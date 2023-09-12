using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnzoAnte.CAI.Ej01
{
    internal class Ejercicio01Model
    {
        public string DocumentoIngresado { get; set; }
        public string NombreIngresado { get; set; }
        public string ApellidoIngresado { get; set; }
        public string FechaNacimientoIngresado { get; set; }

        public string Validar()
        {
            return "Ok";
        }
    }
}
