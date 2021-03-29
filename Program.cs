using PoEn.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoEn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyCustomApplicationContext());
        }
    }


    public class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        private bool hidden = true;
        Form1 form = new Form1();


        public MyCustomApplicationContext()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Exit", Exit)
            }),
                Visible = true
            };
            //set up double click event
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;
            Application.Exit();
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            if (hidden) // this.WindowState == FormWindowState.Minimized)
            {
                // this.WindowState = FormWindowState.Normal;
                form.Show();
                hidden = false;
            }
            else
            {
                // this.WindowState = FormWindowState.Minimized;
                form.Hide();
                hidden = true;
            }
        }
    }
}
