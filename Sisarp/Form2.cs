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
    public partial class Form2 : Form
    {
        List<string> myList = new List<string>(new string[] { "nume","partener","practica","elev" });

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int top = 5;
            foreach (string element in myList)
            {
                Console.Write($"{element} ");
                Label l = new Label();
                panel1.Controls.Add(l);
                l.Height = 30;
                l.Width = 70;
                l.Left = 5;                
                l.Text = element;
                l.Top = top;
                l.Visible = true;
                top = l.Top + l.Height +10;
                l.ForeColor = Color.Red;
                l.BackColor = Color.Yellow;
                l.Name = element;
                l.Click +=new EventHandler(l_Click);
                
            }
        }
        private void l_Click(object sender, EventArgs e)
        {
            Label l = sender as Label;
            MessageBox.Show(l.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            
        }
    }
}
