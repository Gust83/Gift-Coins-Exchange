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
    public partial class Tukar : Form
    {
        public Tukar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                deskripsi.Text = "Es Krim Susu HONIAN berbagai Rasa";
                koin.Text = "5 Koin";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                deskripsi.Text = "Kripik Kentang Khas HONIAN";
                koin.Text = "8 Koin";

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                deskripsi.Text = "Payung Edisi Spesial HONIAN";
                koin.Text = "50 Koin";
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                deskripsi.Text = "Pistol Air Honian";
                koin.Text = "45 Koin";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                deskripsi.Text = "Boneka Beruang Dengan baju Staff HONIAN";
                koin.Text = "83 Koin";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 5;
            deskripsi.Text = "";
            koin.Text = "";
            id.Text = "";
            pay.Text = "";
                }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            double change = 0;
            


            if (comboBox1.SelectedIndex == 0)
            {
                total = 5;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                total = 8;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                total = 50;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                total = 45;
            }
            else if (comboBox1.SelectedIndex == 4)
            {

                total = 83;
            }
            double pay = double.Parse(this.pay.Text);

         if (pay < total)
            {
                MessageBox.Show("Coin mu Kurang, bermainlah lagi");
            }
         else
            {

         
                change = pay - total;
                MessageBox.Show("Selamat dan Terimakasih telah bermain Di TAMAN HONIAN" +
                    "Sisa Koin transaksi kamu adalah: " + change + " Koin");
                
            }

         

        }



        private void button3_Click(object sender, EventArgs e)
        {
            exchange form = new exchange();
            form.ShowDialog();
    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            History f = new History();
            string comboBox = comboBox1.ToString();
            f.ko = comboBox;
            f.Mo = id.Text;
            f.Lo = koin.Text;
            
            History form = new History();
            form.ShowDialog();
            this.Hide();
        }

        private void koin_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
