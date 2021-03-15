using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QuadradoDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o valor de A:");
           int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
           int B = int.Parse(Console.ReadLine());

            double divisao = A / B;
            double quadrado = Math.Pow(divisao, 2);

            Console.WriteLine("O resultado do quadrado da divisão é = " + quadrado);
            Console.ReadKey();
        }
    }
}
