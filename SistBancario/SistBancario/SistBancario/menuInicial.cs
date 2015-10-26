using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistBancario
{
    public partial class menuInicial : Form
    {
        public menuInicial()
        {
            InitializeComponent();
        }

        private void menuInicial_Load(object sender, EventArgs e)
        {
            int boundWidth = Screen.PrimaryScreen.Bounds.Width;
            int boundHeight = Screen.PrimaryScreen.Bounds.Height;
            int x = boundWidth - this.Width;
            int y = boundHeight - this.Height;
            this.Location = new Point(x / 2, y / 2);
        }

        private void butBalcao_Click(object sender, EventArgs e)
        {
            this.Hide();
            balcao balcao = new balcao();
            balcao.Show();
        }

        private void butCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            cliente cliente = new cliente();
            cliente.Show();
        }

        private void butFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            funcionario funcionario = new funcionario();
            funcionario.Show();
        }

        private void butOperacoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            operacao operacao = new operacao();
            operacao.Show();
        }

        private void butEmprestimos_Click(object sender, EventArgs e)
        {
            this.Hide();
            emprestimo emprestimo = new emprestimo();
            emprestimo.Show();
        }

        private void butTransferencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            transferencia transferencia = new transferencia();
            transferencia.Show();
        }

        private void butContas_Click(object sender, EventArgs e)
        {
            this.Hide();
            conta conta = new conta();
            conta.Show();
        }

        private void butDepositos_Click(object sender, EventArgs e)
        {
            this.Hide();
            deposito deposito = new deposito();
            deposito.Show();
        }

        private void butLevantamentos_Click(object sender, EventArgs e)
        {
       
            this.Hide();
            levantamento levantamento = new levantamento();
            levantamento.Show();
        }   
    }
}
