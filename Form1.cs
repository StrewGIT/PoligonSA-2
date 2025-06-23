using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
namespace PoligonSA
{
    public partial class Form1 : Form
    {
        int dotSize = 9;
        Poligon poligon;
        bool freeze = false;
        double currentScale;
        int coffx, coffy;
        public Form1()
        {
            InitializeComponent();
            poligon = new Poligon();
        }
        public void DrawAll(Poligon P,Color c)
        {
            int offx = -10;
            int offy = -10;
            int x = Math.Abs(P.Leftmost.X - P.Rightmost.X);
            //MessageBox.Show(P.Leftmost.X.ToString());
            if (P.Leftmost.relX < 0) offx = P.Leftmost.relX;
            //MessageBox.Show(offx.ToString());
            int y = Math.Abs(P.Topmost.Y - P.Bottommost.Y);
            //MessageBox.Show(P.Topmost.Y.ToString());
            if (P.Topmost.relY < 0) offy = P.Topmost.relY;
            //MessageBox.Show(offy.ToString());
            double scale = 650.0 / (Math.Max(x, y) * 1.4);
            //MessageBox.Show(scale.ToString());
            Brush brush = Brushes.Black;
            Pen pen = new Pen(c);
            using (Graphics g = PnlDrawing.CreateGraphics())
            {
                for (int i = 0; i < P.Count; i++)
                {
                    int xt = (int)((P.Vektori(i).Pocetak.relX - offx) * scale);
                    int yt = (int)((P.Vektori(i).Pocetak.relY - offy) * scale);
                    int xt1 = (int)((P.Vektori(i).Kraj.relX - offx) * scale);
                    int yt1 = (int)((P.Vektori(i).Kraj.relY - offy) * scale);
                    g.FillEllipse(brush, xt - dotSize / 2, yt - dotSize / 2, dotSize, dotSize);
                    //MessageBox.Show((P.Vektori(i).Pocetak.relX - offx).ToString()  + " " + (P.Vektori(i).Pocetak.relY- offy).ToString() );
                    g.DrawLine(pen, new Point(xt, yt), new Point(xt1, yt1));
                }
            }
            currentScale = scale;
            coffx = offx;
            coffy = offy;
        }
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            PnlDrawing.Invalidate();
            PnlDrawing.Update();
            try
            {
                Tacka t = new Tacka(int.Parse(TboxX.Text)*10, int.Parse(TboxY.Text)*10);
                poligon.Dodaj(t);
                TboxX.Text = "";
                TboxY.Text = "";
                if (poligon.Count == 1)
                {
                    double scale = 650.0 / (Math.Max(t.X, t.Y) * 1.4);
                    using (Graphics g = PnlDrawing.CreateGraphics())
                    {
                        Brush brush = Brushes.Black;
                        g.FillEllipse(brush, (int)(Math.Round(t.X * scale)) - dotSize / 2, (int)(Math.Round(t.Y * scale)) - dotSize / 2, dotSize, dotSize);
                    }
                    currentScale = scale;
                }
                else
                {
                    DrawAll(poligon, Color.Black);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            poligon = new Poligon();
            PnlDrawing.Invalidate();
            PnlDrawing.Update();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                poligon.Save();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                poligon = new Poligon();
                poligon.Load();
                DrawAll(poligon,Color.Black);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnObim_Click(object sender, EventArgs e)
        {
            MessageBox.Show(poligon.Obim().ToString());
        }

        private void BtnProst_Click(object sender, EventArgs e)
        {
            if (poligon.jeProst()) MessageBox.Show("Poligon je prost");
            else MessageBox.Show("Poligon nije prost");
        }

        private void BtnPovrsina_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(poligon.Povrsina().ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnKonveksan_Click(object sender, EventArgs e)
        {
            if (poligon.jeKonveksan()) MessageBox.Show("Poligon je konveksan");
            else MessageBox.Show("Poligon je konkavan");
        }

        private void BtnOmotac_Click(object sender, EventArgs e)
        {
            if (poligon.jeKonveksan())
            {
                MessageBox.Show("Poligon mora biti konkavan");
            }
            else
            {
                try
                {
                DrawAll(poligon.KonveksniPokrivac(),Color.Orange);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlDrawing.Invalidate();
            PnlDrawing.Update();
            DrawAll(poligon, Color.Black);
        }

        private void BtnPripadnost_Click(object sender, EventArgs e)
        {
            Tacka tacka = new Tacka(int.Parse(TboxXPr.Text) * 10, int.Parse(TboxYPr.Text) * 10);
            Pripadnost(tacka);
        }
        public void Pripadnost(Tacka t)
        {
            try
            {
                if (poligon.PripadaTacka(t)) { MessageBox.Show("Pripada"); }
                else MessageBox.Show("Ne pripada");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnBojenje_Click(object sender, EventArgs e)
        {
            if (!poligon.jeProst()) { MessageBox.Show("Poligon mora biti prost");return; }
            for (int i = poligon.Leftmost.X; i < poligon.Rightmost.X; i++)
            {
                for(int j = poligon.Topmost.Y; j < poligon.Bottommost.Y; j++)
                {
                    Brush brush = Brushes.Green;
                    Tacka t = new Tacka(i,j);
                    t.relX = t.X - poligon.Ref.X;
                    t.relY = t.Y - poligon.Ref.Y;
                    try
                    {
                        if (poligon.PripadaTacka(t))
                        {
                            using (Graphics g = PnlDrawing.CreateGraphics())
                            {
                                int xt = (int)((t.relX - coffx) * currentScale);
                                int yt = (int)((t.relY - coffy) * currentScale);
                                g.FillEllipse(brush, xt - dotSize / 2, yt - dotSize / 2, dotSize, dotSize);
                            }
                        }
                    }
                    catch (Exception ex) {MessageBox.Show(ex.Message); }
                }
            }
        }

        private void BtnTeziste_Click(object sender, EventArgs e)
        {
            Tacka t = new Tacka((int)Math.Round(poligon.Teziste.Item1),(int)Math.Round(poligon.Teziste.Item2));
            t.relX = t.X - poligon.Ref.X;
            t.relY = t.Y - poligon.Ref.Y;
            int xt = (int)((t.relX - coffx) * currentScale);
            int yt = (int)((t.relY - coffy) * currentScale);
            using (Graphics g = PnlDrawing.CreateGraphics())
            {
                g.FillEllipse(Brushes.DarkOrange, xt - dotSize / 2, yt - dotSize / 2, dotSize, dotSize);
            }
        }

        private void BtnMomentInercije_Click(object sender, EventArgs e)
        {
            MessageBox.Show(poligon.MomentInercije().ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
