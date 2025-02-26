using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void TravarBotao()
        {
            /*if ((lblOper.Text == btDiv.Text && numOper2.Value == 0)
                || lblOper.Text == "...")
                btIgual.Enabled = false;
            else 
                btIgual.Enabled = true;*/
            btIgual.Enabled = 
                !((lblOper.Text == btDiv.Text && numOper2.Value == 0)
                || lblOper.Text == "...");
        }

        void AtribuirOperacao(string oper)
        {
            lblOper.Text = oper;
            btIgual.Enabled = true;
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btSoma.Text);
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btSub.Text);
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btMult.Text);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btDiv.Text);
            TravarBotao();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            num1 = (double)numOper1.Value;
            num2 = (double)numOper2.Value;

            if (lblOper.Text == btSoma.Text)
                resultado = num1 + num2;
            else if (lblOper.Text == btSub.Text)
                resultado = num2 - num1;
            else if (lblOper.Text == btMult.Text)
                resultado = num1 * num2;
            else
                resultado = num1 / num2;

            lblResultado.Text = resultado.ToString();

        }

        private void numOper2_ValueChanged(object sender, EventArgs e)
        {
            TravarBotao();
        }
    }
}
