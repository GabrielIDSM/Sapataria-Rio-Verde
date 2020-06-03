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
        public static frmLogin frmL;
        //Construtor
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnLogin_Load(object sender, EventArgs e)
        {
            frmL = new frmLogin(this);
            frmL.ShowDialog();
        }

        public void ConfirmaConta()
        {
            this.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja sair efetuar o Logout", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r.Equals(DialogResult.Yes))
            {
                vendedor = null;
                this.Visible = false;
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
    }
}
