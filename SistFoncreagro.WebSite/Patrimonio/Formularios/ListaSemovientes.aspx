<%@ Page Title="Relación de Activo Biológico" Language="vb" AutoEventWireup="false" MasterPageFile="~/Patrimonio/MasterPagePatrimonio.master" CodeBehind="ListaSemovientes.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaSemovientes" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function onRequestStart(sender, args) {
            if (args.get_eventTarget().indexOf("ExportToExcelButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToWordButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToPdfButton") >= 0) {
                args.set_enableAjax(false);
            }
        }
    </script>


    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td >
                            Lista de activos biológicos</td>
                        <td  >
                            </td>
                        <td style="text-align: center; width:30px"   >
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Patrimonio/Formularios/DefaultPatrimonio.aspx" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td width="40%">
                            <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlSemovientes" 
                                GridLines="None" Skin="Hay" AllowFilteringByColumn="True" PageSize="30">
                                <GroupingSettings CaseSensitive="False" />
                                <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
<MasterTableView commanditemdisplay="Top" datasourceid="SqlSemovientes" ClientDataKeyNames="IdSemoviente" 
                                    DataKeyNames="IdSemoviente" NoDetailRecordsText="No existen registros." 
                                    NoMasterRecordsText="No existen registros.">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Activo Biológico" 
        exporttoexceltext="Exportar a Excel" showexporttoexcelbutton="True" 
        showexporttopdfbutton="True" showrefreshbutton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Editar" 
            FilterControlAltText="Filter column column" ImageUrl="~\img\Edit.gif" 
            Text="Editar" UniqueName="column">
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro que desea Eliminar el Bien?" 
            ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
            Text="Eliminar" UniqueName="Eliminar">
            <HeaderStyle Width="1.5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="Proyecto" 
            FilterControlAltText="Filter Proyecto column" HeaderText="Proyecto" 
            ReadOnly="True" SortExpression="Proyecto" UniqueName="Proyecto" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="5%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="UBICACION" 
            FilterControlAltText="Filter UBICACION column" HeaderText="Ubicación" 
            ReadOnly="True" SortExpression="Ubicacion" UniqueName="UBICACION" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="5%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="AreteMicrochip" 
            FilterControlAltText="Filter AreteMicrochip column" HeaderText="Microchip" 
            SortExpression="AreteMicrochip" UniqueName="AreteMicrochip" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="AreteEstablo" 
            FilterControlAltText="Filter AreteEstablo column" HeaderText="Arete" 
            SortExpression="AreteEstablo" UniqueName="AreteEstablo" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
            SortExpression="Nombre" UniqueName="Nombre" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="20%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="raza" 
            FilterControlAltText="Filter raza column" HeaderText="Raza" 
            SortExpression="raza" UniqueName="raza" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="22%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Sexo" 
            FilterControlAltText="Filter Sexo column" HeaderText="Sexo" 
            SortExpression="Sexo" UniqueName="Sexo" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="5%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Color" 
            FilterControlAltText="Filter Color column" HeaderText="Color" 
            SortExpression="Color" UniqueName="Color" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="20%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdSemoviente" DataType="System.Int32" 
            FilterControlAltText="Filter IdSemoviente column" HeaderText="IdSemoviente" 
            ReadOnly="True" SortExpression="IdSemoviente" UniqueName="IdSemoviente" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdProyecto" DataType="System.Int32" 
            FilterControlAltText="Filter IdProyecto column" HeaderText="IdProyecto" 
            SortExpression="IdProyecto" UniqueName="IdProyecto" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdRaza" DataType="System.Int32" 
            FilterControlAltText="Filter IdRaza column" HeaderText="IdRaza" 
            SortExpression="IdRaza" UniqueName="IdRaza" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdProyectoCPD" DataType="System.Int32" 
            FilterControlAltText="Filter IdProyectoCPD column" HeaderText="IdProyectoCPD" 
            SortExpression="IdProyectoCPD" UniqueName="IdProyectoCPD" Visible="False">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                            </telerik:RadGrid>
            </td>
        </tr>
    </table>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"  
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Formulario" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" OnClientClose="Validar" >
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
                                            
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <asp:SqlDataSource ID="SqlSemovientes" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetSEMOVIENTESDetallado" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                <ClientEvents OnRequestStart="onRequestStart" />
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
    </telerik:RadAjaxManager>
     <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }
     </script>
    </telerik:RadCodeBlock>
                            </asp:Content>


