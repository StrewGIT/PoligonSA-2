﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoligonSA
{
    public class Poligon
    {
        private List<Vektor> vektori;
        public Tacka Ref;
        public Vektor Vektori(int a)
        {
            return vektori[a];
        }
        public Tacka Leftmost
        {
            get
            {
                int xLevo = 0;
                for (int i = 0; i < vektori.Count; i++)
                {
                    if (vektori[i].Kraj.X < vektori[xLevo].Kraj.X) { xLevo = i; }
                }
                return vektori[xLevo].Kraj;
            }
        }
        public Tacka Rightmost
        {
            get
            {
                int xDesno = 0;
                for (int i = 0; i < vektori.Count; i++)
                {
                    if (vektori[i].Kraj.X > vektori[xDesno].Kraj.X) { xDesno = i; }
                }
                return vektori[xDesno].Kraj;
            }
        }
        public Tacka Topmost
        {
            get
            {
                int xGore = 0;
                for (int i = 0; i < vektori.Count; i++)
                {
                    if (vektori[i].Kraj.Y < vektori[xGore].Kraj.Y) { xGore = i; }
                }
                return vektori[xGore].Kraj;
            }
        }
        public Tacka Bottommost
        {
            get
            {
                int xDole = 0;
                for (int i = 0; i < vektori.Count; i++)
                {
                    if (vektori[i].Kraj.Y > vektori[xDole].Kraj.Y) { xDole = i; }
                }
                return vektori[xDole].Kraj;
            }
        }
        public int Count { get {  return vektori.Count; } }
        public Poligon()
        {
            vektori = new List<Vektor>();
        }
        //vektori.Add(new Vektor(vektor.Kraj, vektori[0].Pocetak));
        public void Dodaj(Tacka tacka)
        {
            if (vektori.Count > 1)
            {
                tacka.relX = tacka.X - vektori[0].Pocetak.X;
                tacka.relY = tacka.Y - vektori[0].Pocetak.Y;
                vektori.RemoveAt(vektori.Count - 1);
                vektori.Add(new Vektor(vektori.Last().Kraj, tacka));
                vektori.Add(new Vektor(tacka, vektori[0].Pocetak));
            }
            else if (vektori.Count > 0)
            {
                tacka.relX = tacka.X - vektori[0].Kraj.X;
                tacka.relY = tacka.Y - vektori[0].Kraj.Y;
                Vektor temp = new Vektor(vektori[0].Kraj, tacka);
                vektori.RemoveAt(0);
                vektori.Add(temp);
                vektori.Add(new Vektor(tacka, vektori[0].Pocetak));
            }
            else
            {
                tacka.relX = 0;
                tacka.relY = 0;
                Ref = tacka;
                vektori.Add(new Vektor(tacka));
            }


        }
        public void Dodaj(Vektor vektor)
        {
            vektori.Add(vektor);
        }
        public bool jeProst()
        {
            for (int i = 0; i < vektori.Count - 1; i++)
            {
                for (int j = i + 1; j < vektori.Count; j++)
                {
                    try
                    {
                        if (Ravan.Sece(vektori[i], vektori[j]) == 1 || Ravan.Sece(vektori[i], vektori[j]) == -2)
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
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
            if (!jeProst()) { throw new Exception("Poligon mora biti prost"); }
            if (Count < 3) { throw new Exception("Poligon mora imati minimum 3 temena"); }
            int zbir = vektori[vektori.Count - 1].Kraj.X * vektori[0].Kraj.Y - vektori[vektori.Count - 1].Kraj.Y * vektori[0].Kraj.X;
            for (int i = 0; i < vektori.Count - 1; i++)
            {
                zbir += vektori[i].Kraj.X * vektori[i + 1].Kraj.Y;
                zbir -= vektori[i].Kraj.Y * vektori[i + 1].Kraj.X;
            }
            return (double)(Math.Abs(zbir)) / 2.0;
        }
        public bool jeKonveksan()
        {
            if (!jeProst()) throw new Exception("Poligon mora biti prost");
            int k = 0;
            for (int i = 0; i < vektori.Count - 1; i++)
            {
                k = Math.Sign(Ravan.VektorskiProizvod(vektori[i], vektori[i + 1]));
                if (k != 0)
                    break;
            }
            if (k == 0)
                return false;
            for (int i = 0; i < vektori.Count - 1; i++)
            {
                int sign = Math.Sign(Ravan.VektorskiProizvod(vektori[i], vektori[i + 1]));
                if (sign != 0 && sign != k)
                    return false;
            }
            int lastSign = Math.Sign(Ravan.VektorskiProizvod(vektori[vektori.Count - 1], vektori[0]));
            if (lastSign != 0 && lastSign != k)
                return false;

            return true;
        }
        public Poligon KonveksniPokrivac()
        {
            
            Poligon Pokrivac = new Poligon();
            int xLevo = 0;
            for (int i = 0; i < vektori.Count; i++)
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
            while (p != xLevo);
            return Pokrivac;
        }
        public bool PripadaTacka(Tacka A)
        {
            if (!jeProst()) throw new Exception("Poligon mora biti prost");
            bool alternate = false;
            Random rand = new Random();
            Tacka B = new Tacka(10000, rand.Next(10000));
            int k = 0;
            foreach (Vektor v in vektori)
            {
                //Vektor v1 = new Vektor(new Tacka(v.Pocetak.relX, v.Pocetak.relY), new Tacka(v.Kraj.relX, v.Kraj.relY));
            //Loop:
                //MessageBox.Show(Ravan.Sece(v, new Vektor(A, B)).ToString());
                if (Ravan.Sece(v, new Vektor(A, B)) == 1) k++;
                else if (Ravan.Sece(v, new Vektor(A, B)) == -2 || Ravan.Sece(v, new Vektor(A, B)) == -1) return true;
                /*else if (Ravan.Sece(v, new Vektor(A, B)) == -3 || Ravan.Sece(v, new Vektor(A, B)) == -4)
                {
                    if (alternate)
                    {
                        B = new Tacka(10000, rand.Next(10000));
                        alternate = false;
                    }
                    else
                    {
                        B = new Tacka(rand.Next(10000), 10000);
                        alternate = true;
                    }
                    goto Loop;*/
                //}
            }
            //MessageBox.Show("k:" + k.ToString());
            return (k % 2 == 1);
        }
        public void Save()
        {
            if (vektori.Count < 3) { throw (new ArgumentException("Poligon mora imati 3 temena")); }
            else
            {
                StreamWriter sr = new StreamWriter("poligon.txt") ;
                foreach (Vektor v in vektori)
                {
                    sr.WriteLine(v.Pocetak.X.ToString() + " " + v.Pocetak.Y.ToString());
                }
                sr.Close();
            }
        }
        public void Load()
        {
            StreamReader sr = new StreamReader("poligon.txt");
            while (!sr.EndOfStream)
            {
                string[] strings = sr.ReadLine().Split(' ');
                Dodaj(new Tacka(int.Parse(strings[0]), int.Parse(strings[1])));
            }
            sr.Close();
        }
        public (double,double) Teziste
        {
            get
            {
                double Xc = 1 / (6 * Povrsina());
                double Yc = 1 / (6 * Povrsina());
                double Xs= 0, Ys= 0;
                for(int i = 0; i < Count; i++)
                {
                    Xs += ((vektori[i].Pocetak.X) + vektori[(i + 1) % Count].Pocetak.X) * ((vektori[i].Pocetak.X* vektori[(i + 1) % Count].Pocetak.Y) - (vektori[i].Pocetak.Y * vektori[(i + 1) % Count].Pocetak.X));
                    Ys += (vektori[i].Pocetak.Y + vektori[(i + 1) % Count].Pocetak.Y) * ((vektori[i].Pocetak.X * vektori[(i + 1) % Count].Pocetak.Y) - (vektori[i].Pocetak.Y * vektori[(i + 1) % Count].Pocetak.X));
                }
                return (Xs * Xc, Ys * Yc);
            }
        }
        public double MomentInercije()
        {
            if (Count < 3)
                throw new Exception("Poligon mora imati bar 3 temena");

            (double,double) C = Teziste;
            double inertia = 0;

            for (int i = 0; i < Count; i++)
            {
                (double, double) A = (vektori[i].Pocetak.X, vektori[i].Pocetak.Y);
                (double, double) B = (vektori[(i + 1) % Count].Pocetak.X, vektori[(i + 1) % Count].Pocetak.Y);

                double x0 = A.Item1 - C.Item1;
                double y0 = A.Item2 - C.Item2;
                double x1 = B.Item1 - C.Item1;
                double y1 = B.Item2 - C.Item2;

                double cross = x0 * y1 - x1 * y0;

                double term = (x0 * x0 + x0 * x1 + x1 * x1 +
                               y0 * y0 + y0 * y1 + y1 * y1);

                inertia += cross * term;
            }

            return Math.Abs(inertia) / 12.0;
        }
    }
}
