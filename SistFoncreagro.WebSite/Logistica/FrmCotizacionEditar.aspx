<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmCotizacionEditar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmCotizacionEditar" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function cargarDatos(idCotizacion, estado) {
        idCoti = idCotizacion;
        est = estado;
    }
//    function CargarVentana(idDetalle, idProyecto, producto) {
//        var oWnd = radopen("VentanaCentroCostoxDetalleReq.aspx?Anular=0&IdDetalle=" + idDetalle + "&IdProyecto=" + idProyecto + "&Producto=" + producto, "CentroCosto");
//    }

    function CargarVentanaCotizacion(esta) {
        var oWnd = radopen("VentanaCargarCotizacion.aspx?IdCotizacion=" + idCoti + "&Estado=" + esta, "VentanaCotizacion");
        return false;
    }

    function CargarVentanaDetalle(tipo, est) {
        var oWnd = radopen("VentanaAgregarDetalle.aspx?IdCotizacion=" + idCoti + "&tip=" + tipo + "&Edit=" + est, "VentanaDetalle");
        return false;
    }

    function CargarVentanaAsistentes() {
        var oWnd = radopen("VentanaAsistentes.aspx?IdCotizacion=" + idCoti, "VentanaAsistente");
        return false;
    }

    function AnularCotizacion() {
        radconfirm('¿Está seguro que desea <b>ANULAR</b> la cotización?', confirmaRecepcion, 300, 150, null, 'Recepción parcial');
    }


    function confirmaRecepcion(arg) {
        if (arg) {
            $find("<%= RadAjaxManager1.ClientID%>").ajaxRequest("AnularCotizacion");
         }
    }

</script>
</telerik:RadCodeBlock>
<asp:TextBox ID="txtIdCotizacion" runat="server" Height="0px" ReadOnly="True" Visible="False" Width="0px"></asp:TextBox>
<asp:TextBox ID="txtIdRequerimiento" runat="server" Height="0px" ReadOnly="True" Visible="False" Width="0px"></asp:TextBox>
<fieldset class="jcv">
<legend class="legendJcv">GENERAR ORDEN DE COMPRA</legend>
    <asp:Panel ID="upCabezera" runat="server">
      <table style="width: 100%" border="0" cellspacing="0" cellpadding="0" class="tabla4">
        <tr>
            <td style="width: 14%; height: 20px; font-weight: bold; font-size: 13px;">
                Nombre :</td>
            <td style="height: 20px">
                <table>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtNombre" runat="server" Width="351px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtNombre" ErrorMessage="*" Font-Size="8pt" 
                                ValidationGroup="Validar"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:LinkButton ID="lbSolicitarAprobacion" runat="server" Enabled="False" 
                                ValidationGroup="Validar">Solicitar Aprobación</asp:LinkButton>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:LinkButton ID="lbAnularCotizacion" runat="server" 
                                onclientclick="AnularCotizacion();">Anular Cotización</asp:LinkButton>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:LinkButton ID="lbGuardarCabezera" runat="server" ValidationGroup="Validar">Guardar cambios</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 14%; height: 20px; font-weight: bold; font-size: 13px;">
                Moneda :</td>
            <td style="height: 20px" valign="middle">
                <asp:DropDownList ID="ddlMoneda" runat="server" DataSourceID="odsMoneda" 
                    Width="140px" DataTextField="Nombre" 
                    DataValueField="IdMoneda">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Tipo :" style="width: 14%; height: 20px; font-weight: bold; font-size: 13px;"></asp:Label>
                &nbsp;<asp:DropDownList ID="ddlTipo" runat="server" DataSourceID="odsTipoCoti" 
                    DataTextField="Descripcion" DataValueField="IdTipoCotizacion" 
                    Width="140px" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 14%; font-weight: bold; height: 20px; font-size: 13px;">
                N° Requerimiento :</td>
            <td style="height: 20px">
                <asp:Label ID="lblRequerimiento" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" 
                    style="width: 14%; height: 20px; font-weight: bold; font-size: 13px;" 
                    Text="Área :"></asp:Label>
                &nbsp;<asp:Label ID="lblArea" runat="server"></asp:Label>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 14%; font-weight: bold; height: 20px; font-size: 13px;">
                <asp:Label ID="lblFecha" runat="server" Text="Fecha :"></asp:Label>
            </td>
            <td style="height: 20px">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblFechaRegistro" runat="server"></asp:Label>
                            <asp:DropDownList ID="ddlRazonCotizacion" runat="server" 
                                DataSourceID="odsRazonCotizacion" DataTextField="Descripcion" 
                                DataValueField="IdRazonSoulSource" Visible="False" Width="354px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="querid" runat="server" 
                                ControlToValidate="ddlRazonCotizacion" ErrorMessage="*" Font-Size="7.5pt" 
                                ValidationExpression="[1-9]" ValidationGroup="Validar"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 14%; font-weight: bold; height: 20px; font-size: 13px;">
                Estado Cotización:</td>
            <td style="height: 25px">
                <asp:Label ID="lblEstado" runat="server"></asp:Label>
            </td>
            <td style="height: 25px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 14%; font-weight: bold; height: 20px; font-size: 13px;">
                Observaciones :</td>
            <td style="height: 25px">
                <asp:TextBox ID="txtObservaciones" runat="server" Height="50px" TextMode="MultiLine" 
                    Width="351px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            <td style="height: 25px">
                &nbsp;</td>
        </tr>
        </table>
    </asp:Panel>
