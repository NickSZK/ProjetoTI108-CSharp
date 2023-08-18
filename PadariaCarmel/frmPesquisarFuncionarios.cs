﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PadariaCarmel {
  public partial class frmPesquisarFuncionarios : Form {
    public frmPesquisarFuncionarios() {
      InitializeComponent();
      desativarCampos();
    }

    public void desativarCampos() {
      txtDescricao.Enabled = false;
      btnPesquisar.Enabled = false;
      btnLimpar.Enabled = false;
    }

    public void ativarCampos() {
      txtDescricao.Enabled = true;
      btnPesquisar.Enabled = true;
      btnLimpar.Enabled = true;
      txtDescricao.Focus();
    }

    private void btnPesquisar_Click(object sender, EventArgs e) {
      if (rdbCodigo.Checked) {
        txtDescricao.Focus();
        lstPesquisar.Items.Clear();
        pesquisarCodigo(txtDescricao.Text);
      }

      if (rdbNome.Checked) {
        txtDescricao.Focus();
        lstPesquisar.Items.Clear();
        pesquisarNome(txtDescricao.Text);
      }

      txtDescricao.Clear();
      txtDescricao.Focus();
    }

    public void limparCampos() {
      rdbCodigo.Checked = false;
      rdbNome.Checked = false;
      txtDescricao.Clear();
      lstPesquisar.Items.Clear();
      txtDescricao.Focus();
    }

    private void btnLimpar_Click(object sender, EventArgs e) {
      limparCampos();
    }

    private void rdbCodigo_CheckedChanged(object sender, EventArgs e) {
      ativarCampos();
    }

    private void rdbNome_CheckedChanged(object sender, EventArgs e) {
      ativarCampos();
    }

    private void lstPesquisar_SelectedIndexChanged(object sender, EventArgs e) {
      string nome = lstPesquisar.SelectedItem.ToString();
      frmFuncionarios abrir = new frmFuncionarios(nome);
      abrir.Show();
      this.Hide();
    }

    // Pesquisat por código
    public void  pesquisarCodigo(string codigo) {
         MySqlCommand comm = new MySqlCommand();
         comm.CommandText = "SELECT nome FROM tbFuncionarios WHERE codFunc = " + codigo + ";";
         comm.CommandType = CommandType.Text;
         comm.Connection = Conectar.obterConexao();

         MySqlDataReader DR;
         DR = comm.ExecuteReader();
         DR.Read();

         lstPesquisar.Items.Add(DR.GetString(0));

         Conectar.fecharConexao();
    }

    // Pesquisar por Nome
    public void pesquisarNome(string nome) {
         MySqlCommand comm = new MySqlCommand();
         comm.CommandText = "SELECT nome FROM tbFuncionarios WHERE nome LIKE '%" + nome + "%';";
         comm.CommandType = CommandType.Text;
         comm.Connection = Conectar.obterConexao();

         MySqlDataReader DR;
         DR = comm.ExecuteReader();
         DR.Read();

         lstPesquisar.Items.Add(DR.GetString(0));

         Conectar.fecharConexao();
      }
   }
}
