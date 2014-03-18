<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmOrdenCompraPorRecepcionar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmOrdenCompraPorRecepcionar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function eliminarFila(param) {
        var parametro = param;
        if (parametro == 1) {
            var tabla = document.getElementById('tablaOrdenCompra');
            tabla.deleteRow(4);
            tabla.deleteRow(4);
        }
    }

    function ValidarDatos(cantSolicitada, cantRecepcionada) {
        var canSolicitada = document.getElementById(cantSolicitada);
        var cantRecepcion = document.getElementById(cantRecepcionada);
        if (cantRecepcion.value == '') {
            radalert('La cantidad de recepción debe tener un valor.', 400, 100, 'Alerta');
            cantRecepcion.value = '0';
        }
        if ((cantRecepcion.value * 1) > (canSolicitada.value * 1)) {
            radalert('La cantidad recepcionada NO puede ser mayor que la cantidad solicitada.', 400, 100, 'Alerta');
            cantRecepcion.value = canSolicitada.value;
        }
        if ((cantRecepcion.value * 1) > -1) {
        }
        else {
            radalert('Verificar datos ingresados.', 400, 100, 'Alerta');
            cantRecepcion.value = canSolicitada.value;
        }

    }

    function ValidarDatosParcial(cantSolicitada, cantRecepcionada, cantPend) {
        var canSolicitada = document.getElementById(cantSolicitada);
        var cantRecepcion = document.getElementById(cantRecepcionada);
        var cantPendiente = document.getElementById(cantPend);

        if (cantPendiente.value == '') {
            radalert('La cantidad pendiente debe tener un valor.', 400, 100, 'Alerta');
            cantPendiente.value = '0';
        }

        if ((cantPendiente.value * 1) > ((canSolicitada.value * 1) - (cantRecepcion.value * 1))) {
            radalert('Verificar la cantidad pendiente.', 400, 100, 'Alerta');
            cantPendiente.value = ((canSolicitada.value * 1) - (cantRecepcion.value * 1));
        }

        if ((cantPendiente.value * 1) > -1) {
        }
        else {
            radalert('Verificar datos ingresados.', 400, 100, 'Alerta');
            cantRecepcion.value = ((canSolicitada.value * 1) - (cantRecepcion.value * 1)); ;
        }
    }

    function recepcionarOrdenCompra(parametro) {
        if (parametro == 1) {//RECEPCION PARCIAL

            document.getElementById('ctl00_MainContent_txtValidarRecepcion').value = '0';

            var valDoc = document.getElementById('ctl00_MainContent_txtDocumentoRecepcion');
            if (valDoc.value == '') {
                radalert('Debe ingresar un documento de referencia.', 400, 100, 'Alerta');
                return false;
            }
            var gridViewCtlId = '<%= gvDetalleOrdenCompra.ClientID %>';
            var tabla = document.getElementById(gridViewCtlId);
            var filas = tabla.rows.length;
            var a = tabla.attributes.length;

            for (i = 0; i < filas - 2; i++) {
                if (i < 8) {
                    var indice = '0' + (i + 2);
                }
                else {
                    var indice = (i + 2);
                }

                var cantSolic = document.getElementById('ctl00_MainContent_gvDetalleOrdenCompra_ctl' + indice + '_txtCantidadSolicitada');
                var cantComp = document.getElementById('ctl00_MainContent_gvDetalleOrdenCompra_ctl' + indice + '_txtCantidadComprada');
                var cantPendiente = document.getElementById('ctl00_MainContent_gvDetalleOrdenCompra_ctl' + indice + '_txtCantidadPendiente');

                if ((cantPendiente.value * 1) < ((cantSolic.value * 1) - (cantComp.value * 1))) {
                    document.getElementById('ctl00_MainContent_txtValidarRecepcion').value = '1'
                }
            }

            var valOrden = document.getElementById('ctl00_MainContent_txtValidarRecepcion');

            if (valOrden.value == '1') {
                radconfirm('La cantidad pendiente es menor. ¿Es una recepción parcial?', confirmaRecepcion, 300, 150, null, 'Recepción parcial');
            }
            else {
                radconfirm('¿Verificó las cantidades pendientes a recepcionar?', confirmaRecepcionCompleta, 300, 150, null, 'Recepcionar O/C');
            }
        }
        else {//RECEPCION NORMAL
            document.getElementById('ctl00_MainContent_txtValidarRecepcion').value = '0';

            var valDoc = document.getElementById('ctl00_MainContent_txtDocumentoRecepcion');
            if (valDoc.value == '') {
                radalert('Debe ingresar un documento de referencia.', 400, 100, 'Alerta');
                return false;
            }
            var gridViewCtlId = '<%= gvDetalleOrdenCompra.ClientID %>';
            var tabla = document.getElementById(gridViewCtlId);
            var filas = tabla.rows.length;
            var a = tabla.attributes.length;

            for (i = 0; i < filas - 2; i++) {
                if (i < 8) {
                    var indice = '0' + (i + 2);
                }
                else {
                    var indice = (i + 2);
                }

                var cantSolic = document.getElementById('ctl00_MainContent_gvDetalleOrdenCompra_ctl' + indice + '_txtCantidadSolicitada');
                var cantComp = document.getElementById('ctl00_MainContent_gvDetalleOrdenCompra_ctl' + indice + '_txtCantidadComprada');

                if ((cantComp.value * 1) < (cantSolic.value * 1)) {
                    document.getElementById('ctl00_MainContent_txtValidarRecepcion').value = '1'
                }
            }

            var valOrden = document.getElementById('ctl00_MainContent_txtValidarRecepcion');

            if (valOrden.value == '1') {
                radconfirm('La cantidad comprada es menor. ¿Es una recepción parcial?', confirmaRecepcion, 300, 150, null, 'Recepción parcial');
            }
            else {
                radconfirm('¿Verificó las cantidades a recepcionar?', confirmaRecepcionCompleta, 300, 150, null, 'Recepcionar O/C');
            }
        }
    }

    function confirmaRecepcion(arg) {
        if (arg) {
            $find("<%= RadAjaxManager1.ClientID%>").ajaxRequest("RecepcionParcial");
        }
        else {
            radconfirm('La cantidad comprada es menor. ¿Desea recepcionar por completo la O/C?', confirmaRecepcionCompleta, 300, 150, null, 'Recepcionar O/C');
        }
    }

    function confirmaRecepcionCompleta(arg) {
        if (arg) {
            $find("<%= RadAjaxManager1.ClientID%>").ajaxRequest("RecepcionCompleta");
        }
    }

    function CargarVentana(idDetalle, idProyecto) {
        var oWnd = radopen("VentanaCentroCostoxDetalleReq.aspx?IdDetalle=" + idDetalle + "&IdProyecto=" + idProyecto, "CentroCosto");
    }

