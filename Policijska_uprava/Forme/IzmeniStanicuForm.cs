using Policijska_uprava.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Policijska_uprava.Forme
{
    public partial class IzmeniStanicuForm : Form
    {
        StanicaBasic stanica;
        public IzmeniStanicuForm(StanicaBasic st)
        {
            stanica=st;
            InitializeComponent();
        }
        public void popuniPodacima()
        {
            textBox1.Text = stanica.Naziv;
            textBox2.Text= stanica.Adresa;
            textBox3.Text= stanica.Opstina;
            dateTimePicker1.Value = stanica.Datum_Osnivanja;
            numericUpDown1.Value = stanica.BrojVozila;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene stanice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.stanica.Naziv = textBox1.Text;
                this.stanica.Adresa = textBox2.Text;
                this.stanica.Opstina = textBox3.Text;
                this.stanica.Datum_Osnivanja = dateTimePicker1.Value;
                this.stanica.BrojVozila = (int)numericUpDown1.Value;
                DTOManager.azurirajStanicu(this.stanica);
                MessageBox.Show("Azuriranje stanice je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

        private void IzmeniStanicuForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
