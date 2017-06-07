using Prueba_PreExamen_Final.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_PreExamen_Final.Models
{
    class Movil : Dispositivo
    {
        private SO so;

        public Movil(string marca, string modelo, float pulgada) : base(marca, modelo, pulgada)
        {

        }

        public Movil() { }

        public SO getSO()
        {
            return so;
        }

        public void setSO(SO So)
        {

        }
    }
}
