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
            palabras.Add("AaZzYMMi");

            var sonPalindromos = EsPalidromo(palabras);

            for (int i = 0; i < sonPalindromos.Count; i++)
            {
                Console.WriteLine(palabras[i] +" - "+ sonPalindromos[i]);
            }
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

            for (int i = 0; i < palabras.Count; i++)
            {
                string frase = palabras[i].Replace(" ", String.Empty);
                Console.WriteLine(frase);
                sonPalindromos.Add(verify(frase));
            }

            return sonPalindromos;
        }

        // ======================================================================================================
        // Comparar 2 arreglos de Chars sin importar la posición
        // Comparar si todos tiene una cantidad par de letras
        // Puede quedar una sola en cantidad impar

        /*
         * 1. Debo crear un arreglo de caracteres de la frase sin espacios
         * 2. En un nuevo rreglo guardar la cantidad de veces que se repite una letra
         * 3. Después de contarla, quitarla del arreglo para no volver a contar los mismos
         * 4. Verificar en el arreglo de veces repetidas puede haber como maximo una cantidad impar.
         */
        public static bool verify(string frase)
        {
            bool oso = false;

            // Code
            char[] charArray = frase.ToCharArray(); 
            char[] charArrayTemp = frase.ToCharArray();
            List<int> numChars = new List<int>();
            

            for (int i = 0; i < charArray.Length; i++)
            {
                if (!charArrayTemp[i].Equals(' '))
                {
                    int repet = 0;
                    for (int j = i; j < charArray.Length; j++)
                    {
                        if (charArray[i].Equals(charArray[j]))
                        {
                            charArrayTemp[j] = ' ';
                            repet++;
                        }
                    }
                    //Console.WriteLine(repet);
                    numChars.Add(repet);
                }
            }
            // Cantidad de impares
            int cantImpares = 0;
            for (int i = 0; i < numChars.Count; i++)
            {
                if (numChars[i]%2==1)
                {
                    cantImpares++;
                }
            }
            Console.WriteLine("Impares: " + cantImpares);
            if (cantImpares <= 1)
                oso = true;

            return oso;
        }


    }
}
