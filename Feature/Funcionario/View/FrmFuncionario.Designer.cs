namespace ProjetoDesafio.Feature.Funcionario.View
{
    partial class FrmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Informacoes = new System.Windows.Forms.GroupBox();
            this.Endereco = new System.Windows.Forms.GroupBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.Contato = new System.Windows.Forms.GroupBox();
            this.Acesso = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskSenhaConfirmar = new System.Windows.Forms.MaskedTextBox();
            this.Informacoes.SuspendLayout();
            this.Endereco.SuspendLayout();
            this.Contato.SuspendLayout();
            this.Acesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AccessibleDescription = "Cadastrar";
            this.btnCadastrar.AccessibleName = "Cadastrar";
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(137, 122);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.AccessibleDescription = "Listar";
            this.btnListar.AccessibleName = "Listar";
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListar.Location = new System.Drawing.Point(192, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(137, 122);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.AccessibleDescription = "Alterar";
            this.btnAlterar.AccessibleName = "Alterar";
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(373, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 122);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleDescription = "Excluir";
            this.btnExcluir.AccessibleName = "";
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(560, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 122);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(5, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 25);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.AccessibleDescription = "Nome";
            this.txtNome.AccessibleName = "Nome";
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(102, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(545, 30);
            this.txtNome.TabIndex = 0;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AccessibleDescription = "Endereco";
            this.lblEndereco.AccessibleName = "Endereco";
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(10, 123);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(96, 25);
            this.lblEndereco.TabIndex = 10;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtRua
            // 
            this.txtRua.AccessibleDescription = "Rua";
            this.txtRua.AccessibleName = "Rua";
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(114, 120);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(532, 30);
            this.txtRua.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AccessibleDescription = "Numero";
            this.lblNumero.AccessibleName = "Numero";
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(10, 179);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(81, 25);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(114, 178);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(142, 30);
            this.txtNumero.TabIndex = 3;
            // 
            // lblCep
            // 
            this.lblCep.AccessibleDescription = "CEP";
            this.lblCep.AccessibleName = "CEP";
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(10, 62);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(53, 25);
            this.lblCep.TabIndex = 8;
            this.lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.AccessibleDescription = "Cep";
            this.txtCep.AccessibleName = "CEP";
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(114, 59);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(197, 30);
            this.txtCep.TabIndex = 0;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AccessibleDescription = "Complemento";
            this.lblComplemento.AccessibleName = "Complemento";
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(296, 179);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(134, 25);
            this.lblComplemento.TabIndex = 12;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.AccessibleDescription = "Complemento";
            this.txtComplemento.AccessibleName = "Complemento";
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(451, 176);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(195, 30);
            this.txtComplemento.TabIndex = 4;
            // 
            // lblCidade
            // 
            this.lblCidade.AccessibleDescription = "Cidade";
            this.lblCidade.AccessibleName = "Cidade";
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(10, 292);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(75, 25);
            this.lblCidade.TabIndex = 14;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.AccessibleDescription = "Cidade";
            this.txtCidade.AccessibleName = "Cidade";
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(114, 292);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(532, 30);
            this.txtCidade.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AccessibleDescription = "Estado";
            this.lblEstado.AccessibleName = "Estado";
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(330, 62);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 25);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.AccessibleDescription = "Estado";
            this.cmbEstado.AccessibleName = "Estado";
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cmbEstado.Location = new System.Drawing.Point(409, 58);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(237, 33);
            this.cmbEstado.TabIndex = 1;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(10, 352);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(50, 25);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "País";
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(114, 349);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(532, 30);
            this.txtPais.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "Data de Nascimento";
            this.label1.AccessibleName = "Data de Nascimento";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nascimento";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(504, 118);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(144, 30);
            this.dtNascimento.TabIndex = 2;
            // 
            // lblSexo
            // 
            this.lblSexo.AccessibleDescription = "Sexo";
            this.lblSexo.AccessibleName = "Sexo";
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(7, 123);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(58, 25);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.AccessibleDescription = "Sexo";
            this.cmbSexo.AccessibleName = "Sexo";
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(104, 120);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(195, 33);
            this.cmbSexo.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AccessibleDescription = "Email";
            this.lblEmail.AccessibleName = "Email";
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "Email";
            this.txtEmail.AccessibleName = "Email";
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(103, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(553, 30);
            this.txtEmail.TabIndex = 0;
            // 
            // lblCargo
            // 
            this.lblCargo.AccessibleDescription = "Cargo";
            this.lblCargo.AccessibleName = "Cargo";
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(8, 59);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(66, 25);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.AccessibleDescription = "Cargo";
            this.cmbCargo.AccessibleName = "Cargo";
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(104, 56);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(551, 33);
            this.cmbCargo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // mskTelefone
            // 
            this.mskTelefone.AccessibleDescription = "Telefone";
            this.mskTelefone.AccessibleName = "Telefone";
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(106, 115);
            this.mskTelefone.Mask = "(999)  00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(242, 30);
            this.mskTelefone.TabIndex = 1;
            // 
            // lblRg
            // 
            this.lblRg.AccessibleDescription = "RG";
            this.lblRg.AccessibleName = "RG";
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(12, 179);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(40, 25);
            this.lblRg.TabIndex = 7;
            this.lblRg.Text = "RG";
            // 
            // mskRg
            // 
            this.mskRg.AccessibleDescription = "RG";
            this.mskRg.AccessibleName = "RG";
            this.mskRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRg.Location = new System.Drawing.Point(104, 176);
            this.mskRg.Mask = "99 999 999-9";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(195, 30);
            this.mskRg.TabIndex = 3;
            this.mskRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCpf
            // 
            this.lblCpf.AccessibleDescription = "CPF";
            this.lblCpf.AccessibleName = "CPF";
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(345, 178);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(52, 25);
            this.lblCpf.TabIndex = 9;
            this.lblCpf.Text = "CPF";
            // 
            // mskCpf
            // 
            this.mskCpf.AccessibleDescription = "CPF";
            this.mskCpf.AccessibleName = "CPF";
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(503, 176);
            this.mskCpf.Mask = "000 000 000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(145, 30);
            this.mskCpf.TabIndex = 4;
            this.mskCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AccessibleDescription = "Usuario";
            this.lblUsuario.AccessibleName = "Usuario";
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(701, 59);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 25);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(805, 56);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(532, 30);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AccessibleDescription = "Senha";
            this.lblSenha.AccessibleName = "Senha";
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(8, 112);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 25);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // mskSenha
            // 
            this.mskSenha.AccessibleDescription = "Senha";
            this.mskSenha.AccessibleName = "Senha";
            this.mskSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSenha.Location = new System.Drawing.Point(104, 112);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.PasswordChar = '*';
            this.mskSenha.Size = new System.Drawing.Size(551, 30);
            this.mskSenha.TabIndex = 2;
            this.mskSenha.UseSystemPasswordChar = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleDescription = "Enviar";
            this.btnSalvar.AccessibleName = "Enviar";
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(447, 774);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(221, 54);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleDescription = "Cancelar";
            this.btnCancelar.AccessibleName = "Cancelar";
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Location = new System.Drawing.Point(818, 774);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(221, 54);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Informacoes
            // 
            this.Informacoes.Controls.Add(this.txtNome);
            this.Informacoes.Controls.Add(this.lblNome);
            this.Informacoes.Controls.Add(this.cmbSexo);
            this.Informacoes.Controls.Add(this.lblSexo);
            this.Informacoes.Controls.Add(this.label1);
            this.Informacoes.Controls.Add(this.dtNascimento);
            this.Informacoes.Controls.Add(this.mskRg);
            this.Informacoes.Controls.Add(this.mskCpf);
            this.Informacoes.Controls.Add(this.lblRg);
            this.Informacoes.Controls.Add(this.lblCpf);
            this.Informacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacoes.Location = new System.Drawing.Point(13, 166);
            this.Informacoes.Name = "Informacoes";
            this.Informacoes.Size = new System.Drawing.Size(685, 225);
            this.Informacoes.TabIndex = 2;
            this.Informacoes.TabStop = false;
            this.Informacoes.Text = "Informações Pessoais";
            // 
            // Endereco
            // 
            this.Endereco.Controls.Add(this.txtBairro);
            this.Endereco.Controls.Add(this.lblBairro);
            this.Endereco.Controls.Add(this.txtCep);
            this.Endereco.Controls.Add(this.lblCep);
            this.Endereco.Controls.Add(this.cmbEstado);
            this.Endereco.Controls.Add(this.lblEstado);
            this.Endereco.Controls.Add(this.txtRua);
            this.Endereco.Controls.Add(this.lblEndereco);
            this.Endereco.Controls.Add(this.txtNumero);
            this.Endereco.Controls.Add(this.lblNumero);
            this.Endereco.Controls.Add(this.lblComplemento);
            this.Endereco.Controls.Add(this.txtComplemento);
            this.Endereco.Controls.Add(this.txtCidade);
            this.Endereco.Controls.Add(this.lblCidade);
            this.Endereco.Controls.Add(this.txtPais);
            this.Endereco.Controls.Add(this.lblPais);
            this.Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.Location = new System.Drawing.Point(704, 166);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(685, 410);
            this.Endereco.TabIndex = 3;
            this.Endereco.TabStop = false;
            this.Endereco.Text = "Endereço";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(114, 235);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(532, 30);
            this.txtBairro.TabIndex = 5;
            // 
            // lblBairro
            // 
            this.lblBairro.AccessibleDescription = "Numero";
            this.lblBairro.AccessibleName = "Numero";
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(10, 236);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(63, 25);
            this.lblBairro.TabIndex = 13;
            this.lblBairro.Text = "Bairro";
            // 
            // Contato
            // 
            this.Contato.Controls.Add(this.txtEmail);
            this.Contato.Controls.Add(this.lblEmail);
            this.Contato.Controls.Add(this.label2);
            this.Contato.Controls.Add(this.mskTelefone);
            this.Contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contato.Location = new System.Drawing.Point(12, 397);
            this.Contato.Name = "Contato";
            this.Contato.Size = new System.Drawing.Size(685, 179);
            this.Contato.TabIndex = 4;
            this.Contato.TabStop = false;
            this.Contato.Text = "Informações de Contato";
            // 
            // Acesso
            // 
            this.Acesso.Controls.Add(this.label3);
            this.Acesso.Controls.Add(this.mskSenhaConfirmar);
            this.Acesso.Controls.Add(this.lblCargo);
            this.Acesso.Controls.Add(this.cmbCargo);
            this.Acesso.Controls.Add(this.lblUsuario);
            this.Acesso.Controls.Add(this.txtUsuario);
            this.Acesso.Controls.Add(this.lblSenha);
            this.Acesso.Controls.Add(this.mskSenha);
            this.Acesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acesso.Location = new System.Drawing.Point(13, 582);
            this.Acesso.Name = "Acesso";
            this.Acesso.Size = new System.Drawing.Size(1376, 167);
            this.Acesso.TabIndex = 5;
            this.Acesso.TabStop = false;
            this.Acesso.Text = "Informações de Acesso";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "Senha";
            this.label3.AccessibleName = "Senha";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(701, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // mskSenhaConfirmar
            // 
            this.mskSenhaConfirmar.AccessibleDescription = "Senha";
            this.mskSenhaConfirmar.AccessibleName = "Senha";
            this.mskSenhaConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSenhaConfirmar.Location = new System.Drawing.Point(805, 115);
            this.mskSenhaConfirmar.Name = "mskSenhaConfirmar";
            this.mskSenhaConfirmar.PasswordChar = '*';
            this.mskSenhaConfirmar.Size = new System.Drawing.Size(532, 30);
            this.mskSenhaConfirmar.TabIndex = 3;
            this.mskSenhaConfirmar.UseSystemPasswordChar = true;
            // 
            // FrmFuncionario
            // 
            this.AccessibleDescription = "Pais";
            this.AccessibleName = "Pais";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 870);
            this.Controls.Add(this.Acesso);
            this.Controls.Add(this.Contato);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.Informacoes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFuncionario";
            this.Text = "Cadastro de Funcionário";
            this.Informacoes.ResumeLayout(false);
            this.Informacoes.PerformLayout();
            this.Endereco.ResumeLayout(false);
            this.Endereco.PerformLayout();
            this.Contato.ResumeLayout(false);
            this.Contato.PerformLayout();
            this.Acesso.ResumeLayout(false);
            this.Acesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.MaskedTextBox mskSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox Informacoes;
        private System.Windows.Forms.GroupBox Endereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.GroupBox Contato;
        private System.Windows.Forms.GroupBox Acesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskSenhaConfirmar;
    }
}