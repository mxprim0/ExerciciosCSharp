using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cliente maria = new Cliente();

            // maria.nome = "Maria";
            // maria.profissao = "Dev DotNet";
            // maria.cpf = "123.456.789.11";

            ContaCorrente conta = new ContaCorrente();

            // conta.titular = maria;
            conta.titular = new Cliente();
            conta.titular.nome = "Maria Costa";
            conta.titular.cpf = "123.456.789.11";
            conta.titular.profissao = "Dev DotNet";
            
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            // Console.WriteLine(maria.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
