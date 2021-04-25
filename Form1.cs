using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using Microsoft.Win32;
using Newtonsoft.Json;
using PoEn.Properties;
using Message = FirebaseAdmin.Messaging.Message;

namespace PoEn
{
    public partial class Form1 : Form
    {
        string appPath = Application.StartupPath;
        const string logFile = "\\log.txt";
        const string clientFile = "logs\\Client.txt";
        bool ThreadActive = false;
        int currentTradeRecordsInFile = 0;
        string deviceToken = String.Empty;


        public Form1()
        {
            InitializeComponent();
            InitialSetup();
            LoadSettings();
            chkDoubleBuffered.Checked = true;
            this.Icon = Resources.AppIcon;

            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(Application.StartupPath + @"\credentials.json"),
            });
        }

        private string CheckRegistryKey()
        {
            // The name of the key must include a valid root.
            const string userRoot = "HKEY_CURRENT_USER";
            const string subPath = "Software\\GrindingGearGames\\Path of Exile";
            const string keyName = userRoot + "\\" + subPath;

            // Your default value is returned if the name/asdvalue pair does not exist.
            string key = (string)Registry.GetValue(keyName, "InstallLocation", "No path has been found.");
            return key;
        }

        //Initial setup, checking if files exist and if not create where nesescary 
        private void InitialSetup()
        {
            if (!File.Exists(appPath + logFile))
            {
                try
                {
                    using (File.Create(appPath + logFile, 1024, FileOptions.None))
                    Console.WriteLine("Creating new log file.");
                }
                catch (Exception e)
                {
                    ShowErrorMessage(e.Message);
                }
            }

            //Some initial checks - move to appr function
            if (CheckRegistryKey() == "No path has been found.")
            {
                ShowErrorMessage("Game directory has not been found, please select installtion path manualy.");
                LogErrorMessage("Failed to obtain game directory from system registry, requesitng manual input.");
            }
            else
            {
                txtInstallationPath.Text = CheckRegistryKey();
            }

            //Set-up client watcher
            fileSystemWatcher1.Path = txtInstallationPath.Text + "logs";

            //check default option on the checkbox list
            int index = chkOptionsList.Items.IndexOf("Trade Requests");
            chkOptionsList.SetItemChecked(index, true);

            //disable stop thread button at start but only if background worker isnt running.
            if (ThreadActive == false)
            {
                btnStopThread.Enabled = false;
            }
        }

        //Show and log error messages
        private void ShowErrorMessage(string errorMsg)
        {
            MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            LogErrorMessage(errorMsg);
        }

        private void LogErrorMessage(string errorMsg)
        {
            File.AppendAllText(appPath + logFile, DateTime.Now.ToString() + " - " + errorMsg + Environment.NewLine);
            Console.WriteLine("Logged an error - " + errorMsg);
        }

        private void ReadFile(string pathToFile, bool skipLines)
        {
            Console.WriteLine("Preparing to read file: " + pathToFile + " SkipLines: " + skipLines);
            //disable triggering button to avoid weird stuff
            btnTest.Enabled = false;
            long linesToSkip;
            
            //check if we skipping lines
            //if skipping establish how many we need to omit
            if (skipLines == true)
            {
                //linesToSkip = CountLinesReader(txtInstallationPath.Text + "\\logs\\Client.txt");
                linesToSkip = CountSpecifficBlocks("Trade Requests")-6; //offseting to display only 5 items
                Console.WriteLine("Lines to skip: " + (linesToSkip).ToString() + " of total " + linesToSkip.ToString()); //displaying just one recent line for threading
            }
            else
            {
                linesToSkip = 0;
                Console.WriteLine("No lines to skip");
            }

            //reset and set all the counters
            int totalCounter = 0;
            int vulkanCounter = 0;
            int startupCounter = 0;
            int deviceCounter = 0;
            int locationCounter = 0;
            int connectionCounter = 0;
            int outboundMessageCounter = 0;
            int inboundMessageCounter = 0;
            int tradeRequestsCounter = 0;

            //beep!
            int newAmountofBlock = CountSpecifficBlocks("Trade Requests");
            if (currentTradeRecordsInFile < newAmountofBlock)
            {
                PlaySound();
            }
            int tradeLoopCounter = 0;
            Application.DoEvents();

            //Loop through all checked items on the list and populate data grid
            foreach (string item in chkOptionsList.CheckedItems)
            {
                Console.WriteLine("Processing: " + item.ToString());
                //opening file in read only mode, otherwise POE holds it locked nad we are unable to read
                //var fs = new FileStream(pathToFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                foreach (string line in ReadLines(pathToFile, 0)) //remove substraciton later, filtering to less data for debuging 
                {
                    //filtering rows for system informations, chat data etc.
                    if (line != null)
                    {
                        //trade requests
                        if ((line.Contains("@From")) && (line.Contains("Hi, I would like to") && (item.Contains("Trade Requests"))))
                        {
                            if (tradeRequestsCounter > linesToSkip)
                            {
                                //setting up some strings to hold split data
                                string date = String.Empty;
                                string messageType = String.Empty;
                                string price = String.Empty;
                                string currency = String.Empty;
                                string itemR = String.Empty;
                                string leagueType = String.Empty;
                                string possitionY = String.Empty;
                                string possitionX = String.Empty;

                                //do some processing and split string into subs
                                Console.WriteLine($"Processing Sub");

                                //Splitting string into two parts (System data and after price data, easier than breaking it down with regular expressions also faster to execute).
                                //Using one word before the price to have nice first 3 records in array as price, currency and name of the league
                                string[] firstSubs = line.Split(new string[] { "for" }, StringSplitOptions.None);
                                string[] secondSubs = firstSubs[0].Split(new string[] { "@" }, StringSplitOptions.None);
                                string[] secondSubsDateSplit = secondSubs[0].Split(' ');
                                string[] secondSubsTypeSplit = secondSubs[1].Split(' ');
                                string[] secondSubsItemSplit = secondSubs[1].Split(new string[] { "your" }, StringSplitOptions.None); //possible to extract nick and clan name
                                string[] priceSubs = firstSubs[1].Split(' ');

                                //FIRST part of breakdown:
                                date = secondSubsDateSplit[0] + " " + secondSubsDateSplit[1];
                                messageType = "@" + secondSubsTypeSplit[0];
                                string[] subs = secondSubs[0].Split(' ');
                                itemR = secondSubsItemSplit[1].Replace("listed", "");
                                price = priceSubs[1];
                                currency = priceSubs[2];

                                //getting last 4 records of priceSubs to get item possition
                                possitionY = priceSubs[priceSubs.Length-1];
                                possitionX = priceSubs[priceSubs.Length-3];

                                int posX = Convert.ToInt32(possitionX.Replace(",", ""));
                                int posY = Convert.ToInt32(possitionY.Replace(")", ""));


                                int rowId = dgvMain.Rows.Add();

                                // Grab the new row!
                                DataGridViewRow row = dgvMain.Rows[rowId];

                                // Add the data to datagrid
                                row.Cells["ID"].Value = tradeRequestsCounter.ToString();
                                row.Cells["Date"].Value = date;
                                row.Cells["Type"].Value = messageType;
                                row.Cells["Item"].Value = itemR;
                                row.Cells["Price"].Value = price;
                                row.Cells["Currency"].Value = currency;
                                row.Cells["PossitionTop"].Value = posY.ToString();
                                row.Cells["PossitionLeft"].Value = posX.ToString();

                                Console.WriteLine("Subs count: " + subs.Length.ToString());

                                //send fb msg
                                Application.DoEvents();

                                //this needs to be linked to something other than hardset integer...right now amount of displayed rows is 6 so 6 is there for a reason as we're recounting actions not actual records being processed
                                if (tradeLoopCounter == 4)
                                {
                                    if (chkPlaySound.Checked == true)
                                    {
                                        PlaySound();
                                    }

                                    //sending out fb msg, fix date parsing issue 
                                    SendToTokenAsync(txtDeviceToken.Text, "Trade request", @"N\A", itemR, Convert.ToInt32(price), DateTime.Now, currency, posX, posY);

                                    //copy item name to the clipboard
                                    Clipboard.SetText(itemR);

                                }

                                Console.WriteLine("Processing " + tradeLoopCounter.ToString() + "trade request");
                                tradeLoopCounter++;
                                Application.DoEvents();
                            }
                            tradeRequestsCounter++;
                            //Console.WriteLine(tradeRequestsCounter.ToString());
                            Application.DoEvents();
                        }
                        //incomming messages
                        if ((line.Contains("@From")) && (item.Contains("Incoming Messages")))
                        {
                            dgvMain.Rows.Add(line);
                            inboundMessageCounter++;
                            Application.DoEvents();
                        }
                        //outgoing messages
                        if ((line.Contains("@To")) && (item.Contains("Outgoing Messages")))
                        {
                            dgvMain.Rows.Add(line);
                            outboundMessageCounter++;
                            Application.DoEvents();
                        }
                        //System Info
                        if ((line.Contains("[VULKAN]")) && (item.Contains("Vulkan Messages")))
                        {
                            dgvMain.Rows.Add(line);
                            vulkanCounter++;
                            Application.DoEvents();
                        }
                        //Location and coneciton info
                        if ((line.Contains("[STARTUP]")) && (item.Contains("Startup Messages")))
                        {
                            dgvMain.Rows.Add(line);
                            startupCounter++;
                            Application.DoEvents();
                        }
                        //device info
                        if ((line.Contains("[DEVICE]")) && (item.Contains("Device Messages")))
                        {
                            dgvMain.Rows.Add(line);
                            deviceCounter++;
                            Application.DoEvents();
                        }
                        //location info
                        if ((line.Contains("You have entered")) && (item.Contains("Location Messages")))
                        {
                            dgvMain.Rows.Add(line);
                            locationCounter++;
                            Application.DoEvents();
                        }
                        //conneciton info
                        if ((line.Contains("Connecting to instance")) && (item.Contains("Connection Messages")))
                        {
                            dgvMain.Rows.Add(line);
                            connectionCounter++;
                            Application.DoEvents();
                        }
                        //System.Console.WriteLine(line);
                        totalCounter++;
                        Application.DoEvents();
                    }
                    Application.DoEvents();
                }
                Application.DoEvents();
            }
            Console.WriteLine("There were {0} lines processed.", totalCounter);
            //re-enable trigger button
            btnTest.Enabled = true;

            //remember number of items for further operations
            //test
            currentTradeRecordsInFile = CountSpecifficBlocks("Trade Requests");
            Console.WriteLine("Current Trade rows in memory: " + currentTradeRecordsInFile.ToString());
            dgvMain.Sort(dgvMain.Columns[1], ListSortDirection.Descending);
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(this.SingleByteReadThread);
            ThreadActive = true;
            newThread.Start();
            btnStartThread.Enabled = false;
            btnStopThread.Enabled = true;
        }

        //static method to use line skiping without need to use filestream
        public static IEnumerable<string> ReadLines(string path, long howManyLines)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 0x1000, FileOptions.SequentialScan))
            using (var sr = new StreamReader(fs, Encoding.UTF8))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i <= howManyLines)
                    {
                        yield return null;
                    }
                    else
                    {
                        yield return line;
                    }
                    i++;
                }
            }
        }

        //Reading one byte of the files to compensate for crappy design of FSW and windows not firing events.
        private void SingleByteReadThread(object notUsed)
        {
            while (ThreadActive == true)
            {
                using (FileStream fs = new FileStream(txtInstallationPath.Text + "\\logs\\Client.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        fs.ReadByte();

                Thread.Sleep(TimeSpan.FromMilliseconds(500));
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Value.ToString().Contains("@From"))
                {
                    dgvMain.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                }
                if (e.Value.ToString().Contains("@To"))
                {
                    dgvMain.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGreen;
                }
            }
        }


        //triggering actions when changes in client file are detected.
        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            Console.WriteLine($"Client Changed: {e.FullPath}");

            //trigger button1 processing of 1 line while skipping all the others
            dgvMain.Rows.Clear();
            if (chkIgnoreHistoricalData.Checked == true)
            {
                ReadFile(txtInstallationPath.Text + "\\logs\\Client.txt", true);
            }
            else
            {
                ReadFile(txtInstallationPath.Text + "\\logs\\Client.txt", false);
            }

            //flash window to get attention, this needs to be triggered differently in the future, possibly after adding new row to the data grid so maybe an aciton there
            if (chkFlashWindow.Checked == true) FlashWindow.Tray(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(CountSpecifficBlocks("Trade Requests").ToString());
            Stash stash = new Stash();
            stash.ShowDialog();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            //test
            currentTradeRecordsInFile = CountSpecifficBlocks("Trade Requests");

            dgvMain.Rows.Clear();
            if (chkIgnoreHistoricalData.Checked == true)
            {
                ReadFile(txtInstallationPath.Text + "\\logs\\Client.txt", true);
            }
            else
            {
                ReadFile(txtInstallationPath.Text + "\\logs\\Client.txt", false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThreadActive = false;
            btnStartThread.Enabled = true;
        }

        //counting lines in files
        private long CountLinesReader(string pathToFile)
        {
            int lineCounter = 0;
            string line;

            //opening file in read only mode, otherwise POE holds it locked nad we are unable to read
            var fs = new FileStream(pathToFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            System.IO.StreamReader file = new System.IO.StreamReader(fs);

            while ((line = file.ReadLine()) != null)
            {
                lineCounter++;
            }
            return lineCounter;
        }

        //make a list of blocks later, maybe a switch statement
        private int CountSpecifficBlocks(string blockName)
        {
            int counter = 0;
            foreach (string line in ReadLines(txtInstallationPath.Text + "\\logs\\Client.txt",0)) //remove substraciton later, filtering to less data for debuging 
            {
                //filtering rows for system informations, chat data etc.
                if (line != null)
                {
                    //trade requests
                    if ((line.Contains("@From")) && (line.Contains("Hi, I would like to") && (blockName == "Trade Requests")))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        //can be used to count trades etc 
        private void button3_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(CountSpecifficBlocks("Trade Requests").ToString());
            //SendToTokenAsync(txtDeviceToken.Text, "action1", "stash1", "item1", "currency", DateTime.Now, 10, 31, 12);
        }

        public class MessageData
        {
            public DateTime Timestamp { get; set; }
            public string Action { get; set; }
            public string Stash { get; set; }
            public string Item { get; set; }
            public string Price { get; set; }
            public string PosY { get; set; }
            public string PosX { get; set; }
        }

        internal static async Task SendToTokenAsync(string registrationToken, string action, string stash, string item, int price, DateTime datetime, string currency, int posX, int posY)
        {
            var message = new Message()
            {
                Data = new Dictionary<string, string>()
                {
                    { "Action", action },
                    { "Stash", stash },
                    { "Item", item },
                    { "Timestamp", datetime.ToString() },
                    { "Price", price.ToString() },
                    { "PosX", posX.ToString() },
                    { "PosY", posY.ToString() },
                },
                Notification = new Notification()
                {
                    Title = "PoEn Notification",
                    Body = "New trade request for item: " + item + ", price: " + price,
                },
                Token = registrationToken,
            };
            string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);
            // Response is a message ID string.
            Console.WriteLine("Successfully sent message: " + response);
        }

        //TOPMST window for debuging while in the game
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        private const UInt32 BOTTOM_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        private void alwaysOnTopToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysOnTopToolStripMenuItem.Checked == true)
            {
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }
            else
            {
                SetWindowPos(this.Handle, HWND_BOTTOM, 0, 0, 0, 0, BOTTOM_FLAGS);
            }
        }

        //preplay the alarm
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlaySound();
        }
    
        //temporary procedure to be replaced
        public void PlaySound()
        {
            System.IO.Stream str = Properties.Resources.beep_01;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        //save some settings and dispose of icon on form closing event
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["ClientsPath"] = txtInstallationPath.Text;
            Properties.Settings.Default["DeviceToken"] = txtDeviceToken.Text;
            Properties.Settings.Default["AccountName"] = txtAccountName.Text;
            Properties.Settings.Default["SSID"] = txtSSID.Text;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            txtInstallationPath.Text = Properties.Settings.Default["ClientsPath"].ToString();
            txtDeviceToken.Text = Properties.Settings.Default["DeviceToken"].ToString();
            txtAccountName.Text = Properties.Settings.Default["AccountName"].ToString();
            txtSSID.Text = Properties.Settings.Default["SSID"].ToString();

            deviceToken = Properties.Settings.Default["DeviceToken"].ToString();
        }

        //draw a grid to show estimated item location
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int cellSize = 10;
            int numOfCells = 48;
            Pen blackPen = new Pen(Color.Black, 3);
            
            for (int y = 0; y < numOfCells; ++y)
            {
                e.Graphics.DrawLine(blackPen, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                e.Graphics.DrawLine(blackPen, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoubleBuffered.Checked == true)
            {
                SetDoubleBuffer(dgvMain, true);
            }
            else
            {
                SetDoubleBuffer(dgvMain, false);
            }
        }

        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, ctl, new object[] { DoubleBuffered });
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (System.Windows.Forms.FolderBrowserDialog selectFolderDialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                // Show the FolderBrowserDialog.
                DialogResult result = selectFolderDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtInstallationPath.Text = selectFolderDialog.SelectedPath + @"\";
                }
            }
        }

        private void projectWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/users/wajrak/projects/1");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.patreon.com/wajbox");
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/wajrak/PoEn/issues");
        }

        //show stash location on selected item
    }
}
