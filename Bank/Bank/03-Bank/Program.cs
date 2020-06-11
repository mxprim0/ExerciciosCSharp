using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // a palavra "new" cria uma variavel de referencia para o objeto
            ContaCorrente contaDaMaria = new ContaCorrente();
            contaDaMaria.titular = "Maria";
            contaDaMaria.agencia = 863;
            contaDaMaria.numero = 863452;

            ContaCorrente contaDaMariaJose = new ContaCorrente();
            contaDaMaria.titular = "Maria Jose";
            contaDaMaria.agencia = 863;
            contaDaMaria.numero = 863452;

            Console.WriteLine(contaDaMaria = contaDaMariaJose);

            // contaDaMaria = contaDaMariaJose;
            // Console.WriteLine(contaDaMaria == contaDaMariaJose);

            Console.ReadLine();
        }
    }
}
