namespace ProjetoDesafio.Feature.Promocao.View.TelaPromocao
{
    partial class FrmTipo
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
            this.gpTipo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.gpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTipo
            // 
            this.gpTipo.Controls.Add(this.label1);
            this.gpTipo.Controls.Add(this.cmbTipo);
            this.gpTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTipo.Location = new System.Drawing.Point(68, 83);
            this.gpTipo.Name = "gpTipo";
            this.gpTipo.Size = new System.Drawing.Size(663, 310);
            this.gpTipo.TabIndex = 0;
            this.gpTipo.TabStop = false;
            this.gpTipo.Text = "Tipo da Promoção";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Desconto Percentual/ Valor atribuído",
            "Cada X em compras, ganhe Y em desconto",
            "Leve X, pague Y"});
            this.cmbTipo.Location = new System.Drawing.Point(138, 66);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(452, 37);
            this.cmbTipo.TabIndex = 0;
            // 
            // FrmTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpTipo);
            this.Name = "FrmTipo";
            this.Text = "Selecionar Tipo da Promoção";
            this.gpTipo.ResumeLayout(false);
            this.gpTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}