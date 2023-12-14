<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearProducto.aspx.cs" Inherits="Rec1.CrearProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Producto</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Crear Nuevo Producto</h3>
            <asp:TextBox ID="txtDescripcion" runat="server" placeholder="Descripción del producto"></asp:TextBox>
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Green" Visible="false"></asp:Label>

            <asp:Button ID="btnCrearProducto" runat="server" Text="Crear Producto" OnClick="btnCrearProducto_Click" />
            <br /><br />
            <asp:HyperLink ID="lnkListarProductos" runat="server" Text="Ir a Listar Productos" NavigateUrl="~/ListarProductos.aspx" />
             <br /><br />
            <asp:HyperLink ID="lnkVolverAlMenu" runat="server" Text="Volver al Menú" NavigateUrl="~/Menu.aspx" />
        </div>
    </form>
</body>
</html>
