using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiVize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        double sayi1, sayi2;
        double sonuc;
        string islem;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text);

            switch(islem)
            {
                case "+": sonuc = sayi1 + sayi2;
                    break;
                case "-": sonuc = sayi1 - sayi2;
                    break;
                case "*": sonuc = sayi1 * sayi2;
                    break;
                case "/": sonuc = sayi1 / sayi2;
                    break;
                case "x^y": sonuc = Math.Pow(sayi1, sayi2);
                    break;
                default:
                    break;
            }
            textBox1.Text = sonuc.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            islem = "+";
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            islem = "-";
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            islem = "/";
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            islem = "*";
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            islem = "x^y";
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Exp(sayi1);
            textBox1.Text = sonuc.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Sqrt(sayi1);
            textBox1.Text = sonuc.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = 1;

            for (int i = 0; i <= sayi1; i++)
            {
                sonuc *= i;
            }

            textBox1.Text = sonuc.ToString();
        }

      
    }
}
