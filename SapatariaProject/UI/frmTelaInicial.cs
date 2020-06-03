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

namespace SapatariaProject.UI
{
    public partial class frmTelaInicial : Form
    {
        //Atributos
        public VendedoresDTO vendedor = null;
        public static frmLogin frmL;
        //Construtor
        public frmTelaInicial()
        {
            InitializeComponent();
            pPrincipal.Visible = false;
        }

        private void btnLogin_Load(object sender, EventArgs e)
        {
            frmL = new frmLogin(this);
            frmL.ShowDialog();
        }

        public void ConfirmaConta()
        {
            pPrincipal.Visible = true;
            this.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja sair efetuar o Logout", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r.Equals(DialogResult.Yes))
            {
                vendedor = null;
                pPrincipal.Visible = false;
                frmL = new frmLogin(this);
                frmL.ShowDialog();
            }
        }
    }
}
