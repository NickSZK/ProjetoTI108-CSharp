﻿
namespace PadariaCarmel {
  partial class frmPesquisarFuncionarios {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarFuncionarios));
      this.gpbPesquisar = new System.Windows.Forms.GroupBox();
      this.txtDescricao = new System.Windows.Forms.TextBox();
      this.lblDescricao = new System.Windows.Forms.Label();
      this.rdbNome = new System.Windows.Forms.RadioButton();
      this.rdbCodigo = new System.Windows.Forms.RadioButton();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.lstPesquisar = new System.Windows.Forms.ListBox();
      this.btnLimpar = new System.Windows.Forms.Button();
      this.gpbPesquisar.SuspendLayout();
      this.SuspendLayout();
      // 
      // gpbPesquisar
      // 
      this.gpbPesquisar.Controls.Add(this.txtDescricao);
      this.gpbPesquisar.Controls.Add(this.lblDescricao);
      this.gpbPesquisar.Controls.Add(this.rdbNome);
      this.gpbPesquisar.Controls.Add(this.rdbCodigo);
      this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gpbPesquisar.Location = new System.Drawing.Point(23, 28);
      this.gpbPesquisar.Name = "gpbPesquisar";
      this.gpbPesquisar.Size = new System.Drawing.Size(563, 160);
      this.gpbPesquisar.TabIndex = 0;
      this.gpbPesquisar.TabStop = false;
      this.gpbPesquisar.Text = "Pesquisar por:";
      // 
      // txtDescricao
      // 
      this.txtDescricao.Location = new System.Drawing.Point(129, 78);
      this.txtDescricao.MaxLength = 10;
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(235, 26);
      this.txtDescricao.TabIndex = 3;
      // 
      // lblDescricao
      // 
      this.lblDescricao.AutoSize = true;
      this.lblDescricao.Location = new System.Drawing.Point(26, 81);
      this.lblDescricao.Name = "lblDescricao";
      this.lblDescricao.Size = new System.Drawing.Size(80, 20);
      this.lblDescricao.TabIndex = 2;
      this.lblDescricao.Text = "Descrição";
      // 
      // rdbNome
      // 
      this.rdbNome.AutoSize = true;
      this.rdbNome.Location = new System.Drawing.Point(157, 36);
      this.rdbNome.Name = "rdbNome";
      this.rdbNome.Size = new System.Drawing.Size(69, 24);
      this.rdbNome.TabIndex = 2;
      this.rdbNome.Text = "Nome";
      this.rdbNome.UseVisualStyleBackColor = true;
      // 
      // rdbCodigo
      // 
      this.rdbCodigo.AutoSize = true;
      this.rdbCodigo.Location = new System.Drawing.Point(26, 36);
      this.rdbCodigo.Name = "rdbCodigo";
      this.rdbCodigo.Size = new System.Drawing.Size(77, 24);
      this.rdbCodigo.TabIndex = 1;
      this.rdbCodigo.Text = "Código";
      this.rdbCodigo.UseVisualStyleBackColor = true;
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
      this.btnPesquisar.Location = new System.Drawing.Point(605, 37);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(155, 151);
      this.btnPesquisar.TabIndex = 5;
      this.btnPesquisar.Text = "&Pesquisar";
      this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // lstPesquisar
      // 
      this.lstPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstPesquisar.FormattingEnabled = true;
      this.lstPesquisar.ItemHeight = 20;
      this.lstPesquisar.Location = new System.Drawing.Point(23, 205);
      this.lstPesquisar.Name = "lstPesquisar";
      this.lstPesquisar.Size = new System.Drawing.Size(563, 144);
      this.lstPesquisar.TabIndex = 6;
      // 
      // btnLimpar
      // 
      this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
      this.btnLimpar.Location = new System.Drawing.Point(605, 205);
      this.btnLimpar.Name = "btnLimpar";
      this.btnLimpar.Size = new System.Drawing.Size(155, 147);
      this.btnLimpar.TabIndex = 5;
      this.btnLimpar.Text = "&Limpar";
      this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btnLimpar.UseVisualStyleBackColor = true;
      this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
      // 
      // frmPesquisarFuncionarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(780, 557);
      this.Controls.Add(this.btnLimpar);
      this.Controls.Add(this.lstPesquisar);
      this.Controls.Add(this.btnPesquisar);
      this.Controls.Add(this.gpbPesquisar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimizeBox = false;
      this.Name = "frmPesquisarFuncionarios";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Padaria - Pesquisar Funcionários";
      this.gpbPesquisar.ResumeLayout(false);
      this.gpbPesquisar.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gpbPesquisar;
    private System.Windows.Forms.TextBox txtDescricao;
    private System.Windows.Forms.Label lblDescricao;
    private System.Windows.Forms.RadioButton rdbNome;
    private System.Windows.Forms.RadioButton rdbCodigo;
    private System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.ListBox lstPesquisar;
    private System.Windows.Forms.Button btnLimpar;
  }
}