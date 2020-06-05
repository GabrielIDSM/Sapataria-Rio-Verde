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
    public partial class FrmAttEstoque : Form
    {
        //Atributos
        SapatosBLL sapatosBll = new SapatosBLL();
        SapatosDTO sapatosDto = new SapatosDTO();
        List<SapatosDTO> sapatos;
        //Construtor
        public FrmAttEstoque()
        {
            InitializeComponent();
            DefineSapatos();
        }

        private void DefineSapatos()
        {
            this.sapatos = sapatosBll.Read();
            dgvEstoque.DataSource = this.sapatos;
            dgvEstoque.Enabled = true;
            txtbxQ.Enabled = false;
            txtbxQ.Text = "";
            btnAlterar.Enabled = false;
            btnAtt.Enabled = false;
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sapatosDto = this.sapatos[dgvEstoque.CurrentCell.RowIndex];
            txtbxQ.Text = sapatosDto.Quantidade.ToString();
            btnAlterar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            txtbxQ.Enabled = true;
            dgvEstoque.Enabled = false;
            btnAtt.Enabled = true;
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            bool validade = true;
            try
            {
                sapatosDto.Quantidade = int.Parse(txtbxQ.Text);
                if (sapatosDto.Quantidade < 0) throw new Exception();
            }catch (Exception ev)
            {
                validade = false;
            }
            if (validade) validade = sapatosBll.AttProduto(this.sapatosDto);
            if (validade)
            {
                MessageBox.Show("Foi possível atualizar", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DefineSapatos();
            }
            else
            {
                MessageBox.Show("Não foi possível atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sapatosDto = this.sapatos[dgvEstoque.CurrentCell.RowIndex];
            txtbxQ.Text = sapatosDto.Quantidade.ToString();
            btnAlterar.Enabled = true;
        }
    }
}
