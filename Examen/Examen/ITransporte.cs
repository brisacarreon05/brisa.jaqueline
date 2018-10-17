using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    interface ITransporte
    {
        string Carga { get; set;  }

        void Cargar();
        void Frenar();
        void Manejar(); 
    }
}
