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
    public partial class NewProduct : Form
    {
        public Product products { get; set; }
        
        public NewProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            products = new Product((int)numCode.Value, tbName.Text, numPrice.Value);
            
            this.DialogResult = DialogResult.OK;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Мора да постои име!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbName, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void numCode_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
