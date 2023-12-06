using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.Classlar;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toplama toplama = new Toplama();
            Ortalama ortalama = new Ortalama();
            toplama.Sayi1 = int.Parse(sayi1.Text);
            toplama.Sayi2= int.Parse(sayi2.Text);
            toplama.Sayi3 = int.Parse(sayi3.Text);
            ortalama.Sayi1= int.Parse(sayi1.Text);
            ortalama.Sayi2 = int.Parse(sayi2.Text);
            ortalama.Sayi3= int.Parse(sayi3.Text);
            ToplamSayi.Text = Convert.ToString(toplama.topla());
            OrtSAyi.Text=Convert.ToString(ortalama.OrtHesapla());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1.Text = Convert.ToString(" ");
            sayi2.Text = Convert.ToString(" ");
            sayi3.Text = Convert.ToString(" ");
            ToplamSayi.Text=string.Empty;
            OrtSAyi.Text=string.Empty;


        }
    }
}
