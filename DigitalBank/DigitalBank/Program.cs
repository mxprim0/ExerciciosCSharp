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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario joao = new Funcionario();
            joao.Nome = "Joao";
            joao.CPF = "123456789-88";
            joao.Salario = 2000;

            gerenciador.Registrar(joao);

            Diretor maria = new Diretor();
            maria.Nome = "Maria";
            maria.CPF = "987654321-99";
            maria.Salario = 5000;

            gerenciador.Registrar(maria);

            Console.WriteLine(joao.Nome);
            Console.WriteLine(joao.GetBonificacao());

            Console.WriteLine(maria.Nome);
            Console.WriteLine(maria.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
