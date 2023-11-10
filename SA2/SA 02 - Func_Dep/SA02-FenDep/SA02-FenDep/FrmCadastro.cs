using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SA02_FenDep
{
	public partial class FrmCadastro : Form
	{
		public FrmCadastro()
		{
			InitializeComponent();
			PreencherCboSetores();
			PreencherCboSexo();
			PreecherDataGriedViewF();
			PreecherDataGriedViewD();
		}
		
		private void PreencherCboSetores()
		{
			Setor osetor = new Setor();
			cboSetor.DataSource = osetor.SelecionarSetores();
			cboSetor.ValueMember = "id";
			cboSetor.DisplayMember = "nome";
			cboSetor.Refresh();
		}
		
		private void PreencherCboSexo()
		{
			Sexo osexo = new Sexo();
			cboSexo.DataSource = osexo.SelecionarGeneros();
			cboSexo.ValueMember = "id";
			cboSexo.DisplayMember = "sexo";
			cboSexo.Refresh();
		}
		
		private void PreecherDataGriedViewF()
		{
			Funcionario ofun = new Funcionario();
			
			dgvFuncionarios.DataSource = ofun.ListarTodosFuncionarios();
			
			dgvFuncionarios.Refresh();
		}
		
		private void PreecherDataGriedViewD()
		{
			Dependente odep = new Dependente();
			
			dgvDependentes.DataSource = odep.ListarTodosDependentes();
			
			dgvDependentes.Refresh();
		}
		
		void TxtTextoPesquisarTextChanged(object sender, EventArgs e)
		{
			// Dgv Funcionarios
			Funcionario ofun = new Funcionario();
			
			dgvFuncionarios.DataSource = ofun.ListarPorNomeFuncionarios(txtTextoPesquisar.Text);
			
			dgvFuncionarios.Refresh();
			
			// Dgv Dependentes
			Dependente odep = new Dependente();
			
			dgvDependentes.DataSource = odep.ListarPorNomeDependentes(txtTextoPesquisar.Text);
			
			dgvDependentes.Refresh();
			
		}
		
		public void LimparCamposF()
		{
			txtIDf.Text = string.Empty;
			txtNomef.Text = string.Empty;
			txtTextoPesquisar.Text = string.Empty;
			mtxCPF.Text = string.Empty;
			cboSetor.SelectedItem = -1;
			
		}
		
		public void LimparCamposD()
		{
			txtIDd.Text = string.Empty;
			txtNomed.Text = string.Empty;
			txtTextoPesquisar.Text = string.Empty;
			dtpDataNasc.Value = DateTime.Now;
			cboSexo.SelectedItem = -1;
			
		}
		
		public bool ValidadorDeCPF()
		{	CPF teste = new CPF();
			
			if(teste.VerificadorF(mtxCPF.Text)==false)
			{
				MessageBox.Show("CPF Invalido");
				mtxCPF.Focus();
				return false;
			}
			else
			{
				return true;
			}
		}
		
		public bool ValidarCamposF()
		{
			if(string.IsNullOrEmpty(txtNomef.Text))
			{
				MessageBox.Show("Preencha o nome do funcionário!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtNomef.Focus();
				return false;
			}
			
			else if(mtxCPF.Text == "   ,   ,   -")
			{
				MessageBox.Show("Preencha o CPF do funcionário!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				mtxCPF.Focus();
				return false;
			}
			
			else if(string.IsNullOrEmpty(cboSetor.Text))
			{
				MessageBox.Show("Escolha um setor!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				cboSetor.Focus();
				return false;
			}
			
			else
			{
				return true;
			}
			
		}
		
		public bool ValidarCamposD()
		{
			if(string.IsNullOrEmpty(txtIDf.Text))
			{
				MessageBox.Show("Selecione um funcionário!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				tpFuncionario.Focus();
				return false;
			}
			
			else if(string.IsNullOrEmpty(txtNomed.Text))
			{
				MessageBox.Show("Preencha o nome do dependente!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtNomed.Focus();
				return false;
			}
			
			else if(dtpDataNasc.Value>DateTime.Now)
			{
				MessageBox.Show("Preencha uma data valida!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				dtpDataNasc.Focus();
				return false;
			}
			
			else if(string.IsNullOrEmpty(cboSexo.Text))
			{
				MessageBox.Show("Selecione um gênero!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				cboSexo.Focus();
				return false;
			}
			
			else
			{
				return true;
			}
			
			
		}
		
		void DgvFuncionariosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
			{
				// Passar os dados do banco para os textboxs
				txtIDf.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtNomef.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
				mtxCPF.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString().Replace(".", string.Empty).Replace(",", string.Empty).Replace("-", string.Empty);;
				cboSetor.SelectedValue = dgvFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
				Dependente odep = new Dependente();
				dgvDependentes.DataSource = odep.ListarPorNomeDependentes(txtNomef.Text);
			}
		}
		
		void DgvDependentesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
			{
				// Passar os dados do banco para os textboxs
				txtIDd.Text = dgvDependentes.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtNomed.Text = dgvDependentes.Rows[e.RowIndex].Cells[1].Value.ToString();
				dtpDataNasc.Value = DateTime.Parse(dgvDependentes.Rows[e.RowIndex].Cells[2].Value.ToString());
				cboSexo.SelectedValue = dgvDependentes.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtIDf.Text = dgvDependentes.Rows[e.RowIndex].Cells[4].Value.ToString();
				
			}
		}
		
		void BtnGravarfClick(object sender, EventArgs e)
		{
			try
			{
				if(ValidarCamposF()==false){}
				else{
					Funcionario funcionario =  null;
					
					// Instanciar objeto
					funcionario = new Funcionario();
					
					// Passando conteúdo preenchido para as propriedades do objeto
					funcionario.Nome = txtNomef.Text;
					funcionario.Cpf = mtxCPF.Text.Replace(".", string.Empty).Replace(",", string.Empty).Replace("-", string.Empty);;
					funcionario.Setorid = (int)cboSetor.SelectedValue;
					
					// Acessando o metódo e passando os dados atráves do objeto
					funcionario.InserirFuncionario(funcionario);
					
					//Messagem de Realização da Ação
					MessageBox.Show("Registro inserido com sucesso!","Sucessso",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
					//PreencherDataGriedView
					PreecherDataGriedViewF();
					
					//Limpar os campos
					LimparCamposF();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		void BtnAtualizarfClick(object sender, EventArgs e)
		{
			
			try
			{
				if(ValidarCamposF()==false){}
				else{
					Funcionario funcionario =  null;
					
					// Instanciar objeto
					funcionario = new Funcionario();
					
					// Passando conteúdo preenchido para as propriedades do objeto
					funcionario.Id = int.Parse(txtIDf.Text);
					funcionario.Nome = txtNomef.Text;
					funcionario.Cpf = mtxCPF.Text.Replace(".", string.Empty).Replace(",", string.Empty).Replace("-", string.Empty);;
					funcionario.Setorid = (int)cboSetor.SelectedValue;
					
					// Acessando o metódo e passando os dados atráves do objeto
					funcionario.AtualizarFuncionario(funcionario);
					
					//Messagem de Realização da Ação
					MessageBox.Show("Registro atualizado com sucesso!","Sucessso",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
					//PreencherDataGriedView
					PreecherDataGriedViewF();
					
					//Limpar os campos
					LimparCamposF();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			
		}
		
		void BtnExcluirfClick(object sender, EventArgs e)
		{
			Funcionario funcionario = null;
			Dependente odep = null;
			int codigoid = 0;
			
			try {
				//Pergunta para efetuar a exclusão
				DialogResult result = MessageBox.Show("Deseja realmente excluir o registro?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
				
				if (result == DialogResult.Yes)
				{
					//Intanciar o objeto
					funcionario = new Funcionario();
					odep = new Dependente();
					
					//Passando o valor do Textbox para o objeto
					codigoid = int.Parse(txtIDf.Text);
					
					//Executando o metódo de Exclusão
					funcionario.ExcluirFuncionario(codigoid);
					odep.ExcluirDependenteAtF(codigoid);
					
					//Mensagem de sucesso
					MessageBox.Show("Registro excluído com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
					//Atualizar o DataGriedView
					PreecherDataGriedViewF();
					PreecherDataGriedViewD();
					
					//Limpar Textboxs
					LimparCamposF();
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		void BtnGravardClick(object sender, EventArgs e)
		{
			try
			{
				if(ValidarCamposD()==false){}
				else{
					Dependente dependente =  null;
					
					// Instanciar objeto
					dependente = new Dependente();
					
					// Passando conteúdo preenchido para as propriedades do objeto
					dependente.Nome = txtNomed.Text;
					dependente.Datanasc = DateTime.Parse(dtpDataNasc.Value.ToShortDateString());
					dependente.GeneroId = (int)cboSexo.SelectedValue;
					dependente.FuncionarioId = int.Parse(txtIDf.Text);
					
					// Acessando o metódo e passando os dados atráves do objeto
					dependente.InserirDependente(dependente);
					
					//Messagem de Realização da Ação
					MessageBox.Show("Registro inserido com sucesso!","Sucessso",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
					//PreencherDataGriedView
					PreecherDataGriedViewD();
					
					//Limpar os campos
					LimparCamposD();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		void BtnAtualizardClick(object sender, EventArgs e)
		{
			try
			{
				if(ValidarCamposD()==false){}
				else{
					Dependente dependente =  null;
					
					// Instanciar objeto
					dependente = new Dependente();
					
					// Passando conteúdo preenchido para as propriedades do objeto
					dependente.Id = int.Parse(txtIDd.Text);
					dependente.Nome = txtNomed.Text;
					dependente.Datanasc = DateTime.Parse(dtpDataNasc.Value.ToShortDateString());
					dependente.GeneroId = (int)cboSexo.SelectedValue;
					dependente.FuncionarioId = int.Parse(txtIDf.Text);
					
					// Acessando o metódo e passando os dados atráves do objeto
					dependente.AtualizarDependente(dependente);
					
					//Messagem de Realização da Ação
					MessageBox.Show("Registro atualizado com sucesso!","Sucessso",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
					//PreencherDataGriedView
					PreecherDataGriedViewD();
					
					//Limpar os campos
					LimparCamposD();
					LimparCamposF();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		void BtnExcluirdClick(object sender, EventArgs e)
		{
			Dependente dependente =  null;
			int codigoid = 0;
			
			try {
				//Pergunta para efetuar a exclusão
				DialogResult result = MessageBox.Show("Deseja realmente excluir o registro?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
				
				if (result == DialogResult.Yes)
				{
					//Intanciar o objeto
					dependente = new Dependente();
					
					//Passando o valor do Textbox para o objeto
					codigoid = int.Parse(txtIDd.Text);
					
					//Executando o metódo de Exclusão
					dependente.ExcluirDependente(codigoid);
					
					//Mensagem de sucesso
					MessageBox.Show("Registro excluído com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
					//Atualizar o DataGriedView
					PreecherDataGriedViewD();
					
					//Limpar Textboxs
					LimparCamposD();
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		void FrmCadastroLoad(object sender, EventArgs e)
		{
			
			// DataGriedView Funcionarios
			// Define o nome das colunas para apresentação
			dgvFuncionarios.Columns["id"].HeaderText = "ID";
			dgvFuncionarios.Columns["nome"].HeaderText = "Nome";
			dgvFuncionarios.Columns["cpf"].HeaderText = "CPF";
			dgvFuncionarios.Columns["setorid"].HeaderText = "SetorID";
			dgvFuncionarios.Columns["id1"].HeaderText = "SetorID2";
			dgvFuncionarios.Columns["nome1"].HeaderText = "Setor";
			
			// Define o tamanho da Coluna
			dgvFuncionarios.Columns["id"].Width = 32;
			dgvFuncionarios.Columns["nome"].Width = 180;
			dgvFuncionarios.Columns["cpf"].Width = 100;
			dgvFuncionarios.Columns["setorid"].Visible =false;
			dgvFuncionarios.Columns["id1"].Visible =false;
			dgvFuncionarios.Columns["nome1"].Width = 100;
			
			// Define a posição dos nomes das colunas
			dgvFuncionarios.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvFuncionarios.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvFuncionarios.Columns["cpf"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvFuncionarios.Columns["setorid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvFuncionarios.Columns["id1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvFuncionarios.Columns["nome1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			
			
			// Define a posição das celulas da colunas
			dgvFuncionarios.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvFuncionarios.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvFuncionarios.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvFuncionarios.Columns["setorid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvFuncionarios.Columns["id1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvFuncionarios.Columns["nome1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			
			// DataGriedView Dependentes
			//Define o tamanho da Coluna

			dgvDependentes.Columns["id"].Width = 32;
			dgvDependentes.Columns["nome"].Width = 180;
			dgvDependentes.Columns["datanasc"].Width = 120;
			dgvDependentes.Columns["sexoid"].Visible =false;
			dgvDependentes.Columns["funcionarioid"].Visible =false;
			dgvDependentes.Columns["id1"].Visible =false;
			dgvDependentes.Columns["sexo"].Width = 100;
			dgvDependentes.Columns["id2"].Visible =false;
			dgvDependentes.Columns["nome1"].Width = 180;
			
			// Define o nome das colunas para apresentação
			dgvDependentes.Columns["id"].HeaderText = "ID";
			dgvDependentes.Columns["nome"].HeaderText = "Nome";
			dgvDependentes.Columns["datanasc"].HeaderText = "Data de Nascimento";
			dgvDependentes.Columns["sexoid"].HeaderText = "sexoid";
			dgvDependentes.Columns["funcionarioid"].HeaderText = "funcionarioid";
			dgvDependentes.Columns["id1"].HeaderText = "Sexoid";
			dgvDependentes.Columns["sexo"].HeaderText = "Sexo";
			dgvDependentes.Columns["id2"].HeaderText = "funcionarioid2";
			dgvDependentes.Columns["nome1"].HeaderText = "Funcionário";
			
			// Define a posição dos nomes das colunas
			dgvDependentes.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["datanasc"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["sexoid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["funcionarioid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["id1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["sexo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["id2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["nome1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			
			
			// Define a posição das celulas da colunas
			dgvDependentes.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["datanasc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["sexoid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["funcionarioid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["id1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["sexo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["id2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDependentes.Columns["nome1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			
			
		}
		
		void MtxCPFValidated(object sender, EventArgs e)
		{
			if(ValidadorDeCPF()==false){}
		}
		
		void TxtNomefValidated(object sender, EventArgs e)
		{
			bool Soletras = Regex.IsMatch(txtNomef.Text, "^[a-zA-Z ]+$");
			
			if (Soletras==false) {
				MessageBox.Show("Digite somente letras não acentuadas!");
				
				txtNomef.Focus();
			}
		}
		
		void TxtNomedValidated(object sender, EventArgs e)
		{
			bool Soletras = Regex.IsMatch(txtNomed.Text, "^[a-zA-Z ]+$");
			
			if (Soletras==false) {
				MessageBox.Show("Digite somente letras não acentuadas!");
				txtNomed.Focus();
			}
		}
		void BtnLimparfClick(object sender, EventArgs e)
		{
			LimparCamposF();
			PreecherDataGriedViewF();
			PreecherDataGriedViewD();
		}
		void BtnLimpardClick(object sender, EventArgs e)
		{
			LimparCamposD();
			PreecherDataGriedViewD();
		}
		
		
	}
}
