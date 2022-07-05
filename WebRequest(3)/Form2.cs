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

namespace WebRequest_3_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortTime", "HH:mm tt");
            regkey.Close();

            var Explorer = Process.GetProcessesByName("explorer");
            foreach (var ex in Explorer)
            {
                ex.Kill();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm tt");
            Thread t = Thread.CurrentThread;
            t.Name = "Form thread";
            label2.Text = t.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortTime", "HH:mm");
            regkey.Close();

            var Explorer = Process.GetProcessesByName("explorer");
            foreach (var ex in Explorer)
            {
                ex.Kill();
            }
        }
    }
}
