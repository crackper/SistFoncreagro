<%@ Page Title="Generar Plantilla de Datos" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmPlantilla.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmPlantilla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;Parametros para generar la plantilla de datos</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" 
                                ToolTip="Cerrar" CausesValidation="False" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table align="center" class="style1" >
                    <tr class="Texto">
                        <td colspan="2">
            Indique los datos solicitados, luego haga clic en el botón &quot;Generar&quot;.</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="font-family: Arial; font-size: 3pt">
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%">
                            Fecha:</td>
                        <td style="text-align: left" width="80%">

        
            <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px" AutoPostBack="True">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" AutoPostBack="True"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Proyecto:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Moneda:</td>
                        <td style="text-align: left">
                                                                                            <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True">
                                                                                                <asp:ListItem Value="1" Selected="True">Soles</asp:ListItem>
                                                                                                <asp:ListItem Value="2">Dolares</asp:ListItem>
                                                                                            </asp:RadioButtonList>
                                                                                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:Button ID="Button1" runat="server" Text="Button" />
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Proceso.gif" 
                ToolTip="Generar Plantilla" BorderStyle="None" BorderWidth="1px" />
                            <asp:Button ID="Button2" runat="server" Text="Button" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
           <asp:ObjectDataSource ID="odsProyecto" runat="server" 
        SelectMethod="GetAllFromProyecto" 
        TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>                                                     
   
             

                                            
    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" GridLines="None" Visible="False">
<MasterTableView>
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" ReadOnly="True" 
            SortExpression="Codigo" UniqueName="Codigo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Descripcion" 
            SortExpression="Descripcion" UniqueName="Descripcion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DebeMN" DataType="System.Decimal" 
            FilterControlAltText="Filter DebeMN column" HeaderText="DebeMN" ReadOnly="True" 
            SortExpression="DebeMN" UniqueName="DebeMN">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="HaberMN" DataType="System.Decimal" 
            FilterControlAltText="Filter HaberMN column" HeaderText="HaberMN" 
            ReadOnly="True" SortExpression="HaberMN" UniqueName="HaberMN">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SaldoDeudor" DataType="System.Decimal" 
            FilterControlAltText="Filter SaldoDeudor column" HeaderText="SaldoDeudor" 
            ReadOnly="True" SortExpression="SaldoDeudor" UniqueName="SaldoDeudor">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SaldoAcreedor" DataType="System.Decimal" 
            FilterControlAltText="Filter SaldoAcreedor column" HeaderText="SaldoAcreedor" 
            ReadOnly="True" SortExpression="SaldoAcreedor" UniqueName="SaldoAcreedor">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Activo" DataType="System.Decimal" 
            FilterControlAltText="Filter Activo column" HeaderText="Activo" ReadOnly="True" 
            SortExpression="Activo" UniqueName="Activo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Pasivo" DataType="System.Decimal" 
            FilterControlAltText="Filter Pasivo column" HeaderText="Pasivo" ReadOnly="True" 
            SortExpression="Pasivo" UniqueName="Pasivo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="PerdidaN" DataType="System.Decimal" 
            FilterControlAltText="Filter PerdidaN column" HeaderText="PerdidaN" 
            ReadOnly="True" SortExpression="PerdidaN" UniqueName="PerdidaN">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="GananciaN" DataType="System.Decimal" 
            FilterControlAltText="Filter GananciaN column" HeaderText="GananciaN" 
            ReadOnly="True" SortExpression="GananciaN" UniqueName="GananciaN">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="PerdidaF" DataType="System.Decimal" 
            FilterControlAltText="Filter PerdidaF column" HeaderText="PerdidaF" 
            ReadOnly="True" SortExpression="PerdidaF" UniqueName="PerdidaF">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="GananciaF" DataType="System.Decimal" 
            FilterControlAltText="Filter GananciaF column" HeaderText="GananciaF" 
            ReadOnly="True" SortExpression="GananciaF" UniqueName="GananciaF">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
    </telerik:RadGrid>
    <asp:SqlDataSource ID="sqlNivelTitulo" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="RepBalanceComprobacionAcumuladoNivelMayor" 
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:Parameter Name="Fecha" Type="DateTime" />
            <asp:Parameter DefaultValue="" Name="idProyecto" Type="Int32" />
            <asp:Parameter DefaultValue="" Name="idMoneda" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" GridLines="None" Visible="False">
<MasterTableView>
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Descripcion" 
            SortExpression="Descripcion" UniqueName="Descripcion">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DebeMN" DataType="System.Decimal" 
            FilterControlAltText="Filter DebeMN column" HeaderText="DebeMN" ReadOnly="True" 
            SortExpression="DebeMN" UniqueName="DebeMN">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="HaberMN" DataType="System.Decimal" 
            FilterControlAltText="Filter HaberMN column" HeaderText="HaberMN" 
            ReadOnly="True" SortExpression="HaberMN" UniqueName="HaberMN">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SaldoDeudor" DataType="System.Decimal" 
            FilterControlAltText="Filter SaldoDeudor column" HeaderText="SaldoDeudor" 
            ReadOnly="True" SortExpression="SaldoDeudor" UniqueName="SaldoDeudor">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SaldoAcreedor" DataType="System.Decimal" 
            FilterControlAltText="Filter SaldoAcreedor column" HeaderText="SaldoAcreedor" 
            ReadOnly="True" SortExpression="SaldoAcreedor" UniqueName="SaldoAcreedor">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Activo" DataType="System.Decimal" 
            FilterControlAltText="Filter Activo column" HeaderText="Activo" ReadOnly="True" 
            SortExpression="Activo" UniqueName="Activo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Pasivo" DataType="System.Decimal" 
            FilterControlAltText="Filter Pasivo column" HeaderText="Pasivo" ReadOnly="True" 
            SortExpression="Pasivo" UniqueName="Pasivo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="PerdidaN" DataType="System.Decimal" 
            FilterControlAltText="Filter PerdidaN column" HeaderText="PerdidaN" 
            ReadOnly="True" SortExpression="PerdidaN" UniqueName="PerdidaN">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="GananciaN" DataType="System.Decimal" 
            FilterControlAltText="Filter GananciaN column" HeaderText="GananciaN" 
            ReadOnly="True" SortExpression="GananciaN" UniqueName="GananciaN">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="PerdidaF" DataType="System.Decimal" 
            FilterControlAltText="Filter PerdidaF column" HeaderText="PerdidaF" 
            ReadOnly="True" SortExpression="PerdidaF" UniqueName="PerdidaF">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="GananciaF" DataType="System.Decimal" 
            FilterControlAltText="Filter GananciaF column" HeaderText="GananciaF" 
            ReadOnly="True" SortExpression="GananciaF" UniqueName="GananciaF">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
    </telerik:RadGrid>
    <asp:SqlDataSource ID="sqlDetalle" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="RepBalanceComprobacionAcumuladoNivelDetalle" 
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:Parameter Name="Fecha" Type="DateTime" />
            <asp:Parameter DefaultValue="" Name="idProyecto" Type="Int32" />
            <asp:Parameter DefaultValue="" Name="idMoneda" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
   
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" EnableAJAX="False">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadDatePicker1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadComboBox3">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadioButtonList2">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                    <telerik:AjaxUpdatedControl ControlID="sqlNivelTitulo" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                    <telerik:AjaxUpdatedControl ControlID="sqlDetalle" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ImageButton1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
   
 </asp:Content>


