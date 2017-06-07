using Prueba_PreExamen_Final;
using Prueba_PreExamen_Final.Interfaces;
using Prueba_PreExamen_Final.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_PreExamen_Final
{
    class Program 
    {
        static  ArrayList<Dispositivo> Lista = new ArrayList<Dispositivo>();
        static void Main(string[] args)
        {

            
            Entrada();
            
        }

        public static void Entrada()
        {
            // DECLARACION VARIABLES
            string entrada = " ";   // Variable auxiliar de cadenas de caracteres
            bool esCorrecto = false;    // Control de Validacion de datos
            int accion = 0;

            // ENTRADA
            Console.WriteLine("*** Bienvenido al Taller Cenec ***");
            Console.WriteLine("Que desea hacer: ");
            Console.WriteLine("1 - Añadir");
            Console.WriteLine("2 - Reparar");
            Console.WriteLine("3 - Entregar");
            do
            {
                Console.WriteLine("Introduzca numero de horas trabajadas: ");
                entrada = Console.ReadLine();
                // Validacion por Formato
                esCorrecto = Int32.TryParse(entrada, out accion);
                // Validacion de número positivo
                if (esCorrecto)
                {
                    if (accion <= 0)
                    {
                        //Console.Clear(); - Borra Todo lo que esta escrito en pantalla
                        throw new Exception("ERROR: La accion es incorrecta ");
                        esCorrecto = false;
                    }
                }
                else
                {
                    //Console.Clear();
                    throw new Exception("ERROR: La accion es incorrecta ");
                }
            }
            while (!esCorrecto);
            Option(accion);
        }

        public static void Option(int accion)
        {
            switch(accion)
            {
                case 1:
                    AniadirDispositivo();
                break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }

       

        public static void AniadirDispositivo()
        {
            string entrada = " ";   // Variable auxiliar de cadenas de caracteres
            bool esCorrecto = false;    // Control de Validacion de datos
            int accion = 0;

            
            do
            {
                Console.WriteLine("Que Dispositivo desea aniadir: ");
                Console.WriteLine("1 - Movil");
                Console.WriteLine("2 - PC");
                Console.WriteLine("3 - Tablet");
                Console.WriteLine("4 - Portatil");
                entrada = Console.ReadLine();
                // Validacion por Formato
                esCorrecto = Int32.TryParse(entrada, out accion);
                // Validacion de número positivo
                if (esCorrecto)
                {
                    if (accion <= 0)
                    {
                        //Console.Clear(); - Borra Todo lo que esta escrito en pantalla
                        throw new Exception("ERROR: La accion es incorrecta ");
                        esCorrecto = false;
                    }
                }
                else
                {
                    //Console.Clear();
                    throw new Exception("ERROR: La accion es incorrecta ");
                }
            }
            while (!esCorrecto);

            ElecDispositivo(accion);
        }

        public static void ElecDispositivo(int accion)
        {
            switch (accion)
            {
                case 1:
                    AniadirMovil();
                    break;
                case 2:
                    AniadirPC();
                    break;
                case 3:
                    AniadirTablet();
                    break;
                case 4:
                    AniadirPortatil();
                    break;
            }
        }

        public static void AniadirPC()
        {
            PC PC = new PC();
            string marca, modelo, procesador, piezas, fuente, aux, SO;
            int Gb = 0;

            Console.WriteLine("Marca: ");
            marca = Console.ReadLine();
            PC.setMarca(marca);

            Console.WriteLine("Modelo: ");
            modelo = Console.ReadLine();
            PC.setModelo(modelo);

            Console.WriteLine("Procesador: ");
            procesador = Console.ReadLine();
            PC.setProcesador(procesador);

            Console.WriteLine("Piezas: ");
            piezas = Console.ReadLine();
            PC.setPiezas(piezas);

            Console.WriteLine("Fuente Alimentacion: ");
            fuente = Console.ReadLine();
            PC.setFuenteAliment(fuente);

            Console.WriteLine("RAM: - GB");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out Gb);
            if(Gb == 1)
            {
                PC.setRam(Enum.RAM.GB1);
            }
            else if (Gb == 2)
            {
                PC.setRam(Enum.RAM.GB2);
            }
            else if (Gb == 4)
            {
                PC.setRam(Enum.RAM.GB4);
            }
            else if (Gb == 8)
            {
                PC.setRam(Enum.RAM.GB8);
            }
            else if (Gb == 16)
            {
                PC.setRam(Enum.RAM.GB16);
            }
            else if (Gb == 32)
            {
                PC.setRam(Enum.RAM.GB32);
            }
            Console.WriteLine("SO: ");
            SO = Console.ReadLine();
            if(SO == "window")
            {
                PC.setSO(Enum.SO.Window);
            }
            else if (SO == "ios")
            {
                PC.setSO(Enum.SO.IOS);
            }
            else if (SO == "android")
            {
                PC.setSO(Enum.SO.Android);
            }
            Console.WriteLine("Disposivo: Portatil, Marca: {0}, Modelo: {1}, Procesador: {2}, RAM: {4}, SO: {5}", marca, modelo, procesador, aux, SO);
            
        }

        public static void AniadirPortatil()
        {
            Portatil PC = new Portatil();
            string marca, modelo, procesador, aux, SO;
            float pulgadas;
            int Gb = 0;

            Console.WriteLine("Marca: ");
            marca = Console.ReadLine();
            PC.setMarca(marca);

            Console.WriteLine("Modelo: ");
            modelo = Console.ReadLine();
            PC.setModelo(modelo);

            Console.WriteLine("Procesador: ");
            procesador = Console.ReadLine();
            PC.setProcesador(procesador);

            Console.WriteLine("Pulgadas: ");
            aux = Console.ReadLine();
            Single.TryParse(aux, out pulgadas);
            PC.setPulgada(pulgadas);

            Console.WriteLine("RAM: - GB");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out Gb);
            if (Gb == 1)
            {
                PC.setRam(Enum.RAM.GB1);
            }
            else if (Gb == 2)
            {
                PC.setRam(Enum.RAM.GB2);
            }
            else if (Gb == 4)
            {
                PC.setRam(Enum.RAM.GB4);
            }
            else if (Gb == 8)
            {
                PC.setRam(Enum.RAM.GB8);
            }
            else if (Gb == 16)
            {
                PC.setRam(Enum.RAM.GB16);
            }
            else if (Gb == 32)
            {
                PC.setRam(Enum.RAM.GB32);
            }
            Console.WriteLine("SO: ");
            SO = Console.ReadLine();
            if (SO == "window")
            {
                PC.setSO(Enum.SO.Window);
            }
            else if (SO == "ios")
            {
                PC.setSO(Enum.SO.IOS);
            }
            else if (SO == "android")
            {
                PC.setSO(Enum.SO.Android);
            }

            Console.WriteLine("Disposivo: Portatil, Marca: {0}, Modelo: {1}, Procesador: {2}, Pulgadas: {3}, RAM: {4}, SO: {5}", marca, modelo, procesador, pulgadas, aux, SO);
            
        }

        public static void AniadirMovil()
        {
            Movil movil = new Movil();
            string SO,marca, modelo, aux;
            float pulgadas;
            Console.WriteLine("Marca: ");
            marca = Console.ReadLine();
            movil.setMarca(marca);

            Console.WriteLine("Modelo: ");
            modelo = Console.ReadLine();
            movil.setModelo(modelo);

            Console.WriteLine("Pulgadas: ");
            aux = Console.ReadLine();
            Single.TryParse(aux, out pulgadas);
            movil.setPulgada(pulgadas);

            Console.WriteLine("SO: ");
            SO = Console.ReadLine();
            if (SO == "window")
            {
                movil.setSO(Enum.SO.Window);
            }
            else if (SO == "ios")
            {
                movil.setSO(Enum.SO.IOS);
            }
            else if (SO == "android")
            {
                movil.setSO(Enum.SO.Android);
            }
            Console.WriteLine("Disposivo: Portatil, Marca: {0}, Modelo: {1}, Procesador: {2}, Pulgadas: {3}, SO: {5}", marca, modelo, pulgadas, aux, SO);
        }

        public static void AniadirTablet()
        {
            Tablet tablet = new Tablet();
            string aux, marca, modelo;
            float pulgadas;

            Console.WriteLine("Marca: ");
            marca = Console.ReadLine();
            tablet.setMarca(marca);

            Console.WriteLine("Modelo: ");
            modelo = Console.ReadLine();
            tablet.setModelo(modelo);

            Console.WriteLine("Pulgadas: ");
            aux = Console.ReadLine();
            Single.TryParse(aux, out pulgadas);
            tablet.setPulgada(pulgadas);

            Console.WriteLine("SO: ");
            aux = Console.ReadLine();
            if (aux == "window")
            {
                tablet.setSO(Enum.SO.Window);
            }
            else if (aux == "ios")
            {
                tablet.setSO(Enum.SO.IOS);
            }
            else if (aux == "android")
            {
                tablet.setSO(Enum.SO.Android);
            }
            Console.WriteLine("Disposivo: Portatil, Marca: {0}, Modelo: {1}, Pulgadas: {3}, SO: {5}", marca, modelo, pulgadas, aux);
        }
        }   

}
