namespace ProjetoDesafio.Feature.Funcionario.View
{
    partial class FrmListagemDeFuncionarios
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
            this.rdbUsuario = new System.Windows.Forms.RadioButton();
            this.rdbCargo = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gpLista = new System.Windows.Forms.GroupBox();
            this.dtListaFuncionarios = new System.Windows.Forms.DataGridView();
            this.funcionarioModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgIeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbUsuario
            // 
            this.rdbUsuario.AutoSize = true;
            this.rdbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUsuario.Location = new System.Drawing.Point(719, 25);
            this.rdbUsuario.Name = "rdbUsuario";
            this.rdbUsuario.Size = new System.Drawing.Size(100, 29);
            this.rdbUsuario.TabIndex = 11;
            this.rdbUsuario.TabStop = true;
            this.rdbUsuario.Text = "Usuário";
            this.rdbUsuario.UseVisualStyleBackColor = true;
            // 
            // rdbCargo
            // 
            this.rdbCargo.AutoSize = true;
            this.rdbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCargo.Location = new System.Drawing.Point(563, 25);
            this.rdbCargo.Name = "rdbCargo";
            this.rdbCargo.Size = new System.Drawing.Size(87, 29);
            this.rdbCargo.TabIndex = 10;
            this.rdbCargo.TabStop = true;
            this.rdbCargo.Text = "Cargo";
            this.rdbCargo.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNome.Location = new System.Drawing.Point(415, 25);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(90, 29);
            this.rdbNome.TabIndex = 9;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome ";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(406, 80);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(505, 34);
            this.txtPesquisar.TabIndex = 8;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPesquisar_KeyDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::ProjetoDesafio.Properties.Resources.icons8_pesquisar_32;
            this.btnPesquisar.Location = new System.Drawing.Point(354, 77);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(46, 39);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // gpLista
            // 
            this.gpLista.Controls.Add(this.dtListaFuncionarios);
            this.gpLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLista.Location = new System.Drawing.Point(11, 153);
            this.gpLista.Name = "gpLista";
            this.gpLista.Size = new System.Drawing.Size(1380, 599);
            this.gpLista.TabIndex = 15;
            this.gpLista.TabStop = false;
            // 
            // dtListaFuncionarios
            // 
            this.dtListaFuncionarios.AllowUserToAddRows = false;
            this.dtListaFuncionarios.AutoGenerateColumns = false;
            this.dtListaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.nomePessoaDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.rgIeDataGridViewTextBoxColumn,
            this.cpfCnpjDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.emailPessoaDataGridViewTextBoxColumn,
            this.telefonePessoaDataGridViewTextBoxColumn,
            this.usuarioFuncionarioDataGridViewTextBoxColumn,
            this.senhaFuncionarioDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.dtListaFuncionarios.DataSource = this.funcionarioModelBindingSource;
            this.dtListaFuncionarios.Location = new System.Drawing.Point(0, 13);
            this.dtListaFuncionarios.Name = "dtListaFuncionarios";
            this.dtListaFuncionarios.RowHeadersWidth = 51;
            this.dtListaFuncionarios.RowTemplate.Height = 24;
            this.dtListaFuncionarios.Size = new System.Drawing.Size(1380, 580);
            this.dtListaFuncionarios.TabIndex = 0;
            this.dtListaFuncionarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtListagemDeFuncionarios_CellFormatting);
            this.dtListaFuncionarios.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // funcionarioModelBindingSource
            // 
            this.funcionarioModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Funcionario.Model.FuncionarioModel);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleDescription = "Excluir";
            this.btnExcluir.AccessibleName = "";
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::ProjetoDesafio.Properties.Resources.delete__1_;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(198, 12);
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
            this.btnAlterar.Location = new System.Drawing.Point(11, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 122);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "IdFuncionario";
            this.idFuncionarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idFuncionarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            this.idFuncionarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomePessoaDataGridViewTextBoxColumn
            // 
            this.nomePessoaDataGridViewTextBoxColumn.DataPropertyName = "NomePessoa";
            this.nomePessoaDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomePessoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomePessoaDataGridViewTextBoxColumn.Name = "nomePessoaDataGridViewTextBoxColumn";
            this.nomePessoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.Width = 125;
            // 
            // rgIeDataGridViewTextBoxColumn
            // 
            this.rgIeDataGridViewTextBoxColumn.DataPropertyName = "RgIe";
            this.rgIeDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rgIeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rgIeDataGridViewTextBoxColumn.Name = "rgIeDataGridViewTextBoxColumn";
            this.rgIeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpfCnpjDataGridViewTextBoxColumn
            // 
            this.cpfCnpjDataGridViewTextBoxColumn.DataPropertyName = "CpfCnpj";
            this.cpfCnpjDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfCnpjDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpfCnpjDataGridViewTextBoxColumn.Name = "cpfCnpjDataGridViewTextBoxColumn";
            this.cpfCnpjDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailPessoaDataGridViewTextBoxColumn
            // 
            this.emailPessoaDataGridViewTextBoxColumn.DataPropertyName = "EmailPessoa";
            this.emailPessoaDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailPessoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailPessoaDataGridViewTextBoxColumn.Name = "emailPessoaDataGridViewTextBoxColumn";
            this.emailPessoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonePessoaDataGridViewTextBoxColumn
            // 
            this.telefonePessoaDataGridViewTextBoxColumn.DataPropertyName = "TelefonePessoa";
            this.telefonePessoaDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefonePessoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonePessoaDataGridViewTextBoxColumn.Name = "telefonePessoaDataGridViewTextBoxColumn";
            this.telefonePessoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioFuncionarioDataGridViewTextBoxColumn
            // 
            this.usuarioFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "UsuarioFuncionario";
            this.usuarioFuncionarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioFuncionarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuarioFuncionarioDataGridViewTextBoxColumn.Name = "usuarioFuncionarioDataGridViewTextBoxColumn";
            this.usuarioFuncionarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // senhaFuncionarioDataGridViewTextBoxColumn
            // 
            this.senhaFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "SenhaFuncionario";
            this.senhaFuncionarioDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaFuncionarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senhaFuncionarioDataGridViewTextBoxColumn.Name = "senhaFuncionarioDataGridViewTextBoxColumn";
            this.senhaFuncionarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo.NomeCargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmListagemDeFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 826);
            this.Controls.Add(this.rdbUsuario);
            this.Controls.Add(this.rdbCargo);
            this.Controls.Add(this.rdbNome);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gpLista);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Name = "FrmListagemDeFuncionarios";
            this.Text = "FrmListagemDeFuncionarios";
            this.gpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListaFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbUsuario;
        private System.Windows.Forms.RadioButton rdbCargo;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gpLista;
        private System.Windows.Forms.DataGridView dtListaFuncionarios;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.BindingSource funcionarioModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgIeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
    }
}