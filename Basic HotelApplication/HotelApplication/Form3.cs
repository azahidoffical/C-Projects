using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApplication
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void anaEkranButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void kytKontrolButton_Click(object sender, EventArgs e)
        {
            string girilenTC = tcTextBox.Text;
            string girilenAd = adTextBox.Text;
            string girilenSoyad = soyadTextBox.Text;
            string girilenTelefon = numaraMaskedTextBox.Text;
            string girilenDogumTarihi = dtMaskedTextBox.Text;
            string girilenMail = mailTextBox.Text;

            bool kayitVarMi = false;

            if (!File.Exists(Form2.dosyaYolu))
            {
                MessageBox.Show("Kayıt dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StreamReader oku = new StreamReader(Form2.dosyaYolu);
            string satir;

            while ((satir = oku.ReadLine()) != null)
            {
                satir = satir.Replace("\r", "").Replace("\n", ""); // Satır sonu karakterlerini sil

                string[] parcalar = satir.Split('#');

                if (parcalar.Length >= 6)
                {
                    string dosyaTC = parcalar[0];
                    string dosyaAd = parcalar[1];
                    string dosyaSoyad = parcalar[2];
                    string dosyaTelefon = parcalar[3];
                    string dosyaDogumTarihi = parcalar[4];
                    string dosyaMail = parcalar[5];

                    if (
                        girilenTC == dosyaTC &&
                        girilenAd == dosyaAd &&
                        girilenSoyad == dosyaSoyad &&
                        girilenTelefon == dosyaTelefon &&
                        girilenDogumTarihi == dosyaDogumTarihi &&
                        girilenMail == dosyaMail
                       )
                    {
                        kayitVarMi = true;
                        break;
                    }
                }
            }

            oku.Close();

            if (kayitVarMi)
            {
                MessageBox.Show("Kullanıcı sistemde kayıtlı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı sistemde kayıtlı değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
