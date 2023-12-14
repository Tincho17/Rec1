<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarProductos.aspx.cs" Inherits="Rec1.ListarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buscar y Editar Producto</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Buscar y Editar Producto</h3>
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" EnableViewState="False"></asp:Label>
            <br />
            <label>Ingrese ID de Producto:</label>
            <asp:TextBox ID="txtBuscarId" runat="server" placeholder="Ingrese ID"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br /><br />
            <label>ID de Producto:</label>
            <asp:TextBox ID="txtId" runat="server" ReadOnly="true"></asp:TextBox>
            <br />
            <label>Descripción de Producto:</label>
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Descripción" OnClick="btnActualizar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Producto" OnClick="btnEliminar_Click" />
            <br /><br />
            <asp:HyperLink ID="lnkCrearProducto" runat="server" Text="Volver a Crear Productos" NavigateUrl="~/CrearProducto.aspx" />
                         <br /><br />
            <asp:HyperLink ID="lnkVolverAlMenu" runat="server" Text="Volver al Menú" NavigateUrl="~/Menu.aspx" />
        </div>
    </form>
</body>
</html>