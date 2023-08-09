
namespace PadariaCarmel {
    partial class frmFuncionarios {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
      this.pnlCRUD = new System.Windows.Forms.Panel();
      this.btnVoltar = new System.Windows.Forms.Button();
      this.btnLimpar = new System.Windows.Forms.Button();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnAlterar = new System.Windows.Forms.Button();
      this.btnCadastrar = new System.Windows.Forms.Button();
      this.btnNovo = new System.Windows.Forms.Button();
      this.pnlFuncionario = new System.Windows.Forms.Panel();
      this.mskCEP = new System.Windows.Forms.MaskedTextBox();
      this.lblCEP = new System.Windows.Forms.Label();
      this.cbbEstado = new System.Windows.Forms.ComboBox();
      this.lblEstado = new System.Windows.Forms.Label();
      this.txtCidade = new System.Windows.Forms.TextBox();
      this.lblCidade = new System.Windows.Forms.Label();
      this.txtBairro = new System.Windows.Forms.TextBox();
      this.lblBairro = new System.Windows.Forms.Label();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.lblNumero = new System.Windows.Forms.Label();
      this.txtEndereco = new System.Windows.Forms.TextBox();
      this.lblEndereco = new System.Windows.Forms.Label();
      this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
      this.lblTelefone = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.lblEmail = new System.Windows.Forms.Label();
      this.mskCPF = new System.Windows.Forms.MaskedTextBox();
      this.lblCPF = new System.Windows.Forms.Label();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.lblNome = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.lblCOdigo = new System.Windows.Forms.Label();
      this.pnlCRUD.SuspendLayout();
      this.pnlFuncionario.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlCRUD
      // 
      this.pnlCRUD.BackColor = System.Drawing.Color.Gainsboro;
      this.pnlCRUD.Controls.Add(this.btnVoltar);
      this.pnlCRUD.Controls.Add(this.btnLimpar);
      this.pnlCRUD.Controls.Add(this.btnPesquisar);
      this.pnlCRUD.Controls.Add(this.btnExcluir);
      this.pnlCRUD.Controls.Add(this.btnAlterar);
      this.pnlCRUD.Controls.Add(this.btnCadastrar);
      this.pnlCRUD.Controls.Add(this.btnNovo);
      this.pnlCRUD.Location = new System.Drawing.Point(1, 479);
      this.pnlCRUD.Name = "pnlCRUD";
      this.pnlCRUD.Size = new System.Drawing.Size(783, 81);
      this.pnlCRUD.TabIndex = 12;
      // 
      // btnVoltar
      // 
      this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
      this.btnVoltar.Location = new System.Drawing.Point(672, 23);
      this.btnVoltar.Name = "btnVoltar";
      this.btnVoltar.Size = new System.Drawing.Size(105, 37);
      this.btnVoltar.TabIndex = 19;
      this.btnVoltar.Text = "&Voltar";
      this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnVoltar.UseVisualStyleBackColor = true;
      this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
      // 
      // btnLimpar
      // 
      this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
      this.btnLimpar.Location = new System.Drawing.Point(561, 23);
      this.btnLimpar.Name = "btnLimpar";
      this.btnLimpar.Size = new System.Drawing.Size(105, 37);
      this.btnLimpar.TabIndex = 18;
      this.btnLimpar.Text = "&Limpar";
      this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnLimpar.UseVisualStyleBackColor = true;
      this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
      this.btnPesquisar.Location = new System.Drawing.Point(450, 23);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(105, 37);
      this.btnPesquisar.TabIndex = 17;
      this.btnPesquisar.Text = "&Pesquisar";
      this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
      this.btnExcluir.Location = new System.Drawing.Point(339, 23);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(105, 37);
      this.btnExcluir.TabIndex = 16;
      this.btnExcluir.Text = "&Excluir";
      this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnExcluir.UseVisualStyleBackColor = true;
      // 
      // btnAlterar
      // 
      this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
      this.btnAlterar.Location = new System.Drawing.Point(228, 23);
      this.btnAlterar.Name = "btnAlterar";
      this.btnAlterar.Size = new System.Drawing.Size(105, 37);
      this.btnAlterar.TabIndex = 15;
      this.btnAlterar.Text = "&Alterar";
      this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnAlterar.UseVisualStyleBackColor = true;
      // 
      // btnCadastrar
      // 
      this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
      this.btnCadastrar.Location = new System.Drawing.Point(117, 23);
      this.btnCadastrar.Name = "btnCadastrar";
      this.btnCadastrar.Size = new System.Drawing.Size(105, 37);
      this.btnCadastrar.TabIndex = 14;
      this.btnCadastrar.Text = "&Cadastrar";
      this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnCadastrar.UseVisualStyleBackColor = true;
      this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
      // 
      // btnNovo
      // 
      this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
      this.btnNovo.Location = new System.Drawing.Point(6, 23);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(105, 37);
      this.btnNovo.TabIndex = 13;
      this.btnNovo.Text = "&Novo";
      this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnNovo.UseVisualStyleBackColor = true;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // pnlFuncionario
      // 
      this.pnlFuncionario.Controls.Add(this.mskCEP);
      this.pnlFuncionario.Controls.Add(this.lblCEP);
      this.pnlFuncionario.Controls.Add(this.cbbEstado);
      this.pnlFuncionario.Controls.Add(this.lblEstado);
      this.pnlFuncionario.Controls.Add(this.txtCidade);
      this.pnlFuncionario.Controls.Add(this.lblCidade);
      this.pnlFuncionario.Controls.Add(this.txtBairro);
      this.pnlFuncionario.Controls.Add(this.lblBairro);
      this.pnlFuncionario.Controls.Add(this.txtNumero);
      this.pnlFuncionario.Controls.Add(this.lblNumero);
      this.pnlFuncionario.Controls.Add(this.txtEndereco);
      this.pnlFuncionario.Controls.Add(this.lblEndereco);
      this.pnlFuncionario.Controls.Add(this.mskTelefone);
      this.pnlFuncionario.Controls.Add(this.lblTelefone);
      this.pnlFuncionario.Controls.Add(this.txtEmail);
      this.pnlFuncionario.Controls.Add(this.lblEmail);
      this.pnlFuncionario.Controls.Add(this.mskCPF);
      this.pnlFuncionario.Controls.Add(this.lblCPF);
      this.pnlFuncionario.Controls.Add(this.txtNome);
      this.pnlFuncionario.Controls.Add(this.lblNome);
      this.pnlFuncionario.Controls.Add(this.txtCodigo);
      this.pnlFuncionario.Controls.Add(this.lblCOdigo);
      this.pnlFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pnlFuncionario.Location = new System.Drawing.Point(1, 1);
      this.pnlFuncionario.Name = "pnlFuncionario";
      this.pnlFuncionario.Size = new System.Drawing.Size(783, 482);
      this.pnlFuncionario.TabIndex = 0;
      // 
      // mskCEP
      // 
      this.mskCEP.Location = new System.Drawing.Point(558, 378);
      this.mskCEP.Mask = "99999-999";
      this.mskCEP.Name = "mskCEP";
      this.mskCEP.Size = new System.Drawing.Size(84, 26);
      this.mskCEP.TabIndex = 11;
      this.mskCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCEP_KeyDown);
      // 
      // lblCEP
      // 
      this.lblCEP.AutoSize = true;
      this.lblCEP.Location = new System.Drawing.Point(558, 354);
      this.lblCEP.Name = "lblCEP";
      this.lblCEP.Size = new System.Drawing.Size(41, 20);
      this.lblCEP.TabIndex = 20;
      this.lblCEP.Text = "CEP";
      // 
      // cbbEstado
      // 
      this.cbbEstado.FormattingEnabled = true;
      this.cbbEstado.Items.AddRange(new object[] {
            "São Paulo",
            "Minas Gerais",
            "Paraná",
            "Santa Catarina",
            "Rio Grande do Sul"});
      this.cbbEstado.Location = new System.Drawing.Point(378, 378);
      this.cbbEstado.Name = "cbbEstado";
      this.cbbEstado.Size = new System.Drawing.Size(121, 28);
      this.cbbEstado.TabIndex = 10;
      // 
      // lblEstado
      // 
      this.lblEstado.AutoSize = true;
      this.lblEstado.Location = new System.Drawing.Point(378, 354);
      this.lblEstado.Name = "lblEstado";
      this.lblEstado.Size = new System.Drawing.Size(60, 20);
      this.lblEstado.TabIndex = 18;
      this.lblEstado.Text = "Estado";
      // 
      // txtCidade
      // 
      this.txtCidade.Location = new System.Drawing.Point(210, 378);
      this.txtCidade.MaxLength = 150;
      this.txtCidade.Name = "txtCidade";
      this.txtCidade.Size = new System.Drawing.Size(148, 26);
      this.txtCidade.TabIndex = 9;
      // 
      // lblCidade
      // 
      this.lblCidade.AutoSize = true;
      this.lblCidade.Location = new System.Drawing.Point(210, 354);
      this.lblCidade.Name = "lblCidade";
      this.lblCidade.Size = new System.Drawing.Size(59, 20);
      this.lblCidade.TabIndex = 16;
      this.lblCidade.Text = "Cidade";
      // 
      // txtBairro
      // 
      this.txtBairro.Location = new System.Drawing.Point(35, 378);
      this.txtBairro.MaxLength = 150;
      this.txtBairro.Name = "txtBairro";
      this.txtBairro.Size = new System.Drawing.Size(155, 26);
      this.txtBairro.TabIndex = 8;
      // 
      // lblBairro
      // 
      this.lblBairro.AutoSize = true;
      this.lblBairro.Location = new System.Drawing.Point(35, 354);
      this.lblBairro.Name = "lblBairro";
      this.lblBairro.Size = new System.Drawing.Size(51, 20);
      this.lblBairro.TabIndex = 14;
      this.lblBairro.Text = "Bairro";
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(558, 303);
      this.txtNumero.MaxLength = 10;
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new System.Drawing.Size(100, 26);
      this.txtNumero.TabIndex = 7;
      // 
      // lblNumero
      // 
      this.lblNumero.AutoSize = true;
      this.lblNumero.Location = new System.Drawing.Point(558, 279);
      this.lblNumero.Name = "lblNumero";
      this.lblNumero.Size = new System.Drawing.Size(65, 20);
      this.lblNumero.TabIndex = 12;
      this.lblNumero.Text = "Número";
      // 
      // txtEndereco
      // 
      this.txtEndereco.Location = new System.Drawing.Point(35, 303);
      this.txtEndereco.MaxLength = 150;
      this.txtEndereco.Name = "txtEndereco";
      this.txtEndereco.Size = new System.Drawing.Size(463, 26);
      this.txtEndereco.TabIndex = 6;
      // 
      // lblEndereco
      // 
      this.lblEndereco.AutoSize = true;
      this.lblEndereco.Location = new System.Drawing.Point(35, 279);
      this.lblEndereco.Name = "lblEndereco";
      this.lblEndereco.Size = new System.Drawing.Size(78, 20);
      this.lblEndereco.TabIndex = 10;
      this.lblEndereco.Text = "Endereço";
      // 
      // mskTelefone
      // 
      this.mskTelefone.Location = new System.Drawing.Point(558, 144);
      this.mskTelefone.Mask = "(99) 99999-9999";
      this.mskTelefone.Name = "mskTelefone";
      this.mskTelefone.Size = new System.Drawing.Size(124, 26);
      this.mskTelefone.TabIndex = 4;
      // 
      // lblTelefone
      // 
      this.lblTelefone.AutoSize = true;
      this.lblTelefone.Location = new System.Drawing.Point(558, 120);
      this.lblTelefone.Name = "lblTelefone";
      this.lblTelefone.Size = new System.Drawing.Size(71, 20);
      this.lblTelefone.TabIndex = 8;
      this.lblTelefone.Text = "Telefone";
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(35, 225);
      this.txtEmail.MaxLength = 100;
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(282, 26);
      this.txtEmail.TabIndex = 5;
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Location = new System.Drawing.Point(35, 201);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(53, 20);
      this.lblEmail.TabIndex = 6;
      this.lblEmail.Text = "E-mail";
      // 
      // mskCPF
      // 
      this.mskCPF.Location = new System.Drawing.Point(378, 144);
      this.mskCPF.Mask = "999,999,999-99";
      this.mskCPF.Name = "mskCPF";
      this.mskCPF.Size = new System.Drawing.Size(120, 26);
      this.mskCPF.TabIndex = 3;
      // 
      // lblCPF
      // 
      this.lblCPF.AutoSize = true;
      this.lblCPF.Location = new System.Drawing.Point(378, 120);
      this.lblCPF.Name = "lblCPF";
      this.lblCPF.Size = new System.Drawing.Size(40, 20);
      this.lblCPF.TabIndex = 4;
      this.lblCPF.Text = "CPF";
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(35, 144);
      this.txtNome.MaxLength = 100;
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(282, 26);
      this.txtNome.TabIndex = 2;
      // 
      // lblNome
      // 
      this.lblNome.AutoSize = true;
      this.lblNome.Location = new System.Drawing.Point(35, 120);
      this.lblNome.Name = "lblNome";
      this.lblNome.Size = new System.Drawing.Size(51, 20);
      this.lblNome.TabIndex = 2;
      this.lblNome.Text = "Nome";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(35, 82);
      this.txtCodigo.MaxLength = 10;
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(100, 26);
      this.txtCodigo.TabIndex = 1;
      // 
      // lblCOdigo
      // 
      this.lblCOdigo.AutoSize = true;
      this.lblCOdigo.Location = new System.Drawing.Point(35, 58);
      this.lblCOdigo.Name = "lblCOdigo";
      this.lblCOdigo.Size = new System.Drawing.Size(59, 20);
      this.lblCOdigo.TabIndex = 0;
      this.lblCOdigo.Text = "Código";
      // 
      // frmFuncionarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.pnlFuncionario);
      this.Controls.Add(this.pnlCRUD);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "frmFuncionarios";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Padaria - Funcionários";
      this.Load += new System.EventHandler(this.frmFuncionarios_Load);
      this.pnlCRUD.ResumeLayout(false);
      this.pnlFuncionario.ResumeLayout(false);
      this.pnlFuncionario.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlFuncionario;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCOdigo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
  }
}