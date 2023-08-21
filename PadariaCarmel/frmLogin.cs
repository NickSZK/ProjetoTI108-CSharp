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
    public partial class frmLogin : Form {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmLogin() {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            // Close();
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
         bool resultado = acessoSistema(txtUsuario.Text, txtSenha.Text);

         if(resultado) {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            } else {
                MessageBox.Show("Usuário ou senha inválidos.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                limparTela();
            }
        }
        public void limparTela() {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnEntrar.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e) {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

      // Busca usuário por nome no Banco de Dados
      public bool acessoSistema(string nome, string senha) {
         MySqlCommand comm = new MySqlCommand();
         comm.CommandText = "SELECT * FROM tbUsuarios WHERE nome = @nome AND senha = @senha";
         comm.CommandType = CommandType.Text;

         comm.Parameters.Clear();
         comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nome;
         comm.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = senha;

         comm.Connection = Conectar.obterConexao();
         MySqlDataReader DR;
         DR = comm.ExecuteReader();

         bool resultado = DR.HasRows;

         Conectar.fecharConexao();

         return resultado;
      }
    }
}
