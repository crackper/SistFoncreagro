<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmProyectoComponentes.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProyectoComponentes" Debug = "true" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
                    <script type="text/javascript">
                        function NuevoComponente(IdProyecto) {
                            var oWnd = radopen("FrmComponentes1.aspx?IdProyecto=" + IdProyecto, "AsignarComp");
                            //                            var oWnd = radopen("FrmConvenioMarco.aspx", "NuevoMarco");
                            return false;
                        }
                        function CerrarRadWindow(oWnd, args) {
                            var arg = args.get_argument();
                            if (arg) {
                                if (arg.indicador >= 1) {
                                    $find("<%= AJAX_MANAGER.ClientID %>").ajaxRequest("ActualizarGrilla|" + arg.indicador);
                                }
                            }
                        }
                </script>
     </telerik:RadCodeBlock>
    
    
    <table style="width: 100%">
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Label ID="LblProyecto" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:HiddenField ID="HFIdProyecto" runat="server" />
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
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                Lista de Componentes:</td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="OdsProyComp" GridLines="None" 
                    AllowPaging="True" PageSize="4" ShowFooter="True">
<MasterTableView datasourceid="OdsProyComp" ClientDataKeyNames="IdProyComp" 
                        DataKeyNames="IdProyComp">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" 
            FilterControlAltText="Filter Editar column" HeaderText="Editar" 
            ImageUrl="~/img/Edit.gif" UniqueName="Editar">
            <HeaderStyle Width="5%" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter column2 column" HeaderText="Elim." 
            ImageUrl="~/img/delete.gif" UniqueName="column2" CommandName="Delete">
            <HeaderStyle Width="10%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdProyComp" DataType="System.Int32" 
            FilterControlAltText="Filter IdProyComp column" HeaderText="IdProyComp" 
            SortExpression="IdProyComp" UniqueName="IdProyComp" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Convenio.Nombre" 
            FilterControlAltText="Filter column1 column" HeaderText="Convenio" 
            UniqueName="Convenio">
            <HeaderStyle Width="45%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Componente.Nombre" 
            FilterControlAltText="Filter column column" HeaderText="Componente" 
            UniqueName="Componente">
            <HeaderStyle Width="30%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn Aggregate="Sum" DataField="Porcentaje" 
            DataFormatString="{0:0,0.00}" FilterControlAltText="Filter Porcentaje column" 
            HeaderText="Porcentaje" UniqueName="Porcentaje">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsProyComp" runat="server" 
                    SelectMethod="GetProyCompByIdProyecto" 
                    TypeName="SistFoncreagro.BussinesLogic.ProyCompBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="_idProy" QueryStringField="IdProyecto" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
                <asp:HiddenField ID="HFIdProyComp" runat="server" />
                <telerik:RadWindowManager ID="RWMensajes" runat="server">
                    <Windows>
                        <telerik:RadWindow ID="AsignarComp" runat="server" Modal="True" 
                            Title="Nuevo Componente" Width="750px">
                        </telerik:RadWindow>
                    </Windows>
                </telerik:RadWindowManager>
                <telerik:RadAjaxManager ID="AJAX_MANAGER" runat="server">
                </telerik:RadAjaxManager>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table style="width: 100%">
                        <tr>
                            <td align="right" style="width: 75px">
                                Convenio:</td>
                            <td style="width: 802px">
                                <asp:TextBox ID="TxtConvenio" runat="server" TextMode="MultiLine" Width="795px" 
                                    ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 75px">
                                Componente:</td>
                            <td style="width: 802px">
                                <asp:TextBox ID="TxtComponente" runat="server" Width="790px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 75px">
                                Porcentaje:</td>
                            <td style="width: 802px">
                                <telerik:RadNumericTextBox ID="TxtPorcen" Runat="server">
                                </telerik:RadNumericTextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="TxtPorcen" ErrorMessage="Valor Requerido"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 75px">
                                &nbsp;</td>
                            <td style="width: 802px">
                                <asp:HiddenField ID="HFIdConveProy" runat="server" />
                                <asp:HiddenField ID="HFIdComponente" runat="server" />
                                <asp:ImageButton ID="BtnGrabar" runat="server" ImageUrl="~/img/update.gif" 
                                    Width="25px" />
                                <asp:ImageButton ID="BtnCancelar" runat="server" ImageUrl="~/img/cancel.gif" 
                                    Width="25px" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
            &nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Panel ID="Panel2" runat="server" Visible="False">
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 346px">
                                Seleccionar Convenio:</td>
                            <td>
                                Seleccionar Componente:<asp:Button ID="BtnNueComp" runat="server" Text="..." />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 346px">
                                <telerik:RadGrid ID="RadGrid2" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="OdsConveProy" 
                                    GridLines="None" PageSize="4" Width="334px" Skin="Office2007">

                                    <MasterTableView DataSourceID="OdsConveProy" ClientDataKeyNames="IdConvProy" 
                                        DataKeyNames="IdConvProy">
                                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                            <HeaderStyle Width="20px" />
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                            <HeaderStyle Width="20px" />
                                        </ExpandCollapseColumn>
                                        <Columns>
                                            <telerik:GridButtonColumn CommandName="Select" 
                                                FilterControlAltText="Filter column1 column" HeaderText="Selec." Text="Selec." 
                                                UniqueName="column1">
                                                <HeaderStyle Width="5%" />
                                            </telerik:GridButtonColumn>
                                            <telerik:GridBoundColumn DataField="IdConvProy" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdConvProy column" HeaderText="IdConvProy" 
                                                SortExpression="IdConvProy" UniqueName="IdConvProy" Visible="False">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="_Convenio.Nombre" 
                                                FilterControlAltText="Filter column column" HeaderText="Convenio" 
                                                UniqueName="convenio">
                                                <HeaderStyle Width="95%" />
                                            </telerik:GridBoundColumn>
                                        </Columns>
                                        <EditFormSettings>
                                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                            </EditColumn>
                                        </EditFormSettings>
                                    </MasterTableView>
                                    <FilterMenu EnableImageSprites="False">
                                    </FilterMenu>
                                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                                    </HeaderContextMenu>
                                </telerik:RadGrid>
                                <asp:ObjectDataSource ID="OdsConveProy" runat="server" 
                                    SelectMethod="GetFromConveProyByIdProyecto" 
                                    TypeName="SistFoncreagro.BussinesLogic.ConveProyBL">
                                    <SelectParameters>
                                        <asp:QueryStringParameter Name="_id" QueryStringField="IdProyecto" 
                                            Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                            <td>
                                <telerik:RadGrid ID="RadGrid3" runat="server" AllowFilteringByColumn="True" 
                                    AllowPaging="True" AutoGenerateColumns="False" CellSpacing="0" 
                                    DataSourceID="OdsComponente" GridLines="None" PageSize="4" Skin="Forest">
                                    <GroupingSettings CaseSensitive="False" />
                                    <MasterTableView DataSourceID="OdsComponente" ClientDataKeyNames="IdComponente" 
                                        DataKeyNames="IdComponente">
                                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                            <HeaderStyle Width="20px" />
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                            <HeaderStyle Width="20px" />
                                        </ExpandCollapseColumn>
                                        <Columns>
                                            <telerik:GridButtonColumn CommandName="Select" 
                                                FilterControlAltText="Filter column column" HeaderText="Selec." Text="Selec." 
                                                UniqueName="column">
                                                <HeaderStyle Width="5%" />
                                            </telerik:GridButtonColumn>
                                            <telerik:GridBoundColumn DataField="IdComponente" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdComponente column" HeaderText="IdComponente" 
                                                SortExpression="IdComponente" UniqueName="IdComponente" Visible="False">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="Nombre" 
                                                FilterControlAltText="Filter Nombre column" HeaderText="Componente" 
                                                SortExpression="Nombre" UniqueName="Nombre" ShowFilterIcon = "false" AutoPostBackOnFilter="True" 
                                                 CurrentFilterFunction = "contains" FilterControlWidth = "60%" >
                                            </telerik:GridBoundColumn>
                                        </Columns>
                                        <EditFormSettings>
                                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                            </EditColumn>
                                        </EditFormSettings>
                                    </MasterTableView>
                                    <FilterMenu EnableImageSprites="False">
                                    </FilterMenu>
                                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                                    </HeaderContextMenu>
                                </telerik:RadGrid>
                                <asp:ObjectDataSource ID="OdsComponente" runat="server" 
                                    SelectMethod="GetAllFromComponente" 
                                    TypeName="SistFoncreagro.BussinesLogic.ComponenteBL"></asp:ObjectDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 346px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
