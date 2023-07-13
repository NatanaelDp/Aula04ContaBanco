namespace Aula04AppBanco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblOperacoes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblInformarValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(24, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(153, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Conradito´s Bank";
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAtual.Location = new System.Drawing.Point(25, 74);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(110, 17);
            this.lblSaldoAtual.TabIndex = 1;
            this.lblSaldoAtual.Text = "Seu saldo atual:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(25, 112);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(39, 18);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "R$ 0";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // lblOperacoes
            // 
            this.lblOperacoes.AutoSize = true;
            this.lblOperacoes.Location = new System.Drawing.Point(3, 0);
            this.lblOperacoes.Name = "lblOperacoes";
            this.lblOperacoes.Size = new System.Drawing.Size(116, 13);
            this.lblOperacoes.TabIndex = 3;
            this.lblOperacoes.Text = "Operações disponíveis";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSacar);
            this.panel1.Controls.Add(this.btnDepositar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblOperacoes);
            this.panel1.Location = new System.Drawing.Point(28, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 218);
            this.panel1.TabIndex = 4;
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDepositar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDepositar.Location = new System.Drawing.Point(35, 44);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(90, 33);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(145, 44);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(90, 33);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblInformarValor
            // 
            this.lblInformarValor.AutoSize = true;
            this.lblInformarValor.Location = new System.Drawing.Point(42, 37);
            this.lblInformarValor.Name = "lblInformarValor";
            this.lblInformarValor.Size = new System.Drawing.Size(80, 13);
            this.lblInformarValor.TabIndex = 6;
            this.lblInformarValor.Text = "Informe o valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(37, 53);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(131, 20);
            this.txtValor.TabIndex = 7;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(44, 12);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(70, 13);
            this.lblOperacao.TabIndex = 5;
            this.lblOperacao.Text = "DEPÓSITO";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(37, 79);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(131, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOperacao);
            this.panel2.Controls.Add(this.lblInformarValor);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Location = new System.Drawing.Point(35, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 114);
            this.panel2.TabIndex = 7;
            // 
            // btnExtrato
            // 
            this.btnExtrato.Location = new System.Drawing.Point(218, 69);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(75, 23);
            this.btnExtrato.TabIndex = 5;
            this.btnExtrato.Text = "Ver Extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 394);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSaldoAtual);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblOperacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label lblInformarValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExtrato;
    }
}

