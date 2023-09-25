using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio1.Model;
using Exercicio1;

namespace Exercicio1.Services
{
    internal class DepositoService
    {
        private SQLiteDB db;

        public DepositoService(SQLiteDB sqliteDB)
        {
            db = sqliteDB;
        }

        public bool RealizarDeposito(int numeroConta, double valor)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
            SQLiteDB db = new SQLiteDB(dbPath);
            // Verifique se a conta com o número especificado existe no banco de dados
            ContaBancariaModel conta = db.ObterContaPorNumero(numeroConta);

            if (conta != null)
            {
                // Atualize a conta no banco de dados (se necessário)
                db.AtualizarSaldo(numeroConta,conta.Saldo + valor);

                // Retorna true para indicar que o depósito foi bem-sucedido
                return true;
            }

            // Retorna false se a conta não existir
            return false;
        }

    }
}
