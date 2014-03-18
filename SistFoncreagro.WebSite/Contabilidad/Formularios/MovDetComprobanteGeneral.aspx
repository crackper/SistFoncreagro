<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MovDetComprobanteGeneral.aspx.vb" Inherits="SistFoncreagro.WebSite.MovDetComprobanteGeneral" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Movimiento detallado del Comprobante</title>
     <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 1100px;">
    
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/excel.gif" 
            ToolTip="Exportar a Excel" />
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataSourceID="DetalleComprobante" GridLines="None" 
            Height="100%" style="font-size: 9pt; font-family: Arial" Width="1100px" 
            ShowFooter="True" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="FechaContable" DataFormatString="{0:dd/MM/yyyy}" 
                    HeaderText="Fch. Contable" SortExpression="FechaContable">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaDocumento" DataFormatString="{0:dd/MM/yyyy}" 
                    HeaderText="Fch. Documento" SortExpression="FechaDocumento">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Codigo" HeaderText="Cuenta" SortExpression="Codigo">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Codigo1" HeaderText="C.C" SortExpression="Codigo1">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Ruc" HeaderText="Coa" SortExpression="Ruc">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="TipoCambio" HeaderText="T.C." 
                    SortExpression="TipoCambio">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="IdMoneda" HeaderText="M." SortExpression="IdMoneda">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="CargoMN" HeaderText="Debe MN" 
                    SortExpression="CargoMN">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="AbonoMN" HeaderText="Haber MN" 
                    SortExpression="AbonoMN">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="CargoME" HeaderText="Debe ME" 
                    SortExpression="CargoME">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="AbonoME" HeaderText="Haber ME" 
                    SortExpression="AbonoME">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Registro" HeaderText="Registro" ReadOnly="True" 
                    SortExpression="Registro">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="NroCheque" HeaderText="N° Cheque" 
                    SortExpression="NroCheque">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Glosa" HeaderText="Glosa" SortExpression="Glosa">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:SqlDataSource ID="DetalleComprobante" runat="server" 
            ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="GetMovDetComprobante" 
            SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:QueryStringParameter Name="fecha" QueryStringField="Fecha" 
                    Type="DateTime" />
                <asp:QueryStringParameter Name="codigo" QueryStringField="Codigo" 
                    Type="String" />
                <asp:Parameter DefaultValue="0" Name="idProyecto" Type="Int32" />
                <asp:QueryStringParameter Name="subDiario" QueryStringField="SubDiario" 
                    Type="Int32" DefaultValue="" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
