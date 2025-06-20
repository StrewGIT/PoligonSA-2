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
            this.BtnObrisi = new System.Windows.Forms.Button();
            this.LblNaslov = new System.Windows.Forms.Label();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.BtnDodaj.Location = new System.Drawing.Point(725, 105);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(123, 30);
            this.BtnDodaj.TabIndex = 5;
            this.BtnDodaj.Text = "Dodaj tačku";
            this.BtnDodaj.UseVisualStyleBackColor = false;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(725, 206);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(292, 456);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // BtnObrisi
            // 
            this.BtnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BtnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnObrisi.Location = new System.Drawing.Point(894, 105);
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
            this.BtnLoad.Location = new System.Drawing.Point(894, 150);
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
            this.BtnSave.Location = new System.Drawing.Point(725, 150);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(123, 30);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Sačuvaj";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 681);
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
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

