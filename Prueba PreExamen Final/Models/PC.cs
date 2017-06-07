using Prueba_PreExamen_Final.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_PreExamen_Final.Models
{
    class PC : Dispositivo
    {
        private string procesador;
        private string piezas;
        private string fuenteAliment;
        private RAM ram { get; set; }
        private SO so { get; set; }

        public PC(string procesador, string piezas, string fuenteAliment, string marca, string modelo) : base(marca, modelo)
        {
            this.procesador = procesador;
            this.piezas = piezas;
            this.fuenteAliment = fuenteAliment;
        }

        public PC()
        {
        }

        // GETS AND SETTERS
        public string getProcesador()
        {
            return procesador;
        }

        public void setProcesador(string Procesador)
        {
            if(Procesador == "")
            {
                throw new Exception("[ERROR]: NO HA INTRODUCIDO UN PROCESADOR VALIDO");
            }
        }

        public string getPiezas()
        {
            return piezas;
        }

        public void setPiezas(string Piezas)
        {
            if (Piezas == "")
            {
                throw new Exception("[ERROR]: NO HA INTRODUCIDO UN PROCESADOR VALIDO");
            }
        }

        public string getFuenteAliment()
        {
            return fuenteAliment;
        }

        public void setFuenteAliment(string Fuente)
        {
            if (Fuente == "")
            {
                throw new Exception("[ERROR]: NO HA INTRODUCIDO UN PROCESADOR VALIDO");
            }
        }

        public RAM getRam()
        {
            return ram;
        }

        public void setRam(RAM RAM)
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
