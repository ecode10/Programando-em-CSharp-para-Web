<%@ Page language="c#" Codebehind="frmId.aspx.cs" AutoEventWireup="false" Inherits="PrimeiroSistema.frmId" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>frmId</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:RadioButtonList id="RadioButtonList1" style="Z-INDEX: 101; LEFT: 256px; POSITION: absolute; TOP: 160px"
				runat="server" RepeatDirection="Horizontal">
				<asp:ListItem Value="1">Solteiro</asp:ListItem>
				<asp:ListItem Value="2">Casado</asp:ListItem>
				<asp:ListItem Value="3">Separado</asp:ListItem>
			</asp:RadioButtonList>
		</form>
	</body>
</HTML>
