using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Transporte transporte = new Transporte();
            Tren tren = new Tren();
            tren.Carga = "Autos";

            
            transporte.Carga = "";
            transporte.Tamaño = "";
            transporte.Velocidad = 123;

            Transporte transporte2 = new Transporte();

            transporte2.Carga = "Comida";
            Console.WriteLine(transporte2.Carga);
           
        }
    }
}
