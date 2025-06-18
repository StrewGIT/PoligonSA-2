using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoligonSA
{
    internal class Ravan
    {
        public static int VektorskiProizvod(Vektor A, Vektor B)
        {
            int x1 = A.izCentra().X;
            int y1 = A.izCentra().Y;
            int x2= B.izCentra().X;
            int y2 = B.izCentra().Y;
            return x1*y2 - y1*x2;
        }
        public bool Sece(Vektor A,Vektor B)
        {
            if(VektorskiProizvod(A,B) == 1) {
                return false;
            }
            else 
            {
                return true;
            }
            
        }
    }
}
