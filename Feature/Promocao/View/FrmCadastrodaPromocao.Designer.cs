namespace ProjetoDesafio.Feature.Promocao.View
{
    partial class FrmCadastroDaPromocao
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
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomePromoção = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.rdValor = new System.Windows.Forms.RadioButton();
            this.rdPorcentagem = new System.Windows.Forms.RadioButton();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.dtgProdutosPromocao = new System.Windows.Forms.DataGridView();
            this.PrecoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInserirProdutos = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblAcima = new System.Windows.Forms.Label();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtInicio
            // 
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(238, 170);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(151, 30);
            this.dtInicio.TabIndex = 4;
            // 
            // dtFim
            // 
            this.dtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(461, 170);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(151, 30);
            this.dtFim.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(188, 122);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(424, 30);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtNomePromoção
            // 
            this.txtNomePromoção.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePromoção.Location = new System.Drawing.Point(188, 75);
            this.txtNomePromoção.MaxLength = 100;
            this.txtNomePromoção.Name = "txtNomePromoção";
            this.txtNomePromoção.Size = new System.Drawing.Size(424, 30);
            this.txtNomePromoção.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "até";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(183, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "de";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Período";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Desconto Percentual/ Valor atribuído",
            "Acima de  X em compras, ganhe Y em desconto",
            "Leve X, pague Y"});
            this.cmbTipo.Location = new System.Drawing.Point(188, 26);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(424, 33);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedValueChanged += new System.EventHandler(this.CmbTipo_SelectedValueChanged);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesconto.Location = new System.Drawing.Point(23, 221);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(95, 25);
            this.lblDesconto.TabIndex = 34;
            this.lblDesconto.Text = "Desconto";
            // 
            // rdValor
            // 
            this.rdValor.AutoSize = true;
            this.rdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdValor.Location = new System.Drawing.Point(330, 218);
            this.rdValor.Name = "rdValor";
            this.rdValor.Size = new System.Drawing.Size(57, 29);
            this.rdValor.TabIndex = 6;
            this.rdValor.TabStop = true;
            this.rdValor.Text = "R$";
            this.rdValor.UseVisualStyleBackColor = true;
            // 
            // rdPorcentagem
            // 
            this.rdPorcentagem.AutoSize = true;
            this.rdPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdPorcentagem.Location = new System.Drawing.Point(188, 218);
            this.rdPorcentagem.Name = "rdPorcentagem";
            this.rdPorcentagem.Size = new System.Drawing.Size(51, 29);
            this.rdPorcentagem.TabIndex = 5;
            this.rdPorcentagem.TabStop = true;
            this.rdPorcentagem.Text = "%";
            this.rdPorcentagem.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDesconto.Location = new System.Drawing.Point(461, 217);
            this.txtDesconto.MaxLength = 12;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(151, 30);
            this.txtDesconto.TabIndex = 7;
            this.txtDesconto.TextChanged += new System.EventHandler(this.TxtDesconto_TextChanged);
            // 
            // dtgProdutosPromocao
            // 
            this.dtgProdutosPromocao.AutoGenerateColumns = false;
            this.dtgProdutosPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutosPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.PrecoCompra,
            this.precoVendaDataGridViewTextBoxColumn,
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn});
            this.dtgProdutosPromocao.DataSource = this.produtoModelBindingSource;
            this.dtgProdutosPromocao.Location = new System.Drawing.Point(28, 332);
            this.dtgProdutosPromocao.Name = "dtgProdutosPromocao";
            this.dtgProdutosPromocao.RowHeadersWidth = 51;
            this.dtgProdutosPromocao.RowTemplate.Height = 24;
            this.dtgProdutosPromocao.Size = new System.Drawing.Size(584, 372);
            this.dtgProdutosPromocao.TabIndex = 37;
            // 
            // PrecoCompra
            // 
            this.PrecoCompra.DataPropertyName = "PrecoCompra";
            this.PrecoCompra.HeaderText = "Preco Compra";
            this.PrecoCompra.MinimumWidth = 6;
            this.PrecoCompra.Name = "PrecoCompra";
            this.PrecoCompra.Width = 125;
            // 
            // btnInserirProdutos
            // 
            this.btnInserirProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirProdutos.Image = global::ProjetoDesafio.Properties.Resources.icons8_soma_16;
            this.btnInserirProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirProdutos.Location = new System.Drawing.Point(411, 266);
            this.btnInserirProdutos.Name = "btnInserirProdutos";
            this.btnInserirProdutos.Size = new System.Drawing.Size(201, 39);
            this.btnInserirProdutos.TabIndex = 8;
            this.btnInserirProdutos.Text = "Inserir Produtos";
            this.btnInserirProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirProdutos.UseVisualStyleBackColor = true;
            this.btnInserirProdutos.Click += new System.EventHandler(this.BtnInserirProdutos_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSalvar.Image = global::ProjetoDesafio.Properties.Resources.check1;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(238, 738);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(165, 54);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancelar.Image = global::ProjetoDesafio.Properties.Resources.clear;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(447, 738);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 54);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(25, 273);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 25);
            this.lblStatus.TabIndex = 39;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbStatus.Location = new System.Drawing.Point(186, 270);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(201, 33);
            this.cmbStatus.TabIndex = 40;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(186, 218);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(426, 30);
            this.txtValor.TabIndex = 41;
            this.txtValor.Visible = false;
            // 
            // lblAcima
            // 
            this.lblAcima.AutoSize = true;
            this.lblAcima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcima.Location = new System.Drawing.Point(25, 220);
            this.lblAcima.Name = "lblAcima";
            this.lblAcima.Size = new System.Drawing.Size(94, 25);
            this.lblAcima.TabIndex = 42;
            this.lblAcima.Text = "Acima de";
            this.lblAcima.Visible = false;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Cod";
            this.idProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "PrecoVenda";
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "Preço Venda";
            this.precoVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            this.precoVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoDeVendaComDescontoDataGridViewTextBoxColumn
            // 
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn.DataPropertyName = "PrecoDeVendaComDesconto";
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn.HeaderText = "Preço Desconto";
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn.Name = "precoDeVendaComDescontoDataGridViewTextBoxColumn";
            this.precoDeVendaComDescontoDataGridViewTextBoxColumn.Width = 125;
            // 
            // produtoModelBindingSource
            // 
            this.produtoModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Produto.Model.ProdutoModel);
            // 
            // FrmCadastroDaPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 922);
            this.Controls.Add(this.lblAcima);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnInserirProdutos);
            this.Controls.Add(this.dtgProdutosPromocao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.rdValor);
            this.Controls.Add(this.rdPorcentagem);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomePromoção);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "FrmCadastroDaPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro da Promoção";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNomePromoção;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.RadioButton rdValor;
        private System.Windows.Forms.RadioButton rdPorcentagem;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dtgProdutosPromocao;
        private System.Windows.Forms.BindingSource produtoModelBindingSource;
        private System.Windows.Forms.Button btnInserirProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDeVendaComDescontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblAcima;
    }
}