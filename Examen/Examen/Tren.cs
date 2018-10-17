using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Tren:Transporte
    {
        override public void Manejar()
        {
            base.Manejar();
            Console.WriteLine("El tren maneja una carga de " + this.Carga + "en la noche");
        }
    }
}
