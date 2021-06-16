using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Repartidor : Persona
    {
        public int Comision { get; set; }


        public int CalcularComision()
        {
            return Comision;
        }

    }
}
