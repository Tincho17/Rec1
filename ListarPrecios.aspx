<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarPrecios.aspx.cs" Inherits="Rec1.ListarPrecios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buscar y Editar Precio</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Buscar y Editar Precio</h3>
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" EnableViewState="False"></asp:Label>
            <br />
            <label>Ingrese ID de Precio:</label>
            <asp:TextBox ID="txtBuscarId" runat="server" placeholder="Ingrese ID"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br /><br />
            <label>ID de Precio:</label>
            <asp:TextBox ID="txtId" runat="server" ReadOnly="true"></asp:TextBox>
            <br />
            <label>Fecha:</label>
            <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            <br />
            <label>Monto:</label>
            <asp:TextBox ID="txtMonto" runat="server"></asp:TextBox>
            <br />
            <label>ID de Producto:</label>
            <asp:TextBox ID="txtIdProducto" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Precio" OnClick="btnActualizar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Precio" OnClick="btnEliminar_Click" />
            <br /><br />
            <asp:HyperLink ID="lnkCrearPrecio" runat="server" Text="Volver a Crear Precios" NavigateUrl="~/CrearPrecio.aspx" />
                         <br /><br />
            <asp:HyperLink ID="lnkVolverAlMenu" runat="server" Text="Volver al Menú" NavigateUrl="~/Menu.aspx" />
        </div>
    </form>
</body>
</html>