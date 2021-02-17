using System; //Usando biblioteca System
using System.Collections.Generic; //Usando coleção genérica
using System.Linq; //Transforma em linguagem de maquina
using System.Text;//Ativa recursos de texto
using System.Threading.Tasks; // multiplas linhas de tarefas

namespace Proj_Var //nome do projeto
{
    class Program //nome da classe
    {
        static void Main(string[] args) //metodo principal
        {
            Console.WriteLine("Qual é o seu nome?\n"); 
            var nome = Console.ReadLine(); // o var paranomear variavel e o read para ler a função
            var data = DateTime.Now; //coletar data
            Console.WriteLine($"\n Olá, {nome}, on {data:d} at {data:t}!!!"); //o sifrão aguarda uma variavel
            Console.Write("\n Pressione algo para sair...");
            Console.ReadKey(true); // ler uma tecla = verdadeiro
        }
    }
}
