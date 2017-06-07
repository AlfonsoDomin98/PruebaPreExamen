using Prueba_PreExamen_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_PreExamen_Final.Interfaces
{
    interface Ireparable
    {
         float Precio { get; set; }
        void Reparar(float Precio);
        
    }
}
