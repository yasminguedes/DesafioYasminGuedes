namespace ProjetoDesafio.Feature.Menu
{
    partial class FrmMenu
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
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnPromocao = new System.Windows.Forms.Button();
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Image = global::ProjetoDesafio.Properties.Resources.warehouse;
            this.btnEstoque.Location = new System.Drawing.Point(1095, 225);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(229, 126);
            this.btnEstoque.TabIndex = 10;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Image = global::ProjetoDesafio.Properties.Resources.icons8_solicitar_dinheiro_64;
            this.btnPedido.Location = new System.Drawing.Point(836, 225);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(229, 126);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.BtnPedido_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Image = global::ProjetoDesafio.Properties.Resources.icons8_grupo_de_usuário_homem_mulher_64;
            this.BtnCliente.Location = new System.Drawing.Point(836, 67);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(229, 126);
            this.BtnCliente.TabIndex = 8;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Image = global::ProjetoDesafio.Properties.Resources.icons8_pacote_64__1_;
            this.btnProduto.Location = new System.Drawing.Point(327, 225);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(229, 126);
            this.btnProduto.TabIndex = 7;
            this.btnProduto.Text = "Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Image = global::ProjetoDesafio.Properties.Resources.icons8_categoria_64__1_;
            this.btnCategoria.Location = new System.Drawing.Point(71, 225);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(229, 126);
            this.btnCategoria.TabIndex = 6;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.Image = global::ProjetoDesafio.Properties.Resources.icons8_marca_registrada_64__1_;
            this.btnMarca.Location = new System.Drawing.Point(1095, 67);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(229, 126);
            this.btnMarca.TabIndex = 5;
            this.btnMarca.Text = "Marca";
            this.btnMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.BtnMarca_Click);
            // 
            // btnPromocao
            // 
            this.btnPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromocao.Image = global::ProjetoDesafio.Properties.Resources.price_tag;
            this.btnPromocao.Location = new System.Drawing.Point(583, 225);
            this.btnPromocao.Name = "btnPromocao";
            this.btnPromocao.Size = new System.Drawing.Size(229, 126);
            this.btnPromocao.TabIndex = 4;
            this.btnPromocao.Text = "Promoção";
            this.btnPromocao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPromocao.UseVisualStyleBackColor = true;
            this.btnPromocao.Click += new System.EventHandler(this.BtnPromocao_Click);
            // 
            // btnCargo
            // 
            this.btnCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargo.Image = global::ProjetoDesafio.Properties.Resources.icons8_funcionário_homem_64;
            this.btnCargo.Location = new System.Drawing.Point(583, 67);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(229, 126);
            this.btnCargo.TabIndex = 2;
            this.btnCargo.Text = "Cargo";
            this.btnCargo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.BtnCargo_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackgroundImage = global::ProjetoDesafio.Properties.Resources.icons8_fornecedor_64__1_;
            this.btnFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFornecedor.Location = new System.Drawing.Point(327, 67);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(229, 126);
            this.btnFornecedor.TabIndex = 1;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.BtnFornecedor_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackgroundImage = global::ProjetoDesafio.Properties.Resources.icons8_gestão_de_desenvolvimento_comercial_64;
            this.btnFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFuncionario.Location = new System.Drawing.Point(71, 67);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(229, 126);
            this.btnFuncionario.TabIndex = 0;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 411);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.btnPromocao);
            this.Controls.Add(this.btnCargo);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnPromocao;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnEstoque;
    }
}