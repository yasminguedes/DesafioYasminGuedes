namespace ProjetoDesafio.Feature.Promocao.View.TelaPromocao
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
            this.gpPromocoes = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpPromocoesCadastradas = new System.Windows.Forms.GroupBox();
            this.dtgPromocao = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.NomePromocao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpPromocoes.SuspendLayout();
            this.gpPromocoesCadastradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromocao)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPromocoes
            // 
            this.gpPromocoes.Controls.Add(this.btnNovo);
            this.gpPromocoes.Controls.Add(this.gpPromocoesCadastradas);
            this.gpPromocoes.Controls.Add(this.btnEditar);
            this.gpPromocoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPromocoes.Location = new System.Drawing.Point(42, 67);
            this.gpPromocoes.Name = "gpPromocoes";
            this.gpPromocoes.Size = new System.Drawing.Size(1166, 574);
            this.gpPromocoes.TabIndex = 18;
            this.gpPromocoes.TabStop = false;
            this.gpPromocoes.Text = "Promoções Cadastradas";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::ProjetoDesafio.Properties.Resources.icons8_adicionar_arquivo_32;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(1053, 55);
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
            this.gpPromocoesCadastradas.Location = new System.Drawing.Point(22, 134);
            this.gpPromocoesCadastradas.Name = "gpPromocoesCadastradas";
            this.gpPromocoesCadastradas.Size = new System.Drawing.Size(1121, 380);
            this.gpPromocoesCadastradas.TabIndex = 17;
            this.gpPromocoesCadastradas.TabStop = false;
            // 
            // dtgPromocao
            // 
            this.dtgPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomePromocao,
            this.Descricao,
            this.Tipo,
            this.Validade,
            this.Status});
            this.dtgPromocao.Location = new System.Drawing.Point(0, 20);
            this.dtgPromocao.Name = "dtgPromocao";
            this.dtgPromocao.RowHeadersWidth = 51;
            this.dtgPromocao.RowTemplate.Height = 24;
            this.dtgPromocao.Size = new System.Drawing.Size(1115, 360);
            this.dtgPromocao.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::ProjetoDesafio.Properties.Resources.icons8_crie_um_novo_32;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(934, 55);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 73);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleDescription = "Cancelar";
            this.btnCancelar.AccessibleName = "Cancelar";
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.Location = new System.Drawing.Point(958, 668);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(221, 54);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // NomePromocao
            // 
            this.NomePromocao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomePromocao.HeaderText = "Nome da Promoção";
            this.NomePromocao.MinimumWidth = 6;
            this.NomePromocao.Name = "NomePromocao";
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Validade
            // 
            this.Validade.HeaderText = "Validade";
            this.Validade.MinimumWidth = 6;
            this.Validade.Name = "Validade";
            this.Validade.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // FrmPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 751);
            this.Controls.Add(this.gpPromocoes);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.Name = "FrmPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promoção";
            this.gpPromocoes.ResumeLayout(false);
            this.gpPromocoesCadastradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromocao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPromocoes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpPromocoesCadastradas;
        private System.Windows.Forms.DataGridView dtgPromocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePromocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}