namespace Exercicio1
{
    partial class frmSacar
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
            cmbContas = new ComboBox();
            txtValor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSacar = new Button();
            SuspendLayout();
            // 
            // cmbContas
            // 
            cmbContas.FormattingEnabled = true;
            cmbContas.Location = new Point(180, 53);
            cmbContas.Name = "cmbContas";
            cmbContas.Size = new Size(257, 28);
            cmbContas.TabIndex = 0;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(180, 98);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(257, 27);
            txtValor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 53);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "Conta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 105);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Valor:";
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(180, 140);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(94, 29);
            btnSacar.TabIndex = 4;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // frmSacar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSacar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValor);
            Controls.Add(cmbContas);
            Name = "frmSacar";
            Text = "frmSacar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbContas;
        private TextBox txtValor;
        private Label label1;
        private Label label2;
        private Button btnSacar;
    }
}