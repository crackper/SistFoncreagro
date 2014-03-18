<%@ Page Title="Lista de Bienes Inmuebles" Language="vb" AutoEventWireup="false" MasterPageFile="~/Patrimonio/MasterPagePatrimonio.master" CodeBehind="ListaInmuebles.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaInmuebles" %>
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
                            Lista de bienes inmuebles</td>
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
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlInmuebles" 
                                GridLines="None" Skin="Hay" AllowFilteringByColumn="True" PageSize="30">
                                <GroupingSettings CaseSensitive="False" />
                                <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
<MasterTableView commanditemdisplay="Top" datasourceid="SqlInmuebles" ClientDataKeyNames="IdBienInmueble" 
                                    DataKeyNames="IdBienInmueble" NoDetailRecordsText="No existen registros." 
                                    NoMasterRecordsText="No existen registros.">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Inmueble" 
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
            FilterControlAltText="Filter Editar column" ImageUrl="~\img\edit.gif" 
            Text="Editar" UniqueName="Editar">
            <HeaderStyle Width="1.5%" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro que desea Eliminar el Bien?" 
            ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
            Text="Eliminar" UniqueName="Anular">
            <HeaderStyle Width="1.5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Inmueble" 
            SortExpression="Nombre" UniqueName="Nombre" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100%">
            <HeaderStyle HorizontalAlign="Center" Width="32%" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
<telerik:GridBoundColumn DataField="Tipo" CurrentFilterFunction="Contains" 
            ShowFilterIcon="False" AutoPostBackOnFilter="True" HeaderText="Tipo" 
            UniqueName="Tipo" FilterControlWidth="100%" 
            FilterControlAltText="Filter Tipo column">
<HeaderStyle HorizontalAlign="Center" Width="20%"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt"></ItemStyle>
</telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="Proyecto" 
            FilterControlAltText="Filter Proyecto column" FilterControlWidth="100%" 
            HeaderText="Proyecto" ShowFilterIcon="False" UniqueName="Proyecto">
            <HeaderStyle HorizontalAlign="Center" Width="10%"></HeaderStyle>

        <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt"></ItemStyle>
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaCompra" 
            FilterControlAltText="Filter FechaCompra column" HeaderText="Fec. Compra" 
            SortExpression="FechaCompra" UniqueName="FechaCompra" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100%" DataFormatString="{0:dd/MM/yyyy}">
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle Font-Names="arial" Font-Size="8pt" HorizontalAlign="Center" />
           
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn CurrentFilterFunction="Contains" 
            DataField="ValorCompra" DataFormatString="{0:N2}" 
            FilterControlAltText="Filter ValorCompra column" FilterControlWidth="100%" 
            HeaderText="Valor" ShowFilterIcon="False" UniqueName="ValorCompra">
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle Font-Names="arial" Font-Size="8pt" HorizontalAlign="Right" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn CurrentFilterFunction="Contains" DataField="Moneda" 
            FilterControlAltText="Filter Moneda column" FilterControlWidth="100%" 
            HeaderText="M." ShowFilterIcon="False" UniqueName="Moneda">
            <HeaderStyle HorizontalAlign="Center" Width="5%" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Right" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Estado" 
            FilterControlAltText="Filter Estado column" HeaderText="Estado" 
            SortExpression="Estado" UniqueName="Estado" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100%">
           
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle Font-Names="arial" Font-Size="8pt" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdBienInmueble" DataType="System.Int32" 
            FilterControlAltText="Filter IdBienInmueble column" HeaderText="IdBienInmueble" 
            SortExpression="IdBienInmueble" UniqueName="IdBienInmueble" Visible="False" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" />
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
  

                                                <asp:SqlDataSource ID="SqlInmuebles" 
        runat="server" ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetBIENINMUEBLEDetallado" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
  

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

