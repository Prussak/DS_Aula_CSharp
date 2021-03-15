using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTerreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento;
            Console.WriteLine("Digite a largura do terreno:");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do terreno");
            comprimento = double.Parse(Console.ReadLine());
            double area = largura * comprimento;
            Console.WriteLine("A área é de = " + area);
            Console.ReadKey();

        }

    }
}
