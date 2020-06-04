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
    public partial class frmCadastroProdutos : Form
    {
        //Atributos
        SapatosDTO sapatosDto = new SapatosDTO();
        SapatosBLL sapatosBll = new SapatosBLL();
        String[] sexoModel = {"M (Masculino)", "F (Feminino)", "I (Infantil)" };
        //Construtor
        public frmCadastroProdutos()
        {
            InitializeComponent();
            for (int i = 24; i < 45; i++) cbxTamanho.Items.Add(Convert.ToString(i));
            foreach (String m in this.sexoModel) cbxSexo.Items.Add(m);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool validade = true;
            try
            {
                sapatosDto.Nome = txtbxNome.Text;
                sapatosDto.Quantidade = 0;
                sapatosDto.Tamanho = Convert.ToInt32(cbxTamanho.SelectedItem.ToString());
                sapatosDto.Sexo = cbxSexo.SelectedItem.ToString();
                sapatosDto.Valor = float.Parse(txtbxValor.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validade = false;
            }
            if (validade) validade = sapatosBll.NovoProduto(this.sapatosDto);
            if (validade)
            {
                MessageBox.Show("Foi possível cadastrar", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
