namespace ProjetoDesafio.Feature.Promocao.View
{
    partial class FrmPromocao
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
            this.gpPromocoes = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpPromocoesCadastradas = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtgPromocao = new System.Windows.Forms.DataGridView();
            this.promocaoModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.promocaoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promocaoModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminoPromocaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpPromocoes.SuspendLayout();
            this.gpPromocoesCadastradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPromocoes
            // 
            this.gpPromocoes.Controls.Add(this.btnNovo);
            this.gpPromocoes.Controls.Add(this.gpPromocoesCadastradas);
            this.gpPromocoes.Controls.Add(this.btnEditar);
            this.gpPromocoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPromocoes.Location = new System.Drawing.Point(36, 39);
            this.gpPromocoes.Name = "gpPromocoes";
            this.gpPromocoes.Size = new System.Drawing.Size(1340, 546);
            this.gpPromocoes.TabIndex = 16;
            this.gpPromocoes.TabStop = false;
            this.gpPromocoes.Text = "Promoções Cadastradas";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::ProjetoDesafio.Properties.Resources.icons8_adicionar_arquivo_32;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(1193, 55);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 73);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // gpPromocoesCadastradas
            // 
            this.gpPromocoesCadastradas.Controls.Add(this.dtgPromocao);
            this.gpPromocoesCadastradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPromocoesCadastradas.Location = new System.Drawing.Point(22, 134);
            this.gpPromocoesCadastradas.Name = "gpPromocoesCadastradas";
            this.gpPromocoesCadastradas.Size = new System.Drawing.Size(1296, 389);
            this.gpPromocoesCadastradas.TabIndex = 17;
            this.gpPromocoesCadastradas.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::ProjetoDesafio.Properties.Resources.icons8_crie_um_novo_32;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(1083, 55);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 73);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // dtgPromocao
            // 
            this.dtgPromocao.AutoGenerateColumns = false;
            this.dtgPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPromocaoDataGridViewTextBoxColumn,
            this.nomePromocaoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.tipoPromocaoDataGridViewTextBoxColumn,
            this.statusPromocaoDataGridViewTextBoxColumn,
            this.inicioPromocaoDataGridViewTextBoxColumn,
            this.terminoPromocaoDataGridViewTextBoxColumn});
            this.dtgPromocao.DataSource = this.promocaoModelBindingSource2;
            this.dtgPromocao.Location = new System.Drawing.Point(0, 0);
            this.dtgPromocao.Name = "dtgPromocao";
            this.dtgPromocao.RowHeadersWidth = 51;
            this.dtgPromocao.RowTemplate.Height = 24;
            this.dtgPromocao.Size = new System.Drawing.Size(1296, 389);
            this.dtgPromocao.TabIndex = 0;
            // 
            // promocaoModelBindingSource1
            // 
            this.promocaoModelBindingSource1.DataSource = typeof(ProjetoDesafio.Feature.Promocao.Model.PromocaoModel);
            // 
            // promocaoModelBindingSource
            // 
            this.promocaoModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Promocao.Model.PromocaoModel);
            // 
            // promocaoModelBindingSource2
            // 
            this.promocaoModelBindingSource2.DataSource = typeof(ProjetoDesafio.Feature.Promocao.Model.PromocaoModel);
            // 
            // idPromocaoDataGridViewTextBoxColumn
            // 
            this.idPromocaoDataGridViewTextBoxColumn.DataPropertyName = "IdPromocao";
            this.idPromocaoDataGridViewTextBoxColumn.HeaderText = "Cod";
            this.idPromocaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPromocaoDataGridViewTextBoxColumn.Name = "idPromocaoDataGridViewTextBoxColumn";
            this.idPromocaoDataGridViewTextBoxColumn.Width = 40;
            // 
            // nomePromocaoDataGridViewTextBoxColumn
            // 
            this.nomePromocaoDataGridViewTextBoxColumn.DataPropertyName = "NomePromocao";
            this.nomePromocaoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomePromocaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomePromocaoDataGridViewTextBoxColumn.Name = "nomePromocaoDataGridViewTextBoxColumn";
            this.nomePromocaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricão";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // tipoPromocaoDataGridViewTextBoxColumn
            // 
            this.tipoPromocaoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoPromocaoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoPromocaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoPromocaoDataGridViewTextBoxColumn.Name = "tipoPromocaoDataGridViewTextBoxColumn";
            this.tipoPromocaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusPromocaoDataGridViewTextBoxColumn
            // 
            this.statusPromocaoDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusPromocaoDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusPromocaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusPromocaoDataGridViewTextBoxColumn.Name = "statusPromocaoDataGridViewTextBoxColumn";
            // 
            // inicioPromocaoDataGridViewTextBoxColumn
            // 
            this.inicioPromocaoDataGridViewTextBoxColumn.DataPropertyName = "InicioPromocao";
            this.inicioPromocaoDataGridViewTextBoxColumn.HeaderText = "Vigência - Início";
            this.inicioPromocaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inicioPromocaoDataGridViewTextBoxColumn.Name = "inicioPromocaoDataGridViewTextBoxColumn";
            // 
            // terminoPromocaoDataGridViewTextBoxColumn
            // 
            this.terminoPromocaoDataGridViewTextBoxColumn.DataPropertyName = "TerminoPromocao";
            this.terminoPromocaoDataGridViewTextBoxColumn.HeaderText = "Vigência - Término";
            this.terminoPromocaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminoPromocaoDataGridViewTextBoxColumn.Name = "terminoPromocaoDataGridViewTextBoxColumn";
            this.terminoPromocaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 614);
            this.Controls.Add(this.gpPromocoes);
            this.MaximizeBox = false;
            this.Name = "FrmPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promoção";
            this.gpPromocoes.ResumeLayout(false);
            this.gpPromocoesCadastradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promocaoModelBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpPromocoes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gpPromocoesCadastradas;
        private System.Windows.Forms.BindingSource promocaoModelBindingSource;
        private System.Windows.Forms.BindingSource promocaoModelBindingSource1;
        private System.Windows.Forms.DataGridView dtgPromocao;
        private System.Windows.Forms.BindingSource promocaoModelBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPromocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePromocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPromocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPromocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioPromocaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminoPromocaoDataGridViewTextBoxColumn;
    }
}