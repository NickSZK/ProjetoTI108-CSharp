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
         desabilitarCampos();
      }

      public frmFuncionarios(string nome) {
         InitializeComponent();
         desabilitarCampos();
         txtNome.Text = nome;
         pesquisarNome(txtNome.Text);
      }

      private void btnNovo_Click(object sender, EventArgs e) {
         habilitarCampos();
         pesquisarPorCod();
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

      public void habilitarBuscaNome() {
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

         btnNovo.Enabled = false;
         btnCadastrar.Enabled = false;
         btnAlterar.Enabled = true;
         btnExcluir.Enabled = true;
         btnLimpar.Enabled = true;

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
         txtCodigo.Clear();

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
         // desabilitarCampos();
      }

      private void btnCadastrar_Click(object sender, EventArgs e) {
         if(txtNome.Text.Equals("") || txtEmail.Text.Equals("") ||
            txtBairro.Text.Equals("") || txtCidade.Text.Equals("") ||
            txtEndereco.Text.Equals("") || txtNumero.Text.Equals("") ||
            cbbEstado.Text.Equals("") ||
            mskCEP.Text.Equals("     -") || mskCPF.Text.Equals("   .   .   -")|| mskTelefone.Text.Equals("(  )      -")) {
            MessageBox.Show("Preenchimento de campo obrigatório!",
             "Mensagem do Sistema.",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button1);

            txtNome.Focus();
         } else {
            cadastrarFuncionarios();

            MessageBox.Show("Cadastrado com Sucesso!",
                "Mensagem do Sistema.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            desabilitarCampos();

            btnNovo.Enabled = true;

            limparCampos();
         }
         
      }

      // Cadastrar funcionários
      public void cadastrarFuncionarios() {
         MySqlCommand comm = new MySqlCommand();
         comm.CommandText = "INSERT INTO tbFuncionarios(nome, email, telCel, cpf, endereco, numero, bairro, cidade, estado, cep) VALUES (@nome, @email, @telCel, @cpf, @endereco, @numero, @bairro, @cidade, @estado, @cep);";

         comm.CommandType = CommandType.Text;

         comm.Parameters.Clear();
         comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
         comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
         comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 100).Value = mskTelefone.Text;
         comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
         comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
         comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
         comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
         comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
         comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;
         comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCEP.Text;

         comm.Connection = Conectar.obterConexao();

         int res = comm.ExecuteNonQuery();

         Conectar.fecharConexao();
      }

      // Alterar dados funcionários
      public void alterarFuncionarios(int codigo) {
         MySqlCommand comm = new MySqlCommand();
         comm.CommandText = "UPDATE tbFuncionarios SET nome=@nome,email=@email,telCel=@telCel,cpf=@cpf,endereco=@endereco,numero=@numero,cidade=@cidade,estado=@estado,cep=" +
            "@cep WHERE codFunc=" + codigo + ";";

         comm.CommandType = CommandType.Text;

         comm.Parameters.Clear();
         comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
         comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
         comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 100).Value = mskTelefone.Text;
         comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
         comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
         comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
         comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
         comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
         comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;
         comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCEP.Text;

         comm.Connection = Conectar.obterConexao();

         int res = comm.ExecuteNonQuery();

         Conectar.fecharConexao();
      }
      // Pesquisar por código
      public void pesquisarPorCod() {
         MySqlCommand comm = new MySqlCommand();
         comm.CommandText = "SELECT codFunc + 1 FROM tbfuncionarios ORDER BY codFunc DESC;";
         comm.CommandType = CommandType.Text;
         comm.Connection = Conectar.obterConexao();

         MySqlDataReader DR;
         DR = comm.ExecuteReader();
         DR.Read();

         txtCodigo.Text = DR.GetInt32(0).ToString();

         Conectar.fecharConexao();
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
            if(e.KeyCode == Keys.Enter) {
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

      private void txtNome_TextChanged(object sender, EventArgs e) {
         // pesquisarNome(txtNome.Text);
      }

      // Pesquisar por nome
      public void pesquisarNome(string nome) {
         MySqlCommand comm = new MySqlCommand();
         comm.CommandText = "SELECT * FROM tbFuncionarios WHERE nome LIKE '%" + nome + "%';";
         comm.CommandType = CommandType.Text;
         comm.Connection = Conectar.obterConexao();

         MySqlDataReader DR;
         DR = comm.ExecuteReader();
         DR.Read();

         txtCodigo.Text = DR.GetInt32(0).ToString();
         txtNome.Text = DR.GetString(1);
         txtEmail.Text = DR.GetString(2);
         mskTelefone.Text = DR.GetString(3);
         mskCPF.Text = DR.GetString(4);
         txtEndereco.Text = DR.GetString(5);
         txtNumero.Text = DR.GetString(6);
         txtBairro.Text = DR.GetString(7);
         txtCidade.Text = DR.GetString(8);
         cbbEstado.Text = DR.GetString(9);
         mskCEP.Text = DR.GetString(10);

         Conectar.fecharConexao();

         habilitarBuscaNome();
      }

      private void btnAlterar_Click(object sender, EventArgs e) {
         alterarFuncionarios(Convert.ToInt32(txtCodigo.Text));

         MessageBox.Show("Dados alerados com sucesso",
            "Mensagem do sistema",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);

         desabilitarCampos();
         btnNovo.Enabled = true;
         limparCampos();
      }
   }
}
