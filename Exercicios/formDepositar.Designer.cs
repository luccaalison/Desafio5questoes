namespace Exercicio1
{
    partial class formDepositar
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
            txtValor = new TextBox();
            cmbContas = new ComboBox();
            btnDepositar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 55);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Conta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 100);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(137, 100);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(220, 27);
            txtValor.TabIndex = 3;
            // 
            // cmbContas
            // 
            cmbContas.FormattingEnabled = true;
            cmbContas.Location = new Point(137, 52);
            cmbContas.Name = "cmbContas";
            cmbContas.Size = new Size(220, 28);
            cmbContas.TabIndex = 4;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(137, 150);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(94, 29);
            btnDepositar.TabIndex = 5;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // formDepositar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDepositar);
            Controls.Add(cmbContas);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formDepositar";
            Text = "formDepositar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtValor;
        private ComboBox cmbContas;
        private Button btnDepositar;
    }
}