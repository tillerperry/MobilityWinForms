using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                Task.Factory.StartNew(() =>
                {
                    List<int> primes = GetPrimesNumbers(number);
                    UpdateListBox(listView1, primes);
                });
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

        private List<int> GetPrimesNumbers(int n)
        {
            var primesNumbers = new List<int>();
            for (var i = 2; i <= n; i++)
            {
                var isPrimeNumberValue = true;
                for (var j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j != 0) continue;
                    isPrimeNumberValue = false;
                    break;
                }
                if (isPrimeNumberValue)
                {
                    primesNumbers.Add(i);
                }
            }
            return primesNumbers;
        }

        private void UpdateListBox(ListView listBox, List<int> primes)
        {
            if (listBox.InvokeRequired)
            {
                listBox.Invoke(new Action(() => UpdateListBox(listBox, primes)));
            }
            else
            {
                listBox.Items.Clear();
                foreach (int primeNumber in primes)
                {
                    listBox.Items.Add($"{primeNumber}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out var number))
            {
                Task.Factory.StartNew(() =>
                {
                    var primes = GetPrimesNumbers(number);
                    UpdateListBox(listView2, primes);
                });
            }
            else
            {
                MessageBox.Show("Invalid number");
            }

        }
    }
}
