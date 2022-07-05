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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_tab2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Close();
            Form4 f = new Form4();
            f.Show();
        }
    }
}
