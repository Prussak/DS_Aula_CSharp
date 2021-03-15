using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesMetros
{
    class Program
    {
        static void Main(string[] args)
        {

            double pes;
            double metros;

            Console.WriteLine("Digite o valor em pés:");
            pes = double.Parse(Console.ReadLine());

            metros = 0.3048 * pes;



        Console.WriteLine("O valor em metros é de " + metros);
            Console.ReadKey();


        }
    }
}
