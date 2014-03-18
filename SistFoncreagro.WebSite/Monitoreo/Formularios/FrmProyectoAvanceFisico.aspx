<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmProyectoAvanceFisico.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProyectoAvanceFisico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblProyecto" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Fechaserv" runat="server" BackColor="#FFFFCC" Visible="False"></asp:Label>
                <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
                    DynamicHorizontalOffset="2" Font-Names="Arial" Font-Size="Small" 
                    ForeColor="#284E98" StaticSubMenuIndent="10px">
                    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#B5C7DE" />
                    <DynamicSelectedStyle BackColor="#507CD1" />
                    <Items>
                        <asp:MenuItem Text="Ir a..." Value="Ir a...">
                            <asp:MenuItem Text="Estructura" Value="Estructura">
                                <asp:MenuItem Text="Convenio" Value="Convenio"></asp:MenuItem>
                                <asp:MenuItem Text="Componentes" Value="Componentes"></asp:MenuItem>
                                <asp:MenuItem Text="Actividades" Value="Actividades"></asp:MenuItem>
                                <asp:MenuItem Text="Centros de Costo" Value="CCostos"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="Datos Generales" Value="Datos"></asp:MenuItem>
                            <asp:MenuItem Text="Ambito/Beneficiarios" Value="Ambito"></asp:MenuItem>
                            <asp:MenuItem Text="Informes" Value="Informes"></asp:MenuItem>
                            <asp:MenuItem Text="Avance Físico" Value="AvanFis"></asp:MenuItem>
                            <asp:MenuItem Text="Forecast Mensual" Value="ForFin"></asp:MenuItem>
                            <asp:MenuItem Text="Forecast Anual" Value="ForAnual"></asp:MenuItem>
                        </asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <StaticSelectedStyle BackColor="#507CD1" />
                </asp:Menu>
                <telerik:RadWindowManager ID="RWMensajes" runat="server">
                </telerik:RadWindowManager>
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td style="width: 87px">
                            Año:</td>
                        <td style="width: 137px">
                            <telerik:RadNumericTextBox ID="TxtAnio" Runat="server" MaxLength="4" 
                                MaxValue="9999" MinValue="2000" ReadOnly="True" DataType="System.Int32">
                                <NumberFormat DecimalDigits="0" GroupSeparator="" />
                            </telerik:RadNumericTextBox>
                        </td>
                        <td align="right" class="style2" style="width: 1045px">
                            Mes:&nbsp;&nbsp;&nbsp;
                        </td>
                        <td align="left" style="width: 241px">
                            <asp:DropDownList ID="CbMes" runat="server" Height="22px" 
                                style="margin-left: 0px" AutoPostBack="True">
                                <asp:ListItem>ENERO</asp:ListItem>
                                <asp:ListItem>FEBRERO</asp:ListItem>
                                <asp:ListItem>MARZO</asp:ListItem>
                                <asp:ListItem>ABRIL</asp:ListItem>
                                <asp:ListItem>MAYO</asp:ListItem>
                                <asp:ListItem>JUNIO</asp:ListItem>
                                <asp:ListItem>JULIO</asp:ListItem>
                                <asp:ListItem>AGOSTO</asp:ListItem>
                                <asp:ListItem>SEPTIEMBRE</asp:ListItem>
                                <asp:ListItem>OCTUBRE</asp:ListItem>
                                <asp:ListItem>NOVIEMBRE</asp:ListItem>
                                <asp:ListItem>DICIEMBRE</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HiddenField ID="HFIdProyecto" runat="server" />
                <asp:HiddenField ID="HFNumMes" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="BtnCrear" runat="server" 
                    Text="Crear Datos para el mes actual" />
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" GridLines="None" DataSourceID="OdsAvance" 
                    AllowPaging="True" PageSize="6">
<MasterTableView ClientDataKeyNames="IdAvanceFisico" DataKeyNames="IdAvanceFisico" 
                        DataSourceID="OdsAvance">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="IdAvanceFisico" DataType="System.Int32" 
            FilterControlAltText="Filter IdAvanceFisico column" HeaderText="IdAvanceFisico" 
            SortExpression="IdAvanceFisico" UniqueName="IdAvanceFisico" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Componente.Nombre" 
            FilterControlAltText="Filter column column" HeaderText="Componente" 
            UniqueName="column">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Act.Nombre" 
            FilterControlAltText="Filter column1 column" HeaderText="Actividad" 
            UniqueName="column1">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_ElementoGasto.NomElemGasto" 
            FilterControlAltText="Filter column2 column" HeaderText="Elemento Gasto" 
            UniqueName="column2">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Valor" DataType="System.Decimal" 
            FilterControlAltText="Filter Valor column" HeaderText="Valor" 
            SortExpression="Valor" UniqueName="Valor">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter Agregar column" 
            HeaderText="Agregar" UniqueName="Dato">
            <ItemTemplate>
                <telerik:RadNumericTextBox ID="TxtValor" Runat="server">
                </telerik:RadNumericTextBox>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Agregar" 
            FilterControlAltText="Filter Agregar column" ImageUrl="~/img/mas.gif" 
            UniqueName="Agregar">
        </telerik:GridButtonColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsAvance" runat="server" 
                    SelectMethod="GetAvanceFisicoByIdProyecto" 
                    TypeName="SistFoncreagro.BussinesLogic.AvanceFisicoBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="_IdProyecto" QueryStringField="IdProyecto" 
                            Type="Int32" />
                        <asp:ControlParameter ControlID="HFNumMes" Name="_Mes" PropertyName="Value" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="FechaActual" 
                    SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
