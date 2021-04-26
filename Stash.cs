using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoEn
{
    public partial class Stash : Form
    {
        DataTable Headers = new DataTable();
        public Stash()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvStash, true);
        }

        //obsolete now - grid drawing, used datagridview instead
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int cellSize = 20;
            int numOfCells = 24;
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

        private void DrawGrid(bool quad)
        {
            int stashFieldsCount; //(144 or 576)

            //setup grid, columns and rows
            if (quad == true)
            {
                stashFieldsCount = 576;
            }
            else
            {
                stashFieldsCount = 144;
            }
           
        }

        private void CreateGrid (DataGridView dgv, bool quad, int xWidth, int yWidth)
        {
            Headers.Clear();

            int xCount;
            int yCount;

            if (quad == true) xCount = 24;
            else xCount = 12;

            DataRow dr;
            Headers = new DataTable();
            for (int i = 0; i < xCount; i++)
            {
                Headers.Columns.Add(new DataColumn((i + 1).ToString(), typeof(DataGridViewImageColumnEx)));
            }
            for (int i = 0; i < xCount; i++)
            {
                dr = Headers.NewRow();
                Headers.Rows.Add(dr);
            }
            BindGrid();
            if (quad == true) ResizeGrid(25, 25);
            else ResizeGrid(50, 50);
            //dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //resizing rows needs to be added
        void ResizeGrid(int columnWidth, int rowHeight)
        {
            foreach (DataGridViewColumn column in dgvStash.Columns)
            {
                column.Width = columnWidth;
            }
        }
        void BindGrid()
        {
            InputDataDataGridView(Headers, dgvStash);
            //dgvStash.DataSource = Headers;
            dgvStash.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateGrid(dgvStash, true, 25, 25);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateGrid(dgvStash, false, 25, 25);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        //add numbers to row headers
        private void dgvStash_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, ctl, new object[] { DoubleBuffered });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopulateStashList(GetStashJson(1,1));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PopulateTabs(GetStashJson(1, 1));
        }

        //all index pages contain list of all stash tabs.
        //also had to pass over cookie from browser otherwise reporting error 403, access denied 
        static string GetStashJson(int _tab, int _index)
        {
            string urlTab = @"https://www.pathofexile.com/character-window/get-stash-items?league=Ultimatum&tabs=";
            string urlIndex = @"&tabIndex=";
            string urlAcc = "&accountName=";
            string accountName = Properties.Settings.Default["AccountName"].ToString();
            string sSID = Properties.Settings.Default["SSID"].ToString();

            //build uri and cookie - possibly could be extracted from the browser itself to avoid users to copy and paste
            Uri uri = new Uri(urlTab + _tab + urlIndex + _index + urlAcc + accountName);
            Cookie cookie = new Cookie("POESESSID", sSID);

            //build request
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(uri, cookie);

            string json;
            using (var sr = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                json = sr.ReadToEnd();
            }

            //Root obj = JsonConvert.DeserializeObject<Root>(json);

            return json;
        }

        //added populating tabs here at least for now.
        private void PopulateStashList(string json)
        {
            Root obj = JsonConvert.DeserializeObject<Root>(json);

            //populate stash list and also create tabs in tabControl
            cmbStashList.Items.Clear();
            foreach (var tab in obj.Tabs)
            {
                cmbStashList.Items.Add(tab.N);
            }
            foreach (var item in obj.Items)
            {
                if (item.Name != String.Empty)
                {
                    Console.WriteLine(item.Name);
                }
                else
                {
                    Console.WriteLine(item.BaseType);
                }
            }
        }

        private void PopulateTabs(string json)
        {
            Root obj = JsonConvert.DeserializeObject<Root>(json);

            //populate stash list and also create tabs in tabControl
            //tabMain.TabPages.Clear();
            foreach (var tab in obj.Tabs)
            {
                tabMain.TabPages.Add(tab.N);
            }
            foreach (var item in obj.Items)
            {
                if (item.Name != String.Empty)
                {
                    Console.WriteLine(item.Name);
                }
                else
                {
                    Console.WriteLine(item.BaseType);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Headers.Clear();

            int xCount;
            int yCount;

            DataRow dr;
            Headers = new DataTable();
            for (int i = 0; i < 26; i++)
            {
                Headers.Columns.Add(new DataColumn((i + 1).ToString(), typeof(DataGridViewTextBoxColumnEx)));
            }
            for (int i = 0; i < 26; i++)
            {
                dr = Headers.NewRow();
                Headers.Rows.Add(dr);
            }

            BindGrid();
            ResizeGrid(25, 25);

            PopulateItemsTab(dgvStash, tpMain, GetStashJson(1, 13));
        }

        //fills tab with items, needs exalt value converter or separate counter for chaos and exalt 
        private void PopulateItemsTab(DataGridView dgv, TabPage tp, string json)
        {
            Root obj = JsonConvert.DeserializeObject<Root>(json);
            int itemCounter = 0;
            int priceCounter = 0;
            foreach (var tab in obj.Tabs)
            {
                if (tab.Selected == true)
                {
                    foreach (Item item in obj.Items)
                    {
                        Console.WriteLine(item.Name);
                        itemCounter++;

                        if (item.Note != null)
                        {
                            string extractedItemPrice = new String(item.Note.Where(Char.IsDigit).ToArray());
                            priceCounter += Convert.ToInt32(extractedItemPrice);
                        }

                        //add item to the grid
                        //item.W, item.H
                        //item.X,item.Y

                        var cell = (DataGridViewTextBoxCellEx)dgvStash[item.X, item.Y];
                        cell.Value = item.Icon;
                        cell.ColumnSpan = item.H;
                        cell.RowSpan = item.W;
                    }
                }
            }
            Console.WriteLine("Total items in this tab: " + itemCounter.ToString());
            Console.WriteLine("Total value of item in this tab: " + priceCounter.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cell = (DataGridViewTextBoxCellEx)dgvStash[0, 0];
            cell.ColumnSpan = 3;
            cell.RowSpan = 2;

            cell = (DataGridViewTextBoxCellEx)dgvStash[4, 4];
            cell.ColumnSpan = 1;
            cell.RowSpan = 4;
        }

        private void InputDataDataGridView(DataTable dt, DataGridView dgv)
        {

            foreach (DataColumn col in dt.Columns)//create columns in datagridview for each column in datatable
            {
                //DataGridViewTextBoxColumnEx c = new DataGridViewTextBoxColumnEx();
                DataGridViewTextBoxColumnEx c = new DataGridViewTextBoxColumnEx();
                c.Name = col.ColumnName;
                dgv.Columns.Add(c);
            }

            for (int lin = 0; lin < dt.Rows.Count; lin++)//run all the lines in the datatable
            {
                DataGridViewRow row = new DataGridViewRow();//create a new row
                row.CreateCells(dgv);//Clears the existing cells and sets their template according to the supplied

                for (int col = 0; col < dt.Columns.Count; col++)//run all the columns in the datatable
                {
                    row.Cells[col].Value = dt.Rows[lin][col].ToString();//add the value in the row
                }
                dgv.Rows.Add(row);//add the row in the datagridview
            }
        }

        private void cmbStashList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selected: " + cmbStashList.Text);
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        //defo needs to be moved to a separate file
        public class Colour
        {
            [JsonProperty("r")]
            public int R { get; set; }

            [JsonProperty("g")]
            public int G { get; set; }

            [JsonProperty("b")]
            public int B { get; set; }
        }

        public class Tab
        {
            [JsonProperty("n")]
            public string N { get; set; }

            [JsonProperty("i")]
            public int I { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("selected")]
            public bool Selected { get; set; }

            [JsonProperty("colour")]
            public Colour Colour { get; set; }

            [JsonProperty("srcL")]
            public string SrcL { get; set; }

            [JsonProperty("srcC")]
            public string SrcC { get; set; }

            [JsonProperty("srcR")]
            public string SrcR { get; set; }
        }

        public class Property
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("values")]
            public List<List<object>> Values { get; set; }

            [JsonProperty("displayMode")]
            public int DisplayMode { get; set; }

            [JsonProperty("type")]
            public int Type { get; set; }
        }

        public class Requirement
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("values")]
            public List<List<object>> Values { get; set; }

            [JsonProperty("displayMode")]
            public int DisplayMode { get; set; }
        }

        public class Socket
        {
            [JsonProperty("group")]
            public int Group { get; set; }

            [JsonProperty("attr")]
            public string Attr { get; set; }

            [JsonProperty("sColour")]
            public string SColour { get; set; }
        }

        public class Item
        {
            [JsonProperty("verified")]
            public bool Verified { get; set; }

            [JsonProperty("w")]
            public int W { get; set; }

            [JsonProperty("h")]
            public int H { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }

            [JsonProperty("league")]
            public string League { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("typeLine")]
            public string TypeLine { get; set; }

            [JsonProperty("baseType")]
            public string BaseType { get; set; }

            [JsonProperty("identified")]
            public bool Identified { get; set; }

            [JsonProperty("itemLevel")]
            public int ItemLevel { get; set; }

            [JsonProperty("ilvl")]
            public int Ilvl { get; set; }

            [JsonProperty("note")]
            public string Note { get; set; }

            [JsonProperty("properties")]
            public List<Property> Properties { get; set; }

            [JsonProperty("explicitMods")]
            public List<string> ExplicitMods { get; set; }

            [JsonProperty("descrText")]
            public string DescrText { get; set; }

            [JsonProperty("frameType")]
            public int FrameType { get; set; }

            [JsonProperty("x")]
            public int X { get; set; }

            [JsonProperty("y")]
            public int Y { get; set; }

            [JsonProperty("inventoryId")]
            public string InventoryId { get; set; }

            [JsonProperty("requirements")]
            public List<Requirement> Requirements { get; set; }

            [JsonProperty("implicitMods")]
            public List<string> ImplicitMods { get; set; }

            [JsonProperty("flavourText")]
            public List<string> FlavourText { get; set; }

            [JsonProperty("sockets")]
            public List<Socket> Sockets { get; set; }

            [JsonProperty("socketedItems")]
            public List<object> SocketedItems { get; set; }

            [JsonProperty("utilityMods")]
            public List<string> UtilityMods { get; set; }

            [JsonProperty("craftedMods")]
            public List<string> CraftedMods { get; set; }

            [JsonProperty("enchantMods")]
            public List<string> EnchantMods { get; set; }
        }

        public class Root
        {
            [JsonProperty("numTabs")]
            public int NumTabs { get; set; }

            [JsonProperty("tabs")]
            public List<Tab> Tabs { get; set; }

            [JsonProperty("items")]
            public List<Item> Items { get; set; }
        }

        //download image - needs cache as for now it downloads image very time 
        private static Image StreamImage(string url)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(url);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }

        private void RenderImages(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewImageCellEx cell =  row.Cells[0] as DataGridViewImageCellEx;

                if (cell.Value != null)
                cell.Value = (System.Drawing.Image)Properties.Resources.mok__icon;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RenderImages(dgvStash);
        }

        private void dgvStash_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            foreach (DataGridViewRow row in dgvStash.Rows)
            {
                if ((!row.IsNewRow) && (row.Cells[0].Value != "") && (row.Cells[0].Value != null))
                    row.Cells[0].Value = StreamImage(row.Cells[0].Value.ToString());
                else
                    row.Cells[0].Value = null;
            }
        }
    }
}
