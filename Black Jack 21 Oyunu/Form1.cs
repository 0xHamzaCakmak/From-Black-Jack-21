using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack_21_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int sayac = 0;
        int oyuncupuan = 0;
        int pcpuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                int a1, a2, toplam;
                a1 = r.Next(1, 11);
                a2 = r.Next(1, 11);
                toplam = a1 + a2;
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label10.Text = toplam.ToString();
            }
            if (sayac == 2)
            {
                int a3, toplam;
                a3 = r.Next(1, 11);
                label3.Text = a3.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label10.Text = toplam.ToString();

            }
            if (sayac == 3)
            {
                int a4, toplam;
                a4 = r.Next(1, 11);
                label4.Text = a4.ToString();
                toplam = toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label10.Text = toplam.ToString();
            }
            if (label1.Text == "1")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\1.png";
            }
            if (label1.Text == "2")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\2.png";
            }
            if (label1.Text == "3")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\3.png";
            }
            if (label1.Text == "4")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\4.png";
            }
            if (label1.Text == "5")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\5.png";
            }
            if (label1.Text == "6")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\6.png";
            }
            if (label1.Text == "7")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\7.png";
            }
            if (label1.Text == "8")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\8.png";
            }
           
            if (label1.Text == "9")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\9.png";
            }
            if (label1.Text == "10")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\10.png";
            }
            if (label1.Text == "11")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\11.png";
            }
            if (label1.Text == "12")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\12.png";
            }
            if (label1.Text == "13")
            {
                pictureBox1.ImageLocation = "‪C:\\Users\\reela\\OneDrive\\Masaüstü\\c# resim\\balack jack\\13.png";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2, toplam;
            b1 = r.Next(1, 11);
            b2 = r.Next(1, 11);
            toplam = b1 + b2;
            label5.Text = b1.ToString();
            label6.Text = b2.ToString();
            label11.Text = toplam.ToString();
            
            if (toplam < 16)
            {
                int b3;
                b3 = r.Next(1, 11);
                label7.Text = b3.ToString();
                toplam += b3;
                label11.Text = toplam.ToString();
            }
            if (toplam < 16)
            {
                int b4 = r.Next(1, 11);
                label8.Text = b4.ToString();
                toplam += b4;
                label11.Text = toplam.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;
            int oyuncutoplam, pctoplam;
            oyuncutoplam = Convert.ToInt32(label10.Text);
            pctoplam = Convert.ToInt32(label11.Text);

            if (oyuncutoplam > pctoplam && oyuncutoplam <= 21)
            {
                oyuncupuan += 10;
                label20.Text = oyuncupuan.ToString();
            }
            if (pctoplam > oyuncutoplam && pctoplam <= 21)
            {
                pcpuan += 10;
                label21.Text = pcpuan.ToString();
            }
            if (pctoplam > 21 && oyuncutoplam > 21)
            {
                MessageBox.Show("Değerler Büyük. Oyun Berabere");
            }
            if (pctoplam == oyuncutoplam && pctoplam <= 21 && oyuncutoplam <= 21)
            {
                pcpuan += 10;
                oyuncupuan += 10;
            }
            if (oyuncupuan == 50)
            {
                MessageBox.Show("Tebrıkler Kazandınız...");
            }
            if (pcpuan == 50)
            {
                MessageBox.Show("Malesef KAybettiniz ...");
            }
            if (pctoplam <= 21 && oyuncutoplam > 21)
            {
                pcpuan += 10;
                label21.Text = pcpuan.ToString();
            }
            if (oyuncutoplam <= 21 && pctoplam > 21)
            {
                oyuncupuan += 10;
                label20.Text = oyuncupuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayac = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label11.Text = "0";
            label10.Text = "0";
            button4.Enabled = false;
            button3.Enabled = true;

        }
    }
}
