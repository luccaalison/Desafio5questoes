using Exercicio1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Services
{
    internal class SaqueService
    {
        
            private SQLiteDB db;

            public SaqueService(SQLiteDB sqliteDB)
            {
                db = sqliteDB;
            }

            public bool RealizarSaque(int numeroConta, double valor)
            {
                string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
                SQLiteDB db = new SQLiteDB(dbPath);
                // Verifique se a conta com o número especificado existe no banco de dados
                ContaBancariaModel conta = db.ObterContaPorNumero(numeroConta);

                if (conta != null)
                {
                var taxa = 3.50;
                conta.Saldo -= valor + taxa;
                    if (conta.Saldo < -3.5){
                        MessageBox.Show("Falha ao realizar o Saque você não possui saldo o suficiente.");
                    }
                    else
                    {// Atualize a conta no banco de dados (se necessário)
                        db.AtualizarSaldo(numeroConta, conta.Saldo);

                        // Retorna true para indicar que o depósito foi bem-sucedido
                        return true;
                    }
                    
                }

                // Retorna false se a conta não existir
                return false;
            }

        
    }
}
