using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução Projeto 8 - Condicionais 2");

            int idadeMaria = 15;
            // int quantidadePessoas = 2;
            // bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = true;

            if (idadeMaria >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                    Console.WriteLine("Não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
