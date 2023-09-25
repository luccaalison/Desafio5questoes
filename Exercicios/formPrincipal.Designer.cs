namespace Exercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnCriarConta = new Button();
            btnSacar = new Button();
            btnDepositar = new Button();
            btnMostrarContas = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            btnEditar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCriarConta
            // 
            btnCriarConta.Location = new Point(29, 12);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(94, 29);
            btnCriarConta.TabIndex = 0;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = true;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(157, 12);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(94, 29);
            btnSacar.TabIndex = 1;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(277, 12);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(94, 29);
            btnDepositar.TabIndex = 2;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnMostrarContas
            // 
            btnMostrarContas.Location = new Point(391, 12);
            btnMostrarContas.Name = "btnMostrarContas";
            btnMostrarContas.Size = new Size(94, 29);
            btnMostrarContas.TabIndex = 3;
            btnMostrarContas.Text = "Mostrar Contas";
            btnMostrarContas.UseVisualStyleBackColor = true;
            btnMostrarContas.Click += btnMostrarContas_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnEditar });
            dataGridView1.Location = new Point(29, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(574, 188);
            dataGridView1.TabIndex = 5;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.DataPropertyName = "Editar";
            btnEditar.HeaderText = "Ação";
            btnEditar.MinimumWidth = 6;
            btnEditar.Name = "btnEditar";
            btnEditar.Text = "Editar";
            btnEditar.ToolTipText = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 125;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnMostrarContas);
            Controls.Add(btnDepositar);
            Controls.Add(btnSacar);
            Controls.Add(btnCriarConta);
            Name = "FormPrincipal";
            Text = "formPrincipal";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCriarConta;
        private Button btnSacar;
        private Button btnDepositar;
        private Button btnMostrarContas;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn btnEditar;
    }
}