namespace WindowsFormsApp13
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.giris_buton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sifre_textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.kullanici_textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sifregoster_checkBox1 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // giris_buton
            // 
            this.giris_buton.ActiveBorderThickness = 1;
            this.giris_buton.ActiveCornerRadius = 20;
            this.giris_buton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.giris_buton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.giris_buton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.giris_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.giris_buton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("giris_buton.BackgroundImage")));
            this.giris_buton.ButtonText = "Giriş";
            this.giris_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_buton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_buton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.giris_buton.IdleBorderThickness = 1;
            this.giris_buton.IdleCornerRadius = 20;
            this.giris_buton.IdleFillColor = System.Drawing.Color.White;
            this.giris_buton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.giris_buton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.giris_buton.Location = new System.Drawing.Point(92, 487);
            this.giris_buton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.giris_buton.Name = "giris_buton";
            this.giris_buton.Size = new System.Drawing.Size(218, 46);
            this.giris_buton.TabIndex = 4;
            this.giris_buton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.giris_buton.Click += new System.EventHandler(this.giris_buton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.sifre_textbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sifre_textbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.sifre_textbox.BorderThickness = 3;
            this.sifre_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.sifre_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.sifre_textbox.ForeColor = System.Drawing.Color.DarkGray;
            this.sifre_textbox.isPassword = true;
            this.sifre_textbox.Location = new System.Drawing.Point(48, 341);
            this.sifre_textbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sifre_textbox.MaxLength = 32767;
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.Size = new System.Drawing.Size(309, 44);
            this.sifre_textbox.TabIndex = 2;
            this.sifre_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kullanici_textbox
            // 
            this.kullanici_textbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.kullanici_textbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kullanici_textbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.kullanici_textbox.BorderThickness = 3;
            this.kullanici_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kullanici_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullanici_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.kullanici_textbox.ForeColor = System.Drawing.Color.DarkGray;
            this.kullanici_textbox.isPassword = false;
            this.kullanici_textbox.Location = new System.Drawing.Point(48, 243);
            this.kullanici_textbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.kullanici_textbox.MaxLength = 32767;
            this.kullanici_textbox.Name = "kullanici_textbox";
            this.kullanici_textbox.Size = new System.Drawing.Size(309, 44);
            this.kullanici_textbox.TabIndex = 1;
            this.kullanici_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(44, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(44, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // sifregoster_checkBox1
            // 
            this.sifregoster_checkBox1.AutoSize = true;
            this.sifregoster_checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifregoster_checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(142)))));
            this.sifregoster_checkBox1.Location = new System.Drawing.Point(288, 392);
            this.sifregoster_checkBox1.Name = "sifregoster_checkBox1";
            this.sifregoster_checkBox1.Size = new System.Drawing.Size(69, 20);
            this.sifregoster_checkBox1.TabIndex = 3;
            this.sifregoster_checkBox1.Text = "Göster";
            this.sifregoster_checkBox1.UseVisualStyleBackColor = true;
            this.sifregoster_checkBox1.CheckedChanged += new System.EventHandler(this.sifregoster_checkBox1_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Location = new System.Drawing.Point(-15, -15);
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch1.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch1.TabIndex = 7;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Value = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(374, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(17, 21);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(351, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(17, 21);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 10;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(403, 600);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuSwitch1);
            this.Controls.Add(this.sifregoster_checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanici_textbox);
            this.Controls.Add(this.sifre_textbox);
            this.Controls.Add(this.giris_buton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(403, 536);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 giris_buton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox kullanici_textbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox sifre_textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox sifregoster_checkBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}

