

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Model
{
    public class ContaBancariaModel
    {
        public int NumeroConta { get; }
        public string Titular { get; set; }
        public double Saldo { get;  set; }

        public ContaBancariaModel(int numeroConta, string titular, double saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;


        }

        public void Depositar(double valor)
        {
            if (valor > 0)
                Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor + 3.50 <= Saldo)
            {
                Saldo -= valor + 3.50;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Titular}, Saldo: $ {Saldo:F2}";
        }
    }
}


