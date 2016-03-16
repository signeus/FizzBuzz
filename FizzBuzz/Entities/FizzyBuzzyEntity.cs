using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzz.Entities
{
    public class FizzyBuzzy
    {
        public int Clave { get; set; }
        public string Valor { get; set; }

        public FizzyBuzzy(int clave, string valor)
        {
            this.Clave = clave;
            this.Valor = valor;
        }
    }
}