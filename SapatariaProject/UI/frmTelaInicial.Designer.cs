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
            this.pTEstoque = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pCompras = new System.Windows.Forms.Panel();
            this.pTCompras = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pAdm = new System.Windows.Forms.Panel();
            this.btnAttClientes = new System.Windows.Forms.Button();
            this.btnAttVendedores = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnNovoFuncionario = new System.Windows.Forms.Button();
            this.pTAdm = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pTEstoque.SuspendLayout();
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
            this.pEstoque.Location = new System.Drawing.Point(141, 165);
            this.pEstoque.Name = "pEstoque";
            this.pEstoque.Size = new System.Drawing.Size(300, 400);
            this.pEstoque.TabIndex = 1;
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
            this.pCompras.Location = new System.Drawing.Point(447, 165);
            this.pCompras.Name = "pCompras";
            this.pCompras.Size = new System.Drawing.Size(300, 400);
            this.pCompras.TabIndex = 3;
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
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compras";
            // 
            // pAdm
            // 
            this.pAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.pAdm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAdm.Controls.Add(this.btnAttClientes);
            this.pAdm.Controls.Add(this.btnAttVendedores);
            this.pAdm.Controls.Add(this.btnCadastrarCliente);
            this.pAdm.Controls.Add(this.btnNovoFuncionario);
            this.pAdm.Location = new System.Drawing.Point(753, 165);
            this.pAdm.Name = "pAdm";
            this.pAdm.Size = new System.Drawing.Size(300, 400);
            this.pAdm.TabIndex = 5;
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
            this.pTEstoque.ResumeLayout(false);
            this.pTEstoque.PerformLayout();
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
    }
}