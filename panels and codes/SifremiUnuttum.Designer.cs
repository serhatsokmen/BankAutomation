namespace BankAuto1
{
    partial class SifremiUnuttum
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
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(421, 203);
            this.textBoxSifre.Multiline = true;
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(193, 31);
            this.textBoxSifre.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(150, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 65;
            this.label4.Text = "Yeni Şifre :";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(421, 163);
            this.textBoxTel.Multiline = true;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(193, 31);
            this.textBoxTel.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(150, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "Telefon Numarası :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(431, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 69);
            this.button3.TabIndex = 62;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(431, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 69);
            this.button1.TabIndex = 61;
            this.button1.Text = "Yeni Şifre Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(421, 114);
            this.textBoxTc.Multiline = true;
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(193, 31);
            this.textBoxTc.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(150, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 59;
            this.label1.Text = "TC Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(281, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 38);
            this.label2.TabIndex = 58;
            this.label2.Text = "Şifremi Unuttum";
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxSifre;
        private Label label4;
        private TextBox textBoxTel;
        private Label label3;
        private Button button3;
        private Button button1;
        private TextBox textBoxTc;
        private Label label1;
        private Label label2;
    }
}