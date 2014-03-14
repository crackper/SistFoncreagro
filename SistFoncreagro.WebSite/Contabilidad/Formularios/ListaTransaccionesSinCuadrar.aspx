<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaTransaccionesSinCuadrar.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaTransaccionesSinCuadrar" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td >
                            transacciones sin cuadrar</td>
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
                                DataSourceID="SqlDataSource1" GridLines="None" Width="100%" 
                                CssClass="grid" Culture="es-PE" 
                                Skin="Hay">
                    <GroupingSettings CaseSensitive="False" />
                    <ExportSettings ExportOnlyData="True" OpenInNewWindow="True">
                    </ExportSettings>
                    <MasterTableView DataSourceID="SqlDataSource1" 
                        ClientDataKeyNames="IdTransaccion" NoMasterRecordsText="No existen registros." 
                                    Name="Transacciones" NoDetailRecordsText="No existen registros." 
                        DataKeyNames="IDTRANSACCION">
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
                <telerik:GridBoundColumn DataField="idsubdiario" 
                    FilterControlAltText="Filter idsubdiario column" HeaderText="SubDiario" 
                    UniqueName="idsubdiario" DataType="System.Int32" SortExpression="idsubdiario">
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                              <telerik:GridBoundColumn DataField="codigo" 
                                  FilterControlAltText="Filter codigo column" HeaderText="Código" 
                                  UniqueName="codigo" SortExpression="codigo">
                                  <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                  <ItemStyle HorizontalAlign="Center" />
                              </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="CargoMN" 
                    FilterControlAltText="Filter CargoMN column" HeaderText="CargoMN" 
                    UniqueName="CargoMN" DataType="System.Decimal" ReadOnly="True" SortExpression="CargoMN">
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                    <ItemStyle HorizontalAlign="Right" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="AbonoMN" 
                    FilterControlAltText="Filter AbonoMN column" HeaderText="AbonoMN" 
                    UniqueName="AbonoMN" DataType="System.Decimal" ReadOnly="True" SortExpression="AbonoMN">
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                    <ItemStyle HorizontalAlign="Right" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="CargoME" 
                    FilterControlAltText="Filter CargoME column" HeaderText="CargoME" 
                    UniqueName="CargoME" DataType="System.Decimal" ReadOnly="True" SortExpression="CargoME">
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                    <ItemStyle HorizontalAlign="Right" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="AbonoME" 
                    FilterControlAltText="Filter AbonoME column" HeaderText="AbonoME" 
                    UniqueName="AbonoME" DataType="System.Decimal" ReadOnly="True" SortExpression="AbonoME">
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                    <ItemStyle HorizontalAlign="Right" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="glosa" 
                    FilterControlAltText="Filter glosa column" HeaderText="Glosa" 
                    UniqueName="glosa" SortExpression="glosa">
                    <HeaderStyle HorizontalAlign="Center" Width="40%" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IDTRANSACCION" 
                    FilterControlAltText="Filter IDTRANSACCION column" HeaderText="IDTRANSACCION" 
                    UniqueName="IDTRANSACCION" DataType="System.Int32" ReadOnly="True" 
                                  SortExpression="IDTRANSACCION" Visible="False">
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetTransaccionesSinCuadrar" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:SessionParameter Name="mes" SessionField="Mes" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>
