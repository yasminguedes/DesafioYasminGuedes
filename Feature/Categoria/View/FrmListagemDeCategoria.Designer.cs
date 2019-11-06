namespace ProjetoDesafio.Feature.Categoria.View
{
    partial class FrmListagemDeCategoria
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
            this.dtListaCategoria = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.categoriaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListaCategoria
            // 
            this.dtListaCategoria.AutoGenerateColumns = false;
            this.dtListaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn,
            this.nomeCategoriaDataGridViewTextBoxColumn});
            this.dtListaCategoria.DataSource = this.categoriaModelBindingSource1;
            this.dtListaCategoria.Location = new System.Drawing.Point(37, 241);
            this.dtListaCategoria.Name = "dtListaCategoria";
            this.dtListaCategoria.RowHeadersWidth = 51;
            this.dtListaCategoria.RowTemplate.Height = 24;
            this.dtListaCategoria.Size = new System.Drawing.Size(553, 410);
            this.dtListaCategoria.TabIndex = 23;
            this.dtListaCategoria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtListaCategoria_CellFormatting);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleDescription = "Excluir";
            this.btnExcluir.AccessibleName = "";
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::ProjetoDesafio.Properties.Resources.delete__1_;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(224, 30);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 122);
            this.btnExcluir.TabIndex = 22;
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
            this.btnAlterar.Location = new System.Drawing.Point(37, 30);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 122);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // categoriaModelBindingSource
            // 
            this.categoriaModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Categoria.Model.CategoriaModel);
            // 
            // categoriaModelBindingSource1
            // 
            this.categoriaModelBindingSource1.DataSource = typeof(ProjetoDesafio.Feature.Categoria.Model.CategoriaModel);
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idCategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeCategoriaDataGridViewTextBoxColumn
            // 
            this.nomeCategoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeCategoriaDataGridViewTextBoxColumn.DataPropertyName = "NomeCategoria";
            this.nomeCategoriaDataGridViewTextBoxColumn.HeaderText = "Nome da Categoria";
            this.nomeCategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeCategoriaDataGridViewTextBoxColumn.Name = "nomeCategoriaDataGridViewTextBoxColumn";
            // 
            // FrmListagemDeCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 685);
            this.Controls.Add(this.dtListaCategoria);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Name = "FrmListagemDeCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListagemDeCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dtListaCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaModelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListaCategoria;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.BindingSource categoriaModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriaModelBindingSource1;
    }
}