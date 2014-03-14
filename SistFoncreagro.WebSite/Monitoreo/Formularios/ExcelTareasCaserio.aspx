<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ExcelTareasCaserio.aspx.vb" Inherits="SistFoncreagro.WebSite.ExcelTareasCaserio" %>

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
                <asp:BoundField DataField="Provincia" HeaderText="Provincia" ReadOnly="True" 
                    SortExpression="Provincia">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Distrito" HeaderText="Distrito" ReadOnly="True" 
                    SortExpression="Distrito">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="CentroPoblado" HeaderText="Centro Poblado" 
                    ReadOnly="True" SortExpression="CentroPoblado">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Caserio" HeaderText="Caserío" ReadOnly="True" 
                    SortExpression="Caserio">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Intervencion" HeaderText="Intervención" ReadOnly="True" 
                    SortExpression="Intervencion">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Actividad" HeaderText="Actividad" ReadOnly="True" 
                    SortExpression="Actividad">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="SubActividad" HeaderText="SubActividad" 
                    ReadOnly="True" SortExpression="SubActividad">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" 
                    ReadOnly="True" SortExpression="Descripcion">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Estado" HeaderText="Estado" ReadOnly="True" 
                    SortExpression="Estado">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" ReadOnly="True" 
                    SortExpression="Cantidad">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Fecha" DataFormatString="{0:dd/MM/yyyy}" 
                    HeaderText="Fecha" ReadOnly="True" SortExpression="Fecha">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDatos" runat="server" 
            ConnectionString="<%$ ConnectionStrings:cnx %>" 
            SelectCommand="RepCompromisosCaserios" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="IdProyecto" SessionField="IdProyecto" 
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
