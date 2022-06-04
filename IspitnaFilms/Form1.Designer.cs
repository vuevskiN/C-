
namespace IspitnaFilms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFilm = new System.Windows.Forms.ListBox();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.btnRemoveRating = new System.Windows.Forms.Button();
            this.numrating = new System.Windows.Forms.NumericUpDown();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRatings = new System.Windows.Forms.ListBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numrating)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFilm
            // 
            this.lbFilm.FormattingEnabled = true;
            this.lbFilm.ItemHeight = 20;
            this.lbFilm.Location = new System.Drawing.Point(31, 37);
            this.lbFilm.Name = "lbFilm";
            this.lbFilm.Size = new System.Drawing.Size(263, 224);
            this.lbFilm.TabIndex = 0;
            this.lbFilm.SelectedIndexChanged += new System.EventHandler(this.lbFilm_SelectedIndexChanged);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(31, 324);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(153, 29);
            this.btnAddFilm.TabIndex = 1;
            this.btnAddFilm.Text = "Додади Филм";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // btnRemoveRating
            // 
            this.btnRemoveRating.Location = new System.Drawing.Point(31, 382);
            this.btnRemoveRating.Name = "btnRemoveRating";
            this.btnRemoveRating.Size = new System.Drawing.Size(153, 29);
            this.btnRemoveRating.TabIndex = 2;
            this.btnRemoveRating.Text = "Избриши Рејтинг";
            this.btnRemoveRating.UseVisualStyleBackColor = true;
            this.btnRemoveRating.Click += new System.EventHandler(this.btnRemoveRating_Click);
            // 
            // numrating
            // 
            this.numrating.Location = new System.Drawing.Point(458, 47);
            this.numrating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numrating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numrating.Name = "numrating";
            this.numrating.Size = new System.Drawing.Size(150, 27);
            this.numrating.TabIndex = 3;
            this.numrating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnAddRating
            // 
            this.btnAddRating.Location = new System.Drawing.Point(458, 94);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(180, 29);
            this.btnAddRating.TabIndex = 4;
            this.btnAddRating.Text = "Додади Рејтинг";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(458, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(458, 382);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 27);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(458, 441);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 27);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Информации за селектираниот текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Година";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Филм со најголем просечен рејтинг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Филм со најмногу рејтинзи";
            // 
            // lbRatings
            // 
            this.lbRatings.BackColor = System.Drawing.SystemColors.Menu;
            this.lbRatings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRatings.FormattingEnabled = true;
            this.lbRatings.ItemHeight = 20;
            this.lbRatings.Location = new System.Drawing.Point(477, 161);
            this.lbRatings.Name = "lbRatings";
            this.lbRatings.Size = new System.Drawing.Size(267, 140);
            this.lbRatings.TabIndex = 12;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(421, 161);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(50, 20);
            this.labelRating.TabIndex = 13;
            this.labelRating.Text = "label5";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 461);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(263, 29);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.TabIndexChanged += new System.EventHandler(this.progressBar1_TabIndexChanged);
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            this.progressBar1.Validating += new System.ComponentModel.CancelEventHandler(this.progressBar1_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 502);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.lbRatings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.numrating);
            this.Controls.Add(this.btnRemoveRating);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.lbFilm);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numrating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFilm;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.Button btnRemoveRating;
        private System.Windows.Forms.NumericUpDown numrating;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbRatings;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

