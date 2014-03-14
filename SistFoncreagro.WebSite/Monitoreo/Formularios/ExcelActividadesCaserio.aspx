<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ExcelActividadesCaserio.aspx.vb" Inherits="SistFoncreagro.WebSite.ExcelActividadesCaserio" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlData" Font-Names="Arial" Font-Size="8pt">
            <Columns>
                <asp:BoundField DataField="Provincia" HeaderText="Provincia" 
                    SortExpression="Provincia">
                <HeaderStyle BackColor="#000099" />
                </asp:BoundField>
                <asp:BoundField DataField="Distrito" HeaderText="Distrito" 
                    SortExpression="Distrito">
                <HeaderStyle BackColor="#000099" />
                </asp:BoundField>
                <asp:BoundField DataField="Caserio" HeaderText="Caserio" 
                    SortExpression="Caserio">
                <HeaderStyle BackColor="#000099" />
                </asp:BoundField>
                <asp:BoundField DataField="Actividad" HeaderText="Actividad" ReadOnly="True" 
                    SortExpression="Actividad">
                <HeaderStyle BackColor="#000099" />
                </asp:BoundField>
            </Columns>
            <HeaderStyle ForeColor="White" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlData" runat="server" 
            ConnectionString="<%$ ConnectionStrings:cnx %>" 
            SelectCommand="RepActividadesCaserios" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="IdProyecto" SessionField="IdProyecto" 
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
