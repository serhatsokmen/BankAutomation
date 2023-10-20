namespace BankAuto1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPsw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonYetkili = new System.Windows.Forms.RadioButton();
            this.radioButtonMusteri = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(238, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANKA OTOMASYONU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(348, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tc kimlik/kulanıcı adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola ";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(276, 24);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(171, 27);
            this.textBoxUsername.TabIndex = 5;
            // 
            // textBoxPsw
            // 
            this.textBoxPsw.Location = new System.Drawing.Point(276, 60);
            this.textBoxPsw.Name = "textBoxPsw";
            this.textBoxPsw.PasswordChar = '*';
            this.textBoxPsw.Size = new System.Drawing.Size(171, 27);
            this.textBoxPsw.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hesabınız yok mu?\r\nAşağıdaki butona tıklayarak \r\nkayıt olun.\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(44, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonYetkili
            // 
            this.radioButtonYetkili.AutoSize = true;
            this.radioButtonYetkili.Location = new System.Drawing.Point(276, 105);
            this.radioButtonYetkili.Name = "radioButtonYetkili";
            this.radioButtonYetkili.Size = new System.Drawing.Size(69, 24);
            this.radioButtonYetkili.TabIndex = 9;
            this.radioButtonYetkili.TabStop = true;
            this.radioButtonYetkili.Text = "Yetkili";
            this.radioButtonYetkili.UseVisualStyleBackColor = true;
            // 
            // radioButtonMusteri
            // 
            this.radioButtonMusteri.AutoSize = true;
            this.radioButtonMusteri.Location = new System.Drawing.Point(368, 105);
            this.radioButtonMusteri.Name = "radioButtonMusteri";
            this.radioButtonMusteri.Size = new System.Drawing.Size(79, 24);
            this.radioButtonMusteri.TabIndex = 10;
            this.radioButtonMusteri.TabStop = true;
            this.radioButtonMusteri.Text = "Müşteri";
            this.radioButtonMusteri.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(302, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Giriş";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giriş yapmak için tıklayın.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.radioButtonMusteri);
            this.groupBox1.Controls.Add(this.radioButtonYetkili);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPsw);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(174, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 305);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş İşlemleri";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(330, 272);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANKA OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private TextBox textBoxUsername;
        private TextBox textBoxPsw;
        private Label label4;
        private Button button1;
        private RadioButton radioButtonYetkili;
        private RadioButton radioButtonMusteri;
        private Button button2;
        private Label label5;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
    }
}