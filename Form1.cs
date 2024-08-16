using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        private double _result = 0; // Toplama işlemi için kullanılan sonuç değeri
        private string _operation = ""; // Yapılacak işlemi belirten değişken
        public Form1()
        {
            InitializeComponent();
        }
        //Tuş Atamaları
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button0.Text;
        }
        // İşlem Eylemleri
        private void btnTopla_Click(object sender, EventArgs e)
        {
            _operation = "+";
            _result = double.Parse(richTextBox1.Text);
            richTextBox1.Text = "";
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            _operation = "-";
            _result = double.Parse(richTextBox1.Text);
            richTextBox1.Text = "";
        }
        private void btnCarpma_Click(object sender, EventArgs e)
        {
            _operation = "*";
            _result = double.Parse(richTextBox1.Text);
            richTextBox1.Text = "";
        }
        private void btnBolme_Click(object sender, EventArgs e)
        {
            _operation = "/";
            _result = double.Parse(richTextBox1.Text);
            richTextBox1.Text = "";
        }
        private void btnYuzde_Click(object sender, EventArgs e)
        {
            _operation = "%";
            _result = double.Parse(richTextBox1.Text);
            richTextBox1.Text = "";
        }

        //Sonuç İçin Eylem Bölümü
        private void btnSonuc_Click(object sender, EventArgs e)
        {
            double secondOperand = double.Parse(richTextBox1.Text);

            switch (_operation)
            {
                case "+":
                    richTextBox1.Text = (_result + secondOperand).ToString();
                    break;
                case "-":
                    richTextBox1.Text = (_result - secondOperand).ToString();
                    break;
                case "*":
                    richTextBox1.Text = (_result * secondOperand).ToString();
                    break;
                case "/":
                    if (secondOperand != 0)
                    {
                        richTextBox1.Text = (_result / secondOperand).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Bölme işlemi sıfır ile yapılamaz!");
                        richTextBox1.Text = "";
                    }
                    break;

                case "%":
                    richTextBox1.Text = ((_result * secondOperand) / 100).ToString();
                    break;
            }
            _result = 0;
            _operation = "";
        }
        //Silme Eylemi
        private void btnSilme_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            _result = 0;
            _operation = "";
        }

        
    }
}
