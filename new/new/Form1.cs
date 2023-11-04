using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace @new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Convert(string data)
        {
            try
            {
                string inputText = textBox1.Text;
                var stringNumbers = inputText.Trim().Split(' ');

                var numbers = new int[stringNumbers.Length];
                for (int i = 0; i < stringNumbers.Length; i++)
                {
                    numbers[i] = int.Parse(stringNumbers[i]);
                }
                return numbers;
            }
            catch
            {
                MessageBox.Show("Zły format danych");
                return null;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkboxa
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SB
            int[] numbersTab = Convert(textBox1.Text);
            if(numbersTab != null)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();


                for (int i = 0; i < numbersTab.Length; i++)
                {
                    for (int j = 0; j < numbersTab.Length - 1; j++)
                    {
                        if (numbersTab[j] > numbersTab[j + 1])
                        {
                            int temp = numbersTab[j];
                            numbersTab[j] = numbersTab[j + 1];
                            numbersTab[j + 1] = temp;
                        }
                    }
                }

                stopwatch.Stop();
                TimeSpan timeSpan = stopwatch.Elapsed;
                timeValue.Text = timeSpan.TotalMilliseconds + " ms";

                string sortedTab = string.Join(" ", numbersTab);
                textBox2.Text = sortedTab;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //SS
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //SI
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //SQ
        }

        private void timeValue_Click(object sender, EventArgs e)
        {
            //CZAS
        }
    }
}
