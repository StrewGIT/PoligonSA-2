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
        public Form1()
        {
            InitializeComponent();
            poligon = new Poligon();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            PnlDrawing.Invalidate();
            PnlDrawing.Update();
            Tacka t = new Tacka(int.Parse(TboxX.Text) * 10, int.Parse(TboxY.Text) * 10);
            poligon.Dodaj(t);
            TboxX.Text = "";
            TboxY.Text = "";
            if(poligon.Count == 1)
            {
                double scale = 650.0 / (Math.Max(t.X, t.Y) * 1.1);
                using (Graphics g = PnlDrawing.CreateGraphics())
                {
                    Brush brush = Brushes.Black;
                    g.FillEllipse(brush, (int)(Math.Round(t.X * scale)) - dotSize / 2, (int)(Math.Round(t.Y * scale)) - dotSize / 2, dotSize, dotSize);
                }
            }
            else
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
                double scale = 650.0 / (Math.Max(x,y)*1.1);
                //MessageBox.Show(scale.ToString());
                Brush brush = Brushes.Black;
                using (Graphics g = PnlDrawing.CreateGraphics())
                {
                    for (int i = 0; i < poligon.Count; i++)
                    {
                        g.FillEllipse(brush, (int)((poligon.Vektori(i).Pocetak.relX - offx)*scale) - dotSize / 2, (int)((poligon.Vektori(i).Pocetak.relY - offy)*scale) - dotSize / 2, dotSize, dotSize);
                        //MessageBox.Show((poligon.Vektori(i).Pocetak.relX - offx).ToString()  + " " + (poligon.Vektori(i).Pocetak.relY- offy).ToString() );
                    }
                }
            }
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            poligon = new Poligon();
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
                poligon.Load();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlDrawing.Width = 500;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlDrawing.Width = 900;
        }
    }
}
