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
        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }

        public double GetBonificacao()
        //public double ObterBonificacao() Quando encontramos "obter" trocamos pelo Get
        {
            if (_tipo == 1)
                return Salario;

            return Salario * 0.10;
        }
    }
}
