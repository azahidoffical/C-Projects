namespace HotelApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fiyatButton = new System.Windows.Forms.Button();
            this.kayitSorgula = new System.Windows.Forms.Button();
            this.kayitBuutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.fiyatButton);
            this.panel1.Controls.Add(this.kayitSorgula);
            this.panel1.Controls.Add(this.kayitBuutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 450);
            this.panel1.TabIndex = 0;
            // 
            // fiyatButton
            // 
            this.fiyatButton.Location = new System.Drawing.Point(12, 371);
            this.fiyatButton.Name = "fiyatButton";
            this.fiyatButton.Size = new System.Drawing.Size(195, 45);
            this.fiyatButton.TabIndex = 1;
            this.fiyatButton.Text = "Fiyat Listesi";
            this.fiyatButton.UseVisualStyleBackColor = true;
            this.fiyatButton.Click += new System.EventHandler(this.fiyatButton_Click);
            // 
            // kayitSorgula
            // 
            this.kayitSorgula.Location = new System.Drawing.Point(12, 299);
            this.kayitSorgula.Name = "kayitSorgula";
            this.kayitSorgula.Size = new System.Drawing.Size(195, 45);
            this.kayitSorgula.TabIndex = 2;
            this.kayitSorgula.Text = "Kayıt Sorgula";
            this.kayitSorgula.UseVisualStyleBackColor = true;
            this.kayitSorgula.Click += new System.EventHandler(this.kayitSorgula_Click);
            // 
            // kayitBuutton
            // 
            this.kayitBuutton.Location = new System.Drawing.Point(12, 224);
            this.kayitBuutton.Name = "kayitBuutton";
            this.kayitBuutton.Size = new System.Drawing.Size(195, 45);
            this.kayitBuutton.TabIndex = 1;
            this.kayitBuutton.Text = "Kayıt Yap / Sil";
            this.kayitBuutton.UseVisualStyleBackColor = true;
            this.kayitBuutton.Click += new System.EventHandler(this.kayitBuutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(21, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Black Sea Residence";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Sea Residence";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kayitSorgula;
        private System.Windows.Forms.Button kayitBuutton;
        private System.Windows.Forms.Button fiyatButton;
    }
}

