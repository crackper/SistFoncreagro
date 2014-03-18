<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmProyectoInformes.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProyectoInformes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="LblProyecto" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Label"></asp:Label>
                <asp:HiddenField ID="HIdProyecto" runat="server" />
                <telerik:RadWindowManager ID="RWMensajes" runat="server">
                </telerik:RadWindowManager>
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
                Lista de Informes:</td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RGInforme" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="OdsInformes" GridLines="None" Skin="Forest" 
                    AllowPaging="True">
<MasterTableView datasourceid="OdsInformes" ClientDataKeyNames="IdInfProy" CommandItemDisplay="Top" 
                        DataKeyNames="IdInfProy">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Registro"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridEditCommandColumn ButtonType="ImageButton" 
            EditImageUrl="~/img/edit.gif" 
            FilterControlAltText="Filter EditCommandColumn column" HeaderText="Edit">
            <HeaderStyle Width="5%" />
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Borrar" 
            FilterControlAltText="Filter column column" HeaderText="Elim." 
            ImageUrl="~/img/delete.gif" UniqueName="column">
            <HeaderStyle Width="5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdInfProy" DataType="System.Int32" 
            FilterControlAltText="Filter IdInfProy column" HeaderText="IdInfProy" 
            SortExpression="IdInfProy" UniqueName="IdInfProy" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Archivo.Ruta" 
            FilterControlAltText="Filter Archivo column" HeaderText="Informe" 
            UniqueName="Archivo">
            <HeaderStyle Width="25%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" HeaderText="Tipo" 
            SortExpression="Tipo" UniqueName="Tipo">
            <HeaderStyle Width="12%" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn DataField="FechaProg" 
            FilterControlAltText="Filter FechaProg column" HeaderText="F. Programada" 
            UniqueName="FechaProg">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" 
                    Text='<%# validarfecha(databinder.eval(container.dataitem, "FechaProg")) %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle Width="15%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn DataField="FechaPresen" 
            FilterControlAltText="Filter FechaPresen column" HeaderText="F. Presentó" 
            UniqueName="FechaPresen">
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" 
                    Text='<%# validarfecha(databinder.eval(container.dataitem, "FechaPresen")) %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle Width="15%" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="Estado" 
            FilterControlAltText="Filter Estado column" HeaderText="Estado" 
            SortExpression="Estado" UniqueName="Estado">
            <HeaderStyle Width="13%" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            HeaderText="Ver Archivo" UniqueName="TemplateColumn">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" 
                    NavigateUrl='<%# Ruta(Eval("_Archivo.Ruta")) %>' Target="_blank">Ver</asp:HyperLink>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
    </Columns>

<EditFormSettings EditFormType="WebUserControl" 
        UserControlName="~\Monitoreo\Controles\ControlProyectoInformes.ascx">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsInformes" runat="server" 
                    SelectMethod="GetInformeProyectoByIdProyecto" 
                    TypeName="SistFoncreagro.BussinesLogic.InformeProyectoBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="_idProy" QueryStringField="IdProyecto" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <telerik:RadWindowManager ID="RWM1" runat="server">
                </telerik:RadWindowManager>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>
