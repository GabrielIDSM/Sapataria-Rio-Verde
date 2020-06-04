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
using SapatariaProject.BLL;

namespace SapatariaProject.UI
{
    public partial class frmLogin : Form
    {
        //Atributos
        VendedoresDTO vendedor = null; 
        VendedoresDTO vendDto = new VendedoresDTO();
        VendedoresBLL vendBll = new VendedoresBLL();
        AdmBLL admBll = new AdmBLL();
        frmTelaInicial frmT = new frmTelaInicial();
        //Construtor
        public frmLogin(frmTelaInicial frmT)
        {
            this.frmT = frmT;
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VendedoresDTO vendedor = null;
            //Método que verifica se existe uma conta com esse login e senha
            vendedor = vendBll.EhVendedor(txtbxLogin.Text, txtbxSenha.Text);
            if(vendedor != null)
            {
                frmT.vendedor = vendedor;
                this.vendedor = vendedor;
                if (admBll.EhAdm(vendedor.Login)) frmT.ConfirmaAdm();
                frmT.ConfirmaConta();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Login ou Senha incorretos", "Conta inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.vendedor == null) Program.EncerraAplicacao();
        }
    }
}
