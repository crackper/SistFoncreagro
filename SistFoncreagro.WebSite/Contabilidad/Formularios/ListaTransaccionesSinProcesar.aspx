<%@ Page Title="Transacciones sin Procesar" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaTransaccionesSinProcesar.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaTransaccionesSinProcesar" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td >
                            transacciones sin procesar</td>
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
                <telerik:RadGrid ID="RadGrid1" runat="server" 
                                AutoGenerateColumns="False" CellSpacing="0" 
                                DataSourceID="odsTransacciones" GridLines="None" Width="100%" 
                                CssClass="grid" Culture="es-PE" 
                                Skin="Hay">
                    <GroupingSettings CaseSensitive="False" />
                    <ExportSettings ExportOnlyData="True" OpenInNewWindow="True">
                    </ExportSettings>
                    <MasterTableView DataSourceID="odsTransacciones" 
                        ClientDataKeyNames="IdProveedorCliente" NoMasterRecordsText="No existen registros." 
                                    Name="Proveedor" NoDetailRecordsText="No existen registros.">
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Registro" ExportToCsvText="Exportar a CSV" 
        ExportToExcelText="Exportar a Excel" ExportToWordText="Exportar a Word" 
        RefreshText="Refrescar">
                        </CommandItemSettings>
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </ExpandCollapseColumn>
                          <Columns>
                              <telerik:GridBoundColumn DataField="IdSubdiario" 
                                  FilterControlAltText="Filter column1 column" HeaderText="SubDiario" 
                                  UniqueName="column1">
                              </telerik:GridBoundColumn>
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
                <telerik:GridBoundColumn DataField="Glosa" 
                    FilterControlAltText="Filter column3 column" HeaderText="Glosa" 
                    UniqueName="column3">
                </telerik:GridBoundColumn>
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
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="odsTransacciones" runat="server" 
                    SelectMethod="GetTransaccionesSinProcesar" 
                    TypeName="SistFoncreagro.BussinesLogic.TransaccionBL">
                    <SelectParameters>
                        <asp:SessionParameter Name="Anio" SessionField="Anio" Type="Int32" />
                        <asp:SessionParameter Name="Mes" SessionField="Mes" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>
