using System.Security.Cryptography;

namespace wezel4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s1 = "fsdfsd";
            String s2 = "fsdfsFSDFSDads";
            int n = s1.Length;
            int m = s2.Length;
            int[,] tab = new int[n+1, m+1];
            for(int i=1; i<tab.GetLength(0); i++)
            {
                for(int j=1; j<tab.GetLength(1); j++)
                {
                    if (s1[i-1] == s2[j-1])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        tab[i, j] = Math.Max(tab[i - 1, j], tab[i, j - 1]);
                    }
                }
            }

        }
    }

}