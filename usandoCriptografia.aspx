<%@ Page language="c#" Codebehind="usandoCriptografia.aspx.cs" AutoEventWireup="false" Inherits="PrimeiroSistema.usandoCriptografia" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>usandoCriptografia</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lblValor" style="Z-INDEX: 101; LEFT: 232px; POSITION: absolute; TOP: 88px" runat="server">Valor:</asp:Label>
			<asp:TextBox id="txtValor" style="Z-INDEX: 102; LEFT: 280px; POSITION: absolute; TOP: 88px" runat="server"></asp:TextBox>
			<asp:Button id="cmdEnviar" style="Z-INDEX: 103; LEFT: 280px; POSITION: absolute; TOP: 128px"
				runat="server" Text="Criptografar"></asp:Button>
			<asp:Label id="lblResultado" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 176px"
				runat="server"></asp:Label>
			<asp:Button id="cmdDescript" style="Z-INDEX: 105; LEFT: 400px; POSITION: absolute; TOP: 128px"
				runat="server" Text="Descriptografar"></asp:Button>
		</form>
	</body>
</HTML>
