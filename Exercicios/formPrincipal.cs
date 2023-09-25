using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercicio1;
using Exercicio1.Services;

namespace Exercicio1
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            formCriarConta formCriarConta = new formCriarConta();
            formCriarConta.ShowDialog();
        }

        private void btnMostrarContas_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
            SQLiteDB db = new SQLiteDB(dbPath);
            db.MostrarDadosContas(dataGridView1);

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            frmSacar frmSacar = new frmSacar();
            frmSacar.ShowDialog();

            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
            SQLiteDB db = new SQLiteDB(dbPath);
            db.MostrarDadosContas(dataGridView1);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            formDepositar formDepositar = new formDepositar();
            formDepositar.ShowDialog();

            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
            SQLiteDB db = new SQLiteDB(dbPath);
            db.MostrarDadosContas(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                // Obtém os dados da linha selecionada
                int numeroConta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Conta"].Value);
                string titular = dataGridView1.Rows[e.RowIndex].Cells["Titular"].Value.ToString();
                double saldo = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Saldo"].Value);

                // Abre o formulário de edição (frmEditar) e passa os dados da linha
                formEditar formEditar = new formEditar(numeroConta, titular, saldo);
                formEditar.ShowDialog();

                string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContaBancaria.db");
                SQLiteDB db = new SQLiteDB(dbPath);
                db.MostrarDadosContas(dataGridView1);
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                // Defina o texto que deseja exibir nos botões
                e.Value = "Editar";
            }
        }
    }

}
