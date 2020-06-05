using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução Projeto 4");

            double salario;
            salario = 1200.50;

            // o int é um tipo de variavel que suporta ate 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é um tipo variavel de 64 bits
            long idade;
            idade = 1300000000000000;

            // o short é um tipo de variavel de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;

            // float nao suporta muito bem casas decimais ex: 1.60
            float altura = 1.60f;

            // logo após criar a variável já recomendado atribuir um valor a ela (boa prática)
            Console.ReadLine();
        }
    }
}
