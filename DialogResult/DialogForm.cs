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
    public partial class DialogForm : Form
    {
        private Product Prod;
        private bool newProduct;
        public DialogForm(Product newProd, bool flag)
        {
            InitializeComponent();
            Prod = newProd;
            newProduct = flag;
            if(!flag)
            {
                button1.Text = "Заменить";
                txb_Name.Text = newProd.Name;
                txb_MadeIn.Text = newProd.MadeIn;
                txb_Price.Text = newProd.Price.ToString();
            }
            else
            {
                txb_Name.Text = string.Empty;
                txb_MadeIn.Text = string.Empty;
                txb_Price.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((txb_Name.Text == string.Empty) || (txb_MadeIn.Text == string.Empty) || (txb_Price.Text == string.Empty)) 
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if(Convert.ToDouble(txb_Price.Text) < 0)
                {
                    MessageBox.Show("Цена не может быть меньше 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Prod.Name = txb_Name.Text;
                Prod.MadeIn = txb_MadeIn.Text;
                Prod.Price = Convert.ToDouble(txb_Price.Text);
            }
            catch 
            {
                MessageBox.Show("Введиет корректную цену!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
