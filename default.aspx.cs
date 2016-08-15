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
	/// Summary description for _default.
	/// </summary>
	public class _default : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.Label lblEmail;
		protected System.Web.UI.WebControls.Label lblTelefone;
		protected System.Web.UI.WebControls.TextBox txtTelefone;
		protected System.Web.UI.WebControls.RadioButtonList rdListaOpcao;
		protected System.Web.UI.WebControls.DropDownList cmbOpcoes;
		protected System.Web.UI.WebControls.CheckBox ckSistema;
		protected System.Web.UI.WebControls.Button cmdEnviar;
		protected System.Web.UI.WebControls.Label Label1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			Label1.Text = "Sistema Pronto para começar";
		}

		/// <summary>
		/// Metodo para sumir com os campos de email
		/// dinamicamente
		/// </summary>
		public void sumirEmail()
		{
			txtEmail.Visible=false;
			lblEmail.Visible=false;
		}

		/// <summary>
		/// Metodo para sumir com os campos de Telefone
		/// dinamicamente
		/// </summary>
		public void sumirTelefone()
		{
			txtTelefone.Visible=false;
			lblTelefone.Visible=false;
		}

		/// <summary>
		/// Metodos para aparecer os campos de email
		/// dinamicamente
		/// </summary>
		public void aparecerEmail()
		{
			lblEmail.Visible=true;
			txtEmail.Visible=true;
			ckSistema.Visible=true;
			cmdEnviar.Visible=true;
		}

		/// <summary>
		/// Metodos para aparecer os campos de telefone
		/// dinamicamente
		/// </summary>
		public void aparecerTelefone()
		{
			txtTelefone.Visible=true;
			lblTelefone.Visible=true;
			ckSistema.Visible=true;
			cmdEnviar.Visible=true;
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
			this.rdListaOpcao.SelectedIndexChanged += new System.EventHandler(this.rdListaOpcao_SelectedIndexChanged);
			this.cmbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cmbOpcoes_SelectedIndexChanged);
			this.cmdEnviar.Click += new System.EventHandler(this.cmdEnviar_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void rdListaOpcao_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (rdListaOpcao.SelectedValue  == "1")
			{
				sumirTelefone();
				aparecerEmail();
			}
			else 
			{
				aparecerTelefone();
				sumirEmail();
			}
		}

		private void cmbOpcoes_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cmbOpcoes.SelectedValue == "1")
			{
				sumirTelefone();
				aparecerEmail();
			}
			else
			{
				aparecerTelefone();
				sumirEmail();
			}
		}




		private void cmdEnviar_Click(object sender, System.EventArgs e)
		{
			Server.Transfer("pagina.aspx");
		}
	}
}
