using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_LFVV_1244416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int suma = 0;
            do
            {
                try
                {
                    if(x % 2 == 0)
                    {
                        suma += x;
                    }
                    x++;

                }
                catch
                {
                    x++;
                }

            }while (x <=1000);
            Console.WriteLine("La suma de todos los numeros pares de 2 al 1000 es: " + suma);
            Console.ReadKey();
        }
    }
}
