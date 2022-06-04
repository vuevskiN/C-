using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IspitnaFilms
{
    public partial class AddFilm : Form
    {
        public Film films { get; set; }
        public AddFilm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            films = new Film(tbName.Text, Convert.ToInt32(tbYear.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Мора да се внесе име!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(tbYear.Text) >= 2023)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbYear, "Внесената година е не валидна!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbYear, null);
            }
        }
    }
}
