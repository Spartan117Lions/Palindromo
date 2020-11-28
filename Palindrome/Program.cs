using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Es o se puede armar un Palindromo?");
            List<string> palabras = new List<string>();
            palabras.Add("AABBCCDD");
            palabras.Add("ANITA LAVA LA TINA");
            palabras.Add("AAZZYYR");
            palabras.Add("YYEEDT");
            palabras.Add("RAUL");

            var sonPalindromos = EsPalidromo(palabras);
        }


        /// <summary>
        /// Este método retorna una lista de banderas, que define en las posiciones correspondientes
        /// si la palabra es o no palindromo
        /// EJEMPLO
        /// [0] true
        /// [1] true
        /// [2] true
        /// [3] false
        /// [4] false
        /// </summary>
        /// <param name="palabras"></param>
        /// <returns></returns>
        public static List<bool> EsPalidromo(List<string> palabras)
        {
            List<bool> sonPalindromos = new List<bool>();

            //Aquí procesa la data

            return sonPalindromos;
        }
    }
}
