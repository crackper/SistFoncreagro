<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ExcelGastos.aspx.vb" Inherits="SistFoncreagro.WebSite.ExcelGastos" %>

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
                <asp:BoundField DataField="Distrito" HeaderText="Distrito" ReadOnly="True" 
                    SortExpression="Distrito" >
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="CentroPoblado" HeaderText="CentroPoblado" 
                    ReadOnly="True" SortExpression="CentroPoblado" >
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Caserio" HeaderText="Caserio" ReadOnly="True" 
                    SortExpression="Caserio" >
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Internvencion" HeaderText="Internvencion" 
                    ReadOnly="True" SortExpression="Internvencion" >
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" 
                    SortExpression="Codigo" >
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Producto" HeaderText="Producto" ReadOnly="True" 
                    SortExpression="Producto" >
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" ReadOnly="True" 
                    SortExpression="Unidad" >
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" ReadOnly="True" 
                    SortExpression="Cantidad" DataFormatString="{0:N2}" >
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="PrecioUnitario" HeaderText="PrecioUnitario" 
                    ReadOnly="True" SortExpression="PrecioUnitario" DataFormatString="{0:N2}" >
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Total">
                     <ItemTemplate>
                       <asp:Label runat="server" ID="Label1"
                        Text='<%# Calcular_Total(Eval("PrecioUnitario"),               
                                       Eval("Cantidad")) %>'>
                       </asp:Label>
                    </ItemTemplate>
                     <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:TemplateField>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" 
                    ReadOnly="True" SortExpression="Fecha" DataFormatString="{0:dd/MM/yyyy}" >
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDatos" runat="server" 
            ConnectionString="<%$ ConnectionStrings:cnx %>" 
            SelectCommand="RepGastosXCaserio" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="idProyecto" SessionField="IdProyecto" 
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
