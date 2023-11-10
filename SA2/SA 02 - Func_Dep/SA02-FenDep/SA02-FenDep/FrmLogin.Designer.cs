/*
 * Created by SharpDevelop.
 * User: diask
 * Date: 22/06/2023
 * Time: 19:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SA02_FenDep
{
	partial class FrmLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lbUsuario;
		private System.Windows.Forms.PictureBox picLogin;
		private System.Windows.Forms.Button btnOlhin;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.btnSair = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lbUsuario = new System.Windows.Forms.Label();
			this.picLogin = new System.Windows.Forms.PictureBox();
			this.btnOlhin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(173, 187);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(81, 36);
			this.btnSair.TabIndex = 6;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(54, 187);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(81, 36);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(130, 117);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(170, 20);
			this.txtSenha.TabIndex = 4;
			// 
			// lblSenha
			// 
			this.lblSenha.Location = new System.Drawing.Point(130, 85);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(100, 23);
			this.lblSenha.TabIndex = 3;
			this.lblSenha.Text = "Senha:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(130, 56);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(170, 20);
			this.txtUsuario.TabIndex = 2;
			// 
			// lbUsuario
			// 
			this.lbUsuario.Location = new System.Drawing.Point(130, 24);
			this.lbUsuario.Name = "lbUsuario";
			this.lbUsuario.Size = new System.Drawing.Size(100, 23);
			this.lbUsuario.TabIndex = 1;
			this.lbUsuario.Text = "Usuario: ";
			// 
			// picLogin
			// 
			this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
			this.picLogin.Location = new System.Drawing.Point(11, 50);
			this.picLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.picLogin.Name = "picLogin";
			this.picLogin.Size = new System.Drawing.Size(100, 97);
			this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLogin.TabIndex = 7;
			this.picLogin.TabStop = false;
			// 
			// btnOlhin
			// 
			this.btnOlhin.BackColor = System.Drawing.Color.Transparent;
			this.btnOlhin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnOlhin.Location = new System.Drawing.Point(267, 143);
			this.btnOlhin.Name = "btnOlhin";
			this.btnOlhin.Size = new System.Drawing.Size(31, 28);
			this.btnOlhin.TabIndex = 8;
			this.btnOlhin.UseVisualStyleBackColor = false;
			this.btnOlhin.Click += new System.EventHandler(this.BtnOlhinClick);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 235);
			this.Controls.Add(this.btnOlhin);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lbUsuario);
			this.Controls.Add(this.picLogin);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.FrmLoginLoad);
			((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
