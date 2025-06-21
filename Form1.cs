using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
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
            Tacka t = new Tacka(int.Parse(TboxX.Text)*10, int.Parse(TboxY.Text)*10);
            poligon.Dodaj(t);
            TboxX.Text = "";
            TboxY.Text = "";
            if(poligon.Count == 1)
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
                DrawAll(poligon,Color.Black);
            }
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
                DrawAll(poligon.KonveksniPokrivac(),Color.Orange);
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
            MessageBox.Show("Da biste proverili pripadnost tačke poligonu, pritisnite na panelu gde se vaša tačka nalazi, ona će biti obojena zeleno ako se nalazi u poligonu, a crveno ako se nalazi izvan","Info");
        }

        private void PnlDrawing_MouseClick(object sender, MouseEventArgs e)
        {
            Tacka tacka = new Tacka((int)(Math.Round((e.X+(coffx/currentScale))/currentScale)), (int)(Math.Round((e.Y + (coffy/currentScale)) / currentScale)));
            Brush brush = Brushes.Transparent;
            try
            {
                if (poligon.PripadaTacka(tacka)) { brush = Brushes.Green; }
                else brush = Brushes.Red;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            using (Graphics g = PnlDrawing.CreateGraphics())
                {
                    g.FillEllipse(brush, e.X - dotSize / 2, e.Y - dotSize / 2, dotSize, dotSize);
                }
        }
    }
}
