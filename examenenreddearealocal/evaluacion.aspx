<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="evaluacion.aspx.cs" Inherits="examenenreddearealocal.evaluacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbltipoexamen" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btnfinalizar" runat="server" Text="Finalizar" />
        <br />
        <asp:GridView ID="grdpregunta" runat="server">
        </asp:GridView>
        <asp:Label ID="lblpregunta" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
