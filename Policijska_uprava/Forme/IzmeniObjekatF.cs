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
    public partial class IzmeniObjekatF : Form
    {
        ObjekatBasic objekat;
        public IzmeniObjekatF(ObjekatBasic st)
        {
            objekat = st;
            InitializeComponent();
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            textBox1.Text = objekat.Adresa;
            textBox2.Text = objekat.Tip;
            textBox3.Text = objekat.KontaktIme;
            textBox4.Text = objekat.KontaktPrezime;
            numericUpDown1.Value = (decimal)objekat.Povrsina;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene objekta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.objekat.Adresa = textBox1.Text;
                this.objekat.Tip = textBox3.Text;
                this.objekat.KontaktIme = textBox4.Text;
                this.objekat.KontaktPrezime = textBox2.Text;
                this.objekat.Povrsina = (float)numericUpDown1.Value;
                DTOManager.azurirajObjekat(this.objekat);
                MessageBox.Show("Azuriranje objekta je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

        private void IzmeniObjekatF_Load(object sender, EventArgs e)
        {

        }
    }
}
