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
    public partial class exchange : Form
    {
        public exchange()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string code1 = "441", code2 = "933", code3 = "830";

            if (Staff.Text == code1)
            {
                MessageBox.Show("Selamat Kamu Mendapatkan 1 Koin" +
                    "Berterimakasihlah kepada Kakak Lylia");
            }
            else if (Staff.Text == code2)
            {
                MessageBox.Show("Selamat Kamu Mendapatkan 1 Koin" +
                    "Berterimakasihlah kepada Kakak Soka");
            }
            else if (Staff.Text == code3)
            {
                MessageBox.Show("Selamat Kamu Mendapatkan 1 Koin" +
                    "Berterimakasihlah kepada Kakak Boni");
            }
            else

                MessageBox.Show("Whoops Code yang kamu masukkan salah!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tukar form = new Tukar();
            form.ShowDialog();
             
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
