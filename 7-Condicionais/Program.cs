using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução Projeto 7 - Condicionais");

            int idadeMaria = 15;
            int quantidadePessoas = 2;

            if (idadeMaria >= 18)
            {
                Console.WriteLine("Possui mais de 18 anos, pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Menor de idade, mas está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("Menor de idade, não pode entrar.");
                }

            }

            Console.ReadLine();
        }
    }
}
