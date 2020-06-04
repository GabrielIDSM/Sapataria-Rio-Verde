namespace SapatariaProject.UI
{
    partial class frmExcCadastroClientes
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
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.txtbxTelefone = new System.Windows.Forms.TextBox();
            this.txtbxComprasFeitas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxID
            // 
            this.cbxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(138, 12);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(254, 32);
            this.cbxID.TabIndex = 3;
            this.cbxID.SelectedIndexChanged += new System.EventHandler(this.cbxID_SelectedIndexChanged);
            // 
            // txtbxNome
            // 
            this.txtbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNome.Location = new System.Drawing.Point(138, 50);
            this.txtbxNome.MaxLength = 40;
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.ReadOnly = true;
            this.txtbxNome.Size = new System.Drawing.Size(254, 29);
            this.txtbxNome.TabIndex = 6;
            // 
            // txtbxTelefone
            // 
            this.txtbxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTelefone.Location = new System.Drawing.Point(138, 85);
            this.txtbxTelefone.MaxLength = 20;
            this.txtbxTelefone.Name = "txtbxTelefone";
            this.txtbxTelefone.ReadOnly = true;
            this.txtbxTelefone.Size = new System.Drawing.Size(254, 29);
            this.txtbxTelefone.TabIndex = 8;
            // 
            // txtbxComprasFeitas
            // 
            this.txtbxComprasFeitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxComprasFeitas.Location = new System.Drawing.Point(138, 120);
            this.txtbxComprasFeitas.MaxLength = 20;
            this.txtbxComprasFeitas.Name = "txtbxComprasFeitas";
            this.txtbxComprasFeitas.ReadOnly = true;
            this.txtbxComprasFeitas.Size = new System.Drawing.Size(254, 29);
            this.txtbxComprasFeitas.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Compras";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(287, 155);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 31);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Excluir";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmExcCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 200);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxComprasFeitas);
            this.Controls.Add(this.txtbxTelefone);
            this.Controls.Add(this.txtbxNome);
            this.Controls.Add(this.cbxID);
            this.Name = "frmExcCadastroClientes";
            this.Text = "Excluir Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.TextBox txtbxTelefone;
        private System.Windows.Forms.TextBox txtbxComprasFeitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmar;
    }
}