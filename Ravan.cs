using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PoligonSA
{
    internal static class Ravan
    {
        public static int VektorskiProizvod(Vektor A, Vektor B)
        {
            return A.izCentra().X * B.izCentra().Y - A.izCentra().Y * B.izCentra().X;
        }
        public static int Orijentacija(Tacka p, Tacka q, Tacka r)
        {
            int val = VektorskiProizvod(new Vektor(p, q), new Vektor(q, r));

            if (val == 0) return 0;
            return (val > 0) ? 1 : 2;
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
                SaIsteStrane(A.Pocetak, A.Kraj, B);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Jedan")
                {
                    return -1;
                }
                else if (ex.Message == "Oba")
                {
                    return -2;
                }
            }
            try
            {
                SaIsteStrane(B.Pocetak, B.Kraj, A);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Jedan")
                {
                    return -3;
                }
                else if (ex.Message == "Oba")
                {
                    return -4;
                }
            }
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
            catch (Exception)
            {

            }
            throw new NotImplementedException("Greska u metodi Sece");
        }
        
    }
}
