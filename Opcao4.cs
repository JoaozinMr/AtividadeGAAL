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
    public partial class Opcao4 : Form
    {
        public Opcao4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Equacoes
                double x0 = double.Parse(txtEquacaoX.Text);
                double y0 = double.Parse(txtEquacaoY.Text);
                double z0 = double.Parse(txtEquacaoZ.Text);

                double dx = double.Parse(txtEquacaoA.Text);
                double dy = double.Parse(txtEquacaoB.Text);
                double dz = double.Parse(txtEquacaoC.Text);

                // Ponto
                double x1 = double.Parse(txtPontoX.Text);
                double y1 = double.Parse(txtPontoY.Text);
                double z1 = double.Parse(txtPontoZ.Text);

                // Calcula o vetor AP
                double apx = x1 - x0;
                double apy = y1 - y0;
                double apz = z1 - z0;

                // AP x d
                double crossX = apy * dz - apz * dy;
                double crossY = apz * dx - apx * dz;
                double crossZ = apx * dy - apy * dx;

                // Norma do produto vetorial ||AP x d||
                double somaCross = crossX * crossX + crossY * crossY + crossZ * crossZ;
                double crossNorma = Math.Sqrt(somaCross);

                // Norma do vetor diretor ||d||
                double somaD = dx * dx + dy * dy + dz * dz;
                double dNorma = Math.Sqrt(somaD);

                // Verifica se o ponto está na reta
                if (crossNorma == 0)
                {
                    lblResposta.Text = "O ponto está contido na reta. Distância = 0";
                }
                else
                {
                    double distancia = crossNorma / dNorma;
                    lblResposta.Text = $"Distância do ponto à reta: √{somaCross} / \u221A{somaD} = {distancia:F2}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("O vetor diretor não pode ter todos os componentes iguais a zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
