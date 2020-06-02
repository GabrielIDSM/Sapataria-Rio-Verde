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
    public partial class frmLogin : Form
    {
        //Atributos
        VendedoresDTO vendDto = new VendedoresDTO();
        VendedoresBLL vendBll = new VendedoresBLL();
        //Construtor
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
        }
    }
}
