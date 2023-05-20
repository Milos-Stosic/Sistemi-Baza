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
    public partial class DodajAlarmniSistem : Form
    {
        AlarmniSistemBasic alarmniSistem;
        public DodajAlarmniSistem()
        {
            InitializeComponent();
            alarmniSistem = new AlarmniSistemBasic();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dodaj_Alarmni_Sistem_Click(object sender, EventArgs e)
        {
         
                string poruka = "Da li zelite da dodate novi alarmni sistem?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.alarmniSistem.Id = (int)numericUpDown2.Value;
                this.alarmniSistem.Model = textBox1.Text;
                this.alarmniSistem.Datum_Instalacije = dateTimePicker1.Value;
                this.alarmniSistem.Godina_Proizvodnje = (int)(numericUpDown1.Value);
                this.alarmniSistem.Tehnicko_Lice = textBox4.Text;
                this.alarmniSistem.Pocetak_Odrzavanja = dateTimePicker2.Value;
                this.alarmniSistem.Zavrsetak_Odrzavanja = dateTimePicker3.Value;

                DTOManager.dodajAlarmniSistem(this.alarmniSistem);
                MessageBox.Show("Uspesno ste dodali novi alarmni sistem!");
                this.Close();
            }
            else
            {

            }
        }

        private void DodajAlarmniSistem_Load(object sender, EventArgs e)
        {

        }
    }
}