</fieldset>
<fieldset class="jcv">
    <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="width: 14%; height: 20px; font-weight: bold; font-size: 13px;">
                Proveedor :</td>
            <td style="height: 20px">
               <table style="width: 100%">
                                                    <tr>
                                                        <td style="width: 445px">
                                                <telerik:RadComboBox ID="rcbProveedor" Runat="server" 
                                    DataSourceID="odsProveedor" DataTextField="RazonSocial" 
                                    DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" 
                                    style="margin-left: 0px" ValidationGroup="poducto" Width="440px" 
                                    EmptyMessage="Ingrese Ruc o Razón social...">
                                </telerik:RadComboBox>
                                                        </td>
                                                        <td style="width: 15px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="rcbProveedor" 
                                    ErrorMessage="Ingrese RUC o Razón Social del Proveedor" 
                                    ValidationGroup="proveedor" Font-Size="8pt">*</asp:RequiredFieldValidator>
                                                        </td>
                                                        <td>
                                <asp:LinkButton ID="lbAgregarProveedor" runat="server" 
                    ValidationGroup="proveedor">Agregar Proveedor</asp:LinkButton>
                                                        </td>
                                                    </tr>
                                                </table>
                </td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 14%; height: 20px; font-weight: bold; font-size: 13px;">
                Producto/Servicio :</td>
            <td style="height: 20px">
                 <table style="width: 100%">
                                                    <tr>
                                                        <td style="width: 445px">
                                                            <telerik:RadComboBox ID="rcbProductoServicio" Runat="server" 
                                                                AllowCustomText="True" DataSourceID="odsProductoServicio" 
                                                                DataTextField="CodigoDescripcion" DataValueField="IdCatalogo" 
                                                                EnableLoadOnDemand="True" Width="440px">
                                                            </telerik:RadComboBox>
                <asp:TextBox ID="txtValidar2" runat="server" ReadOnly="True" Height="0px" 
                    Visible="False" Width="89px">0</asp:TextBox>
                                                        </td>
                                                        <td style="width: 15px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ControlToValidate="rcbProductoServicio" 
                                    ErrorMessage="Ingrese RUC o Razón Social del Proveedor" 
                                    ValidationGroup="producto" Font-Size="8pt">*</asp:RequiredFieldValidator>
                                                        </td>
                                                        <td>
                                <asp:LinkButton ID="lbAgregarProductoServicio" runat="server" 
                    ValidationGroup="producto">Agregar P/S</asp:LinkButton>
                                                        </td>
                                                    </tr>
                                                </table>
                                </td>
            <td style="height: 20px">
                &nbsp;</td>
        </tr>

    </table>
</fieldset>
<fieldset class="jcv">
    <table border="0" cellspacing="0" cellpadding="0" class="tabla4">
        <tr>
            <td style="width: 14%; font-weight: bold; height: 25px; font-size: small;">
                <asp:TextBox ID="txtValidar" runat="server" ReadOnly="True" Height="0px" 
                    Visible="False" Width="0px">0</asp:TextBox>
                </td>
            <td align="right" style="height: 25px" valign="top">
                <asp:LinkButton ID="lbGuardarDetalle" runat="server">Guardar detalle</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td style="font-weight: bold; height: 20px; font-size: x-small;" colspan="2">
                <asp:GridView ID="gvDetalleCotizacion" runat="server" DataSourceID="odsDetalleReqCoti" 
                    AutoGenerateColumns="False" Font-Size="9pt" Width="890px">

