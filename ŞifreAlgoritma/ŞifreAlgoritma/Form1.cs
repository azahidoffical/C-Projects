using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞifreAlgoritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yazi = textBox1.Text; // Kullanıcının girdiği metin
            char[] karakterler = yazi.ToCharArray();
            int uzunluk = karakterler.Length;
            string[] kodlar = new string[uzunluk];

            // Her karakterin ASCII kodunu al ve string dizisine at
            for (int i = 0; i < uzunluk; i++)
            {
                kodlar[i] = ((int)karakterler[i]).ToString();
            }

            // ASCII kodlarını 4 haneye tamamla (başına 0 ekleyerek)
            string siraliKodlar = "";
            for (int i = 0; i < kodlar.Length; i++)
            {
                string asciikodu = kodlar[i];
                int eklenecek = 4 - asciikodu.Length;
                for (int j = 0; j < eklenecek; j++)
                {
                    asciikodu = "0" + asciikodu;
                }
                siraliKodlar += asciikodu;
            }

            // Karıştırma: baştan ve sondan sırayla birer karakter alarak şifre oluştur
            string sifre = "";
            int sol = 0;
            int sag = siraliKodlar.Length - 1;

            while (sol <= sag)
            {
                sifre += siraliKodlar.Substring(sol, 1);
                if (sol != sag)
                    sifre += siraliKodlar.Substring(sag, 1);
                sol++;
                sag--;
            }

            label2.Text = sifre; // Şifreyi göster
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifre = label2.Text; // Şifreli metin
            string ilkyarisi = "";
            string sonyarisi = "";

            // Şifreyi çözmek için karakterleri iki gruba ayır
            for (int i = 0; i < sifre.Length; i += 2)
            {
                ilkyarisi += sifre.Substring(i, 1);
                if (i + 1 < sifre.Length)
                    sonyarisi = sifre.Substring(i + 1, 1) + sonyarisi;
            }

            string siralikodlar = ilkyarisi + sonyarisi; // Asıl ASCII kodları sıralı hali

            // ASCII kodlarını çöz ve karakterlere dönüştür
            string yazi = "";
            int index = 0;
            while (index < siralikodlar.Length)
            {
                string kodParca = siralikodlar.Substring(index, 4);
                int asciiKodu = int.Parse(kodParca);
                yazi += (char)asciiKodu;
                index += 4;
            }

            label3.Text = yazi; // Çözülmüş metni göster
        }
    }
}
