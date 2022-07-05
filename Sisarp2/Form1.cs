using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisarp2
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

        private void tmr1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.lbl1.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.lbl1.Text = DateTime.Now.ToString("MMM-dd-yyyy");
        }
    }
}
