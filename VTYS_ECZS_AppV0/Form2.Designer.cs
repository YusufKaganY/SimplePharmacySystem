namespace VTYS_ECZS_AppV0
{
    partial class Form2
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
            this.btnIlaclar = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnLoglar = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIlaclar
            // 
            this.btnIlaclar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIlaclar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIlaclar.FlatAppearance.BorderSize = 0;
            this.btnIlaclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIlaclar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIlaclar.Location = new System.Drawing.Point(12, 12);
            this.btnIlaclar.Name = "btnIlaclar";
            this.btnIlaclar.Size = new System.Drawing.Size(187, 86);
            this.btnIlaclar.TabIndex = 0;
            this.btnIlaclar.Text = "İLAÇLAR";
            this.btnIlaclar.UseVisualStyleBackColor = false;
            this.btnIlaclar.Click += new System.EventHandler(this.btnIlaclar_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMusteriler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriler.FlatAppearance.BorderSize = 0;
            this.btnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMusteriler.Location = new System.Drawing.Point(259, 12);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(187, 86);
            this.btnMusteriler.TabIndex = 1;
            this.btnMusteriler.Text = "MÜŞTERİLER";
            this.btnMusteriler.UseVisualStyleBackColor = false;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSatisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatisYap.FlatAppearance.BorderSize = 0;
            this.btnSatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisYap.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSatisYap.Location = new System.Drawing.Point(12, 119);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(187, 86);
            this.btnSatisYap.TabIndex = 2;
            this.btnSatisYap.Text = "SATIŞ YAP";
            this.btnSatisYap.UseVisualStyleBackColor = false;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRaporlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaporlar.FlatAppearance.BorderSize = 0;
            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporlar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRaporlar.Location = new System.Drawing.Point(259, 119);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(187, 86);
            this.btnRaporlar.TabIndex = 3;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Crimson;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCikis.Location = new System.Drawing.Point(283, 228);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(139, 62);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnLoglar
            // 
            this.btnLoglar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnLoglar.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnLoglar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoglar.FlatAppearance.BorderSize = 0;
            this.btnLoglar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoglar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoglar.Location = new System.Drawing.Point(39, 228);
            this.btnLoglar.Name = "btnLoglar";
            this.btnLoglar.Size = new System.Drawing.Size(139, 62);
            this.btnLoglar.TabIndex = 5;
            this.btnLoglar.Text = "KAYIT DEFTERİ";
            this.btnLoglar.UseVisualStyleBackColor = false;
            this.btnLoglar.Click += new System.EventHandler(this.btnLoglar_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(36, 325);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(80, 16);
            this.lblKullanici.TabIndex = 6;
            this.lblKullanici.Text = "PERSONEL";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 366);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnLoglar);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnIlaclar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form2";
            this.Text = "ECZS-MENU";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIlaclar;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnLoglar;
        private System.Windows.Forms.Label lblKullanici;
    }
}