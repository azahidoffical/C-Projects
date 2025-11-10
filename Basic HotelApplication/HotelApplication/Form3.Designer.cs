namespace HotelApplication
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kontrolRichTextBox = new System.Windows.Forms.RichTextBox();
            this.doğumTarihiLabel = new System.Windows.Forms.Label();
            this.numaraLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.adLabel = new System.Windows.Forms.Label();
            this.tcLabel = new System.Windows.Forms.Label();
            this.numaraMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dtMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.kytKontrolButton = new System.Windows.Forms.Button();
            this.anaEkranButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(394, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Black Sea Residence";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(280, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Kayıt Kontrol Ekranı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 111);
            this.panel1.TabIndex = 1;
            // 
            // kontrolRichTextBox
            // 
            this.kontrolRichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.kontrolRichTextBox.Location = new System.Drawing.Point(0, 111);
            this.kontrolRichTextBox.Name = "kontrolRichTextBox";
            this.kontrolRichTextBox.Size = new System.Drawing.Size(909, 126);
            this.kontrolRichTextBox.TabIndex = 2;
            this.kontrolRichTextBox.Text = "";
            // 
            // doğumTarihiLabel
            // 
            this.doğumTarihiLabel.AutoSize = true;
            this.doğumTarihiLabel.Location = new System.Drawing.Point(477, 439);
            this.doğumTarihiLabel.Name = "doğumTarihiLabel";
            this.doğumTarihiLabel.Size = new System.Drawing.Size(94, 16);
            this.doğumTarihiLabel.TabIndex = 25;
            this.doğumTarihiLabel.Text = "Doğum Tarihi :";
            // 
            // numaraLabel
            // 
            this.numaraLabel.AutoSize = true;
            this.numaraLabel.Location = new System.Drawing.Point(477, 352);
            this.numaraLabel.Name = "numaraLabel";
            this.numaraLabel.Size = new System.Drawing.Size(120, 16);
            this.numaraLabel.TabIndex = 24;
            this.numaraLabel.Text = "Telefon Numarası :";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(477, 253);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(80, 16);
            this.mailLabel.TabIndex = 23;
            this.mailLabel.Text = "Mail Adresi :";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.Location = new System.Drawing.Point(203, 430);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(53, 16);
            this.soyadLabel.TabIndex = 22;
            this.soyadLabel.Text = "Soyad :";
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(203, 344);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(30, 16);
            this.adLabel.TabIndex = 21;
            this.adLabel.Text = "Ad :";
            // 
            // tcLabel
            // 
            this.tcLabel.AutoSize = true;
            this.tcLabel.Location = new System.Drawing.Point(203, 253);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(133, 16);
            this.tcLabel.TabIndex = 20;
            this.tcLabel.Text = "T.C Kimlik Numarası :";
            // 
            // numaraMaskedTextBox
            // 
            this.numaraMaskedTextBox.Location = new System.Drawing.Point(480, 371);
            this.numaraMaskedTextBox.Mask = "(999) 000-0000";
            this.numaraMaskedTextBox.Name = "numaraMaskedTextBox";
            this.numaraMaskedTextBox.Size = new System.Drawing.Size(210, 22);
            this.numaraMaskedTextBox.TabIndex = 19;
            // 
            // dtMaskedTextBox
            // 
            this.dtMaskedTextBox.Location = new System.Drawing.Point(480, 458);
            this.dtMaskedTextBox.Mask = "00/00/0000";
            this.dtMaskedTextBox.Name = "dtMaskedTextBox";
            this.dtMaskedTextBox.Size = new System.Drawing.Size(210, 22);
            this.dtMaskedTextBox.TabIndex = 18;
            this.dtMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(480, 272);
            this.mailTextBox.Multiline = true;
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(210, 31);
            this.mailTextBox.TabIndex = 17;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(203, 449);
            this.soyadTextBox.Multiline = true;
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(210, 31);
            this.soyadTextBox.TabIndex = 16;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(203, 363);
            this.adTextBox.Multiline = true;
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(210, 30);
            this.adTextBox.TabIndex = 15;
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(203, 272);
            this.tcTextBox.Multiline = true;
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(210, 31);
            this.tcTextBox.TabIndex = 14;
            // 
            // kytKontrolButton
            // 
            this.kytKontrolButton.Location = new System.Drawing.Point(203, 495);
            this.kytKontrolButton.Name = "kytKontrolButton";
            this.kytKontrolButton.Size = new System.Drawing.Size(210, 53);
            this.kytKontrolButton.TabIndex = 26;
            this.kytKontrolButton.Text = "Kayıt Kontrol";
            this.kytKontrolButton.UseVisualStyleBackColor = true;
            this.kytKontrolButton.Click += new System.EventHandler(this.kytKontrolButton_Click);
            // 
            // anaEkranButton
            // 
            this.anaEkranButton.Location = new System.Drawing.Point(480, 495);
            this.anaEkranButton.Name = "anaEkranButton";
            this.anaEkranButton.Size = new System.Drawing.Size(210, 53);
            this.anaEkranButton.TabIndex = 27;
            this.anaEkranButton.Text = "Ana Ekrana Dön";
            this.anaEkranButton.UseVisualStyleBackColor = true;
            this.anaEkranButton.Click += new System.EventHandler(this.anaEkranButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 570);
            this.Controls.Add(this.anaEkranButton);
            this.Controls.Add(this.kytKontrolButton);
            this.Controls.Add(this.doğumTarihiLabel);
            this.Controls.Add(this.numaraLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.soyadLabel);
            this.Controls.Add(this.adLabel);
            this.Controls.Add(this.tcLabel);
            this.Controls.Add(this.numaraMaskedTextBox);
            this.Controls.Add(this.dtMaskedTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.tcTextBox);
            this.Controls.Add(this.kontrolRichTextBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Sea Residence";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox kontrolRichTextBox;
        private System.Windows.Forms.Label doğumTarihiLabel;
        private System.Windows.Forms.Label numaraLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label tcLabel;
        private System.Windows.Forms.MaskedTextBox numaraMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dtMaskedTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.Button kytKontrolButton;
        private System.Windows.Forms.Button anaEkranButton;
    }
}