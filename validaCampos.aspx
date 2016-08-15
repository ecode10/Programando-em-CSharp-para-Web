<%@ Page language="c#" Codebehind="validaCampos.aspx.cs" AutoEventWireup="false" Inherits="PrimeiroSistema.validaCampos" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>validaCampos</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="txtEmail" style="Z-INDEX: 101; LEFT: 192px; POSITION: absolute; TOP: 64px" runat="server"></asp:TextBox>
			<asp:Label id="lblEmail" style="Z-INDEX: 102; LEFT: 136px; POSITION: absolute; TOP: 64px" runat="server">Email:</asp:Label>
			<asp:TextBox id="txtNome" style="Z-INDEX: 103; LEFT: 192px; POSITION: absolute; TOP: 96px" runat="server"
				Width="232px"></asp:TextBox>
			<asp:Label id="lblNome" style="Z-INDEX: 104; LEFT: 136px; POSITION: absolute; TOP: 96px" runat="server">Nome:</asp:Label>
			<asp:TextBox id="txtSenha" style="Z-INDEX: 105; LEFT: 192px; POSITION: absolute; TOP: 128px"
				runat="server" Width="128px" TextMode="Password"></asp:TextBox>
			<asp:Label id="lblSenha" style="Z-INDEX: 106; LEFT: 136px; POSITION: absolute; TOP: 128px"
				runat="server">Senha:</asp:Label>
			<asp:Label id="lblConfirmacaoSenha" style="Z-INDEX: 107; LEFT: 40px; POSITION: absolute; TOP: 160px"
				runat="server">Confirmação de Senha:</asp:Label>
			<asp:TextBox id="txtConfirmacao" style="Z-INDEX: 108; LEFT: 192px; POSITION: absolute; TOP: 160px"
				runat="server" Width="128px" TextMode="Password"></asp:TextBox>
			<asp:Button id="cmdEnviar" style="Z-INDEX: 109; LEFT: 200px; POSITION: absolute; TOP: 200px"
				runat="server" Text="Enviar"></asp:Button>
			<asp:RequiredFieldValidator id="valEmail" style="Z-INDEX: 110; LEFT: 368px; POSITION: absolute; TOP: 64px" runat="server"
				ErrorMessage="Digite o Email:" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="valSenha" style="Z-INDEX: 111; LEFT: 336px; POSITION: absolute; TOP: 128px"
				runat="server" ErrorMessage="Digite a Senha" ControlToValidate="txtSenha"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="valConfirmacao" style="Z-INDEX: 112; LEFT: 336px; POSITION: absolute; TOP: 160px"
				runat="server" ErrorMessage="Digite a Confirmação da Senha" ControlToValidate="txtConfirmacao"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator id="valEmailCorretamente" style="Z-INDEX: 113; LEFT: 368px; POSITION: absolute; TOP: 64px"
				runat="server" ErrorMessage="Digite o Email Corretamente " ControlToValidate="txtEmail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
			<asp:CompareValidator id="validaComparacao" style="Z-INDEX: 114; LEFT: 336px; POSITION: absolute; TOP: 184px"
				runat="server" ControlToValidate="txtSenha" ErrorMessage="Digite a confirmação da senha corretamente !!"
				ControlToCompare="txtConfirmacao"></asp:CompareValidator>
		</form>
	</body>
</HTML>
