using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercicio1.Model;
using Exercicio1;
using Exercicio1.Services;

namespace Exercicio1
{
    public partial class frmSacar : Form
    {
        private SaqueService saqueService;
        public frmSacar()
        {
            InitializeComponent();
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
            saqueService = new SaqueService(new SQLiteDB(dbPath));
            CarregarContas();
        }

        private void CarregarContas()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
            SQLiteDB db = new SQLiteDB(dbPath);

            List<ContaBancariaModel> contas = db.ObterContas();

            // Limpe o ComboBox
            cmbContas.Items.Clear();

            // Adicione as contas ao ComboBox no formato "numeroConta - titular"
            foreach (var conta in contas)
            {
                cmbContas.Items.Add($"{conta.NumeroConta} - {conta.Titular}");
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
            SQLiteDB db = new SQLiteDB(dbPath);
            string selectedText = cmbContas.SelectedItem.ToString();

            // Divida o texto usando o caractere '-' como separador
            string[] parts = selectedText.Split('-');
            if (parts.Length == 2)
            {
                // A primeira parte (parts[0]) contém o número da conta como texto
                string numeroContaText = parts[0].Trim();

                // Tente converter o número da conta em um valor inteiro
                if (int.TryParse(numeroContaText, out int numeroConta))
                {
                    var valor = Convert.ToDouble(txtValor.Text);

                    // Chame o serviço para realizar o depósito
                    bool sucesso = saqueService.RealizarSaque(numeroConta, valor);

                    if (sucesso)
                    {
                        // Realizado com sucesso
                        MessageBox.Show("Depósito realizado com sucesso!");

                        // Feche o formDeposito
                        this.Close();
                    }
                    else
                    {
                        // Trate o erro, se necessário
                        MessageBox.Show("Falha ao realizar o depósito.");
                    }
                }
            }
        }
    }
}

