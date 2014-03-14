<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ExcelGeneracionEmpleo.aspx.vb" Inherits="SistFoncreagro.WebSite.ExcelGeneracionEmpleo" %>

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
                    SortExpression="Distrito">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="CentroPoblado" HeaderText="CentroPoblado" 
                    ReadOnly="True" SortExpression="CentroPoblado">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Caserio" HeaderText="Caserio" 
                    ReadOnly="True" SortExpression="Caserio">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Internvencion" HeaderText="Internvencion" 
                    ReadOnly="True" SortExpression="Internvencion">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Codigo" HeaderText="C. Costo" ReadOnly="True" 
                    SortExpression="Codigo">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Concepto" HeaderText="Concepto" ReadOnly="True" 
                    SortExpression="Concepto">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="beneficiario" HeaderText="Beneficiario" 
                    ReadOnly="True" SortExpression="beneficiario">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="dni" HeaderText="DNI" ReadOnly="True" 
                    SortExpression="dni">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" ReadOnly="True" 
                    SortExpression="Unidad">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="Cantidad" DataFormatString="{0:N2}" 
                    HeaderText="Cantidad" ReadOnly="True" SortExpression="Cantidad">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="PrecioUnitario" DataFormatString="{0:N2}" 
                    HeaderText="PrecioUnitario" ReadOnly="True" SortExpression="PrecioUnitario">
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
                <asp:BoundField DataField="Fecha" DataFormatString="{0:dd/MM/yyyy}" 
                    HeaderText="Fecha" ReadOnly="True" SortExpression="Fecha">
                <HeaderStyle BackColor="#000099" ForeColor="White" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDatos" runat="server" 
            ConnectionString="<%$ ConnectionStrings:cnx %>" 
            SelectCommand="RepGeneracionEmpleo" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="idProyecto" SessionField="IdProyecto" 
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
