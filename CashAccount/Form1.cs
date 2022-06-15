using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccount
{
    public partial class Form1 : Form
    {
        public List<Product> allProducts { get; set; }
        public Form1()
        {
            
        InitializeComponent();
            allProducts = new List<Product>();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddtoBill_Click(object sender, EventArgs e)
        {
            NewProduct ProducttoAdd = new NewProduct();
            ProducttoAdd.ShowDialog();
                DialogResult result = ProducttoAdd.DialogResult;

                if (result == DialogResult.OK)
                {
               
                        lbProduct.Items.Add(ProducttoAdd.products);
                        
                }
        }

        private void btnAddtoBill_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(lbProduct.SelectedItems.Count != -1)
            {
                NewProduct BillList = new NewProduct();
                int index = lbProduct.SelectedIndex;
                
                foreach(Product p in lbProduct.SelectedItems)
                {
                    lbBill.Items.Add(p);
                }

                loadBill();
                lbProduct.Items.RemoveAt(index);
            }
        }

        private void loadBill()
        {
            //max price
            decimal max = 0;
            decimal sum = 0;
            foreach(Product p in lbBill.Items)
            {
                max = max + p.Price;
                sum = sum + p.Price * (numDanok.Value / 100);
            }

            tbSum.Text = $"{max}";

            

            tbAll.Text = $"{sum}";

            numKol.Value = lbBill.Items.Count;
        }

        private void btnRemovefromBill_Click(object sender, EventArgs e)
        {
            if(lbBill.SelectedIndex != -1)
            {
                int index = lbBill.SelectedIndex;
                lbBill.Items.RemoveAt(index);
                loadBill();
            }
        }

        private void lbBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numDanok_Validating(object sender, CancelEventArgs e)
        {
            loadBill();
        }
    }
}
