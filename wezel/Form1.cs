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
        
}
