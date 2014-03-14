<%@ Page Title="Cuentas Bancarias" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaCtaBancaria.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaCtaBancaria" %>
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
                        <td style="height: 22px">
                            cuentas bancarias</td>
                        <td style="height: 22px">
                        </td>
                        <td style="text-align: right; width:110px; height: 22px;">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsCuentaBancaria" 
                                GridLines="None" Skin="Hay" PageSize="15">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <MasterTableView commanditemdisplay="Top" datasourceid="odsCuentaBancaria" ClientDataKeyNames="IdCtaBancaria" 
                                    DataKeyNames="IdCtaBancaria" 
                        NoMasterRecordsText="No existen Cuentas." 
                        NoDetailRecordsText="No existen Proyectos asignados a esta Cuenta">
                        <DetailTables>
                            <telerik:GridTableView runat="server" 
                                ClientDataKeyNames="IdCtaBancaria,IdProyecto" CommandItemDisplay="Top" 
                                DataKeyNames="IdCtaBancaria,IdProyecto" DataSourceID="odsCtaProyecto" 
                                Name="CuentaProyecto" 
                                NoDetailRecordsText="No existen Proyectos asignados a esta Cuenta.">
                                <ParentTableRelation>
                                    <telerik:GridRelationFields DetailKeyField="IdCtaBancaria" 
                                        MasterKeyField="IdCtaBancaria" />
                                </ParentTableRelation>
                                <CommandItemSettings AddNewRecordText="Asignar Proyecto" 
                                    ExportToPdfText="Export to PDF" ShowRefreshButton="False" />
                                <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                    <HeaderStyle Width="20px" />
                                </RowIndicatorColumn>
                                <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                    <HeaderStyle Width="20px" />
                                </ExpandCollapseColumn>
                                <Columns>
                                    <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                        FilterControlAltText="Filter EditCommandColumn column">
                                        <HeaderStyle Width="2%" />
                                    </telerik:GridEditCommandColumn>
                                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                        ConfirmDialogType="RadWindow" 
                                        ConfirmText="¿Está seguro de Elimnar la relacion del Proyecto con la Cuenta?" 
                                        ConfirmTitle="Mensaje de Confirmación" 
                                        FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
                                        UniqueName="column" Text="Eliminar">
                                        <HeaderStyle Width="2%" />
                                    </telerik:GridButtonColumn>
                                    <telerik:GridBoundColumn DataField="IdCtaBancaria" 
                                        FilterControlAltText="Filter IdCtaBancaria column" HeaderText="IdCtaBancaria" 
                                        UniqueName="IdCtaBancaria" Visible="False">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="IdProyecto" 
                                        FilterControlAltText="Filter IdProyecto column" HeaderText="IdProyecto" 
                                        UniqueName="IdProyecto" Visible="False">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="NomProyecto" 
                                        FilterControlAltText="Filter NomProyecto column" HeaderText="Proyecto" 
                                        UniqueName="NomProyecto">
                                        <HeaderStyle HorizontalAlign="Center" Width="60%" />
                                        <ItemStyle HorizontalAlign="Left" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="Descripcion" 
                                        FilterControlAltText="Filter Descripcion column" HeaderText="Observaciones" 
                                        UniqueName="Descripcion">
                                        <HeaderStyle HorizontalAlign="Center" Width="36%" />
                                        <ItemStyle HorizontalAlign="Left" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="Saldo" 
                                        FilterControlAltText="Filter column1 column" HeaderText="Saldo" 
                                        UniqueName="column1">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </telerik:GridBoundColumn>
                                </Columns>
                                <EditFormSettings EditFormType="WebUserControl" 
                                    UserControlName="~\Contabilidad\Controles\ControlCuentaProyecto.ascx">
                                    <EditColumn FilterControlAltText="Filter EditCommandColumn1 column" 
                                        UniqueName="EditCommandColumn1">
                                    </EditColumn>
                                </EditFormSettings>
                            </telerik:GridTableView>
                        </DetailTables>
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Cuenta Bancaria" 
        exporttoexceltext="Exportar a Excel" showrefreshbutton="False" ShowExportToExcelButton="True" 
                            ShowExportToPdfButton="True">
                        </CommandItemSettings>
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                            Visible="True">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                FilterControlAltText="Filter EditCommandColumn column">
                                <HeaderStyle Width="2%" />
                            </telerik:GridEditCommandColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
                                ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro que desea Anular la Cuenta?" 
                                ConfirmTitle="Mensaje de Confirmación" 
                                FilterControlAltText="Filter Anular column" ImageUrl="~\img\delete.gif" 
                                Text="Eliminar" UniqueName="Anular">
                                <HeaderStyle Width="2%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Descripción" 
            SortExpression="Descripcion" UniqueName="Descripcion" FilterControlWidth="100%">
                                <HeaderStyle HorizontalAlign="Center" Width="23%" />
                                <ItemStyle HorizontalAlign="Left" Font-Names="Arial" Font-Size="8pt" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="NomBanco" 
            FilterControlAltText="Filter NomBanco column" HeaderText="Banco" 
            SortExpression="NomBanco" UniqueName="NomBanco" AllowFiltering="False" DataType="System.Int32">
                                <HeaderStyle HorizontalAlign="Center" Width="15%" />
                                <ItemStyle HorizontalAlign="Left" Font-Names="Arial" Font-Size="8pt" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="NomMoneda" 
            FilterControlAltText="Filter NomMoneda column" HeaderText="M." 
            SortExpression="NomMoneda" UniqueName="NomMoneda" DataType="System.Int32">
                                <HeaderStyle HorizontalAlign="Center" Width="2%" />
                                <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Cuenta" 
            FilterControlAltText="Filter Cuenta column" HeaderText="C. Cont." 
            SortExpression="Cuenta" UniqueName="Cuenta" 
                                DataType="System.Int32">
                                <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Tipo" DataType="System.Int32" 
                                FilterControlAltText="Filter Tipo column" HeaderText="Tipo Cta." 
                                SortExpression="Tipo" UniqueName="Tipo">
                                <HeaderStyle HorizontalAlign="Center" Width="13%" />
                                <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="NroCta" 
                                FilterControlAltText="Filter NroCta column" HeaderText="N° Cta." 
                                SortExpression="NroCta" UniqueName="NroCta">
                                <HeaderStyle HorizontalAlign="Center" Width="14%" />
                                <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="NomSubdiario" 
                                FilterControlAltText="Filter column column" HeaderText="SubDiario" 
                                UniqueName="column">
                                <HeaderStyle HorizontalAlign="Center" Width="28%" />
                                <ItemStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Estado" 
                                FilterControlAltText="Filter Estado column" HeaderText="Estado" 
                                SortExpression="Estado" UniqueName="Estado" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdCtaBancaria" 
            FilterControlAltText="Filter IdCtaBancaria column" HeaderText="IdCtaBancaria" 
            SortExpression="IdCtaBancaria" UniqueName="IdCtaBancaria" DataType="System.Int32" 
                                Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Saldo" DataFormatString="{0:N2}" 
                                FilterControlAltText="Filter column1 column" HeaderText="Saldo" 
                                UniqueName="column1">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Right" />
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings EditFormType="WebUserControl" 
                            UserControlName="~\Contabilidad\Controles\ControlCuentabancaria.ascx">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="odsCuentaBancaria" runat="server" 
                    SelectMethod="GetAllFromCUENTABANCARIA" 
                    TypeName="SistFoncreagro.BussinesLogic.CuentaBancariaBL">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="odsCtaProyecto" runat="server" 
                    SelectMethod="GetCTABANCARIAPROYECTOByIdCtaBancaria" 
                    TypeName="SistFoncreagro.BussinesLogic.CtaBancariaProyectoBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="RadGrid1" Name="IdCtaBancaria" 
                            PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                </telerik:RadWindowManager>
                                            
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" 
                    runat="server">
                    <ClientEvents OnRequestStart="onRequestStart" />
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                </telerik:RadAjaxManager>
            </td>
        </tr>
    </table>
</asp:Content>

