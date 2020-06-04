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
    public partial class frmExcCadastroClientes : Form
    {
        //Atributos
        ClientesBLL clienteBll = new ClientesBLL();
        ClientesDTO clienteDto = new ClientesDTO();
        List<ClientesDTO> clientes = null;
        //Construtor
        public frmExcCadastroClientes()
        {
            InitializeComponent();
            btnConfirmar.Enabled = false;
            DefineClientes();
        }

        public void DefineClientes()
        {
            txtbxNome.Text = "";
            txtbxTelefone.Text = "";
            txtbxComprasFeitas.Text = "";
            cbxID.Items.Clear();
            this.clientes = this.clienteBll.Read();
            if (this.clientes != null) foreach (ClientesDTO c in this.clientes)
                {
                    cbxID.Items.Add(c.Id);
                }
        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
            txtbxNome.Text = this.clientes[cbxID.SelectedIndex].Nome;
            txtbxTelefone.Text = this.clientes[cbxID.SelectedIndex].Telefone;
            txtbxComprasFeitas.Text = Convert.ToString(this.clientes[cbxID.SelectedIndex].Compras);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            cbxID.Enabled = false;
            DialogResult r = MessageBox.Show("Deseja excluir o cliente do Sistema ? ", "Confirmar Ação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r.Equals(DialogResult.Yes))
            {
                clienteDto.Id = this.clientes[cbxID.SelectedIndex].Id;
                bool foiPossivel = clienteBll.ExcluirCliente(clienteDto);
                if (foiPossivel)
                {
                    MessageBox.Show("Foi possível excluir o cliente", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi excluir o cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DefineClientes();
                cbxID.Enabled = true;
            }
            else
            {
                cbxID.Enabled = true;
            }
        }
    }
}
