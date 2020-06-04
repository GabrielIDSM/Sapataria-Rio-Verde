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
    public partial class frmExcCadastroVendedores : Form
    {
        //Atributos
        VendedoresBLL vendedoresBll = new VendedoresBLL();
        VendedoresDTO vendedoresDto = new VendedoresDTO();
        List<VendedoresDTO> vendedores;
        frmTelaInicial frmT;
        //Construtor
        public frmExcCadastroVendedores(frmTelaInicial frmT)
        {
            this.frmT = frmT;
            InitializeComponent();
            btnConfirmar.Enabled = false;
            DefineVendedores();
        }

        private void DefineVendedores()
        {
            cbxLogin.Items.Clear();
            this.vendedores = this.vendedoresBll.Read();
            if (vendedores != null) foreach (VendedoresDTO v in this.vendedores)
                {
                    cbxLogin.Items.Add(v.Login);
                }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cbxLogin.Enabled = false;
            DialogResult r = MessageBox.Show("Deseja excluir o vendedor do Sistema ? ", "Confirmar Ação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r.Equals(DialogResult.Yes))
            {
                vendedoresDto.Login = this.vendedores[cbxLogin.SelectedIndex].Login;
                bool foiPossivel = vendedoresBll.ExcluirVendedor(this.vendedoresDto);
                if (foiPossivel)
                {
                    MessageBox.Show("Foi possível excluir o vendedor", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi excluir o vendedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DefineVendedores();
                cbxLogin.Enabled = true;
            }
            else
            {
                cbxLogin.Enabled = true;
            }

        }

        private void cbxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxVendasFeitas.Text = Convert.ToString(this.vendedores[cbxLogin.SelectedIndex].Vendas);
            if (this.vendedores[cbxLogin.SelectedIndex].Login.Equals(this.frmT.vendedor.Login)){
                btnConfirmar.Enabled = false;
            }
            else
            {
                btnConfirmar.Enabled = true;
            }
        }
    }
}
