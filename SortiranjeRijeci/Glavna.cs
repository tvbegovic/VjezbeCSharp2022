using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortiranjeRijeci
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            var rijeciString = txtRijeci.Text;
            var rijeciPolje = rijeciString.Split(' ');
            Array.Sort(rijeciPolje);
            AzurirajListbox(rijeciPolje);
        }

        private void AzurirajListbox(string[] polje)
        {
            lstSortirano.DataSource = polje;
        }

        private void btnSortirajOrderBy_Click(object sender, EventArgs e)
        {
            var rijeciString = txtRijeci.Text;
            var rijeciPolje = rijeciString.Split(' ');
            var sortiranoPolje = rijeciPolje.OrderBy(r => r).ToArray();
            AzurirajListbox(sortiranoPolje);
        }
    }
}
