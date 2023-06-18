
namespace Gelir_Gider_Takip
{
    partial class GiderTipi_Ekle
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gider_kod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gider_ad = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gider Tip Kod";
            // 
            // txt_gider_kod
            // 
            this.txt_gider_kod.Location = new System.Drawing.Point(87, 26);
            this.txt_gider_kod.Name = "txt_gider_kod";
            this.txt_gider_kod.Size = new System.Drawing.Size(147, 20);
            this.txt_gider_kod.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gider Tip Ad";
            // 
            // txt_gider_ad
            // 
            this.txt_gider_ad.Location = new System.Drawing.Point(87, 52);
            this.txt_gider_ad.Name = "txt_gider_ad";
            this.txt_gider_ad.Size = new System.Drawing.Size(147, 20);
            this.txt_gider_ad.TabIndex = 23;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(37, 97);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(114, 62);
            this.btn_sil.TabIndex = 26;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(157, 97);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(116, 62);
            this.btn_kaydet.TabIndex = 25;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_kapat.Location = new System.Drawing.Point(0, 172);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(311, 62);
            this.btn_kapat.TabIndex = 27;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // GiderTipi_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 234);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_gider_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_gider_kod);
            this.Name = "GiderTipi_Ekle";
            this.Text = "GiderTipi_Ekle";
            this.Load += new System.EventHandler(this.GiderTipi_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gider_kod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gider_ad;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_kapat;
    }
}