using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Exercicio1;
using Exercicio1.Model;

public class SQLiteDB
{
    private string connectionString;

    public SQLiteDB(string dbPath)
    {
        connectionString = $"Data Source={dbPath};Version=3;";
    }

    public void CriarBancoDeDados()
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Crie a tabela Contas se ela não existir
            string criarTabelaContas = "CREATE TABLE IF NOT EXISTS Contas (Conta INT PRIMARY KEY, Titular TEXT, Saldo REAL)";
            using (SQLiteCommand cmd = new SQLiteCommand(criarTabelaContas, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
    public void IncluirConta(int numeroConta, string titular, double saldo)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Insira os valores na tabela Contas
            string inserirConta = "INSERT INTO Contas (Conta, Titular, Saldo) VALUES (@Conta, @Titular, @Saldo)";
            using (SQLiteCommand cmd = new SQLiteCommand(inserirConta, connection))
            {
                cmd.Parameters.AddWithValue("@Conta", numeroConta);
                cmd.Parameters.AddWithValue("@Titular", titular);
                cmd.Parameters.AddWithValue("@Saldo", saldo);

                cmd.ExecuteNonQuery();
            }
        }
    }
    public void AtualizarSaldo(int numeroConta, double novoSaldo)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Atualize o saldo na tabela Contas
            string atualizarSaldo = "UPDATE Contas SET Saldo = @NovoSaldo WHERE Conta = @NumeroConta";
            using (SQLiteCommand cmd = new SQLiteCommand(atualizarSaldo, connection))
            {
                cmd.Parameters.AddWithValue("@NumeroConta", numeroConta);
                cmd.Parameters.AddWithValue("@NovoSaldo", novoSaldo);

                cmd.ExecuteNonQuery();
            }
        }
    }
    public void ExcluirConta(int numeroConta)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Exclua a conta da tabela Contas
            string excluirConta = "DELETE FROM Contas WHERE Conta = @NumeroConta";
            using (SQLiteCommand cmd = new SQLiteCommand(excluirConta, connection))
            {
                cmd.Parameters.AddWithValue("@NumeroConta", numeroConta);

                cmd.ExecuteNonQuery();
            }
        }
    }
    public void MostrarDadosContas(DataGridView dataGridView)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Recupere os registros da tabela Contas
            string selecionarRegistros = "SELECT * FROM Contas";
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selecionarRegistros, connection))
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Contas");

                // Exiba os registros em um DataGridView (se você tiver um DataGridView no seu formulário)
                dataGridView.DataSource = dataSet.Tables["Contas"];
            }
        }
    }
    public ContaBancariaModel ObterContaPorNumero(int numeroConta)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Execute uma consulta SQL para obter a conta pelo número da conta
            string query = "SELECT Conta, Titular, Saldo FROM Contas WHERE Conta = @NumeroConta";
            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@NumeroConta", numeroConta);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Encontrou a conta com o número especificado
                        int numeroContaRetornado = reader.GetInt32(0);
                        string titular = reader.GetString(1);
                        double saldo = reader.GetDouble(2);

                        // Crie uma instância de ContaBancaria e retorne
                        return new ContaBancariaModel(numeroContaRetornado, titular, saldo);
                    }
                }
            }
        }

        // Retorna null se a conta não for encontrada
        return null;
    }
    public List<ContaBancariaModel> ObterContas()
    {
        List<ContaBancariaModel> contas = new List<ContaBancariaModel>();

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Execute uma consulta SQL para obter as contas do banco de dados
            string query = "SELECT * FROM Contas";
            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int numeroConta = reader.GetInt32(0); // Índice 0 representa a coluna "Conta"
                        string titular = reader.GetString(1); // Índice 1 representa a coluna "Titular"
                        double saldo = reader.GetDouble(2); // Índice 2 representa a coluna "Saldo"

                        // Crie uma instância de ContaBancaria e adicione à lista de contas
                        ContaBancariaModel conta = new ContaBancariaModel(numeroConta, titular, saldo);
                        contas.Add(conta);
                    }
                }
            }
        }

        return contas;
    }

    public void EditarConta(int numeroConta, string novoNome)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Atualize o saldo na tabela Contas
            string atualizarSaldo = "UPDATE Contas SET Titular = @NovoNome WHERE Conta = @NumeroConta";
            using (SQLiteCommand cmd = new SQLiteCommand(atualizarSaldo, connection))
            {
                cmd.Parameters.AddWithValue("@NumeroConta", numeroConta);
                cmd.Parameters.AddWithValue("@NovoNome", novoNome);

                cmd.ExecuteNonQuery();
            }
        }
    }

    // Adicione métodos para inserir, atualizar, recuperar dados, etc.
}
