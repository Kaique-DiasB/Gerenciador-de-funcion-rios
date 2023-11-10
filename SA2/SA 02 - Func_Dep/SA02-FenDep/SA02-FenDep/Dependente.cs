using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SA02_FenDep
{
	public class Dependente
	{
		#region Atributos
		private int id;
		private string nome;
		private DateTime datanasc;
		private int generoid;
		private int funcionarioid;
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
		public DateTime Datanasc
		{
			get{return datanasc;}
			set{datanasc = value;}
		}
		public int GeneroId
		{
			get{return generoid;}
			set{generoid = value;}
		}
		public int FuncionarioId
		{
			get{return funcionarioid;}
			set{funcionarioid = value;}
		}
		
		#endregion
		public Dependente()
		{
		}
		
		public void InserirDependente (Dependente dependente)
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
				cmd.Parameters.AddWithValue ("@nome", dependente.Nome);
				cmd.Parameters.AddWithValue ("@datanasc", dependente.Datanasc);
				cmd.Parameters.AddWithValue ("@sexoid", dependente.generoid);
				cmd.Parameters.AddWithValue ("@funcionarioid", dependente.funcionarioid);
				
				// Querry (SQL)
				cmd.CommandText = "INSERT INTO dependentes (nome,datanasc,sexoid,funcionarioid) values (@nome,@datanasc,@sexoid,@funcionarioid);";
				
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
		
		public void ExcluirDependente (int condigoid)
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
			cmd.CommandText = "DELETE FROM dependentes WHERE id = " + condigoid +";";
			
			// Open Connection
			conn.Open();
			
			// Execute Querry (SQL)
			cmd.ExecuteNonQuery();
			
			// Close Connection
			conn.Close();
		}
		
		public void ExcluirDependenteAtF (int condigoid)
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
			cmd.CommandText = "DELETE FROM dependentes WHERE funcionarioid = " + condigoid +";";
			
			// Open Connection
			conn.Open();
			
			// Execute Querry (SQL)
			cmd.ExecuteNonQuery();
			
			// Close Connection
			conn.Close();
		}
		
		public void AtualizarDependente (Dependente dependente)
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
				cmd.Parameters.AddWithValue ("@id",dependente.Id);
				cmd.Parameters.AddWithValue ("@nome", dependente.Nome);
				cmd.Parameters.AddWithValue ("@datanasc", dependente.Datanasc);
				cmd.Parameters.AddWithValue ("@sexoid", dependente.generoid);
				cmd.Parameters.AddWithValue ("@funcionarioid", dependente.funcionarioid);

				
				// Querry (SQL)
				cmd.CommandText = "UPDATE dependentes SET nome = @nome, datanasc = @datanasc, sexoid = @sexoid, funcionarioid = @funcionarioid WHERE id = @id;";
				
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
		
		public DataTable ListarTodosDependentes()
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
				cmd.CommandText = "select d.id,d.nome,d.datanasc,d.sexoid,d.funcionarioid,g.id,g.sexo,f.id,f.nome from dependentes as d left join funcionario as f on d.funcionarioid = f.id left join genero as g on d.sexoid = g.id;";
				
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
		
		public DataTable ListarPorNomeDependentes(string NomedePequisa)
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
				cmd.CommandText = "select d.id,d.nome,d.datanasc,d.sexoid,d.funcionarioid,g.id,g.sexo,f.id,f.nome from dependentes as d left join funcionario as f on d.funcionarioid = f.id left join genero as g on d.sexoid = g.id WHERE f.nome LIKE '%"+NomedePequisa+"%';";
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
