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
    public partial class DodajVanrednog : Form
    {
        PolicajacVanredneSituacijeBasic vanredni;
        public DodajVanrednog()
        {
            InitializeComponent();
            vanredni = new PolicajacVanredneSituacijeBasic();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string poruka = "Da li zelite da dodate novog policajca za vanredne situacije?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.vanredni.Jmbg = textBox1.Text;
                this.vanredni.Adresa = textBox2.Text;
                this.vanredni.Cin = textBox3.Text;
                this.vanredni.Datum_Prijema = DateTime.Parse(textBox4.Text);
                this.vanredni.Datum_Rodjenja = DateTime.Parse(textBox5.Text);
                this.vanredni.Datum_Sticanja_Cina = DateTime.Parse(textBox6.Text);
                this.vanredni.Datum_Sticanja_Diplome = DateTime.Parse(textBox7.Text);
                this.vanredni.Ime_Roditelja = (textBox8.Text);
                this.vanredni.Ime = (textBox9.Text);
                this.vanredni.Prezime = textBox10.Text;
                this.vanredni.Pol = char.Parse(textBox11.Text);
                this.vanredni.Naziv_Vestine = (textBox13.Text);
                this.vanredni.Poseduje_Sertifikat = (textBox15.Text);
                this.vanredni.Pohadjao_Kurs = (textBox14.Text);
                this.vanredni.Datum_Zavrsetka_Kursa = DateTime.Parse(textBox16.Text);
                this.vanredni.Datum_Sticanja_Sertifikata = DateTime.Parse(textBox12.Text);

                DTOManager.dodajPolicajcaZaVanredne(this.vanredni);
               // MessageBox.Show("Uspesno ste dodali novog policajca za vanredne situacije!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
