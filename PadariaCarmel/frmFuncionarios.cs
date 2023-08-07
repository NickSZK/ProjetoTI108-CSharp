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

            limparCampos();
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
    }
}
