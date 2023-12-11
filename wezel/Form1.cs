using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wezel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel(1);
            var w2 = new Wezel(2);
            var w3 = new Wezel(3);
            var w4 = new Wezel(4);
            var listaWezlow = new List<Wezel>();
            listaWezlow.Add(w1);
            listaWezlow.Add(w2);
            listaWezlow.Add(w3);
            w1.childs.Add(w2);
            w1.childs.Add(w3);
            w2.childs.Add(w4);
            A(w1);

            comboBox1.Items.AddRange(listaWezlow.ToArray());
        }

        void A(Wezel w)
        {
            foreach (var dziecko in w.childs)
            {
                MessageBox.Show(dziecko.ToString());
                A(dziecko);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel2(1);
            var w2 = new Wezel2(2);
            var w3 = new Wezel2(3);
            var w4 = new Wezel2(4);
            var w5 = new Wezel2(5);
            var w6 = new Wezel2(6);
            var w7 = new Wezel2(7);

            //w1.neighbours.Add(w2);
            //w2.neighbours.Add(w1);
            w1.Add(w2);
            //w1.neighbours.Add(w3);
            //w3.neighbours.Add(w1);
            w1.Add(w3);
            //w2.neighbours.Add(w4);
            //w4.neighbours.Add(w2);
            //w2.neighbours.Add(w5);
            //w5.neighbours.Add(w2);
            w2.Add(w4);
            w2.Add(w5);
            //w3.neighbours.Add(w6);
            //w6.neighbours.Add(w3);
            //w3.neighbours.Add(w7);
            //w7.neighbours.Add(w3);
            w3.Add(w6);
            w3.Add(w7);
            //w7.neighbours.Add(w4);
            //w4.neighbours.Add(w7);
            w7.Add(w4);

            //ABFS(w1);
            //odwiedzone.Clear();

            DrzewoBinarne tree = new DrzewoBinarne(5);
            var d1 = new Wezel3(3);
            var d2 = new Wezel3(4);
            var d3 = new Wezel3(8);
            var d4 = new Wezel3(7);
            var d5 = new Wezel3(6);
            var d6 = new Wezel3(5);
            var d7 = new Wezel3(6);
            tree.ADD(d1);
            tree.ADD(d2);
            tree.ADD(d3);
            tree.ADD(d4);
            tree.ADD(d5);
            tree.ADD(d6);
            tree.ADD(d7);

            var foundNode = tree.korzen.Znajdz(7);
            var minNode = tree.korzen.ZnajdzMin(tree.korzen);
            var maxNode = tree.korzen.ZnajdzMax(tree.korzen);
            var successorNode = tree.korzen.leftChild.Nastepnik();
            MessageBox.Show(foundNode.ToString());
            MessageBox.Show(minNode.ToString());
            MessageBox.Show(maxNode.ToString());
            MessageBox.Show(successorNode.ToString());
        }

        List<Wezel2> odwiedzone = new List<Wezel2>();
        public void A(Wezel2 w)
        {
            MessageBox.Show(w.ToString());
            odwiedzone.Add(w);

            foreach (var neighbour in w.neighbours)
            {
                if (!odwiedzone.Contains(neighbour))
                {
                    A(neighbour);
                }

            }
        }

        public void ABFS(Wezel2 w)
        {
            Queue<Wezel2> queue = new Queue<Wezel2>();
            queue.Enqueue(w);

            while (queue.Count > 0)
            {
                Wezel2 current = queue.Dequeue();
                MessageBox.Show(current.ToString());
                odwiedzone.Add(current);

                foreach (var neighbour in current.neighbours)
                {
                    if (!odwiedzone.Contains(neighbour) && !queue.Contains(neighbour))
                    {
                        queue.Enqueue(neighbour);
                    }
                }
            }
        }
    }

    public class Wezel
    {
        public int wartosc;
        public List<Wezel> childs = new List<Wezel>();

        public Wezel(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public override string ToString()
        {
            return "Wartość: " + this.wartosc.ToString();
        }
    }

    public class Wezel2
    {
        public int wartosc;
        public List<Wezel2> neighbours = new List<Wezel2>();

        public Wezel2(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public void Add(Wezel2 w)
        {
            this.neighbours.Add(w);
            w.neighbours.Add(this);
        }

        public override string ToString()
        {
            return "Wartość: " + this.wartosc.ToString();
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