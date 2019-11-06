namespace ProjetoDesafio.Feature.Fornecedor.View
{
    partial class FrmListagemDeFornecedor
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
            this.components = new System.ComponentModel.Container();
            this.rdbRazaoSocial = new System.Windows.Forms.RadioButton();
            this.rdbRepresentante = new System.Windows.Forms.RadioButton();
            this.rdbNomeFantasia = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.gpLista = new System.Windows.Forms.GroupBox();
            this.dtListaFornecedor = new System.Windows.Forms.DataGridView();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgIeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularRepresentanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailRepresentanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbRazaoSocial
            // 
            this.rdbRazaoSocial.AutoSize = true;
            this.rdbRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRazaoSocial.Location = new System.Drawing.Point(776, 40);
            this.rdbRazaoSocial.Name = "rdbRazaoSocial";
            this.rdbRazaoSocial.Size = new System.Drawing.Size(148, 29);
            this.rdbRazaoSocial.TabIndex = 11;
            this.rdbRazaoSocial.TabStop = true;
            this.rdbRazaoSocial.Text = "Razão Social";
            this.rdbRazaoSocial.UseVisualStyleBackColor = true;
            // 
            // rdbRepresentante
            // 
            this.rdbRepresentante.AutoSize = true;
            this.rdbRepresentante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRepresentante.Location = new System.Drawing.Point(602, 40);
            this.rdbRepresentante.Name = "rdbRepresentante";
            this.rdbRepresentante.Size = new System.Drawing.Size(160, 29);
            this.rdbRepresentante.TabIndex = 10;
            this.rdbRepresentante.TabStop = true;
            this.rdbRepresentante.Text = "Representante";
            this.rdbRepresentante.UseVisualStyleBackColor = true;
            // 
            // rdbNomeFantasia
            // 
            this.rdbNomeFantasia.AutoSize = true;
            this.rdbNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNomeFantasia.Location = new System.Drawing.Point(419, 40);
            this.rdbNomeFantasia.Name = "rdbNomeFantasia";
            this.rdbNomeFantasia.Size = new System.Drawing.Size(165, 29);
            this.rdbNomeFantasia.TabIndex = 9;
            this.rdbNomeFantasia.TabStop = true;
            this.rdbNomeFantasia.Text = "Nome Fantasia";
            this.rdbNomeFantasia.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(428, 90);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(505, 34);
            this.txtPesquisar.TabIndex = 8;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // gpLista
            // 
            this.gpLista.Controls.Add(this.dtListaFornecedor);
            this.gpLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLista.Location = new System.Drawing.Point(10, 155);
            this.gpLista.Name = "gpLista";
            this.gpLista.Size = new System.Drawing.Size(1390, 665);
            this.gpLista.TabIndex = 15;
            this.gpLista.TabStop = false;
            // 
            // dtListaFornecedor
            // 
            this.dtListaFornecedor.AllowUserToAddRows = false;
            this.dtListaFornecedor.AutoGenerateColumns = false;
            this.dtListaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFornecedorDataGridViewTextBoxColumn,
            this.nomePessoaDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.rgIeDataGridViewTextBoxColumn,
            this.cpfCnpjDataGridViewTextBoxColumn,
            this.emailPessoaDataGridViewTextBoxColumn,
            this.representanteDataGridViewTextBoxColumn,
            this.telefonePessoaDataGridViewTextBoxColumn,
            this.celularRepresentanteDataGridViewTextBoxColumn,
            this.emailRepresentanteDataGridViewTextBoxColumn});
            this.dtListaFornecedor.DataSource = this.fornecedorModelBindingSource;
            this.dtListaFornecedor.Location = new System.Drawing.Point(2, 10);
            this.dtListaFornecedor.Name = "dtListaFornecedor";
            this.dtListaFornecedor.RowHeadersWidth = 51;
            this.dtListaFornecedor.RowTemplate.Height = 24;
            this.dtListaFornecedor.Size = new System.Drawing.Size(1380, 648);
            this.dtListaFornecedor.TabIndex = 0;
            this.dtListaFornecedor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtListFornecedor_CellFormatting);
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "IdFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idFornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            this.idFornecedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomePessoaDataGridViewTextBoxColumn
            // 
            this.nomePessoaDataGridViewTextBoxColumn.DataPropertyName = "NomePessoa";
            this.nomePessoaDataGridViewTextBoxColumn.HeaderText = "Nome Fantasia";
            this.nomePessoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomePessoaDataGridViewTextBoxColumn.Name = "nomePessoaDataGridViewTextBoxColumn";
            this.nomePessoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "Razao Social";
            this.razaoSocialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            this.razaoSocialDataGridViewTextBoxColumn.Width = 125;
            // 
            // rgIeDataGridViewTextBoxColumn
            // 
            this.rgIeDataGridViewTextBoxColumn.DataPropertyName = "RgIe";
            this.rgIeDataGridViewTextBoxColumn.HeaderText = "IE";
            this.rgIeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rgIeDataGridViewTextBoxColumn.Name = "rgIeDataGridViewTextBoxColumn";
            this.rgIeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpfCnpjDataGridViewTextBoxColumn
            // 
            this.cpfCnpjDataGridViewTextBoxColumn.DataPropertyName = "CpfCnpj";
            this.cpfCnpjDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cpfCnpjDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpfCnpjDataGridViewTextBoxColumn.Name = "cpfCnpjDataGridViewTextBoxColumn";
            this.cpfCnpjDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailPessoaDataGridViewTextBoxColumn
            // 
            this.emailPessoaDataGridViewTextBoxColumn.DataPropertyName = "EmailPessoa";
            this.emailPessoaDataGridViewTextBoxColumn.HeaderText = "Email Empresa";
            this.emailPessoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailPessoaDataGridViewTextBoxColumn.Name = "emailPessoaDataGridViewTextBoxColumn";
            this.emailPessoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // representanteDataGridViewTextBoxColumn
            // 
            this.representanteDataGridViewTextBoxColumn.DataPropertyName = "Representante";
            this.representanteDataGridViewTextBoxColumn.HeaderText = "Representante";
            this.representanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.representanteDataGridViewTextBoxColumn.Name = "representanteDataGridViewTextBoxColumn";
            this.representanteDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonePessoaDataGridViewTextBoxColumn
            // 
            this.telefonePessoaDataGridViewTextBoxColumn.DataPropertyName = "TelefonePessoa";
            this.telefonePessoaDataGridViewTextBoxColumn.HeaderText = "Telefone Empresa";
            this.telefonePessoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonePessoaDataGridViewTextBoxColumn.Name = "telefonePessoaDataGridViewTextBoxColumn";
            this.telefonePessoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // celularRepresentanteDataGridViewTextBoxColumn
            // 
            this.celularRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "CelularRepresentante";
            this.celularRepresentanteDataGridViewTextBoxColumn.HeaderText = "Celular Representante";
            this.celularRepresentanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.celularRepresentanteDataGridViewTextBoxColumn.Name = "celularRepresentanteDataGridViewTextBoxColumn";
            this.celularRepresentanteDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailRepresentanteDataGridViewTextBoxColumn
            // 
            this.emailRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "EmailRepresentante";
            this.emailRepresentanteDataGridViewTextBoxColumn.HeaderText = "Email Representante";
            this.emailRepresentanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailRepresentanteDataGridViewTextBoxColumn.Name = "emailRepresentanteDataGridViewTextBoxColumn";
            this.emailRepresentanteDataGridViewTextBoxColumn.Width = 125;
            // 
            // fornecedorModelBindingSource
            // 
            this.fornecedorModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Fornecedor.Model.FornecedorModel);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleDescription = "Excluir";
            this.btnExcluir.AccessibleName = "";
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::ProjetoDesafio.Properties.Resources.delete__1_;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(197, 14);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 122);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.AccessibleDescription = "Alterar";
            this.btnAlterar.AccessibleName = "Alterar";
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::ProjetoDesafio.Properties.Resources.icons8_editar_vários_64;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(10, 14);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 122);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoDesafio.Properties.Resources.icons8_pesquisar_32;
            this.pictureBox1.Location = new System.Drawing.Point(373, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmListagemDeFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 825);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbRazaoSocial);
            this.Controls.Add(this.rdbRepresentante);
            this.Controls.Add(this.rdbNomeFantasia);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.gpLista);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Name = "FrmListagemDeFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Fornecedor";
            this.gpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListaFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbRazaoSocial;
        private System.Windows.Forms.RadioButton rdbRepresentante;
        private System.Windows.Forms.RadioButton rdbNomeFantasia;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox gpLista;
        private System.Windows.Forms.DataGridView dtListaFornecedor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.BindingSource fornecedorModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgIeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn representanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularRepresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailRepresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}