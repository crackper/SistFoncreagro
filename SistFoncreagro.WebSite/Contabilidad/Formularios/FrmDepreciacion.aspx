<%@ Page Title="Depreciación de Activos Fijos" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmDepreciacion.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmDepreciacion" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
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
                                       <td>
                                         depreciación de activos fijos</td>
                                                       
                                        <td style="text-align: right">
               
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar" CausesValidation="False" 
                                                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" />
                
                                                            </td>
                                                       
                                                    </tr>
                                                </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="efa">
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td width="8%" __designer:mapid="efc">
                                                                                            Proyecto:</td>
                                                                                        <td width="76%" __designer:mapid="efd">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe escoger el Proyecto!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="6%" __designer:mapid="f00">
                                                                                            Fecha :</td>
                                                                                        <td width="10%" __designer:mapid="f01">
                                                                                            <asp:TextBox ID="txtDate" runat="server" Width="70px" Enabled="False" />
                                                                                             <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate" />
                                                                                            <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender1" 
                                                                                                ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" />
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td __designer:mapid="efc" colspan="4" 
                                                                                            style="text-align: center; font-size: 3pt; font-family: 'Segoe UI';">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td __designer:mapid="efc" colspan="4" style="text-align: center">
                                                                                            <telerik:RadButton ID="RadButton1" runat="server" Skin="Telerik" 
                                                                                                Text="Generar Depreciación">
                                                                                            </telerik:RadButton>
                                                                                        </td>
                                                                                    </tr>
                                                                                    </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="font-size: 3pt; font-family: 'Segoe UI';" class="Texto">
                                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: center">
  

                                                <telerik:RadGrid ID="RadGrid1" runat="server" 
                             AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlDepreciacion" 
                             Skin="Hay" GridLines="None" AllowSorting="True" >
                                                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                                        SortedBackColor="Silver" SortedDescToolTip="Ordenado descendente" 
                                                        SortToolTip="Click aqui para ordenar" />
<MasterTableView DataKeyNames="IdDepreciacion" DataSourceID="SqlDepreciacion" ClientDataKeyNames="IdDepreciacion" 
                                                        NoMasterRecordsText="No existen registros." CommandItemDisplay="Top">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        ExportToExcelText="Exportar a Excel" ShowAddNewRecordButton="False" 
        ShowExportToExcelButton="True" ShowRefreshButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column"></RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column"></ExpandCollapseColumn>
   <Columns>
                                                                                        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                            FilterControlAltText="Filter EditCommandColumn column" UniqueName="editar" 
                                                                                            UpdateText="Editar">
                                                                                            <HeaderStyle Width="1.5%" />
                                                                                            <ItemStyle Width="2%" />
                                                                                        </telerik:GridEditCommandColumn>
                                                                                        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                            ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro que desea Eliminar el Registro?" 
                                                                                            ConfirmTitle="Mensaje de Confirmación" FilterControlAltText="Filter column2 column" 
                                                                                            ImageUrl="~\img\delete.gif" Text="Eliminar" UniqueName="eliminar">
                                                                                            <HeaderStyle Width="1.5%" />
                                                                                            <ItemStyle Width="2%" />
                                                                                        </telerik:GridButtonColumn>
                                                                                        <telerik:GridBoundColumn DataField="Descripcion" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter Cta column" HeaderText="Activo Fijo" 
                                                                                            SortExpression="Descripcion" UniqueName="Descripcion">
                                                                                            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                                                                                                Width="45%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Left" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="FechaIngreso" 
                                                                                            FilterControlAltText="Filter column column" HeaderText="Fec. Compra" 
                                                                                            UniqueName="FechaIngreso" DataFormatString="{0:dd/MM/yyyy}">
                                                                                            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                                                                                                Width="6%" />
                                                                                            <ItemStyle HorizontalAlign="Center" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Costo" DataFormatString="{0:N2}" 
                                                                                            FilterControlAltText="Filter Costo column" HeaderText="Valor" 
                                                                                            UniqueName="Costo">
                                                                                            <HeaderStyle Width="6%" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="PlanContable" 
                                                                                            FilterControlAltText="Filter PlanContable column" HeaderText="Cta. Contable" 
                                                                                            UniqueName="PlanContable">
                                                                                            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                                                                                                Width="6%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="PlanDepreciacion" 
                                                                                            FilterControlAltText="Filter PlanDepreciacion column" 
                                                                                            HeaderText="Cta. Depreciacion" UniqueName="PlanDepreciacion">
                                                                                            <HeaderStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" 
                                                                                                Width="6%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Porcentaje" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter Transaccion column" HeaderText="%" 
                                                                                            SortExpression="Porcentaje" UniqueName="Porcentaje">
                                                                                            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                                                                                                Width="5%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="MesesDepreciados" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter Cargo column" HeaderText="M. Dep." 
                                                                                            SortExpression="MesesDepreciados" UniqueName="MesesDepreciados" DataFormatString="{0:N2}" 
                                                                                            Aggregate="Sum" FooterAggregateFormatString="{0:N2}">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" 
                                                                                                Width="5%" />
                                                                                            <ItemStyle HorizontalAlign="Center" Width="8%" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="DepreciacionEjercicio" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter Abono column" HeaderText="Dep. Ejercicio" 
                                                                                            SortExpression="DepreciacionEjercicio" UniqueName="DepreciacionEjercicio" DataFormatString="{0:N2}" 
                                                                                            Aggregate="Sum" FooterAggregateFormatString="{0:N2}">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" 
                                                                                                Width="6%" />
                                                                                            <ItemStyle HorizontalAlign="Right" Width="8%" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="DepreciacionAcumulada" 
                                                                                            FilterControlAltText="Filter Glosa column" HeaderText="Dep. Acumulada" 
                                                                                            SortExpression="DepreciacionAcumulada" UniqueName="DepreciacionAcumulada" 
                                                                                            Aggregate="Sum" DataFormatString="{0:N2}" 
                                                                                            FooterAggregateFormatString="{0:N2}">
                                                                                            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                                                                                                Width="6%" />
                                                                                            <ItemStyle Width="35%" Font-Names="Arial" Font-Size="8pt" 
                                                                                                HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
