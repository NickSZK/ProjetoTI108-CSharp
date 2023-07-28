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
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void frmLogin_Load(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }
        private void lblUsuario_Click(object sender, EventArgs e) {

        }

        private void btnSair_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            MessageBox.Show("Bem vindo ao sistema.",
                "Mensagem do sistema",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button3);
        }
    }
}
