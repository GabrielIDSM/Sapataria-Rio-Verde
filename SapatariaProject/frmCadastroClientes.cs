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

namespace SapatariaProject
{
    public partial class frmCadastroClientes : Form
    {
        //Atributos
        ClienteBLL clienteBll = new ClienteBLL();
        ClienteDTO clienteDto = new ClienteDTO();
        //Getters e Setters
        //Construtor
        public frmCadastroClientes()
        {
            InitializeComponent();
            txtbxID.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            clienteDto.Nome = txtbxNome.Text;
            clienteDto.Telefone = txtbxTelefone.Text;
            clienteBll.Inserir(clienteDto);
        }
    }
}
