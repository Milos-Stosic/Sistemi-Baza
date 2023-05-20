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
    public partial class AlarmniSistemF : Form
    {
        public AlarmniSistemF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajAlarmniSistem form = new DodajAlarmniSistem();
            form.ShowDialog();
            popuniPodacima();
        }

        public void popuniPodacima()
        {


            ListaAlarma.Items.Clear();
            List<AlarmniSistemBasic> podaci = DTOManager.GetAlarmniSistemBasic();



            foreach (AlarmniSistemBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Model, p.Datum_Instalacije.ToString(), p.Godina_Proizvodnje.ToString(), p.Tehnicko_Lice,
                    p.Pocetak_Odrzavanja.ToString(), p.Zavrsetak_Odrzavanja.ToString()});
                ListaAlarma.Items.Add(item);

            }
            ListaAlarma.Refresh();
        }

        private void ListaAlarma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AlarmniSistemF_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ListaAlarma.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite alarmni sistem koji zelite da obrisete!");
                return;
            }



            int idAlarmnogSistema = Int32.Parse(ListaAlarma.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani alarmni sistem?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);



            if (result == DialogResult.OK)
            {
                DTOManager.obrisiAlarmniSistem(idAlarmnogSistema);
                MessageBox.Show("Brisanje alarmnog sistemaje uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ListaAlarma.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite policajca cije podatke zelite da izmenite!");
                return;
            }

            int id = Int32.Parse(ListaAlarma.SelectedItems[0].SubItems[0].Text);
            AlarmniSistemBasic ob = DTOManager.vratiAlarmniSistem(id);
            DTOManager.azurirajAlarmniSistem(ob);

            IzmeniAlarmniSistem formaUpdate = new IzmeniAlarmniSistem(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    }
}
