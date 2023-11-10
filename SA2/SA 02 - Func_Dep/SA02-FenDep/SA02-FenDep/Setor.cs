using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SA02_FenDep
{
	public class Setor
	{
		public Setor()
		{
		}
		public DataTable SelecionarSetores()
		{
			MySqlConnection conn = null;
			MySqlCommand cmd = null;
			MySqlDataAdapter da = null;
			DataTable dt = null;
			
			try{
				// Connection
				conn = new MySqlConnection ();
				conn.ConnectionString = ConexaoDB.StringConnection;
				
				// MySqlCommand
				cmd = new MySqlCommand();
				cmd.Connection = conn;
				
				// Querry (SQL)
				cmd.CommandText = "SELECT id, nome FROM setor;";
				
				// Open Connection
				conn.Open();
				
				// Create DataAdapter
				da = new MySqlDataAdapter(cmd);
				
				// Create DateTable
				dt = new DataTable();
				
				// To fill in Datatable
				da.Fill(dt);
				
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
