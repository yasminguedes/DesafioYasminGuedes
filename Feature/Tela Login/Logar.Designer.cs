namespace ProjetoDesafio.Feature.Tela_Login
{
    partial class FrmLogar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pctCheck = new System.Windows.Forms.PictureBox();
            this.pctCheck2 = new System.Windows.Forms.PictureBox();
            this.pctErrado = new System.Windows.Forms.PictureBox();
            this.pctErrado2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCheck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctErrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctErrado2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(256, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso ao Sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(227, 386);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(257, 34);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(227, 501);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(257, 34);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Leave += new System.EventHandler(this.TxtSenha_Leave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrar.Location = new System.Drawing.Point(227, 581);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(257, 53);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // pctCheck
            // 
            this.pctCheck.Image = ((System.Drawing.Image)(resources.GetObject("pctCheck.Image")));
            this.pctCheck.Location = new System.Drawing.Point(490, 386);
            this.pctCheck.Name = "pctCheck";
            this.pctCheck.Size = new System.Drawing.Size(25, 29);
            this.pctCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctCheck.TabIndex = 7;
            this.pctCheck.TabStop = false;
            this.pctCheck.Visible = false;
            // 
            // pctCheck2
            // 
            this.pctCheck2.Image = ((System.Drawing.Image)(resources.GetObject("pctCheck2.Image")));
            this.pctCheck2.Location = new System.Drawing.Point(490, 506);
            this.pctCheck2.Name = "pctCheck2";
            this.pctCheck2.Size = new System.Drawing.Size(25, 29);
            this.pctCheck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctCheck2.TabIndex = 8;
            this.pctCheck2.TabStop = false;
            this.pctCheck2.Visible = false;
            // 
            // pctErrado
            // 
            this.pctErrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctErrado.ErrorImage = global::ProjetoDesafio.Properties.Resources.cancel_16;
            this.pctErrado.Image = global::ProjetoDesafio.Properties.Resources.cancel_16;
            this.pctErrado.ImageLocation = "center";
            this.pctErrado.Location = new System.Drawing.Point(494, 390);
            this.pctErrado.Name = "pctErrado";
            this.pctErrado.Size = new System.Drawing.Size(18, 19);
            this.pctErrado.TabIndex = 9;
            this.pctErrado.TabStop = false;
            this.pctErrado.Visible = false;
            // 
            // pctErrado2
            // 
            this.pctErrado2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctErrado2.BackgroundImage")));
            this.pctErrado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctErrado2.Location = new System.Drawing.Point(490, 507);
            this.pctErrado2.Name = "pctErrado2";
            this.pctErrado2.Size = new System.Drawing.Size(29, 28);
            this.pctErrado2.TabIndex = 10;
            this.pctErrado2.TabStop = false;
            this.pctErrado2.Visible = false;
            // 
            // FrmLogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 776);
            this.Controls.Add(this.pctErrado2);
            this.Controls.Add(this.pctErrado);
            this.Controls.Add(this.pctCheck2);
            this.Controls.Add(this.pctCheck);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCheck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctErrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctErrado2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox pctCheck;
        private System.Windows.Forms.PictureBox pctCheck2;
        private System.Windows.Forms.PictureBox pctErrado;
        private System.Windows.Forms.PictureBox pctErrado2;
    }
}