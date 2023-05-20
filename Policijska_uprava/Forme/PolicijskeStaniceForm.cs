using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Policijska_uprava.Forme
{
    public partial class PolicijskeStaniceForm : Form
    {
        public PolicijskeStaniceForm()
        {
            InitializeComponent();
            
        }
        private void PolicijskeStaniceForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listaStanica.Items.Clear();
            List<StanicaBasic> podaci = DTOManager.GetStaniceBasic();



            foreach (StanicaBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Naziv, p.Adresa, p.BrojVozila.ToString(),
                    p.Opstina, p.Datum_Osnivanja.ToString()});
                listaStanica.Items.Add(item);
            }
            listaStanica.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)//dodavanje
        {
            DodajStanicuForm forma = new DodajStanicuForm();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)//izmena
        {

            if (listaStanica.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite stanicu cije podatke zelite da izmenite!");
                return;
            }

            int ID = int.Parse(listaStanica.SelectedItems[0].SubItems[0].Text);
            StanicaBasic ob = DTOManager.vratiStanicu(ID);

            IzmeniStanicuForm formaUpdate = new IzmeniStanicuForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)//brisanje
        {
            if (listaStanica.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite stanicu koju zelite da obrisete!");
                return;
            }

            int ID = int.Parse(listaStanica.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu stanicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiStanicu(ID);
                MessageBox.Show("Brisanje stanice je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {
            }
        }

        private void listaStanica_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listaStanica.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite stanicu!");
                return;
            }


            int ID = int.Parse(listaStanica.SelectedItems[0].SubItems[0].Text);
            ObjekatForm forma = new ObjekatForm(ID);
            forma.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }
    }
}
