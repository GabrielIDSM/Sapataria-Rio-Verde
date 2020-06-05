namespace SapatariaProject.UI
{
    partial class frmTelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaInicial));
            this.btnLogout = new System.Windows.Forms.Button();
            this.pEstoque = new System.Windows.Forms.Panel();
            this.btnExcProdutos = new System.Windows.Forms.Button();
            this.btnAttProdutos = new System.Windows.Forms.Button();
            this.btnCadProdutos = new System.Windows.Forms.Button();
            this.btnReporEstoque = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.pTEstoque = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pCompras = new System.Windows.Forms.Panel();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.pTCompras = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pAdm = new System.Windows.Forms.Panel();
            this.btnExcCadastroVendedores = new System.Windows.Forms.Button();
            this.btnExcCadastroClientes = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnAttClientes = new System.Windows.Forms.Button();
            this.btnAttVendedores = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnNovoFuncionario = new System.Windows.Forms.Button();
            this.pTAdm = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pEstoque.SuspendLayout();
            this.pTEstoque.SuspendLayout();
            this.pCompras.SuspendLayout();
            this.pTCompras.SuspendLayout();
            this.pAdm.SuspendLayout();
            this.pTAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 42);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pEstoque
            // 
            this.pEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.pEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEstoque.Controls.Add(this.btnExcProdutos);
            this.pEstoque.Controls.Add(this.btnAttProdutos);
            this.pEstoque.Controls.Add(this.btnCadProdutos);
            this.pEstoque.Controls.Add(this.btnReporEstoque);
            this.pEstoque.Controls.Add(this.btnEstoque);
            this.pEstoque.Location = new System.Drawing.Point(141, 165);
            this.pEstoque.Name = "pEstoque";
            this.pEstoque.Size = new System.Drawing.Size(300, 400);
            this.pEstoque.TabIndex = 1;
            // 
            // btnExcProdutos
            // 
            this.btnExcProdutos.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcProdutos.Location = new System.Drawing.Point(3, 167);
            this.btnExcProdutos.Name = "btnExcProdutos";
            this.btnExcProdutos.Size = new System.Drawing.Size(292, 35);
            this.btnExcProdutos.TabIndex = 5;
            this.btnExcProdutos.Text = "Remover Cadastro de Produtos";
            this.btnExcProdutos.UseVisualStyleBackColor = false;
            this.btnExcProdutos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAttProdutos
            // 
            this.btnAttProdutos.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAttProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttProdutos.Location = new System.Drawing.Point(3, 126);
            this.btnAttProdutos.Name = "btnAttProdutos";
            this.btnAttProdutos.Size = new System.Drawing.Size(292, 35);
            this.btnAttProdutos.TabIndex = 4;
            this.btnAttProdutos.Text = "Atualizar Cadastro de Produtos";
            this.btnAttProdutos.UseVisualStyleBackColor = false;
            this.btnAttProdutos.Click += new System.EventHandler(this.btnAttProdutos_Click);
            // 
            // btnCadProdutos
            // 
            this.btnCadProdutos.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCadProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProdutos.Location = new System.Drawing.Point(3, 85);
            this.btnCadProdutos.Name = "btnCadProdutos";
            this.btnCadProdutos.Size = new System.Drawing.Size(292, 35);
            this.btnCadProdutos.TabIndex = 3;
            this.btnCadProdutos.Text = "Cadastrar Produto";
            this.btnCadProdutos.UseVisualStyleBackColor = false;
            this.btnCadProdutos.Click += new System.EventHandler(this.btnCadProdutos_Click);
            // 
            // btnReporEstoque
            // 
            this.btnReporEstoque.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReporEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporEstoque.Location = new System.Drawing.Point(3, 44);
            this.btnReporEstoque.Name = "btnReporEstoque";
            this.btnReporEstoque.Size = new System.Drawing.Size(292, 35);
            this.btnReporEstoque.TabIndex = 2;
            this.btnReporEstoque.Text = "Atualizar Estoque";
            this.btnReporEstoque.UseVisualStyleBackColor = false;
            this.btnReporEstoque.Click += new System.EventHandler(this.btnReporEstoque_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Location = new System.Drawing.Point(3, 3);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(292, 35);
            this.btnEstoque.TabIndex = 1;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // pTEstoque
            // 
            this.pTEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.pTEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTEstoque.Controls.Add(this.label1);
            this.pTEstoque.Location = new System.Drawing.Point(141, 109);
            this.pTEstoque.Name = "pTEstoque";
            this.pTEstoque.Size = new System.Drawing.Size(300, 50);
            this.pTEstoque.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estoque";
            // 
            // pCompras
            // 
            this.pCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.pCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCompras.Controls.Add(this.btnVendas);
            this.pCompras.Controls.Add(this.btnNovaVenda);
            this.pCompras.Location = new System.Drawing.Point(447, 165);
            this.pCompras.Name = "pCompras";
            this.pCompras.Size = new System.Drawing.Size(300, 400);
            this.pCompras.TabIndex = 3;
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.Location = new System.Drawing.Point(3, 44);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(292, 35);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Text = "Histórico de Vendas";
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.Location = new System.Drawing.Point(3, 3);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(292, 35);
            this.btnNovaVenda.TabIndex = 2;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = false;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // pTCompras
            // 
            this.pTCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.pTCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTCompras.Controls.Add(this.label2);
            this.pTCompras.Location = new System.Drawing.Point(447, 109);
            this.pTCompras.Name = "pTCompras";
            this.pTCompras.Size = new System.Drawing.Size(300, 50);
            this.pTCompras.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendas";
            // 
            // pAdm
            // 
            this.pAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.pAdm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAdm.Controls.Add(this.btnExcCadastroVendedores);
            this.pAdm.Controls.Add(this.btnExcCadastroClientes);
            this.pAdm.Controls.Add(this.btnStatus);
            this.pAdm.Controls.Add(this.btnAttClientes);
            this.pAdm.Controls.Add(this.btnAttVendedores);
            this.pAdm.Controls.Add(this.btnCadastrarCliente);
            this.pAdm.Controls.Add(this.btnNovoFuncionario);
            this.pAdm.Location = new System.Drawing.Point(753, 165);
            this.pAdm.Name = "pAdm";
            this.pAdm.Size = new System.Drawing.Size(300, 400);
            this.pAdm.TabIndex = 5;
            // 
            // btnExcCadastroVendedores
            // 
            this.btnExcCadastroVendedores.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcCadastroVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcCadastroVendedores.Location = new System.Drawing.Point(3, 167);
            this.btnExcCadastroVendedores.Name = "btnExcCadastroVendedores";
            this.btnExcCadastroVendedores.Size = new System.Drawing.Size(292, 35);
            this.btnExcCadastroVendedores.TabIndex = 6;
            this.btnExcCadastroVendedores.Text = "Remover Cadastro de Vendedores";
            this.btnExcCadastroVendedores.UseVisualStyleBackColor = false;
            this.btnExcCadastroVendedores.Click += new System.EventHandler(this.btnExcCadastroVendedores_Click);
            // 
            // btnExcCadastroClientes
            // 
            this.btnExcCadastroClientes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcCadastroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcCadastroClientes.Location = new System.Drawing.Point(3, 208);
            this.btnExcCadastroClientes.Name = "btnExcCadastroClientes";
            this.btnExcCadastroClientes.Size = new System.Drawing.Size(292, 35);
            this.btnExcCadastroClientes.TabIndex = 5;
            this.btnExcCadastroClientes.Text = "Remover Cadastro de Clientes";
            this.btnExcCadastroClientes.UseVisualStyleBackColor = false;
            this.btnExcCadastroClientes.Click += new System.EventHandler(this.btnExcCadastroClientes_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(3, 249);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(292, 35);
            this.btnStatus.TabIndex = 4;
            this.btnStatus.Text = "Conceder Status de ADM";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnAttClientes
            // 
            this.btnAttClientes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAttClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttClientes.Location = new System.Drawing.Point(3, 126);
            this.btnAttClientes.Name = "btnAttClientes";
            this.btnAttClientes.Size = new System.Drawing.Size(292, 35);
            this.btnAttClientes.TabIndex = 3;
            this.btnAttClientes.Text = "Atualizar Cadastro de Clientes";
            this.btnAttClientes.UseVisualStyleBackColor = false;
            this.btnAttClientes.Click += new System.EventHandler(this.btnAttClientes_Click);
            // 
            // btnAttVendedores
            // 
            this.btnAttVendedores.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAttVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttVendedores.Location = new System.Drawing.Point(3, 85);
            this.btnAttVendedores.Name = "btnAttVendedores";
            this.btnAttVendedores.Size = new System.Drawing.Size(292, 35);
            this.btnAttVendedores.TabIndex = 2;
            this.btnAttVendedores.Text = "Atualizar Cadastro de Vendedores";
            this.btnAttVendedores.UseVisualStyleBackColor = false;
            this.btnAttVendedores.Click += new System.EventHandler(this.btnAttVendedores_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(3, 44);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(292, 35);
            this.btnCadastrarCliente.TabIndex = 1;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnNovoFuncionario
            // 
            this.btnNovoFuncionario.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNovoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFuncionario.Location = new System.Drawing.Point(3, 3);
            this.btnNovoFuncionario.Name = "btnNovoFuncionario";
            this.btnNovoFuncionario.Size = new System.Drawing.Size(292, 35);
            this.btnNovoFuncionario.TabIndex = 0;
            this.btnNovoFuncionario.Text = "Cadastrar Vendedor";
            this.btnNovoFuncionario.UseVisualStyleBackColor = false;
            this.btnNovoFuncionario.Click += new System.EventHandler(this.btnNovoFuncionario_Click);
            // 
            // pTAdm
            // 
            this.pTAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.pTAdm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTAdm.Controls.Add(this.label3);
            this.pTAdm.Location = new System.Drawing.Point(753, 109);
            this.pTAdm.Name = "pTAdm";
            this.pTAdm.Size = new System.Drawing.Size(300, 50);
            this.pTAdm.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sistema";
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pTAdm);
            this.Controls.Add(this.pAdm);
            this.Controls.Add(this.pTCompras);
            this.Controls.Add(this.pCompras);
            this.Controls.Add(this.pTEstoque);
            this.Controls.Add(this.pEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sapataria Rio Verde";
            this.Load += new System.EventHandler(this.btnLogin_Load);
            this.pEstoque.ResumeLayout(false);
            this.pTEstoque.ResumeLayout(false);
            this.pTEstoque.PerformLayout();
            this.pCompras.ResumeLayout(false);
            this.pTCompras.ResumeLayout(false);
            this.pTCompras.PerformLayout();
            this.pAdm.ResumeLayout(false);
            this.pTAdm.ResumeLayout(false);
            this.pTAdm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Panel pEstoque;
        public System.Windows.Forms.Panel pTEstoque;
        public System.Windows.Forms.Panel pCompras;
        public System.Windows.Forms.Panel pTCompras;
        public System.Windows.Forms.Panel pAdm;
        public System.Windows.Forms.Panel pTAdm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoFuncionario;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnAttClientes;
        private System.Windows.Forms.Button btnAttVendedores;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnExcCadastroVendedores;
        private System.Windows.Forms.Button btnExcCadastroClientes;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Button btnExcProdutos;
        private System.Windows.Forms.Button btnAttProdutos;
        private System.Windows.Forms.Button btnCadProdutos;
        private System.Windows.Forms.Button btnReporEstoque;
        private System.Windows.Forms.Button btnVendas;
    }
}