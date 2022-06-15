
namespace CashAccount
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
            this.components = new System.ComponentModel.Container();
            this.lbProduct = new System.Windows.Forms.ListBox();
            this.lbBill = new System.Windows.Forms.ListBox();
            this.numKol = new System.Windows.Forms.NumericUpDown();
            this.btnAddtoBill = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemovefromBill = new System.Windows.Forms.Button();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.tbAll = new System.Windows.Forms.TextBox();
            this.numDanok = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numKol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDanok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProduct
            // 
            this.lbProduct.FormattingEnabled = true;
            this.lbProduct.ItemHeight = 20;
            this.lbProduct.Location = new System.Drawing.Point(59, 35);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(253, 184);
            this.lbProduct.TabIndex = 0;
            this.lbProduct.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbBill
            // 
            this.lbBill.FormattingEnabled = true;
            this.lbBill.ItemHeight = 20;
            this.lbBill.Location = new System.Drawing.Point(458, 35);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(253, 184);
            this.lbBill.TabIndex = 1;
            this.lbBill.SelectedIndexChanged += new System.EventHandler(this.lbBill_SelectedIndexChanged);
            // 
            // numKol
            // 
            this.numKol.Location = new System.Drawing.Point(159, 246);
            this.numKol.Name = "numKol";
            this.numKol.ReadOnly = true;
            this.numKol.Size = new System.Drawing.Size(153, 27);
            this.numKol.TabIndex = 2;
            // 
            // btnAddtoBill
            // 
            this.btnAddtoBill.Location = new System.Drawing.Point(59, 311);
            this.btnAddtoBill.Name = "btnAddtoBill";
            this.btnAddtoBill.Size = new System.Drawing.Size(253, 29);
            this.btnAddtoBill.TabIndex = 3;
            this.btnAddtoBill.Text = "Додади во Сметка";
            this.btnAddtoBill.UseVisualStyleBackColor = true;
            this.btnAddtoBill.Click += new System.EventHandler(this.btnAddtoBill_Click);
            this.btnAddtoBill.Validating += new System.ComponentModel.CancelEventHandler(this.btnAddtoBill_Validating);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(59, 374);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(253, 29);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Додади нов";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemovefromBill
            // 
            this.btnRemovefromBill.Location = new System.Drawing.Point(458, 246);
            this.btnRemovefromBill.Name = "btnRemovefromBill";
            this.btnRemovefromBill.Size = new System.Drawing.Size(253, 29);
            this.btnRemovefromBill.TabIndex = 5;
            this.btnRemovefromBill.Text = "Избриши од Сметка";
            this.btnRemovefromBill.UseVisualStyleBackColor = true;
            this.btnRemovefromBill.Click += new System.EventHandler(this.btnRemovefromBill_Click);
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(558, 300);
            this.tbSum.Name = "tbSum";
            this.tbSum.ReadOnly = true;
            this.tbSum.Size = new System.Drawing.Size(153, 27);
            this.tbSum.TabIndex = 6;
            this.tbSum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbAll
            // 
            this.tbAll.Location = new System.Drawing.Point(558, 394);
            this.tbAll.Name = "tbAll";
            this.tbAll.ReadOnly = true;
            this.tbAll.Size = new System.Drawing.Size(153, 27);
            this.tbAll.TabIndex = 7;
            // 
            // numDanok
            // 
            this.numDanok.Location = new System.Drawing.Point(558, 344);
            this.numDanok.Name = "numDanok";
            this.numDanok.Size = new System.Drawing.Size(153, 27);
            this.numDanok.TabIndex = 8;
            this.numDanok.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numDanok.Validating += new System.ComponentModel.CancelEventHandler(this.numDanok_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Продукти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сметка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Вкупно";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Данок %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "За Плаќање";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Количина";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDanok);
            this.Controls.Add(this.tbAll);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.btnRemovefromBill);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnAddtoBill);
            this.Controls.Add(this.numKol);
            this.Controls.Add(this.lbBill);
            this.Controls.Add(this.lbProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numKol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDanok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.ListBox lbBill;
        private System.Windows.Forms.NumericUpDown numKol;
        private System.Windows.Forms.Button btnAddtoBill;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemovefromBill;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.TextBox tbAll;
        private System.Windows.Forms.NumericUpDown numDanok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

