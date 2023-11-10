/*
 * Created by SharpDevelop.
 * User: diask
 * Date: 22/06/2023
 * Time: 19:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SA02_FenDep
{
	partial class FrmCadastro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblTextoPesquisar;
		private System.Windows.Forms.TextBox txtTextoPesquisar;
		private System.Windows.Forms.TabControl tabCadastros;
		private System.Windows.Forms.TabPage tpFuncionario;
		private System.Windows.Forms.Button btnExcluirf;
		private System.Windows.Forms.Button btnAtualizarf;
		private System.Windows.Forms.Button btnGravarf;
		private System.Windows.Forms.Panel pnlFuncionario;
		private System.Windows.Forms.ComboBox cboSetor;
		private System.Windows.Forms.Label lblSetor;
		private System.Windows.Forms.MaskedTextBox mtxCPF;
		private System.Windows.Forms.Label lblCPF;
		private System.Windows.Forms.TextBox txtNomef;
		private System.Windows.Forms.Label lblNomef;
		private System.Windows.Forms.TextBox txtIDf;
		private System.Windows.Forms.Label lblIDf;
		private System.Windows.Forms.DataGridView dgvFuncionarios;
		private System.Windows.Forms.TabPage tpDependente;
		private System.Windows.Forms.Button btnExcluird;
		private System.Windows.Forms.Button btnAtualizard;
		private System.Windows.Forms.Button btnGravard;
		private System.Windows.Forms.Panel pnlDependentes;
		private System.Windows.Forms.DataGridView dgvDependentes;
		private System.Windows.Forms.DateTimePicker dtpDataNasc;
		private System.Windows.Forms.ComboBox cboSexo;
		private System.Windows.Forms.Label lblSexo;
		private System.Windows.Forms.Label lblDataNasc;
		private System.Windows.Forms.TextBox txtNomed;
		private System.Windows.Forms.Label lblNomed;
		private System.Windows.Forms.TextBox txtIDd;
		private System.Windows.Forms.Label lblIDd;
		private System.Windows.Forms.Button btnLimparf;
		private System.Windows.Forms.Button btnLimpard;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
			this.lblTextoPesquisar = new System.Windows.Forms.Label();
			this.txtTextoPesquisar = new System.Windows.Forms.TextBox();
			this.tabCadastros = new System.Windows.Forms.TabControl();
			this.tpFuncionario = new System.Windows.Forms.TabPage();
			this.btnLimparf = new System.Windows.Forms.Button();
			this.btnExcluirf = new System.Windows.Forms.Button();
			this.btnAtualizarf = new System.Windows.Forms.Button();
			this.btnGravarf = new System.Windows.Forms.Button();
			this.pnlFuncionario = new System.Windows.Forms.Panel();
			this.cboSetor = new System.Windows.Forms.ComboBox();
			this.lblSetor = new System.Windows.Forms.Label();
			this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
			this.lblCPF = new System.Windows.Forms.Label();
			this.txtNomef = new System.Windows.Forms.TextBox();
			this.lblNomef = new System.Windows.Forms.Label();
			this.txtIDf = new System.Windows.Forms.TextBox();
			this.lblIDf = new System.Windows.Forms.Label();
			this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
			this.tpDependente = new System.Windows.Forms.TabPage();
			this.btnLimpard = new System.Windows.Forms.Button();
			this.btnExcluird = new System.Windows.Forms.Button();
			this.btnAtualizard = new System.Windows.Forms.Button();
			this.btnGravard = new System.Windows.Forms.Button();
			this.pnlDependentes = new System.Windows.Forms.Panel();
			this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
			this.cboSexo = new System.Windows.Forms.ComboBox();
			this.lblSexo = new System.Windows.Forms.Label();
			this.lblDataNasc = new System.Windows.Forms.Label();
			this.txtNomed = new System.Windows.Forms.TextBox();
			this.lblNomed = new System.Windows.Forms.Label();
			this.txtIDd = new System.Windows.Forms.TextBox();
			this.lblIDd = new System.Windows.Forms.Label();
			this.dgvDependentes = new System.Windows.Forms.DataGridView();
			this.tabCadastros.SuspendLayout();
			this.tpFuncionario.SuspendLayout();
			this.pnlFuncionario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
			this.tpDependente.SuspendLayout();
			this.pnlDependentes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDependentes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTextoPesquisar
			// 
			this.lblTextoPesquisar.Location = new System.Drawing.Point(29, 17);
			this.lblTextoPesquisar.Name = "lblTextoPesquisar";
			this.lblTextoPesquisar.Size = new System.Drawing.Size(189, 27);
			this.lblTextoPesquisar.TabIndex = 0;
			this.lblTextoPesquisar.Text = "Digite o nome do funcionário: ";
			// 
			// txtTextoPesquisar
			// 
			this.txtTextoPesquisar.Location = new System.Drawing.Point(224, 19);
			this.txtTextoPesquisar.Name = "txtTextoPesquisar";
			this.txtTextoPesquisar.Size = new System.Drawing.Size(412, 23);
			this.txtTextoPesquisar.TabIndex = 1;
			this.txtTextoPesquisar.TextChanged += new System.EventHandler(this.TxtTextoPesquisarTextChanged);
			// 
			// tabCadastros
			// 
			this.tabCadastros.Controls.Add(this.tpFuncionario);
			this.tabCadastros.Controls.Add(this.tpDependente);
			this.tabCadastros.Location = new System.Drawing.Point(21, 52);
			this.tabCadastros.Name = "tabCadastros";
			this.tabCadastros.SelectedIndex = 0;
			this.tabCadastros.Size = new System.Drawing.Size(619, 307);
			this.tabCadastros.TabIndex = 2;
			// 
			// tpFuncionario
			// 
			this.tpFuncionario.Controls.Add(this.btnLimparf);
			this.tpFuncionario.Controls.Add(this.btnExcluirf);
			this.tpFuncionario.Controls.Add(this.btnAtualizarf);
			this.tpFuncionario.Controls.Add(this.btnGravarf);
			this.tpFuncionario.Controls.Add(this.pnlFuncionario);
			this.tpFuncionario.Location = new System.Drawing.Point(4, 24);
			this.tpFuncionario.Name = "tpFuncionario";
			this.tpFuncionario.Padding = new System.Windows.Forms.Padding(3);
			this.tpFuncionario.Size = new System.Drawing.Size(611, 279);
			this.tpFuncionario.TabIndex = 0;
			this.tpFuncionario.Text = "Funcionário";
			this.tpFuncionario.UseVisualStyleBackColor = true;
			// 
			// btnLimparf
			// 
			this.btnLimparf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimparf.BackgroundImage")));
			this.btnLimparf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimparf.Location = new System.Drawing.Point(574, 247);
			this.btnLimparf.Name = "btnLimparf";
			this.btnLimparf.Size = new System.Drawing.Size(31, 29);
			this.btnLimparf.TabIndex = 5;
			this.btnLimparf.UseVisualStyleBackColor = true;
			this.btnLimparf.Click += new System.EventHandler(this.BtnLimparfClick);
			// 
			// btnExcluirf
			// 
			this.btnExcluirf.Location = new System.Drawing.Point(384, 250);
			this.btnExcluirf.Name = "btnExcluirf";
			this.btnExcluirf.Size = new System.Drawing.Size(75, 23);
			this.btnExcluirf.TabIndex = 4;
			this.btnExcluirf.Text = "Excluir";
			this.btnExcluirf.UseVisualStyleBackColor = true;
			this.btnExcluirf.Click += new System.EventHandler(this.BtnExcluirfClick);
			// 
			// btnAtualizarf
			// 
			this.btnAtualizarf.Location = new System.Drawing.Point(268, 250);
			this.btnAtualizarf.Name = "btnAtualizarf";
			this.btnAtualizarf.Size = new System.Drawing.Size(75, 23);
			this.btnAtualizarf.TabIndex = 3;
			this.btnAtualizarf.Text = "Atualizar";
			this.btnAtualizarf.UseVisualStyleBackColor = true;
			this.btnAtualizarf.Click += new System.EventHandler(this.BtnAtualizarfClick);
			// 
			// btnGravarf
			// 
			this.btnGravarf.Location = new System.Drawing.Point(152, 250);
			this.btnGravarf.Name = "btnGravarf";
			this.btnGravarf.Size = new System.Drawing.Size(75, 23);
			this.btnGravarf.TabIndex = 2;
			this.btnGravarf.Text = "Gravar";
			this.btnGravarf.UseVisualStyleBackColor = true;
			this.btnGravarf.Click += new System.EventHandler(this.BtnGravarfClick);
			// 
			// pnlFuncionario
			// 
			this.pnlFuncionario.Controls.Add(this.cboSetor);
			this.pnlFuncionario.Controls.Add(this.lblSetor);
			this.pnlFuncionario.Controls.Add(this.mtxCPF);
			this.pnlFuncionario.Controls.Add(this.lblCPF);
			this.pnlFuncionario.Controls.Add(this.txtNomef);
			this.pnlFuncionario.Controls.Add(this.lblNomef);
			this.pnlFuncionario.Controls.Add(this.txtIDf);
			this.pnlFuncionario.Controls.Add(this.lblIDf);
			this.pnlFuncionario.Controls.Add(this.dgvFuncionarios);
			this.pnlFuncionario.Location = new System.Drawing.Point(6, 6);
			this.pnlFuncionario.Name = "pnlFuncionario";
			this.pnlFuncionario.Size = new System.Drawing.Size(599, 238);
			this.pnlFuncionario.TabIndex = 1;
			// 
			// cboSetor
			// 
			this.cboSetor.FormattingEnabled = true;
			this.cboSetor.Location = new System.Drawing.Point(422, 203);
			this.cboSetor.Name = "cboSetor";
			this.cboSetor.Size = new System.Drawing.Size(164, 23);
			this.cboSetor.TabIndex = 9;
			// 
			// lblSetor
			// 
			this.lblSetor.Location = new System.Drawing.Point(364, 203);
			this.lblSetor.Name = "lblSetor";
			this.lblSetor.Size = new System.Drawing.Size(52, 23);
			this.lblSetor.TabIndex = 8;
			this.lblSetor.Text = "Setor:";
			// 
			// mtxCPF
			// 
			this.mtxCPF.Location = new System.Drawing.Point(60, 203);
			this.mtxCPF.Mask = "000.000.000-00";
			this.mtxCPF.Name = "mtxCPF";
			this.mtxCPF.Size = new System.Drawing.Size(168, 23);
			this.mtxCPF.TabIndex = 7;
			this.mtxCPF.Validated += new System.EventHandler(this.MtxCPFValidated);
			// 
			// lblCPF
			// 
			this.lblCPF.Location = new System.Drawing.Point(13, 203);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(52, 23);
			this.lblCPF.TabIndex = 6;
			this.lblCPF.Text = "CPF:";
			// 
			// txtNomef
			// 
			this.txtNomef.Location = new System.Drawing.Point(60, 174);
			this.txtNomef.Name = "txtNomef";
			this.txtNomef.Size = new System.Drawing.Size(526, 23);
			this.txtNomef.TabIndex = 5;
			this.txtNomef.Validated += new System.EventHandler(this.TxtNomefValidated);
			// 
			// lblNomef
			// 
			this.lblNomef.Location = new System.Drawing.Point(13, 174);
			this.lblNomef.Name = "lblNomef";
			this.lblNomef.Size = new System.Drawing.Size(52, 23);
			this.lblNomef.TabIndex = 4;
			this.lblNomef.Text = "Nome:";
			// 
			// txtIDf
			// 
			this.txtIDf.Enabled = false;
			this.txtIDf.Location = new System.Drawing.Point(60, 145);
			this.txtIDf.Name = "txtIDf";
			this.txtIDf.Size = new System.Drawing.Size(100, 23);
			this.txtIDf.TabIndex = 3;
			// 
			// lblIDf
			// 
			this.lblIDf.Location = new System.Drawing.Point(13, 145);
			this.lblIDf.Name = "lblIDf";
			this.lblIDf.Size = new System.Drawing.Size(52, 23);
			this.lblIDf.TabIndex = 2;
			this.lblIDf.Text = "ID:";
			// 
			// dgvFuncionarios
			// 
			this.dgvFuncionarios.AllowUserToAddRows = false;
			this.dgvFuncionarios.AllowUserToDeleteRows = false;
			this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFuncionarios.Location = new System.Drawing.Point(16, 3);
			this.dgvFuncionarios.Name = "dgvFuncionarios";
			this.dgvFuncionarios.ReadOnly = true;
			this.dgvFuncionarios.Size = new System.Drawing.Size(570, 136);
			this.dgvFuncionarios.TabIndex = 1;
			this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFuncionariosCellClick);
			// 
			// tpDependente
			// 
			this.tpDependente.Controls.Add(this.btnLimpard);
			this.tpDependente.Controls.Add(this.btnExcluird);
			this.tpDependente.Controls.Add(this.btnAtualizard);
			this.tpDependente.Controls.Add(this.btnGravard);
			this.tpDependente.Controls.Add(this.pnlDependentes);
			this.tpDependente.Location = new System.Drawing.Point(4, 24);
			this.tpDependente.Name = "tpDependente";
			this.tpDependente.Padding = new System.Windows.Forms.Padding(3);
			this.tpDependente.Size = new System.Drawing.Size(611, 279);
			this.tpDependente.TabIndex = 1;
			this.tpDependente.Text = "Dependente";
			this.tpDependente.UseVisualStyleBackColor = true;
			// 
			// btnLimpard
			// 
			this.btnLimpard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpard.BackgroundImage")));
			this.btnLimpard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimpard.Location = new System.Drawing.Point(574, 247);
			this.btnLimpard.Name = "btnLimpard";
			this.btnLimpard.Size = new System.Drawing.Size(31, 29);
			this.btnLimpard.TabIndex = 8;
			this.btnLimpard.UseVisualStyleBackColor = true;
			this.btnLimpard.Click += new System.EventHandler(this.BtnLimpardClick);
			// 
			// btnExcluird
			// 
			this.btnExcluird.Location = new System.Drawing.Point(384, 250);
			this.btnExcluird.Name = "btnExcluird";
			this.btnExcluird.Size = new System.Drawing.Size(75, 23);
			this.btnExcluird.TabIndex = 7;
			this.btnExcluird.Text = "Excluir";
			this.btnExcluird.UseVisualStyleBackColor = true;
			this.btnExcluird.Click += new System.EventHandler(this.BtnExcluirdClick);
			// 
			// btnAtualizard
			// 
			this.btnAtualizard.Location = new System.Drawing.Point(267, 250);
			this.btnAtualizard.Name = "btnAtualizard";
			this.btnAtualizard.Size = new System.Drawing.Size(75, 23);
			this.btnAtualizard.TabIndex = 6;
			this.btnAtualizard.Text = "Atualizar";
			this.btnAtualizard.UseVisualStyleBackColor = true;
			this.btnAtualizard.Click += new System.EventHandler(this.BtnAtualizardClick);
			// 
			// btnGravard
			// 
			this.btnGravard.Location = new System.Drawing.Point(152, 250);
			this.btnGravard.Name = "btnGravard";
			this.btnGravard.Size = new System.Drawing.Size(75, 23);
			this.btnGravard.TabIndex = 5;
			this.btnGravard.Text = "Gravar";
			this.btnGravard.UseVisualStyleBackColor = true;
			this.btnGravard.Click += new System.EventHandler(this.BtnGravardClick);
			// 
			// pnlDependentes
			// 
			this.pnlDependentes.Controls.Add(this.dtpDataNasc);
			this.pnlDependentes.Controls.Add(this.cboSexo);
			this.pnlDependentes.Controls.Add(this.lblSexo);
			this.pnlDependentes.Controls.Add(this.lblDataNasc);
			this.pnlDependentes.Controls.Add(this.txtNomed);
			this.pnlDependentes.Controls.Add(this.lblNomed);
			this.pnlDependentes.Controls.Add(this.txtIDd);
			this.pnlDependentes.Controls.Add(this.lblIDd);
			this.pnlDependentes.Controls.Add(this.dgvDependentes);
			this.pnlDependentes.Location = new System.Drawing.Point(6, 6);
			this.pnlDependentes.Name = "pnlDependentes";
			this.pnlDependentes.Size = new System.Drawing.Size(599, 238);
			this.pnlDependentes.TabIndex = 0;
			// 
			// dtpDataNasc
			// 
			this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataNasc.Location = new System.Drawing.Point(102, 203);
			this.dtpDataNasc.Name = "dtpDataNasc";
			this.dtpDataNasc.Size = new System.Drawing.Size(103, 23);
			this.dtpDataNasc.TabIndex = 18;
			// 
			// cboSexo
			// 
			this.cboSexo.FormattingEnabled = true;
			this.cboSexo.Location = new System.Drawing.Point(420, 203);
			this.cboSexo.Name = "cboSexo";
			this.cboSexo.Size = new System.Drawing.Size(164, 23);
			this.cboSexo.TabIndex = 17;
			// 
			// lblSexo
			// 
			this.lblSexo.Location = new System.Drawing.Point(362, 203);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(52, 23);
			this.lblSexo.TabIndex = 16;
			this.lblSexo.Text = "Sexo:";
			// 
			// lblDataNasc
			// 
			this.lblDataNasc.Location = new System.Drawing.Point(14, 203);
			this.lblDataNasc.Name = "lblDataNasc";
			this.lblDataNasc.Size = new System.Drawing.Size(82, 23);
			this.lblDataNasc.TabIndex = 14;
			this.lblDataNasc.Text = "Data de Nasc.:";
			// 
			// txtNomed
			// 
			this.txtNomed.Location = new System.Drawing.Point(61, 174);
			this.txtNomed.Name = "txtNomed";
			this.txtNomed.Size = new System.Drawing.Size(523, 23);
			this.txtNomed.TabIndex = 13;
			this.txtNomed.Validated += new System.EventHandler(this.TxtNomedValidated);
			// 
			// lblNomed
			// 
			this.lblNomed.Location = new System.Drawing.Point(14, 174);
			this.lblNomed.Name = "lblNomed";
			this.lblNomed.Size = new System.Drawing.Size(52, 23);
			this.lblNomed.TabIndex = 12;
			this.lblNomed.Text = "Nome:";
			// 
			// txtIDd
			// 
			this.txtIDd.Enabled = false;
			this.txtIDd.Location = new System.Drawing.Point(61, 145);
			this.txtIDd.Name = "txtIDd";
			this.txtIDd.Size = new System.Drawing.Size(100, 23);
			this.txtIDd.TabIndex = 11;
			// 
			// lblIDd
			// 
			this.lblIDd.Location = new System.Drawing.Point(14, 145);
			this.lblIDd.Name = "lblIDd";
			this.lblIDd.Size = new System.Drawing.Size(52, 23);
			this.lblIDd.TabIndex = 10;
			this.lblIDd.Text = "ID:";
			// 
			// dgvDependentes
			// 
			this.dgvDependentes.AllowUserToAddRows = false;
			this.dgvDependentes.AllowUserToDeleteRows = false;
			this.dgvDependentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDependentes.Location = new System.Drawing.Point(14, 3);
			this.dgvDependentes.Name = "dgvDependentes";
			this.dgvDependentes.ReadOnly = true;
			this.dgvDependentes.Size = new System.Drawing.Size(570, 136);
			this.dgvDependentes.TabIndex = 0;
			this.dgvDependentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDependentesCellClick);
			// 
			// FrmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(660, 380);
			this.Controls.Add(this.tabCadastros);
			this.Controls.Add(this.txtTextoPesquisar);
			this.Controls.Add(this.lblTextoPesquisar);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FrmCadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Funcionario";
			this.Load += new System.EventHandler(this.FrmCadastroLoad);
			this.tabCadastros.ResumeLayout(false);
			this.tpFuncionario.ResumeLayout(false);
			this.pnlFuncionario.ResumeLayout(false);
			this.pnlFuncionario.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
			this.tpDependente.ResumeLayout(false);
			this.pnlDependentes.ResumeLayout(false);
			this.pnlDependentes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDependentes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
