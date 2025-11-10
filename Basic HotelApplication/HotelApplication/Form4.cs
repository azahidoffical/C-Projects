using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApplication
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DairelerListBox.Items.Clear();

            string secilenKat = comboBox1.SelectedItem.ToString();

            // En sade haliyle if-else kullanarak daireleri göster
            if (secilenKat == "1. Kat")
            {
                DairelerListBox.Items.Add("Daire 101 - 5.000.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 102 - SATILDI");
                DairelerListBox.Items.Add("Daire 103 - SATILDI");
                DairelerListBox.Items.Add("Daire 104 - SATILDI");
                DairelerListBox.Items.Add("Daire 105 - 9.000.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 106 - 9.095.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 107 - 9.125.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 108 - SATILDI");
                DairelerListBox.Items.Add("Daire 109 - SATILDI");
            }
            else if (secilenKat == "2. Kat")
            {
                DairelerListBox.Items.Add("Daire 201 - 7.000.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 202 - SATILDI");
                DairelerListBox.Items.Add("Daire 203 - 7.550.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 204 - SATIlDI");
                DairelerListBox.Items.Add("Daire 205 - 8.250.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 206 - SATILDI");
                DairelerListBox.Items.Add("Daire 207 - 9.320.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 208 - SATILDI");
                DairelerListBox.Items.Add("Daire 209 - SATILDI");
            }
            else if (secilenKat == "3. Kat")
            {
                DairelerListBox.Items.Add("Daire 301 - SATILDI");
                DairelerListBox.Items.Add("Daire 302 - 8.910.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 303 - 9.410.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 304 - 9.610.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 305 - SATILDI");
                DairelerListBox.Items.Add("Daire 306 - SATILDI");
                DairelerListBox.Items.Add("Daire 307 - 10.310.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 308 - SATILDI");
                DairelerListBox.Items.Add("Daire 309 - 10.910.000₺ - SATILIK");
            }
            else if (secilenKat == "4. Kat")
            {
                DairelerListBox.Items.Add("Daire 401 - 8.250.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 402 - 8.650.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 403 - SATILDI");
                DairelerListBox.Items.Add("Daire 405 - 9.120.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 406 - 9.350.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 407 - 9.950.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 408 - 10.350.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 409 - 10.750.000₺ - SATILIK");

            }
            else if (secilenKat == "5. Kat")
            {
                DairelerListBox.Items.Add("Daire 501 - 9.500.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 502 - 9.965.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 503 - 10.120.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 504 - 10.520.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 505 - 10.980.00₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 506 - SATILDI");
                DairelerListBox.Items.Add("Daire 507 - SATILDI");
                DairelerListBox.Items.Add("Daire 508 - 11.625.200₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 509 - 11.925.200₺ - SATILIK");
            }
            else if (secilenKat == "6. Kat")
            {
                DairelerListBox.Items.Add("Daire 601 - 10.500.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 602 - 10.965.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 603 - 11.420.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 604 - SATILDI");
                DairelerListBox.Items.Add("Daire 605 - 11.980.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 606 - 12.320.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 607 - 12.525.200₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 608 - SATILDI");
                DairelerListBox.Items.Add("Daire 609 - SATILDI");
            }
            else if (secilenKat == "7. Kat")
            {
                DairelerListBox.Items.Add("Daire 701 - 11.000.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 702 - SATILDI");
                DairelerListBox.Items.Add("Daire 703 - 11.800.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 704 - 12.200.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 705 - SATILDI");
                DairelerListBox.Items.Add("Daire 706 - 13.120.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 707 - SATILDI");
                DairelerListBox.Items.Add("Daire 708 - 13.525.200₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 709 - 13.825.200₺ - SATILIK");
            }
            else if (secilenKat == "8. Kat")
            {
                DairelerListBox.Items.Add("Daire 801 - 12.000.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 802 - 12.965.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 803 - 13.420.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 804 - SATILDI");
                DairelerListBox.Items.Add("Daire 805 - 13.980.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 806 - SATILDI");
                DairelerListBox.Items.Add("Daire 807 - 14.525.200₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 808 - 14.825.200₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 809 - SATILDI");
            }
            else if (secilenKat == "9. Kat")
            {
                DairelerListBox.Items.Add("Daire 901 - 13.000.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 902 - 13.965.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 903 - SATILDI");
                DairelerListBox.Items.Add("Daire 904 - 14.620.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 905 - SATILDI");
                DairelerListBox.Items.Add("Daire 906 - 15.320.000₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 907 - 15.725.200₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 908 - 16.025.200₺ - SATILIK");
                DairelerListBox.Items.Add("Daire 909 - SATILDI");
            }
            else
            {
                DairelerListBox.Items.Add("Bu katta kayıt yok.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void kayitButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
