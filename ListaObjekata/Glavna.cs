using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaObjekata
{
    public partial class Glavna : Form
    {
        List<Igra> igre = new List<Igra>();
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
            if (!ok)
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
                igra.Naziv = naziv;
                igra.Opis = opis;
                igra.DatumIzdavanja = datum;
                igra.Cijena = cijena;
                igra.Izdavac = izdavac;
                igra.Vrsta = vrsta;
                igre.Add(igra);
                AzurirajDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreška. Tekst pogreške: {ex.Message}");
            }
        }

        void AzurirajDataGrid()
        {
            dgvIgre.DataSource = null;
            dgvIgre.DataSource = igre;
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var currentRow = dgvIgre.CurrentRow;
            if(currentRow != null)
            {
                var index = dgvIgre.CurrentRow.Index;
                if (index >= 0)
                {
                    igre.RemoveAt(index);
                    AzurirajDataGrid();
                }
            }
            
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var datoteka = new StreamWriter("igre.txt");
            foreach (var igra in igre)
            {
                datoteka.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                    igra.Naziv, igra.Opis, igra.Vrsta, igra.DatumIzdavanja,
                    igra.Cijena, igra.Izdavac);
            }
            datoteka.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            igre.Clear();
            var redci = File.ReadAllLines("igre.txt");
            foreach (var red in redci)
            {
                var stupci = red.Split('\t');
                var igra = new Igra();
                igra.Naziv = stupci[0];
                igra.Opis = stupci[1];
                igra.Vrsta = stupci[2];
                var ok = DateTime.TryParse(stupci[3], out DateTime datum);
                if (ok)
                    igra.DatumIzdavanja = datum;
                ok = double.TryParse(stupci[4], out double cijena);
                if (ok)
                    igra.Cijena = cijena;
                igra.Izdavac = stupci[5];
                igre.Add(igra);
            }
            AzurirajDataGrid();
        }
    }
}
