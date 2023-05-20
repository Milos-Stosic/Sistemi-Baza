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
    public partial class DodajPolicajca : Form
    {
        PolicajacBasic policajac;
        public DodajPolicajca()
        {
            InitializeComponent();
            policajac = new PolicajacBasic();
        }

        private void listaPolicajca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void DodajPolicajca_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog policajca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.policajac.Jmbg = jmbg.Text;
                this.policajac.Adresa = Adresa.Text;
                this.policajac.Cin = Cin.Text;
                this.policajac.Datum_Prijema = dateTimePicker1.Value;
                this.policajac.Datum_Rodjenja = dateTimePicker2.Value;
                this.policajac.Datum_Sticanja_Cina= dateTimePicker3.Value;
                this.policajac.Datum_Sticanja_Diplome = dateTimePicker4.Value;
                this.policajac.Ime_Roditelja= (ImeRoditelja.Text);
                this.policajac.Ime = (ime.Text);
                this.policajac.Prezime = Prezime.Text;
                this.policajac.Pol= char.Parse(POL.Text);
                this.policajac.Naziv_Skole_Kursa=Edukacija.Text;
                               

                DTOManager.dodajPolicajca(this.policajac);
                this.Close();
            }
            else
            {

            }
        }

        private void ImeRoditelja_TextChanged(object sender, EventArgs e)
        {

        }

        private void jmbg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
