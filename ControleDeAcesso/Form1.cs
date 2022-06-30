using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            int anoNasc = int.Parse(txtAnoNasc.Text);
            int idade = DateTime.Now.Year - anoNasc;

            if (idade >= 18)
            {
                lblResultado.Text = "BEM VINDO, " + nome.ToUpper() + " " + sobrenome.ToUpper() + " , " + idade + " ANOS.";
                lblResultado.ForeColor = Color.Green;
                lblMsg.Text = "SÓ VEM, QUE É SHOW!!!";
                lblMsg.ForeColor = Color.Green;
                pibInicio.Image = Properties.Resources.f2;

            }
            else
            {
                lblResultado.Text = nome.ToUpper() + " " + sobrenome.ToUpper() + " , " + idade + " ANOS.";
                lblResultado.ForeColor = Color.Red;
                lblMsg.Text = "VAZA, PIRRALHO!!!";
                lblMsg.ForeColor = Color.Red;
                pibInicio.Image = Properties.Resources.f1;
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtAnoNasc.Text = "";
            lblResultado.Text = "";
            lblMsg.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
