<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Rec1.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menú</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Bienvenido</h1>
           <asp:Menu ID="Menu1" runat="server" CssClass="menu" Orientation="Vertical">
    <Items>
        <asp:MenuItem Text="Crear Cuenta" Value="Crear Producto" NavigateUrl="~/CrearProducto.aspx" />
        <asp:MenuItem Text="Listar Cuentas" Value="Listar Productos" NavigateUrl="~/ListarProductos.aspx" />
        <asp:MenuItem Text="Crear Precio" Value="Crear Precio" NavigateUrl="~/CrearPrecio.aspx" />
        <asp:MenuItem Text="Listar Precios" Value="Listar Precios" NavigateUrl="~/ListarPrecios.aspx" />
    </Items>
</asp:Menu>
            <div>
            </div>
        </div>
    </form>
</body>
</html>