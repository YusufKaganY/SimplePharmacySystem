namespace VTYS_ECZS_AppV0
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.gridIlaclar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.gridSepet = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnSepetEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridIlaclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Seç:";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(102, 33);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(308, 24);
            this.cmbMusteri.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlaç/Barkod Ara:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(125, 84);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(172, 22);
            this.txtAra.TabIndex = 3;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // gridIlaclar
            // 
            this.gridIlaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIlaclar.Location = new System.Drawing.Point(19, 234);
            this.gridIlaclar.Name = "gridIlaclar";
            this.gridIlaclar.RowHeadersWidth = 51;
            this.gridIlaclar.RowTemplate.Height = 24;
            this.gridIlaclar.Size = new System.Drawing.Size(720, 501);
            this.gridIlaclar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adet:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(60, 123);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(237, 22);
            this.txtAdet.TabIndex = 6;
            // 
            // gridSepet
            // 
            this.gridSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSepet.Location = new System.Drawing.Point(815, 134);
            this.gridSepet.Name = "gridSepet";
            this.gridSepet.RowHeadersWidth = 51;
            this.gridSepet.RowTemplate.Height = 24;
            this.gridSepet.Size = new System.Drawing.Size(680, 485);
            this.gridSepet.TabIndex = 7;
            this.gridSepet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSepet_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(874, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(1175, 28);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(161, 46);
            this.lblToplamTutar.TabIndex = 9;
            this.lblToplamTutar.Text = "0.00 TL";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(1081, 641);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(222, 56);
            this.btnSatisYap.TabIndex = 10;
            this.btnSatisYap.Text = "Satışı Tamamla";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // btnSepetEkle
            // 
            this.btnSepetEkle.Location = new System.Drawing.Point(102, 161);
            this.btnSepetEkle.Name = "btnSepetEkle";
            this.btnSepetEkle.Size = new System.Drawing.Size(222, 56);
            this.btnSepetEkle.TabIndex = 11;
            this.btnSepetEkle.Text = "SEPETE EKLE";
            this.btnSepetEkle.UseVisualStyleBackColor = true;
            this.btnSepetEkle.Click += new System.EventHandler(this.btnSepetEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1066, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sepet Listesi";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 852);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSepetEkle);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridSepet);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridIlaclar);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "ECZS - Satış";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridIlaclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView gridIlaclar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.DataGridView gridSepet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnSepetEkle;
        private System.Windows.Forms.Label label6;
    }
}