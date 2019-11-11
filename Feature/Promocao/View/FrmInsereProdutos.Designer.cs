namespace ProjetoDesafio.Feature.Promocao.View
{
    partial class FrmInsereProdutos
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
            this.txtProdutos = new System.Windows.Forms.TextBox();
            this.rdMarca = new System.Windows.Forms.RadioButton();
            this.rdCategoria = new System.Windows.Forms.RadioButton();
            this.rdValidade = new System.Windows.Forms.RadioButton();
            this.rdProduto = new System.Windows.Forms.RadioButton();
            this.rdCodigo = new System.Windows.Forms.RadioButton();
            this.dtgListaProdutos = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckbProdutos = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.produtoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProdutos
            // 
            this.txtProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutos.Location = new System.Drawing.Point(50, 110);
            this.txtProdutos.MaxLength = 100;
            this.txtProdutos.Name = "txtProdutos";
            this.txtProdutos.Size = new System.Drawing.Size(569, 30);
            this.txtProdutos.TabIndex = 10;
            this.txtProdutos.TextChanged += new System.EventHandler(this.TxtProdutos_TextChanged);
            // 
            // rdMarca
            // 
            this.rdMarca.AutoSize = true;
            this.rdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMarca.Location = new System.Drawing.Point(179, 53);
            this.rdMarca.Name = "rdMarca";
            this.rdMarca.Size = new System.Drawing.Size(88, 29);
            this.rdMarca.TabIndex = 9;
            this.rdMarca.TabStop = true;
            this.rdMarca.Text = "Marca";
            this.rdMarca.UseVisualStyleBackColor = true;
            // 
            // rdCategoria
            // 
            this.rdCategoria.AutoSize = true;
            this.rdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCategoria.Location = new System.Drawing.Point(298, 53);
            this.rdCategoria.Name = "rdCategoria";
            this.rdCategoria.Size = new System.Drawing.Size(118, 29);
            this.rdCategoria.TabIndex = 8;
            this.rdCategoria.TabStop = true;
            this.rdCategoria.Text = "Categoria";
            this.rdCategoria.UseVisualStyleBackColor = true;
            // 
            // rdValidade
            // 
            this.rdValidade.AutoSize = true;
            this.rdValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdValidade.Location = new System.Drawing.Point(572, 53);
            this.rdValidade.Name = "rdValidade";
            this.rdValidade.Size = new System.Drawing.Size(193, 29);
            this.rdValidade.TabIndex = 7;
            this.rdValidade.TabStop = true;
            this.rdValidade.Text = "Prazo de Validade";
            this.rdValidade.UseVisualStyleBackColor = true;
            // 
            // rdProduto
            // 
            this.rdProduto.AutoSize = true;
            this.rdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdProduto.Location = new System.Drawing.Point(50, 53);
            this.rdProduto.Name = "rdProduto";
            this.rdProduto.Size = new System.Drawing.Size(101, 29);
            this.rdProduto.TabIndex = 6;
            this.rdProduto.TabStop = true;
            this.rdProduto.Text = "Produto";
            this.rdProduto.UseVisualStyleBackColor = true;
            // 
            // rdCodigo
            // 
            this.rdCodigo.AutoSize = true;
            this.rdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCodigo.Location = new System.Drawing.Point(452, 53);
            this.rdCodigo.Name = "rdCodigo";
            this.rdCodigo.Size = new System.Drawing.Size(96, 29);
            this.rdCodigo.TabIndex = 12;
            this.rdCodigo.TabStop = true;
            this.rdCodigo.Text = "Código";
            this.rdCodigo.UseVisualStyleBackColor = true;
            // 
            // dtgListaProdutos
            // 
            this.dtgListaProdutos.AutoGenerateColumns = false;
            this.dtgListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoBarras,
            this.nomeProdutoDataGridViewTextBoxColumn});
            this.dtgListaProdutos.DataSource = this.produtoModelBindingSource;
            this.dtgListaProdutos.Location = new System.Drawing.Point(653, 221);
            this.dtgListaProdutos.Name = "dtgListaProdutos";
            this.dtgListaProdutos.RowHeadersWidth = 51;
            this.dtgListaProdutos.RowTemplate.Height = 24;
            this.dtgListaProdutos.Size = new System.Drawing.Size(584, 412);
            this.dtgListaProdutos.TabIndex = 13;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(820, 657);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(165, 54);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Confirmar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(1072, 657);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 54);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ckbProdutos
            // 
            this.ckbProdutos.FormattingEnabled = true;
            this.ckbProdutos.Location = new System.Drawing.Point(50, 221);
            this.ckbProdutos.Name = "ckbProdutos";
            this.ckbProdutos.Size = new System.Drawing.Size(477, 412);
            this.ckbProdutos.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::ProjetoDesafio.Properties.Resources.add_24;
            this.btnAdd.Location = new System.Drawing.Point(479, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 45);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoDesafio.Properties.Resources.icons8_pesquisar_32;
            this.pictureBox1.Location = new System.Drawing.Point(653, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // produtoModelBindingSource
            // 
            this.produtoModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Produto.Model.ProdutoModel);
            // 
            // frmProdutoBindingSource
            // 
            this.frmProdutoBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Produto.View.FrmProduto);
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.DataPropertyName = "CodigoBarras";
            this.CodigoBarras.HeaderText = "Código de barras";
            this.CodigoBarras.MinimumWidth = 6;
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.Width = 150;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.Width = 330;
            // 
            // FrmInsereProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 723);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ckbProdutos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgListaProdutos);
            this.Controls.Add(this.rdCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtProdutos);
            this.Controls.Add(this.rdMarca);
            this.Controls.Add(this.rdCategoria);
            this.Controls.Add(this.rdValidade);
            this.Controls.Add(this.rdProduto);
            this.MinimizeBox = false;
            this.Name = "FrmInsereProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserção de produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtProdutos;
        private System.Windows.Forms.RadioButton rdMarca;
        private System.Windows.Forms.RadioButton rdCategoria;
        private System.Windows.Forms.RadioButton rdValidade;
        private System.Windows.Forms.RadioButton rdProduto;
        private System.Windows.Forms.RadioButton rdCodigo;
        private System.Windows.Forms.BindingSource frmProdutoBindingSource;
        private System.Windows.Forms.DataGridView dtgListaProdutos;
        private System.Windows.Forms.BindingSource produtoModelBindingSource;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckedListBox ckbProdutos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
    }
}