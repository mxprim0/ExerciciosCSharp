﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoJoao = new ContaCorrente();

            contaDoJoao.titular = "João";

            Console.WriteLine(contaDoJoao.saldo);

            bool resultadoSaque = contaDoJoao.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoJoao.saldo);
            
            contaDoJoao.Depositar(500);
            Console.WriteLine(contaDoJoao.saldo);

            Console.ReadLine();
        }
    }
}
