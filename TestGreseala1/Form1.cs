using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TestGreseala1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var http = new HttpClient();
            var link = new Uri("http://universities.hipolabs.com/search");
            var rezultat = http.GetAsync(link).Result;
            var json = rezultat.Content.ReadAsStringAsync().Result;
            Console.WriteLine(json);
            var datajson = JsonConvert.DeserializeObject<Uni>(json);

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (var item in datajson.lista)
            {
                var Panel = new Panel();
                var lbl1 = new Label();
                var lbl2 = new Label();
                var lbl3 = new Label();

                panel1.Controls.Add(Panel);
                Panel.Controls.Add(lbl1);
                Panel.Controls.Add(lbl2);
                Panel.Controls.Add(lbl3);

                lbl1.AutoSize = true;
                lbl1.BackColor = Color.Green;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                lbl1.Text = item.name.ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                lbl2.AutoSize = true;
                lbl2.BackColor = Color.Purple;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                lbl2.Text = item.country.ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                lbl3.AutoSize = true;
                lbl3.BackColor = Color.Red;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                lbl3.Text = item.alpha_two_code.ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                Panel.Height = 500;
                Panel.Width = 500;
                Panel.BackColor = Color.Yellow;
                Panel.Location = new Point(0, 100);
                //button1.Visible = true;



#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }
        [JsonArray]
        private class Universitati
        {
            public string? name { get; set; }

            public string? country { get; set; }

            public string? alpha_two_code { get; set; }
        }
        [JsonArray]
        private class Uni
        {
            public List<Universitati>? lista { get; set; }
        }
    }
}