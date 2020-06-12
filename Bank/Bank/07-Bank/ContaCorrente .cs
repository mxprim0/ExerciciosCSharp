// using _07_Bank;

namespace _07_Bank
{
    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                value
                if (value < 0)
                {
                    return;
                }

                _agencia = value;
                // value só funciona dentro do método set
            }
        }
        public int Numero { get; set }
        
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                value
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
                // value só funciona dentro do método set
            }
        }

        // Construtor do Objeto ContaCorrente::::
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }
        
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

        /* Exemplo do código acima sem a simplificação:::
         * 
         * public bool Transferir( double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
         */
    }
}
 