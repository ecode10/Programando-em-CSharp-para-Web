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
	/// Summary description for formularioList.
	/// </summary>
	public class formularioList : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ListBox lstOrigem;
		protected System.Web.UI.WebControls.ListBox lstDestino;
		protected System.Web.UI.WebControls.Button cmdEnviar;
		protected System.Web.UI.WebControls.Button cmdRetornar;
	
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
			this.cmdRetornar.Click += new System.EventHandler(this.cmdRetornar_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		/// <summary>
		/// Metodo para enviar um valor de um objeto para outro objeto
		/// da tela
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmdEnviar_Click(object sender, System.EventArgs e)
		{
			///Primeiro estou testando se o index é maior que zero
			///quer dizer que, o valor do objeto passado tem que ser maior que zero (0)
			if (this.lstOrigem.SelectedIndex > 0)
			{
				///adicionando
				this.lstDestino.Items.Add(this.lstOrigem.SelectedItem);

				///removendo
				this.lstOrigem.Items.RemoveAt(this.lstDestino.SelectedIndex);
			}
		}

		/// <summary>
		/// Metodo que serve para remover o que foi enviado para o objeto da tela.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmdRetornar_Click(object sender, System.EventArgs e)
		{
			///primeiro testo se foi selecionado algum valor
			if (this.lstDestino.SelectedIndex > 0)
			{
				///adicionando
				this.lstOrigem.Items.Add(this.lstDestino.SelectedItem);

				///removendo
				this.lstDestino.Items.RemoveAt(this.lstDestino.SelectedIndex);
			}
		}
	}
}
