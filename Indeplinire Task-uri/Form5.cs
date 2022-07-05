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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_tab2_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Close();

            Form6 f = new Form6();
            f.Show();
        }
    }
}
