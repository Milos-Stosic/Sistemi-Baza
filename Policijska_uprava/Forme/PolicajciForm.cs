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

namespace Policijska_uprava.Forme
{
    public partial class PolicajciForm : Form
    {
        public PolicajciForm()
        {
            InitializeComponent();
            popuniPodacima();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PolicajciForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {


            listaPolicajca.Items.Clear();
            List<PolicajacBasic> podaci = DTOManager.GetPolicajceBasic();



            foreach(PolicajacBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Jmbg, p.Ime, p.Ime_Roditelja, p.Prezime, p.Pol.ToString(),
                    p.Datum_Prijema.ToString(), p.Datum_Rodjenja.ToString(), p.Adresa, p.Naziv_Skole_Kursa, p.Datum_Sticanja_Diplome.ToString(), p.Cin,
                        p.Datum_Sticanja_Cina.ToString()});
                listaPolicajca.Items.Add(item);
            }
            listaPolicajca.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajPolicajca form = new DodajPolicajca();
            form.ShowDialog();
            popuniPodacima();
        }
        
        private void button2_Click(object sender, EventArgs e) //IZMENA
        {

            if (listaPolicajca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite policajca cije podatke zelite da izmenite!");
                return;
            }

            string jmbg = (listaPolicajca.SelectedItems[0].SubItems[0].Text);
            PolicajacBasic ob = DTOManager.vratiPolicajca(jmbg);

            IzmeniPolicajcaF formaUpdate = new IzmeniPolicajcaF(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaPolicajca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite policajca kojeg zelite da obrisete!");
                return;
            }



            string jmbg =(listaPolicajca.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog policajca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);



            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPolicajca(jmbg);
                MessageBox.Show("Brisanje policajca je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrikaziDruge drugi = new PrikaziDruge();
            drugi.Show();
        }
    }
    
}
