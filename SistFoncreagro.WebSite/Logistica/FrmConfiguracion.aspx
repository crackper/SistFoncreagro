<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmConfiguracion.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmConfiguracion" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type ="text/javascript">
            function pregunta(id, pregunta) {
                idOC = id;
                preg = pregunta;

                if (preg = '1') {
                    var p = 'Desea <b>habilitar</b> la utilización de multiples centrros de costo.'
                }
                else {
                    var p = 'Desea <b>deshabilitar</b> la utilización de multiples centrros de costo.'
                }

                var res = radconfirm(p, confirma_accion1, 350, 100, null, 'Advertencia');
            }
            function confirma_accion1(arg) {
                if (arg == true) {
                    //radconfirm("Para <b>Anular</b> tambien el Requerimiento de compra asociado a esta Orden de Compra, haga clic en <b>OK</b> en caso contrario haga clic en <b>Cancelar</b>.<br><br>Si <b>NO</b> Anula el req. de compra este volverá a su estado anterior(Aprobado).", confirma_accion2,500,100,null,'Advertencia');
                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("HabilitarDeshabilitar|" + idOC);
                }
            } 
        </script>
</telerik:RadCodeBlock>
    <fieldset class="jcv">
        <legend class="legendJcv">HABILITAR CENTRO COSTO</legend>
        <asp:Panel ID="PanelHabilitar" runat="server">
            <table style="width: 100%">
                <tr>
                    <td align="right">
                        <asp:Label ID="lblMensaje" runat="server" Visible="False" Font-Size="8pt" 
                            ForeColor="Red" Text="Se asignó más de un centro de costo a un item del requerimiento, por favor eliminar centro de costo."></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <telerik:RadGrid ID="RadGrid1" runat="server" 
                AllowSorting="True" AutoGenerateColumns="False" CellSpacing="0" 
                DataSourceID="odsRequerimientos" GridLines="None" Skin="Hay" Width="897px" 
                            Font-Size="5pt">
                <ClientSettings>
                    <Selecting AllowRowSelect="True" />
                </ClientSettings>
                <MasterTableView DataSourceID="odsRequerimientos" DataKeyNames="IdRequerimiento, ActivarCentroCosto">
                    <CommandItemSettings ExportToPdfText="Export to PDF" />
                    <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                        <HeaderStyle Width="20px" />
                    </RowIndicatorColumn>
                    <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                        <HeaderStyle Width="20px" />
                    </ExpandCollapseColumn>
                    <Columns>
                        <telerik:GridBoundColumn DataField="NombreRequiere" 
                            FilterControlAltText="Filter column column" HeaderText="Requerido Por" 
                            UniqueName="column">
                            <ItemStyle Width="230px" />
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="FechaRequerimiento" 
                            DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime" 
                            FilterControlAltText="Filter FechaRequerimiento column" HeaderText="Fecha Req." 
                            SortExpression="FechaRequerimiento" UniqueName="FechaRequerimiento">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" Width="60px" />
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Numero" 
                            FilterControlAltText="Filter Numero column" HeaderText="Número" 
                            SortExpression="Numero" UniqueName="Numero">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" Width="60px" />
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Tipo" 
                            FilterControlAltText="Filter Tipo column" HeaderText="Tipo" 
                            SortExpression="Tipo" UniqueName="Tipo">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" Width="50px" Font-Size="8pt" />
                        </telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn AutoPostBackOnFilter="True" 
                            CurrentFilterFunction="Contains" DataField="Estado" FilterControlWidth="60%" 
                            HeaderText="Estado Req." SortExpression="Estado" 
                            UniqueName="EstadoTemplate">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Font-Bold="True" 
                                    ForeColor='<%# ObtenerColor(Eval("Estado")) %>' Text='<%# Eval("Estado") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" Width="115px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridBoundColumn DataField="AbreviacionMoneda" 
                            FilterControlAltText="Filter column1 column" HeaderText="Moneda" 
                            UniqueName="column1">
                            <HeaderStyle HorizontalAlign="Center" Width="40px" />
                            <ItemStyle HorizontalAlign="Center" Width="40px" />
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Monto" DataFormatString="{0:n}" 
                            DataType="System.Decimal" FilterControlAltText="Filter Monto column" 
                            HeaderText="Monto" SortExpression="Monto" UniqueName="Monto">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Right" />
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="IdRequerimiento" DataType="System.Int32" 
                            FilterControlAltText="Filter IdRequerimiento column" 
                            HeaderText="IdRequerimiento" SortExpression="IdRequerimiento" 
                            UniqueName="IdRequerimiento" Visible="False">
                        </telerik:GridBoundColumn>
                        <telerik:GridButtonColumn CommandName="Habilitar" 
                            ConfirmDialogType="RadWindow" 
                            ConfirmText="¿Desea habilitar la utilización de multiples centros de costo?" 
                            ConfirmTitle="Habilitar" DataTextField="Habilitar" DataTextFormatString="Habilitar" 
                            FilterControlAltText="Filter column2 column" SortExpression="Habilitar" 
                            UniqueName="column2">
                            <ItemStyle Width="45px" HorizontalAlign="Center" />
                        </telerik:GridButtonColumn>
                        <telerik:GridButtonColumn CommandName="Deshabilitar" 
                            ConfirmDialogType="RadWindow" 
                            ConfirmText="¿Desea deshabilitar la utilización de multiples centros de costo?" 
                            ConfirmTitle="Habilitar" DataTextField="Deshabilitar" DataTextFormatString="Deshabilitar" 
                            FilterControlAltText="Filter column3 column" SortExpression="Habilitar" 
                            UniqueName="column2">
                            <ItemStyle Width="55px" HorizontalAlign="Center" />
                        </telerik:GridButtonColumn>
                        <telerik:GridTemplateColumn UniqueName="TemplateColumn" AllowFiltering="False" 
                            HeaderText="ChecBox" Visible="False">
                        <ItemTemplate>
                            <asp:CheckBox ID="cbEstado" runat="server" 
                                Checked='<%# Bind("ActivarCentroCosto") %>' />
                        </ItemTemplate>
                             <HeaderStyle Width="30px" />
                             <ItemStyle HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridBoundColumn DataField="HabilitarCentroCosto" 
                            FilterControlAltText="Filter column3 column" HeaderText="C. Costo" 
                            UniqueName="column3">
                            <ItemStyle Width="60px" />
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
                    </td>
                </tr>
            </table>
            
            <br />
            
            
            
            <br />
     <asp:ObjectDataSource ID="odsRequerimientos" runat="server" 
                                SelectMethod="GetAllFromRequerimientoHabilitar" 
                                TypeName="SistFoncreagro.BussinesLogic.RequerimientoBL">
                            </asp:ObjectDataSource>
       
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="RadGrid1">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                        <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                            LoadingPanelID="RadAjaxLoadingPanel1" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
        </asp:Panel>
    </fieldset>
</asp:Content>
