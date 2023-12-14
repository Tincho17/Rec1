<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearPrecio.aspx.cs" Inherits="Rec1.CrearPrecio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Precio</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Crear Nuevo Precio</h3>
            <asp:TextBox ID="txtFecha" runat="server" placeholder="Fecha (YYYY-MM-DD)"></asp:TextBox>
            <asp:TextBox ID="txtMonto" runat="server" placeholder="Monto"></asp:TextBox>
            <asp:TextBox ID="txtIdProducto" runat="server" placeholder="ID de Producto"></asp:TextBox>
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Green" Visible="false"></asp:Label>

            <asp:Button ID="btnCrearPrecio" runat="server" Text="Crear Precio" OnClick="btnCrearPrecio_Click" />
            <br /><br />
            <asp:HyperLink ID="lnkListarPrecios" runat="server" Text="Ir a Listar Precios" NavigateUrl="~/ListarPrecios.aspx" />
            <br /><br />
            <asp:HyperLink ID="lnkVolverAlMenu" runat="server" Text="Volver al Menú" NavigateUrl="~/Menu.aspx" />
        </div>
    </form>
</body>
</html>
