<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmCotizacionEditarAprobar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmCotizacionEditarAprobar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function CargarFormato(idCotizacion) {
        var oWnd = radopen("VentanaReporteSoulSource.aspx?IdCoti=" + idCotizacion, "VentanaFormato");
        return false;
    }

    function CargarVentanaCotizacion(idCoti) {
        var oWnd = radopen("VentanaCargarCotizacion.aspx?IdCotizacion=" + idCoti + "&Estado=1", "VentanaCotizacion");
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
    <fieldset dir="rtl">
    <asp:LinkButton ID="lbFormato" runat="server">Ver Formato</asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="lbAdjuntarArchivo" runat="server">Adjuntos</asp:LinkButton>
              &nbsp;&nbsp;&nbsp;&nbsp;
                          <asp:LinkButton ID="lbAprobarOc" runat="server">Aprobar Sole Source</asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:LinkButton ID="lbAnularSoul" runat="server" 
                      Text="Anular Sole Source" />
    </fieldset>
<fieldset class="jcv">
<legend class="legendJcv">GENERAR ORDEN DE COMPRA</legend>
    <asp:Panel ID="upCabezera" runat="server">
      <table style="width: 100%" border="0" cellspacing="0" cellpadding="0" class="tabla4">
        <tr>
            <td style="width: 14%; height: 20px; font-weight: bold; font-size: 13px;">
                Área :</td>
            <td class="style3">
                
                <asp:Label ID="lblArea" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" 
                    style="width: 14%; height: 20px; font-weight: bold; font-size: 13px;" 
                    Text="N° Requerimiento :"></asp:Label>
                &nbsp;&nbsp;<asp:Label ID="lblRequerimiento" runat="server"></asp:Label>
                
            </td>
            <td style="height: 20px">
                <asp:Label ID="Label4" runat="server" 
                    style="width: 14%; height: 20px; font-weight: bold; font-size: 13px;" 
                    Text="Detalle Aprobación :"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 14%; height: 20px; font-weight: bold; font-size: 13px;">
                Moneda :</td>
            <td valign="middle" class="style3">
                <asp:Label ID="lblMoneda" runat="server"></asp:Label>
            </td>
            <td rowspan="5">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BorderColor="White" BorderStyle="None" DataSourceID="odsEstadoCotizacion" 
                    Font-Size="8pt" Width="445px">
                    <Columns>
                        <asp:BoundField DataField="NombrePersona" HeaderText="Nombre" ReadOnly="True" 
                            SortExpression="NombrePersona">
                        <ItemStyle HorizontalAlign="Center" Width="250px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FechaApruebaAnula" 
                            DataFormatString="{0:dd/MM/yyyy} - {0:HH:mm}" HeaderText="Fecha Aprobación" 
                            SortExpression="FechaApruebaAnula">
                        <ItemStyle HorizontalAlign="Center" Width="150px" />
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 14%; font-weight: bold; height: 20px; font-size: 13px;">
                Nombre Doc. :</td>
            <td class="style3">
                <asp:Label ID="lblNombre" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 14%; font-weight: bold; height: 20px; font-size: 13px;">
                <asp:Label ID="lblFecha" runat="server" Text="Fecha :"></asp:Label>
            </td>
            <td class="style3">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblFechaRegistro" runat="server"></asp:Label>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="width: 14%; font-weight: bold; height: 20px; font-size: 13px;">
                Estado Cotización:</td>
            <td class="style4">
                <asp:Label ID="lblEstado" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 14%; font-weight: bold; height: 20px; font-size: 13px;">
                Observaciones :</td>
            <td class="style4">
                <asp:Label ID="lblObservaciones" runat="server"></asp:Label>
               </td>
        </tr>
        </table>
    </asp:Panel>
</fieldset>

<fieldset class="jcv">
    <table border="0" cellspacing="0" cellpadding="0" class="tabla4">
        <tr>
            <td style="font-weight: bold; height: 20px; font-size: x-small;">
                <asp:GridView ID="gvDetalleCotizacion" runat="server" DataSourceID="odsDetalleReqCoti" 
                    AutoGenerateColumns="False" Font-Size="9pt" Width="910px">

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
            <td style="font-weight: bold; height: 20px; font-size: x-small;" align="center">
                &nbsp;</td>
        </tr>
        </table>
</fieldset>                   <asp:TextBox ID="txtValidar" runat="server" ReadOnly="True" Height="0px" 
                    Visible="False" Width="0px">0</asp:TextBox>
                <asp:ObjectDataSource ID="odsEstadoCotizacion" runat="server" 
                    SelectMethod="GetAllFromEstadoCotizacionByIdCotizacion" 
                    TypeName="SistFoncreagro.BussinesLogic.EstadoCotizacionBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="IdCotizacion" QueryStringField="IdCoti" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
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

                   <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                    <Windows>
                        <telerik:RadWindow ID="VentanaFormato" runat="server" Animation="Resize" 
                        AnimationDuration="200" Width="770px" 
                        Height="600px" Title="Formato Sole Source" Left="150px" ReloadOnShow="True" 
                        ShowContentDuringLoad="False" Modal="True" VisibleStatusbar="False">
                    </telerik:RadWindow>
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
    <style type="text/css">
        .style3
        {
            height: 20px;
            width: 359px;
        }
        .style4
        {
            height: 25px;
            width: 359px;
        }
    </style>
    </asp:Content>

