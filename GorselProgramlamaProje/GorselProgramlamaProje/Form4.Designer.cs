namespace GorselProgramlamaProje
{
    partial class frmRandevuAl
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
            this.cmbRandevuGun = new System.Windows.Forms.ComboBox();
            this.cmbRandevuAy = new System.Windows.Forms.ComboBox();
            this.cmbRandevuYil = new System.Windows.Forms.ComboBox();
            this.cmbRandevuDoktor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.txtGelenKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpSaatSec = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDoktorAdi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbRandevuGun
            // 
            this.cmbRandevuGun.FormattingEnabled = true;
            this.cmbRandevuGun.Location = new System.Drawing.Point(12, 126);
            this.cmbRandevuGun.Name = "cmbRandevuGun";
            this.cmbRandevuGun.Size = new System.Drawing.Size(121, 24);
            this.cmbRandevuGun.TabIndex = 0;
            this.cmbRandevuGun.SelectedIndexChanged += new System.EventHandler(this.cmbRandevuGun_SelectedIndexChanged);
            // 
            // cmbRandevuAy
            // 
            this.cmbRandevuAy.FormattingEnabled = true;
            this.cmbRandevuAy.Location = new System.Drawing.Point(170, 126);
            this.cmbRandevuAy.Name = "cmbRandevuAy";
            this.cmbRandevuAy.Size = new System.Drawing.Size(121, 24);
            this.cmbRandevuAy.TabIndex = 1;
            this.cmbRandevuAy.SelectedIndexChanged += new System.EventHandler(this.cmbRandevuAy_SelectedIndexChanged);
            // 
            // cmbRandevuYil
            // 
            this.cmbRandevuYil.FormattingEnabled = true;
            this.cmbRandevuYil.Location = new System.Drawing.Point(319, 126);
            this.cmbRandevuYil.Name = "cmbRandevuYil";
            this.cmbRandevuYil.Size = new System.Drawing.Size(121, 24);
            this.cmbRandevuYil.TabIndex = 2;
            this.cmbRandevuYil.SelectedIndexChanged += new System.EventHandler(this.cmbRandevuYil_SelectedIndexChanged);
            // 
            // cmbRandevuDoktor
            // 
            this.cmbRandevuDoktor.FormattingEnabled = true;
            this.cmbRandevuDoktor.Location = new System.Drawing.Point(649, 126);
            this.cmbRandevuDoktor.Name = "cmbRandevuDoktor";
            this.cmbRandevuDoktor.Size = new System.Drawing.Size(127, 24);
            this.cmbRandevuDoktor.TabIndex = 3;
            this.cmbRandevuDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbRandevuDoktor_SelectedIndexChanged);
            this.cmbRandevuDoktor.Click += new System.EventHandler(this.cmbRandevuDoktor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gün Seçiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(166, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ay Seçiniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(315, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yıl Seçiniz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(636, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doktor Seçiniz :";
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(284, 189);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(201, 69);
            this.btnRandevuAl.TabIndex = 8;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // txtGelenKullaniciAdi
            // 
            this.txtGelenKullaniciAdi.Location = new System.Drawing.Point(108, 33);
            this.txtGelenKullaniciAdi.Name = "txtGelenKullaniciAdi";
            this.txtGelenKullaniciAdi.Size = new System.Drawing.Size(128, 22);
            this.txtGelenKullaniciAdi.TabIndex = 9;
            this.txtGelenKullaniciAdi.TextChanged += new System.EventHandler(this.txtGelenKullaniciAdi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kullanici :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(477, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Saat Seçiniz :";
            // 
            // dtpSaatSec
            // 
            this.dtpSaatSec.CustomFormat = "";
            this.dtpSaatSec.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaatSec.Location = new System.Drawing.Point(481, 126);
            this.dtpSaatSec.Name = "dtpSaatSec";
            this.dtpSaatSec.Size = new System.Drawing.Size(118, 22);
            this.dtpSaatSec.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(555, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Seçtiğiniz Doktorunuz ismi :";
            // 
            // lblDoktorAdi
            // 
            this.lblDoktorAdi.AutoSize = true;
            this.lblDoktorAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorAdi.Location = new System.Drawing.Point(554, 233);
            this.lblDoktorAdi.Name = "lblDoktorAdi";
            this.lblDoktorAdi.Size = new System.Drawing.Size(0, 25);
            this.lblDoktorAdi.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 17;
            // 
            // frmRandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 292);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDoktorAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpSaatSec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGelenKullaniciAdi);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRandevuDoktor);
            this.Controls.Add(this.cmbRandevuYil);
            this.Controls.Add(this.cmbRandevuAy);
            this.Controls.Add(this.cmbRandevuGun);
            this.Name = "frmRandevuAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Alma Formu";
            this.Load += new System.EventHandler(this.frmRandevuAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRandevuGun;
        private System.Windows.Forms.ComboBox cmbRandevuAy;
        private System.Windows.Forms.ComboBox cmbRandevuYil;
        private System.Windows.Forms.ComboBox cmbRandevuDoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtGelenKullaniciAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpSaatSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDoktorAdi;
        private System.Windows.Forms.Label label8;
    }
}