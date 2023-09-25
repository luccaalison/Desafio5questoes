namespace Exercicio1
{
    partial class formEditar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumConta = new TextBox();
            txtTitular = new TextBox();
            txtSaldo = new TextBox();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 28);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero Da Conta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Titular:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 119);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Saldo:";
            // 
            // txtNumConta
            // 
            txtNumConta.Enabled = false;
            txtNumConta.Location = new Point(216, 28);
            txtNumConta.Name = "txtNumConta";
            txtNumConta.Size = new Size(260, 27);
            txtNumConta.TabIndex = 3;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(216, 74);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(260, 27);
            txtTitular.TabIndex = 4;
            // 
            // txtSaldo
            // 
            txtSaldo.Enabled = false;
            txtSaldo.Location = new Point(216, 116);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(260, 27);
            txtSaldo.TabIndex = 5;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(216, 167);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // formEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(txtSaldo);
            Controls.Add(txtTitular);
            Controls.Add(txtNumConta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formEditar";
            Text = "formEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumConta;
        private TextBox txtTitular;
        private TextBox txtSaldo;
        private Button btnEdit;
    }
}