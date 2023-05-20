namespace Policijska_uprava.Forme
{
    partial class PolicijskeStaniceForm
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
            this.listaStanica = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAZIV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ADRESA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BROJ_SLUZBENIH_VOZILA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OPSTINA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATUM_OSNIVANJA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaStanica
            // 
            this.listaStanica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NAZIV,
            this.ADRESA,
            this.BROJ_SLUZBENIH_VOZILA,
            this.OPSTINA,
            this.DATUM_OSNIVANJA});
            this.listaStanica.FullRowSelect = true;
            this.listaStanica.HideSelection = false;
            this.listaStanica.Location = new System.Drawing.Point(12, 12);
            this.listaStanica.Name = "listaStanica";
            this.listaStanica.Size = new System.Drawing.Size(986, 370);
            this.listaStanica.TabIndex = 0;
            this.listaStanica.UseCompatibleStateImageBehavior = false;
            this.listaStanica.View = System.Windows.Forms.View.Details;
            this.listaStanica.SelectedIndexChanged += new System.EventHandler(this.listaStanica_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NAZIV
            // 
            this.NAZIV.Text = "NAZIV";
            this.NAZIV.Width = 122;
            // 
            // ADRESA
            // 
            this.ADRESA.Text = "ADRESA";
            this.ADRESA.Width = 161;
            // 
            // BROJ_SLUZBENIH_VOZILA
            // 
            this.BROJ_SLUZBENIH_VOZILA.Text = "BROJ SLUZBENIH VOZILA";
            this.BROJ_SLUZBENIH_VOZILA.Width = 186;
            // 
            // OPSTINA
            // 
            this.OPSTINA.Text = "OPSTINA";
            this.OPSTINA.Width = 110;
            // 
            // DATUM_OSNIVANJA
            // 
            this.DATUM_OSNIVANJA.Text = "DATUM OSNIVANJA";
            this.DATUM_OSNIVANJA.Width = 148;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "OBRISI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "IZMENI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(846, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "PRIKAZI OBJEKTE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PolicijskeStaniceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaStanica);
            this.Name = "PolicijskeStaniceForm";
            this.Text = "PolicijskeStaniceForm";
            this.Load += new System.EventHandler(this.PolicijskeStaniceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaStanica;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NAZIV;
        private System.Windows.Forms.ColumnHeader ADRESA;
        private System.Windows.Forms.ColumnHeader BROJ_SLUZBENIH_VOZILA;
        private System.Windows.Forms.ColumnHeader OPSTINA;
        private System.Windows.Forms.ColumnHeader DATUM_OSNIVANJA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}