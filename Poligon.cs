using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoligonSA
{
    internal class Poligon
    {
        private List<Vektor> vektori;
        public Poligon()
        {
            vektori = new List<Vektor>();
        }
        public void Dodaj(Vektor vektor)
        {
            vektori.Add(vektor);
        }
        public bool jeProst()
        {
            for(int i=0;i<vektori.Count-1;i++)
            {
                for(int j=i+1;j<vektori.Count;j++)
                {
                    try
                    {
                        if (Ravan.Sece(vektori[i], vektori[j]) == 1 || Ravan.Sece(vektori[i], vektori[j]) == -2)
                        {
                            return false;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
            return true;
        }
        public double Obim()
        {
            double rez = 0;
            foreach (Vektor v in vektori)
            {
                rez += v.D;
            }
            return rez;
        }
        public double Povrsina()
        {
            int zbir = vektori[vektori.Count - 1].Kraj.X * vektori[0].Kraj.Y - vektori[vektori.Count - 1].Kraj.Y * vektori[0].Kraj.X;
            for (int i = 0; i < vektori.Count - 1; i++)
            {
                zbir += vektori[i].Kraj.X * vektori[i + 1].Kraj.Y;
                zbir -= vektori[i].Kraj.Y * vektori[i + 1].Kraj.X;
            }
            return (double)(zbir) / 2.0;
        }
        public bool jeKonveksan()
        {
            int k;
            k = Math.Sign(Ravan.VektorskiProizvod(vektori[vektori.Count - 1], vektori[0]));
            for(int i=0;i<vektori.Count - 2; i++)
            {
                if (Math.Sign(Ravan.VektorskiProizvod(vektori[i], vektori[i+1]))!=k)
                {
                    return false;
                }
            }
            return true;
        }
        public Poligon KonveksniPokrivac()
        {
            Poligon Pokrivac = new Poligon();
            int xLevo=int.MaxValue;
            for(int i=0;i<vektori.Count; i++)
            {
                if (vektori[i].Kraj.X < vektori[xLevo].Kraj.X) { xLevo = i; }
            }
            int p, q;
            p = xLevo;
            do
            {
                q = (p + 1) % vektori.Count;
                for (int i = 0; i < vektori.Count; i++)
                {
                    if (Ravan.Orijentacija(vektori[p].Kraj, vektori[i].Kraj, vektori[q].Kraj) == 2) q = i;
                }
                Pokrivac.Dodaj(new Vektor(vektori[p].Kraj, vektori[q].Kraj));
                p = q;
            }
            while(p != xLevo);
            return Pokrivac;
        }
        public bool PripadaTacka(Tacka A)
        {
            Tacka B = new Tacka(int.MaxValue,int.MaxValue);
            int k = 0;
            foreach (Vektor v in vektori)
            {
                if (Ravan.Sece(v, new Vektor(A, B)) == 1) k++;
                else if (Ravan.Sece(v, new Vektor(A, B)) == -2) return true;
            }
            return false; // dovrsi
        }
    }
}
