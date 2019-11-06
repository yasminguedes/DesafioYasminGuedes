namespace ProjetoDesafio.Feature.Promocao.View
{
    partial class FrmInsereProdutosPromocao
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
            this.rdProduto = new System.Windows.Forms.RadioButton();
            this.rdValidade = new System.Windows.Forms.RadioButton();
            this.rdCategoria = new System.Windows.Forms.RadioButton();
            this.rdMarca = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdPorcentagem = new System.Windows.Forms.RadioButton();
            this.rdValor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgSelecionarProdutos = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecionarProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rdProduto
            // 
            this.rdProduto.AutoSize = true;
            this.rdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdProduto.Location = new System.Drawing.Point(35, 31);
            this.rdProduto.Name = "rdProduto";
            this.rdProduto.Size = new System.Drawing.Size(225, 33);
            this.rdProduto.TabIndex = 0;
            this.rdProduto.TabStop = true;
            this.rdProduto.Text = "Nome do Produto";
            this.rdProduto.UseVisualStyleBackColor = true;
            // 
            // rdValidade
            // 
            this.rdValidade.AutoSize = true;
            this.rdValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdValidade.Location = new System.Drawing.Point(648, 31);
            this.rdValidade.Name = "rdValidade";
            this.rdValidade.Size = new System.Drawing.Size(231, 33);
            this.rdValidade.TabIndex = 1;
            this.rdValidade.TabStop = true;
            this.rdValidade.Text = "Prazo de Validade";
            this.rdValidade.UseVisualStyleBackColor = true;
            // 
            // rdCategoria
            // 
            this.rdCategoria.AutoSize = true;
            this.rdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCategoria.Location = new System.Drawing.Point(467, 31);
            this.rdCategoria.Name = "rdCategoria";
            this.rdCategoria.Size = new System.Drawing.Size(139, 33);
            this.rdCategoria.TabIndex = 2;
            this.rdCategoria.TabStop = true;
            this.rdCategoria.Text = "Categoria";
            this.rdCategoria.UseVisualStyleBackColor = true;
            // 
            // rdMarca
            // 
            this.rdMarca.AutoSize = true;
            this.rdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMarca.Location = new System.Drawing.Point(312, 31);
            this.rdMarca.Name = "rdMarca";
            this.rdMarca.Size = new System.Drawing.Size(100, 33);
            this.rdMarca.TabIndex = 3;
            this.rdMarca.TabStop = true;
            this.rdMarca.Text = "Marca";
            this.rdMarca.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(36, 89);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 34);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox2.Location = new System.Drawing.Point(380, 152);
            this.textBox2.MaxLength = 12;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 34);
            this.textBox2.TabIndex = 6;
            // 
            // rdPorcentagem
            // 
            this.rdPorcentagem.AutoSize = true;
            this.rdPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.rdPorcentagem.Location = new System.Drawing.Point(162, 152);
            this.rdPorcentagem.Name = "rdPorcentagem";
            this.rdPorcentagem.Size = new System.Drawing.Size(57, 33);
            this.rdPorcentagem.TabIndex = 7;
            this.rdPorcentagem.TabStop = true;
            this.rdPorcentagem.Text = "%";
            this.rdPorcentagem.UseVisualStyleBackColor = true;
            // 
            // rdValor
            // 
            this.rdValor.AutoSize = true;
            this.rdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.rdValor.Location = new System.Drawing.Point(262, 152);
            this.rdValor.Name = "rdValor";
            this.rdValor.Size = new System.Drawing.Size(66, 33);
            this.rdValor.TabIndex = 8;
            this.rdValor.TabStop = true;
            this.rdValor.Text = "R$";
            this.rdValor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(31, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desconto";
            // 
            // dtgSelecionarProdutos
            // 
            this.dtgSelecionarProdutos.AutoGenerateColumns = false;
            this.dtgSelecionarProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSelecionarProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.Marca,
            this.Categoria,
            this.dataValidadeDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn,
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn});
            this.dtgSelecionarProdutos.DataSource = this.produtoModelBindingSource2;
            this.dtgSelecionarProdutos.Location = new System.Drawing.Point(25, 230);
            this.dtgSelecionarProdutos.Name = "dtgSelecionarProdutos";
            this.dtgSelecionarProdutos.RowHeadersWidth = 51;
            this.dtgSelecionarProdutos.RowTemplate.Height = 24;
            this.dtgSelecionarProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSelecionarProdutos.Size = new System.Drawing.Size(980, 477);
            this.dtgSelecionarProdutos.TabIndex = 12;
            this.dtgSelecionarProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtSelecionarProdutos_CellFormatting);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVoltar.Image = global::ProjetoDesafio.Properties.Resources.icons8_voltar_32;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(373, 734);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(172, 54);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnProximo.Image = global::ProjetoDesafio.Properties.Resources.icons8_avançar_32;
            this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProximo.Location = new System.Drawing.Point(611, 734);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(172, 54);
            this.btnProximo.TabIndex = 14;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancelar.Image = global::ProjetoDesafio.Properties.Resources.icons8_excluir_32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(839, 734);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 54);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSelecionar.Image = global::ProjetoDesafio.Properties.Resources.icons8_selecionado_32;
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.Location = new System.Drawing.Point(724, 77);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(267, 58);
            this.btnSelecionar.TabIndex = 11;
            this.btnSelecionar.Text = "Selecionar Todos";
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDesmarcar.Image = global::ProjetoDesafio.Properties.Resources.icons8_subtração_32;
            this.btnDesmarcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesmarcar.Location = new System.Drawing.Point(724, 142);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(267, 54);
            this.btnDesmarcar.TabIndex = 10;
            this.btnDesmarcar.Text = "Desmarcar Todos";
            this.btnDesmarcar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoDesafio.Properties.Resources.icons8_pesquisar_32;
            this.pictureBox1.Location = new System.Drawing.Point(611, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Selecionar
            // 
            this.Selecionar.DataPropertyName = "PrecoDeVendaComDesconto";
            this.Selecionar.HeaderText = "Sel.";
            this.Selecionar.MinimumWidth = 6;
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selecionar.Width = 70;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca.NomeMarca";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria.NomeCategoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            this.dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "DataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.HeaderText = "Data Validade";
            this.dataValidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            this.dataValidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "PrecoVenda";
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "Preco Venda";
            this.precoVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            this.precoVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoDeVendaComDescontoDataGridViewTextBoxColumn
            // 
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn.DataPropertyName = "PrecoDeVendaComDesconto";
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn.HeaderText = "Preco Desconto";
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn.Name = "precoDeVendaComDescontoDataGridViewTextBoxColumn";
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn.Width = 150;
            // 
            // produtoModelBindingSource2
            // 
            this.produtoModelBindingSource2.DataSource = typeof(ProjetoDesafio.Feature.Produto.Model.ProdutoModel);
            // 
            // produtoModelBindingSource1
            // 
            this.produtoModelBindingSource1.DataSource = typeof(ProjetoDesafio.Feature.Produto.Model.ProdutoModel);
            // 
            // produtoModelBindingSource
            // 
            this.produtoModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Produto.Model.ProdutoModel);
            // 
            // FrmInsereProdutosPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 835);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgSelecionarProdutos);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdValor);
            this.Controls.Add(this.rdPorcentagem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdMarca);
            this.Controls.Add(this.rdCategoria);
            this.Controls.Add(this.rdValidade);
            this.Controls.Add(this.rdProduto);
            this.MinimizeBox = false;
            this.Name = "FrmInsereProdutosPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Produto na Promoção - Desconto";
            this.Load += new System.EventHandler(this.FrmInsereProdutosPromocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecionarProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdProduto;
        private System.Windows.Forms.RadioButton rdValidade;
        private System.Windows.Forms.RadioButton rdCategoria;
        private System.Windows.Forms.RadioButton rdMarca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdPorcentagem;
        private System.Windows.Forms.RadioButton rdValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.BindingSource produtoModelBindingSource;
        private System.Windows.Forms.BindingSource produtoModelBindingSource1;
        private System.Windows.Forms.DataGridView dtgSelecionarProdutos;
        private System.Windows.Forms.BindingSource produtoModelBindingSource2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDeVendaComDescontoDataGridViewTextBoxColumn;
    }
}