using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Transporte : ITransporte 
    {
        string carga = "", tamaño = "";
        int velocidad = 0; 

        public string Carga
        {
            get { return this.carga; }
            set { this.carga= value; }
        }

        public string Tamaño
        {
            get { return this.Tamaño; }
            set { this.tamaño = value; }
        } 
        
        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = value; }
        }

        public Transporte()
        {

        }

        public Transporte(string carga, string tamaño, int velocidad)
        {
            this.carga = carga;
            this.tamaño = tamaño;
            this.velocidad = velocidad;
        }

        public virtual void Cargar()
        {
            Console.WriteLine("El" + this.carga + "esta transportando personas");
        }

        public virtual void Manejar()
        {
            Console.WriteLine("El " + this.carga + "esta siendo manejado por una persona");
        }

        public virtual void Frenar()
        {
            Console.WriteLine("El " + this.carga + "esta frenando");
        }
    }
}
