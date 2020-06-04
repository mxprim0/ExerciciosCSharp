using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculoPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução Projeto 10 - Cálculo de Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);

                // contadorMes = contadorMes + 1;
                // contadorMes += 1;
                contadorMes++;
            }

            // 0.36% = 0.0036
            // valorInvestido = valorInvestido + valorInvestido * 0.0036;
            // Console.WriteLine("Após 1 mês investido, você terá R$ " + valorInvestido);

            // valorInvestido = valorInvestido + valorInvestido * 0.0036;
            // Console.WriteLine("Após 2 meses investido, você terá R$ " + valorInvestido);

            Console.ReadLine();
        }
    }
}
