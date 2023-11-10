using System;
using System.Drawing;
using System.Windows.Forms;

namespace SA02_FenDep
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();

		}
		
		private bool ValidarCampos(){
			return string.IsNullOrEmpty(txtUsuario.Text)||
				string.IsNullOrEmpty(txtSenha.Text);
		}
		void BtnLoginClick(object sender, EventArgs e)
		{
			AutenticacaoLogin logout = new AutenticacaoLogin();
			
			//Passar o conteúdo do textBoxs para o objeto
			logout.Usuario = txtUsuario.Text;
			logout.Senha = txtSenha.Text;
			
			//Verifica se usuario e senha são validos
			if(ValidarCampos())
			{
				MessageBox.Show("Preencha todos os campos!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			
			else
			{
				if (logout.Autenticador(logout)==true)
				{
					
					MessageBox.Show("Login efetuado com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
					//Oculatar o formulários de login
					this.Hide();
					
					//Exibe a tela principal
					FrmPrincipal frmPrincipal = new FrmPrincipal();
					frmPrincipal.Show();
				}
				
				else{
					MessageBox.Show("Usuário e senha inválidos!.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		void BtnSairClick(object sender, EventArgs e)
		{
			// Pergunta para verfiicar se desejá efetuar a ação
			DialogResult result = MessageBox.Show("Desaja realmente sair?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			
			if (result==DialogResult.Yes) {
				Application.Exit();
			}
		}
		void BtnOlhinClick(object sender, EventArgs e)
		{
			Bitmap b = new Bitmap(@"C:\Users\diask\Desktop\SA 02 - Func_Dep\Imagens\eye-off.ico");
			Bitmap b2 = new Bitmap(@"C:\Users\diask\Desktop\SA 02 - Func_Dep\Imagens\eye.ico");
			
			if (txtSenha.PasswordChar =='*')
			{
				btnOlhin.BackgroundImage = b;
				btnOlhin.BackgroundImageLayout = ImageLayout.Stretch;
				txtSenha.PasswordChar = '\0';
			}
			
			else{
				
				btnOlhin.BackgroundImage= b2;
				btnOlhin.BackgroundImageLayout = ImageLayout.Stretch;
				txtSenha.PasswordChar = '*';
			}
			
		}
		void FrmLoginLoad(object sender, EventArgs e)
		{
			Bitmap b2 = new Bitmap(@"C:\Users\diask\Desktop\SA 02 - Func_Dep\Imagens\eye.ico");
			btnOlhin.BackgroundImage = b2;
			btnOlhin.BackgroundImageLayout = ImageLayout.Stretch;
		}
	}
}
