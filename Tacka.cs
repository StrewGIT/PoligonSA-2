using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoligonSA
{
    internal class Tacka
    {
        private static int brojac = 0;
        private int broj;
        private int x, y;
        public Tacka(int x, int y)
        {
            if (x >= 0) this.x = x;
            else throw new ArgumentException("Koordinate moraju biti nenegativne");
            if (y >= 0) this.y = y;
            else throw new ArgumentException("Koordinate moraju biti nenegativne");
            brojac++;
            broj = brojac;
        }
        public Tacka()
        {
            this.x = 0;
            this.y = 0;
            brojac++;
            broj = brojac;
        }
        public int X {  
            get { return x; } 
            set {
                if (x >= 0) this.x = X;
                else throw new ArgumentException("Koordinate moraju biti nenegativne");
            } 
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (y >= 0) this.y = Y;
                else throw new ArgumentException("Koordinate moraju biti nenegativne");
            }
        }
    }
}
