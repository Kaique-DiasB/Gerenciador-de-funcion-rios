using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SA02_FenDep
{
	public class Funcionario
	{
		#region Atributos
		private int id;
		private string nome;
		private string cpf;
		private int setorid;
		#endregion
		#region Propriedades
		public int Id
		{
			get{return id;}
			set{id = value;}
		}
		public string Nome
		{
			get{return nome;}
			set{nome = value;}
		}
		public string Cpf
		{
			get{return cpf;}
			set{cpf = value;}
		}
		public int Setorid
		{
			get{return setorid;}
			set{setorid = value;}
		}
		#endregion
		
		public Funcionario()
		{
		}
		
		public void InserirFuncionario (Funcionario funcionario)
		{
			MySqlConnection conn = null;
			MySqlCommand cmd = null;
			
			try {
				// Connection
				conn = new MySqlConnection();
				conn.ConnectionString = ConexaoDB.StringConnection;
				
				// MySqlCommand
				cmd = new MySqlCommand();
				cmd.Connection = conn;
				
				// Paramenters
				cmd.Parameters.AddWithValue ("@nome", funcionario.Nome);
				cmd.Parameters.AddWithValue ("@cpf", funcionario.Cpf);
				cmd.Parameters.AddWithValue ("@setorid", funcionario.Setorid);

				
				// Querry (SQL)
				cmd.CommandText = "INSERT INTO funcionario (nome,cpf,setorid) values (@nome,@cpf,@setorid);";
				
				// Open Connetion
				conn.Open();
				
				// Execute Querry (SQL)
				cmd.ExecuteNonQuery();
			}
			
			catch (MySqlException ex)
			{
				throw new Exception ("Servidor SQL Erro: " + ex.Number);
			}
			catch (Exception ex)
			{
				throw new Exception ("Erro: " + ex.Message);
			}
			finally
			{
				// Close Connection
				conn.Close();
			}
		}
		
		public void ExcluirFuncionario (int condigoid)
		{
			MySqlConnection conn = null;
			MySqlCommand cmd = null;
			
			// Connection
			conn = new MySqlConnection();
			conn.ConnectionString = ConexaoDB.StringConnection;
			
			// MySqlCommand
			cmd = new MySqlCommand();
			cmd.Connection = conn;
			
			// Querry (SQL)
			cmd.CommandText = "DELETE FROM funcionario WHERE id = " + condigoid +";";
			
			// Open Connection
			conn.Open();
			
			// Execute Querry (SQL)
			cmd.ExecuteNonQuery();
			
			// Close Connection
			conn.Close();
		}
		
		public void AtualizarFuncionario (Funcionario funcionario)
		{
			
			MySqlConnection conn = null;
			MySqlCommand cmd = null;
			
			try {
				// Connection
				conn = new MySqlConnection();
				conn.ConnectionString = ConexaoDB.StringConnection;
				
				// MySqlCommand
				cmd = new MySqlCommand();
				cmd.Connection = conn;
				
				// Paramenters
				cmd.Parameters.AddWithValue ("@id", funcionario.Id);
				cmd.Parameters.AddWithValue ("@nome", funcionario.Nome);
				cmd.Parameters.AddWithValue ("@cpf", funcionario.Cpf);
				cmd.Parameters.AddWithValue ("@setorid", funcionario.Setorid);

				
				// Querry (SQL)
				cmd.CommandText = "UPDATE funcionario SET nome = @nome, cpf = @cpf, setorid = @setorid WHERE id = @id;";
				
				// Open Connetion
				conn.Open();
				
				// Execute Querry (SQL)
				cmd.ExecuteNonQuery();
			}
			
			catch (MySqlException ex)
			{
				throw new Exception ("Servidor SQL Erro: " + ex.Number);
			}
			catch (Exception ex)
			{
				throw new Exception ("Erro: " + ex.Message);
			} finally {
				// Close Connection
				conn.Close();
			}
		}
		
		public DataTable ListarTodosFuncionarios()
		{
			MySqlConnection conn = null;
			MySqlCommand cmd = null;
			MySqlDataAdapter da = null;
			DataTable dt = null;
			
			
			try
			{
				// Connection
				conn = new MySqlConnection ();
				conn.ConnectionString = ConexaoDB.StringConnection;
				
				// MySqlCommand
				cmd = new MySqlCommand();
				cmd.Connection = conn;
				
				// Querry (SQL)
				cmd.CommandText = "select f.id,f.nome,f.cpf,f.setorid,s.id,s.nome from funcionario as f left join setor s on f.setorid = s.id;";
				
				// Open Connection
				conn.Open();
				
				// Create DataAdapter
				da = new MySqlDataAdapter(cmd);
				
				// Create DataTable
				dt = new DataTable();
				
				// To fill a DataTable
				da.Fill(dt);
				
				// Return
				return dt;
				
			}
			catch (MySqlException ex)
			{
				throw new Exception ("Servidor SQL Erro: " + ex.Number);
			}
			catch (Exception ex)
			{
				throw new Exception ("Erro: " + ex.Message);
			}
			finally
			{
				// Close Connetion
				conn.Close();
			}
		}
		
		public DataTable ListarPorNomeFuncionarios(string NomedePequisa)
		{
			MySqlConnection conn = null;
			MySqlCommand cmd = null;
			MySqlDataAdapter da = null;
			DataTable dt = null;
			
			
			try
			{
				// Connection
				conn = new MySqlConnection ();
				conn.ConnectionString = ConexaoDB.StringConnection;
				
				// MySqlCommand
				cmd = new MySqlCommand();
				cmd.Connection = conn;
				
				// Querry (SQL)
				cmd.CommandText = "select f.id,f.nome,f.cpf,f.setorid,s.id,s.nome from funcionario as f left join setor s on f.setorid = s.id WHERE f.nome LIKE '%"+NomedePequisa+"%';";
				// Open Connection
				conn.Open();
				
				// Create DataAdapter
				da = new MySqlDataAdapter(cmd);
				
				// Create DataTable
				dt = new DataTable();
				
				// To fill a DataTable
				da.Fill(dt);
				
				// Return
				return dt;
				
			}
			catch (MySqlException ex)
			{
				throw new Exception ("Servidor SQL Erro: " + ex.Number);
			}
			catch (Exception ex)
			{
				throw new Exception ("Erro: " + ex.Message);
			}
			finally
			{
				// Close Connetion
				conn.Close();
			}
		}
	}
}
