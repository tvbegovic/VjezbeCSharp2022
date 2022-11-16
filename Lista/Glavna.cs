using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class Glavna : Form
    {
        List<string> rijeci = new List<string>();
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnDodajRijec_Click(object sender, EventArgs e)
        {
            var rijec = txtRijec.Text;
            //Mogli bi provjeriti da rijec nije prazan string
            rijeci.Add(rijec);
            AzurirajListBox();
            txtRijec.Text = String.Empty;
            txtRijec.Focus();
        }

        void AzurirajListBox()
        {
            lstRijeci.DataSource = null;
            lstRijeci.DataSource = rijeci;
        }

        private void btnDodajPozicija_Click(object sender, EventArgs e)
        {
            var unos = txtPozicija.Text;
            var ok = int.TryParse(unos, out int pozicija);
            if(!ok)
            {
                MessageBox.Show("Pogrešan format");
                return;
            }
            //TODO: provjeri da li je pozicija valjana (u rasponu od 0 - veličina lista)
            if(pozicija < 0 || pozicija > rijeci.Count - 1)
            {
                MessageBox.Show("Pozicija je izvan raspona");
                return;
            }
            rijeci.Insert(pozicija, txtRijec.Text);
            AzurirajListBox();
        }

        private void btnDodajVise_Click(object sender, EventArgs e)
        {
            var stringViseRijeci = txtViseRijeci.Text;
            var poljeViseRijeci = stringViseRijeci.Split(' ');            
            rijeci.AddRange(poljeViseRijeci);
            AzurirajListBox();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var index = lstRijeci.SelectedIndex;
            if(index >= 0)
            {
                rijeci.RemoveAt(index);
                AzurirajListBox();
            }
        }

        private void btnIsprazni_Click(object sender, EventArgs e)
        {
            rijeci.Clear();
            AzurirajListBox();
        }
    }
}
