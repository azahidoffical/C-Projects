namespace HotelApplication
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.dtMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.numaraMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tcLabel = new System.Windows.Forms.Label();
            this.adLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.numaraLabel = new System.Windows.Forms.Label();
            this.doğumTarihiLabel = new System.Windows.Forms.Label();
            this.kayitButton = new System.Windows.Forms.Button();
            this.müsteriBilgiListbox = new System.Windows.Forms.ListBox();
            this.silButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.systemSaveButton = new System.Windows.Forms.Button();
            this.anaekranButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 111);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(446, 62);
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
            this.label1.Location = new System.Drawing.Point(387, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Kayıt Ekranı";
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(5, 138);
            this.tcTextBox.Multiline = true;
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(210, 31);
            this.tcTextBox.TabIndex = 1;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(5, 229);
            this.adTextBox.Multiline = true;
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(210, 30);
            this.adTextBox.TabIndex = 2;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(5, 315);
            this.soyadTextBox.Multiline = true;
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(210, 31);
            this.soyadTextBox.TabIndex = 3;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(282, 138);
            this.mailTextBox.Multiline = true;
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(210, 31);
            this.mailTextBox.TabIndex = 4;
            // 
            // dtMaskedTextBox
            // 
            this.dtMaskedTextBox.Location = new System.Drawing.Point(282, 324);
            this.dtMaskedTextBox.Mask = "00/00/0000";
            this.dtMaskedTextBox.Name = "dtMaskedTextBox";
            this.dtMaskedTextBox.Size = new System.Drawing.Size(210, 22);
            this.dtMaskedTextBox.TabIndex = 6;
            this.dtMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // numaraMaskedTextBox
            // 
            this.numaraMaskedTextBox.Location = new System.Drawing.Point(282, 237);
            this.numaraMaskedTextBox.Mask = "(999) 000-0000";
            this.numaraMaskedTextBox.Name = "numaraMaskedTextBox";
            this.numaraMaskedTextBox.Size = new System.Drawing.Size(210, 22);
            this.numaraMaskedTextBox.TabIndex = 7;
            // 
            // tcLabel
            // 
            this.tcLabel.AutoSize = true;
            this.tcLabel.Location = new System.Drawing.Point(5, 119);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(133, 16);
            this.tcLabel.TabIndex = 8;
            this.tcLabel.Text = "T.C Kimlik Numarası :";
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(5, 210);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(30, 16);
            this.adLabel.TabIndex = 9;
            this.adLabel.Text = "Ad :";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.Location = new System.Drawing.Point(5, 296);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(53, 16);
            this.soyadLabel.TabIndex = 10;
            this.soyadLabel.Text = "Soyad :";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(279, 119);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(80, 16);
            this.mailLabel.TabIndex = 11;
            this.mailLabel.Text = "Mail Adresi :";
            // 
            // numaraLabel
            // 
            this.numaraLabel.AutoSize = true;
            this.numaraLabel.Location = new System.Drawing.Point(279, 218);
            this.numaraLabel.Name = "numaraLabel";
            this.numaraLabel.Size = new System.Drawing.Size(120, 16);
            this.numaraLabel.TabIndex = 12;
            this.numaraLabel.Text = "Telefon Numarası :";
            // 
            // doğumTarihiLabel
            // 
            this.doğumTarihiLabel.AutoSize = true;
            this.doğumTarihiLabel.Location = new System.Drawing.Point(279, 305);
            this.doğumTarihiLabel.Name = "doğumTarihiLabel";
            this.doğumTarihiLabel.Size = new System.Drawing.Size(94, 16);
            this.doğumTarihiLabel.TabIndex = 13;
            this.doğumTarihiLabel.Text = "Doğum Tarihi :";
            // 
            // kayitButton
            // 
            this.kayitButton.Location = new System.Drawing.Point(8, 391);
            this.kayitButton.Name = "kayitButton";
            this.kayitButton.Size = new System.Drawing.Size(207, 47);
            this.kayitButton.TabIndex = 14;
            this.kayitButton.Text = "Müşteri Kaydı Yap";
            this.kayitButton.UseVisualStyleBackColor = true;
            this.kayitButton.Click += new System.EventHandler(this.kayitButton_Click);
            // 
            // müsteriBilgiListbox
            // 
            this.müsteriBilgiListbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.müsteriBilgiListbox.FormattingEnabled = true;
            this.müsteriBilgiListbox.ItemHeight = 16;
            this.müsteriBilgiListbox.Location = new System.Drawing.Point(505, 111);
            this.müsteriBilgiListbox.Name = "müsteriBilgiListbox";
            this.müsteriBilgiListbox.Size = new System.Drawing.Size(568, 447);
            this.müsteriBilgiListbox.TabIndex = 15;
            this.müsteriBilgiListbox.Click += new System.EventHandler(this.müsteriBilgiListbox_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(282, 391);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(210, 47);
            this.silButton.TabIndex = 16;
            this.silButton.Text = "Kayıtlı Müşteriyi Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(282, 444);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(207, 47);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Temizle";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // systemSaveButton
            // 
            this.systemSaveButton.Location = new System.Drawing.Point(10, 444);
            this.systemSaveButton.Name = "systemSaveButton";
            this.systemSaveButton.Size = new System.Drawing.Size(205, 47);
            this.systemSaveButton.TabIndex = 17;
            this.systemSaveButton.Text = "Sisteme Kaydet";
            this.systemSaveButton.UseVisualStyleBackColor = true;
            this.systemSaveButton.Click += new System.EventHandler(this.systemSaveButton_Click);
            // 
            // anaekranButton
            // 
            this.anaekranButton.Location = new System.Drawing.Point(12, 497);
            this.anaekranButton.Name = "anaekranButton";
            this.anaekranButton.Size = new System.Drawing.Size(477, 47);
            this.anaekranButton.TabIndex = 18;
            this.anaekranButton.Text = "Ana Ekrana Dön";
            this.anaekranButton.UseVisualStyleBackColor = true;
            this.anaekranButton.Click += new System.EventHandler(this.anaekranButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 558);
            this.Controls.Add(this.anaekranButton);
            this.Controls.Add(this.systemSaveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.müsteriBilgiListbox);
            this.Controls.Add(this.kayitButton);
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
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Sea Residence";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.MaskedTextBox dtMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox numaraMaskedTextBox;
        private System.Windows.Forms.Label tcLabel;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label numaraLabel;
        private System.Windows.Forms.Label doğumTarihiLabel;
        private System.Windows.Forms.Button kayitButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button systemSaveButton;
        private System.Windows.Forms.Button anaekranButton;
        public System.Windows.Forms.ListBox müsteriBilgiListbox;
    }
}