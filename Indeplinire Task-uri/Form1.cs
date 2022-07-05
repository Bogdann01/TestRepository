using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indeplinire_Task_uri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_tab2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] listadate = System.IO.File.ReadAllLines(@"C:\Users\Victor\Desktop\FisierTask-uri.txt");
        
            label1.Text = listadate[0] + " " + listadate[1];
            label2.Text = listadate[2];
        }
    }
}