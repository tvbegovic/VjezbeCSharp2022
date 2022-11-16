using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igre_Klase
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();            
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            var naziv = txtNaziv.Text;
            var opis = txtOpis.Text;
            var izdavac = txtIzdavac.Text;
            var vrsta = txtVrsta.Text;
            var ok = double.TryParse(txtCijena.Text, out double cijena);
            if(!ok)
            {
                MessageBox.Show("Pogrešan format cijene");
                return;
            }
            ok = DateTime.TryParse(txtDatum.Text, out DateTime datum);
            if (!ok)
            {
                MessageBox.Show("Pogrešan format datuma");
                return;
            }
            try
            {
                var igra = new Igra();
                //Verzija 1 - funkcija IzmijeniPodatke
                //igra.IzmijeniPodatke(naziv, opis, cijena, datum, izdavac, vrsta);
                //Verzija 2 - upisujem u klasu preko public properties
                igra.Naziv = naziv;
                igra.Opis = opis;
                igra.DatumIzdavanja = datum;
                igra.Cijena = cijena;
                igra.Izdavac = izdavac;
                igra.Vrsta = vrsta;
                MessageBox.Show("Podaci su uspješno uneseni");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreška. Tekst pogreške: {ex.Message}");
            }
        }
    }
}
