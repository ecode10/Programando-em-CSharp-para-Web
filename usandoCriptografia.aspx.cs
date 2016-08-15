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
	/// Summary description for usandoCriptografia.
	/// </summary>
	public class usandoCriptografia : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblValor;
		protected System.Web.UI.WebControls.TextBox txtValor;
		protected System.Web.UI.WebControls.Button cmdEnviar;
		protected System.Web.UI.WebControls.Button cmdDescript;
		protected System.Web.UI.WebControls.Label lblResultado;
	
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
			this.cmdDescript.Click += new System.EventHandler(this.cmdDescript_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		/// <summary>
		/// Metodo que envia dados para a classe clsCriptografia e retorna
		/// o dado criptografado e mostra na tela
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmdEnviar_Click(object sender, System.EventArgs e)
		{
			PrimeiroSistema.componentes.clsCriptografia sCript = new PrimeiroSistema.componentes.clsCriptografia();
			lblResultado.Text = sCript.encrypt(txtValor.Text);
		}


		/// <summary>
		/// Método que envia dados para a classe clsCriptografia e retorna
		/// o dado descriptografado e mostra na tela
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmdDescript_Click(object sender, System.EventArgs e)
		{
			PrimeiroSistema.componentes.clsCriptografia sCript = new PrimeiroSistema.componentes.clsCriptografia();
			lblResultado.Text = sCript.decrypt(txtValor.Text);		
		}
	}
}
