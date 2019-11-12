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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.txtNomePromoção = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.rdValor = new System.Windows.Forms.RadioButton();
            this.rdPorcentagem = new System.Windows.Forms.RadioButton();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.dtgProdutosPromocao = new System.Windows.Forms.DataGridView();
            this.btnInserirProdutos = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpProdutos = new System.Windows.Forms.GroupBox();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDeVendaComDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosPromocao)).BeginInit();
            this.gpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtInicio
            // 
            this.dtInicio.Enabled = false;
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(185, 595);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(151, 30);
            this.dtInicio.TabIndex = 6;
            // 
            // dtFim
            // 
            this.dtFim.Enabled = false;
            this.dtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(408, 595);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(151, 30);
            this.dtFim.TabIndex = 7;
            // 
            // txtNomePromoção
            // 
            this.txtNomePromoção.Enabled = false;
            this.txtNomePromoção.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePromoção.Location = new System.Drawing.Point(875, 24);
            this.txtNomePromoção.MaxLength = 100;
            this.txtNomePromoção.Name = "txtNomePromoção";
            this.txtNomePromoção.Size = new System.Drawing.Size(424, 30);
            this.txtNomePromoção.TabIndex = 1;
            this.txtNomePromoção.TextChanged += new System.EventHandler(this.TxtNomePromoção_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "até";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "de";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Período";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(711, 29);
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
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Desconto ",
            "Acima de  X em compras, ganhe Y em desconto",
            "Leve X, pague Y"});
            this.cmbTipo.Location = new System.Drawing.Point(188, 26);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(424, 33);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.CmbTipo_SelectedIndexChanged);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesconto.Location = new System.Drawing.Point(711, 101);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(95, 25);
            this.lblDesconto.TabIndex = 34;
            this.lblDesconto.Text = "Desconto";
            // 
            // rdValor
            // 
            this.rdValor.AutoSize = true;
            this.rdValor.Enabled = false;
            this.rdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rdValor.Location = new System.Drawing.Point(1017, 99);
            this.rdValor.Name = "rdValor";
            this.rdValor.Size = new System.Drawing.Size(59, 29);
            this.rdValor.TabIndex = 4;
            this.rdValor.TabStop = true;
            this.rdValor.Text = "R$";
            this.rdValor.UseVisualStyleBackColor = true;
            // 
            // rdPorcentagem
            // 
            this.rdPorcentagem.AutoSize = true;
            this.rdPorcentagem.Enabled = false;
            this.rdPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rdPorcentagem.Location = new System.Drawing.Point(875, 99);
            this.rdPorcentagem.Name = "rdPorcentagem";
            this.rdPorcentagem.Size = new System.Drawing.Size(52, 29);
            this.rdPorcentagem.TabIndex = 3;
            this.rdPorcentagem.TabStop = true;
            this.rdPorcentagem.Text = "%";
            this.rdPorcentagem.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDesconto.Location = new System.Drawing.Point(1148, 98);
            this.txtDesconto.MaxLength = 12;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(151, 30);
            this.txtDesconto.TabIndex = 5;
            this.txtDesconto.TextChanged += new System.EventHandler(this.TxtDesconto_TextChanged);
            // 
            // dtgProdutosPromocao
            // 
            this.dtgProdutosPromocao.AutoGenerateColumns = false;
            this.dtgProdutosPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutosPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoBarras,
            this.nomeProduto,
            this.precoCompra,
            this.precoVenda,
            this.precoDeVendaComDesconto});
            this.dtgProdutosPromocao.DataSource = this.produtoModelBindingSource1;
            this.dtgProdutosPromocao.Location = new System.Drawing.Point(1, 12);
            this.dtgProdutosPromocao.Name = "dtgProdutosPromocao";
            this.dtgProdutosPromocao.RowHeadersWidth = 51;
            this.dtgProdutosPromocao.RowTemplate.Height = 24;
            this.dtgProdutosPromocao.Size = new System.Drawing.Size(1270, 398);
            this.dtgProdutosPromocao.TabIndex = 37;
            this.dtgProdutosPromocao.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DtgProdutosPromocao_CellPainting);
            // 
            // btnInserirProdutos
            // 
            this.btnInserirProdutos.Enabled = false;
            this.btnInserirProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirProdutos.Image = global::ProjetoDesafio.Properties.Resources.add_24;
            this.btnInserirProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirProdutos.Location = new System.Drawing.Point(29, 99);
            this.btnInserirProdutos.Name = "btnInserirProdutos";
            this.btnInserirProdutos.Size = new System.Drawing.Size(206, 39);
            this.btnInserirProdutos.TabIndex = 2;
            this.btnInserirProdutos.Text = "Inserir produtos";
            this.btnInserirProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirProdutos.UseVisualStyleBackColor = true;
            this.btnInserirProdutos.Click += new System.EventHandler(this.BtnInserirProdutos_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(788, 674);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(165, 54);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
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
            this.btnCancelar.Location = new System.Drawing.Point(1134, 674);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 54);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // gpProdutos
            // 
            this.gpProdutos.Controls.Add(this.dtgProdutosPromocao);
            this.gpProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpProdutos.Location = new System.Drawing.Point(28, 144);
            this.gpProdutos.Name = "gpProdutos";
            this.gpProdutos.Size = new System.Drawing.Size(1271, 414);
            this.gpProdutos.TabIndex = 43;
            this.gpProdutos.TabStop = false;
            // 
            // codigoBarras
            // 
            this.codigoBarras.DataPropertyName = "CodigoBarras";
            this.codigoBarras.HeaderText = "Código de barras";
            this.codigoBarras.MinimumWidth = 6;
            this.codigoBarras.Name = "codigoBarras";
            this.codigoBarras.Width = 150;
            // 
            // nomeProduto
            // 
            this.nomeProduto.DataPropertyName = "NomeProduto";
            this.nomeProduto.HeaderText = "Produto";
            this.nomeProduto.MinimumWidth = 6;
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Width = 300;
            // 
            // precoCompra
            // 
            this.precoCompra.DataPropertyName = "PrecoCompra";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precoCompra.DefaultCellStyle = dataGridViewCellStyle1;
            this.precoCompra.HeaderText = "Preço de compra";
            this.precoCompra.MinimumWidth = 6;
            this.precoCompra.Name = "precoCompra";
            this.precoCompra.Width = 150;
            // 
            // precoVenda
            // 
            this.precoVenda.DataPropertyName = "PrecoVenda";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.precoVenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.precoVenda.HeaderText = "Preço de venda";
            this.precoVenda.MinimumWidth = 6;
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.Width = 150;
            // 
            // precoDeVendaComDesconto
            // 
            this.precoDeVendaComDesconto.DataPropertyName = "PrecoDeVendaComDesconto";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.precoDeVendaComDesconto.DefaultCellStyle = dataGridViewCellStyle3;
            this.precoDeVendaComDesconto.HeaderText = "Preço com desconto";
            this.precoDeVendaComDesconto.MinimumWidth = 6;
            this.precoDeVendaComDesconto.Name = "precoDeVendaComDesconto";
            this.precoDeVendaComDesconto.Width = 150;
            // 
            // produtoModelBindingSource1
            // 
            this.produtoModelBindingSource1.DataSource = typeof(ProjetoDesafio.Feature.Produto.Model.ProdutoModel);
            // 
            // produtoModelBindingSource
            // 
            this.produtoModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Produto.Model.ProdutoModel);
            // 
            // FrmCadastroDaPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 763);
            this.Controls.Add(this.gpProdutos);
            this.Controls.Add(this.btnInserirProdutos);
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
            this.Controls.Add(this.txtNomePromoção);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "FrmCadastroDaPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro ";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosPromocao)).EndInit();
            this.gpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.TextBox txtNomePromoção;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.BindingSource produtoModelBindingSource1;
        private System.Windows.Forms.GroupBox gpProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDeVendaComDesconto;
    }
}