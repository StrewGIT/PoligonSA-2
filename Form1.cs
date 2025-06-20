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
        Color c = Color.Black;
        Poligon poligon;
        bool freeze = false;
        public Form1()
        {
            InitializeComponent();
            poligon = new Poligon();
        }
        public void DrawAll()
        {
            int offx = -10;
            int offy = -10;
            int x = Math.Abs(poligon.Leftmost.X - poligon.Rightmost.X);
            //MessageBox.Show(poligon.Leftmost.X.ToString());
            if (poligon.Leftmost.relX < 0) offx = poligon.Leftmost.relX;
            //MessageBox.Show(offx.ToString());
            int y = Math.Abs(poligon.Topmost.Y - poligon.Bottommost.Y);
            //MessageBox.Show(poligon.Topmost.Y.ToString());
            if (poligon.Topmost.relY < 0) offy = poligon.Topmost.relY;
            //MessageBox.Show(offy.ToString());
            double scale = 650.0 / (Math.Max(x, y) * 1.3);
            //MessageBox.Show(scale.ToString());
            Brush brush = Brushes.Black;
            Pen pen = new Pen(c);
            using (Graphics g = PnlDrawing.CreateGraphics())
            {
                for (int i = 0; i < poligon.Count; i++)
                {
                    int xt = (int)((poligon.Vektori(i).Pocetak.relX - offx) * scale);
                    int yt = (int)((poligon.Vektori(i).Pocetak.relY - offy) * scale);
                    int xt1 = (int)((poligon.Vektori(i).Kraj.relX - offx) * scale);
                    int yt1 = (int)((poligon.Vektori(i).Kraj.relY - offy) * scale);
                    g.FillEllipse(brush, xt - dotSize / 2, yt - dotSize / 2, dotSize, dotSize);
                    //MessageBox.Show((poligon.Vektori(i).Pocetak.relX - offx).ToString()  + " " + (poligon.Vektori(i).Pocetak.relY- offy).ToString() );
                    g.DrawLine(pen, new Point(xt, yt), new Point(xt1, yt1));
                }
            }
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
                double scale = 650.0 / (Math.Max(t.X, t.Y) * 1.3);
                using (Graphics g = PnlDrawing.CreateGraphics())
                {
                    Brush brush = Brushes.Black;
                    g.FillEllipse(brush, (int)(Math.Round(t.X * scale)) - dotSize / 2, (int)(Math.Round(t.Y * scale)) - dotSize / 2, dotSize, dotSize);
                }
            }
            else
            {
                DrawAll();
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
                DrawAll();

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
    }
}
