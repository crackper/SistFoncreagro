<%@ Page Title="Anticipos/Entregas a Rendir Pendientes" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaAnticiposEntregasPendientes.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaAnticiposEntregasPendientes" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td >
                            lista de anticipos/entregas a rendir pendientes</td>
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
                                DataSourceID="odsTransaccion" 
                                AutoGenerateColumns="False" CellSpacing="0" Culture="es-PE" 
                                GridLines="None">
                    <GroupingSettings CaseSensitive="False" />
<GroupingSettings CaseSensitive="False"></GroupingSettings>

                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>

                    <MasterTableView 
                                    DataSourceID="odsTransaccion" NoDetailRecordsText="No existen registros." 
                                    NoMasterRecordsText="No existen registros." 
                        ClientDataKeyNames="IdTransaccion" datakeynames="IdTransaccion">
                        <CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Registro" RefreshText="Refrescar">
                        </CommandItemSettings>
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Procesar" 
                                ConfirmDialogType="RadWindow" 
                                ConfirmText="¿Va a Rendir la Entrega o el Anticipo?" 
                                ConfirmTitle="Mensaje de Confirmación" 
                                FilterControlAltText="Filter column2 column" ImageUrl="~\img\Proceso.gif" 
                                UniqueName="procesar" Text="Procesar">
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="IdSubDiario" 
            FilterControlAltText="Filter column2 column" HeaderText="SD" UniqueName="column2">
                                <HeaderStyle HorizontalAlign="Center" Width="5%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Codigo" 
                                FilterControlAltText="Filter Codigo column" HeaderText="N° " 
                                SortExpression="Codigo" UniqueName="Codigo">
                                <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="FechaContable" DataType="System.DateTime" 
            FilterControlAltText="Filter FechaContable column" HeaderText="Fec. Contable" 
            SortExpression="FechaContable" UniqueName="FechaContable" DataFormatString="{0:dd/MM/yyyy}">
                                <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="NombreProveedor" 
                                FilterControlAltText="Filter column1 column" HeaderText="Coa" 
                                UniqueName="column1">
                                <HeaderStyle HorizontalAlign="Center" Width="25%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Registro" 
                                FilterControlAltText="Filter Registro column" HeaderText="Registro" 
                                ReadOnly="True" SortExpression="Registro" UniqueName="Registro">
                                <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="IdMoneda" 
                                FilterControlAltText="Filter column column" HeaderText="M." UniqueName="column">
                                <HeaderStyle HorizontalAlign="Center" Width="2%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Total" DataFormatString="{0:0,0.00}" 
                                DataType="System.Decimal" FilterControlAltText="Filter Total column" 
                                HeaderText="Total" SortExpression="Total" UniqueName="Total">
                                <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                <ItemStyle HorizontalAlign="Right" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Glosa" 
                                FilterControlAltText="Filter Glosa column" HeaderText="Glosa" 
                                SortExpression="Glosa" UniqueName="Glosa">
                                <HeaderStyle HorizontalAlign="Center" Width="30%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Idtransaccion" DataType="System.Int32" 
                                FilterControlAltText="Filter Idtransaccion column" HeaderText="Idtransaccion" 
                                SortExpression="Idtransaccion" UniqueName="Idtransaccion" Visible="False">
                                <HeaderStyle HorizontalAlign="Center" />
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings EditFormType="WebUserControl" 
        UserControlName="~\Contabilidad\Controles\ControlRecibo.ascx">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="odsTransaccion" runat="server" 
                    SelectMethod="GetTRANSACCIONESdeAnticiposEntregasPendientes" 
                    TypeName="SistFoncreagro.BussinesLogic.TransaccionBL">
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
</asp:Content>