<SortedAscendingCellStyle BackColor="#F7F7F7"></SortedAscendingCellStyle>

<SortedAscendingHeaderStyle BackColor="#487575"></SortedAscendingHeaderStyle>

<SortedDescendingCellStyle BackColor="#E5E5E5"></SortedDescendingCellStyle>

<SortedDescendingHeaderStyle BackColor="#275353"></SortedDescendingHeaderStyle>
                <Columns>
                <asp:BoundField DataField="IdCatalogo" HeaderText="IdCatalogo" 
                    SortExpression="IdCatalogo" Visible="False" />
                    <asp:ButtonField ButtonType="Image" CommandName="DeleteItem" 
                                        ImageUrl="~/img/Delete.gif" >
                                    <HeaderStyle Width="15px" />
                                    <ItemStyle Width="15px" />
                                    </asp:ButtonField>

               <asp:BoundField DataField="codigoCatalogo" HeaderText="CÓDIGO" 
                    SortExpression="codigoCatalogo" >
                <HeaderStyle HorizontalAlign="Center" Width="75px" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="nombreCatalogo" HeaderText="PRODUCTO / SERVICIO" 
                    SortExpression="nombreCatalogo" >
               <HeaderStyle Width="300px" />
                </asp:BoundField>
                <asp:BoundField DataField="UnidadMedidaDetalle" HeaderText="UNIDAD" >
                <HeaderStyle HorizontalAlign="Center" Width="30px" />
                <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:BoundField>
                    <asp:TemplateField HeaderText="IGV">
                        <ItemTemplate>
                            <asp:CheckBox ID="cbIgv" runat="server" Checked='<%# Bind("DetAfectoIgv") %>' 
                                Enabled="False" />
                        </ItemTemplate>
                        <ControlStyle Width="20px" />
                        <FooterStyle Width="20px" />
                        <HeaderStyle Width="20px" />
                        <ItemStyle Width="20px" />
                    </asp:TemplateField>
                <asp:BoundField DataField="Cantidad" HeaderText="CANTIDAD" >
                <HeaderStyle HorizontalAlign="Center" Width="65px" />
                <ItemStyle HorizontalAlign="Center" Width="25px" />
                </asp:BoundField>
                    <asp:TemplateField HeaderText="PROVEEDOR">
                        <ItemTemplate>
                                            <asp:TextBox ID="txtIdDetReqCoti" runat="server"
                        Text='<%# Bind("IdDetalleReqCotizacion") %>' Width="0px" Height="0px" 
                                 ReadOnly="True" Visible="False"></asp:TextBox>
                    <asp:TextBox ID="txtIdDetReq" runat="server"
                        Text='<%# Bind("IdDetalleRequerimiento") %>' Width="0px" Height="0px"
                        ReadOnly="True" Visible="False"></asp:TextBox>
                            <asp:TextBox ID="txtIdDetalleReqCotizacion" runat="server" ReadOnly="True" 
                                Width="0px" Text='<%# Bind("IdDetalleReqCotizacion") %>' Height="0px" 
                                Visible="False"></asp:TextBox>
                            <asp:Panel ID="Panel1" runat="server">
                                <asp:GridView ID="gvProveedor" runat="server" AutoGenerateColumns="False" 
                                DataSourceID="odsProveedorDetalleCotizacion" 
                                    onselectedindexchanged="gvProveedor_SelectedIndexChanged" 
                                    onrowcommand="gvProveedor_RowCommand" 
                                    Width="420px" DataKeyNames="IdProveedor" Font-Size="8pt">
                                <Columns>
                                    <asp:ButtonField ButtonType="Image" CommandName="DeleteCommand" 
                                        ImageUrl="~/img/Delete.gif" >
                                    <HeaderStyle Width="15px" />
                                    <ItemStyle Width="15px" />
                                    </asp:ButtonField>
                                    <asp:CommandField ShowSelectButton="True" SelectText="Selec" >
                                    <HeaderStyle HorizontalAlign="Center" Width="15px" />
                                    <ItemStyle HorizontalAlign="Center" Width="15px" />
                                    </asp:CommandField>
                                    <asp:BoundField DataField="NombreProveedor" HeaderText="Razón Social" 
                                        ReadOnly="True" SortExpression="NombreProveedor" >
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" Width="200px" />
                                    </asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:RadioButton ID="rbSeleccionarProveedor" runat="server" Checked='<%# Bind("Estado") %>' 
                                                GroupName="grupoSeleccionar" Enabled="False" />
                                            <asp:TextBox ID="txtIdProveedorDetalleCotizacion" runat="server" Height="0px" 
                                                ReadOnly="True" Text='<%# Bind("IdProveedorDetalleCotizacion") %>' 
                                                Visible="False" Width="0px"></asp:TextBox>
                                            <asp:TextBox ID="txtIdProveedor" runat="server" Height="0px" 
                                                ReadOnly="True" Text='<%# Bind("IdProveedor") %>' 
                                                Visible="False" Width="0px"></asp:TextBox>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" Width="15px" />
                                        <ItemStyle HorizontalAlign="Center" Width="15px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Precio">
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtPrecio" runat="server" BackColor="Info" 
                                                CssClass="TextoCentro" Text='<%# Bind("Monto", "{0:N}") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" Width="50px" />
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                            </asp:Panel>
                            <asp:ObjectDataSource ID="odsProveedorDetalleCotizacion" runat="server" 
                                SelectMethod="GetAllFromProveedorDetalleCotizacionByIdDetalleReqCotizacion" 
                                TypeName="SistFoncreagro.BussinesLogic.ProveedorDetalleCotizacionBL">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="txtIdDetalleReqCotizacion" 
                                        Name="idDetalleReqCotizacion" PropertyName="Text" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
            </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="font-weight: bold; height: 20px; font-size: x-small;" align="center" 
                colspan="2">
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" Visible="False"></asp:Label>
            </td>
        </tr>
        </table>
