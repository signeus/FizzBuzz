using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzz.Models
{

        public class Persona
    {
        public string Saludo { get; set; }
        public string Nombre { get; set; }

        public Persona()
        {
            Saludo = "Buenas ";
            Nombre = string.Empty;
        }
    }
}