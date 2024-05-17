using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace park
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Penukaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tukar form = new Tukar();
            form.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            exchange form = new exchange();
            form.ShowDialog();
        }
    }
}
