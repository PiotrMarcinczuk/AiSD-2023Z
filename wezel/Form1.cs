using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DrzewoBinarne tree = new DrzewoBinarne(4);
            var d1 = new Wezel3(4);
            var d2 = new Wezel3(1);
            var d3 = new Wezel3(6);
            tree.ADD(d1);
            tree.ADD(d2);
            tree.ADD(d3);
            MessageBox.Show(tree.ToString());
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

            while(queue.Count > 0)
            {
                Wezel3 parent = queue.Dequeue();
                if(w.wartosc < parent.wartosc)
                {
                    w.rodzic = parent;
                    parent.leftChild = w;
                    queue.Enqueue(w);
                    this.liczbaWezlow++;
                }
                else
                {
                    w.rodzic = parent;
                    parent.rightChild = w;
                    queue.Enqueue(w);
                    this.liczbaWezlow++;
                }
            }
        }
    }
}