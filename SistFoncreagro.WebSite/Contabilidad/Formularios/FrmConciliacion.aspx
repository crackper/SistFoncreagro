<%@ Page Title="Conciliacion Bancaria" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterContabilidad1.master" CodeBehind="FrmConciliacion.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmConciliacion" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                                                <table align="center" 
         class="tabla3">
                                                    <tr>
                                                        <td style="text-align: left" valign="bottom"> 
                                                            <table style="width: 90px">
                                                                <tr>
                                                                    <td >
                                                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                                ToolTip="Grabar" BorderColor="Gray" BorderStyle="Solid" 
                                                                BorderWidth="0px" style="height: 25px" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/img/Nuevo.gif" 
                                                                ToolTip="Nuevo" BorderColor="Gray" BorderStyle="Solid" BorderWidth="0px" 
                                                                CausesValidation="False" style="width: 19px" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/img/Buscar.gif" 
                                                                            ToolTip="Ver el Reporte" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                                    <table cellspacing="0" style="width: 100%" class="0" >
                                                                        <tr >
                                                                            <td width="12%">
                                                                                Cuenta:</td>
                                                                            <td width="50%">
                                                                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="OdsCuentas" 
                                                                                    DataTextField="Descripcion" DataValueField="IdCtaBancaria">
                                                                                </asp:DropDownList>
                                                                            </td>
                                                                            <td width="5%">
                                                                                Fecha:</td>
                                                                            <td width="33%" >
                                                                                  <asp:TextBox ID="txtDate" runat="server" Width="70px" TabIndex="2" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                                                            AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                            TargetControlID="txtDate" />
                                                                                           
                                                                        <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                                                            ControlExtender="MaskedEditExtender2" ControlToValidate="txtDate" 
                                                                            Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                            InvalidValueMessage="¡Fecha Incorrecta!" />                                                                                            
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                                                                ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Fecha Contable!"></asp:RequiredFieldValidator>
                                                                                 </td>
                                                                        </tr>
                                                                        <tr >
                                                                            <td class="style4">
                                                                                Saldo Bancario:</td>
                                                                            <td >
                                                                                                        <telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" Value="0" 
                                                                                                            Width="70px" TabIndex="12">
                                                                                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                           
                                                                                                        </telerik:RadNumericTextBox>
                                                                            </td>
                                                                            <td  class="style4">
                                                                            </td>
                                                                            <td class="style4">
                                                                            </td>
                                                                        </tr>
                                                                        <tr >
                                                                            <td  class="style4">
                                                                                &nbsp;Archivo:</td>
                                                                            <td  style="text-align: left">
                                                <asp:TextBox ID="TextBox3" runat="server" Width="80%"></asp:TextBox>
                                                                                <asp:ImageButton ID="ImageButton13" runat="server" 
                                                                                    ImageUrl="~/img/OpenFile.gif" ToolTip="Abrir Archivo" />
                                                                            </td>
                                                                            <td class="style4" colspan="2" style="text-align: left">
                                                <asp:Label ID="lblMsn" runat="server" style="color: #006699" Width="100%"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="ef8">
                                                                            <td __designer:mapid="ef9" class="style4">
                                                                                &nbsp;</td>
                                                                            <td __designer:mapid="ef9"  colspan="3" style="text-align: left">
                  <asp:FileUpload ID="FileUploadControl" runat="server" 
                                ToolTip="Adjuntar archivos" Width="380px" />
                            <asp:ImageButton ID="ibSubirArchivo" runat="server" ImageUrl="~/img/upload.gif" 
                                ToolTip="Adjuntar Archivo" Height="20px" ValidationGroup="zz" />
                                                                            </td>
                                                                        </tr>
                                                                        </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: center">
                                                                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                                                                CellSpacing="0" DataSourceID="OdsDetalle" GridLines="None" 
                                                                Width="100%" Skin="Hay" style="text-align: left" ShowFooter="True" EnableEmbeddedBaseStylesheet="False" 
                                                                                                EnableEmbeddedScripts="False">
                                                                                <MasterTableView ClientDataKeyNames="IdDetalle" 
                                                                                    DataSourceID="OdsDetalle" NoMasterRecordsText="No existen registros." 
                                                                                    CommandItemDisplay="Top">
                                                                                    <CommandItemSettings AddNewRecordText="Agregar Línea" 
                                                                                        ExportToPdfText="Export to PDF" RefreshText="Refrescar" />
                                                                                    <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                                                                    </RowIndicatorColumn>
                                                                                    <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                                                                    </ExpandCollapseColumn>
                                                                                    <Columns>
                                                                                        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                            FilterControlAltText="Filter EditCommandColumn column">
                                                                                            <HeaderStyle Width="1.5%" />
                                                                                        </telerik:GridEditCommandColumn>
                                                                                        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                            ConfirmText="¿Está seguro que desea Eliminar el registro?" 
                                                                                            ConfirmTitle="Mensaje de Confirmación" 
                                                                                            FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
                                                                                            Text="Eliminar" UniqueName="column">
                                                                                            <HeaderStyle Width="1.5%" />
                                                                                        </telerik:GridButtonColumn>
                                                                                        <telerik:GridBoundColumn DataField="TipoMovimientoDesc" 
                                                                                            FilterControlAltText="Filter TipoMovimientoDesc column" HeaderText="Movimiento" 
                                                                                            UniqueName="TipoMovimientoDesc" DataType="System.Int32" 
                                                                                            SortExpression="TipoMovimientoDesc">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="25%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Fecha" 
                                                                                            FilterControlAltText="Filter Fecha column" HeaderText="Fecha" 
                                                                                            UniqueName="Fecha" DataType="System.DateTime" SortExpression="Fecha" 
                                                                                            DataFormatString="{0:dd/MM/yyyy}">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="ProveedorCliente" 
                                                                                            FilterControlAltText="Filter ProveedorCliente column" HeaderText="Coa" 
                                                                                            UniqueName="ProveedorCliente" DataType="System.Int32" 
                                                                                            SortExpression="ProveedorCliente">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="24%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Glosa" 
                                                                                            FilterControlAltText="Filter Glosa column" HeaderText="Glosa" 
                                                                                            UniqueName="Glosa" SortExpression="Glosa">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="24%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Monto" 
                                                                                            FilterControlAltText="Filter Monto column" HeaderText="Monto" 
                                                                                            UniqueName="Monto" DataType="System.Decimal" SortExpression="Monto" 
                                                                                            DataFormatString="{0:N2}">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdConciliacion" 
                                                                                            FilterControlAltText="Filter IdConciliacion column" HeaderText="IdConciliacion" 
                                                                                            UniqueName="IdConciliacion" DataType="System.Int32" 
                                                                                            SortExpression="IdConciliacion" Visible="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdDetalle" 
                                                                                            FilterControlAltText="Filter IdDetalle column" HeaderText="IdDetalle" 
                                                                                            UniqueName="IdDetalle" DataType="System.Int32" SortExpression="IdDetalle" 
                                                                                            Visible="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                    </Columns>
                                                                                    <EditFormSettings EditFormType="WebUserControl" 
                                                                                        UserControlName="~\Contabilidad\Controles\ControlConciliacion.ascx">
                                                                                        <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                                                                        </EditColumn>
                                                                                    </EditFormSettings>
                                                                                    <CommandItemTemplate>
                                                                                        <asp:ImageButton ID="ImageButton8" runat="server" 
                                                                                            ImageUrl="~/img/AgregarLinea.gif" onclick="ImageButton8_Click" />
                                                                                    </CommandItemTemplate>
                                                                                </MasterTableView> 
                                                                                <FilterMenu EnableImageSprites="False">
                                                                                </FilterMenu>
                                                                                <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                                                                                </HeaderContextMenu>
                                                                            </telerik:RadGrid>
                                                               
                                                                                        </td>
                                                    </tr>
                                                    </table>

                                                <asp:ObjectDataSource ID="OdsCuentas" runat="server" 
        SelectMethod="GetAllFromCUENTABANCARIA" 
        TypeName="SistFoncreagro.BussinesLogic.CuentaBancariaBL" 
        OldValuesParameterFormatString="original_{0}">
    </asp:ObjectDataSource>
                                            
             

                                            
    <asp:ObjectDataSource ID="OdsDetalle" runat="server" 
        SelectMethod="GetDETALLECONCILIACIONByIdConciliacion" 
        TypeName="SistFoncreagro.BussinesLogic.DetalleConciliacionBL" 
        OldValuesParameterFormatString="original_{0}">
        <SelectParameters>
            <asp:SessionParameter Name="IdConciliacion" SessionField="IdConciliacion" 
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
                                            
             

                                            
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
  <Windows>
                <telerik:RadWindow ID="Proveedores" runat="server" Behavior="Minimize, Close" 
                    Behaviors="Default" Height="750px"
                    InitialBehavior="None" Left="" Modal="True" NavigateUrl="" 
                     Style="display: none;" Top="" VisibleStatusbar="True"
                    Width="500px" Title="Registro de Proveedores" AutoSize="True">
                </telerik:RadWindow>
            </Windows>
                            </telerik:RadWindowManager>

             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  



            
        




            
        




                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>


<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    var parametro = 0;
    var tipo = 0;

    function CargarVentana(nombre) {
        aviso = open("/SistIntegral/Contabilidad/Adjuntos/" + nombre, "Documento", "status=no, directories=no, toolbar=no, width=800, height=500, left=100, top=100")
        //        window.open("../Archivos1/Logistica/" + nombre, nombre, "width=800, height=500")    
    }
</script>
</telerik:RadCodeBlock>
                                                </asp:Content>

