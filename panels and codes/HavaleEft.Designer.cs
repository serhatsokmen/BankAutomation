namespace BankAuto1
{
    partial class HavaleEft
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(397, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 69);
            this.button3.TabIndex = 46;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(397, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 69);
            this.button1.TabIndex = 45;
            this.button1.Text = "Havale/EFT Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(387, 136);
            this.textBoxNo.Multiline = true;
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(193, 31);
            this.textBoxNo.TabIndex = 44;
            this.textBoxNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(116, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Alıcı Hesap NO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(236, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 38);
            this.label2.TabIndex = 47;
            this.label2.Text = "Havale ve EFT İşlemi";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.Location = new System.Drawing.Point(387, 177);
            this.textBoxMiktar.Multiline = true;
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(193, 31);
            this.textBoxMiktar.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(116, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "Gönderilecek Miktar : ";
            // 
            // HavaleEft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.label1);
            this.Name = "HavaleEft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Havale ve EFT İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button3;
        private Button button1;
        private TextBox textBoxNo;
        private Label label1;
        private Label label2;
        private TextBox textBoxMiktar;
        private Label label3;
    }
}