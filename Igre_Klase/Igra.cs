using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Igre_Klase
{
    internal class Igra
    {
        private string naziv;
        private string opis;
        private double cijena;
        private DateTime datumIzdavanja;
        private string izdavac;
        private string vrsta;

        public string Naziv 
        { 
            get { return naziv; } 
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Naziv ne smije biti prazan");
                naziv = value; 
            } 
        }

        public string Opis { get => opis; set => opis = value; }
        public double Cijena { 
            get => cijena;
            set
            {
                if (value < 0 || value > 1000)
                    throw new ArgumentException("Cijena mora biti između 0 i 1000");
                cijena = value;
            }
        }
        public DateTime DatumIzdavanja { get => datumIzdavanja; set => datumIzdavanja = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }
        public string Vrsta
        {
            get => vrsta;
            set
            {
                var dozvoljeneVrste = new[] {
                "Akcijska", "RPG", "Avantura", "Simulacija", "Sport" , "Strategija" };
                if (!dozvoljeneVrste.Contains(value))
                    throw new ArgumentException("Vrsta nije jedna od dozvoljenih");
                vrsta = value;
            }
        }
        public void IzmijeniPodatke(string naziv, string opis, double cijena,
            DateTime datumIzdavanja, string izdavac, string vrsta)
        {
            if (string.IsNullOrEmpty(naziv))
                throw new ArgumentException("Naziv ne smije biti prazan");
            this.naziv = naziv;
            this.Opis = opis;
            if (cijena < 0 || cijena > 1000)
                throw new ArgumentException("Cijena mora biti između 0 i 1000");
            this.Cijena = cijena;
            this.DatumIzdavanja = datumIzdavanja;
            this.Izdavac = izdavac;
            var dozvoljeneVrste = new[] {
                "Akcijska", "RPG", "Avantura", "Simulacija", "Sport" , "Strategija" };
            if (!dozvoljeneVrste.Contains(vrsta))
                throw new ArgumentException("Vrsta nije jedna od dozvoljenih");
            this.Vrsta = vrsta;
        }

    }
}
