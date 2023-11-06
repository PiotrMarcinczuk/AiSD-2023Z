using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
            numericUpDown1.Enabled = false;
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
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkbox
            if (checkBox1.Checked)
            {
                textBox1.Enabled = false;
                numericUpDown1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = true;
                numericUpDown1.Enabled = false;
            }
            textBox1.Text = "";
            textBox2.Text = "";
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
            int[] numbersTab = Convert(textBox1.Text);

            if(numbersTab != null)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int minIndex = 0;
                int index = 0;
                int temp = 0;
                for (int i = 0; i < numbersTab.Length; i++)
                {
                    minIndex = i;
                    for (int j = i + 1; j < numbersTab.Length; j++)
                    {
                        if (numbersTab[j] < numbersTab[minIndex])
                        {
                            minIndex = j;
                        }
                    }
                    if (minIndex != i)
                    {
                        temp = numbersTab[minIndex];
                        numbersTab[minIndex] = numbersTab[i];
                        numbersTab[i] = temp;
                    }
                }

                stopwatch.Stop();
                TimeSpan timeSpan = stopwatch.Elapsed;
                timeValue.Text = timeSpan.TotalMilliseconds + " ms";

                string sortedTab = string.Join(" ", numbersTab);
                textBox2.Text = sortedTab;

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //SI
            int[] numbersTab = Convert(textBox1.Text);

            if(numbersTab != null)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int temp = 0;

                for(int i=1; i<numbersTab.Length; i++)
                {
                    temp = numbersTab[i];
                    int j = i - 1;
                    while(j >= 0 && numbersTab[j] > temp)
                    {
                        numbersTab[j + 1] = numbersTab[j];
                        j -= 1; // jesli j mniejsze od 0 to nie sprawdzamy juz po lewej j
                    }
                    numbersTab[j + 1] = temp;
                }

                stopwatch.Stop();
                TimeSpan timeSpan = stopwatch.Elapsed;
                timeValue.Text = timeSpan.TotalMilliseconds + " ms";

                string sortedTab = string.Join(" ", numbersTab);
                textBox2.Text = sortedTab;
            }
        }

        private void SM_Click(object sender, EventArgs e)
        {
            //SM
            int[] numbersTab = Convert(textBox1.Text);

            
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                mergeSort(numbersTab);

                stopwatch.Stop();
                TimeSpan timeSpan = stopwatch.Elapsed;
                timeValue.Text = timeSpan.TotalMilliseconds + " ms";

                string sortedTab = string.Join(" ", numbersTab);
                textBox2.Text = sortedTab;
            
        }

        private void mergeSort(int[] numbersTab)
        {
            if(numbersTab.Length <= 1)
            {
                return;
            }

            int mid = numbersTab.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[numbersTab.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = numbersTab[i];
            }
            for (int i = mid; i < numbersTab.Length; i++)
            {
                right[i-mid] = numbersTab[i];
            }

            mergeSort(left);
            mergeSort(right);

            // Kiedy mamy juz pojedyncze elementy jako tablicy laczymy je w wieksze tablice
            int leftIndex = 0, rightIndex = 0, index = 0;
            while(leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    numbersTab[index] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    numbersTab[index] = right[rightIndex];
                    rightIndex++;
                }
                index++;
            }

            while(leftIndex < left.Length)
            {
                numbersTab[index] = left[leftIndex];
                leftIndex++;
                index++;
            }

            while(rightIndex < right.Length)
            {
                numbersTab[index] = right[rightIndex];
                rightIndex++;
                index++;
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //SQ
            int[] numbersTab = Convert(textBox1.Text);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            quickSort(numbersTab, 0 ,numbersTab.Length-1);

            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            timeValue.Text = timeSpan.TotalMilliseconds + " ms";

            string sortedTab = string.Join(" ", numbersTab);
            textBox2.Text = sortedTab;

        }

        private void quickSort(int[] numbersTab, int left, int right)
        {
            if (left < right)
            {
                int pivotTemp = pivotIndex(numbersTab, left, right);
                quickSort(numbersTab, left, pivotTemp-1);
                quickSort(numbersTab, pivotTemp+1, right);
            }
        }

        private int pivotIndex(int[] numbersTab, int left, int right)
        {
            int pivot = numbersTab[right];
            int i = left - 1;
            for(int j=left; j<right; j++)
            {
                if (numbersTab[j] <= pivot)
                {
                    i++;
                    int temp = numbersTab[i];
                    numbersTab[i] = numbersTab[j];
                    numbersTab[j] = temp;
                }
            }
            int tempPivot = numbersTab[i + 1];
            numbersTab[i + 1] = numbersTab[right];
            numbersTab[right] = tempPivot;

            return i + 1;
        }

        private void timeValue_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Generuj_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int size = (int)numericUpDown1.Value;
            int[] numbersTab = new int[size];
            for (int i = 0; i < numbersTab.Length; i++)
            {
                numbersTab[i] = random.Next(-2000, 2000);
                textBox1.Text += numbersTab[i] + " ";
            }
        }
    }
}
