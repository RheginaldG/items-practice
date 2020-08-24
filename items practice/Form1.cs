using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace items_practice
{
    public partial class Form1 : Form
    {
        public struct Item
        {
            public string itmname { get; set; }
            public string itmPrice { get; set; }
            public string itmStock { get; set; }

            public override string ToString()
            {
                return itmname;
            }
        }
        public struct moove
        {
            public string Name;
            public string Email;
            public string Address;

        }
        List<moove> custdetails = new List<moove>();

        public struct picksmoove
        {
            public string NameOfItem { get; set; }
            public decimal ItemValue { get; set; }
            public decimal ItemNo { get; set; }
        }
        List<picksmoove> moovepick = new List<picksmoove>();


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] line = File.ReadAllLines(@".\TextFile1.txt");
            //foreach (var LINE in line)
            //{
            //    string[] cuts = LINE.Split('|');

            //    string itmnm = cuts[0];
            //    string itmprc = cuts[1];
            //    string itmstck = cuts[2];
            //    Item item = new Item()
            //    {
            //        itmname = itmnm,
            //        itmPrice = itmprc,
            //        itmStock = itmstck
            //    };
            //    comboBox1.Items.Add(item);

            //using (TextReader reader = new StreamReader(@".\TextFile1.txt"))
            //{
            //    string line = null;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        string[] fields = line.Split('|');
            //        string itmnm = fields[0];
            //        string itmprc = fields[1];
            //        string itmstck = fields[2];
            //        Item item = new Item()
            //        {
            //            itmname = itmnm,
            //            itmPrice = itmprc,
            //            itmStock = itmstck
            //        };
            //        comboBox1.Items.Add(item);
            //    }

            //}


            string[] read = File.ReadAllLines(@".\TextFile1.txt");
            foreach (string lr  in read)
            {
                string[] value = lr.Split('|');
                 Item item = new Item()
                {
                    itmname = value[0],
                    itmPrice = value[1],
                    itmStock = value[2]
                };
                comboBox1.Items.Add(item);
               
            }








          

            






            comboBox1.Items.RemoveAt(0);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item carted = (Item)comboBox1.SelectedItem;
            label1.Text = carted.itmPrice.ToString();
            label2.Text = carted.itmStock.ToString();
            numericUpDown1.Maximum = decimal.Parse(carted.itmStock);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string email = textBox2.Text;
            string address = textBox3.Text;

            moove x = new moove
            {
                Name = textBox1.Text,
                Email = email,
                Address = address

            };
            custdetails.Add(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(custdetails,moovepick);
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string r = comboBox1.Text;
            decimal i = numericUpDown1.Value;
            decimal x = decimal.Parse(label1.Text);
            decimal totalprice = x * i;

            picksmoove k = new picksmoove
            {
                NameOfItem = r,
                ItemNo = i,
                ItemValue = totalprice
            };
            moovepick.Add(k);
        }
    }
}
