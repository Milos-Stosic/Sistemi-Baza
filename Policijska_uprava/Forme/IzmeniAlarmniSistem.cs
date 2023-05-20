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
    public partial class IzmeniAlarmniSistem : Form
    {

        AlarmniSistemBasic alarmniSistem;
        public IzmeniAlarmniSistem(AlarmniSistemBasic a)
        {
            InitializeComponent();
            this.alarmniSistem = a;
        }

        private void IzmeniAlarmniSistem_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void GODINA_PROIZVODNJE_TextChanged(object sender, EventArgs e)
        {

        }

        public void popuniPodacima()
        {
            Model.Text = this.alarmniSistem.Model;
            dateTimePicker1.Value = this.alarmniSistem.Datum_Instalacije;
            numericUpDown1.Value = this.alarmniSistem.Godina_Proizvodnje;
            TEHNICKO_LICE.Text = this.alarmniSistem.Tehnicko_Lice;
            dateTimePicker2.Value = this.alarmniSistem.Pocetak_Odrzavanja;
            dateTimePicker3.Value = this.alarmniSistem.Zavrsetak_Odrzavanja;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene alarmnog sistema?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.alarmniSistem.Model = Model.Text;
                this.alarmniSistem.Datum_Instalacije = dateTimePicker1.Value;
                this.alarmniSistem.Godina_Proizvodnje = (int)(numericUpDown1.Value);
                this.alarmniSistem.Datum_Poslednjeg_Atesta = dateTimePicker5.Value;
                this.alarmniSistem.Datum_Poslednjeg_Servisa = dateTimePicker4.Value;
                this.alarmniSistem.Tehnicko_Lice = TEHNICKO_LICE.Text;
                this.alarmniSistem.Pocetak_Odrzavanja = dateTimePicker2.Value;
                this.alarmniSistem.Zavrsetak_Odrzavanja = dateTimePicker3.Value;
                DTOManager.azurirajAlarmniSistem(this.alarmniSistem);
                MessageBox.Show("Azuriranje alarmnog sistema je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }

        private void Model_TextChanged(object sender, EventArgs e)
        {

        }

        private void TEHNICKO_LICE_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DATUM_INSTALACIJE_TextChanged(object sender, EventArgs e)
        {

        }

        private void POCETAK_ODRZAVANJA_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZAVRSETAK_ODRZAVANJA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
