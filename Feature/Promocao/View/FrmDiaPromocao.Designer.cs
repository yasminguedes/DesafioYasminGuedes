namespace ProjetoDesafio.Feature.Promocao.View
{
    partial class FrmDiaPromocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiaPromocao));
            this.gpDia = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dtHoraTermino = new System.Windows.Forms.DateTimePicker();
            this.dtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.gpAdicionados = new System.Windows.Forms.GroupBox();
            this.dtgDiasAdicionados = new System.Windows.Forms.DataGridView();
            this.DiaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDiaTermino = new System.Windows.Forms.DateTimePicker();
            this.dtDiaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraTérmino = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblDiaFim = new System.Windows.Forms.Label();
            this.lblDiaInicio = new System.Windows.Forms.Label();
            this.cmbDiaSemana = new System.Windows.Forms.ComboBox();
            this.lblDiadaSemana = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpDia.SuspendLayout();
            this.gpAdicionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiasAdicionados)).BeginInit();
            this.SuspendLayout();
            // 
            // gpDia
            // 
            this.gpDia.Controls.Add(this.btnExcluir);
            this.gpDia.Controls.Add(this.btnAdicionar);
            this.gpDia.Controls.Add(this.dtHoraTermino);
            this.gpDia.Controls.Add(this.dtHoraInicio);
            this.gpDia.Controls.Add(this.gpAdicionados);
            this.gpDia.Controls.Add(this.dtDiaTermino);
            this.gpDia.Controls.Add(this.dtDiaInicio);
            this.gpDia.Controls.Add(this.lblHoraTérmino);
            this.gpDia.Controls.Add(this.lblHoraInicio);
            this.gpDia.Controls.Add(this.lblDiaFim);
            this.gpDia.Controls.Add(this.lblDiaInicio);
            this.gpDia.Controls.Add(this.cmbDiaSemana);
            this.gpDia.Controls.Add(this.lblDiadaSemana);
            this.gpDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDia.Location = new System.Drawing.Point(12, 33);
            this.gpDia.Name = "gpDia";
            this.gpDia.Size = new System.Drawing.Size(1011, 653);
            this.gpDia.TabIndex = 0;
            this.gpDia.TabStop = false;
            this.gpDia.Text = "Adicionar Dia";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(760, 29);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 73);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(554, 29);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 73);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // dtHoraTermino
            // 
            this.dtHoraTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraTermino.Location = new System.Drawing.Point(760, 211);
            this.dtHoraTermino.Name = "dtHoraTermino";
            this.dtHoraTermino.ShowUpDown = true;
            this.dtHoraTermino.Size = new System.Drawing.Size(115, 30);
            this.dtHoraTermino.TabIndex = 12;
            this.dtHoraTermino.Value = new System.DateTime(2019, 10, 25, 20, 54, 0, 0);
            // 
            // dtHoraInicio
            // 
            this.dtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraInicio.Location = new System.Drawing.Point(760, 123);
            this.dtHoraInicio.Name = "dtHoraInicio";
            this.dtHoraInicio.ShowUpDown = true;
            this.dtHoraInicio.Size = new System.Drawing.Size(115, 30);
            this.dtHoraInicio.TabIndex = 11;
            this.dtHoraInicio.Value = new System.DateTime(2019, 10, 25, 11, 4, 15, 0);
            // 
            // gpAdicionados
            // 
            this.gpAdicionados.Controls.Add(this.dtgDiasAdicionados);
            this.gpAdicionados.Location = new System.Drawing.Point(6, 288);
            this.gpAdicionados.Name = "gpAdicionados";
            this.gpAdicionados.Size = new System.Drawing.Size(1004, 366);
            this.gpAdicionados.TabIndex = 10;
            this.gpAdicionados.TabStop = false;
            this.gpAdicionados.Text = "Dias Adicionados";
            // 
            // dtgDiasAdicionados
            // 
            this.dtgDiasAdicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiasAdicionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiaSemana,
            this.DataInicio,
            this.DataTermino,
            this.HoraInicio,
            this.HoraFim});
            this.dtgDiasAdicionados.Location = new System.Drawing.Point(7, 30);
            this.dtgDiasAdicionados.Name = "dtgDiasAdicionados";
            this.dtgDiasAdicionados.RowHeadersWidth = 51;
            this.dtgDiasAdicionados.RowTemplate.Height = 24;
            this.dtgDiasAdicionados.Size = new System.Drawing.Size(997, 330);
            this.dtgDiasAdicionados.TabIndex = 0;
            // 
            // DiaSemana
            // 
            this.DiaSemana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaSemana.HeaderText = "Dia da Semana";
            this.DiaSemana.MinimumWidth = 6;
            this.DiaSemana.Name = "DiaSemana";
            // 
            // DataInicio
            // 
            this.DataInicio.HeaderText = "Data de Início";
            this.DataInicio.MinimumWidth = 6;
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Width = 125;
            // 
            // DataTermino
            // 
            this.DataTermino.HeaderText = "Data de Término";
            this.DataTermino.MinimumWidth = 6;
            this.DataTermino.Name = "DataTermino";
            this.DataTermino.Width = 125;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora de Início";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Width = 125;
            // 
            // HoraFim
            // 
            this.HoraFim.HeaderText = "Hora de Término";
            this.HoraFim.MinimumWidth = 6;
            this.HoraFim.Name = "HoraFim";
            this.HoraFim.Width = 125;
            // 
            // dtDiaTermino
            // 
            this.dtDiaTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiaTermino.Location = new System.Drawing.Point(237, 211);
            this.dtDiaTermino.Name = "dtDiaTermino";
            this.dtDiaTermino.Size = new System.Drawing.Size(150, 30);
            this.dtDiaTermino.TabIndex = 7;
            // 
            // dtDiaInicio
            // 
            this.dtDiaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiaInicio.Location = new System.Drawing.Point(237, 123);
            this.dtDiaInicio.Name = "dtDiaInicio";
            this.dtDiaInicio.Size = new System.Drawing.Size(150, 30);
            this.dtDiaInicio.TabIndex = 6;
            // 
            // lblHoraTérmino
            // 
            this.lblHoraTérmino.AutoSize = true;
            this.lblHoraTérmino.Location = new System.Drawing.Point(565, 216);
            this.lblHoraTérmino.Name = "lblHoraTérmino";
            this.lblHoraTérmino.Size = new System.Drawing.Size(158, 25);
            this.lblHoraTérmino.TabIndex = 5;
            this.lblHoraTérmino.Text = "Hora de Término";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(565, 128);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(131, 25);
            this.lblHoraInicio.TabIndex = 4;
            this.lblHoraInicio.Text = "Hora de Início";
            // 
            // lblDiaFim
            // 
            this.lblDiaFim.AutoSize = true;
            this.lblDiaFim.Location = new System.Drawing.Point(55, 216);
            this.lblDiaFim.Name = "lblDiaFim";
            this.lblDiaFim.Size = new System.Drawing.Size(145, 25);
            this.lblDiaFim.TabIndex = 3;
            this.lblDiaFim.Text = "Dia de Término";
            // 
            // lblDiaInicio
            // 
            this.lblDiaInicio.AutoSize = true;
            this.lblDiaInicio.Location = new System.Drawing.Point(55, 128);
            this.lblDiaInicio.Name = "lblDiaInicio";
            this.lblDiaInicio.Size = new System.Drawing.Size(118, 25);
            this.lblDiaInicio.TabIndex = 2;
            this.lblDiaInicio.Text = "Dia de Início";
            // 
            // cmbDiaSemana
            // 
            this.cmbDiaSemana.FormattingEnabled = true;
            this.cmbDiaSemana.Location = new System.Drawing.Point(237, 45);
            this.cmbDiaSemana.Name = "cmbDiaSemana";
            this.cmbDiaSemana.Size = new System.Drawing.Size(253, 33);
            this.cmbDiaSemana.TabIndex = 1;
            // 
            // lblDiadaSemana
            // 
            this.lblDiadaSemana.AutoSize = true;
            this.lblDiadaSemana.Location = new System.Drawing.Point(55, 48);
            this.lblDiadaSemana.Name = "lblDiadaSemana";
            this.lblDiadaSemana.Size = new System.Drawing.Size(147, 25);
            this.lblDiadaSemana.TabIndex = 0;
            this.lblDiadaSemana.Text = "Dia da Semana";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleDescription = "Enviar";
            this.btnSalvar.AccessibleName = "Enviar";
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(582, 724);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(221, 54);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleDescription = "Cancelar";
            this.btnCancelar.AccessibleName = "Cancelar";
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.Location = new System.Drawing.Point(287, 724);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(221, 54);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmDiaPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 804);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpDia);
            this.MaximizeBox = false;
            this.Name = "FrmDiaPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Dias da Promoção";
            this.gpDia.ResumeLayout(false);
            this.gpDia.PerformLayout();
            this.gpAdicionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiasAdicionados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDia;
        private System.Windows.Forms.GroupBox gpAdicionados;
        private System.Windows.Forms.DateTimePicker dtDiaTermino;
        private System.Windows.Forms.DateTimePicker dtDiaInicio;
        private System.Windows.Forms.Label lblHoraTérmino;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblDiaFim;
        private System.Windows.Forms.Label lblDiaInicio;
        private System.Windows.Forms.ComboBox cmbDiaSemana;
        private System.Windows.Forms.Label lblDiadaSemana;
        private System.Windows.Forms.DateTimePicker dtHoraInicio;
        private System.Windows.Forms.DateTimePicker dtHoraTermino;
        private System.Windows.Forms.DataGridView dtgDiasAdicionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTermino;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFim;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}