</script>
</telerik:RadCodeBlock>
     <asp:TextBox ID="txtValidarOrden" runat="server" Visible="False" Width="0px" Height="0px"></asp:TextBox>
      <fieldset class="jcv">
       <legend class="legendJcv">ORDEN DE COMPRA</legend>
                 <table id="tablaOrdenCompra" class="tabla5" cellpadding="0" 
              cellspacing="0" style="width: 100%">
          <tr>
              <td align="left" style="width: 2%" class="Texto">
                    &nbsp;</td>
              <td style="width: 14%; font-weight: 600;">
                    &nbsp;</td>
              <td style="width: 29%;">
                    &nbsp;</td>
              <td style="width: 15%; font-weight: 600; height: 20px;">
                  &nbsp;</td>
              <td style="width: 32%;">
                  &nbsp;</td>
          </tr>
          <tr>
              <td align="left" style="width: 2%" class="Texto">
                    &nbsp;</td>
              <td style="width: 14%; font-weight: 600;" 
                  class="Texto">
                    N° Orden Compra :</td>
              <td style="width: 29%; ">
                    <asp:Label ID="lblNumeroOc" runat="server"></asp:Label>
                </td>
              <td style="font-weight: 600; width: 14%; height: 20px;">
                       N° Requerimiento :</td>
              <td style="width: 32%; ">
                       <asp:Label ID="lblNumeroRequerimiento" runat="server"></asp:Label>
              </td>
          </tr>
               <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       &nbsp;</td>
                   <td class="Texto" 
                       style="width: 14%; font-weight: 600;">
                       Tipo Orden Compra :</td>
                   <td style="width: 29%; ">
                       <asp:Label ID="lblTipoOc" runat="server"></asp:Label>
                   </td>
                   <td style="width: 14%; font-weight: 600; height: 20px;">
                  Requerido Por :</td>
                   <td style="width: 32%; ">
                  <asp:Label ID="lblRequeridoPor" runat="server"></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       &nbsp;</td>
                   <td class="Texto" 
                       style="width: 14%; font-weight: 600;">
                       Área / Proyecto :</td>
                   <td colspan="3">
                       <asp:Label ID="lblAreaProyecto" runat="server" Font-Size="9pt"></asp:Label>
                   </td>
               </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td class="Texto" 
                           style="width: 14%; font-weight: 600;">
                           Periodo :&nbsp;&nbsp;</td>
                       <td colspan="3" style="height: 19px; width: 80%;">
                           <asp:Label ID="lblPeriodo" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td class="Texto" 
                           style="width: 14%; font-weight: 600;">
                           Ruta :&nbsp;&nbsp;</td>
                       <td colspan="3" style="height: 19px; width: 80%;">
                           <asp:Label ID="lblOrigen" runat="server"></asp:Label>
                       </td>
                   </tr>
          <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       &nbsp;</td>
                   <td class="Texto" 
                       style="width: 14%; font-weight: 600;">
                       Estado :</td>
                   <td style="width: 29%; height: 19px;">
                       <asp:Label ID="lblEstadoOrdenCompra" runat="server"></asp:Label>
                   </td>
                   <td style="width: 14%; font-weight: 600; height: 20px;">
                       Moneda :</td>
                   <td style="width: 32%; ">
                       <asp:Label ID="lblMoneda" runat="server"></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       &nbsp;</td>
                   <td class="Texto" 
                       style="width: 14%; font-weight: 600;">
                       Proveedor :</td>
                   <td style="height: 19px;" colspan="3">
                       <asp:Label ID="lblProveedorTexto" runat="server"></asp:Label>
                   </td>
               </tr>
                     <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       &nbsp;</td>
                   <td class="Texto" 
                       style="width: 14%; font-weight: 600;">
                       Tipo Pago :</td>
                   <td style="width: 29%; height: 20px;" valign="middle">
                       <asp:Label ID="lblTipoPago" runat="server"></asp:Label>
                   </td>
                   <td style="width: 14%; font-weight: 600; height: 20px;">
                       % Anticipo :</td>
                   <td style="width: 32%; height: 20px;" valign="middle">
                       <asp:Label ID="lblAnticipo" runat="server"></asp:Label>
                   </td>
               </tr>
          <tr>
              <td align="left" style="width: 2%; height: 29px;">
                    </td>
              <td style="width: 14%; font-weight: 600;" 
                  class="Texto">
                    Observaciones :<br />
                </td>
              <td colspan="3" style="width: 80%; height: 40px;">
                    <asp:TextBox ID="txtObservacion" runat="server" Height="37px" 
                        TextMode="MultiLine" Width="498px" BorderColor="White"></asp:TextBox>
                </td>
          </tr>
                   <tr>
                       <td align="left" style="width: 2%">
                       </td>
                       <td class="Texto" 
                           style="width: 14%; font-weight: 600;" rowspan="3">
                           <asp:Label ID="lbResponsable" runat="server" Text="Responsable :"></asp:Label>
                       </td>
                       <td colspan="3" style="width: 80%;" rowspan="3">
                           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                               BorderColor="White" BorderStyle="None" 
                               DataSourceID="odsListaEstadoOrdenCompra" Width="500px">
                               <Columns>
                                   <asp:BoundField DataField="NombrePersona" HeaderText="Nombre" ReadOnly="True" 
                                       SortExpression="NombrePersona">
                                   <ItemStyle HorizontalAlign="Center" Width="250px" />
                                   </asp:BoundField>
                                   <asp:BoundField DataField="FechaApruebaAnula" DataFormatString="{0:dd/MM/yyyy}" 
                                       HeaderText="Fecha Aprobación" SortExpression="FechaApruebaAnula">
                                   <ItemStyle HorizontalAlign="Center" Width="150px" />
                                   </asp:BoundField>
                               </Columns>
                           </asp:GridView>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" style="width: 2%">
                       </td>
                   </tr>
                                      <tr>
                       <td align="left" style="width: 2%">
                       </td>
                   </tr>
          <tr>
              <td style="width: 15px">
                    &nbsp;</td>
              <td style="width: 14%; font-weight: 600;">
                  <asp:TextBox ID="txtValidarRecepcion" runat="server" Width="0px" 
                      BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="White" 
                      Height="0px"></asp:TextBox>
              </td>
              <td colspan="3">
                  <asp:TextBox ID="txtIgv" runat="server" Height="0px" Visible="False" 
                      Width="0px"></asp:TextBox>
              </td>
          </tr>
      </table>      
      </fieldset>
     <fieldset class="jcv">
        <legend class="legendJcv">DETALLE ORDEN DE COMPRA</legend>
            <asp:GridView ID="gvDetalleOrdenCompra" runat="server" 
             AutoGenerateColumns="False" Width="905px" 
             DataKeyNames="IdDetalleOrdenCompra" ShowFooter="True" Font-Size="9pt">
            <Columns>
                <asp:TemplateField SortExpression="IdDetalleOrdenCompra">
                    <EditItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("IdDetalleOrdenCompra") %>'></asp:Label>
                    </EditItemTemplate>
                         <ItemTemplate>
                    <asp:TextBox ID="txtIdDetalleOrden" runat="server" BackColor="Info" CssClass="TextoCentro"
                        Text='<%# Bind("IdDetalleOrdenCompra") %>' Width="0px" Visible="False"></asp:TextBox>
                     </ItemTemplate>
                        <ControlStyle/>
                        <FooterStyle/>
                        <HeaderStyle Width="1px" />
                        <ItemStyle Width="1px" />
                </asp:TemplateField>
                <asp:BoundField DataField="IdDetalleOrdenCompra" 
                    HeaderText="IdDetalleOrdenCompra" 
                    SortExpression="IdDetalleOrdenCompra" Visible="False" >
                    <ControlStyle Font-Size="0px" ForeColor="White" />
                <FooterStyle Font-Size="0px" ForeColor="White" />
                <HeaderStyle Font-Size="0px" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="codigoCatalogo" HeaderText="Código" 
                    SortExpression="codigoCatalogo" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="75px" />
                </asp:BoundField>
                <asp:BoundField DataField="nombreCatalogo" HeaderText="Producto / Servicio" 
                    SortExpression="nombreCatalogo" >
                    <HeaderStyle Width="300px" />
                </asp:BoundField>
                <asp:BoundField DataField="unidadMedidaAbreviacion" HeaderText="Unidad" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="55px" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Cant. Solicitada" 
                    SortExpression="CantidadSolicitada">
                <ItemTemplate>
                    <asp:TextBox ID="txtCantidadSolicitada" runat="server" BackColor="Info" CssClass="TextoCentro"
                        Text='<%# Bind("CantidadSolicitada", "{0:N}") %>' Width="70px" 
                        ReadOnly="True" Enabled="<%# False %>"></asp:TextBox>
                </ItemTemplate>
                    <HeaderStyle Font-Size="7pt" />
                <ItemStyle HorizontalAlign="Center" Width="70px" />
                </asp:TemplateField>
               <asp:TemplateField HeaderText="Cant. Recepcionada" 
                    SortExpression="CantidadComprada">
                <ItemTemplate>
                    <asp:TextBox ID="txtCantidadComprada" runat="server" BackColor="Info" CssClass="TextoCentro"
                        Text='<%# Bind("CantidadComprada", "{0:N}") %>' Width="70px" 
                        Enabled="<%# RecepcionParcial() %>"></asp:TextBox>
                </ItemTemplate>
                <FooterTemplate>
                    &nbsp;&nbsp; <asp:Label ID="lblSubtotal1" runat="server" Text="Sub Total :"></asp:Label><br />
                    &nbsp; <asp:Label ID="lblIgv1" runat="server" Text="I.G.V. :"></asp:Label><br />
                    &nbsp; <asp:Label ID="lblTotal1" runat="server" Text="Total :"></asp:Label>
                </FooterTemplate>
                <FooterStyle HorizontalAlign="Center" />
                   <HeaderStyle Font-Size="7pt" />
                <ItemStyle HorizontalAlign="Center" Width="70px" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cant. Recibida" SortExpression="CantidadPendienteNumero" 
                    Visible="False">
                <ItemTemplate>
                    <asp:TextBox ID="txtCantidadPendiente" runat="server" BackColor="Info" CssClass="TextoCentro"
                        Text='<%# Bind("CantidadPendienteNumero", "{0:N}") %>' Width="70px" 
                        Enabled='<%# DesHabilitar(Eval("CantidadPendienteNumero")) %>'></asp:TextBox>
                </ItemTemplate>
                <FooterTemplate>
                    &nbsp;&nbsp; <asp:Label ID="lblSubtotal2" runat="server" Text="Sub Total :"></asp:Label><br />
                    &nbsp; <asp:Label ID="lblIgv2" runat="server" Text="I.G.V. :"></asp:Label><br />
                    &nbsp; <asp:Label ID="lblTotal2" runat="server" Text="Total :"></asp:Label>
                </FooterTemplate>
                <FooterStyle HorizontalAlign="Center" />
                    <HeaderStyle Font-Size="7pt" />
                <ItemStyle HorizontalAlign="Center" Width="70px" />
                </asp:TemplateField>
             <asp:TemplateField HeaderText="P. Compra" SortExpression="PrecioCompra">
                <ItemTemplate>
                    <asp:Label ID="lblPCompra" runat="server" 
                        Text='<%# Eval("PrecioCompra", "{0:N}") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" Width="60px" />
                <ItemStyle HorizontalAlign="Right" />
                <FooterTemplate>
                    <%# subTotalMostrar().ToString("N2")%><br />
                    <%# igvMostrar().ToString("N2")%><br />
                    <%# totalMostrar().ToString("N2")%>                    
                </FooterTemplate>
                <FooterStyle HorizontalAlign="Right" />
            </asp:TemplateField>
               <asp:TemplateField HeaderText="C. Costo" SortExpression="" Visible="False">
                    <ItemTemplate>
                    <asp:LinkButton ID="lbCentroCosto" Text="Centro Coto" runat="server" 
                            Font-Size="8pt"/>
                    </ItemTemplate>
                    <HeaderStyle Width="60px" />
                    <ItemStyle HorizontalAlign="Center" Width="60px" />
                </asp:TemplateField>
            </Columns>
            </asp:GridView>
         </fieldset>
         
