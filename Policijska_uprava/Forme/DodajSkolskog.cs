using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Policijska_uprava.Forme
{
    public partial class DodajSkolskog : Form
    {
        SkolskiPolicajacBasic skolski;
        public DodajSkolskog()
        {
            InitializeComponent();
            skolski= new SkolskiPolicajacBasic();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog skolskog policajca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.skolski.Jmbg = textBox1.Text;
                this.skolski.Adresa = textBox2.Text;
                this.skolski.Cin = textBox3.Text;
                this.skolski.Datum_Prijema = DateTime.Parse(textBox4.Text);
                this.skolski.Datum_Rodjenja = DateTime.Parse(textBox5.Text);
                this.skolski.Datum_Sticanja_Cina = DateTime.Parse(textBox6.Text);
                this.skolski.Datum_Sticanja_Diplome = DateTime.Parse(textBox7.Text);
                this.skolski.Ime_Roditelja = (textBox8.Text);
                this.skolski.Ime = (textBox9.Text);
                this.skolski.Prezime = textBox10.Text;
                this.skolski.Pol = char.Parse(textBox11.Text);
                this.skolski.Naziv_Skole = (textBox13.Text);
                this.skolski.Skola_adresa = (textBox14.Text);
                this.skolski.Tip_Skole = (textBox15.Text);
                this.skolski.Osoba_Za_Kontakt = (textBox16.Text);

                DTOManager.dodajSkolskog(this.skolski);
               // MessageBox.Show("Uspesno ste dodali novog skolskog policajca!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
