using System;
using System.Data.Odbc;

namespace PrimeiroSistema.componentes
{
	/// <summary>
	/// Classe com métodos para conectar no banco de dados mysql
	/// </summary>
	public class clsBanco
	{
		/// <summary>
		/// Fazendo conexao com o banco de dados
		/// MYSQL
		/// </summary>
		public OdbcConnection sConn = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};Server=bsb066666;DataBase=bd_primeiraAplicacao;uid=root;pwd=;option=3");

		/// <summary>
		/// Metodo para conectar no banco de dados
		/// </summary>
		public void Conecta()
		{
			try
			{
				if (sConn.State==0)
				{
					sConn.Open();
				}
				else
				{
					sConn.Close();
				}
			}
			catch(Exception e)
			{
				throw new Exception("Banco de dados Fora: classe clsBanco.cs "+ e.StackTrace);
			}
		}

		/// <summary>
		/// Metodo para desconectar do banco de dados
		/// </summary>
		public void Desconecta()
		{
			try
			{
				if (sConn.State!=0)
				{
					sConn.Close();
				}
				else
				{
					sConn.Close();
				}
			}
			catch(Exception e)
			{
				throw new Exception("Erro no Banco de Dados: classe clsBanco.cs "+ e.StackTrace);
			}
		}
	}
}
