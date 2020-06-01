using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto: Criando variáveis ponto flutuante.");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5 / 4;
            Console.WriteLine("5 / 4 = " + idade);

            idade = 5 / 4.0;
            Console.WriteLine("5 / 4.0 = " + idade);

            Console.WriteLine("Fim de execução. Por favor tecle Enter para sair.");
            Console.ReadLine();
        }
    }
}
