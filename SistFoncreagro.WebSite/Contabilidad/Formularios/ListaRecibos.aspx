<%@ Page Title="Lista de Recibos Provisionales de Fondo Fijo" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaRecibos.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaRecibos" %>
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
                            recibos provisionales de fondo fijo</td>
                        <td  >
                            </td>
                        <td style="text-align: center; width:30px"   >
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td width="40%">
                            <telerik:RadGrid ID="RadGrid1" runat="server" Skin="Hay" 
                                DataSourceID="odsRecibos" 
                                AutoGenerateColumns="False" CellSpacing="0" Culture="es-PE" 
                                GridLines="None" ShowFooter="True">
                                <GroupingSettings CaseSensitive="False" />
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
<MasterTableView CommandItemDisplay="Top" 
                                    DataSourceID="odsRecibos" NoDetailRecordsText="No existen registros." 
                                    NoMasterRecordsText="No existen registros." ClientDataKeyNames="IdRecibo" 
                                    DataKeyNames="IdRecibo">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Registro" RefreshText="Refrescar" 
        ShowRefreshButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
       
        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
            FilterControlAltText="Filter EditCommandColumn column"  UniqueName="editar" >
            <HeaderStyle Width="2%" />
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ConfirmDialogType="RadWindow" 
            ConfirmTitle="Mensaje de Confirmación" FilterControlAltText="Filter column column" 
            ImageUrl="~\img\delete.gif" Text="Eliminar" UniqueName="eliminar" 
            ConfirmText="¿Esta seguro que desea Eliminar el Recibo?">
            <HeaderStyle Width="2%" />
        </telerik:GridButtonColumn>
       
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
            ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro de Anular el Recibo?" 
            ConfirmTitle="¡Alerta!" 
            ImageUrl="~\img\Anular.gif" Text="Anular" UniqueName="Anular">
            <HeaderStyle Width="2%" />
        </telerik:GridButtonColumn>
       
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100%" AndCurrentFilterFunction="Contains" 
            FooterText="Total:">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Width="5%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="Monto" DataType="System.Decimal" 
            FilterControlAltText="Filter Monto column" HeaderText="Monto" 
            SortExpression="Monto" UniqueName="Monto" DataFormatString="{0:0,0.00}" 
            FilterControlWidth="80%" Aggregate="Sum" 
            FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Width="8%" />
            <ItemStyle HorizontalAlign="Right" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Fecha" DataType="System.DateTime" 
            FilterControlAltText="Filter Fecha column" HeaderText="Fecha" 
            SortExpression="Fecha" UniqueName="Fecha" 
            DataFormatString="{0:dd/MM/yyyy}" FilterControlWidth="80%">
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>


        <telerik:GridBoundColumn DataField="EntregadoA" 
            FilterControlAltText="Filter EntregadoA column" HeaderText="Entregado a" 
            SortExpression="EntregadoA" UniqueName="EntregadoA" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100%" AndCurrentFilterFunction="Contains">
            <HeaderStyle HorizontalAlign="Center" Width="21%" />
            <ItemStyle HorizontalAlign="Left" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Glosa" 
            FilterControlAltText="Filter Glosa column" HeaderText="Glosa" 
            SortExpression="Glosa" UniqueName="Glosa" AutoPostBackOnFilter="True" 
            ShowFilterIcon="False" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" AndCurrentFilterFunction="Contains">
            <HeaderStyle HorizontalAlign="Center" Width="20%" />
            <ItemStyle HorizontalAlign="Left" />
        </telerik:GridBoundColumn>


        <telerik:GridBoundColumn DataField="FechaVencimiento" 
            DataFormatString="{0:dd/MM/yyyy}" 
            FilterControlAltText="Filter FechaVencimiento column" HeaderText="Vence" 
            UniqueName="FechaVencimiento">
        </telerik:GridBoundColumn>


        <telerik:GridBoundColumn DataField="IdProyecto" 
            FilterControlAltText="Filter IdProyecto column" HeaderText="IdProyecto" 
            SortExpression="IdProyecto" UniqueName="IdProyecto" DataType="System.Int32" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdRecibo" 
            FilterControlAltText="Filter IdRecibo column" HeaderText="IdRecibo" 
            SortExpression="IdRecibo" UniqueName="IdRecibo" DataType="System.Int32" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Usuario" DataType="System.Int32" 
            FilterControlAltText="Filter Usuario column" HeaderText="Usuario" 
            SortExpression="Usuario" UniqueName="Usuario" Visible="False">
        </telerik:GridBoundColumn>
       
        <telerik:GridBoundColumn DataField="IdCCosto" 
            FilterControlAltText="Filter column column" UniqueName="column" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NomCCosto" 
            FilterControlAltText="Filter column1 column" HeaderText="C. Costo" 
            UniqueName="column1">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
       
        <telerik:GridBoundColumn DataField="NomEstado" 
            FilterControlAltText="Filter Estado column" HeaderText="Estado" 
            UniqueName="Estado">
        </telerik:GridBoundColumn>
       
    </Columns>

<EditFormSettings EditFormType="WebUserControl" 
        UserControlName="~\Contabilidad\Controles\ControlRecibo.ascx">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                            </telerik:RadGrid>
            </td>
        </tr>
    </table>
  
                            <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>
                            <asp:ObjectDataSource ID="odsRecibos" runat="server" 
                                SelectMethod="GetRECIBOPendientes" 
                                TypeName="SistFoncreagro.BussinesLogic.ReciboBL">
    </asp:ObjectDataSource>
                             <telerik:RadAjaxManager ID="RadAjaxManager1" 
        runat="server">
                                 <AjaxSettings>
                                     <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                         <UpdatedControls>
                                             <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                 LoadingPanelID="RadAjaxLoadingPanel1" />
                                         </UpdatedControls>
                                     </telerik:AjaxSetting>
                                 </AjaxSettings>
    </telerik:RadAjaxManager>
                                            
                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                             <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">

        <script type="text/javascript">

            function Alerta(Texto) {
                radalert(Texto, 300, 50, "Alerta");
            }
           
        </script>
    </telerik:RadCodeBlock>
                            </asp:Content>
