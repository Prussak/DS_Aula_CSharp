using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votos_sindicato
{
    class Program
    {
        static void Main(string[] args)
        {

            int soma;
            double porcentA, porcentB, porcentC, porcentNulo, porcentBranco;
            int A, B, C, branco, nulos;

            Console.WriteLine("Digite o numero de votos do candidato A:");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos do candidato B:");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos do candidato C:");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos em Branco:");
            branco = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos Nulos:");
            nulos = int.Parse(Console.ReadLine());


            soma = A + B + C + branco + nulos;
            porcentA = (A * 100) / soma;
            porcentB = (B * 100) / soma;
            porcentC = (C * 100) / soma;
            porcentNulo = (nulos * 100) / soma;
            porcentBranco = (branco * 100) / soma;

            Console.WriteLine("O valor em porcentagem dos votos é de: ");
            Console.WriteLine("Candidato A: " + porcentA + "%");
            Console.WriteLine("Candidato B: " + porcentB + "%");
            Console.WriteLine("Candidato C: " + porcentC + "%");
            Console.WriteLine("Em Branco: " + porcentBranco + "%");
            Console.WriteLine("Nulos: " + porcentNulo + "%");
            Console.WriteLine("Total de votos: " + soma);

            Console.ReadKey();

        }
    }
}
