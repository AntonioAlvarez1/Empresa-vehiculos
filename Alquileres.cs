using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_vehiculos
{
    internal class Alquileres
    {
        public string Nit { get; set; }
        public string placa { get; set; }
        public DateTime fechaAlquiler { get; set; }
        public DateTime fechaDevolucion { get; set; }
        public int kilometros { get; set;}

    }
}
