// using _06_Bank;

namespace _06_Bank
{
    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular { get; set; }

        public int Agencia { get; set }
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
        
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
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
 