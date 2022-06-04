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
    public partial class Form1 : Form
    {
        public List<Film> mostRatings { get; set; }
        public Form1()
        {
            InitializeComponent();
            mostRatings = new List<Film>();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            AddFilm newFilm = new AddFilm();
            newFilm.ShowDialog();

            if(newFilm.DialogResult == DialogResult.OK)
            {
                lbFilm.Items.Add(newFilm.films);
            }
        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
           if(lbFilm.SelectedIndex != -1)
            {
                Film newFilm = new Film();
                newFilm = lbFilm.SelectedItem as Film;
                Rating newRating = new Rating();
                newRating.rating = numrating.Value;
                newFilm.ratings.Add(newRating);
                lbRatings.Items.Add(newRating);
                loadRatings();
            }
        }

        private void loadRatings()
        {
            
            lbRatings.Items.Clear();
            Film selectedFilm = lbFilm.SelectedItem as Film;
            int numberRatings = 0;
            int averageRating = 0;

            mostRatings.Add(selectedFilm);
            
            foreach(Rating r in selectedFilm.ratings)
            {
                lbRatings.Items.Add(r);
                averageRating = averageRating + (int)r.rating;
                numberRatings++;
            }

            Film max = lbFilm.Items[0] as Film;


            foreach(Film f in lbFilm.Items)
            {
                if(f.ratings.Count > max.ratings.Count)
                {
                    max = f;
                }
            }
          
            if(lbFilm.SelectedIndex != -1)
            {
                textBox3.Text = $"{max.Name}";
            }

            else
            {
                textBox3.Text = $"Нема најголем рејтинг!";
            }

            labelRating.Text = $"Име:{selectedFilm.Name}\nБрој рејтинзи:{numberRatings}\n";
           
            if(numberRatings > 0)
            {
                labelRating.Text += $"Просечен рејтинг:{Convert.ToString(averageRating / numberRatings)}\n";
                
                
            }

            progressBar1.Value = progressBar1.Value + 1;
        }

        

        private void btnRemoveRating_Click(object sender, EventArgs e)
        {
            
            if(lbFilm.SelectedIndex != -1)
            {
                if(MessageBox.Show("Сигурен ли си?","Сигурен си?",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    lbRatings.Items.RemoveAt(lbRatings.Items.Count - 1);
                    Film removed = lbFilm.SelectedItem as Film;
                    removed.ratings.RemoveAt(removed.ratings.Count - 1);

                   

                    loadRatings();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            loadRatings();

        }

        private void lbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadRatings();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Validating(object sender, CancelEventArgs e)
        {
            loadRatings();
            progressBar1.Maximum = 5;

            
        }

        private void progressBar1_TabIndexChanged(object sender, EventArgs e)
        {
            loadRatings();

            if(progressBar1.Value >= 5)
            {
                MessageBox.Show("Value is higher than five!");
            }
        }
    }
}
