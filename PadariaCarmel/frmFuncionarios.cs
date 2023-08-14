using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace PadariaCarmel {
    public partial class frmFuncionarios : Form {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios() {
            InitializeComponent();
        }

        public frmFuncionarios(string nome) {
          InitializeComponent();
          txtNome.Text = nome;
        }

    private void btnNovo_Click(object sender, EventArgs e) {
            habilitarCampos();
        }

        // Desabilitar campos 
        public void desabilitarCampos() {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;

            mskCPF.Enabled = false;
            mskCEP.Enabled = false;
            mskTelefone.Enabled = false;

            cbbEstado.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        public void habilitarCampos() {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;

            mskCPF.Enabled = true;
            mskCEP.Enabled = true;
            mskTelefone.Enabled = true;

            cbbEstado.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }

        public void limparCampos() {
            txtCodigo.Enabled = false;
            txtNome.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();

            mskCPF.Clear();
            mskCEP.Clear();
            mskTelefone.Clear();

            cbbEstado.Text = "";
            txtNome.Focus();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e) {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            desabilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            MessageBox.Show("Cadastrado com Sucesso!",
                "Mensagem do Sistema.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            desabilitarCampos();
            btnNovo.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            limparCampos();
        }

    public void buscaCEP(string numCEP) {
      // http://www.andrealveslima.com.br/blog/index.php/2016/09/07/acessando-os-web-services-dos-correios-com-c-e-vb-net-consulta-de-ceps-e-precos/
      // https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl
      WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();


      WSCorreios.enderecoERP endereco = ws.consultaCEP(numCEP);

      txtEndereco.Text = endereco.end;
      txtBairro.Text = endereco.bairro;
      txtCidade.Text = endereco.cidade;
      cbbEstado.Text = endereco.uf;
    }

    private void mskCEP_KeyDown(object sender, KeyEventArgs e) {
      try {
        if (e.KeyCode == Keys.Enter) {
          buscaCEP(mskCEP.Text);
          txtNumero.Focus();
        }
      } catch(Exception) {
        MessageBox.Show("Favor inserir CEP váilido",
          "Mensagem do sitema",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error,
          MessageBoxDefaultButton.Button1);
        mskCEP.Focus();
        mskCEP.Text = "";
      }
      
    }

    private void btnPesquisar_Click(object sender, EventArgs e) {
      frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
      abrir.Show();
      this.Hide();
    }
  }
}
