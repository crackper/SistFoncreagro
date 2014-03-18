<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmProyectoAmbito.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProyectoAmbito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="LblProyecto" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
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
                <asp:HiddenField ID="HFIdProyecto" runat="server" />
                <asp:ImageButton ID="ImgActualizar" runat="server" ImageUrl="~/img/grabar.gif" 
                    ToolTip="Actualizar Beneficiarios" />
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="OdsAmbitoProyecto" GridLines="None">
<MasterTableView clientdatakeynames="IdAmbProy" datakeynames="IdAmbProy" 
                        datasourceid="OdsAmbitoProyecto">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            FilterControlAltText="Filter column5 column" HeaderText="Elim." 
            ImageUrl="~/img/delete.gif" UniqueName="column5">
            <HeaderStyle Width="5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdAmbProy" 
            FilterControlAltText="Filter IdAmbProy column" HeaderText="IdAmbProy" 
            SortExpression="IdAmbProy" UniqueName="IdAmbProy" Visible="False" 
            AutoPostBackOnFilter="True">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_UbigeoDatos.Departamento" 
            FilterControlAltText="Filter column column" HeaderText="Departamento" 
            UniqueName="column">
            <HeaderStyle Width="17%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_UbigeoDatos.Provincia" 
            FilterControlAltText="Filter column1 column" HeaderText="Provincia" 
            UniqueName="column1">
            <HeaderStyle Width="17%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_UbigeoDatos.Distrito" 
            FilterControlAltText="Filter column2 column" HeaderText="Distrito" 
            UniqueName="column2">
            <HeaderStyle Width="17%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_UbigeoDatos.CentroPoblado" 
            FilterControlAltText="Filter column3 column" HeaderText="CentroPoblado" 
            UniqueName="CentroPoblado">
            <HeaderStyle Width="17%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_UbigeoDatos.Caserio" 
            FilterControlAltText="Filter column4 column" HeaderText="Caserío" 
            UniqueName="Caserio">
            <HeaderStyle Width="17%" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter Beneficiarios column" 
            HeaderText="Beneficiarios" UniqueName="Beneficiarios">
            <ItemTemplate>
                <telerik:RadNumericTextBox ID="RNBeneficiarios" Runat="server" 
                    Culture="es-PE" DbValue='<%# Bind("Beneficiarios") %>' Width="125px">
                </telerik:RadNumericTextBox>
            </ItemTemplate>
            <HeaderStyle Width="10%" />
        </telerik:GridTemplateColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsAmbitoProyecto" runat="server" 
                    SelectMethod="GetAmbitoProyectoByIdProy" 
                    TypeName="SistFoncreagro.BussinesLogic.AmbitoProyectoBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="_IdProy" QueryStringField="IdProyecto" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                Seleccionar Caseríos por:&nbsp;
                <asp:RadioButton ID="RdbDistrito" runat="server" AutoPostBack="True" 
                    Text="Distrito" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RdbCP" runat="server" AutoPostBack="True" 
                    Text="Centro Poblado" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RdbCas" runat="server" AutoPostBack="True" 
                    Text="Caserio" />
                <br />
                <asp:HiddenField ID="HFNivel" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid2" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="OdsDatosUbigeo" 
                    GridLines="None" Skin="Forest" AllowFilteringByColumn="True">
                    <GroupingSettings CaseSensitive="False" />
                    <ClientSettings AllowColumnHide="True">
                        <Resizing AllowColumnResize="True" />
                    </ClientSettings>
<MasterTableView DataSourceID="OdsDatosUbigeo" ClientDataKeyNames="CUBIGEO" DataKeyNames="CUBIGEO">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn CommandName="Select" 
            FilterControlAltText="Filter Seleccionar column" HeaderText="Selec." 
            Text="Selec" UniqueName="Seleccionar">
            <HeaderStyle Width="5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="CUBIGEO" 
            FilterControlAltText="Filter CUBIGEO column" HeaderText="CUBIGEO" 
            SortExpression="CUBIGEO" UniqueName="CUBIGEO" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Departamento" 
            FilterControlAltText="Filter Departamento column" HeaderText="Departamento" 
            SortExpression="Departamento" UniqueName="Departamento" 
            AllowFiltering="False">
            <HeaderStyle Width="19%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Provincia" 
            FilterControlAltText="Filter Provincia column" HeaderText="Provincia" 
            SortExpression="Provincia" UniqueName="Provincia" AllowFiltering="False">
            <HeaderStyle Width="19%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Distrito" 
            FilterControlAltText="Filter Distrito column" HeaderText="Distrito" 
            SortExpression="Distrito" UniqueName="Distrito" ShowFilterIcon ="false"
             FilterControlWidth = "60%" CurrentFilterFunction = "Contains" 
            AutoPostBackOnFilter="True">
            <HeaderStyle Width="19%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CentroPoblado" 
            FilterControlAltText="Filter CentroPoblado column" HeaderText="CentroPoblado" 
            SortExpression="CentroPoblado" UniqueName="CentroPoblado" ShowFilterIcon ="false"
             FilterControlWidth = "60%" CurrentFilterFunction = "Contains" 
            AutoPostBackOnFilter="True">
            <HeaderStyle Width="19%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Caserio" 
            FilterControlAltText="Filter Caserio column" HeaderText="Caserio" 
            SortExpression="Caserio" UniqueName="Caserio" ShowFilterIcon ="false"
             FilterControlWidth = "60%" CurrentFilterFunction = "Contains" 
            AutoPostBackOnFilter="True">
            <HeaderStyle Width="19%" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsDatosUbigeo" runat="server" 
                    SelectMethod="GetUbigeoDatosByNivel" 
                    TypeName="SistFoncreagro.BussinesLogic.UbigeoDatosBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="HFNivel" DefaultValue="aa" Name="_Nivel" 
                            PropertyName="Value" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
