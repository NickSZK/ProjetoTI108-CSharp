using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaCarmel {
  public partial class frmPesquisarFuncionarios : Form {
    public frmPesquisarFuncionarios() {
      InitializeComponent();
    }

    private void btnPesquisar_Click(object sender, EventArgs e) {
      lstPesquisar.Items.Clear();
      lstPesquisar.Items.Add(txtDescricao.Text);
      txtDescricao.Clear();
      txtDescricao.Focus();
    }

    public void limparCampos() {
      if(rdbCodigo.Checked) {
        txtDescricao.Focus();
        txtDescricao.Clear();
        lstPesquisar.Items.Clear();
      }

      if(rdbNome.Checked) {
        txtDescricao.Focus();
        txtDescricao.Clear();
        lstPesquisar.Items.Clear();
      }
    }

    private void btnLimpar_Click(object sender, EventArgs e) {
      limparCampos();
    }
  }
}
