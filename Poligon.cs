using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoligonSA
{
    internal class Poligon
    {
        private List<Vektor> vektori;
        public Poligon() {
            vektori = new List<Vektor>();
        }
        public void Dodaj(Vektor vektor)
        {
            vektori.Add(vektor);
        }
        public bool jeProst()
        {
            bool rez = true;
            return rez;
        }
    }
}
