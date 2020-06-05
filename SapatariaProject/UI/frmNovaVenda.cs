using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SapatariaProject.BLL;
using SapatariaProject.DTO;

namespace SapatariaProject.UI
{
    public partial class frmNovaVenda : Form
    {
        //Atributos
        ClientesDTO clientesDTO = new ClientesDTO();
        ClientesBLL clientesBLL = new ClientesBLL();
        VendedoresDTO vendedoresDTO;
        VendedoresBLL vendedoresBLL = new VendedoresBLL();
        VendasDTO vendasDTO = new VendasDTO();
        VendasBLL vendasBLL = new VendasBLL();
        SapatosDTO sapatosDTO = new SapatosDTO();
        SapatosBLL sapatosBLL = new SapatosBLL();
        List<ClientesDTO> Clientes;
        List<SapatosDTO> Sapatos;
        int nDeUnidades = 0;
        //Construtor
        public frmNovaVenda(VendedoresDTO vendedor)
        {
            this.vendedoresDTO = vendedor;
            InitializeComponent();
            pnlClientes.Visible = false;
            pnlUnidades.Visible = false;
            pnlVenda.Visible = false;
            btnConfirmaCliente.Enabled = false;
            btnConfirmarProd.Enabled = false;
            btnConfirmar.Enabled = false;
            Clientes = clientesBLL.Read();
            cbxID.Items.Add("NR");
            foreach (ClientesDTO c in Clientes) cbxID.Items.Add(c.Id);
            Sapatos = sapatosBLL.Read();
            dgvEstoque.DataSource = this.Sapatos;
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConfirmarProd.Enabled = true;
            sapatosDTO = Sapatos[dgvEstoque.CurrentCell.RowIndex];
        }

        private void btnConfirmarProd_Click(object sender, EventArgs e)
        {
            dgvEstoque.Enabled = false;
            btnConfirmarProd.Enabled = false;
            pnlUnidades.Visible = true;
        }

        private void btnConfirmarQ_Click(object sender, EventArgs e)
        {
            bool validade = true;
            try
            {
                nDeUnidades = Convert.ToInt32(txtbxQ.Text);
                if (nDeUnidades <= 0) throw new Exception();
                if (nDeUnidades > Sapatos[dgvEstoque.CurrentCell.RowIndex].Quantidade) throw new Exception();
            }
            catch
            {
                validade = false;
            }
            if (validade)
            {
                vendasDTO.Valor = Sapatos[dgvEstoque.CurrentCell.RowIndex].Valor * nDeUnidades;
                txtbxQ.Enabled = false;
                btnConfirmarQ.Enabled = false;
                pnlClientes.Visible = true;
            }
            else
            {
                MessageBox.Show("Número Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxID.SelectedIndex == 0)
            {
                clientesDTO = null;
                vendasDTO.Cliente = 0;
                txtbxNome.Text = "Cliente não Registrado";
            }
            else
            {
                clientesDTO = Clientes[cbxID.SelectedIndex - 1];
                vendasDTO.Cliente = cbxID.SelectedIndex;
                txtbxNome.Text = Clientes[cbxID.SelectedIndex - 1].Nome;
            }
            btnConfirmaCliente.Enabled = true;
        }

        private void btnConfirmaCliente_Click(object sender, EventArgs e)
        {
            btnConfirmaCliente.Enabled = false;
            pnlVenda.Visible = true;
            btnConfirmar.Enabled = true;
            txtTotal.Text = "R$ " + vendasDTO.Valor.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool validade = true;
            vendasDTO.Vendedor = vendedoresDTO.Login;
            validade = vendasBLL.NovaVenda(vendasDTO);
            validade = vendedoresBLL.AddVenda(vendedoresDTO);
            validade = clientesBLL.AddCompra(clientesDTO);
            if (validade)
            {
                MessageBox.Show("Foi possível efetuar a compra", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Não foi possível efetuar a compra", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
