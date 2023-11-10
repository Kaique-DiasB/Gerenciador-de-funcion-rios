using System;
using System.Drawing;
using System.Windows.Forms;

namespace SA02_FenDep
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();

		}
		void CadastroToolStripMenuItem1Click(object sender, EventArgs e)
		{
			FrmCadastro frmCadastro = new FrmCadastro();
			
			frmCadastro.Show();
		}
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			// Pergunta para verfiicar se desejá efetuar a ação
			DialogResult result = MessageBox.Show("Desaja realmente sair?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			
			if (result==DialogResult.Yes) {
				Application.Exit();
			}
		}
	}
}
