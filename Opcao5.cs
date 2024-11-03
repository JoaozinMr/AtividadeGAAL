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
    public partial class Opcao5 : Form
    {
        public Opcao5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Primeiro plano
                double A = double.Parse(txtEquacaoA1.Text);
                double B = double.Parse(txtEquacaoB1.Text);
                double C = double.Parse(txtEquacaoC1.Text);
                double D = double.Parse(txtEquacaoD1.Text);

                // Segundo plano
                double A2 = double.Parse(txtEquacaoA2.Text);
                double B2 = double.Parse(txtEquacaoB2.Text);
                double C2 = double.Parse(txtEquacaoC2.Text);
                double D2 = double.Parse(txtEquacaoD2.Text);

                // Verifica se os planos são paralelos
                bool saoParalelos = (A * B2 == A2 * B) && (A * C2 == A2 * C) && (B * C2 == B2 * C);

                if (!saoParalelos)
                {
                    lblResposta.Text = "Os planos são concorrentes e se interceptam. Distância = 0";
                    return;
                }

                //Buscando um ponto no Plano 1
                double x0, y0, z0;

                if (C != 0)
                {
                    x0 = 0;
                    y0 = 0;
                    z0 = -D / C;
                }
                else if (B != 0)
                {
                    x0 = 0;
                    z0 = 0;
                    y0 = -D / B;
                }
                else if (A != 0)
                {
                    y0 = 0;
                    z0 = 0;
                    x0 = -D / A;
                }
                else
                {
                    MessageBox.Show("Os coeficientes de A, B e C não podem ser todos zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double numerador = Math.Abs(A2 * x0 + B2 * y0 + C2 * z0 + D2);

                double valor = A2 * A2 + B2 * B2 + C2 * C2;
                double denominador = Math.Sqrt(valor);

                double distance = numerador / denominador;

                lblResposta.Text = $"Os planos são paralelos. Distância entre eles: {numerador} / {denominador} = {distance:F2}";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Os coeficientes de A, B e C não podem ser todos zero, pois não formam um plano válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
