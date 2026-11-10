using System;
using System.Windows.Forms;

namespace temp_conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Button 1: Celsius to Fahrenheit (C → F)
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Read the text from textBox1 right when the button is clicked
            if (double.TryParse(textBox1.Text, out double temp))
            {
                // 2. Calculate and display
                double F = temp * 9 / 5 + 32;
                textBox2.Text = F.ToString("0.##") + "°F";
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        // Button 2: Fahrenheit to Celsius (F → C)
        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Read the text from textBox1 right when the button is clicked
            if (double.TryParse(textBox1.Text, out double temp))
            {
                // 2. Calculate and display
                double C = (temp - 32) * 5 / 9;
                textBox2.Text = C.ToString("0.##") + "°C";
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        // Leave this empty so typing won't crash your app
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
