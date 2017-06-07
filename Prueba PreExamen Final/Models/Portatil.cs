using Prueba_PreExamen_Final.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_PreExamen_Final.Models
{
    class Portatil  : Dispositivo
    {

        private string Procesador;
        private RAM ram;
        private SO so;

        public Portatil(string Procesador, string marca, string modelo, float pulgada) : base(marca, modelo, pulgada)
        {
            this.Procesador = Procesador;
        }

        // GETS AND SETTERS
        public string getProcesador()
        {
            return Procesador;
        }

        public void setProcesador(string pros)
        {
            if(pros == "")
            {
                throw new Exception("[ERROR]: NO HA INTRODUCIDO UN PROCESADOR CORRECTO");
            }
        }

        public RAM getRam()
        {
            return ram;
        }

        public void setRam(RAM RAM)
        {
            if(RAM == null)
            {
                throw new Exception("[ERROR]: NO HA INTRODUCIDO UNA RAM CORRECTA");
            }
        }

        public override void Precio()
        {
            throw new NotImplementedException();
        }
    }
}
