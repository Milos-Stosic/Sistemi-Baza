using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Policijska_uprava.Forme
{
    public partial class DodajPozornika : Form
    {
        PozornikBasic pozornik;
        public DodajPozornika()
        {
            InitializeComponent();
            pozornik = new PozornikBasic();
        }

        private void DodajPozornika_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog pozornika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.pozornik.Jmbg = textBox1.Text;
                this.pozornik.Adresa = textBox2.Text;
                this.pozornik.Cin = textBox3.Text;
                this.pozornik.Datum_Prijema = dateTimePicker1.Value;
                this.pozornik.Datum_Rodjenja = dateTimePicker2.Value;
                this.pozornik.Datum_Sticanja_Cina = dateTimePicker3.Value;
                this.pozornik.Datum_Sticanja_Diplome = dateTimePicker4.Value;
                this.pozornik.Ime_Roditelja = (textBox8.Text);
                this.pozornik.Ime = (textBox9.Text);
                this.pozornik.Prezime = textBox10.Text;
                this.pozornik.Pol = char.Parse(textBox11.Text);
                this.pozornik.Naziv_Ulice = (textBox12.Text);

                DTOManager.dodajPozornika(this.pozornik);
              //  MessageBox.Show("Uspesno ste dodali novog pozornika!");
                this.Close();
            }
            else
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
