
namespace Gelir_Gider_Takip
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.rad_gelir = new System.Windows.Forms.RadioButton();
            this.rad_gider = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dat_tarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_gider_tipi = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_f_gider = new System.Windows.Forms.RadioButton();
            this.rad_f_gelir = new System.Windows.Forms.RadioButton();
            this.rad_f_hepsi = new System.Windows.Forms.RadioButton();
            this.cal_recno = new Gelir_Gider_Takip.TextBoxNumbersOnly();
            this.cal_tutar = new Gelir_Gider_Takip.TextBoxNumbersOnly();
            this.btn_tip_ekle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tip_ekle);
            this.groupBox1.Controls.Add(this.cmb_gider_tipi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cal_recno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cal_tutar);
            this.groupBox1.Controls.Add(this.btn_kapat);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Aciklama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dat_tarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rad_gider);
            this.groupBox1.Controls.Add(this.rad_gelir);
            this.groupBox1.Controls.Add(this.txt_cari);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(394, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 356);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Tipi";
            // 
            // txt_cari
            // 
            this.txt_cari.Location = new System.Drawing.Point(88, 112);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(147, 20);
            this.txt_cari.TabIndex = 1;
            // 
            // rad_gelir
            // 
            this.rad_gelir.AutoSize = true;
            this.rad_gelir.Location = new System.Drawing.Point(88, 37);
            this.rad_gelir.Name = "rad_gelir";
            this.rad_gelir.Size = new System.Drawing.Size(46, 17);
            this.rad_gelir.TabIndex = 2;
            this.rad_gelir.TabStop = true;
            this.rad_gelir.Text = "Gelir";
            this.rad_gelir.UseVisualStyleBackColor = true;
            // 
            // rad_gider
            // 
            this.rad_gider.AutoSize = true;
            this.rad_gider.Location = new System.Drawing.Point(152, 37);
            this.rad_gider.Name = "rad_gider";
            this.rad_gider.Size = new System.Drawing.Size(50, 17);
            this.rad_gider.TabIndex = 3;
            this.rad_gider.TabStop = true;
            this.rad_gider.Text = "Gider";
            this.rad_gider.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cari";
            // 
            // dat_tarih
            // 
            this.dat_tarih.Location = new System.Drawing.Point(88, 60);
            this.dat_tarih.Name = "dat_tarih";
            this.dat_tarih.Size = new System.Drawing.Size(200, 20);
            this.dat_tarih.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(88, 164);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(236, 80);
            this.txt_Aciklama.TabIndex = 9;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(208, 250);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(116, 62);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(88, 250);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(114, 62);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_kapat.Location = new System.Drawing.Point(3, 333);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(388, 62);
            this.btn_kapat.TabIndex = 13;
            this.btn_kapat.Text = "Programı Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "RECno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Gider İse Tipi";
            // 
            // cmb_gider_tipi
            // 
            this.cmb_gider_tipi.FormattingEnabled = true;
            this.cmb_gider_tipi.Location = new System.Drawing.Point(88, 86);
            this.cmb_gider_tipi.Name = "cmb_gider_tipi";
            this.cmb_gider_tipi.Size = new System.Drawing.Size(200, 21);
            this.cmb_gider_tipi.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rad_f_hepsi);
            this.panel1.Controls.Add(this.rad_f_gider);
            this.panel1.Controls.Add(this.rad_f_gelir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(394, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 42);
            this.panel1.TabIndex = 2;
            // 
            // rad_f_gider
            // 
            this.rad_f_gider.AutoSize = true;
            this.rad_f_gider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rad_f_gider.Location = new System.Drawing.Point(86, 10);
            this.rad_f_gider.Name = "rad_f_gider";
            this.rad_f_gider.Size = new System.Drawing.Size(66, 21);
            this.rad_f_gider.TabIndex = 5;
            this.rad_f_gider.TabStop = true;
            this.rad_f_gider.Text = "Gider";
            this.rad_f_gider.UseVisualStyleBackColor = true;
            this.rad_f_gider.CheckedChanged += new System.EventHandler(this.rad_f_hepsi_CheckedChanged);
            // 
            // rad_f_gelir
            // 
            this.rad_f_gelir.AutoSize = true;
            this.rad_f_gelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rad_f_gelir.Location = new System.Drawing.Point(16, 10);
            this.rad_f_gelir.Name = "rad_f_gelir";
            this.rad_f_gelir.Size = new System.Drawing.Size(61, 21);
            this.rad_f_gelir.TabIndex = 4;
            this.rad_f_gelir.TabStop = true;
            this.rad_f_gelir.Text = "Gelir";
            this.rad_f_gelir.UseVisualStyleBackColor = true;
            this.rad_f_gelir.CheckedChanged += new System.EventHandler(this.rad_f_hepsi_CheckedChanged);
            // 
            // rad_f_hepsi
            // 
            this.rad_f_hepsi.AutoSize = true;
            this.rad_f_hepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rad_f_hepsi.Location = new System.Drawing.Point(167, 10);
            this.rad_f_hepsi.Name = "rad_f_hepsi";
            this.rad_f_hepsi.Size = new System.Drawing.Size(67, 21);
            this.rad_f_hepsi.TabIndex = 6;
            this.rad_f_hepsi.TabStop = true;
            this.rad_f_hepsi.Text = "Hepsi";
            this.rad_f_hepsi.UseVisualStyleBackColor = true;
            this.rad_f_hepsi.CheckedChanged += new System.EventHandler(this.rad_f_hepsi_CheckedChanged);
            // 
            // cal_recno
            // 
            this.cal_recno.Location = new System.Drawing.Point(88, 11);
            this.cal_recno.Name = "cal_recno";
            this.cal_recno.NumbersOnly = true;
            this.cal_recno.Size = new System.Drawing.Size(79, 20);
            this.cal_recno.TabIndex = 16;
            this.cal_recno.Text = "0";
            // 
            // cal_tutar
            // 
            this.cal_tutar.Location = new System.Drawing.Point(88, 138);
            this.cal_tutar.Name = "cal_tutar";
            this.cal_tutar.NumbersOnly = true;
            this.cal_tutar.Size = new System.Drawing.Size(79, 20);
            this.cal_tutar.TabIndex = 14;
            this.cal_tutar.Text = "0";
            // 
            // btn_tip_ekle
            // 
            this.btn_tip_ekle.Location = new System.Drawing.Point(294, 87);
            this.btn_tip_ekle.Name = "btn_tip_ekle";
            this.btn_tip_ekle.Size = new System.Drawing.Size(53, 20);
            this.btn_tip_ekle.TabIndex = 20;
            this.btn_tip_ekle.Text = "Ekle";
            this.btn_tip_ekle.UseVisualStyleBackColor = true;
            this.btn_tip_ekle.Click += new System.EventHandler(this.btn_tip_ekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 398);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dat_tarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rad_gider;
        private System.Windows.Forms.RadioButton rad_gelir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private TextBoxNumbersOnly cal_tutar;
        private TextBoxNumbersOnly cal_recno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_gider_tipi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rad_f_hepsi;
        private System.Windows.Forms.RadioButton rad_f_gider;
        private System.Windows.Forms.RadioButton rad_f_gelir;
        private System.Windows.Forms.Button btn_tip_ekle;
    }
}

