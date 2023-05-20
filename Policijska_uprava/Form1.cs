using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Policijska_uprava.Entiteti;
using Policijska_uprava.Forme;

namespace Policijska_uprava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



       

        private void button3_Click(object sender, EventArgs e)
        {
           Intervencije inter = new Intervencije();
            inter.Show();

        }

      

        private void button6_Click(object sender, EventArgs e)
        {
            PolicajciForm forma = new PolicajciForm();
                forma.ShowDialog();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AlarmniSistemF forma = new AlarmniSistemF();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PolicijskeStaniceForm forma = new PolicijskeStaniceForm();
            forma.ShowDialog();
        }
    }
}
