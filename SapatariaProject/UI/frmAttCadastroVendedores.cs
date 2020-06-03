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
    public partial class frmAttCadastroVendedores : Form
    {
        //Atributos
        VendedoresBLL vendedoresBll = new VendedoresBLL();
        VendedoresDTO vendedoresDto = new VendedoresDTO();
        List<VendedoresDTO> vendedores;
        //Construtor
        public frmAttCadastroVendedores()
        {
            InitializeComponent();
            btnAlterar.Enabled = false;
            btnConfirmar.Enabled = false;
            txtbxSenha.Enabled = false;
            this.vendedores = this.vendedoresBll.Read();
            if(vendedores != null) foreach(VendedoresDTO v in this.vendedores)
                {
                    cbxLogin.Items.Add(v.Login);
                }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            txtbxSenha.Enabled = false;
            btnConfirmar.Enabled = false;
            btnAlterar.Enabled = true;
            cbxLogin.Enabled = true;
            vendedoresDto = vendedores[cbxLogin.SelectedIndex];
            vendedoresDto.Senha = txtbxSenha.Text;
            bool foiPossivel = vendedoresBll.AttVendedor(vendedoresDto);
            if (foiPossivel)
            {
                cbxLogin.Items.Clear();
                this.vendedores = this.vendedoresBll.Read();
                if (vendedores != null) foreach (VendedoresDTO v in this.vendedores)
                    {
                        cbxLogin.Items.Add(v.Login);
                    }
                MessageBox.Show("Foi possível atualizar", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Não foi possível atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtbxSenha.Enabled = true;
            btnConfirmar.Enabled = true;
            btnAlterar.Enabled = false;
            cbxLogin.Enabled = false;
        }

        private void cbxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxSenha.Text = this.vendedores[cbxLogin.SelectedIndex].Senha;
            btnAlterar.Enabled = true;
        }
    }
}
