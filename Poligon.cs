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
    }
}
