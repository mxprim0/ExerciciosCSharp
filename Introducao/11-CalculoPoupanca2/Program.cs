using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculoPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do Projeto 11 - Cálculo de Poupança Parte 2");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