<telerik:GridBoundColumn DataField="SaldoPorDepreciar" HeaderText="Saldo Depreciar" SortExpression="SaldoPorDepreciar" UniqueName="SaldoPorDepreciar" 
                                                                                            DataType="System.Int32" FilterControlAltText="Filter IdLinea column" 
                                                                                            Aggregate="Sum" DataFormatString="{0:N2}" FooterAggregateFormatString="{0:N2}" 
                                                                                            ReadOnly="True">
<HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" Width="6%"></HeaderStyle>
    <ItemStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Right" />
</telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdBienMueble" 
                                                                                            FilterControlAltText="Filter IdBienMueble column" HeaderText="IdBienMueble" 
                                                                                            UniqueName="IdBienMueble" Visible="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdDepreciacion" 
                                                                                            FilterControlAltText="Filter IdDepreciacion column" 
                                                                                            HeaderText="IdDepreciacion" UniqueName="IdDepreciacion" 
                                                                                            Visible="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                    </Columns>

 <EditFormSettings EditFormType="WebUserControl" 
                                                                                        UserControlName="~\Contabilidad\Controles\ControlDepreciacion.ascx">
                                                                                      
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
                                                                                      
                                                                                    </EditFormSettings>
</MasterTableView>




<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Hay"></HeaderContextMenu>




                         </telerik:RadGrid>
  

                                                        </td>
                                                    </tr>
                                                    </table>

                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>

    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

        <asp:SqlDataSource ID="SqlDepreciacion" 
    runat="server" 
                                                                                
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                                                
    SelectCommand="GetDEPRECIACIONByIdProyecto" 
                                                                                
    SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="RadComboBox1" Name="IdProyecto" 
                    PropertyName="SelectedValue" Type="Int32" />
                <asp:SessionParameter Name="Ejercicio" SessionField="Anio" Type="Int32" />
                <asp:SessionParameter Name="Mes" SessionField="Mes" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
  

                                                <telerik:RadWindowManager ID="RadWindowManager1" 
                             runat="server">
                         </telerik:RadWindowManager>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                <ClientEvents OnRequestStart="onRequestStart" />
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadButton1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
    </telerik:RadAjaxManager>
   </asp:Content>
