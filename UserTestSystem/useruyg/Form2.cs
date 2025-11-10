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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            /*show forms*/
            form1.Show();
            /* hide this forms */
            this.Hide();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            int userNameLineFound = 0;
            int passwordLineFound = 0;
            bool isUserNameCorrect = false;
            bool isPasswordCorrect = false;

            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            for (int i = 0; i < Form1.userIndex; i++)
            {
                if (username == Form1.usernames[i])
                {
                    userNameLineFound = i;
                    isUserNameCorrect = true;
                    break;
                }
            }
            for (int i = 0; i < Form1.userIndex; i++)
            {
                if (password == Form1.passwords[i])
                {
                    passwordLineFound = i;
                    isPasswordCorrect = true;
                    break;
                }
            }
            if (isUserNameCorrect && isPasswordCorrect)
            {
                if (userNameLineFound  == passwordLineFound)
                {
                    richTextBox1.Text = "Kullanıcı sistemde tanımlı";
                    MessageBox.Show("Kullanıcı sistemde tanımlı");
                }
                else
                {
                    richTextBox1.Text = "Kullanıcı sistemde tanımlı değildir";
                    MessageBox.Show("Kullanıcı sistemde tanımlı değildir");
                }

            }
        }
    }
}
