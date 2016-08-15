<%@ Page language="c#" Codebehind="default.aspx.cs" AutoEventWireup="false" Inherits="PrimeiroSistema._default" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>default</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 120px; POSITION: absolute; TOP: 72px" runat="server"
				Font-Size="X-Large" ForeColor="Blue" Width="384px">Seja Bem Vindo ao Sistema</asp:Label>
			<asp:TextBox id="txtEmail" style="Z-INDEX: 102; LEFT: 240px; POSITION: absolute; TOP: 224px"
				runat="server" Visible="False"></asp:TextBox>
			<asp:Label id="lblEmail" style="Z-INDEX: 103; LEFT: 240px; POSITION: absolute; TOP: 200px"
				runat="server" Visible="False">Email:</asp:Label>
			<asp:Label id="lblTelefone" style="Z-INDEX: 104; LEFT: 240px; POSITION: absolute; TOP: 280px"
				runat="server" Visible="False">Telefone:</asp:Label>
			<asp:TextBox id="txtTelefone" style="Z-INDEX: 105; LEFT: 240px; POSITION: absolute; TOP: 304px"
				runat="server" Visible="False"></asp:TextBox>
			<asp:RadioButtonList id="rdListaOpcao" style="Z-INDEX: 106; LEFT: 248px; POSITION: absolute; TOP: 144px"
				runat="server" RepeatDirection="Horizontal" AutoPostBack="True">
				<asp:ListItem Value="1">Email</asp:ListItem>
				<asp:ListItem Value="2">Telefone</asp:ListItem>
			</asp:RadioButtonList>
			<asp:DropDownList id="cmbOpcoes" style="Z-INDEX: 107; LEFT: 416px; POSITION: absolute; TOP: 152px"
				runat="server" AutoPostBack="True">
				<asp:ListItem Value="0" Selected="True">Selecione</asp:ListItem>
				<asp:ListItem Value="1">Email</asp:ListItem>
				<asp:ListItem Value="2">Telefone</asp:ListItem>
			</asp:DropDownList>
			<asp:CheckBox id="ckSistema" style="Z-INDEX: 108; LEFT: 240px; POSITION: absolute; TOP: 344px"
				runat="server" Text="Sistema" Visible="False"></asp:CheckBox>
			<asp:Button id="cmdEnviar" style="Z-INDEX: 109; LEFT: 328px; POSITION: absolute; TOP: 344px"
				runat="server" Visible="False" Text="Enviar"></asp:Button>
		</form>
	</body>
</HTML>
