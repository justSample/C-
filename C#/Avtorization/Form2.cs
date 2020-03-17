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
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "1.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine("Логин: "+textBox1.Text);
                sw.WriteLine("Пароль: " + textBox2.Text);
                sw.Close();
            }
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
