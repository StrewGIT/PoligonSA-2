using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PoligonSA
{
    internal class Ravan
    {
        public static int VektorskiProizvod(Vektor A, Vektor B)
        {
            return A.izCentra().X * B.izCentra().Y - A.izCentra().Y * B.izCentra().X;
        }
        public static bool SaIsteStrane(Tacka A, Tacka B, Vektor C)
        {
            Vektor AC1 = new Vektor(A, C.Pocetak);
            Vektor AC2 = new Vektor(A,C.Kraj);
            Vektor BC1 = new Vektor(B, C.Pocetak);
            Vektor BC2 = new Vektor(B, C.Kraj);
            if ((VektorskiProizvod(AC1, AC2) > 0 && VektorskiProizvod(BC1, BC2) > 0) || (VektorskiProizvod(AC1, AC2) < 0 && VektorskiProizvod(BC1, BC2) < 0))
            {
                return true;
            }
            else if((VektorskiProizvod(AC1, AC2) > 0 && VektorskiProizvod(BC1, BC2) < 0) || (VektorskiProizvod(AC1, AC2) < 0 && VektorskiProizvod(BC1, BC2) > 0))
            {
                return false;
            }
            else if(VektorskiProizvod(AC1, AC2) == 0 && VektorskiProizvod(BC1, BC2) == 0)
            {
                throw new Exception("Oba");
            }
            else { throw new Exception("Jedan"); }
        }
        public static int Sece(Vektor A,Vektor B)
        {
            try
            {
                if (SaIsteStrane(A.Pocetak, A.Kraj, B) || SaIsteStrane(B.Pocetak, B.Kraj, A))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                if(ex.Message == "Jedan")
                {
                    return -1;
                }
                else if(ex.Message == "Oba")
                {
                    return -2;
                }
            }
            throw new NotImplementedException("Greska u metodi Sece");
        }
    }
}
