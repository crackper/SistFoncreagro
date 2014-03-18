<%@ Page Title="Registro y Facturación de Ventas" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaVentas.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaVentas" %>

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
                            lista de ventas</td>
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
<MasterTableView CommandItemDisplay="Top" 
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
       
        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
            FilterControlAltText="Filter EditCommandColumn column"  
            UniqueName="editar" Reorderable="False" >
            <HeaderStyle Width="2%" />
        </telerik:GridEditCommandColumn>
       
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
            ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro de Anular/Eliminar el Registro?" 
            ConfirmTitle="¡Alerta!" 
            ImageUrl="~\img\Anular.gif" Text="Anular/Eliminar" UniqueName="Anular" 
            Reorderable="False">
            <HeaderStyle Width="2%" />
        </telerik:GridButtonColumn>
       
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
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                    HeaderText="Estado" UniqueName="TemplateColumn" 
            SortExpression="Estado">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server"  ForeColor='<%# Color(Eval("Estado")) %>'
                            Text='<%# DescEstado(Eval("Estado")) %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridTemplateColumn>
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
  
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"  
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Formulario" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" OnClientClose="onClientClose" OnClientBeforeClose="ActualizarGrilla" >
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
                                            
             

                                            
                             <asp:SqlDataSource ID="SqlVenta" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="GetVENTAByAnio1" 
        SelectCommandType="StoredProcedure">
                                 <SelectParameters>
                                     <asp:SessionParameter Name="anio" SessionField="Anio" Type="Int32" />
                                     <asp:SessionParameter Name="mes" SessionField="Mes" Type="Int32" />
                                 </SelectParameters>
    </asp:SqlDataSource>
                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" OnAjaxRequest="RadAjaxManager1_AjaxRequest">
                                    <ajaxsettings>
                                <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                    <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="RadAjaxManager1" />
                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                    </UpdatedControls>
                                </telerik:AjaxSetting>       
                                    </ajaxsettings>
                                </telerik:RadAjaxManager>

                                            
                                    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
                                        Height="16px" Skin="Default">
                              </telerik:RadAjaxLoadingPanel>
  

                             <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">

        <script type="text/javascript">

            function Alerta(Texto) {
                radalert(Texto, 300, 50, "Alerta");
            }
           
            function ActualizarGrilla() {
                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("1");
            }
            function onClientClose(oWnd, args) {
                // get the transferred arguments
                var arg = args.get_argument();
                if (arg == '' || arg == null) {
                    // No need to refresh RadGrid
                }
                else {
                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(arg);
                }
              }

        </script>
    </telerik:RadCodeBlock>
                            </asp:Content>
