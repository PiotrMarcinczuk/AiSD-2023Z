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
            foreach(var dziecko in w.childs)
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
            A(w1);
        }

        List<Wezel2> odwiedzone = new List<Wezel2>();
        public void A(Wezel2 w)
        {
            
            odwiedzone.Clear();

            foreach (var neighbour in w.neighbours)
            {
                MessageBox.Show(neighbour.ToString());
                if (odwiedzone.Contains(neighbour))
                {
                    odwiedzone.Add(neighbour);
                    A(neighbour);
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
        
}
