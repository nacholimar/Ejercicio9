using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 2, 5, 4, 6, 7, 8, 8, 8 };

            int valor = myArray[0];
            int rep = 1;
            int maxRep = 1;
            int number = 0;

            for (int item = 1; item < myArray.Length; item++)
            {
                if (myArray[item] == valor)
                {
                    rep++;
                }
                else
                {
                    rep = 1;
                }

                if (rep > maxRep)
                {
                    maxRep = rep;
                    number = myArray[item];
                }
                valor = myArray[item];
            }
            Console.WriteLine("Longest: " + maxRep);
            Console.WriteLine("Number: " + number);
            Console.ReadLine();
        }
    }
}
