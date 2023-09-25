using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class formEditar : Form
    {
        private int numeroConta;
        private string titular;
        private double saldo;

        public formEditar(int numeroConta, string titular, double saldo)
        {
            InitializeComponent();

            // Configure os campos do formulário com os parâmetros recebidos
            this.numeroConta = numeroConta;
            this.titular = titular;
            this.saldo = saldo;

            // Preencha os campos do formulário com os dados
            txtNumConta.Text = numeroConta.ToString();
            txtTitular.Text = titular;
            txtSaldo.Text = saldo.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var numeroConta = Convert.ToInt32(txtNumConta.Text);
            var titular = txtTitular.Text;
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
            SQLiteDB db = new SQLiteDB(dbPath);
            db.EditarConta(numeroConta, titular);

            MessageBox.Show("Conta Editada com sucesso!");

            // Feche o formDeposito
            this.Close();

        }
    }
}
