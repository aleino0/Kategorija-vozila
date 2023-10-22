namespace kategorijaVozila
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fModel = new System.Windows.Forms.TextBox();
            this.fBrKotaca = new System.Windows.Forms.TextBox();
            this.fGodPr = new System.Windows.Forms.TextBox();
            this.fUnos = new System.Windows.Forms.Button();
            this.fObrada = new System.Windows.Forms.Button();
            this.fIspis = new System.Windows.Forms.Button();
            this.fIspisPod = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fSpremi = new System.Windows.Forms.Button();
            this.fUcitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fModel
            // 
            this.fModel.Location = new System.Drawing.Point(12, 63);
            this.fModel.Name = "fModel";
            this.fModel.Size = new System.Drawing.Size(100, 20);
            this.fModel.TabIndex = 0;
            // 
            // fBrKotaca
            // 
            this.fBrKotaca.Location = new System.Drawing.Point(12, 153);
            this.fBrKotaca.Name = "fBrKotaca";
            this.fBrKotaca.Size = new System.Drawing.Size(100, 20);
            this.fBrKotaca.TabIndex = 2;
            this.fBrKotaca.TextChanged += new System.EventHandler(this.fBrKotaca_TextChanged);
            // 
            // fGodPr
            // 
            this.fGodPr.Location = new System.Drawing.Point(12, 105);
            this.fGodPr.Name = "fGodPr";
            this.fGodPr.Size = new System.Drawing.Size(100, 20);
            this.fGodPr.TabIndex = 1;
            this.fGodPr.TextChanged += new System.EventHandler(this.fGodPr_TextChanged);
            // 
            // fUnos
            // 
            this.fUnos.Location = new System.Drawing.Point(258, 59);
            this.fUnos.Name = "fUnos";
            this.fUnos.Size = new System.Drawing.Size(75, 23);
            this.fUnos.TabIndex = 3;
            this.fUnos.Text = "Unos";
            this.fUnos.UseVisualStyleBackColor = true;
            this.fUnos.Click += new System.EventHandler(this.fUnos_Click);
            // 
            // fObrada
            // 
            this.fObrada.Location = new System.Drawing.Point(258, 105);
            this.fObrada.Name = "fObrada";
            this.fObrada.Size = new System.Drawing.Size(75, 23);
            this.fObrada.TabIndex = 4;
            this.fObrada.Text = "Obrada";
            this.fObrada.UseVisualStyleBackColor = true;
            this.fObrada.Click += new System.EventHandler(this.fObrada_Click);
            // 
            // fIspis
            // 
            this.fIspis.Location = new System.Drawing.Point(258, 153);
            this.fIspis.Name = "fIspis";
            this.fIspis.Size = new System.Drawing.Size(75, 23);
            this.fIspis.TabIndex = 5;
            this.fIspis.Text = "Ispis";
            this.fIspis.UseVisualStyleBackColor = true;
            this.fIspis.Click += new System.EventHandler(this.fIspis_Click);
            // 
            // fIspisPod
            // 
            this.fIspisPod.Location = new System.Drawing.Point(12, 182);
            this.fIspisPod.Name = "fIspisPod";
            this.fIspisPod.ReadOnly = true;
            this.fIspisPod.Size = new System.Drawing.Size(321, 192);
            this.fIspisPod.TabIndex = 6;
            this.fIspisPod.TabStop = false;
            this.fIspisPod.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "godina proizvodnje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "broji kotača:";
            // 
            // fSpremi
            // 
            this.fSpremi.Location = new System.Drawing.Point(13, 391);
            this.fSpremi.Name = "fSpremi";
            this.fSpremi.Size = new System.Drawing.Size(75, 23);
            this.fSpremi.TabIndex = 10;
            this.fSpremi.Text = "spremi";
            this.fSpremi.UseVisualStyleBackColor = true;
            this.fSpremi.Click += new System.EventHandler(this.fSpremi_Click);
            // 
            // fUcitaj
            // 
            this.fUcitaj.Location = new System.Drawing.Point(237, 390);
            this.fUcitaj.Name = "fUcitaj";
            this.fUcitaj.Size = new System.Drawing.Size(96, 23);
            this.fUcitaj.TabIndex = 11;
            this.fUcitaj.Text = "Ucitaj s racunala";
            this.fUcitaj.UseVisualStyleBackColor = true;
            this.fUcitaj.Click += new System.EventHandler(this.fUcitaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 430);
            this.Controls.Add(this.fUcitaj);
            this.Controls.Add(this.fSpremi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fIspisPod);
            this.Controls.Add(this.fIspis);
            this.Controls.Add(this.fObrada);
            this.Controls.Add(this.fUnos);
            this.Controls.Add(this.fGodPr);
            this.Controls.Add(this.fBrKotaca);
            this.Controls.Add(this.fModel);
            this.Name = "Form1";
            this.Text = "Kategorije vozila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fModel;
        private System.Windows.Forms.TextBox fBrKotaca;
        private System.Windows.Forms.TextBox fGodPr;
        private System.Windows.Forms.Button fUnos;
        private System.Windows.Forms.Button fObrada;
        private System.Windows.Forms.Button fIspis;
        private System.Windows.Forms.RichTextBox fIspisPod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fSpremi;
        private System.Windows.Forms.Button fUcitaj;
    }
}

