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
	/// Summary description for frmRelatorio.
	/// </summary>
	public class frmRelatorio : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Button cmdDeletar;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			///Se a página nao for reload
			if (!Page.IsPostBack)
			{
				///chamando o metodo para preencher o objeto grid
				///do html que já foi criado
				preencheGrid();
			}
		}

		/// <summary>
		/// Metodo para preencher o objeto datagrid com os dados
		/// vindo do banco
		/// </summary>
		private void preencheGrid()
		{
			PrimeiroSistema.componentes.clsRelatorio sRel = new PrimeiroSistema.componentes.clsRelatorio();
			this.DataGrid1.DataSource = sRel.buscaRelatorio();
			this.DataGrid1.DataBind();
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
			this.DataGrid1.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.DataGrid1_ItemCreated);
			this.cmdDeletar.Click += new System.EventHandler(this.cmdDeletar_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DataGrid1_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			////////////////////////////////////////////////////////////////
			///Adicionando o Javascript ao CheckBox
			////////////////////////////////////////////////////////////////
			
			if (e.Item.ItemType == ListItemType.Header)
			{
				CheckBox ck = (CheckBox)e.Item.FindControl("ckHead");

				if(ck != null)
					ck.Attributes.Add("onclick","selecionarTodos(this);");
			}

			if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
			{
				CheckBox ck = (CheckBox)e.Item.FindControl("ckItem");
				if (ck != null)
					ck.Attributes.Add("onclick","desselecionarTodos();");
			}

			///////////////////////////////////////
			///Fim
			//////////////////////////////////////				
		}

		private void cmdDeletar_Click(object sender, System.EventArgs e)
		{
			///instanciando o metodo para ser usado mais abaixo
			///no método
			PrimeiroSistema.componentes.clsExcluir sExcluir = new PrimeiroSistema.componentes.clsExcluir();


			///fazendo um for para deletar apenas os objetos
			///da tela marcados
			foreach( DataGridItem itens in this.DataGrid1.Items )
			{
				CheckBox ck = (CheckBox) itens.FindControl("ckItem");
				Label id = (Label) itens.FindControl("lblId");
				if (ck !=null && ck.Checked)
				{
					sExcluir.excluirDados(Convert.ToInt32(id.Text));
				}
			}		

			preencheGrid();
		}
	}
}
