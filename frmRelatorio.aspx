<%@ Page language="c#" Codebehind="frmRelatorio.aspx.cs" AutoEventWireup="false" Inherits="PrimeiroSistema.frmRelatorio" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>frmRelatorio</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script>
			function selecionarTodos(ckall){
				var actVar = ckall.checked; 
				for (i=0; i<Form1.length; i++){
					if (Form1.elements[i].type == "checkbox"){
						if (Form1.elements[i].name.indexOf("ckItem")!= -1){
							Form1.elements[i].checked = actVar;
						}
					}
				}
			}
			
			function desselecionarTodos(){
				var status = true;
				for(i=0; i<Form1.length; i++){
					if(Form1.elements[i].type=="checkbox" && Form1.elements[i].name !="ckHead"){
						if(Form1.elements[i].name.indexOf("ckItem") != -1){
							if(Form1.elements[i].checked==false){
								status=false;
							}
						}
					}
				}
			}
			
			
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id="DataGrid1" runat="server" AutoGenerateColumns="False">
				<Columns>
					<asp:TemplateColumn>
						<HeaderTemplate>
							<asp:CheckBox id="ckHead" runat="server"></asp:CheckBox>
						</HeaderTemplate>
						<ItemTemplate>
							<asp:CheckBox id="ckItem" runat="server"></asp:CheckBox>
							<asp:Label id="lblId" Visible=False runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "CH_USU")%>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="ch_usu" Visible="False"></asp:BoundColumn>
					<asp:BoundColumn DataField="no_usu" HeaderText="Nome"></asp:BoundColumn>
					<asp:BoundColumn DataField="email_usu" HeaderText="Email"></asp:BoundColumn>
					<asp:HyperLinkColumn Text="Alterar" DataNavigateUrlField="ch_usu" DataNavigateUrlFormatString="../alterar/alteraProduto.aspx?CH_PROD={0}"
						HeaderText="Alterar Produto"></asp:HyperLinkColumn>
				</Columns>
			</asp:DataGrid>
			<br>
			&nbsp;
			<asp:Button id="cmdDeletar" runat="server" Text="Deletar" style="Z-INDEX: 101; LEFT: 96px; POSITION: absolute; TOP: 168px"></asp:Button>
		</form>
	</body>
</HTML>
