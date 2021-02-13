using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bir_İŞLEMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int sayi3;
        public void RandomAl()
        {
            sayi3 = rastgele.Next(100, 1000);
            textBox7.Text = sayi3.ToString();

            int[] sayi2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            textBox6.Text = sayi2[rastgele.Next(9)].ToString();

            int[] sayi = new int[5];
            for (int i = 0; i < 5; i++)
            {
                sayi[i] = rastgele.Next(1, 10);
            }
            textBox1.Text = sayi[0].ToString();
            textBox2.Text = sayi[1].ToString();
            textBox3.Text = sayi[2].ToString();
            textBox4.Text = sayi[3].ToString();
            textBox5.Text = sayi[4].ToString();
        }

        public void Hesapla()
        {

            sayi3 = Convert.ToInt32(textBox7.Text);

            int[] sayilar = new int[] { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text) };

            while (true)
            {
                int num = rastgele.Next(6);
                int temp = sayilar[num];
                sayilar[num] = sayilar[0];
                sayilar[0] = temp;

                int toplam = sayilar[0];
                string sonuc = sayilar[0].ToString();

                int sayac = rastgele.Next(1, 7);

                for (int i = 1; i < sayac; i++)
                {
                    int islem = rastgele.Next(4);

                    if (islem == 0)
                    {
                        toplam += sayilar[i];
                        sonuc += " + " + sayilar[i].ToString();
                    }
                    if (islem == 1)
                    {
                        toplam -= sayilar[i];
                        sonuc += " - " + sayilar[i].ToString();
                    }
                    if (islem == 2)
                    {
                        toplam *= sayilar[i];
                        sonuc += " x " + sayilar[i].ToString();
                    }
                    if (islem == 3)
                    {
                        if (toplam % sayilar[i] != 0) continue;
                        toplam /= sayilar[i];
                        sonuc += " / " + sayilar[i].ToString();
                    }
                }
                sonuc += " = " + toplam.ToString();

                if (toplam == sayi3)
                {
                    listBox1.Items.Add(sonuc);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomAl();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
           
        }
    }
}

