using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WebRequest_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var http = new HttpClient();
            //var link = new Uri("http://universities.hipolabs.com/search?name=middle");
            //var rez = http.GetAsync(link).Result;
            //var json = rez.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(json);
            //var datejson = JsonConvert.DeserializeObject<unis>(json);

            //foreach (var item in datejson.list)
            //{
            //    var panel = new Panel();
            //    var lbl1 = new Label();
            //    var lbl2 = new Label();
            //    var lbl3 = new Label();

            //    panel1.Controls.Add(panel);
            //    panel.Controls.Add(lbl1);
            //    panel.Controls.Add(lbl2);
            //    panel.Controls.Add(lbl3);

            //    lbl1.AutoSize = true;
            //    lbl1.BackColor = Color.Green;
            //    lbl1.Text = item.name.ToString();

            //    lbl2.AutoSize = true;
            //    lbl2.BackColor = Color.Yellow;
            //    lbl2.Text = item.country.ToString();

            //    lbl3.AutoSize = true;
            //    lbl3.BackColor = Color.Purple;
            //    lbl3.Text = item.alpha_two_code.ToString();

            //    panel.Height = 400;
            //    panel.Width = 400;
            //    panel.BackColor = Color.Blue;
            //    panel.Location = new Point(5, 100);
            //}


        }
    


        public class universitati
        {
            public string name { get; set; }
            public string country { get; set; } 
            public string alpha_two_code { get; set; }
        }

        public class unis
        {
            public List<universitati> list { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
