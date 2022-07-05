using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisarp
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

        private void btn_cv_Click(object sender, EventArgs e)
        {
            lbl_scris.Text = "Ceva";
        }

        private void btn_altcv_Click(object sender, EventArgs e)
        {
            lbl_scris.Text = "Altceva";
        }

        private void btn_aparitie_Click(object sender, EventArgs e)
        {
            if(btn_altcv.Visible == false && btn_cv.Visible == false)
            {
                btn_cv.Visible = true;
                btn_altcv.Visible = true;
                button1.Visible = true;
            }
            else
            {
                btn_altcv.Visible = false;
                btn_cv.Visible = false;
                button1.Visible = false;
            }
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj la alegere.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.ShowDialog();    
        }
    }
}
