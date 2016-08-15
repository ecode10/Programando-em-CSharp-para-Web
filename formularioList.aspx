<%@ Page language="c#" Codebehind="formularioList.aspx.cs" AutoEventWireup="false" Inherits="PrimeiroSistema.formularioList" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>formularioList</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:ListBox id="lstOrigem" style="Z-INDEX: 101; LEFT: 160px; POSITION: absolute; TOP: 104px"
				runat="server" Width="136px" Height="96px" SelectionMode="Multiple">
				<asp:ListItem Value="0">&lt;&lt; Selecione &gt;&gt;</asp:ListItem>
				<asp:ListItem Value="1">C#</asp:ListItem>
				<asp:ListItem Value="2">J#</asp:ListItem>
				<asp:ListItem Value="3">C++</asp:ListItem>
			</asp:ListBox>
			<asp:ListBox id="lstDestino" style="Z-INDEX: 102; LEFT: 360px; POSITION: absolute; TOP: 104px"
				runat="server" Width="128px" Height="88px" SelectionMode="Multiple">
				<asp:ListItem Value="0">&lt;&lt; Selecione &gt;&gt;</asp:ListItem>
			</asp:ListBox>
			<asp:Button id="cmdEnviar" style="Z-INDEX: 103; LEFT: 312px; POSITION: absolute; TOP: 112px"
				runat="server" Text=" >> "></asp:Button>
			<asp:Button id="cmdRetornar" style="Z-INDEX: 104; LEFT: 312px; POSITION: absolute; TOP: 152px"
				runat="server" Text=" << "></asp:Button>
		</form>
	</body>
</HTML>
