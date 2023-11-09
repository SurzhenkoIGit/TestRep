using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogResult
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();
       
        private int Sum;
        public Form1()
        {
            InitializeComponent();
            Sum = 0;
            listView1.View = View.Details;
            listView1.Columns.Add("Название", 185, HorizontalAlignment.Left);
            listView1.Columns.Add("Производитель", 185, HorizontalAlignment.Left);
            listView1.Columns.Add("Цена (руб)", 100, HorizontalAlignment.Left);
        }

        private void btn_AddProd_Click(object sender, EventArgs e)
        {
            if (cb_Have.SelectedIndex == -1)
            {
                return;
            }

            listView1.Items.Add(products[cb_Have.SelectedIndex].Price.ToString());
            Sum += (int)products[cb_Have.SelectedIndex].Price;
            lbl_Sum.Text = Sum.ToString();
            
        }


        private void btn_ChangeProd_Click(object sender, EventArgs e)
        {
            if (cb_Have.SelectedIndex == -1)
            {
                return;
            }
            DialogForm df = new DialogForm(products[cb_Have.SelectedIndex], false);
            int index = cb_Have.SelectedIndex;
            if(df.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cb_Have.Items.RemoveAt(index);
                cb_Have.Items.Insert(index, products[index].Name);
                cb_Have.SelectedIndex = index;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Prod_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ListViewItem items = null;
            Product prod = new Product();
            DialogForm df = new DialogForm(prod, true);
            if(df.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                items = new ListViewItem();
                items.Text = prod.Name;
                items.SubItems.Add(prod.MadeIn);
                items.SubItems.Add(prod.Price.ToString());
                listView1.Items.Add(items);
                cb_Have.Items.Add(prod.Name);
                products.Add(prod);
            }
        }
    }
}
