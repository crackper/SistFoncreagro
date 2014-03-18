<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmProyectoConvenio.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProyectoConvenio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%; font-family: Arial; font-size: 9pt;">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblProyecto" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HiddenField ID="HFIdProyecto" runat="server" />
                <telerik:RadWindowManager ID="RWMensajes" runat="server">
                </telerik:RadWindowManager>
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
            <td>
                Lista Convenios:</td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="OdsConveProy" GridLines="None" 
                    ShowFooter="True" AllowPaging="True">
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
<MasterTableView datasourceid="OdsConveProy" ClientDataKeyNames="IdConvProy" 
                        DataKeyNames="IdConvProy">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter column1 column" HeaderText="Elim." 
            ImageUrl="~/img/delete.gif" UniqueName="column1" CommandName="Delete">
            <HeaderStyle Width="10%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdConvProy" DataType="System.Int32" 
            FilterControlAltText="Filter IdConvProy column" HeaderText="IdConvProy" 
            SortExpression="IdConvProy" UniqueName="IdConvProy" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Convenio.nombre" 
            FilterControlAltText="Filter column column" HeaderText="Convenio" 
            UniqueName="column">
            <HeaderStyle Width="75%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn Aggregate="Sum" DataField="MontoAprobado" 
            DataFormatString="{0:0,0.00}" DataType="System.Decimal" 
            FilterControlAltText="Filter MontoAprobado column" HeaderText="Monto" 
            SortExpression="MontoAprobado" UniqueName="MontoAprobado" 
            FooterText="TOTAL">
            <HeaderStyle Width="15%" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
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
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 672px" class="style2">
                                Convenio:&nbsp;
                            </td>
                            <td style="width: 264px">
                                Monto:</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 672px" class="style2">
                                <asp:TextBox ID="TxtConvenio" runat="server" TextMode="MultiLine" Width="659px"></asp:TextBox>
                            </td>
                            <td style="width: 264px">
                                <telerik:RadNumericTextBox ID="TxtMonto" Runat="server">
                                </telerik:RadNumericTextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="TxtMonto" ErrorMessage="Ingrese el monto"></asp:RequiredFieldValidator>
                                &nbsp;
                            </td>
                            <td>
                                <asp:ImageButton ID="BtnAceptar" runat="server" ImageUrl="~/img/update.gif" 
                                    ToolTip="Aceptar" Width="25px" />
                                <asp:ImageButton ID="BtnCancelar" runat="server" ImageUrl="~/img/cancel.gif" 
                                    Width="25px" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel2" runat="server" Visible="False">
                    <table style="width: 100%">
                        <tr>
                            <td>
                                Seleccionar Convenio de la lista:&nbsp;
                                <asp:HiddenField ID="HFIdConvenio" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <telerik:RadGrid ID="RadGrid2" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="Odsconvenio" 
                                    GridLines="None" AllowFilteringByColumn="True" Skin="Simple">
                                    <GroupingSettings CaseSensitive="False" />
                                    <MasterTableView ClientDataKeyNames="IdConvenio" DataKeyNames="IdConvenio" 
                                        DataSourceID="Odsconvenio" PageSize="5">
                                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                        </ExpandCollapseColumn>
                                        <Columns>
                                            <telerik:GridButtonColumn CommandName="Seleccionar" 
                                                FilterControlAltText="Filter column column" HeaderText="Seleccionar" 
                                                Text="Seleccionar" UniqueName="column">
                                            </telerik:GridButtonColumn>
                                            <telerik:GridBoundColumn DataField="IdConvenio" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdConvenio column" HeaderText="IdConvenio" 
                                                SortExpression="IdConvenio" UniqueName="IdConvenio" Visible="False">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="Codigo" 
                                                FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
                                                SortExpression="Codigo" UniqueName="Codigo" 
                                                AutoPostBackOnFilter="True" AllowFiltering="False">
                                                <HeaderStyle Width="10%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="Nombre" 
                                                FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
                                                SortExpression="Nombre" UniqueName="Nombre" ShowFilterIcon = "false"
                                                 CurrentFilterFunction = "contains" FilterControlWidth = "50%" 
                                                AutoPostBackOnFilter="True" >
                                                <HeaderStyle Width="80%" />
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
                                <asp:ObjectDataSource ID="Odsconvenio" runat="server" 
                                    SelectMethod="GetAllFromConvenio" 
                                    TypeName="SistFoncreagro.BussinesLogic.ConvenioBL"></asp:ObjectDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
