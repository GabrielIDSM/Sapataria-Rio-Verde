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
using SapatariaProject;

namespace SapatariaProject.UI
{
    public partial class frmAttCadastroClientes : Form
    {
        //Atributos
        ClientesBLL clienteBll = new ClientesBLL();
        ClientesDTO clienteDto = new ClientesDTO();
        List<ClientesDTO> clientes = null;
        //Construtor
        public frmAttCadastroClientes()
        {
            InitializeComponent();
        }

        private void frmAttCadastroClientes_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnConfirmar.Enabled = false;
            txtbxNome.Enabled = false;
            txtbxTelefone.Enabled = false;
            this.clientes = this.clienteBll.Read();
            if(this.clientes != null) foreach(ClientesDTO c in this.clientes)
                {
                    cbxID.Items.Add(c.Id);
                }
        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxNome.Text = clientes[cbxID.SelectedIndex].Nome;
            txtbxTelefone.Text = clientes[cbxID.SelectedIndex].Telefone;
            btnAlterar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtbxNome.Enabled = true;
            txtbxTelefone.Enabled = true;
            btnConfirmar.Enabled = true;
            btnAlterar.Enabled = false;
            cbxID.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            txtbxNome.Enabled = false;
            txtbxTelefone.Enabled = false;
            btnConfirmar.Enabled = false ;
            cbxID.Enabled = true;
            btnAlterar.Enabled = true;
            clienteDto = this.clientes[cbxID.SelectedIndex];
            clienteDto.Nome = txtbxNome.Text;
            clienteDto.Telefone = txtbxTelefone.Text;
            bool foiPossivel = clienteBll.AttCliente(clienteDto);
            if (foiPossivel)
            {
                this.clientes = clienteBll.Read();
                cbxID.Items.Clear();
                if (this.clientes != null) foreach (ClientesDTO c in this.clientes)
                    {
                        cbxID.Items.Add(c.Id);
                    }
                MessageBox.Show("Foi possível atualizar", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Não foi possível atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
