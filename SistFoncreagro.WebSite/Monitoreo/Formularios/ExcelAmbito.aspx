<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ExcelAmbito.aspx.vb" Inherits="SistFoncreagro.WebSite.ExcelAmbito" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDatos" Font-Names="Arial" Font-Size="8pt">
            <Columns>
                <asp:BoundField DataField="Provincia" HeaderText="Provincia" 
                    SortExpression="Provincia">
                     <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Distrito" HeaderText="Distrito" 
                    SortExpression="Distrito">
                     <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="CentroPoblado" HeaderText="CentroPoblado" 
                    SortExpression="CentroPoblado">
                     <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                 <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                    SortExpression="Nombre">
                     <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Internvencion" HeaderText="Internvencion" 
                    SortExpression="Internvencion">
                     <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Anillo" HeaderText="Anillo" SortExpression="Anillo">
                 <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
               
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDatos" runat="server" 
            ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="RepAmbitoProyecto" 
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
