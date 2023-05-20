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
    public partial class ObjekatForm : Form
    {
        public int IDStanice { get; set; }
        public ObjekatForm(int iDStanice)
        {
            InitializeComponent();
            IDStanice = iDStanice;
        }
        private void ObjekatForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();
            List<ObjekatBasic> podaci = DTOManager.GetObjekteBasic(IDStanice);



            foreach (ObjekatBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Adresa, p.Tip, p.Povrsina.ToString(),
                    p.KontaktIme, p.KontaktPrezime});
                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)//dodavanje
        {
            DodajObjekatF forma = new DodajObjekatF(IDStanice);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)//izmena
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite objekat cije podatke zelite da izmenite!");
                return;
            }

            int ID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ObjekatBasic ob = DTOManager.vratiObjekat(ID);

            IzmeniObjekatF formaUpdate = new IzmeniObjekatF(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)//brisanje
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite objekat koju zelite da obrisete!");
                return;
            }

            int ID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani objekat?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiObjekat(ID);
                MessageBox.Show("Brisanje objekta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {
            }
        }

        private void listaStanica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
