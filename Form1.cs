using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            double saldo = double.Parse(lblSaldo.Text.Replace("R$", ""));
            double soma;
            if (lblOperacao.Text=="SAQUE")
            {
                 soma =  saldo - valor;
            }
            else
            {
                 soma = valor + saldo;
            }
           
            lblSaldo.Text = "R$" + soma;
            

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            //tira a cor do botão de depositar
            btnDepositar.BackColor = Color.Gainsboro;
            btnDepositar.ForeColor = Color.Black; 
            //Pinta o botão de sacar
            btnSacar.BackColor = Color.LightBlue;
            btnSacar.ForeColor = Color.DodgerBlue;
            lblOperacao.Text = "SAQUE";

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnSacar.BackColor = Color.Gainsboro;
            btnSacar.ForeColor = Color.Black;
            btnDepositar.BackColor = Color.LightBlue;
            btnDepositar.ForeColor = Color.DodgerBlue;
            lblOperacao.Text = "DEPÓSITO";
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            Form2 telaExtrato = new Form2();
            telaExtrato.Show();

        }
    }
}
