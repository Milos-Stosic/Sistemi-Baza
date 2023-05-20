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
    public partial class Policajci_za_vanredne_situacije : Form
    {
        public Policajci_za_vanredne_situacije()
        {
            InitializeComponent();
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {


            listView1.Items.Clear();
            List<PolicajacVanredneSituacijeBasic> podaci = DTOManager.GetPolicajacVanredneSituacijeBasic();



            foreach (PolicajacVanredneSituacijeBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Jmbg.ToString(), p.Ime.ToString(), p.Ime_Roditelja.ToString(), p.Prezime.ToString(), p.Pol.ToString(), p.Datum_Prijema.ToString(), p.Datum_Rodjenja.ToString(), p.Adresa.ToString(), p.Naziv_Skole_Kursa.ToString(),
                        p.Datum_Sticanja_Diplome.ToString(), p.Cin.ToString(), p.Datum_Sticanja_Cina.ToString(), p.Naziv_Vestine.ToString(), p.Poseduje_Sertifikat.ToString(),p.Pohadjao_Kurs.ToString(),p.Datum_Zavrsetka_Kursa.ToString(),p.Datum_Sticanja_Sertifikata.ToString()});

                listView1.Items.Add(item);

            }

            listView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite policajca koga zelite da obrisete!");
                return;
            }



            string jmbg = (listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog policajca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);



            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVanrednog(jmbg);
                MessageBox.Show("Brisanje policajca uspesno obavljeno!");
                this.PopuniPodacima();
            }
            else
            {



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajVanrednog pol = new DodajVanrednog();
            pol.Show();
        }
    }
}
