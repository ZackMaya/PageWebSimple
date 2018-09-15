<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProyectoWebServicioSocial.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 92px;
        }
    </style>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <center>
    <h1>Prueba de desarrollo Web </h1>
    
    <h5>Elabora: Ernesto Z. Maya D.</h5>
    

    <form id="form1" runat="server">
        <table style="max-width:70%" >
            <tr>
                <td class="auto-style1">Selecciona el filtro que deseas</td>
            </tr>
                <tr>
                <td class="auto-style1">
                    <asp:Button Text="Precio ↑" ID="btnpreciodesc" runat="server" OnClick="btnpreciodesc_Click1" class="btn" />
                    <asp:Button Text="Precio ↓" ID="btnprecioasc" runat="server" OnClick="btnprecioasc_Click" class="btn" />
                </td>
                <td class="auto-style1">
                    <asp:Button Text="Existencia ↑" ID="btnexistenciadesc" runat="server" OnClick="btnexistenciadesc_Click" class="btn"/>
                    <asp:Button Text="Existencia ↓" ID="btnexistenciaasc" runat="server" OnClick="btnexistenciaasc_Click" class="btn" />
                </td>
                <td class="auto-style1">
                    <asp:Button Text="A-Z ↑" ID="btnalfadesc" runat="server" OnClick="btnalfadesc_Click" class="btn"/>
                    <asp:Button Text="A-Z ↓" ID="btnalfaasc" runat="server" OnClick="btnalfaasc_Click" class="btn"/>
                </td>
                </tr>
        </table>

        <br />
        <hr />
        <h3>Lista de Productos</h3>
        <br />
    <div>
        <table class="table table-bordered">
            <asp:GridView ID="getProducto" runat="server" AutoGenerateColumns="false" Width="806px">
                <Columns>
                    <asp:BoundField DataField="nombre_producto" HeaderText="Nombre Producto" />
                    <asp:BoundField DataField="precio" HeaderText="Precio MX" />
                    <asp:BoundField DataField="nombre_categoria" HeaderText="Categoria" />
                    <asp:BoundField DataField="cantidad_actual" HeaderText="Existencia" />
                    <asp:BoundField DataField="descripcion_producto" HeaderText="Descripción" />

                </Columns>
            </asp:GridView>
            </table>
    </div>
    </form>
        <br />
        <br />
        <br />
        </center>
</body>
</html>
