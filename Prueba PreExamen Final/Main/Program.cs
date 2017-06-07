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
    class Program : ArrayList
    {
        public static Dispositivo elemento  = new Dispositivo();
        public static ArrayList<Dispositivo> Lista  = new ArrayList<Dispositivo>();
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

            Console.WriteLine("Que Dispositivo desea aniadir: ");
            Console.WriteLine("1 - Movil");
            Console.WriteLine("2 - PC");
            Console.WriteLine("3 - Tablet");
            Console.WriteLine("4 - Portatil");
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

                    break;
            }
        }

        public static void AniadirPC()
        {
            PC PC = new PC();
            string aux = "";
            int Gb = 0;

            Console.WriteLine("Procesador: ");
            aux = Console.ReadLine();
            PC.setProcesador(aux);
            Console.WriteLine("Piezas: ");
            aux = Console.ReadLine();
            PC.setPiezas(aux);
            Console.WriteLine("Fuente Alimentacion: ");
            aux = Console.ReadLine();
            PC.setFuenteAliment(aux);
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
            aux = Console.ReadLine();
            if(aux == "window")
            {
                PC.setSO(Enum.SO.Window);
            }
            else if (aux == "ios")
            {
                PC.setSO(Enum.SO.IOS);
            }
            else if (aux == "android")
            {
                PC.setSO(Enum.SO.Android);
            }
        }
        
        public static void AniadirMovil()
        {
            Movil movil = new Movil();
            string aux = "";
            Console.WriteLine("SO: ");
            aux = Console.ReadLine();
            if (aux == "window")
            {
                movil.setSO(Enum.SO.Window);
            }
            else if (aux == "ios")
            {
                movil.setSO(Enum.SO.IOS);
            }
            else if (aux == "android")
            {
                movil.setSO(Enum.SO.Android);
            }
        }

        public static void AniadirTablet()
        {
            Tablet tablet = new Tablet();
            string aux = "";
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
        }
        }   

}
