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
    public partial class DodajObjekatF : Form
    {
        ObjekatBasic objekat;
        int IDStanice;
        public DodajObjekatF(int iDStanice)
        {
            InitializeComponent();
            objekat = new ObjekatBasic();
            IDStanice = iDStanice;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string poruka = "Da li zelite da dodate nov objekat?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                objekat.Adresa = textBox1.Text;
                objekat.Tip = textBox3.Text;
                objekat.Povrsina = (float)numericUpDown1.Value;
                objekat.KontaktIme = textBox4.Text;
                objekat.KontaktPrezime = textBox2.Text;
                DTOManager.dodajObjekat(this.objekat, IDStanice);
                this.Close();
            }
            else
            {

            }
        }

        private void DodajObjekatF_Load(object sender, EventArgs e)
        {

        }
    }
}
