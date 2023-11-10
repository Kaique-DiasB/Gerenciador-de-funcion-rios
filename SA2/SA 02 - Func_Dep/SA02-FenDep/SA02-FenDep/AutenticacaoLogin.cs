using System;
using MySql.Data.MySqlClient;

namespace SA02_FenDep
{
	public class AutenticacaoLogin
	{
		#region Atributos
		private string usuario;
		private string senha;
		#endregion
		
		#region Propriedades
		public string Usuario
		{
			get{return usuario;}
			set{usuario = value;}
		}
		public string Senha
		{
			get{return senha;}
			set{senha = value;}
		}
		#endregion
		
		public AutenticacaoLogin()
		{
		}
		
		
		public bool Autenticador(AutenticacaoLogin user)
		{
			MySqlConnection conn = null;
			MySqlCommand cmd= null;
			MySqlDataReader reader = null;
			
			try {
				// Connection
				conn = new MySqlConnection();
				conn.ConnectionString = ConexaoDB.StringConnection;
				
				// MysqlCommand
				cmd = new MySqlCommand();
				cmd.Connection = conn;
				
				// Paramentros
				cmd.Parameters.AddWithValue("@nome",user.Usuario);
				
				// Querry (SQL)
				cmd.CommandText = "SELECT username,pwd FROM usuarios WHERE username = @nome;";
				
				// Abrindo Connection
				conn.Open();
				
				// Executar Reader
				reader = cmd.ExecuteReader();
				
				if (reader.HasRows)
                {
                    reader.Read();
                    if (user.Usuario.Equals(reader["username"].ToString()) && user.Senha.Equals(reader["pwd"].ToString()))
                    {
                    	return true;
                    }
                    else
                    {
                    	return false;
                    }
                }
				
                //Se ele não encontrar o usuario no BD, ele não retorna linha!
                else
                {	
                	return false;
                }
			}
			
			catch (MySqlException ex) {
				throw new Exception ("Servidor SQL Erro: " + ex.Number);
			}
			catch (Exception ex) {
				throw new Exception ("Erro " + ex.Message);
			} finally {
				// Fechar DataReader
				reader.Close();
				
				//Fechar Connection
				conn.Close();
			}
		}
	}
}
