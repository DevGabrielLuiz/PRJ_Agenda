/*
 * Created by SharpDevelop.
 * User: POLIMIG
 * Date: 10/10/2022
 * Time: 09:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PRJ_AGAENDA1
{
	partial class FRMCONTATOS
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.TabControl tbcDados;
		private System.Windows.Forms.TabPage Dados;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox mskTelefone;
		private System.Windows.Forms.DataGridView dvgDados;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.ComboBox cmbOperador;
		private System.Windows.Forms.ComboBox cmbCampo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.tbcDados = new System.Windows.Forms.TabControl();
			this.Dados = new System.Windows.Forms.TabPage();
			this.dvgDados = new System.Windows.Forms.DataGridView();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.cmbOperador = new System.Windows.Forms.ComboBox();
			this.cmbCampo = new System.Windows.Forms.ComboBox();
			this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbcDados.SuspendLayout();
			this.Dados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.Gold;
			this.btnNovo.Location = new System.Drawing.Point(13, 13);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(102, 43);
			this.btnNovo.TabIndex = 0;
			this.btnNovo.Text = "Inserir";
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.BtnNovoClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.Gold;
			this.btnSalvar.Location = new System.Drawing.Point(121, 13);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(102, 43);
			this.btnSalvar.TabIndex = 1;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Gold;
			this.btnCancelar.Location = new System.Drawing.Point(229, 13);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(102, 43);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.Gold;
			this.btnExcluir.Location = new System.Drawing.Point(337, 13);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(102, 43);
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			// 
			// tbcDados
			// 
			this.tbcDados.Controls.Add(this.Dados);
			this.tbcDados.Location = new System.Drawing.Point(13, 62);
			this.tbcDados.Name = "tbcDados";
			this.tbcDados.SelectedIndex = 0;
			this.tbcDados.Size = new System.Drawing.Size(641, 576);
			this.tbcDados.TabIndex = 4;
			// 
			// Dados
			// 
			this.Dados.BackColor = System.Drawing.Color.Goldenrod;
			this.Dados.Controls.Add(this.dvgDados);
			this.Dados.Controls.Add(this.btnPesquisar);
			this.Dados.Controls.Add(this.txtValor);
			this.Dados.Controls.Add(this.cmbOperador);
			this.Dados.Controls.Add(this.cmbCampo);
			this.Dados.Controls.Add(this.mskTelefone);
			this.Dados.Controls.Add(this.label3);
			this.Dados.Controls.Add(this.txtEmail);
			this.Dados.Controls.Add(this.label4);
			this.Dados.Controls.Add(this.txtNome);
			this.Dados.Controls.Add(this.label2);
			this.Dados.Controls.Add(this.txtCodigo);
			this.Dados.Controls.Add(this.label1);
			this.Dados.Location = new System.Drawing.Point(4, 25);
			this.Dados.Name = "Dados";
			this.Dados.Padding = new System.Windows.Forms.Padding(3);
			this.Dados.Size = new System.Drawing.Size(633, 547);
			this.Dados.TabIndex = 0;
			this.Dados.Text = "Dados";
			// 
			// dvgDados
			// 
			this.dvgDados.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgDados.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dvgDados.Location = new System.Drawing.Point(7, 306);
			this.dvgDados.Name = "dvgDados";
			this.dvgDados.RowTemplate.Height = 24;
			this.dvgDados.Size = new System.Drawing.Size(620, 235);
			this.dvgDados.TabIndex = 13;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(525, 264);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(105, 23);
			this.btnPesquisar.TabIndex = 12;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(320, 263);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(199, 22);
			this.txtValor.TabIndex = 11;
			// 
			// cmbOperador
			// 
			this.cmbOperador.FormattingEnabled = true;
			this.cmbOperador.Items.AddRange(new object[] {
			"=",
			">",
			"<",
			">=",
			"<=",
			"<>"});
			this.cmbOperador.Location = new System.Drawing.Point(166, 263);
			this.cmbOperador.Name = "cmbOperador";
			this.cmbOperador.Size = new System.Drawing.Size(148, 24);
			this.cmbOperador.TabIndex = 10;
			// 
			// cmbCampo
			// 
			this.cmbCampo.FormattingEnabled = true;
			this.cmbCampo.Items.AddRange(new object[] {
			"Codigo",
			"Nome",
			"Email",
			"Telefone"});
			this.cmbCampo.Location = new System.Drawing.Point(7, 263);
			this.cmbCampo.Name = "cmbCampo";
			this.cmbCampo.Size = new System.Drawing.Size(153, 24);
			this.cmbCampo.TabIndex = 9;
			// 
			// mskTelefone
			// 
			this.mskTelefone.Location = new System.Drawing.Point(7, 209);
			this.mskTelefone.Mask = "(00)0000-0000";
			this.mskTelefone.Name = "mskTelefone";
			this.mskTelefone.Size = new System.Drawing.Size(241, 22);
			this.mskTelefone.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(4, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(244, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Telefone";
			// 
			// txtEmail
			// 
			this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtEmail.Location = new System.Drawing.Point(7, 153);
			this.txtEmail.MaxLength = 150;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(241, 22);
			this.txtEmail.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(241, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Email";
			// 
			// txtNome
			// 
			this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNome.Location = new System.Drawing.Point(7, 90);
			this.txtNome.MaxLength = 50;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(241, 22);
			this.txtNome.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(241, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nome";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(7, 34);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(241, 22);
			this.txtCodigo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código";
			// 
			// FRMCONTATOS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(665, 650);
			this.Controls.Add(this.tbcDados);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnNovo);
			this.Name = "FRMCONTATOS";
			this.Text = "FRMCONTATOS";
			this.tbcDados.ResumeLayout(false);
			this.Dados.ResumeLayout(false);
			this.Dados.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
