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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string dosyaYolu = "otelkayit.txt";
        private void kayitButton_Click(object sender, EventArgs e)
        {
            string tckimlik = tcTextBox.Text;
            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string telefon = numaraMaskedTextBox.Text;
            string dogumtarihi = dtMaskedTextBox.Text;
            string mail = mailTextBox.Text; // Mail TextBox adını kendi formundakiyle değiştir

            if (tckimlik.Length != 11 || !tckimlik.All(char.IsDigit))
            {
                MessageBox.Show("Geçerli bir 11 haneli TC Kimlik numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!mail.Contains("@"))
            {
                MessageBox.Show("Mail adresinde '@' işareti bulunmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Oda numarası üretme
            Random rnd = new Random();
            int kat = rnd.Next(1, 10) * 100;       
            int oda = rnd.Next(0, 9);  
            int odaNo = kat + oda;                 

            // Bilgileri listeye ekle
            müsteriBilgiListbox.Items.Add(tckimlik + "#" + ad + "#" + soyad + "#" + telefon + "#" + dogumtarihi + "#" + mail + "#" + odaNo);
            MessageBox.Show("Kayıt başarıyla eklendi. Oda No: " + odaNo, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       

        private void clearButton_Click(object sender, EventArgs e)
        {
            tcTextBox.Clear();
            adTextBox.Clear();
            soyadTextBox.Clear();
            numaraMaskedTextBox.Clear();
            dtMaskedTextBox.Clear();
            mailTextBox.Clear(); // mail için de ekle
        }

        private void systemSaveButton_Click(object sender, EventArgs e)
        {

            StreamWriter kaydet = new StreamWriter(dosyaYolu);
            for (int i = 0; i < müsteriBilgiListbox.Items.Count; i++)
            {
                kaydet.WriteLine(müsteriBilgiListbox.Items[i].ToString());
            }
            kaydet.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader oku = new StreamReader(dosyaYolu);
            string satir;
            while ((satir = oku.ReadLine()) != null)
            {
                müsteriBilgiListbox.Items.Add(satir);
            }
            oku.Close();

            MessageBox.Show("Kayıt ekranı aktif","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void silButton_Click(object sender, EventArgs e)
        {
            müsteriBilgiListbox.Items.RemoveAt(müsteriBilgiListbox.SelectedIndex);
        }

        private void müsteriBilgiListbox_Click(object sender, EventArgs e)
        {
            int satirno = müsteriBilgiListbox.SelectedIndex;
            if (satirno == -1) return;

            string satir = müsteriBilgiListbox.Items[satirno].ToString();

            string[] parçalar = satir.Split('#');

            if (parçalar.Length < 7) return; // Artık 7 parça: tc, ad, soyad, tel, doğum, mail, oda

            tcTextBox.Text = parçalar[0];
            adTextBox.Text = parçalar[1];
            soyadTextBox.Text = parçalar[2];
            numaraMaskedTextBox.Text = parçalar[3];
            dtMaskedTextBox.Text = parçalar[4];
            mailTextBox.Text = parçalar[5];
            
        }

        private void anaekranButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
