<%@ Page Title="Lista de Transacciones" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaTransacciones.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaOperaciones" %>
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
                            <asp:Label ID="Label1" runat="server" ForeColor="White"></asp:Label>
                        </td>
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
                            <telerik:RadGrid ID="RadGrid1" runat="server" AllowFilteringByColumn="True" 
                                AutoGenerateColumns="False" CellSpacing="0" 
                                DataSourceID="odsProveedorCliente" GridLines="None" Width="100%" 
                                CssClass="grid" Culture="es-PE" OnItemCommand="RadGrid1_ItemCommand" 
                                Skin="Hay">
                                <GroupingSettings CaseSensitive="False" />
                                <ExportSettings ExportOnlyData="True" OpenInNewWindow="True">
                                </ExportSettings>
<MasterTableView DataKeyNames="IdProveedorCliente" DataSourceID="odsProveedorCliente" ClientDataKeyNames="IdProveedorCliente" 
                                    CommandItemDisplay="Top" NoMasterRecordsText="No existen registros." 
                                    Name="Proveedor" NoDetailRecordsText="No existen registros.">
    <DetailTables>
        <telerik:GridTableView runat="server" ClientDataKeyNames="IdTransaccion" 
            DataKeyNames="IdTransaccion" DataSourceID="odsTransaccion" 
            Name="Transacciones" AllowFilteringByColumn="False" Width="100%" 
            NoDetailRecordsText="No existen registros." 
            NoMasterRecordsText="No existen registros.">
            <DetailTables>
                <telerik:GridTableView runat="server" ClientDataKeyNames="IdLinea" 
                    DataKeyNames="IdLinea" DataSourceID="DSLineas" Name="Lineas" 
                    AllowFilteringByColumn="False" NoDetailRecordsText="No existen registros." 
                    NoMasterRecordsText="No existen registros." >
                    <ParentTableRelation>
                        <telerik:GridRelationFields DetailKeyField="IdTransaccion" 
                            MasterKeyField="IdTransaccion" />
                    </ParentTableRelation>
                    <CommandItemSettings ExportToPdfText="Export to PDF" />
                    <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                        <HeaderStyle Width="20px" />
                    </RowIndicatorColumn>
                    <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                        <HeaderStyle Width="20px" />
                    </ExpandCollapseColumn>
                    <Columns>
                                                                                        <telerik:GridBoundColumn DataField="Cuenta" 
                                                                                            FilterControlAltText="Filter column column" HeaderText="Cuenta" 
                                                                                            UniqueName="column" AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Center" Width="15%" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="CCosto" 
                                                                                            FilterControlAltText="Filter column3 column" HeaderText="C.Costo" 
                                                                                            UniqueName="column3" AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Center" Width="15%" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="MontoCargo" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter Cargo column" HeaderText="Cargo" 
                                                                                            SortExpression="Cargo" UniqueName="Cargo" DataFormatString="{0:0,0.00}" 
                                                                                            AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Right" Width="15%" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="MontoAbono" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter Abono column" HeaderText="Abono" 
                                                                                            SortExpression="Abono" UniqueName="Abono" DataFormatString="{0:0,0.00}" 
                                                                                            AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Right" Width="15%" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="TipoCambio" DataFormatString="{0:0.0000}" 
                                                                                            FilterControlAltText="Filter TipoCambio column" HeaderText="T. C." 
                                                                                            UniqueName="TipoCambio">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Glosa" 
                                                                                            FilterControlAltText="Filter Glosa column" HeaderText="Glosa" 
                                                                                            SortExpression="Glosa" UniqueName="Glosa" AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle Width="30%" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdLinea" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter IdLinea column" HeaderText="IdLinea" 
                                                                                            ReadOnly="True" SortExpression="IdLinea" UniqueName="IdLinea" 
                                                                                            Visible="False" AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdTransaccion" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter Transaccion column" HeaderText="Transaccion" 
                                                                                            SortExpression="Transaccion" UniqueName="Transaccion" Visible="False" 
                                                                                            AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdPlan" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter Cta column" HeaderText="Cuenta" 
                                                                                            SortExpression="Cta" UniqueName="Cta" Visible="False" 
                                                                                            AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdCCosto" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter ElemGto column" HeaderText="C. Costo" 
                                                                                            SortExpression="ElemGto" UniqueName="ElemGto" Visible="False" 
                                                                                            AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                    </Columns>
                    <EditFormSettings>
                        <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                        </EditColumn>
                    </EditFormSettings>
                  
                </telerik:GridTableView>
            </DetailTables>
            <ParentTableRelation>
                <telerik:GridRelationFields DetailKeyField="IdProveedorCliente" 
                    MasterKeyField="IdProveedorCliente" />
            </ParentTableRelation>
            <CommandItemSettings ExportToPdfText="Export to PDF" />
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            </RowIndicatorColumn>
            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                Visible="True">
            </ExpandCollapseColumn>
            <Columns>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Editar" 
                    FilterControlAltText="Filter editar column" UniqueName="editar" 
                    ImageUrl="~\img\edit.gif">
                </telerik:GridButtonColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                    ConfirmDialogType="RadWindow" 
                    ConfirmText="¿Está seguro que desea Eliminar el Comprobante?" ConfirmTitle="Mensaje de Confirmación" 
                    FilterControlAltText="Filter column1 column" ImageUrl="~\img\delete.gif" 
                    Text="Eliminar" UniqueName="eliminar">
                </telerik:GridButtonColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
                    ConfirmDialogType="RadWindow" 
                    ConfirmText="¿Está seguro que desea Anular el Comprobante?" ConfirmTitle="Mensaje de Confirmación" 
                    FilterControlAltText="Filter anular column" ImageUrl="~\img\Anular.gif" 
                    Text="Anular" UniqueName="anular">
                </telerik:GridButtonColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Ver" 
                    FilterControlAltText="Filter ver column" ImageUrl="~\img\Rendir.gif" Text="Ver" 
                    UniqueName="ver">
                </telerik:GridButtonColumn>
                <telerik:GridBoundColumn DataField="Codigo" 
                    FilterControlAltText="Filter Codigo column" HeaderText="N° Comprobante" 
                    UniqueName="Codigo">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Registro" 
                    FilterControlAltText="Filter column2 column" HeaderText="Registro" 
                    UniqueName="column2">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="FechaDocumento" 
                    FilterControlAltText="Filter FechaDocumento column" HeaderText="Fec. Documento" 
                    UniqueName="FechaDocumento" DataFormatString="{0:dd/MM/yyyy}">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="FechaContable" 
                    DataFormatString="{0:dd/MM/yyyy}" 
                    FilterControlAltText="Filter FechaContable column" HeaderText="Fec. Contable" 
                    UniqueName="FechaContable">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IdMoneda" 
                    FilterControlAltText="Filter IdMoneda column" HeaderText="Moneda" 
                    UniqueName="IdMoneda">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Total" DataFormatString="{0:N2}" 
                    FilterControlAltText="Filter Total column" HeaderText="Total" 
                    UniqueName="Total">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Right" />
                </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
                    HeaderText="Proyecto" UniqueName="TemplateColumn1">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" 
                            Text='<%# Proyecto(Eval("IdProyecto")) %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                    HeaderText="Estado" UniqueName="TemplateColumn">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server"  ForeColor='<%# Color(Eval("Estado")) %>'
                            Text='<%# DescEstado(Eval("Estado")) %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridTemplateColumn>
                <telerik:GridBoundColumn DataField="Idtransaccion" 
                    FilterControlAltText="Filter Idtransaccion column" HeaderText="Idtransaccion" 
                    UniqueName="Idtransaccion" Visible="False">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="idProyecto" 
                    FilterControlAltText="Filter column column" UniqueName="column" Visible="False">
                </telerik:GridBoundColumn>
            </Columns>
            <EditFormSettings>
                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                </EditColumn>
            </EditFormSettings>
        </telerik:GridTableView>
    </DetailTables>
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Registro" ExportToCsvText="Exportar a CSV" 
        ExportToExcelText="Exportar a Excel" ExportToWordText="Exportar a Word" 
        RefreshText="Refrescar"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
        Visible="True">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="IdProveedorCliente" 
            FilterControlAltText="Filter IdProveedorCliente column" HeaderText="IdProveedorCliente" 
            SortExpression="IdProveedorCliente" UniqueName="IdProveedorCliente" 
            ReadOnly="True" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NombreProveedor" 
            AutoPostBackOnFilter="true" CurrentFilterFunction="Contains" 
            ShowFilterIcon="false" HeaderText="Proveedor/Cliente" 
            SortExpression="NombreProveedor" UniqueName="NombreProveedor" 
            FilterControlAltText="Filter NombreProveedor column" 
            FilterControlWidth="300px"  >
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
                            <asp:ObjectDataSource ID="odsProveedorCliente" runat="server" 
                                SelectMethod="GetProveedoresClienteInTransaccion" 
                                TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                <SelectParameters>
                                    <asp:SessionParameter Name="anio" SessionField="Anio" Type="Int32" />
                                    <asp:SessionParameter Name="mes" SessionField="Mes" Type="Int32" />
                                    <asp:QueryStringParameter Name="idSubDiario" QueryStringField="IdSubDiario" 
                                        Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
  
                            <asp:ObjectDataSource ID="odsTransaccion" runat="server" 
                                SelectMethod="GetTRANSACCIONByAnioMesIdSubdiarioIdProveedorCliente" 
                                TypeName="SistFoncreagro.BussinesLogic.TransaccionBL">
                                <SelectParameters>
                                    <asp:SessionParameter Name="anio" SessionField="Anio" Type="Int32" />
                                    <asp:SessionParameter Name="mes" SessionField="Mes" Type="Int32" />
                                    <asp:QueryStringParameter Name="idSubDiario" QueryStringField="IdSubDiario" 
                                        Type="Int32" />
                                    <asp:ControlParameter ControlID="RadGrid1" Name="idproveedorCliente" 
                                        PropertyName="SelectedValue" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <asp:SqlDataSource ID="DSLineas" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        
        SelectCommand="SELECT lINEA.MontoAbono, lINEA.MontoCargo, lINEA.IdPlan, lINEA.Glosa, lINEA.IdLinea, lINEA.IdTransaccion, lINEA.IdCCosto, lINEA.IdProveedorCliente, lINEA.IdTipoDocumento, lINEA.NroDocumento, lINEA.SerieDocumento, lINEA.FechaDocumento, lINEA.Flag, lINEA.TipoCambio, lINEA.Estado, lINEA.IdMoneda, lINEA.CargoMN, lINEA.CargoME, lINEA.AbonoMN, lINEA.AbonoME, lINEA.Enlace, PLANCONTABLE.Codigo AS Cuenta, CCOSTO.Codigo AS CCosto FROM LINEA AS lINEA INNER JOIN PLANCONTABLE ON lINEA.IdPlan = PLANCONTABLE.IdPlan left JOIN CCOSTO ON lINEA.IdCCosto = CCOSTO.IdCCosto WHERE (lINEA.IdTransaccion = @idTransaccion)">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="RadGrid1" Name="idTransaccion" 
                                        PropertyName="SelectedValue" />
                                </SelectParameters>
    </asp:SqlDataSource>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"  
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Formulario" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True"  OnClientBeforeClose="Validar">
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
                                            
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
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
