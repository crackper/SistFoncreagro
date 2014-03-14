<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ExcelExistencias.aspx.vb" Inherits="SistFoncreagro.WebSite.ExcelExistencias" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDatos" Font-Names="Arial" Font-Size="8pt" >
            <Columns>
                <asp:BoundField DataField="Producto" HeaderText="Producto" ReadOnly="True" 
                    SortExpression="Producto" >
                <HeaderStyle BackColor="#000099" ForeColor="White" HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" SortExpression="Unidad" >
                <HeaderStyle BackColor="#000099" ForeColor="White" HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="CantidadDisponible" HeaderText="Cantidad" ReadOnly="True" 
                    SortExpression="CantidadDisponible" >
                <HeaderStyle BackColor="#000099" ForeColor="White" HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Destino" HeaderText="Destino" ReadOnly="True" 
                    SortExpression="CantidadDisponible" >
                <HeaderStyle BackColor="#000099" ForeColor="White" HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDatos" runat="server" 
            ConnectionString="<%$ ConnectionStrings:cnx %>" 
            SelectCommand="GetProductosExistentesXProyecto" 
            SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="idProyecto" SessionField="IdProyecto" 
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
