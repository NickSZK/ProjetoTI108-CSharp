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
    public partial class frmCalcula : Form {
        public frmCalcula() {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            // Close();
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txtNum1.Text = "";
            txtNum2.Clear();
            lblResposta.Text = "";

            rdbSoma.Checked = false;
            rdbSubtracao.Checked = false;
            rdbDivisao.Checked = false;
            rdbMultiplicacao.Checked = false;

            txtNum1.Focus();
        }
    }
}
