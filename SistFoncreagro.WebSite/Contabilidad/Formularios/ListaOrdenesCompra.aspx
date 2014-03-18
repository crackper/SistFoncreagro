<%@ Page Title="Ordenes de Compra Pendientes" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaOrdenesCompra.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaOrdenesCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td >
                            ORDENES PENDIENTES</td>
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
                <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="sqlOrdenes" GridLines="None" Skin="Hay">
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
<Selecting AllowRowSelect="True"></Selecting>
                    </ClientSettings>
<MasterTableView DataSourceID="sqlOrdenes" ClientDataKeyNames="IdOcxFactura" 
                        DataKeyNames="IdOcxFactura" 
                        NoMasterRecordsText="No existen órdenes pendientes.">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

   <Columns>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Generar" 
                                ConfirmDialogType="RadWindow" 
                                ConfirmText="Se generará un Registro de Cuentas por Pagar, ¿Desea Continuar?" 
                                ConfirmTitle="Mensaje de Confirmación" 
                                FilterControlAltText="Filter column column" ImageUrl="~\img\Proceso.gif" 
                                UniqueName="Generar" Text="Procesar">
                                <HeaderStyle Width="1%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                                UniqueName="TemplateColumn">
                                <ItemTemplate>
                                    <asp:ImageButton ID="Observar" runat="server" CssClass="cursor" 
                                        ImageUrl="~/img/Deshacer.gif" ToolTip="Devolver Orden" />
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridBoundColumn DataField="NumeroOrdenCompra" 
            FilterControlAltText="Filter NumeroOrdenCompra column" HeaderText="N° Orden" 
            SortExpression="NumeroOrdenCompra" UniqueName="NumeroOrdenCompra">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" HeaderText="Tipo" 
            SortExpression="Tipo" UniqueName="Tipo">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Ruc" 
            FilterControlAltText="Filter Ruc column" HeaderText="Ruc" 
            SortExpression="Ruc" UniqueName="Ruc">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="RazonSocial" 
            FilterControlAltText="Filter RazonSocial column" HeaderText="Razón Social" 
            UniqueName="RazonSocial" SortExpression="RazonSocial">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Fecha" 
            FilterControlAltText="Filter Fecha column" HeaderText="Fecha Doc." 
            SortExpression="Fecha" UniqueName="Fecha" 
                                DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Registro" 
                                FilterControlAltText="Filter Registro column" HeaderText="Registro" 
                                UniqueName="Registro">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Nombre" FilterControlAltText="Filter Nombre column" 
            HeaderText="Moneda" UniqueName="Nombre" DataType="System.Int32" SortExpression="Nombre">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Monto" DataFormatString="{0:0,0.00}" 
                                FilterControlAltText="Filter column1 column" HeaderText="Monto" 
                                UniqueName="Monto">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Right" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdOrdenCompra" 
            FilterControlAltText="Filter IdOrdenCompra column" HeaderText="IdOrdenCompra" 
            SortExpression="IdOrdenCompra" UniqueName="IdOrdenCompra" DataType="System.Int32" 
                                ReadOnly="True" Visible="False">
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
                <asp:SqlDataSource ID="sqlOrdenes" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
        
        SelectCommand="GetOrdenCompraPendientes" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>

        

        
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

        function openWin(idOCxFactura) {
            var oWnd = radopen("Dialog1.aspx?idOCxFactura=" + idOCxFactura, "RadWindow1");
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
