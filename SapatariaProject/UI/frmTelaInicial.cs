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
        private static VendedoresDTO vendedor;
        private static Boolean adm = false;
        public static frmLogin frmL;
        //Getters e Setters
        internal static VendedoresDTO Vendedor { get => vendedor; set => vendedor = value; }
        public static bool Adm { get => adm; set => adm = value; }
        //Construtor
        public frmTelaInicial()
        {
            InitializeComponent();
            pPrincipal.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmL = new frmLogin();
            frmL.ShowDialog();
        }

        private void btnLogin_Load(object sender, EventArgs e)
        {
            frmL = new frmLogin();
            frmL.ShowDialog();
        }
    }
}
