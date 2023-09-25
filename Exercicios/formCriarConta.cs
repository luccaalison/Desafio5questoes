using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercicio1.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicio1
{
    public partial class formCriarConta : Form
    {
        private ContaController controller = new ContaController();
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public formCriarConta()
        {
            InitializeComponent();
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumeroConta.Text) && !string.IsNullOrEmpty(txtTitular.Text))
            {
                int numeroConta = int.Parse(txtNumeroConta.Text);
                string titular = txtTitular.Text;
                double saldo = 0.0;

                if (checkBox1.Checked && !string.IsNullOrEmpty(txtSaldo.Text))
                {
                    saldo = Convert.ToDouble(txtSaldo.Text);
                }

                string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
                SQLiteDB db = new SQLiteDB(dbPath);
                db.CriarBancoDeDados();

                db.IncluirConta(numeroConta, titular, saldo);
                MessageBox.Show("Conta criada com sucesso!");
                DialogResult = DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Preencha os campos obrigatórios (Número da Conta e Titular).");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Verifique se o CheckBox está marcado (checked)
            if (checkBox1.Checked)
            {
                // Habilitar o TextBox
                txtSaldo.Enabled = true;
            }
            else
            {
                // Desabilitar o TextBox
                txtSaldo.Enabled = false;
            }
        }
    }

}
