namespace PoligonSA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlDrawing = new System.Windows.Forms.Panel();
            this.TboxX = new System.Windows.Forms.TextBox();
            this.TboxY = new System.Windows.Forms.TextBox();
            this.LblX = new System.Windows.Forms.Label();
            this.LblY = new System.Windows.Forms.Label();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnObim = new System.Windows.Forms.Button();
            this.BtnProst = new System.Windows.Forms.Button();
            this.BtnPovrsina = new System.Windows.Forms.Button();
            this.BtnKonveksan = new System.Windows.Forms.Button();
            this.BtnOmotac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TboxXPr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TboxYPr = new System.Windows.Forms.TextBox();
            this.BtnPripadnost = new System.Windows.Forms.Button();
            this.BtnBojenje = new System.Windows.Forms.Button();
            this.BtnTeziste = new System.Windows.Forms.Button();
            this.BtnMomentInercije = new System.Windows.Forms.Button();
            this.BtnObrisi = new System.Windows.Forms.Button();
            this.LblNaslov = new System.Windows.Forms.Label();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlDrawing
            // 
            this.PnlDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDrawing.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlDrawing.Location = new System.Drawing.Point(12, 12);
            this.PnlDrawing.Name = "PnlDrawing";
            this.PnlDrawing.Size = new System.Drawing.Size(650, 650);
            this.PnlDrawing.TabIndex = 0;
            // 
            // TboxX
            // 
            this.TboxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxX.Location = new System.Drawing.Point(748, 64);
            this.TboxX.Name = "TboxX";
            this.TboxX.Size = new System.Drawing.Size(100, 26);
            this.TboxX.TabIndex = 1;
            // 
            // TboxY
            // 
            this.TboxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxY.Location = new System.Drawing.Point(917, 64);
            this.TboxY.Name = "TboxY";
            this.TboxY.Size = new System.Drawing.Size(100, 26);
            this.TboxY.TabIndex = 2;
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX.Location = new System.Drawing.Point(721, 67);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(21, 20);
            this.LblX.TabIndex = 3;
            this.LblX.Text = "X";
            // 
            // LblY
            // 
            this.LblY.AutoSize = true;
            this.LblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblY.Location = new System.Drawing.Point(890, 67);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(21, 20);
            this.LblY.TabIndex = 4;
            this.LblY.Text = "Y";
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(250)))), ((int)(((byte)(158)))));
            this.BtnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodaj.Location = new System.Drawing.Point(725, 180);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(123, 30);
            this.BtnDodaj.TabIndex = 5;
            this.BtnDodaj.Text = "Dodaj tačku";
            this.BtnDodaj.UseVisualStyleBackColor = false;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnObim);
            this.flowLayoutPanel1.Controls.Add(this.BtnProst);
            this.flowLayoutPanel1.Controls.Add(this.BtnPovrsina);
            this.flowLayoutPanel1.Controls.Add(this.BtnKonveksan);
            this.flowLayoutPanel1.Controls.Add(this.BtnOmotac);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.TboxXPr);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TboxYPr);
            this.flowLayoutPanel1.Controls.Add(this.BtnPripadnost);
            this.flowLayoutPanel1.Controls.Add(this.BtnBojenje);
            this.flowLayoutPanel1.Controls.Add(this.BtnTeziste);
            this.flowLayoutPanel1.Controls.Add(this.BtnMomentInercije);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(725, 279);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 362);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // BtnObim
            // 
            this.BtnObim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnObim.Location = new System.Drawing.Point(3, 3);
            this.BtnObim.Name = "BtnObim";
            this.BtnObim.Size = new System.Drawing.Size(144, 49);
            this.BtnObim.TabIndex = 0;
            this.BtnObim.Text = "Obim";
            this.BtnObim.UseVisualStyleBackColor = true;
            this.BtnObim.Click += new System.EventHandler(this.BtnObim_Click);
            // 
            // BtnProst
            // 
            this.BtnProst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProst.Location = new System.Drawing.Point(153, 3);
            this.BtnProst.Name = "BtnProst";
            this.BtnProst.Size = new System.Drawing.Size(144, 49);
            this.BtnProst.TabIndex = 1;
            this.BtnProst.Text = "Da li je prost?";
            this.BtnProst.UseVisualStyleBackColor = true;
            this.BtnProst.Click += new System.EventHandler(this.BtnProst_Click);
            // 
            // BtnPovrsina
            // 
            this.BtnPovrsina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPovrsina.Location = new System.Drawing.Point(3, 58);
            this.BtnPovrsina.Name = "BtnPovrsina";
            this.BtnPovrsina.Size = new System.Drawing.Size(144, 49);
            this.BtnPovrsina.TabIndex = 2;
            this.BtnPovrsina.Text = "Površina";
            this.BtnPovrsina.UseVisualStyleBackColor = true;
            this.BtnPovrsina.Click += new System.EventHandler(this.BtnPovrsina_Click);
            // 
            // BtnKonveksan
            // 
            this.BtnKonveksan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKonveksan.Location = new System.Drawing.Point(153, 58);
            this.BtnKonveksan.Name = "BtnKonveksan";
            this.BtnKonveksan.Size = new System.Drawing.Size(144, 49);
            this.BtnKonveksan.TabIndex = 3;
            this.BtnKonveksan.Text = "Da li je konveksan?";
            this.BtnKonveksan.UseVisualStyleBackColor = true;
            this.BtnKonveksan.Click += new System.EventHandler(this.BtnKonveksan_Click);
            // 
            // BtnOmotac
            // 
            this.BtnOmotac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOmotac.Location = new System.Drawing.Point(3, 113);
            this.BtnOmotac.Name = "BtnOmotac";
            this.BtnOmotac.Size = new System.Drawing.Size(144, 49);
            this.BtnOmotac.TabIndex = 4;
            this.BtnOmotac.Text = "Konveksni omotac";
            this.BtnOmotac.UseVisualStyleBackColor = true;
            this.BtnOmotac.Click += new System.EventHandler(this.BtnOmotac_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(153, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ponovo nacrtaj - undo Konveksni omotac";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TboxXPr
            // 
            this.TboxXPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxXPr.Location = new System.Drawing.Point(30, 168);
            this.TboxXPr.Name = "TboxXPr";
            this.TboxXPr.Size = new System.Drawing.Size(100, 26);
            this.TboxXPr.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Y";
            // 
            // TboxYPr
            // 
            this.TboxYPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxYPr.Location = new System.Drawing.Point(163, 168);
            this.TboxYPr.Name = "TboxYPr";
            this.TboxYPr.Size = new System.Drawing.Size(100, 26);
            this.TboxYPr.TabIndex = 12;
            // 
            // BtnPripadnost
            // 
            this.BtnPripadnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPripadnost.Location = new System.Drawing.Point(3, 200);
            this.BtnPripadnost.Name = "BtnPripadnost";
            this.BtnPripadnost.Size = new System.Drawing.Size(294, 49);
            this.BtnPripadnost.TabIndex = 6;
            this.BtnPripadnost.Text = "Provera pripadnosti tacke poligonu";
            this.BtnPripadnost.UseVisualStyleBackColor = true;
            this.BtnPripadnost.Click += new System.EventHandler(this.BtnPripadnost_Click);
            // 
            // BtnBojenje
            // 
            this.BtnBojenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBojenje.Location = new System.Drawing.Point(3, 255);
            this.BtnBojenje.Name = "BtnBojenje";
            this.BtnBojenje.Size = new System.Drawing.Size(294, 49);
            this.BtnBojenje.TabIndex = 16;
            this.BtnBojenje.Text = "Bojenje poligona";
            this.BtnBojenje.UseVisualStyleBackColor = true;
            this.BtnBojenje.Click += new System.EventHandler(this.BtnBojenje_Click);
            // 
            // BtnTeziste
            // 
            this.BtnTeziste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeziste.Location = new System.Drawing.Point(3, 310);
            this.BtnTeziste.Name = "BtnTeziste";
            this.BtnTeziste.Size = new System.Drawing.Size(144, 49);
            this.BtnTeziste.TabIndex = 17;
            this.BtnTeziste.Text = "Težište";
            this.BtnTeziste.UseVisualStyleBackColor = true;
            this.BtnTeziste.Click += new System.EventHandler(this.BtnTeziste_Click);
            // 
            // BtnMomentInercije
            // 
            this.BtnMomentInercije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMomentInercije.Location = new System.Drawing.Point(153, 310);
            this.BtnMomentInercije.Name = "BtnMomentInercije";
            this.BtnMomentInercije.Size = new System.Drawing.Size(144, 49);
            this.BtnMomentInercije.TabIndex = 18;
            this.BtnMomentInercije.Text = "Moment inercije";
            this.BtnMomentInercije.UseVisualStyleBackColor = true;
            this.BtnMomentInercije.Click += new System.EventHandler(this.BtnMomentInercije_Click);
            // 
            // BtnObrisi
            // 
            this.BtnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnObrisi.Location = new System.Drawing.Point(894, 180);
            this.BtnObrisi.Name = "BtnObrisi";
            this.BtnObrisi.Size = new System.Drawing.Size(123, 30);
            this.BtnObrisi.TabIndex = 7;
            this.BtnObrisi.Text = "Obriši poligon";
            this.BtnObrisi.UseVisualStyleBackColor = false;
            this.BtnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // LblNaslov
            // 
            this.LblNaslov.AutoSize = true;
            this.LblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNaslov.Location = new System.Drawing.Point(686, 12);
            this.LblNaslov.Name = "LblNaslov";
            this.LblNaslov.Size = new System.Drawing.Size(340, 31);
            this.LblNaslov.TabIndex = 9;
            this.LblNaslov.Text = "Poligon - Stefan Andrejević";
            // 
            // BtnLoad
            // 
            this.BtnLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.Location = new System.Drawing.Point(894, 225);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(123, 30);
            this.BtnLoad.TabIndex = 11;
            this.BtnLoad.Text = "Učitaj";
            this.BtnLoad.UseVisualStyleBackColor = false;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(725, 225);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(123, 30);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Sačuvaj";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(708, 110);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(352, 40);
            this.LblInfo.TabIndex = 12;
            this.LblInfo.Text = "Koordinate se računaju 10 puta veće nego \r\nzapisane zbog preciznosti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 681);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblNaslov);
            this.Controls.Add(this.BtnObrisi);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.LblY);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.TboxY);
            this.Controls.Add(this.TboxX);
            this.Controls.Add(this.PnlDrawing);
            this.Name = "Form1";
            this.Text = "Poligon";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlDrawing;
        private System.Windows.Forms.TextBox TboxX;
        private System.Windows.Forms.TextBox TboxY;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnObrisi;
        private System.Windows.Forms.Label LblNaslov;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnObim;
        private System.Windows.Forms.Button BtnProst;
        private System.Windows.Forms.Button BtnPovrsina;
        private System.Windows.Forms.Button BtnKonveksan;
        private System.Windows.Forms.Button BtnOmotac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnPripadnost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TboxYPr;
        private System.Windows.Forms.TextBox TboxXPr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBojenje;
        private System.Windows.Forms.Button BtnTeziste;
        private System.Windows.Forms.Button BtnMomentInercije;
        private System.Windows.Forms.Label LblInfo;
    }
}

