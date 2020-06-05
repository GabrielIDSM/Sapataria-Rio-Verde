﻿using System;
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
    public partial class frmLogVendas : Form
    {
        //Atributos
        VendasBLL vendasBLL = new VendasBLL();
        //Construtor
        public frmLogVendas()
        {
            InitializeComponent();
            dgvVendas.DataSource = vendasBLL.ReadDt();
        }
    }
}