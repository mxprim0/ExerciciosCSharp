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

            Funcionario joao = new Funcionario(2000, "123456789-88");
            joao.Nome = "Joao";

            joao.AumentarSalario();
            Console.WriteLine("Novo salário do João: " + joao.Salario);

            Console.WriteLine(Funcionario.TotalDefuncionarios);

            gerenciador.Registrar(joao);

            Diretor maria = new Diretor(5000, "987654321-99");
            maria.Nome = "Maria";

            maria.AumentarSalario();
            Console.WriteLine("Novo salário do Maria: " + maria.Salario);

            Console.WriteLine(Funcionario.TotalDefuncionarios);

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
