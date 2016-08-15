using System;
using System.Data.Odbc;

namespace PrimeiroSistema.componentes
{
	/// <summary>
	/// Classe para inserir usuario
	/// </summary>
	public class clsInserir
	{
		/// <summary>
		/// Instanciando primeiro a classe de banco de dados para ser
		/// usada mais tarde dentro desta classe
		/// </summary>
		PrimeiroSistema.componentes.clsBanco sBanco = new clsBanco();

		/// <summary>
		/// Método para inserir usuário no banco de dados MYSQL
		/// </summary>
		/// <param name="nome">nome do usuario</param>
		/// <param name="email">email do usuario</param>
		/// <returns>true / false</returns>
		public Boolean inserirUsuario(string nome, string email)
		{
			Boolean bResultado = false;
			try
			{
				///Abrindo a conexão com o banco de dados
				sBanco.Conecta();

				///Criando query string para usar mais a frente na execucao
				string sql = "insert into tb_usuario (no_usu, email_usu) values ('" + nome + "', '" + email + "')";

				///instanciando objeto ODBC e passando a query string e o objeto de conexao
				OdbcCommand sqlC = new OdbcCommand(sql,sBanco.sConn);

				///executando o código
				bResultado = Convert.ToBoolean(sqlC.ExecuteNonQuery());

				///retornando resultado
				return bResultado;
			}
			catch(OdbcException e)
			{
				///se ocorrer algum erro, passará o erro ocorrido
				throw new Exception("Erro ao inserir, método clsInserir.cs" + e.StackTrace);
			}
			finally
			{
				///fechando conexao aberta do banco
				sBanco.Desconecta();
			}
		}
	}
}
