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
    public partial class frmConcederStatus : Form
    {
        //Atributos
        VendedoresBLL vendedoresBll = new VendedoresBLL();
        VendedoresDTO vendedoresDto = new VendedoresDTO();
        AdmBLL admBll = new AdmBLL();
        AdmDTO AdmDto = new AdmDTO();
        List<VendedoresDTO> vendedores;
        //Construtor
        public frmConcederStatus()
        {
            InitializeComponent();
            btnConfirmar.Enabled = false;
            DefineVendedores();
        }

        public void DefineVendedores()
        {
            cbxLogin.Items.Clear();
            this.vendedores = admBll.NaoAdms();
            if(this.vendedores != null) foreach(VendedoresDTO v in this.vendedores)
                {
                    cbxLogin.Items.Add(v.Login);
                }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = false;
            DialogResult r = MessageBox.Show("Deseja conceder status ? ", "Confirmar Ação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r.Equals(DialogResult.Yes))
            {
                AdmDto.Login = this.vendedores[cbxLogin.SelectedIndex].Login;
                DefineVendedores();
                bool foiPossivel = admBll.NovoAdm(AdmDto);
                if (foiPossivel)
                {
                    MessageBox.Show("Foi possível conceder status", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi conceder status", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }

        private void cbxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
        }
    }
}
