namespace ProjetoDesafio.Feature.Cliente.View
{
    partial class FrmSelecionaCliente
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.clienteModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtListaCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(145, 631);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(126, 35);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(316, 631);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 35);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // clienteModelBindingSource1
            // 
            this.clienteModelBindingSource1.DataSource = typeof(ProjetoDesafio.Feature.Cliente.Model.ClienteModel);
            // 
            // clienteModelBindingSource
            // 
            this.clienteModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Cliente.Model.ClienteModel);
            // 
            // nomePessoaDataGridViewTextBoxColumn
            // 
            this.nomePessoaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomePessoaDataGridViewTextBoxColumn.DataPropertyName = "NomePessoa";
            this.nomePessoaDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomePessoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomePessoaDataGridViewTextBoxColumn.Name = "nomePessoaDataGridViewTextBoxColumn";
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtListaCliente
            // 
            this.dtListaCliente.AutoGenerateColumns = false;
            this.dtListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nomePessoaDataGridViewTextBoxColumn});
            this.dtListaCliente.DataSource = this.clienteModelBindingSource1;
            this.dtListaCliente.Location = new System.Drawing.Point(66, 77);
            this.dtListaCliente.Name = "dtListaCliente";
            this.dtListaCliente.RowHeadersWidth = 51;
            this.dtListaCliente.RowTemplate.Height = 24;
            this.dtListaCliente.Size = new System.Drawing.Size(463, 484);
            this.dtListaCliente.TabIndex = 3;
            // 
            // FrmSelecionaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 690);
            this.Controls.Add(this.dtListaCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.MinimizeBox = false;
            this.Name = "FrmSelecionaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelecionarClientes";
            this.Load += new System.EventHandler(this.FrmSelecionaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clienteModelBindingSource;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource clienteModelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dtListaCliente;
    }
}