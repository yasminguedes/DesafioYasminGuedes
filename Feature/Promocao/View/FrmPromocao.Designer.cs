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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPromocao));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Nome da Promoção", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Tipo", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Status", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Nome da Promoção", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Tipo", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Status", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.InfoText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Nome da Promoção", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Tipo", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Status", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpPromocoes = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstStatus = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNome = new System.Windows.Forms.ListView();
            this.clNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTipo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpPromocoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleDescription = "Cancelar";
            this.btnCancelar.AccessibleName = "Cancelar";
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Location = new System.Drawing.Point(36, 601);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(221, 54);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // gpPromocoes
            // 
            this.gpPromocoes.Controls.Add(this.btnNovo);
            this.gpPromocoes.Controls.Add(this.groupBox1);
            this.gpPromocoes.Controls.Add(this.btnEditar);
            this.gpPromocoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPromocoes.Location = new System.Drawing.Point(36, 39);
            this.gpPromocoes.Name = "gpPromocoes";
            this.gpPromocoes.Size = new System.Drawing.Size(761, 541);
            this.gpPromocoes.TabIndex = 16;
            this.gpPromocoes.TabStop = false;
            this.gpPromocoes.Text = "Promoções Cadastradas";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(646, 37);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 73);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstStatus);
            this.groupBox1.Controls.Add(this.lstNome);
            this.groupBox1.Controls.Add(this.lstTipo);
            this.groupBox1.Location = new System.Drawing.Point(22, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 380);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lstStatus
            // 
            this.lstStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            listViewGroup1.Header = "Nome da Promoção";
            listViewGroup1.Name = "lstNome";
            listViewGroup2.Header = "Tipo";
            listViewGroup2.Name = "lstTipo";
            listViewGroup3.Header = "Status";
            listViewGroup3.Name = "lstStatus";
            this.lstStatus.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.lstStatus.HideSelection = false;
            listViewItem1.Group = listViewGroup3;
            this.lstStatus.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstStatus.Location = new System.Drawing.Point(589, 0);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(124, 380);
            this.lstStatus.TabIndex = 4;
            this.lstStatus.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nome da Promoção";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            // 
            // lstNome
            // 
            this.lstNome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNome,
            this.clTipo,
            this.clStatus});
            this.lstNome.GridLines = true;
            listViewGroup4.Header = "Nome da Promoção";
            listViewGroup4.Name = "lstNome";
            listViewGroup5.Header = "Tipo";
            listViewGroup5.Name = "lstTipo";
            listViewGroup6.Header = "Status";
            listViewGroup6.Name = "lstStatus";
            this.lstNome.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.lstNome.HideSelection = false;
            listViewItem2.Group = listViewGroup4;
            listViewItem2.UseItemStyleForSubItems = false;
            this.lstNome.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lstNome.Location = new System.Drawing.Point(0, 0);
            this.lstNome.Name = "lstNome";
            this.lstNome.Size = new System.Drawing.Size(435, 380);
            this.lstNome.TabIndex = 2;
            this.lstNome.UseCompatibleStateImageBehavior = false;
            // 
            // clNome
            // 
            this.clNome.Text = "Nome da Promoção";
            this.clNome.Width = 100;
            // 
            // clTipo
            // 
            this.clTipo.Text = "Tipo";
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            // 
            // lstTipo
            // 
            this.lstTipo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            listViewGroup7.Header = "Nome da Promoção";
            listViewGroup7.Name = "lstNome";
            listViewGroup8.Header = "Tipo";
            listViewGroup8.Name = "lstTipo";
            listViewGroup9.Header = "Status";
            listViewGroup9.Name = "lstStatus";
            this.lstTipo.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7,
            listViewGroup8,
            listViewGroup9});
            this.lstTipo.HideSelection = false;
            listViewItem3.Group = listViewGroup8;
            this.lstTipo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lstTipo.Location = new System.Drawing.Point(434, 0);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(155, 380);
            this.lstTipo.TabIndex = 3;
            this.lstTipo.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome da Promoção";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(536, 37);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 73);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 723);
            this.Controls.Add(this.gpPromocoes);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.Name = "FrmPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promoção";
            this.gpPromocoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpPromocoes;
        private System.Windows.Forms.ListView lstStatus;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lstTipo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstNome;
        private System.Windows.Forms.ColumnHeader clNome;
        private System.Windows.Forms.ColumnHeader clTipo;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}