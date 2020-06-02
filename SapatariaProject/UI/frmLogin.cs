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
        VendedoresDTO vendDto = new VendedoresDTO();
        VendedoresBLL vendBll = new VendedoresBLL();
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
            if(vendedor != null)
            {
                frmT.vendedor = vendedor;
                frmT.ConfirmaConta();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou Senha incorretos", "Conta inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.EncerraAplicacao();
        }
    }
}
