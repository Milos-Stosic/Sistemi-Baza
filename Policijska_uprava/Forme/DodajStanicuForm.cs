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
    public partial class DodajStanicuForm : Form
    {
        StanicaBasic stanica;
        public DodajStanicuForm()
        {
            InitializeComponent();
            stanica = new StanicaBasic();

        }

        private void DodajStanicuForm_Load(object sender, EventArgs e)
        {   

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string poruka = "Da li zelite da dodate novu stanicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.stanica.Naziv = textBox1.Text;
                this.stanica.Adresa = textBox2.Text;
                this.stanica.Opstina = textBox3.Text;
                this.stanica.BrojVozila = (int)numericUpDown1.Value;
                this.stanica.Datum_Osnivanja = dateTimePicker1.Value;

                DTOManager.dodajStanicu(this.stanica);
                MessageBox.Show("Uspesno ste dodali novu stanicu!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
