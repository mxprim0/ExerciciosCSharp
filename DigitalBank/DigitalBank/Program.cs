using DigitalBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario joao = new Funcionario(1);

            joao.Nome = "Joao";
            joao.CPF = "123456789-88";
            joao.Salario = 2000;

            Console.WriteLine(joao.Nome);
            Console.WriteLine(joao.GetBonificacao());

            Console.ReadLine();
        }
    }
}
