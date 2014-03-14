<%@ Page Title="Ventas Pendientes de Aprobar" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaVentasPendientes.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaVentasPendientes" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td >
                            ventas pendientes de aprobar</td>
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
                                DataSourceID="SqlVenta" 
                                AutoGenerateColumns="False" CellSpacing="0" Culture="es-PE" 
                                GridLines="None" ShowFooter="True" AllowSorting="True">
                                <GroupingSettings CaseSensitive="False" />
                                <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="Ordenado descendente" 
                                    SortToolTip="Click aqui para ordenar" />
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
<MasterTableView 
                                    DataSourceID="SqlVenta" NoDetailRecordsText="No existen registros." 
                                    NoMasterRecordsText="No existen registros." ClientDataKeyNames="IdVenta" 
                                    DataKeyNames="IdVenta">
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
         <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Generar" 
                                ConfirmDialogType="RadWindow" 
                                ConfirmText="Se generará un Registro de Ventas, ¿Desea Continuar?" 
                                ConfirmTitle="Mensaje de Confirmación" 
                                FilterControlAltText="Filter column column" ImageUrl="~\img\Proceso.gif" 
                                UniqueName="Generar" Text="Procesar">
                                <HeaderStyle Width="1%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                                UniqueName="TemplateColumn">
                                <ItemTemplate>
                                    <asp:ImageButton ID="Observar" runat="server" CssClass="cursor" 
                                        ImageUrl="~/img/Deshacer.gif" ToolTip="Devolver Venta" />
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
       
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Ver" 
            FilterControlAltText="Filter column column" ImageUrl="~\img\Rendir.gif" 
            Text="Ver Comprobante" UniqueName="column">
        </telerik:GridButtonColumn>
       
        <telerik:GridBoundColumn DataField="IdVenta" 
            FilterControlAltText="Filter IdVenta column" HeaderText="IdVenta" 
            UniqueName="IdVenta" Visible="False">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="Documento" 
            FilterControlAltText="Filter Documento column" HeaderText="Tipo Documento" 
            UniqueName="Documento" SortExpression="Documento">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaDocumento" 
            FilterControlAltText="Filter FechaDocumento column" 
            HeaderText="Fecha" UniqueName="FechaDocumento" 
            DataFormatString="{0:dd/MM/yyyy}" SortExpression="FechaDocumento">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>


        <telerik:GridBoundColumn DataField="NroSerie" 
            FilterControlAltText="Filter NroSerie column" HeaderText="N° Serie" 
            UniqueName="NroSerie" EmptyDataText="" SortExpression="NroSerie">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroDocumento" 
            FilterControlAltText="Filter NroDocumento column" 
            HeaderText="N° Documento" UniqueName="NroDocumento" 
            SortExpression="NroDocumento">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>


        <telerik:GridBoundColumn DataField="Proyecto" 
            FilterControlAltText="Filter Proyecto column" HeaderText="Proyecto" 
            UniqueName="Proyecto" SortExpression="Proyecto">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Left" />
        </telerik:GridBoundColumn>


        <telerik:GridBoundColumn DataField="Cliente" 
            FilterControlAltText="Filter Cliente column" HeaderText="Cliente" 
            UniqueName="Cliente" SortExpression="Cliente">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Left" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdTipoDocumento" 
            FilterControlAltText="Filter IdTipoDocumento column" 
            HeaderText="IdTipoDocumento" UniqueName="IdTipoDocumento" Visible="False">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings EditFormType="WebUserControl">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                            </telerik:RadGrid>

        

        
            </td>
        </tr>
    </table>
     <telerik:RadWindowManager ID="RadWindowManager1" runat="server" 
        AutoSize="True">
      <Windows>
            <telerik:RadWindow ID="RadWindow1" runat="server" 
                Behaviors="Close" OnClientClose="OnClientClose">
            </telerik:RadWindow>
            <telerik:RadWindow ID="Formulario" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move" 
                Behaviors="Resize, Close, Move" 
                ReloadOnShow="True"  OnClientBeforeClose="Validar">
            </telerik:RadWindow>
          
        </Windows>

                            </telerik:RadWindowManager>
                                            
             

                                            
                             <asp:SqlDataSource ID="SqlVenta" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="GetVENTASporAprobar" 
        SelectCommandType="StoredProcedure">
                                 <SelectParameters>
                                     <asp:SessionParameter Name="anio" SessionField="Anio" Type="Int32" />
                                     <asp:SessionParameter Name="mes" SessionField="Mes" Type="Int32" />
                                 </SelectParameters>
    </asp:SqlDataSource>

        

        
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  
            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                <AjaxSettings>
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
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }

        function openWin(IdVenta) {
            var oWnd = radopen("Dialog2.aspx?IdVenta=" + IdVenta, "RadWindow1");
        }

        function OnClientClose(oWnd, args) {
            //get the transferred arguments
            var arg = args.get_argument();
            if (arg) {
                var motivo = arg.cityName;
                var idOCxFactura = arg.idOC;

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Observar|" + motivo + "|" + idOCxFactura);
            }
        }

        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }  
     </script>
    </telerik:RadCodeBlock>
</asp:Content>

