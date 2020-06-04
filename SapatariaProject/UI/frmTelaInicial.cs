using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SapatariaProject.DTO;

namespace SapatariaProject.UI
{
    public partial class frmTelaInicial : Form
    {
        //Atributos
        public VendedoresDTO vendedor = null;
        public bool adm = false;
        public static frmLogin frmL;
        //Construtor
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnLogin_Load(object sender, EventArgs e)
        {
            btnAttClientes.Enabled = false;
            btnAttVendedores.Enabled = false;
            btnCadastrarCliente.Enabled = false;
            btnNovoFuncionario.Enabled = false;
            btnStatus.Enabled = false;
            btnExcCadastroClientes.Enabled = false;
            btnExcCadastroVendedores.Enabled = false;
            frmL = new frmLogin(this);
            frmL.ShowDialog();
        }

        public void ConfirmaConta()
        {
            this.Visible = true;
        }

        public void ConfirmaAdm()
        {
            btnAttClientes.Enabled = true;
            btnAttVendedores.Enabled = true;
            btnCadastrarCliente.Enabled = true;
            btnNovoFuncionario.Enabled = true;
            btnStatus.Enabled = true;
            btnExcCadastroClientes.Enabled = true;
            btnExcCadastroVendedores.Enabled = true;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja sair efetuar o Logout", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r.Equals(DialogResult.Yes))
            {
                btnAttClientes.Enabled = false;
                btnAttVendedores.Enabled = false;
                btnCadastrarCliente.Enabled = false;
                btnNovoFuncionario.Enabled = false;
                btnStatus.Enabled = false;
                vendedor = null;
                this.Visible = false;
                this.adm = false;
                frmL = new frmLogin(this);
                frmL.ShowDialog();
            }
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroVendedores frm = new frmCadastroVendedores();
            frm.ShowDialog();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmCadastroClientes frm = new frmCadastroClientes();
            frm.ShowDialog();
        }

        private void btnAttClientes_Click(object sender, EventArgs e)
        {
            frmAttCadastroClientes frm = new frmAttCadastroClientes();
            frm.ShowDialog();
        }

        private void btnAttVendedores_Click(object sender, EventArgs e)
        {
            frmAttCadastroVendedores frm = new frmAttCadastroVendedores();
            frm.ShowDialog();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            frmConcederStatus frm = new frmConcederStatus();
            frm.ShowDialog();
        }

        private void btnExcCadastroVendedores_Click(object sender, EventArgs e)
        {
            frmExcCadastroVendedores frm = new frmExcCadastroVendedores(this);
            frm.ShowDialog();
        }

        private void btnExcCadastroClientes_Click(object sender, EventArgs e)
        {
            frmExcCadastroClientes frm = new frmExcCadastroClientes();
            frm.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque frm = new frmEstoque();
            frm.ShowDialog();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmLogVendas frm = new frmLogVendas();
            frm.ShowDialog();
        }

        private void btnCadProdutos_Click(object sender, EventArgs e)
        {
            frmCadastroProdutos frm = new frmCadastroProdutos();
            frm.ShowDialog();
        }
    }
}
