using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoligonSA
{
    internal class Vektor
    {
        private Tacka pocetak;
        private Tacka kraj;
        public Vektor(Tacka pocetak, Tacka kraj)
        {
            try
            {
                this.pocetak = pocetak;
                this.kraj = kraj;
            }
            catch(ArgumentException ex) { MessageBox.Show(ex.Message);}
        }
        public Vektor(Tacka kraj)
        {
            try
            {
                this.pocetak = new Tacka();
                this.kraj = kraj;
            }
            catch(ArgumentException ex) { MessageBox.Show(ex.Message);}
        }
        public double D
        {
            get { return (Math.Sqrt((kraj.X - pocetak.X) ^ 2 + (kraj.Y - pocetak.Y) ^ 2)); }
        }
    }
}
