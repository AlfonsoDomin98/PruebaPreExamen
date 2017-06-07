using Prueba_PreExamen_Final.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_PreExamen_Final.Models
{
    class Tablet : Dispositivo
    {
        private SO so;

        public Tablet(string marca, string modelo, float pulgada) : base(marca, modelo, pulgada)
        {

        }

        public Tablet()
        {
        }

        public SO getSO()
        {
            return so;
        }

        public void setSO(SO So)
        {

        }

       
    }
}
