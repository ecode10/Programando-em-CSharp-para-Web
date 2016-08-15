using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace PrimeiroSistema
{
	/// <summary>
	/// Summary description for validaCampos.
	/// </summary>
	public class validaCampos : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.Label lblEmail;
		protected System.Web.UI.WebControls.TextBox txtNome;
		protected System.Web.UI.WebControls.Label lblNome;
		protected System.Web.UI.WebControls.TextBox txtSenha;
		protected System.Web.UI.WebControls.Label lblSenha;
		protected System.Web.UI.WebControls.Label lblConfirmacaoSenha;
		protected System.Web.UI.WebControls.TextBox txtConfirmacao;
		protected System.Web.UI.WebControls.RequiredFieldValidator valEmail;
		protected System.Web.UI.WebControls.RequiredFieldValidator valSenha;
		protected System.Web.UI.WebControls.RequiredFieldValidator valConfirmacao;
		protected System.Web.UI.WebControls.RegularExpressionValidator valEmailCorretamente;
		protected System.Web.UI.WebControls.CompareValidator validaComparacao;
		protected System.Web.UI.WebControls.Button cmdEnviar;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.cmdEnviar.Click += new System.EventHandler(this.cmdEnviar_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void cmdEnviar_Click(object sender, System.EventArgs e)
		{
			///Perguntando se a pagina é valida com todas as validaçoes
			///feitas antes de ir para outra página.
			if (Page.IsValid)
			{
				///Instanciando metodo que foi criado anteriormente
				///Criando uma nova instancia de objetos
				PrimeiroSistema.componentes.clsInserir sInserir = new PrimeiroSistema.componentes.clsInserir();

				///Criando uma variável Boolean 
				///Pegando a variável criada acima, clicando .(ponto) aparecerá todos
				///os métodos disponíveis para acesso, no caso desse método
				///esse parâmetro está esperando dois valores (nome e email).
				Boolean resultado = sInserir.inserirUsuario(txtNome.Text, txtEmail.Text);

				///Se o resultado criado acima for true 
				///é passado para a página posterior
				if (resultado)
				{
					Server.Transfer("pagina.aspx");
				}
			}
		}
	}
}
