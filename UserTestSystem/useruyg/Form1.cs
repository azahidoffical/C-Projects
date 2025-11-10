using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace useruyg
{
    public partial class Form1 : Form
    {
        public static string[] usernames = new string[128];
        public static string[] passwords = new string[128];
        public static int userIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;


            dataGridView1.Rows.Add(username, password, DateTime.Now);

            usernames[userIndex] = username;
            passwords[userIndex] = password;

            userIndex++;

            MessageBox.Show($"Kullanıcı sisteme başarıyla eklendi [Kullanıcı No:{userIndex.ToString()}]!", "Başarlı", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            /*show forms*/
            form2.Show();
            /* hide this forms */
            this.Hide();
        }
    }
}
