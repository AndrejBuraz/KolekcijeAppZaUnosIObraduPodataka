using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolekcijeAplikacijaZaUnosIObraduPodataka
{
    public partial class Form1 : Form
    {
        List<Vozilo> listaVozila = new List<Vozilo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Vozilo vozilo in listaVozila)
            {
                textBoxIspis.Text = vozilo.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUnos_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo(textBoxMarka.Text, textBoxModel.Text, comboBox1.Text);
            listaVozila.Add(vozilo);
        }

        private void buttonObradi_Click(object sender, EventArgs e)
        {
            foreach(Vozilo vozilo in listaVozila)
            {
                if(vozilo.Vrsta == "Avion")
                {
                    vozilo.VoziPo = "Zrak";
                }
                else if(vozilo.Vrsta == "Automobil")
                {
                    vozilo.VoziPo = "Cesta";
                }
                else if(vozilo.Vrsta == "Brod")
                {
                    vozilo.VoziPo = "Voda";
                }
            }
        }
    }

    class Vozilo
    {
        string marka, model, vrsta, voziPo;


        public Vozilo(string marka, string model, string vrsta)
        {
            this.Marka = marka;
            this.Model = model;
            this.Vrsta = vrsta;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Vrsta { get => vrsta; set => vrsta = value; }
        public string VoziPo { get => voziPo; set => voziPo = value; }

        public override string ToString()
        {
            string ispis = ("Marka: " + this.marka + "; Model: "+this.model+"; Vrsta: "+this.vrsta+"; Vozi po: "+this.voziPo);
            return ispis;
        }
    }


   
}
