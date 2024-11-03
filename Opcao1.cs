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
    public partial class Opcao1 : Form
    {
        public Opcao1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Ponto
                double x0 = double.Parse(txtPontoX.Text);
                double y0 = double.Parse(txtPontoY.Text);
                double z0 = double.Parse(txtPontoZ.Text);

                // Vetor
                double dx = double.Parse(txtVetorX.Text);
                double dy = double.Parse(txtVetorY.Text);
                double dz = double.Parse(txtVetorZ.Text);

                string parametricEquationX = $"x = {x0} + ({dx}t)";
                string parametricEquationY = $"y = {y0} + ({dy}t)";
                string parametricEquationZ = $"z = {z0} + ({dz}t)";

                // Exibe o resultado
                lblResposta.Text = $"Equações Paramétricas da Reta:\n{parametricEquationX}\n{parametricEquationY}\n{parametricEquationZ}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
