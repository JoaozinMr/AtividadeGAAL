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
    public partial class Opcao3 : Form
    {
        public Opcao3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Plano
                double A = double.Parse(txtEquacaoA.Text);
                double B = double.Parse(txtEquacaoB.Text);
                double C = double.Parse(txtEquacaoC.Text);
                double D = double.Parse(txtEquacaoD.Text);

                // Ponto
                double x0 = double.Parse(txtPontoX.Text);
                double y0 = double.Parse(txtPontoY.Text);
                double z0 = double.Parse(txtPontoZ.Text);

                double numerador = Math.Abs(A * x0 + B * y0 + C * z0 + D);

                double valor = A * A + B * B + C * C;
                double denominador = Math.Sqrt(valor);

                // Verifica se o ponto está no plano
                if (numerador == 0)
                {
                    lblResposta.Text = "O ponto está contido no plano. Distância = 0";
                }
                else
                {
                    double distance = numerador / denominador;
                    lblResposta.Text = $"Distância do ponto ao plano: {numerador} / √{valor} = {distance:F2}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Os valores de A, B e C não podem ser todos zero, pois não formam um plano válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
