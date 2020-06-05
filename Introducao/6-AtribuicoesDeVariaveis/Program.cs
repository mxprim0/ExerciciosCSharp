using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução Projeto 6");

            int idade = 10;
            int idadeDanielly = idade;

            idade = 30;

            Console.WriteLine(idade);
            Console.WriteLine(idadeDanielly);

            Console.ReadLine();
        }
    }
}
