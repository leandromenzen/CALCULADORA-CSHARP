using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtVisor.Text += btn.Text;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtVisor.Text += btn.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = new DataTable().Compute(txtVisor.Text, null);
                txtVisor.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = string.Empty;
        }
    }
}
