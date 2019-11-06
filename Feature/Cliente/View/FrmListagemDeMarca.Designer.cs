namespace ProjetoDesafio.Feature.Cliente.View
{
    partial class FrmListagemDeMarca
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
            this.dtListaMarca = new System.Windows.Forms.DataGridView();
            this.idMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListaMarca
            // 
            this.dtListaMarca.AutoGenerateColumns = false;
            this.dtListaMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarcaDataGridViewTextBoxColumn,
            this.nomeMarcaDataGridViewTextBoxColumn});
            this.dtListaMarca.DataSource = this.marcaModelBindingSource;
            this.dtListaMarca.Location = new System.Drawing.Point(46, 231);
            this.dtListaMarca.Name = "dtListaMarca";
            this.dtListaMarca.RowHeadersWidth = 51;
            this.dtListaMarca.RowTemplate.Height = 24;
            this.dtListaMarca.Size = new System.Drawing.Size(583, 410);
            this.dtListaMarca.TabIndex = 26;
            this.dtListaMarca.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtListaMarca_CellFormatting);
            // 
            // idMarcaDataGridViewTextBoxColumn
            // 
            this.idMarcaDataGridViewTextBoxColumn.DataPropertyName = "IdMarca";
            this.idMarcaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idMarcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMarcaDataGridViewTextBoxColumn.Name = "idMarcaDataGridViewTextBoxColumn";
            this.idMarcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeMarcaDataGridViewTextBoxColumn
            // 
            this.nomeMarcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeMarcaDataGridViewTextBoxColumn.DataPropertyName = "NomeMarca";
            this.nomeMarcaDataGridViewTextBoxColumn.HeaderText = "Nome da Marca";
            this.nomeMarcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeMarcaDataGridViewTextBoxColumn.Name = "nomeMarcaDataGridViewTextBoxColumn";
            // 
            // marcaModelBindingSource
            // 
            this.marcaModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Marca.Model.MarcaModel);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleDescription = "Excluir";
            this.btnExcluir.AccessibleName = "";
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::ProjetoDesafio.Properties.Resources.delete__1_;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(233, 20);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 122);
            this.btnExcluir.TabIndex = 25;
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
            this.btnAlterar.Location = new System.Drawing.Point(46, 20);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 122);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // FrmListagemDeMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 683);
            this.Controls.Add(this.dtListaMarca);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Name = "FrmListagemDeMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListagemDeMarca";
            ((System.ComponentModel.ISupportInitialize)(this.dtListaMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListaMarca;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.BindingSource marcaModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeMarcaDataGridViewTextBoxColumn;
    }
}