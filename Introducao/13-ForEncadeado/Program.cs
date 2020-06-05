using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução Projeto 13 - For");

            // Escrevendo asteriscos com Breack
            for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();
            }

            // Forma diferente de fazer asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= 10; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
