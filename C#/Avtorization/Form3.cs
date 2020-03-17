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

namespace Avtorization
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "1.txt", System.Text.Encoding.Default))
            {
                string line;
                bool if_login = false;
                while ((line = sr.ReadLine()) != null)
                {
                    if (if_login == true)
                    {
                        if (line == "Пароль: " + textBox2.Text)
                        {
                            Form4 HelloForm = new Form4();
                            HelloForm.ShowDialog();
                            break;
                        } else { if_login = false; }
                    }
                    if (line == "Логин: " + textBox1.Text)
                    {
                        if_login = true;
                    } 
                }
                if (if_login == false)
                {
                    MessageBox.Show("Пользователь не найден!!!");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
