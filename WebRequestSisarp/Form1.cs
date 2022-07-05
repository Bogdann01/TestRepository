using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebRequestSisarp
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

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            using (client) ;
            {
                var URI = new Uri("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita");
                var result = client.GetAsync(URI).Result;
                var json= result.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
