using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wezel3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            DrzewoBinarne tree = new DrzewoBinarne(5);
            var d1 = new Wezel3(3);
            var d2 = new Wezel3(4);
            var d3 = new Wezel3(8);
            var d4 = new Wezel3(7);
            var d5 = new Wezel3(6);
            var d6 = new Wezel3(5);
            var d7 = new Wezel3(1);
            tree.ADD(d1);
            tree.ADD(d2);
            tree.ADD(d3);
            tree.ADD(d4);
            tree.ADD(d5);
            tree.ADD(d6);
            tree.ADD(d7);
            DFS(tree.korzen);
            tree.Usun(d1);
            DFS(tree.korzen);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<Wezel3> odwiedzone = new List<Wezel3>();
        List<Wezel3> lista = new List<Wezel3>();
        public void DFS(Wezel3 w)
        {
            odwiedzone.Clear();
            if(w == null || odwiedzone.Contains(w))
            {
                return;
            }
            MessageBox.Show(w.ToString());
            odwiedzone.Add(w);
            comboBox1.Items.Add(w.ToString());

            DFS(w.leftChild);
            DFS(w.rightChild);
        }
    }
   
    public class Wezel3
    {
        public int wartosc;
        public Wezel3 rodzic;
        public Wezel3 leftChild;
        public Wezel3 rightChild;

        public Wezel3(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public override string ToString()
        {
            return "Wartość: " + this.wartosc.ToString();
        }

        public void Add(int liczba)
        {
            var dziecko = new Wezel3(liczba);
            dziecko.rodzic = this;
            if (liczba < this.wartosc)
            {
                this.leftChild = dziecko;
            }
            else
            {
                this.rightChild = dziecko;
            }
        }

        public Wezel3 Znajdz(int liczba)
        {
            var current = this;

            while (current != null)
            {
                if (liczba < current.wartosc)
                {
                    current = current.leftChild;
                }
                else if (liczba > current.wartosc)
                {
                    current = current.rightChild;
                }
                else
                {
                    return current;
                }
            }

            return null;
        }

        public Wezel3 ZnajdzMin(Wezel3 w)
        {
            var current = w;

            while (current.leftChild != null)
            {
                current = current.leftChild;
            }

            return current;
        }

        public Wezel3 ZnajdzMax(Wezel3 w)
        {
            var current = w;

            while (current.rightChild != null)
            {
                current = current.rightChild;
            }

            return current;
        }

        public Wezel3 Nastepnik()
        {
            if (this.rightChild != null)
            {
                // a) Następnik - jeżeli jest prawe dziecko, bierzemy wartość najmniejszą z największych
                return ZnajdzMin(this.rightChild);
            }

            // b) Jeżeli nie ma prawego dziecka: idź w górę tak długo, aż wyjdziesz jako lewe dziecko. Rodzic w którym wyszedłeś jest następnikiem.
            var parent = this.rodzic;
            var current = this;

            while (parent != null && current == parent.rightChild)
            {
                current = parent;
                parent = parent.rodzic;
            }

            return parent;
        }

        public Wezel3 Poprzednik()
        {
            if (this.leftChild != null)
            {
                return ZnajdzMin(this.leftChild);
            }

            var parent = this.rodzic;
            var current = this;

            while (parent != null && current == parent.leftChild)
            {
                current = parent;
                parent = parent.rodzic;
            }

            return parent;
        }

        internal int liczbaDzieci()
        {
            int wynik = 0;
            if (this.leftChild != null)
            {
                wynik++;
            }
            if (this.rightChild != null)
            {
                wynik++;
            }
            return wynik;
        }
    }

    public class DrzewoBinarne
    {
        public Wezel3 korzen;
        public int liczbaWezlow;
        public DrzewoBinarne(int liczba)
        {
            this.korzen = new Wezel3(liczba);
            this.liczbaWezlow = 1;
        }

        public void ADD(Wezel3 w)
        {
            Queue<Wezel3> queue = new Queue<Wezel3>();
            queue.Enqueue(this.korzen);
            while (queue.Count > 0)
            {
                Wezel3 parent = queue.Dequeue();
                if (w.wartosc < parent.wartosc)
                {
                    if (parent.leftChild == null)
                    {
                        parent.leftChild = w;
                        w.rodzic = parent;
                        this.liczbaWezlow++;
                        return;
                    }
                    else
                    {
                        queue.Enqueue(parent.leftChild);
                    }
                }
                else
                {
                    if (parent.rightChild == null)
                    {
                        parent.rightChild = w;
                        w.rodzic = parent;
                        this.liczbaWezlow++;
                        return;
                    }
                    else
                    {
                        queue.Enqueue(parent.rightChild);
                    }
                }

            }
        }

        public Wezel3 Usun(Wezel3 w)
        {
            switch (w.liczbaDzieci())
            {
                case 0:
                    w = this.UsunGdy0Dzieci(w);
                    break;
                case 1:
                    w = this.UsunGdy1Dzieci(w);
                    break;
                case 2:
                    w = this.UsunGdy2Dzieci(w);
                    break;

            }
            return w;
        }

        public Wezel3 UsunGdy0Dzieci(Wezel3 w)
        {
            if (w.rodzic == null)
            {
                this.korzen = null;
                return w;
            }
            if (w.rodzic.leftChild == w)
            {
                w.rodzic.leftChild = null;
            }
            else
            {
                w.rodzic.rightChild = null;
            }
            w.rodzic = null;
            return w;
        }

        public Wezel3 UsunGdy1Dzieci(Wezel3 w)
        {
            Wezel3 dziecko = null;
            if(w.leftChild != null)
            {
                dziecko = w.leftChild;
                w.leftChild = null;
            }
            else
            {
                dziecko = w.rightChild;
                w.rightChild = null;
            }
            dziecko.rodzic = w.rodzic;

            if(w.rodzic == null)
            {
                this.korzen = dziecko;
            }
            else
            {
                if(w.rodzic.leftChild == w)
                {
                    w.rodzic.leftChild = dziecko;
                }
                else
                {
                    w.rodzic.rightChild = dziecko;
                }
                w.rodzic = null;
            }
            return w;
            // 6 przypadkow
        }

        public Wezel3 UsunGdy2Dzieci(Wezel3 w)
        {
            if(w.rodzic == null)
            {
                this.korzen = w.rightChild;
                w.rightChild.rodzic = null;
                w.leftChild.rodzic = w.rightChild;
            }
            else
            {
                w.rodzic.leftChild = w.leftChild;
                w.rodzic.rightChild = w.rightChild;
            }
            return w;
        }

        public Wezel3 ZnajdzRodzica(int liczba)
        {
            var w = this.korzen;
            Queue<Wezel3> queue = new Queue<Wezel3>();
            queue.Enqueue(w);
            while (queue.Count > 0)
            {
                Wezel3 w1 = queue.Dequeue();
                if (liczba < w1.wartosc)
                {
                    if (w1.leftChild == null)
                    {
                        return w1;
                    }
                    else
                    {
                        w1 = w1.leftChild;
                        queue.Enqueue(w1);
                    }
                }
                else
                {
                    if (w1.rightChild == null)
                    {
                        return w1;
                    }
                    else
                    {
                        w1 = w1.rightChild;
                        queue.Enqueue(w1);
                    }
                }
            }
            return null;
        }
    }
}

