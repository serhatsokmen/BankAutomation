namespace BankAuto1
{
    partial class SifreDegistir
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
            this.textBoxYeni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEski = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYeni2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(246, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 38);
            this.label2.TabIndex = 48;
            this.label2.Text = "Şifre Değiştirme";
            // 
            // textBoxYeni
            // 
            this.textBoxYeni.Location = new System.Drawing.Point(386, 174);
            this.textBoxYeni.Multiline = true;
            this.textBoxYeni.Name = "textBoxYeni";
            this.textBoxYeni.Size = new System.Drawing.Size(193, 31);
            this.textBoxYeni.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(115, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "Yeni Şifre :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(396, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 69);
            this.button3.TabIndex = 53;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(396, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 69);
            this.button1.TabIndex = 52;
            this.button1.Text = "Şifre Değiştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEski
            // 
            this.textBoxEski.Location = new System.Drawing.Point(386, 125);
            this.textBoxEski.Multiline = true;
            this.textBoxEski.Name = "textBoxEski";
            this.textBoxEski.Size = new System.Drawing.Size(193, 31);
            this.textBoxEski.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(115, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "Eski Şifre :";
            // 
            // textBoxYeni2
            // 
            this.textBoxYeni2.Location = new System.Drawing.Point(386, 214);
            this.textBoxYeni2.Multiline = true;
            this.textBoxYeni2.Name = "textBoxYeni2";
            this.textBoxYeni2.Size = new System.Drawing.Size(193, 31);
            this.textBoxYeni2.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(115, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "Yeni Şifre (Tekrar) :";
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.textBoxYeni2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxYeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxEski);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "SifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştirme İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox textBoxYeni;
        private Label label3;
        private Button button3;
        private Button button1;
        private TextBox textBoxEski;
        private Label label1;
        private TextBox textBoxYeni2;
        private Label label4;
    }
}