using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out var number))
            {
                var primeThread = new Thread(() => GetPrimeNumbers(number, listView1));
                primeThread.Start();
            }

            else
            {
                MessageBox.Show("Invalid number");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out var number))
            {
                var primeThread = new Thread(() => GetPrimeNumbers(number, listView2));
                primeThread.Start();
            }
            else
            {
                MessageBox.Show("Invalid number");
            }
        }

        private void GetPrimeNumbers(int n, ListView listBox)
        {
            var primes = new List<int>();

            for (var i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }


            listBox.Invoke((MethodInvoker)delegate
            {
                listBox.Items.Clear();
                foreach (int prime in primes)
                {
                    listBox.Items.Add($"{prime}");
                }
            });
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (var i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}