<asp:Panel ID="PanelRecepcion" runat="server">
     <fieldset>
         <table style="width: 100%">
             <tr>
                 <td width="22%">
                     &nbsp;</td>
                 <td align="right" width="55%">
                     Documento:&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 
                     <asp:TextBox ID="txtDocumentoRecepcion" runat="server" Width="250px"></asp:TextBox>
                 </td>
                 <td align="right" width="23%">
                     <asp:LinkButton ID="lbRecepcionarOrdenCompra" runat="server">Recepcionar orden de compra</asp:LinkButton>
                 </td>
             </tr>
         </table>
    </fieldset>
</asp:Panel>
         <asp:ObjectDataSource ID="odsDetalleOrdenCompra" runat="server">
         </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsListaEstadoOrdenCompra" runat="server" 
        SelectMethod="GetAllFromEstadoOrdenCompraByIdOrdenCompra" 
        TypeName="SistFoncreagro.BussinesLogic.EstadoOrdenCompraBL">
        <SelectParameters>
            <asp:QueryStringParameter Name="IdOrdenCompra" QueryStringField="IdOrdenCompra" 
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsTipoPago" runat="server" 
        SelectMethod="GetAllFromTipoPago" 
        TypeName="SistFoncreagro.BussinesLogic.TipoPagoBL"></asp:ObjectDataSource>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
               </asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>


