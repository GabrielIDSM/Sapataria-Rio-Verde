namespace SapatariaProject.UI
{
    partial class frmNovaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarProd = new System.Windows.Forms.Button();
            this.pnlUnidades = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxQ = new System.Windows.Forms.TextBox();
            this.btnConfirmarQ = new System.Windows.Forms.Button();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.btnConfirmaCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.pnlVenda = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.pnlUnidades.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnConfirmarProd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvEstoque);
            this.panel1.Location = new System.Drawing.Point(70, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 247);
            this.panel1.TabIndex = 0;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(100, 37);
            this.dgvEstoque.MultiSelect = false;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(660, 169);
            this.dgvEstoque.TabIndex = 1;
            this.dgvEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Escolha um Produto";
            // 
            // btnConfirmarProd
            // 
            this.btnConfirmarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarProd.Location = new System.Drawing.Point(750, 212);
            this.btnConfirmarProd.Name = "btnConfirmarProd";
            this.btnConfirmarProd.Size = new System.Drawing.Size(105, 29);
            this.btnConfirmarProd.TabIndex = 14;
            this.btnConfirmarProd.Text = "Confirmar";
            this.btnConfirmarProd.UseVisualStyleBackColor = false;
            this.btnConfirmarProd.Click += new System.EventHandler(this.btnConfirmarProd_Click);
            // 
            // pnlUnidades
            // 
            this.pnlUnidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pnlUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUnidades.Controls.Add(this.btnConfirmarQ);
            this.pnlUnidades.Controls.Add(this.txtbxQ);
            this.pnlUnidades.Controls.Add(this.label2);
            this.pnlUnidades.Location = new System.Drawing.Point(70, 294);
            this.pnlUnidades.Name = "pnlUnidades";
            this.pnlUnidades.Size = new System.Drawing.Size(860, 60);
            this.pnlUnidades.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unidades";
            // 
            // txtbxQ
            // 
            this.txtbxQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxQ.Location = new System.Drawing.Point(99, 14);
            this.txtbxQ.MaxLength = 40;
            this.txtbxQ.Name = "txtbxQ";
            this.txtbxQ.Size = new System.Drawing.Size(254, 29);
            this.txtbxQ.TabIndex = 13;
            // 
            // btnConfirmarQ
            // 
            this.btnConfirmarQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmarQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarQ.Location = new System.Drawing.Point(750, 26);
            this.btnConfirmarQ.Name = "btnConfirmarQ";
            this.btnConfirmarQ.Size = new System.Drawing.Size(105, 29);
            this.btnConfirmarQ.TabIndex = 15;
            this.btnConfirmarQ.Text = "Confirmar";
            this.btnConfirmarQ.UseVisualStyleBackColor = false;
            this.btnConfirmarQ.Click += new System.EventHandler(this.btnConfirmarQ_Click);
            // 
            // pnlClientes
            // 
            this.pnlClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pnlClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientes.Controls.Add(this.txtbxNome);
            this.pnlClientes.Controls.Add(this.cbxID);
            this.pnlClientes.Controls.Add(this.btnConfirmaCliente);
            this.pnlClientes.Controls.Add(this.label3);
            this.pnlClientes.Location = new System.Drawing.Point(70, 360);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(860, 60);
            this.pnlClientes.TabIndex = 2;
            // 
            // btnConfirmaCliente
            // 
            this.btnConfirmaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmaCliente.Location = new System.Drawing.Point(750, 26);
            this.btnConfirmaCliente.Name = "btnConfirmaCliente";
            this.btnConfirmaCliente.Size = new System.Drawing.Size(105, 29);
            this.btnConfirmaCliente.TabIndex = 15;
            this.btnConfirmaCliente.Text = "Confirmar";
            this.btnConfirmaCliente.UseVisualStyleBackColor = false;
            this.btnConfirmaCliente.Click += new System.EventHandler(this.btnConfirmaCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente";
            // 
            // cbxID
            // 
            this.cbxID.DropDownHeight = 240;
            this.cbxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxID.FormattingEnabled = true;
            this.cbxID.IntegralHeight = false;
            this.cbxID.Location = new System.Drawing.Point(77, 14);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(254, 32);
            this.cbxID.TabIndex = 16;
            this.cbxID.SelectedIndexChanged += new System.EventHandler(this.cbxID_SelectedIndexChanged);
            // 
            // txtbxNome
            // 
            this.txtbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNome.Location = new System.Drawing.Point(337, 14);
            this.txtbxNome.MaxLength = 40;
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.ReadOnly = true;
            this.txtbxNome.Size = new System.Drawing.Size(254, 29);
            this.txtbxNome.TabIndex = 17;
            // 
            // pnlVenda
            // 
            this.pnlVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pnlVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVenda.Controls.Add(this.txtTotal);
            this.pnlVenda.Controls.Add(this.label5);
            this.pnlVenda.Controls.Add(this.btnConfirmar);
            this.pnlVenda.Controls.Add(this.label4);
            this.pnlVenda.Location = new System.Drawing.Point(70, 426);
            this.pnlVenda.Name = "pnlVenda";
            this.pnlVenda.Size = new System.Drawing.Size(860, 97);
            this.pnlVenda.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(750, 63);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 29);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirmar Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total (Em R$)";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(134, 49);
            this.txtTotal.MaxLength = 40;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(254, 29);
            this.txtTotal.TabIndex = 18;
            // 
            // frmNovaVenda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlVenda);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.pnlUnidades);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNovaVenda";
            this.Text = "Nova Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.pnlUnidades.ResumeLayout(false);
            this.pnlUnidades.PerformLayout();
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            this.pnlVenda.ResumeLayout(false);
            this.pnlVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarProd;
        private System.Windows.Forms.Panel pnlUnidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmarQ;
        private System.Windows.Forms.TextBox txtbxQ;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Button btnConfirmaCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.Panel pnlVenda;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
    }
}