namespace ShutdownApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dodajGodzine = new System.Windows.Forms.Button();
            this.odejmijGodzine = new System.Windows.Forms.Button();
            this.odejmijGodziny = new System.Windows.Forms.Button();
            this.dodajMinute = new System.Windows.Forms.Button();
            this.dodajMinuty = new System.Windows.Forms.Button();
            this.dodajGodziny = new System.Windows.Forms.Button();
            this.odejmijMinute = new System.Windows.Forms.Button();
            this.odejmijMinuty = new System.Windows.Forms.Button();
            this.odliczaj = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 160F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(107, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 249);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OldLace;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 160F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(525, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 249);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(413, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "h";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(831, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "m";
            this.label2.UseWaitCursor = true;
            // 
            // dodajGodzine
            // 
            this.dodajGodzine.BackColor = System.Drawing.Color.Snow;
            this.dodajGodzine.Location = new System.Drawing.Point(201, 62);
            this.dodajGodzine.Name = "dodajGodzine";
            this.dodajGodzine.Size = new System.Drawing.Size(100, 38);
            this.dodajGodzine.TabIndex = 5;
            this.dodajGodzine.Text = "+1";
            this.dodajGodzine.UseVisualStyleBackColor = false;
            this.dodajGodzine.UseWaitCursor = true;
            this.dodajGodzine.Click += new System.EventHandler(this.dodajGodzine_Click);
            // 
            // odejmijGodzine
            // 
            this.odejmijGodzine.BackColor = System.Drawing.Color.Snow;
            this.odejmijGodzine.Location = new System.Drawing.Point(201, 361);
            this.odejmijGodzine.Name = "odejmijGodzine";
            this.odejmijGodzine.Size = new System.Drawing.Size(100, 40);
            this.odejmijGodzine.TabIndex = 6;
            this.odejmijGodzine.Text = "-1";
            this.odejmijGodzine.UseVisualStyleBackColor = false;
            this.odejmijGodzine.UseWaitCursor = true;
            this.odejmijGodzine.Click += new System.EventHandler(this.odejmijGodzine_Click);
            // 
            // odejmijGodziny
            // 
            this.odejmijGodziny.BackColor = System.Drawing.Color.Snow;
            this.odejmijGodziny.Location = new System.Drawing.Point(201, 407);
            this.odejmijGodziny.Name = "odejmijGodziny";
            this.odejmijGodziny.Size = new System.Drawing.Size(100, 39);
            this.odejmijGodziny.TabIndex = 7;
            this.odejmijGodziny.Text = "-10";
            this.odejmijGodziny.UseVisualStyleBackColor = false;
            this.odejmijGodziny.UseWaitCursor = true;
            this.odejmijGodziny.Click += new System.EventHandler(this.odejmijGodziny_Click);
            // 
            // dodajMinute
            // 
            this.dodajMinute.BackColor = System.Drawing.Color.Snow;
            this.dodajMinute.Location = new System.Drawing.Point(634, 17);
            this.dodajMinute.Name = "dodajMinute";
            this.dodajMinute.Size = new System.Drawing.Size(90, 38);
            this.dodajMinute.TabIndex = 8;
            this.dodajMinute.Text = "+10";
            this.dodajMinute.UseVisualStyleBackColor = false;
            this.dodajMinute.UseWaitCursor = true;
            this.dodajMinute.Click += new System.EventHandler(this.dodajMinute_Click);
            // 
            // dodajMinuty
            // 
            this.dodajMinuty.BackColor = System.Drawing.Color.Snow;
            this.dodajMinuty.Location = new System.Drawing.Point(634, 62);
            this.dodajMinuty.Name = "dodajMinuty";
            this.dodajMinuty.Size = new System.Drawing.Size(90, 38);
            this.dodajMinuty.TabIndex = 9;
            this.dodajMinuty.Text = "+5";
            this.dodajMinuty.UseVisualStyleBackColor = false;
            this.dodajMinuty.UseWaitCursor = true;
            this.dodajMinuty.Click += new System.EventHandler(this.dodajMinuty_Click);
            // 
            // dodajGodziny
            // 
            this.dodajGodziny.BackColor = System.Drawing.Color.Snow;
            this.dodajGodziny.Location = new System.Drawing.Point(201, 12);
            this.dodajGodziny.Name = "dodajGodziny";
            this.dodajGodziny.Size = new System.Drawing.Size(100, 43);
            this.dodajGodziny.TabIndex = 10;
            this.dodajGodziny.Text = "+10";
            this.dodajGodziny.UseVisualStyleBackColor = false;
            this.dodajGodziny.UseWaitCursor = true;
            this.dodajGodziny.Click += new System.EventHandler(this.dodajGodziny_Click);
            // 
            // odejmijMinute
            // 
            this.odejmijMinute.BackColor = System.Drawing.Color.Snow;
            this.odejmijMinute.Location = new System.Drawing.Point(634, 361);
            this.odejmijMinute.Name = "odejmijMinute";
            this.odejmijMinute.Size = new System.Drawing.Size(90, 40);
            this.odejmijMinute.TabIndex = 11;
            this.odejmijMinute.Text = "-5";
            this.odejmijMinute.UseVisualStyleBackColor = false;
            this.odejmijMinute.UseWaitCursor = true;
            this.odejmijMinute.Click += new System.EventHandler(this.odejmijMinute_Click);
            // 
            // odejmijMinuty
            // 
            this.odejmijMinuty.BackColor = System.Drawing.Color.Snow;
            this.odejmijMinuty.Location = new System.Drawing.Point(634, 407);
            this.odejmijMinuty.Name = "odejmijMinuty";
            this.odejmijMinuty.Size = new System.Drawing.Size(90, 39);
            this.odejmijMinuty.TabIndex = 12;
            this.odejmijMinuty.Text = "-10";
            this.odejmijMinuty.UseVisualStyleBackColor = false;
            this.odejmijMinuty.UseWaitCursor = true;
            this.odejmijMinuty.Click += new System.EventHandler(this.odejmijMinuty_Click);
            // 
            // odliczaj
            // 
            this.odliczaj.BackColor = System.Drawing.Color.Snow;
            this.odliczaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odliczaj.Location = new System.Drawing.Point(165, 474);
            this.odliczaj.Name = "odliczaj";
            this.odliczaj.Size = new System.Drawing.Size(168, 57);
            this.odliczaj.TabIndex = 13;
            this.odliczaj.Text = "Odliczaj";
            this.odliczaj.UseVisualStyleBackColor = false;
            this.odliczaj.UseWaitCursor = true;
            this.odliczaj.Click += new System.EventHandler(this.odliczaj_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.BackColor = System.Drawing.Color.Snow;
            this.Anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Anuluj.Location = new System.Drawing.Point(590, 474);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(179, 57);
            this.Anuluj.TabIndex = 14;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = false;
            this.Anuluj.UseWaitCursor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(945, 555);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.odliczaj);
            this.Controls.Add(this.odejmijMinuty);
            this.Controls.Add(this.odejmijMinute);
            this.Controls.Add(this.dodajGodziny);
            this.Controls.Add(this.dodajMinuty);
            this.Controls.Add(this.dodajMinute);
            this.Controls.Add(this.odejmijGodziny);
            this.Controls.Add(this.odejmijGodzine);
            this.Controls.Add(this.dodajGodzine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "MainWindow";
            this.Text = "ShutdownApp";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodajGodzine;
        private System.Windows.Forms.Button odejmijGodzine;
        private System.Windows.Forms.Button odejmijGodziny;
        private System.Windows.Forms.Button dodajMinute;
        private System.Windows.Forms.Button dodajMinuty;
        private System.Windows.Forms.Button dodajGodziny;
        private System.Windows.Forms.Button odejmijMinute;
        private System.Windows.Forms.Button odejmijMinuty;
        private System.Windows.Forms.Button odliczaj;
        private System.Windows.Forms.Button Anuluj;
    }
}

