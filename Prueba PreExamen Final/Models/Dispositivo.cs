using Prueba_PreExamen_Final.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_PreExamen_Final.Models
{
     class Dispositivo : Ireparable
    {
        private string marca;
        private string modelo;
        private float pulgada;

        float Ireparable.Precio
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        // CONSTRUCTOR
        public Dispositivo()
        {

        }
        public Dispositivo(string marca, string modelo, float pulgada)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.pulgada = pulgada;
        }
        public Dispositivo(string marca, string modelo)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        // GETS AND SETTERS
        public string getMarca()
        {
            return marca;
        }

        public void setMarca(string Marca)
        {
            if(Marca == "")
            {
                throw new Exception("[ERROR]: NO HA INTRODUCIDO UNA MARCA VALIDA"); 
            }
        }

        public string getModelo()
        {
            return modelo;
        }

        public void setModelo(string Modelo)
        {
            if (Modelo == "")
            {
                throw new Exception("[ERROR]: NO HA INTRODUCIDO UN MODELO VALIDO");
            }
        }

        public float getPulgada()
        {
            return pulgada;
        }

        public void setPulgada(string Pulgada)
        {
            if (Pulgada == "")
            {
                throw new Exception("[ERROR]: NO HA INTRODUCIDO UNA PULGADA VALIDA");
            }
        }




        // METODOS

        

        public override string ToString()
        {
            return String.Format("marca: {0}, modelo: {1}, pulgadas: {2}", marca,modelo,pulgada);
        }


        public void Reparar(float Precio)
        {
            throw new NotImplementedException();
        }

        public float Precio()
        {
            throw new NotImplementedException();
        }

        
    }
}
