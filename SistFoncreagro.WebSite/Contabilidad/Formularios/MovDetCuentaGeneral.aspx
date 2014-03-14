﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MovDetCuentaGeneral.aspx.vb" Inherits="SistFoncreagro.WebSite.MovDetCuentaGeneral" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Movimiento detallado de la Cuenta</title>
     <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 1150px;">
    
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/excel.gif" 
            ToolTip="Exportar a Excel" />
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataSourceID="DetalleCuenta" GridLines="None" 
            Height="100%" style="font-size: 9pt; font-family: Arial" Width="1150px" 
            DataKeyNames="Codigo,IdSubDiario" ForeColor="#333333" ShowFooter="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Agregar.gif" 
                            ToolTip="Movimiento detallado del Comprobante" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Mes" HeaderText="Mes" SortExpression="Mes">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="IdSubDiario" HeaderText="S.D." 
                    SortExpression="IdSubDiario">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Codigo" HeaderText="Comprobante" 
                    SortExpression="Codigo">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaContable" DataFormatString="{0:dd/MM/yyyy}" 
                    HeaderText="Fch. Contable" SortExpression="FechaContable">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Codigo1" HeaderText="Cuenta" 
                    SortExpression="Codigo1">
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
                <asp:BoundField DataField="Codigo2" HeaderText="C.C." SortExpression="Codigo2">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Ruc" HeaderText="Coa" SortExpression="Ruc">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Registro" HeaderText="Registro" ReadOnly="True" 
                    SortExpression="Registro">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Glosa" HeaderText="Glosa" SortExpression="Glosa">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Proyecto" HeaderText="Proyecto" 
                    SortExpression="Proyecto">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
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
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:SqlDataSource ID="DetalleCuenta" runat="server" 
            ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="GetMovDetCuenta" 
            SelectCommandType="StoredProcedure" 
            ProviderName="<%$ ConnectionStrings:cnx.ProviderName %>">
            <SelectParameters>
                <asp:QueryStringParameter Name="Fecha" QueryStringField="Fecha" 
                    Type="DateTime" />
                <asp:QueryStringParameter Name="cuenta" QueryStringField="Cuenta" 
                    Type="String" />
                <asp:Parameter DefaultValue="0" Name="idProyecto" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Height="750px" 
            Width="1150px">
            <Windows>
                <telerik:RadWindow ID="Movimiento" runat="server" AutoSize="True" 
                    Behavior="Resize, Close" Behaviors="Resize, Close" Height="750px" InitialBehavior="None" 
                    Left="" Modal="True" NavigateUrl="" Style="display: none;" 
                    Title="Movimiento detallado del Comprobante" Top="" VisibleStatusbar="True" 
                    Width="1100px">
                    <Localization Cancel="Cancelar" Close="Cerrar" Maximize="Maximizar" 
                        Minimize="Minimizar" Restore="Restaurar" />
                </telerik:RadWindow>
            </Windows>
        </telerik:RadWindowManager>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
      <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">

        function Abrir(Fecha, SubDiario,  Codigo) {
            var oWnd = radopen("MovDetComprobanteGeneral.aspx?Fecha=" + Fecha + "&SubDiario=" + SubDiario +  "&Codigo=" + Codigo, "Movimiento");
        }
                
     </script>
    </telerik:RadCodeBlock>
    </div>
    </form>
</body>
</html>