<%@ Page Title="Validar Bienes Muebles" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaValidarMuebles.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaValidarMuebles" %>
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
                            Lista de bienes muebles</td>
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
                            <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" EnableLinqExpressions="False"
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlBienes" 
                                GridLines="None" Skin="Hay" AllowFilteringByColumn="True" PageSize="30">
                                <GroupingSettings CaseSensitive="False" />
                                <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
<MasterTableView commanditemdisplay="Top" datasourceid="SqlBienes" ClientDataKeyNames="IdBienMueble" 
                                    DataKeyNames="IdBienMueble" NoDetailRecordsText="No existen registros." 
                                    NoMasterRecordsText="No existen registros." >
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Bien" 
        exporttoexceltext="Exportar a Excel" showexporttoexcelbutton="True" 
        showexporttopdfbutton="True" showrefreshbutton="False" 
        ShowAddNewRecordButton="False"></CommandItemSettings>

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
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="StartsWith" ShowFilterIcon="False" 
            FilterControlWidth="100%">
            <HeaderStyle HorizontalAlign="Center" Width="7%" />
            <ItemStyle HorizontalAlign="Center" Font-Names="arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="PlanCuenta" 
            FilterControlAltText="Filter column column" FilterControlWidth="100%" 
            HeaderText="Cuenta" ShowFilterIcon="False" UniqueName="column">
            <HeaderStyle Width="5%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="PlanDepreciacion" 
            FilterControlAltText="Filter column1 column" FilterControlWidth="100%" 
            HeaderText="Cta. Dep." ShowFilterIcon="False" UniqueName="column1">
            <HeaderStyle Width="5%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="PlanGasto" 
            FilterControlAltText="Filter column2 column" FilterControlWidth="100%" 
            HeaderText="Cta. Gasto" ShowFilterIcon="False" UniqueName="column2">
            <HeaderStyle Width="5%" />
            <ItemStyle Font-Names="arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Bien" 
            FilterControlAltText="Filter Bien column" HeaderText="Bien" 
            SortExpression="Bien" UniqueName="Bien" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100%">
            <HeaderStyle HorizontalAlign="Center" Width="20%" />
            <ItemStyle Font-Names="arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Descripción" 
            SortExpression="Descripcion" UniqueName="Descripcion" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100%">
            <HeaderStyle HorizontalAlign="Center" Width="28.5%" />
            <ItemStyle Font-Names="arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="Costo" DataFormatString="{0:N2}" 
            FilterControlAltText="Filter column3 column" FilterControlWidth="100%" 
            HeaderText="Costo" ShowFilterIcon="False" UniqueName="column3">
            <HeaderStyle Width="5%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="Proyecto" 
            FilterControlAltText="Filter Proyecto column" FilterControlWidth="100%" 
            HeaderText="Proyecto" ShowFilterIcon="False" UniqueName="Proyecto">
            <HeaderStyle HorizontalAlign="Center" Width="6%" />
            <ItemStyle HorizontalAlign="Center" Font-Names="arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" FilterControlWidth="100%" 
            HeaderText="Tipo" ShowFilterIcon="False" UniqueName="Tipo">
            <HeaderStyle HorizontalAlign="Center" Width="8%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Estado"  
            HeaderText="Estado" 
           UniqueName="Estado" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
               FilterControlWidth="100%">
            <HeaderStyle HorizontalAlign="Center" Width="9%" />
            <ItemStyle HorizontalAlign="Center" Font-Names="arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdBienMueble" DataType="System.Int32" 
            FilterControlAltText="Filter IdBienMueble column" HeaderText="IdBienMueble" 
            SortExpression="IdBienMueble" UniqueName="IdBienMueble" Visible="False" 
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
  

                                                <asp:SqlDataSource ID="SqlBienes" 
        runat="server" ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetAllFromBIENMUEBLEActivos" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
  


                                            
                                                <asp:HiddenField ID="HiddenField1" 
        runat="server" />
  


                                            
                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                <ClientEvents OnRequestStart="onRequestStart" />
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                                <telerik:AjaxUpdatedControl ControlID="HiddenField1" />
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
