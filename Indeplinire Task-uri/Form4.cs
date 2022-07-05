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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_tab2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Close();

            Form5 f = new Form5();
            f.Show();
        }
    }
}
