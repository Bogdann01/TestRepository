using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeNenorocit_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //DateTime dateNow = DateTime.Now;
            //label2.Text = dateNow.ToString("HH:mm ");
            label2.Text = $"{Thread.CurrentThread.ManagedThreadId}{DateTime.Now:HH:mm}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Control Panel\International");
            reg.SetValue("sShortDate", "M/d/yyyy");
            reg.SetValue("sLongDate", "M/d/yyyy");
        }
    }
}