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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpcao01_Click(object sender, EventArgs e)
        {
            Opcao1 opcao1 = new Opcao1();
            opcao1.Show();
        }

        private void btnOpcao02_Click(object sender, EventArgs e)
        {
            Opcao2 opcao2 = new Opcao2();
            opcao2.Show();
        }

        private void btnOpcao03_Click(object sender, EventArgs e)
        {
            Opcao3 opcao3 = new Opcao3();
            opcao3.Show();
        }

        private void btnOpcao04_Click(object sender, EventArgs e)
        {
            Opcao4 opcao4 = new Opcao4();
            opcao4.Show();
        }

        private void btnOpcao05_Click(object sender, EventArgs e)
        {
            Opcao5 opcao5 = new Opcao5();
            opcao5.Show();
        }
    }
}
