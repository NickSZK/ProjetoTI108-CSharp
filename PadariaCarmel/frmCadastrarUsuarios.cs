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
   public partial class frmCadastrarUsuarios : Form {
      // Variaveis de controle de sistema
      const int MF_BYCOMMAND = 0X400;
      [DllImport("user32")]
      static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
      [DllImport("user32")]
      static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
      [DllImport("user32")]
      static extern int GetMenuItemCount(IntPtr hWnd);

      public frmCadastrarUsuarios() {
         InitializeComponent();
         desabilitarCampos();
         // carregaFucnionarios();
      }

      // Desabilita campos
      public void desabilitarCampos() {
         txtCodigo.Enabled = false;
         txtNome.Enabled = false;
         txtSenha.Enabled = false;
         txtContraSenha.Enabled = false;

         btnCadastrar.Enabled = false;
         btnAlterar.Enabled = false;
         btnExcluir.Enabled = false;
         btnLimpar.Enabled = false;
      }

      // Habilitar Campos
      public void habilitarCampos() {
         txtCodigo.Enabled = false;
         txtNome.Enabled = true;
         txtSenha.Enabled = true;
         txtContraSenha.Enabled = true;

         txtNome.Focus();

         btnCadastrar.Enabled = true;
         btnAlterar.Enabled = false;
         btnExcluir.Enabled = false;
         btnLimpar.Enabled = true;
         btnNovo.Enabled = false;
      }

      private void btnNovo_Click(object sender, EventArgs e) {
         habilitarCampos();
         carregaFucnionarios();
      }

      private void btnLimpar_Click(object sender, EventArgs e) {
         limparCampos();
      }

      public void limparCampos() {
         txtCodigo.Enabled = false;
         txtNome.Clear();
         txtSenha.Focus();
         txtContraSenha.Focus();
      }

      private void frmCadastrarUsuarios_Load(object sender, EventArgs e) {
         IntPtr hMenu = GetSystemMenu(this.Handle, false);
         int MenuCount = GetMenuItemCount(hMenu) - 1;
         RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
         // desabilitarCampos();
      }

      private void btnCadastrar_Click(object sender, EventArgs e) {
         if(txtNome.Text.Equals("") || txtSenha.Text.Equals("") ||
            txtContraSenha.Text.Equals("")) {
            MessageBox.Show("Preenchimento de campo obrigatório!",
             "Mensagem do Sistema.",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button1);

            txtNome.Focus();
         } else {

            if(txtSenha.Text.Equals(txtContraSenha.Text)) {
               cadastrarUsuarios(Convert.ToInt32(txtCodFunc.Text));

               MessageBox.Show("Cadastrado com Sucesso!",
                   "Mensagem do Sistema.",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);

               desabilitarCampos();

               btnNovo.Enabled = true;

               limparCampos();
            } else {
               MessageBox.Show("Senha e contrasenha não são compatíveis!",
                   "Mensagem do Sistema.",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);

               txtSenha.Text = "";
               txtContraSenha.Text = "";
               txtSenha.Focus();
            }
            
         }
      }

      public void cadastrarUsuarios(int codFunc) {
         MySqlCommand comm = new MySqlCommand();
         comm.CommandText = "INSERT INTO tbFuncionarios(nome, senha, codFunc) VALUES (@nome, @senha, @codFunc);";

         comm.CommandType = CommandType.Text;

         comm.Parameters.Clear();
         comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNome.Text;
         comm.Parameters.Add("@senha", MySqlDbType.VarChar, 14).Value = txtSenha.Text;
         comm.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = txtCodFunc.Text;


         comm.Connection = Conectar.obterConexao();

         int res = comm.ExecuteNonQuery();

         Conectar.fecharConexao();
      }

      // Carregar usuário
      public void carregarUsuarios(string nome) {
         MySqlCommand comm = new MySqlCommand();
         comm.CommandText = "SELECT usu.nome, usu.senha, func.codFunc FROM tbfuncionarios AS func INNER JOIN tbusuarios AS usu ON func.codFunc = usu.codFunc WHERE func.nome = '" + nome + "';";
         comm.CommandType = CommandType.Text;

         comm.Connection = Conectar.obterConexao();

         MySqlDataReader DR;
         DR = comm.ExecuteReader();
         DR.Read();

         try {
            txtNome.Text = DR.GetString(0);
            txtSenha.Text = DR.GetString(1);

            txtCodFunc.Text = DR.GetInt32(2).ToString();

            Conectar.fecharConexao();
         } catch(Exception) {
            MessageBox.Show("Funcionário não encontrado",
               "Mensagem do Sistema.",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);

            txtNome.Clear();
            txtSenha.Clear();
            txtCodigo.Clear();
            txtNome.Focus();
         }
      }

      private void btnVoltar_Click(object sender, EventArgs e) {
         frmMenuPrincipal abrir = new frmMenuPrincipal();
         abrir.Show();
         this.Hide();
      }

      public void carregaFucnionarios() {
         MySqlCommand comm = new MySqlCommand();
         comm.CommandText = "SELECT nome FROM tbfuncionarios ORDER BY nome ASC";
         comm.CommandType = CommandType.Text;

         comm.Connection = Conectar.obterConexao();
         MySqlDataReader DR;
         DR = comm.ExecuteReader();

         lstFuncNCad.Items.Clear();

         while(DR.Read()) {
            lstFuncNCad.Items.Add(DR.GetString(0));
         }

         Conectar.fecharConexao();
      }

      private void lstFuncNCad_SelectedIndexChanged(object sender, EventArgs e) {
         string nome = lstFuncNCad.SelectedItem.ToString();

         carregarUsuarios(nome);
      }
   }
}
