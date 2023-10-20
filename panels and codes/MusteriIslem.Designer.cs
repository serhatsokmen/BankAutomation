namespace BankAuto1
{
    partial class MusteriIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriIslem));
            this.labelAdsoyad = new System.Windows.Forms.Label();
            this.labelBankano = new System.Windows.Forms.Label();
            this.buttonParaCek = new System.Windows.Forms.Button();
            this.buttonParaYatir = new System.Windows.Forms.Button();
            this.buttonSifre = new System.Windows.Forms.Button();
            this.buttonHesap = new System.Windows.Forms.Button();
            this.buttonEft = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBakiye = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdsoyad
            // 
            this.labelAdsoyad.AutoSize = true;
            this.labelAdsoyad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdsoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelAdsoyad.Location = new System.Drawing.Point(90, 9);
            this.labelAdsoyad.Name = "labelAdsoyad";
            this.labelAdsoyad.Size = new System.Drawing.Size(19, 27);
            this.labelAdsoyad.TabIndex = 0;
            this.labelAdsoyad.Text = ".";
            this.labelAdsoyad.Click += new System.EventHandler(this.labelAdsoyad_Click);
            // 
            // labelBankano
            // 
            this.labelBankano.AutoSize = true;
            this.labelBankano.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBankano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelBankano.Location = new System.Drawing.Point(90, 48);
            this.labelBankano.Name = "labelBankano";
            this.labelBankano.Size = new System.Drawing.Size(19, 27);
            this.labelBankano.TabIndex = 1;
            this.labelBankano.Text = ".";
            // 
            // buttonParaCek
            // 
            this.buttonParaCek.BackColor = System.Drawing.Color.Cyan;
            this.buttonParaCek.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonParaCek.Location = new System.Drawing.Point(80, 187);
            this.buttonParaCek.Name = "buttonParaCek";
            this.buttonParaCek.Size = new System.Drawing.Size(162, 53);
            this.buttonParaCek.TabIndex = 3;
            this.buttonParaCek.Text = "Para Çek";
            this.buttonParaCek.UseVisualStyleBackColor = false;
            this.buttonParaCek.Click += new System.EventHandler(this.buttonParaCek_Click);
            // 
            // buttonParaYatir
            // 
            this.buttonParaYatir.BackColor = System.Drawing.Color.Cyan;
            this.buttonParaYatir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonParaYatir.Location = new System.Drawing.Point(80, 331);
            this.buttonParaYatir.Name = "buttonParaYatir";
            this.buttonParaYatir.Size = new System.Drawing.Size(162, 53);
            this.buttonParaYatir.TabIndex = 4;
            this.buttonParaYatir.Text = "Para Yatır";
            this.buttonParaYatir.UseVisualStyleBackColor = false;
            this.buttonParaYatir.Click += new System.EventHandler(this.buttonParaYatir_Click);
            // 
            // buttonSifre
            // 
            this.buttonSifre.BackColor = System.Drawing.Color.Cyan;
            this.buttonSifre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSifre.Location = new System.Drawing.Point(393, 187);
            this.buttonSifre.Name = "buttonSifre";
            this.buttonSifre.Size = new System.Drawing.Size(152, 53);
            this.buttonSifre.TabIndex = 5;
            this.buttonSifre.Text = "Şifre Değiştir";
            this.buttonSifre.UseVisualStyleBackColor = false;
            this.buttonSifre.Click += new System.EventHandler(this.buttonSifre_Click);
            // 
            // buttonHesap
            // 
            this.buttonHesap.BackColor = System.Drawing.Color.Cyan;
            this.buttonHesap.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHesap.Location = new System.Drawing.Point(393, 331);
            this.buttonHesap.Name = "buttonHesap";
            this.buttonHesap.Size = new System.Drawing.Size(152, 53);
            this.buttonHesap.TabIndex = 6;
            this.buttonHesap.Text = "Hesap Hareketleri ";
            this.buttonHesap.UseVisualStyleBackColor = false;
            this.buttonHesap.Click += new System.EventHandler(this.buttonHesap_Click);
            // 
            // buttonEft
            // 
            this.buttonEft.BackColor = System.Drawing.Color.Cyan;
            this.buttonEft.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEft.Location = new System.Drawing.Point(90, 493);
            this.buttonEft.Name = "buttonEft";
            this.buttonEft.Size = new System.Drawing.Size(152, 53);
            this.buttonEft.TabIndex = 9;
            this.buttonEft.Text = "Havale / EFT";
            this.buttonEft.UseVisualStyleBackColor = false;
            this.buttonEft.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCikis.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCikis.Location = new System.Drawing.Point(393, 450);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(152, 64);
            this.buttonCikis.TabIndex = 10;
            this.buttonCikis.Text = "Çıkış Yap";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCik_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(80, 246);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(90, 400);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 87);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(393, 102);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(152, 79);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(395, 246);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 79);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(393, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bakiye :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBakiye
            // 
            this.labelBakiye.AutoSize = true;
            this.labelBakiye.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelBakiye.Location = new System.Drawing.Point(395, 48);
            this.labelBakiye.Name = "labelBakiye";
            this.labelBakiye.Size = new System.Drawing.Size(19, 26);
            this.labelBakiye.TabIndex = 18;
            this.labelBakiye.Text = ".";
            // 
            // MusteriIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 560);
            this.Controls.Add(this.labelBakiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonEft);
            this.Controls.Add(this.buttonHesap);
            this.Controls.Add(this.buttonSifre);
            this.Controls.Add(this.buttonParaYatir);
            this.Controls.Add(this.buttonParaCek);
            this.Controls.Add(this.labelBankano);
            this.Controls.Add(this.labelAdsoyad);
            this.Name = "MusteriIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.MusteriIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAdsoyad;
        private Label labelBankano;
        private Button buttonParaCek;
        private Button buttonParaYatir;
        private Button buttonSifre;
        private Button buttonHesap;
        private Button buttonEft;
        private Button buttonCikis;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label1;
        private Label labelBakiye;
    }
}