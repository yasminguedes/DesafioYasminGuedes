namespace ProjetoDesafio.Feature.Cargo.View
{
    partial class FrmListagemDeCargo
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
            this.dtListaCargos = new System.Windows.Forms.DataGridView();
            this.idCargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListaCargos
            // 
            this.dtListaCargos.AutoGenerateColumns = false;
            this.dtListaCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCargoDataGridViewTextBoxColumn,
            this.nomeCargoDataGridViewTextBoxColumn});
            this.dtListaCargos.DataSource = this.cargoModelBindingSource;
            this.dtListaCargos.Location = new System.Drawing.Point(48, 242);
            this.dtListaCargos.Name = "dtListaCargos";
            this.dtListaCargos.RowHeadersWidth = 51;
            this.dtListaCargos.RowTemplate.Height = 24;
            this.dtListaCargos.Size = new System.Drawing.Size(562, 410);
            this.dtListaCargos.TabIndex = 20;
            this.dtListaCargos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtListaCargos_CellFormatting);
            // 
            // idCargoDataGridViewTextBoxColumn
            // 
            this.idCargoDataGridViewTextBoxColumn.DataPropertyName = "IdCargo";
            this.idCargoDataGridViewTextBoxColumn.Frozen = true;
            this.idCargoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idCargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCargoDataGridViewTextBoxColumn.Name = "idCargoDataGridViewTextBoxColumn";
            this.idCargoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeCargoDataGridViewTextBoxColumn
            // 
            this.nomeCargoDataGridViewTextBoxColumn.DataPropertyName = "NomeCargo";
            this.nomeCargoDataGridViewTextBoxColumn.Frozen = true;
            this.nomeCargoDataGridViewTextBoxColumn.HeaderText = "Nome do Cargo";
            this.nomeCargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeCargoDataGridViewTextBoxColumn.Name = "nomeCargoDataGridViewTextBoxColumn";
            this.nomeCargoDataGridViewTextBoxColumn.Width = 674;
            // 
            // cargoModelBindingSource
            // 
            this.cargoModelBindingSource.DataSource = typeof(ProjetoDesafio.Feature.Cargo.Model.CargoModel);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleDescription = "Excluir";
            this.btnExcluir.AccessibleName = "";
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::ProjetoDesafio.Properties.Resources.delete__1_;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(235, 23);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 122);
            this.btnExcluir.TabIndex = 19;
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
            this.btnAlterar.Location = new System.Drawing.Point(48, 23);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 122);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // FrmListagemDeCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 770);
            this.Controls.Add(this.dtListaCargos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.MaximizeBox = false;
            this.Name = "FrmListagemDeCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Cargos";
            ((System.ComponentModel.ISupportInitialize)(this.dtListaCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dtListaCargos;
        private System.Windows.Forms.BindingSource cargoModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCargoDataGridViewTextBoxColumn;
    }
}