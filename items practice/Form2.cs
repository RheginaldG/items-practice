using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace items_practice
{
    public partial class Form2 : Form
    {
        public Form2(List<Form1.moove> x,List<Form1.picksmoove> y)
        {
            InitializeComponent();

            foreach (Form1.moove s in x)
            {
                label1.Text = s.Name;
                label2.Text = s.Email;
                label3.Text = s.Address;


            }
            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Item";
            col1.Name = "ItemName";
            
            dataGridView1.Columns.Add(col1);


            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Num Required";
            col2.Name = "Quantity";
           
            dataGridView1.Columns.Add(col2);

            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Total Price";
            col3.Name = "Price";
            
            dataGridView1.Columns.Add(col3);

            foreach (Form1.picksmoove picksmoove in y)
            {
                dataGridView1.Rows.Add(picksmoove.NameOfItem, picksmoove.ItemNo, picksmoove.ItemValue);
            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
