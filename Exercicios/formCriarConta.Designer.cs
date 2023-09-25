namespace Exercicio1
{
    partial class formCriarConta
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
            BtnCriar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTitular = new TextBox();
            txtNumeroConta = new TextBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            txtSaldo = new TextBox();
            SuspendLayout();
            // 
            // BtnCriar
            // 
            BtnCriar.Location = new Point(377, 217);
            BtnCriar.Name = "BtnCriar";
            BtnCriar.Size = new Size(94, 29);
            BtnCriar.TabIndex = 0;
            BtnCriar.Text = "Criar";
            BtnCriar.UseVisualStyleBackColor = true;
            BtnCriar.Click += BtnCriar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 39);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Titular:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 84);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 2;
            label2.Text = "Numero da Conta:";
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(200, 36);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(271, 27);
            txtTitular.TabIndex = 3;
            // 
            // txtNumeroConta
            // 
            txtNumeroConta.Location = new Point(200, 81);
            txtNumeroConta.Name = "txtNumeroConta";
            txtNumeroConta.Size = new Size(271, 27);
            txtNumeroConta.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(200, 114);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Terá Depósito inicial?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 147);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 6;
            label3.Text = "Valor Deposito:";
            // 
            // txtSaldo
            // 
            txtSaldo.Enabled = false;
            txtSaldo.Location = new Point(200, 144);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(271, 27);
            txtSaldo.TabIndex = 7;
            // 
            // formCriarConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSaldo);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(txtNumeroConta);
            Controls.Add(txtTitular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCriar);
            Name = "formCriarConta";
            Text = "formCriarConta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCriar;
        private Label label1;
        private Label label2;
        private TextBox txtTitular;
        private TextBox txtNumeroConta;
        private CheckBox checkBox1;
        private Label label3;
        private TextBox txtSaldo;
    }
}