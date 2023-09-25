using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio1.Model;

namespace Exercicio1.Controllers
{
    public class ContaController
    {
        private ContaBancariaModel conta;

        public void CriarConta(int numeroConta, string titular,double saldo)
        {
            conta = new ContaBancariaModel(numeroConta, titular, saldo);
        }

        public void Depositar(double valor)
        {
            if (conta != null)
                conta.Depositar(valor);
        }

        public bool Sacar(double valor)
        {
            if (conta != null)
                return conta.Sacar(valor);
            return false;
        }

        public string ObterDadosConta()
        {
            if (conta != null)
                return conta.ToString();
            return "Conta não criada.";
        }
    }
}
