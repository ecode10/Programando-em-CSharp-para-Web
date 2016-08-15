using System;
using System.Data.Odbc;

namespace PrimeiroSistema.componentes
{
	/// <summary>
	/// Classe para excluir dados do banco
	/// </summary>
	public class clsExcluir
	{
		/// <summary>
		/// Metodo instanciando classe do banco de dados 
		/// para ser usada abaixo
		/// </summary>
		PrimeiroSistema.componentes.clsBanco sBanco = new clsBanco();

		/// <summary>
		/// Metodo responsável para deletar dados do banco
		/// nao retona nada
		/// </summary>
		/// <param name="chave">chave do usuario</param>
		public void excluirDados(int chave)
		{
			try
			{
				///Conectando com o banco de dados
				///abrindo conexao
				sBanco.Conecta();

				///Criando a query string para deletar os dados
				string sql = "delete from tb_usuario where ch_usu = " + chave;

				///Gerando um novo objeto de comando passando
				///a query string e o objeto de conexao
				OdbcCommand sqlc = new OdbcCommand(sql,sBanco.sConn);

				///executando o objeto criado
				sqlc.ExecuteNonQuery();
			}
			catch(OdbcException e)
			{
				///Gerando uma nova exception
				throw new Exception("Erro na classe clsExcluir" + e.StackTrace);
			}
			finally
			{
				///desconectando o banco de dados
				sBanco.Desconecta();
			}
		}
	}
}
