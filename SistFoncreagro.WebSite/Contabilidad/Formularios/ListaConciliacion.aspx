<%@ Page Title="Listado de Conciliaciones Bancarias" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaConciliacion.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaConciliacion" %>
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
                        <td >
                            Listado de conciliaciones bancarias</td>
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
  
                            <telerik:RadGrid ID="RadGrid2" runat="server" 
        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlCuentas" 
        GridLines="None" Skin="Hay">
<MasterTableView ClientDataKeyNames="IdCtaBancaria" DataKeyNames="IdCtaBancaria" DataSourceID="SqlCuentas" 
                                    CommandItemDisplay="Top">
    <DetailTables>
        <telerik:GridTableView runat="server" ClientDataKeyNames="IdConciliacion" 
            DataKeyNames="IdConciliacion" DataSourceID="SqlConciliacion" 
            Name="Conciliaciones">
            <ParentTableRelation>
                <telerik:GridRelationFields DetailKeyField="IdCtaBancaria" 
                    MasterKeyField="IdCtaBancaria" />
            </ParentTableRelation>
            <CommandItemSettings ExportToPdfText="Export to PDF" />
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                <HeaderStyle Width="20px" />
            </RowIndicatorColumn>
            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                <HeaderStyle Width="20px" />
            </ExpandCollapseColumn>
            <Columns>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Editar" 
                    FilterControlAltText="Filter editar column" ImageUrl="~\img\edit.gif" 
                    UniqueName="editar" Text="Editar">
                    <HeaderStyle Width="2%" />
                </telerik:GridButtonColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                    ConfirmDialogType="RadWindow" 
                    ConfirmText="¿Está seguro que desea Eliminar el Registro?" ConfirmTitle="Mensaje de Confirmación" 
                    FilterControlAltText="Filter column1 column" ImageUrl="~\img\delete.gif" 
                    Text="Eliminar" UniqueName="eliminar">
                    <HeaderStyle Width="2%" />
                </telerik:GridButtonColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
                    ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro que desea Anular el Registro?" 
                    ConfirmTitle="Mensaje de Confirmación" FilterControlAltText="Filter anular column" 
                    ImageUrl="~\img\Anular.gif" Text="Anular" UniqueName="anular">
                    <HeaderStyle Width="2%" />
                </telerik:GridButtonColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Ver" 
                    FilterControlAltText="Filter ver column" ImageUrl="~\img\Rendir.gif" Text="Ver Adjuntos" 
                    UniqueName="ver">
                    <HeaderStyle Width="2%" />
                </telerik:GridButtonColumn>
                <telerik:GridTemplateColumn FilterControlAltText="Filter Mes column" 
                    HeaderText="Mes" UniqueName="Mes">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# NomMes(Eval("Mes")) %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle Width="20%" />
                </telerik:GridTemplateColumn>
                <telerik:GridBoundColumn DataField="SaldoBancario" 
                    FilterControlAltText="Filter SaldoBancario column" HeaderText="Saldo Bancario" 
                    UniqueName="SaldoBancario" DataFormatString="{0:N2}">
                    <HeaderStyle Width="72%" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Estado" 
                    FilterControlAltText="Filter Estado column" HeaderText="Estado" 
                    UniqueName="Estado" Visible="False">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IdCtaBancaria" 
                    FilterControlAltText="Filter IdCtaBancaria column" HeaderText="IdCtaBancaria" 
                    UniqueName="IdCtaBancaria" Visible="False">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IdConciliacion" 
                    FilterControlAltText="Filter IdConciliacion column" HeaderText="IdConciliacion" 
                    UniqueName="IdConciliacion" Visible="False">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Mes" 
                    FilterControlAltText="Filter Mes1 column" HeaderText="Mes" UniqueName="Mes1" 
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
        <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Descripcion" 
            SortExpression="Descripcion" UniqueName="Descripcion">
            <HeaderStyle HorizontalAlign="Center" Width="45%" />
            <ItemStyle HorizontalAlign="Left" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroCta" 
            FilterControlAltText="Filter NroCta column" HeaderText="N° Cuenta" 
            SortExpression="NroCta" UniqueName="NroCta">
            <HeaderStyle HorizontalAlign="Center" Width="45%" />
            <ItemStyle HorizontalAlign="Left" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdMoneda" DataType="System.Int32" 
            FilterControlAltText="Filter IdMoneda column" HeaderText="Moneda" 
            SortExpression="IdMoneda" UniqueName="IdMoneda">
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdCtaBancaria" DataType="System.Int32" 
            FilterControlAltText="Filter IdCtaBancaria column" HeaderText="IdCtaBancaria" 
            ReadOnly="True" SortExpression="IdCtaBancaria" UniqueName="IdCtaBancaria" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Fecha" 
            FilterControlAltText="Filter Fecha column" HeaderText="Fecha" 
            UniqueName="Fecha" Visible="False">
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
  
    <asp:SqlDataSource ID="SqlCuentas" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetCTABANCARIAInConciliacion" 
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:SessionParameter Name="anio" SessionField="Anio" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
                                            
             
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
  

    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"  
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Formulario" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True"  OnClientClose="Validar">
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
                                            
             
              <asp:SqlDataSource ID="SqlConciliacion" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetCONCILIACIONBANCARIAByAnioAndIdCtaBancaria" 
        SelectCommandType="StoredProcedure">
                  <SelectParameters>
                      <asp:SessionParameter Name="Anio" SessionField="Anio" Type="Int32" />
                      <asp:ControlParameter ControlID="RadGrid2" Name="IdCtaBancaria" 
                          PropertyName="SelectedValue" Type="Int32" />
                  </SelectParameters>
    </asp:SqlDataSource>
  
                            <telerik:RadAjaxManager ID="RadAjaxManager1" 
        runat="server">
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="RadGrid2">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>
    </telerik:RadAjaxManager>
      <telerik:RadCodeBlock ID="RadCodeBlock2" runat="server">
<script type="text/javascript">
    var parametro = 0;
    var tipo = 0;

    function CargarVentana(nombre) {
        aviso = open("/Contabilidad/Contabilidad/Adjuntos/" + nombre, "Documento", "status=no, directories=no, toolbar=no, width=800, height=500, left=100, top=100")
        //        window.open("../Archivos1/Logistica/" + nombre, nombre, "width=800, height=500")    
    }
</script>
</telerik:RadCodeBlock>

                                                </asp:Content>

