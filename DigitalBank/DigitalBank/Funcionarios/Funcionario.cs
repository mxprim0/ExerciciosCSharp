using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDefuncionarios { get; private set; }

        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        // 3 - gerente de conta corrente
        // 4 - ...
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDefuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario * 1.1;
            Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        //public double ObterBonificacao() Quando encontramos "obter" trocamos pelo Get
        {
            return Salario * 0.10;
        }
    }
}
