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
    public partial class frmCadastroVendedores : Form
    {
        //Atributos
        VendedoresBLL vendedoresBll = new VendedoresBLL();
        VendedoresDTO vendedoresDto = new VendedoresDTO();
        //Construtor
        public frmCadastroVendedores()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            vendedoresDto.Login = txtbxLogin.Text;
            vendedoresDto.Senha = txtbxSenha.Text;
            bool foiPossivel = vendedoresBll.NovoVendedor(vendedoresDto);
            if (foiPossivel)
            {
                MessageBox.Show("Foi possível cadastrar o vendedor", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o vendedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
