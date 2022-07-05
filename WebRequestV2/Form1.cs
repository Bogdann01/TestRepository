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


namespace WebRequestV2
{
    

    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //var client = new HttpClient();
            //var ep = new Uri("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita");
            //var res = client.GetAsync(ep).Result;
            //var json = res.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(json);
            //var jsonData = JsonConvert.DeserializeObject<Drk>(json);
            ////label1.Text = jsonData.drinks[0].ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new System.Net.Http.HttpClient();
            var ep = new Uri("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita");
            var res = client.GetAsync(ep).Result;
            var json = res.Content.ReadAsStringAsync().Result;
            Console.WriteLine(json);
            var jsonData = JsonConvert.DeserializeObject<Drk>(json);

            int distance = 0;

            foreach (var item in jsonData.drinks)
            {
                var panel = new Panel();
                var lbl1 = new Label();
                var lbl2 = new Label();
                var pctr1 = new PictureBox();
                panel1.Controls.Add(panel);
                panel.Controls.Add(lbl1);
                panel.Controls.Add(lbl2);
                panel.Controls.Add(pctr1);

                lbl1.Width = 150;
                lbl1.Height = 50;
                lbl1.Left = 10;
                lbl1.BackColor = Color.Green;
                lbl1.Text = item.strDrink.ToString();
                

                lbl2.Width = 30;
                lbl2.Height = 50;
                lbl2.Left = 10;
                lbl2.BackColor = Color.Blue;
                lbl2.Text = item.strCategory.ToString();

                pctr1.Size = new Size(150, 150);               
                pctr1.Load(item.strDrinkThumb.ToString());
                pctr1.Location = new Point(10, 50);
                pctr1.SizeMode = PictureBoxSizeMode.StretchImage;

                panel.Height = 500;
                panel.Width = 500;
                panel.BackColor = Color.AntiqueWhite;
                panel.Location = new Point(0, 100);
                distance = distance + 250;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f= new Form2();
            f.Show();
        }
    }
    public class Drink
    {
        public string idDrink { get; set; }
        public string strDrink { get; set; }
        public string strCategory { get; set; }

        public string strDrinkThumb { get; set; }
    }
    public class Drk
    {
        public List<Drink> drinks { get; set; }
    }
}
