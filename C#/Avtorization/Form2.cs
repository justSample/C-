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

namespace Avtorization
{
    public partial class Form2 : Form
    {
        private string nameTxt = "LoginAndPasswords.txt";
        private string txtPath = AppDomain.CurrentDomain.BaseDirectory;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(txtPath + nameTxt, true, Encoding.Default);

            sw.AutoFlush = true;
            sw.WriteLine("Логин: "  + textBox1.Text);
            sw.WriteLine("Пароль: " + textBox2.Text);
            sw.Close();

            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
