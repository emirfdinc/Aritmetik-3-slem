using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aritmetik_3_İslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            Int32 sayi1,sayi2,sayi3,toplam;

            sayi1 =Convert.ToInt32(textBox1.Text);
            sayi2 =Convert.ToInt32(textBox2.Text);
            sayi3 =Convert.ToInt32(textBox3.Text);
            toplam=sayi1+sayi2+sayi3;
            listBox1.Items.Add("Toplam Sonucu:" + "" + toplam);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 sayi1, sayi2, sayi3, cıkarma;
            sayi1=Convert.ToInt32(textBox1.Text);
            sayi2=Convert.ToInt32(textBox2.Text);
            sayi3=Convert.ToInt32(textBox3.Text);
            cıkarma = sayi1 - sayi2 - sayi3;
            listBox1.Items.Add("Çıkarma Sonucu:" + cıkarma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 sayi1,sayi2,sayi3,carpma;

            sayi1=Convert.ToInt32(textBox1.Text);
            sayi2= Convert.ToInt32(textBox2.Text);
            sayi3=Convert.ToInt32(textBox3.Text);
            carpma = sayi1 * sayi2 * sayi3;
            listBox1.Items.Add("Çarpma Sonucu:" +  carpma);
                


        }
    }
}
