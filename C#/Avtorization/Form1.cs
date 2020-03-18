using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtorization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Avtorisation = new Form2();
            Avtorisation.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Registration = new Form3();
            Registration.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
