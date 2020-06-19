using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Funcionarios
{
    public class Funcionario
    {
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        // 3 - gerente de conta corrente
        // 4 - ...
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        //public double ObterBonificacao() Quando encontramos "obter" trocamos pelo Get
        {
            return Salario * 0.10;
        }
    }
}
