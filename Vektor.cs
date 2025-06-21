using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoligonSA
{
    public class Vektor
    {
        private Tacka pocetak;
        private Tacka kraj;
        public Tacka Pocetak
        {
            get { return pocetak; }
        }
        public Tacka Kraj
        {
            get { return kraj; }
        }
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
            get { return (Math.Sqrt((kraj.X - pocetak.X)* (kraj.X - pocetak.X) + (kraj.Y - pocetak.Y)* (kraj.Y - pocetak.Y))); }
        }
        public Tacka izCentra()
        {
            int x = pocetak.X - kraj.X;
            int y = pocetak.Y - kraj.Y;
            return new Tacka(x, y,true);
        }
    }
}
