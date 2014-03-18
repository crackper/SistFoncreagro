<%@ Page Title="Caja y Bancos" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaCaja.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaCajaIngresos"  %>
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
                <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="odsSubDiarios" GridLines="None" Skin="Hay" 
                    ShowStatusBar="True">
<MasterTableView ClientDataKeyNames="IdSubDiario" CommandItemDisplay="Top" 
                        DataKeyNames="IdSubDiario" DataSourceID="odsSubDiarios" 
                        NoDetailRecordsText="No existen registros." 
                        NoMasterRecordsText="No existen registros.">
    <DetailTables>
        <telerik:GridTableView runat="server" ClientDataKeyNames="IdTransaccion" 
            DataKeyNames="IdTransaccion" DataSourceID="odsTransaccion" 
            Name="Transacciones" Width="100%" 
            NoDetailRecordsText="No existen registros." 
            NoMasterRecordsText="No existen registros.">
            <DetailTables>
                <telerik:GridTableView runat="server" ClientDataKeyNames="IdLinea" 
                    DataKeyNames="IdLinea" DataSourceID="odsLineas" Name="Lineas" Width="100%" 
                    NoDetailRecordsText="No existen registros." 
                    NoMasterRecordsText="No existen registros.">
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
                         <telerik:GridBoundColumn DataField="PlanContable.Codigo" FilterControlAltText="Filter column column" HeaderText="Cuenta" UniqueName="column" AllowFiltering="False">
                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                            <ItemStyle HorizontalAlign="Center" />
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="Coa"                                 
                             FilterControlAltText="Filter column3 column" HeaderText="Coa" 
                                                                                            
                             UniqueName="column3" AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Registro" 
                                                                                            
                             FilterControlAltText="Filter Registro column" HeaderText="Registro" 
                             UniqueName="Registro">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="13%" />
                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="FechaDocumento" 
                                                                                            
                             FilterControlAltText="Filter FechaDocumento column" HeaderText="Fecha Doc." 
                             UniqueName="FechaDocumento" DataFormatString="{0:dd/MM/yyyy}">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
<telerik:GridBoundColumn DataField="IdMoneda" HeaderText="M." UniqueName="IdMoneda" 
                             FilterControlAltText="Filter IdMoneda column">
</telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="TipoCambio" 
                                                                                            
                             FilterControlAltText="Filter TipoCambio column" HeaderText="T. C." 
                             UniqueName="TipoCambio" DataFormatString="{0:0.0000}">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="CargoMN" DataType="System.Decimal" 
                                                                                            
                             FilterControlAltText="Filter Cargo column" HeaderText="Debe MN" 
                                                                                            
                             SortExpression="Cargo" UniqueName="CargoMN" DataFormatString="{0:0,0.00}" 
                                                                                            
                             AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="AbonoMN" DataType="System.Decimal" 
                                                                                            
                             FilterControlAltText="Filter Abono column" HeaderText="Haber MN" 
                                                                                            
                             SortExpression="Abono" UniqueName="AbonoMN" DataFormatString="{0:0,0.00}" 
                                                                                            
                             AllowFiltering="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="CargoME" 
                             FilterControlAltText="Filter CargoME column" HeaderText="Debe ME" 
                             UniqueName="CargoME">
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="AbonoME" 
                             FilterControlAltText="Filter AbonoME column" HeaderText="Haber ME" 
                             UniqueName="AbonoME">
                         </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn AllowFiltering="False" DataField="Glosa" 
                             FilterControlAltText="Filter Glosa column" HeaderText="Glosa" 
                             SortExpression="Glosa" UniqueName="Glosa">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="35%" />
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
                         <telerik:GridBoundColumn DataField="MontoCargo" 
                             FilterControlAltText="Filter Cargo column" UniqueName="Cargo" Visible="False">
                         </telerik:GridBoundColumn>
                         <telerik:GridBoundColumn DataField="MontoAbono" 
                             FilterControlAltText="Filter Abono column" UniqueName="Abono" Visible="False">
                         </telerik:GridBoundColumn>
                    </Columns>
                    <EditFormSettings>
                        <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                        </EditColumn>
                    </EditFormSettings>
                </telerik:GridTableView>
            </DetailTables>
            <ParentTableRelation>
                <telerik:GridRelationFields DetailKeyField="IdSubDiario" 
                    MasterKeyField="IdSubDiario" />
            </ParentTableRelation>
            <CommandItemSettings ExportToPdfText="Export to PDF" />
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                <HeaderStyle Width="20px" />
            </RowIndicatorColumn>
            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                Visible="True">
                <HeaderStyle Width="20px" />
            </ExpandCollapseColumn>
            <Columns>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Editar" 
                    FilterControlAltText="Filter editar column" ImageUrl="~\img\edit.gif" 
                    UniqueName="editar">
                </telerik:GridButtonColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                    ConfirmDialogType="RadWindow" 
                    ConfirmText="¿Está seguro que desea Eliminar el Registro?" ConfirmTitle="Mensaje de Confirmación" 
                    FilterControlAltText="Filter column1 column" ImageUrl="~\img\delete.gif" 
                    Text="Eliminar" UniqueName="eliminar">
                    <HeaderStyle Width="5%" />
                </telerik:GridButtonColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
                    ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro que desea Anular el Registro?" 
                    ConfirmTitle="Mensaje de Confirmación" FilterControlAltText="Filter anular column" 
                    ImageUrl="~\img\Anular.gif" Text="Anular" UniqueName="anular">
                </telerik:GridButtonColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Ver" 
                    FilterControlAltText="Filter ver column" ImageUrl="~\img\Rendir.gif" Text="Ver" 
                    UniqueName="ver">
                </telerik:GridButtonColumn>
                <telerik:GridBoundColumn DataField="Codigo" 
                    FilterControlAltText="Filter Codigo column" HeaderText="N° Comprobante" 
                    UniqueName="Codigo">
                    <HeaderStyle HorizontalAlign="Center" Width="15%" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="NombreProveedor" 
                    FilterControlAltText="Filter column1 column" HeaderText="Coa" 
                    UniqueName="column1">
                    <HeaderStyle HorizontalAlign="Center" Width="38%" />
                    <ItemStyle HorizontalAlign="Left" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="FechaContable" 
                    DataFormatString="{0:dd/MM/yyyy}" 
                    FilterControlAltText="Filter FechaContable column" HeaderText="Fecha Contable" 
                    UniqueName="FechaContable">
                    <HeaderStyle HorizontalAlign="Center" Width="15%" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IdMoneda" 
                    FilterControlAltText="Filter IdMoneda column" HeaderText="Moneda" 
                    UniqueName="IdMoneda">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Total" DataFormatString="{0:N2}" 
                    FilterControlAltText="Filter column column" HeaderText="Total" 
                    UniqueName="column">
                    <HeaderStyle HorizontalAlign="Center" Width="15%" />
                    <ItemStyle HorizontalAlign="Right" />
                </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
                    HeaderText="Proyecto" UniqueName="TemplateColumn1">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" 
                            Text='<%# Proyecto(Eval("IdProyecto")) %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                    HeaderText="Estado" UniqueName="TemplateColumn">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server"  ForeColor='<%# Color(Eval("Estado")) %>'
                            Text='<%# DescEstado(Eval("Estado")) %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle Width="7%" />
                </telerik:GridTemplateColumn>
                <telerik:GridBoundColumn DataField="IdTransaccion" 
                    FilterControlAltText="Filter IdTransaccion column" HeaderText="IdTransaccion" 
                    UniqueName="IdTransaccion" Visible="False">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="idProyecto" 
                    FilterControlAltText="Filter column2 column" UniqueName="column2" 
                    Visible="False">
                </telerik:GridBoundColumn>
            </Columns>
            <EditFormSettings>
                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                </EditColumn>
            </EditFormSettings>
        </telerik:GridTableView>
    </DetailTables>
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Registro" RefreshText="Refrescar"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
        Visible="True">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="IdSubDiario" 
            FilterControlAltText="Filter IdSubDiario column" HeaderText="Id" 
            SortExpression="IdSubDiario" UniqueName="IdSubDiario">
            <HeaderStyle Width="5%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Sub Diario" 
            SortExpression="Descripcion" UniqueName="Descripcion">
            <HeaderStyle Width="95%" />
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
  
    <asp:ObjectDataSource ID="odsLineas" runat="server" 
        SelectMethod="GetLINEAByIdTransaccion" 
        TypeName="SistFoncreagro.BussinesLogic.LineaBL">
        <SelectParameters>
            <asp:ControlParameter ControlID="RadGrid1" Name="IdTransaccion" 
                                        PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsSubDiarios" runat="server" 
        SelectMethod="GetSUBDIARIOInTransaccionByFlag" 
        TypeName="SistFoncreagro.BussinesLogic.SubdiarioBL">
        <SelectParameters>
            <asp:SessionParameter Name="Anio" SessionField="Anio" Type="Int32" />
            <asp:SessionParameter Name="Mes" SessionField="Mes" Type="Int32" />
            <asp:QueryStringParameter Name="Flag" QueryStringField="Flag" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsTransaccion" runat="server" 
        SelectMethod="GetTRANSACCIONByAnioMesIdSubdiarioFlag" 
        TypeName="SistFoncreagro.BussinesLogic.TransaccionBL">
        <SelectParameters>
            <asp:SessionParameter Name="anio" SessionField="Anio" Type="Int32" />
            <asp:SessionParameter Name="mes" SessionField="Mes" Type="Int32" />
            <asp:ControlParameter ControlID="RadGrid1" Name="idSubDiario" 
                PropertyName="SelectedValue" Type="Int32" />
            <asp:QueryStringParameter Name="Flag" QueryStringField="Flag" Type="String" />
        </SelectParameters>
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
                                    <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                LoadingPanelID="RadAjaxLoadingPanel1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>
    </telerik:RadAjaxManager>
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
                                            
             
              <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">

        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }
     </script>
    </telerik:RadCodeBlock>
                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                </asp:Content>
