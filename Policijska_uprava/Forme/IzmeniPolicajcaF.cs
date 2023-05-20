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
    public partial class IzmeniPolicajcaF : Form
    {
        PolicajacBasic policajac;
        public IzmeniPolicajcaF(PolicajacBasic obj)
        {
            InitializeComponent();
            policajac = obj;
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
            popuniPodacima();
        }

        private void label10_Click(object sender, EventArgs e)
        {
         
        }

        public void popuniPodacima()
        {
            jmbg.Text = policajac.Jmbg.ToString();
            ime.Text = policajac.Ime;
            Prezime.Text = policajac.Prezime;
            ImeRoditelja.Text = policajac.Ime_Roditelja;
            Datum_rodjenja.Text = policajac.Datum_Rodjenja.ToString();
            DatumSticanjaCina.Text = policajac.Datum_Sticanja_Cina.ToString();
            DatumSticanjaDiplome.Text = policajac.Datum_Sticanja_Diplome.ToString();
            Datum_prijema.Text = policajac.Datum_Prijema.ToString();
            Cin.Text = policajac.Cin;
            POL.Text = policajac.Pol.ToString();
            Adresa.Text = policajac.Adresa;
            Edukacija.Text = policajac.Naziv_Skole_Kursa;

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene policajca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.policajac.Jmbg = jmbg.Text;
                policajac.Adresa = Adresa.Text;
                this.policajac.Cin = Cin.Text;
                this.policajac.Datum_Prijema = DateTime.Parse(Datum_prijema.Text);
                this.policajac.Datum_Rodjenja = DateTime.Parse(Datum_rodjenja.Text);
                this.policajac.Datum_Sticanja_Cina = DateTime.Parse(DatumSticanjaCina.Text);
                this.policajac.Datum_Sticanja_Diplome = DateTime.Parse(DatumSticanjaDiplome.Text);
                this.policajac.Ime_Roditelja = (ImeRoditelja.Text);
                this.policajac.Ime = (ime.Text);
                this.policajac.Prezime = Prezime.Text;
                this.policajac.Pol = char.Parse(POL.Text);

                DTOManager.azurirajPolicajca(this.policajac);
                MessageBox.Show("Azuriranje policajca je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
