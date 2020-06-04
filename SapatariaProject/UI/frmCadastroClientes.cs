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
    public partial class frmCadastroClientes : Form
    {
        //Atributos
        ClientesBLL clienteBll = new ClientesBLL();
        ClientesDTO clienteDto = new ClientesDTO();
        //Construtor
        public frmCadastroClientes()
        {
            InitializeComponent();
            txtbxID.Text = Convert.ToString(clienteBll.ProximoID());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            clienteDto.Nome = txtbxNome.Text;
            clienteDto.Telefone = txtbxTelefone.Text;
            bool foiPossivel = clienteBll.NovoCliente(clienteDto);
            if(foiPossivel) MessageBox.Show("Foi possível cadastrar o cliente", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