</fieldset>
<fieldset class="jcv">
    <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="width: 200px">
       <asp:LinkButton ID="lbAdjuntarArchivo" runat="server">Adjuntar archivo</asp:LinkButton>
                        </td>
                        <td>
                                             &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 200px">
                <asp:LinkButton ID="lbAgregarParrafo" runat="server">Agregar detalle</asp:LinkButton>
                        </td>
                        <td align="right" rowspan="2" valign="bottom">
                            <asp:LinkButton ID="lbFinalizar" runat="server" Visible="False">Finalizar</asp:LinkButton>
                            <asp:LinkButton ID="lbGenerarOc" runat="server" Visible="False">Generar O/C</asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 200px">
                <asp:LinkButton ID="lbAdjuntarArchivo1" runat="server"
                OnClientClick="return CargarVentanaAsistentes();">Agregar participantes</asp:LinkButton>
                        </td>
                    </tr>
                </table>
</fieldset>
                   <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                    <Windows>
                    <telerik:RadWindow ID="VentanaCotizacion" runat="server" 
                            Title="Adjuntar cotizacion" Height="450px"
                        Width="705px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" />
                    <telerik:RadWindow ID="VentanaDetalle" runat="server" Title="Agregar párrafo" Height="600px"
                        Width="810px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" />
                  <telerik:RadWindow ID="VentanaAsistente" runat="server" Title="Agregar asistente" Height="500px"
                        Width="720px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" />
                    </Windows>
                </telerik:RadWindowManager>
              <asp:ObjectDataSource ID="odsRazonCotizacion" runat="server" 
        SelectMethod="GetAllFromRazones" 
        TypeName="SistFoncreagro.BussinesLogic.RazonSoulSourceBL">
    </asp:ObjectDataSource>
              <asp:ObjectDataSource ID="odsDetalleReqCoti" runat="server" 
                   SelectMethod="GetAllFromDetalleRequerimientoCotizacionByIdDetReqCot" 
                   TypeName="SistFoncreagro.BussinesLogic.CotizacionBL">
                   <SelectParameters>
                       <asp:QueryStringParameter Name="idCotizacion" QueryStringField="IdCoti" 
                           Type="Int32" />
                   </SelectParameters>
               </asp:ObjectDataSource>
                  <asp:ObjectDataSource ID="odsTipoCoti" runat="server" 
                    SelectMethod="GetAllFromTipoCotizacion" 
                    TypeName="SistFoncreagro.BussinesLogic.TipoCotizacionBL">
                </asp:ObjectDataSource>
                  <asp:ObjectDataSource ID="odsMoneda" runat="server" 
                    SelectMethod="GetAllFromMoneda" 
                    TypeName="SistFoncreagro.BussinesLogic.MonedaBL">
                </asp:ObjectDataSource>
                                <asp:ObjectDataSource ID="odsProveedor" 
        runat="server" SelectMethod="GetAllFromProveedorClienteByParametro" 
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL" 
    OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                    </SelectParameters>
    </asp:ObjectDataSource>
                                <asp:ObjectDataSource ID="odsProductoServicio" 
        runat="server" SelectMethod="GetAllFromCatalogoOfDetalleRequerimientoByParametro" 
        TypeName="SistFoncreagro.BussinesLogic.CatalogoBL">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="txtIdRequerimiento" DefaultValue="" 
                                            Name="idRequerimiento" PropertyName="Text" Type="Int32" />
                                        <asp:Parameter DefaultValue="00" Name="parametro" Type="String" />
                                    </SelectParameters>
    </asp:ObjectDataSource>
               <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" 
        Runat="server" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
               <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                   <AjaxSettings>
                       <telerik:AjaxSetting AjaxControlID="lbGuardarCabezera">
                           <UpdatedControls>
                               <telerik:AjaxUpdatedControl ControlID="upCabezera" 
                                   LoadingPanelID="RadAjaxLoadingPanel1" />
                               <telerik:AjaxUpdatedControl ControlID="lbAgregarParrafo" />
                           </UpdatedControls>
                       </telerik:AjaxSetting>
                       <telerik:AjaxSetting AjaxControlID="ddlTipo">
                           <UpdatedControls>
                               <telerik:AjaxUpdatedControl ControlID="lblFecha" />
                               <telerik:AjaxUpdatedControl ControlID="lblFechaRegistro" />
                               <telerik:AjaxUpdatedControl ControlID="ddlRazonCotizacion" />
                               <telerik:AjaxUpdatedControl ControlID="querid" />
                           </UpdatedControls>
                       </telerik:AjaxSetting>
                       <telerik:AjaxSetting AjaxControlID="lbAgregarProveedor">
                           <UpdatedControls>
                               <telerik:AjaxUpdatedControl ControlID="rcbProveedor" />
                               <telerik:AjaxUpdatedControl ControlID="gvDetalleCotizacion" 
                                   LoadingPanelID="RadAjaxLoadingPanel1" />
                           </UpdatedControls>
                       </telerik:AjaxSetting>
                       <telerik:AjaxSetting AjaxControlID="lbAgregarProductoServicio">
                           <UpdatedControls>
                               <telerik:AjaxUpdatedControl ControlID="rcbProductoServicio" />
                               <telerik:AjaxUpdatedControl ControlID="gvDetalleCotizacion" 
                                   LoadingPanelID="RadAjaxLoadingPanel1" />
                           </UpdatedControls>
                       </telerik:AjaxSetting>
                       <telerik:AjaxSetting AjaxControlID="lbGuardarDetalle">
                           <UpdatedControls>
                               <telerik:AjaxUpdatedControl ControlID="lbSolicitarAprobacion" />
                               <telerik:AjaxUpdatedControl ControlID="gvDetalleCotizacion" 
                                   LoadingPanelID="RadAjaxLoadingPanel1" />
                               <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                               <telerik:AjaxUpdatedControl ControlID="lbFinalizar" />
                           </UpdatedControls>
                       </telerik:AjaxSetting>
                       <telerik:AjaxSetting AjaxControlID="gvDetalleCotizacion">
                           <UpdatedControls>
                               <telerik:AjaxUpdatedControl ControlID="rcbProductoServicio" />
                               <telerik:AjaxUpdatedControl ControlID="gvDetalleCotizacion" />
                               <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                           </UpdatedControls>
                       </telerik:AjaxSetting>
                       <telerik:AjaxSetting AjaxControlID="lbFinalizar">
                           <UpdatedControls>
                               <telerik:AjaxUpdatedControl ControlID="gvDetalleCotizacion" />
                               <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                           </UpdatedControls>
                       </telerik:AjaxSetting>
                   </AjaxSettings>
    </telerik:RadAjaxManager>
               </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>

