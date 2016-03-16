using FizzBuzz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzz.Models
{
    public class FizzBuzzer
    {
        #region variables y listas
        public int Maximo { get; set; }
        private List<FizzyBuzzy> FizzyBuzzyList = new List<FizzyBuzzy>();
        #endregion

        #region Constructor
        public FizzBuzzer()
        {
            Maximo = 100;
            FizzyBuzzyList.Add(new FizzyBuzzy(15, "FizzBuzz"));
            FizzyBuzzyList.Add(new FizzyBuzzy(5, "Buzz"));
            FizzyBuzzyList.Add(new FizzyBuzzy(3, "Fizz"));
        }
        #endregion constructor

        #region FizzBuzz
        /// <summary>
        /// Realiza la ecuación con un máximo entero que introduzca por parámetros.
        /// </summary>
        /// <param name="numberitoMaximo"></param>
        public string FizzBuzzeame(int numberitoMaximo)
        {
            String resultado = String.Empty;
            for (int i = 1; i <= numberitoMaximo; i++)
            {
                resultado += AlgoritmoTopSecretFizzBuzz(i);
            }
            return resultado;
        }
            #region Algoritmo secreto no destapar...
            /// <summary>
            /// Recibe el divisor y te devuelve un resultado según si esta en la lista de valores 
            /// correspondiente al número o si no existe valor devuelve el mismo número.
            /// </summary>
            /// <param name="numeroActual"></param>
            private string AlgoritmoTopSecretFizzBuzz(int numeroActual)
            {
                    foreach (var item in FizzyBuzzyList)
                    {
                        if (numeroActual % item.Clave == 0)
                            return item.Valor + ", ";
                    }
                    return numeroActual + ", ";
            }
            #endregion
        #endregion FizzBuzz
    }
}