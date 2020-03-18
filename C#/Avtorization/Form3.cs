using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using static Avtorization.Form2;

namespace Avtorization
{
    public partial class Form3 : Form
    {
        private string PathToTxt = AppDomain.CurrentDomain.BaseDirectory;
        private string TxtName = "LoginAndPasswords.txt";

        private const string USERNAMEBEGIN = "Логин: ";
        private const string USERPASSWORDBEGIN = "Пароль: ";

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(PathToTxt + TxtName, Encoding.Default);

            string line = String.Empty;
            string userName = String.Empty;
            string userPassword = String.Empty;

            List<User> listUsers = new List<User>();

            while ((line = sr.ReadLine()) != null)
            {
                if (String.IsNullOrEmpty(userName))
                {
                    userName = line.Substring(USERNAMEBEGIN.Length);
                }
                else if(String.IsNullOrEmpty(userPassword))
                {
                    userPassword = line.Substring(USERPASSWORDBEGIN.Length);

                    listUsers.Add(new User(userName, userPassword));

                    userName = String.Empty;
                    userPassword = String.Empty;
                }

            }

            bool isLoginFound = false;

            for(int i = 0;i < listUsers.Count ;i++ )
            {
                if (box_Login.Text.Equals(listUsers[i].Login) && box_Password.Text.Equals(listUsers[i].Password))
                {
                    isLoginFound = true;
                    Form4 HelloForm = new Form4();
                    HelloForm.ShowDialog();
                    break;
                }
            }

            if (!isLoginFound)
            {
                MessageBox.Show("Вы ввели логин или пароль неправильно!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
