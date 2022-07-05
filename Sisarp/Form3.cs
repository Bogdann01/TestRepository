using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sisarp
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();

            int top = 5;
            foreach (Process theprocess in processlist)
            {
                //Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
                Console.Write($"{theprocess.ProcessName} ");
                Label l2 = new Label();
                panel1.Controls.Add(l2);
                l2.Height = 40;
                l2.Width = 200;
                l2.Left = 10;
                l2.Text = theprocess.ProcessName;
                l2.Top = top;
                l2.Visible = true;
                top = l2.Top + l2.Height + 20;
                l2.Name = theprocess.ProcessName;
                EventHandler p = (s, x) =>
                {
                    theprocess.Kill();
                };
                l2.Click += p;
            }
        }
    }
}
