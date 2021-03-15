using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Clear();
            Console.WriteLine("\n\tDigite um número:");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("\nO número é par");
            }
            else
            {
                Console.WriteLine("\nO número é impar");
            }
            Console.ReadKey();
        }
    }
    }

