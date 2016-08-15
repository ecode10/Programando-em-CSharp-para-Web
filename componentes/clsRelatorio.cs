using System;
using System.Data.Odbc;
using System.Data;

namespace PrimeiroSistema.componentes
{
	/// <summary>
	/// Classe para gerar relatorio
	/// </summary>
	public class clsRelatorio
	{
		/// <summary>
		/// Conectando no banco de dados
		/// </summary>
		PrimeiroSistema.componentes.clsBanco sBanco = new clsBanco();

		/// <summary>
		/// Metodo que busca relatorio e traz dataSet
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet buscaRelatorio()
		{
			try
			{
				///Abrindo conexao
				sBanco.Conecta();

				///Gerando query string
				string sql = "select ch_usu, no_usu, email_usu from tb_usuario order by no_usu";

				///Criando um novo dataset para preencher abaixo
				///o mesmo
				DataSet dtSet = new DataSet();

				///Gerando uma instancia do objeto OdbcDataAdapter
				///passando a query string e o objeto do banco de dados
				OdbcDataAdapter dtAdapter = new OdbcDataAdapter(sql,sBanco.sConn);

				///pegando a variavel criada do dataadapter e 
				///preenchendo dataset para ser passado
				dtAdapter.Fill(dtSet);

				///retornando dataset
				return dtSet;
			}
			catch(OdbcException e)
			{
				///gerando uma exception e mostrando onde está dando o erro
				throw new Exception("Erro na classe clsRelatorio " + e.StackTrace);
			}
			finally
			{
				///fechando a conexao com o banco de dados
				sBanco.Desconecta();
			}
		}
	}
}
