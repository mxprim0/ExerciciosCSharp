using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaMaria = new ContaCorrente();

            contaDaMaria.titular = "Maria";
            contaDaMaria.agencia = 863;
            contaDaMaria.numero = 863452;
            contaDaMaria.saldo = 100;

            Console.WriteLine("Titular da Conta: " + contaDaMaria.titular);
            Console.WriteLine("Agência: " + contaDaMaria.agencia);
            Console.WriteLine("Número da Conta: " + contaDaMaria.numero);
            Console.WriteLine("Saldo da Conta: " + contaDaMaria.saldo);

            contaDaMaria.saldo += 200;
            Console.WriteLine("Saldo Atualizado: " + contaDaMaria.saldo);

            Console.ReadLine();
        }
    }
}
