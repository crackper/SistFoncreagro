<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ExcelStakeholder.aspx.vb" Inherits="SistFoncreagro.WebSite.ExcelStakeholder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
                <asp:BoundField DataField="Caserio" HeaderText="Caserio" 
                    SortExpression="Caserio">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Nombre" HeaderText="Apellidos y Nombres" 
                    SortExpression="Nombre">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                 <asp:BoundField DataField="Dni" HeaderText="Dni" 
                    SortExpression="Dni">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Actitud" HeaderText="Actitud" 
                    SortExpression="Actitud">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Poder" HeaderText="Poder" SortExpression="Poder">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="RedLideres" HeaderText="Red Lideres" SortExpression="RedLideres">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Comentario" HeaderText="Comentario" 
                    SortExpression="Comentario">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaRegistro" HeaderText="Fec. Reg." 
                    SortExpression="FechaRegistro" DataFormatString="{0:dd/MM/yyyy}">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
               
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDatos" runat="server" 
            ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="RepInteresados" 
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
