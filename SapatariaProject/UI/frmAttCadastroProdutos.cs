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
    public partial class frmAttCadastroProdutos : Form
    {
        //Atributos
        SapatosDTO sapatosDto = new SapatosDTO();
        SapatosBLL sapatosBll = new SapatosBLL();
        List<SapatosDTO> produtos;
        String[] sexoModel = { "M (Masculino)", "F (Feminino)", "I (Infantil)" };
        int Modo;
        //Construtor
        public frmAttCadastroProdutos(int QualModo)
        {
            this.Modo = QualModo;
            InitializeComponent();
            for (int i = 24; i < 45; i++) cbxTamanho.Items.Add(Convert.ToString(i));
            foreach (String m in this.sexoModel) cbxSexo.Items.Add(m);
            DefineProdutos();
            txtbxNome.Enabled = false;
            cbxTamanho.Enabled = false;
            cbxSexo.Enabled = false;
            txtbxValor.Enabled = false;
            btnAtualizar.Enabled = false;
            btnAlterar.Enabled = false;
            if(QualModo == 1)
            {
                btnAlterar.Visible = false;
                this.Text = "Excluir Cadastro de Produtos";
                btnAtualizar.Text = "Deletar";
                btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            }
        }

        public void DefineProdutos()
        {
            cbxID.Items.Clear();
            this.produtos = sapatosBll.Read();
            foreach (SapatosDTO s in this.produtos)
            {
                cbxID.Items.Add(s.Id);
            }
        }

        private int QualIndexSexo(String s)
        {
            if (s.Equals(sexoModel[0]))
            {
                return 0;
            } else if (s.Equals(sexoModel[1]))
            {
                return 1;
            } else
            {
                return 2;
            }
        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxNome.Text = this.produtos[cbxID.SelectedIndex].Nome;
            cbxTamanho.SelectedIndex = this.produtos[cbxID.SelectedIndex].Tamanho - 24;
            cbxSexo.SelectedIndex = QualIndexSexo(this.produtos[cbxID.SelectedIndex].Sexo);
            txtbxValor.Text = Convert.ToString(this.produtos[cbxID.SelectedIndex].Valor);
            if (this.Modo == 0) btnAlterar.Enabled = true;
            else btnAtualizar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cbxID.Enabled = false;
            btnAlterar.Enabled = false;
            btnAtualizar.Enabled = true;
            txtbxNome.Enabled = true;
            cbxTamanho.Enabled = true;
            cbxSexo.Enabled = true;
            txtbxValor.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool validade = true;
            if(this.Modo == 0)
            {
                try
                {
                    sapatosDto.Id = this.produtos[cbxID.SelectedIndex].Id;
                    sapatosDto.Nome = txtbxNome.Text;
                    sapatosDto.Quantidade = this.produtos[cbxID.SelectedIndex].Quantidade;
                    sapatosDto.Tamanho = Convert.ToInt32(cbxTamanho.SelectedItem.ToString());
                    sapatosDto.Sexo = cbxSexo.SelectedItem.ToString();
                    String valor = txtbxValor.Text;
                    valor = valor.Replace(".", ",");
                    valor = valor.Trim();
                    valor = valor.Normalize();
                    sapatosDto.Valor = (float)Decimal.Parse(valor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    validade = false;
                }
                if (validade) validade = sapatosBll.AttProduto(this.sapatosDto);
            } else
            {
                try
                {
                    sapatosDto.Id = this.produtos[cbxID.SelectedIndex].Id;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    validade = false;
                }
                if (validade) validade = sapatosBll.ExcProduto(this.sapatosDto);
            }
            if (validade)
            {
                if(this.Modo == 0) MessageBox.Show("Foi possível atualizar", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Foi possível Excluir", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                if (this.Modo == 0) MessageBox.Show("Não foi possível atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Não foi possível Excluir", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
