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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.BackgroundImage")));
            this.btnFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFuncionario.Location = new System.Drawing.Point(53, 76);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(145, 126);
            this.btnFuncionario.TabIndex = 0;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(217, 76);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(145, 126);
            this.btnFornecedor.TabIndex = 1;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(382, 76);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(145, 126);
            this.btnAdministrador.TabIndex = 2;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 126);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cliente";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(545, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 126);
            this.button4.TabIndex = 4;
            this.button4.Text = "Promoção";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(53, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 126);
            this.button5.TabIndex = 5;
            this.button5.Text = "Marca";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(217, 234);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 126);
            this.button6.TabIndex = 6;
            this.button6.Text = "Categoria";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(382, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 126);
            this.button7.TabIndex = 7;
            this.button7.Text = "Produto";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 411);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnFuncionario);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}