namespace VTYS_ECZS_AppV0
{
    partial class Form6
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
            this.lblCiro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSatisSayisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKDV = new System.Windows.Forms.Label();
            this.gridRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugünkü Ciro:";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiro.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCiro.Location = new System.Drawing.Point(388, 29);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(110, 32);
            this.lblCiro.TabIndex = 1;
            this.lblCiro.Text = "0.00 TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Satış Sayısı:";
            // 
            // lblSatisSayisi
            // 
            this.lblSatisSayisi.AutoSize = true;
            this.lblSatisSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisSayisi.Location = new System.Drawing.Point(741, 39);
            this.lblSatisSayisi.Name = "lblSatisSayisi";
            this.lblSatisSayisi.Size = new System.Drawing.Size(18, 20);
            this.lblSatisSayisi.TabIndex = 3;
            this.lblSatisSayisi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "KDV Dahil:";
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKDV.Location = new System.Drawing.Point(890, 39);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(65, 20);
            this.lblKDV.TabIndex = 5;
            this.lblKDV.Text = "0.00 TL";
            // 
            // gridRapor
            // 
            this.gridRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRapor.Location = new System.Drawing.Point(5, 75);
            this.gridRapor.Name = "gridRapor";
            this.gridRapor.RowHeadersWidth = 51;
            this.gridRapor.RowTemplate.Height = 24;
            this.gridRapor.Size = new System.Drawing.Size(1291, 573);
            this.gridRapor.TabIndex = 6;
            this.gridRapor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRapor_CellContentClick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 722);
            this.Controls.Add(this.gridRapor);
            this.Controls.Add(this.lblKDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSatisSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCiro);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "ECZS - Raporlar";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSatisSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKDV;
        private System.Windows.Forms.DataGridView gridRapor;
    }
}