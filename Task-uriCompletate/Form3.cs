using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_uriCompletate
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortTime", "HH:mm tt");
            
            var Explorer = Process.GetProcessesByName("explorer");
            foreach (Process ex in Explorer)
            {
                ex.Kill();
            }

            p.StartInfo.FileName = "explorer.exe";
            p.Start();


            regkey.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm tt");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortTime", "HH:mm");
            
            var Explorer = Process.GetProcessesByName("explorer");
            foreach (var ex in Explorer)
            {
                ex.Kill();
            }
            regkey.Close();

            p.StartInfo.FileName = "explorer.exe";
            p.Start();


        }

    }



}
