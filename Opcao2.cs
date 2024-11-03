using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaGaal
{
    public partial class Opcao2 : Form
    {
        public Opcao2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Vetor
                double a = double.Parse(txtVetorX.Text);
                double b = double.Parse(txtVetorY.Text);
                double c = double.Parse(txtVetorZ.Text);
                
                // Ponto
                double x0 = double.Parse(txtPontoX.Text);
                double y0 = double.Parse(txtPontoY.Text);
                double z0 = double.Parse(txtPontoZ.Text);

                double D = -(a * x0 + b * y0 + c * z0);

                lblResposta.Text = $"Equação Geral do Plano: {a}x ";

                if (b < 0)
                    lblResposta.Text += $"- {-b}y ";
                else
                    lblResposta.Text += $"+ {b}y ";

                if (c < 0)
                    lblResposta.Text += $"- {-c}z ";
                else
                    lblResposta.Text += $"+ {c}z ";
      
                if (D < 0)
                    lblResposta.Text += $"- {-D} = 0";
                else
                    lblResposta.Text += $"+ {D} = 0";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
