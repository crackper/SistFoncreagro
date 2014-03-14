<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmRequerimientoEditar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmRequerimientoEditar" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    var parametro = 0;
    var tipo = 0;

    function eliminarFila(tip) {
        var tipo = tip;

        if (tipo == 0) {
                var tabla1 = document.getElementById('tablaRequerimiento');
                tabla1.deleteRow(5);

            }
         }

    function CargarVentana(idDetalle, idProyecto, producto, est) {
        var oWnd = radopen("VentanaCentroCostoxDetalleReq.aspx?IdDetalle=" + idDetalle + "&IdProyecto=" + idProyecto + "&Producto=" + producto + "&Estado=" + est, "CentroCosto");
    }

    function CargarHistorico(IdReq) {
        var oWnd = radopen("VentanaHistoricoRequerimiento.aspx?IdReq=" + IdReq, "Historico");
    }

    function CargarAdjunto(id, el) {
        var oWnd = radopen("VentanaAdjuntarRequerimiento.aspx?IdReq=" + id + "&elim=" + el, "VentanaAdjunto");
    }
</script>
</telerik:RadCodeBlock>
    <fieldset>
                &nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;        
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:ModalPopupExtender ID="lbAnularReqModalPopupExtender" runat="server" 
                      BackgroundCssClass="FondoAplicacion" DynamicServicePath="" Enabled="True" 
                      OkControlID="lbCerrar" PopupControlID="panelAnular" 
                      TargetControlID="lbAnularOc">
                  </asp:ModalPopupExtender>

         <table width="60%">
             <tr>
                 <td width="10%">
         <asp:LinkButton ID="lbHistorico" runat="server" Text="Histórico" Visible="True" />
                 </td>
                 <td width="10%">
                <asp:LinkButton ID="lbAdjunto" runat="server"/>
                 </td>
                 <td width="15%">
              <asp:LinkButton ID="lbAnularOc" runat="server" 
             Text="Anular Requerimiento" />
                  </td>
                 <td width="25%">
                <asp:LinkButton ID="lbSolicitarAprobacion" runat="server">Solicitar Aprobación</asp:LinkButton>
                 </td>
             </tr>
         </table>

    </fieldset>
      <fieldset class="jcv">
       <legend class="legendJcv">REQUERIMIENTO DE COMPRA</legend>
       <asp:Panel ID="PanelEncabezado" runat="server">
    <table id="tablaRequerimiento" cellpadding="0" cellspacing="0">
              <tr>
                  <td align="left" style="width: 2%" class="Texto">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Requerido Por :</td>
                  <td style="height: 10px; width: 70%;">
                        <asp:Label ID="lblRequeridoPor" runat="server"></asp:Label>
                    </td>
              </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 20px;">
                           Nro. Requerimiento :</td>
                       <td style="height: 10px; width: 70%;">
                           <asp:Label ID="lblNroRequerimiento" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 20px;">
                           Tipo Requerimiento :</td>
                       <td style="height: 10px; width: 70%;">
                           <asp:Label ID="lblTipoRequerimiento" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 20px;">
                           Estado :</td>
                       <td style="height: 10px; width: 70%;">
                           <asp:Label ID="lblEstadoRequerimiento" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 20px;">
                           Fecha Requerimiento :</td>
                       <td style="height: 10px; width: 70%;">
                           <asp:Label ID="lblFechaRequerimiento" runat="server"></asp:Label>
                       </td>
                   </tr>
              <tr>
                  <td align="left" class="Texto" style="width: 2%">
                      &nbsp;</td>
                  <td align="left" class="Texto" 
                      style="height: 20px;" colspan="2">
                      <table border="0" cellpadding="0" cellspacing="0" style="width: 590px">
                          <tr>
                              <td align="right" class="style5">
                                  <asp:CheckBox ID="cbPeriodo" runat="server" AutoPostBack="True" Enabled="False" 
                                      Text=" Periodo  :" />
                              </td>
                              <td align="right" style="width: 13%">
                                  Inicio &nbsp;
                              </td>
                              <td>
                                  <telerik:RadDatePicker ID="rdpPeriodoInicio" Runat="server" Enabled="False" 
                                      ToolTip="Fecha Inicio" Width="150px">
                                  </telerik:RadDatePicker>
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Fin :&nbsp;<telerik:RadDatePicker ID="rdpPeriodoFin" Runat="server" 
                                      Enabled="False" ToolTip="Fecha Fin" Width="150px">
                                  </telerik:RadDatePicker>
                              </td>
                          </tr>
                          <tr>
                              <td align="right" rowspan="2" valign="middle" class="style5">
                                  <asp:CheckBox ID="cbRuta" runat="server" AutoPostBack="True" Enabled="False" 
                                      Text="Ruta  :" />
                              </td>
                              <td align="right" style="width: 13%">
                                  Origen &nbsp;
                              </td>
                              <td>
                                  <telerik:RadComboBox ID="rcbOrigen" Runat="server" 
                                      DataTextField="Nombre" DataValueField="IdRutaRequerimiento" Enabled="False" 
                                      Width="386px" DataSourceID="obsRuta">
                                  </telerik:RadComboBox>
                              </td>
                          </tr>
                          <tr>
                              <td align="right" style="width: 13%">
                                  Destino &nbsp;
                              </td>
                              <td>
                                  <telerik:RadComboBox ID="rcbDestino" Runat="server" DataTextField="Nombre" 
                                      DataValueField="IdRutaRequerimiento" Enabled="False" Width="386px" 
                                      DataSourceID="obsRuta">
                                  </telerik:RadComboBox>
                              </td>
                          </tr>
                      </table>

                  </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%" class="Texto">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Moneda :</td>
                  <td style="width: 70%;" class="tablaJcv">
                        <asp:DropDownList ID="ddlMoneda" runat="server" Width="447px" 
                            DataSourceID="odsMoneda" DataTextField="Nombre" DataValueField="IdMoneda">
                        </asp:DropDownList>
                    </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Área/Proyecto :</td>
                  <td style="width: 70%;" class="tablaJcv">
                        <telerik:RadComboBox ID="rcbProyecto" Runat="server" Width="447px" 
                            AutoPostBack="True" DataTextField="AreaProyecto" 
                            DataValueField="IdProyecto" AllowCustomText="True" 
                            EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                            MarkFirstMatch="True" ShowMoreResultsBox="True" ForeColor="Black">
                        </telerik:RadComboBox>
                    </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Centro de Costo :</td>
                  <td style="width: 70%;" class="tablaJcv">
                        <telerik:RadComboBox ID="rcbCentroCosto" Runat="server" AllowCustomText="True" 
                            DataSourceID="odsCentroCostoDetalle" DataTextField="CodigoElementoGasto" 
                            DataValueField="IdCCosto" EnableLoadOnDemand="True" 
                            EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                            ShowMoreResultsBox="True" Width="447px">
                        </telerik:RadComboBox>
                    </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Sustento :</td>
                  <td style="width: 70%;" class="tablaJcv">
                        <asp:TextBox ID="txtSustento" runat="server" Width="442px" 
                            ValidationGroup="Validar" CssClass="CajaTexto"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvSustento" runat="server" 
                            ControlToValidate="txtSustento" ErrorMessage="Ingrese el sustento." 
                            Font-Size="7pt" ValidationGroup="Validar"></asp:RequiredFieldValidator>
                    </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%">
                        <asp:TextBox ID="txtTipoCatalogoRequerimiento" runat="server" Visible="False" 
                            Width="0px">0</asp:TextBox>
                  </td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Observaciones :<br />
                        <br />
                        <br />
                    </td>
                  <td style="width: 70%; " class="tablaJcv">
                        <asp:TextBox ID="txtObservacion" runat="server" Height="49px" 
                            TextMode="MultiLine" Width="441px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="ibActualizar" runat="server" ImageUrl="~/img/Grabar.gif" 
                            style="height: 25px" ValidationGroup="Validar" />
                        </td>
              </tr>
                   <tr>
                       <td align="left" style="width: 2%">
                           <asp:TextBox ID="txtCentroCostoHabilitado" runat="server" Visible="False" 
                               Width="0px">0</asp:TextBox>
                       </td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 21px;">
                           <asp:Label ID="lbResponsable" runat="server" Text="Responsable :" 
                               Visible="False"></asp:Label>
                       </td>
                       <td style="width: 70%; " class="tablaJcv">
                           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                               BorderColor="White" BorderStyle="None" 
                               DataSourceID="odsListaEstadoRequerimiento" Width="447px">
                               <Columns>
                                   <asp:BoundField DataField="NombrePersona" HeaderText="Nombre" ReadOnly="True" 
                                       SortExpression="NombrePersona">
                                   <ItemStyle HorizontalAlign="Center" Width="250px" />
                                   </asp:BoundField>
                                   <asp:BoundField DataField="FechaApruebaAnula" DataFormatString="{0:dd/MM/yyyy} - {0:HH:mm}" 
                                       HeaderText="Fecha Aprobación" SortExpression="FechaApruebaAnula">
                                   <ItemStyle HorizontalAlign="Center" Width="150px" />
                                   </asp:BoundField>
                               </Columns>
                           </asp:GridView>
                       </td>
                   </tr>
              <tr>
                  <td style="width: 2%">
                        &nbsp;</td>
                  <td style="width: 13%;" class="Texto" align="center">
                    
                      &nbsp;</td>
                  <td style="width: 70%;" class="tablaJcv">
                    
                        &nbsp;</td>
              </tr>
          </table>
      </asp:Panel>
      </fieldset>  
     <fieldset class="jcv">
        <legend class="legendJcv">DETALLE REQUERIMIENTO</legend>
        <table class="tablaJcv">
          <tr>
              <td colspan="3">
                    <div style="overflow: scroll; width: 900px;">
                     <asp:GridView ID="gvDetalleRequerimiento" runat="server" 
                            AutoGenerateColumns="False" 
                            DataKeyNames="IdDetalleRequerimiento,codigoCatalogo,nombreCatalogo" 
                            DataSourceID="odsDetalleRequerimiento" 
                            Font-Size="8pt" Width="1200px">
                         <Columns>
                             <asp:ButtonField ButtonType="Image" CommandName="Eliminar" 
                                    FooterText="Eliminar" ImageUrl="~/img/Delete.gif">
                             <ItemStyle HorizontalAlign="Center" Width="15px" />
                             </asp:ButtonField>
                             <asp:BoundField DataField="IdCatalogo" HeaderText="IdCatalogo" 
                                    SortExpression="IdCatalogo" Visible="False" />
                             <asp:BoundField DataField="codigoCatalogo" HeaderText="Código" 
                                    SortExpression="codigoCatalogo">
                             <HeaderStyle HorizontalAlign="Center" Width="70px" />
                             <ItemStyle HorizontalAlign="Center" Width="70px" />
                             </asp:BoundField>
                             <asp:BoundField DataField="nombreCatalogo" HeaderText="Producto / Servicio" 
                                    SortExpression="nombreCatalogo">
                             <HeaderStyle Width="300px" />
                             </asp:BoundField>
                             <asp:TemplateField HeaderText="Observación" SortExpression="Observacion">
                                 <ItemTemplate>
                                     <asp:TextBox ID="txtIdDetReq" runat="server" BackColor="Info" 
                                            CssClass="TextoCentro" Text='<%# Bind("IdDetalleRequerimiento") %>' 
                                            Width="0px" Height="0px" ReadOnly="True" Visible="False"></asp:TextBox>
                                     <asp:TextBox ID="txtDetalleObservacion" runat="server" BackColor="Info" 
                                            CssClass="TextoCentro" Text='<%# Bind("observacion") %>' Width="200px" 
                                            Font-Size="8pt"></asp:TextBox>
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" Width="210px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Unidad" SortExpression="IdUnidadMedida">
                                 <ItemTemplate>
                                     <asp:DropDownList ID="ddlUnidadMedida" runat="server" 
                                            DataSourceID="odsUnidadMedida" DataTextField="Descripcion" 
                                            DataValueField="IdUnidadMedida" Height="19px" 
                                            SelectedValue='<%# Bind("IdUnidadMedida") %>' Width="80px">
                                     </asp:DropDownList>
                                 </ItemTemplate>
                                 <HeaderStyle HorizontalAlign="Center" />
                                 <ItemStyle HorizontalAlign="Center" Width="40px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Cantidad" SortExpression="Cantidad">
                                 <EditItemTemplate>
                                     <asp:Label ID="Label2" runat="server" Text='<%# Bind("Cantidad") %>'></asp:Label>
                                 </EditItemTemplate>
                                 <ItemTemplate>
                                     <asp:TextBox ID="txtCantidad" runat="server" BackColor="Info" 
                                            CssClass="TextoCentro" Text='<%# Bind("Cantidad") %>' Width="50px"></asp:TextBox>
                                 </ItemTemplate>
                                 <HeaderStyle HorizontalAlign="Center" />
                                 <ItemStyle HorizontalAlign="Center" Width="40px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Igv" SortExpression="AfectoIgv">
                                 <ItemTemplate>
                                     <asp:CheckBox ID="cbAfectoIgv" runat="server" 
                                            Checked='<%# Bind("AfectoIgv") %>' />
                                 </ItemTemplate>
                                 <HeaderStyle Width="20px" HorizontalAlign="Center" />
                                 <ItemStyle HorizontalAlign="Center" Width="20px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="C. Costo" SortExpression="">
                                 <ItemTemplate>
                                     <asp:LinkButton ID="lbCentroCosto" runat="server" Font-Size="8pt" 
                                            Text="C. Costo" />
                                 </ItemTemplate>
                                 <HeaderStyle Width="65px" />
                                 <ItemStyle HorizontalAlign="Center" Width="50px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="C. Costo" SortExpression="">
                                 <ItemTemplate>
                                     <telerik:RadComboBox ID="rcbCentroCostoDetalle" Runat="server" 
                                            DataSourceID="odsCentroCostoDetalle" DataTextField="CodigoElementoGasto" 
                                            DataValueField="IdCCosto" SelectedValue='<%# Bind("IdCentroCosto") %>' 
                                            AllowCustomText="True" EnableLoadOnDemand="True" EnableVirtualScrolling="True" 
                                            ItemsPerRequest="10" MarkFirstMatch="True" ShowMoreResultsBox="True" 
                                            Width="300px">
                                     </telerik:RadComboBox>
                                 </ItemTemplate>
                                 <HeaderStyle Width="65px" />
                                 <ItemStyle HorizontalAlign="Center" Width="50px" />
                             </asp:TemplateField>
                             <asp:BoundField DataField="PrecioCompra" DataFormatString="{0:n}" 
                                    HeaderText="P. Ref." SortExpression="PrecioCompra">
                             <HeaderStyle HorizontalAlign="Center" Width="70px" />
                             <ItemStyle HorizontalAlign="Center" Width="30px" />
                             </asp:BoundField>
                             <asp:BoundField DataField="Subtotal" DataFormatString="{0:n}" 
                                    HeaderText="Sub Total">
                             <HeaderStyle HorizontalAlign="Center" Width="70px" />
                             <ItemStyle HorizontalAlign="Center" Width="40px" />
                             </asp:BoundField>
                             <asp:CheckBoxField DataField="AfectoIgv" HeaderText="AfectoIgv" 
                                    SortExpression="AfectoIgv" Visible="False" />
                         </Columns>
                     </asp:GridView>
                    </div>
              </td>           
          </tr>
          <tr>
              <td style="width: 180px">
              </td>
              <td style="width: 622px">
                  &nbsp;</td>
              <td>
              </td>
          </tr>
          <tr>
              <td colspan="3">
                    <table class="tabla4" style="width: 900px" __designer:mapid="93">
                        <tr __designer:mapid="94">
                            <td class="TextoNegrita" style="width: 130px; height: 25px;" 
                                __designer:mapid="95">
                                Producto/Servicio :</td>
                            <td style="width: 700px; height: 25px;" __designer:mapid="96">
                                <telerik:RadComboBox ID="rcbProductoServicio" Runat="server" 
                                    DataSourceID="odsCatalogoBusqueda" DataTextField="CodigoDescripcion" 
                                    DataValueField="IdCatalogo" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" 
                                    style="margin-left: 0px" ValidationGroup="poducto" Width="650px" 
                                    EmptyMessage="Ingrese el producto o servicio...">
                                </telerik:RadComboBox>
                                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="rcbProductoServicio" 
                                    ErrorMessage="Ingrese el código o nombre del producto o servicio." 
                                    ValidationGroup="poducto" Font-Size="7pt">*</asp:RequiredFieldValidator>
                            </td>
                            <td style="height: 25px; width: 20px;" __designer:mapid="99">
                                <asp:LinkButton ID="lbAgregar" runat="server" ValidationGroup="poducto">Agregar</asp:LinkButton>
                            </td>
                        </tr>
                        <tr __designer:mapid="9b">
                            <td class="TextoNegrita" style="width: 130px; height: 10px;" 
                                __designer:mapid="9c">
                                &nbsp;</td>
                            <td style="width: 700px; height: 10px;" __designer:mapid="9d">
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                    ValidationGroup="poducto" Font-Size="8pt" Height="21px" />
                            </td>
                            <td style="height: 10px; width: 50px;" __designer:mapid="9f">
                                &nbsp;</td>
                        </tr>
                    </table>
              </td>
          </tr>
      </table>
   </fieldset>
        <asp:Panel ID="panelAnular" runat="server" CssClass="CajaDialogo" 
        Width="618px">
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <fieldset class="jcv">
<legend class="legendJcv">Anular Requerimiento de Compra</legend>
    <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="width: 65px; height: 30px;">
                Motivo :</td>
            <td style="height: 30px" align="right">
                <asp:LinkButton ID="lbCerrar" runat="server">Cerrar</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="width: 65px" valign="bottom">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtMotivoAnula" ErrorMessage="Ingrese motivo." Font-Size="8pt" 
                    ValidationGroup="Validar1"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="txtMotivoAnula" runat="server" Height="110px" TextMode="MultiLine" 
                    ValidationGroup="Validar1" Width="415px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 65px">
                &nbsp;</td>
            <td align="right">
                <asp:LinkButton ID="lbAnularRequerimientoR" runat="server" 
                    ValidationGroup="Validar1">Aceptar</asp:LinkButton>
            </td>
        </tr>
    </table>
</fieldset>
                </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="lbCerrar" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
</asp:Panel>
   <asp:ObjectDataSource ID="odsCentroCostoDetalle" runat="server" 
     SelectMethod="GetCCOSTOByIdProyecto" 
        TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
                <SelectParameters>
                <asp:ControlParameter ControlID="rcbProyecto" Name="_IdProyecto" 
            PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

    <asp:Timer ID="Timer1" runat="server">
    </asp:Timer>

    <asp:ObjectDataSource ID="obsRuta" runat="server" 
        SelectMethod="GetAllFromRutaRequerimiento" 
        TypeName="SistFoncreagro.BussinesLogic.RutaRequerimientoBL">
    </asp:ObjectDataSource>

                        <asp:ObjectDataSource ID="odsListaEstadoRequerimiento" runat="server" 
                            SelectMethod="GetAllFromEstadoRequerimientoByIdRequerimiento" 
                            
        TypeName="SistFoncreagro.BussinesLogic.EstadoRequerimientoBL">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="IdRequerimiento" QueryStringField="IdReq" 
                                    Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
               <asp:ObjectDataSource ID="odsMoneda" runat="server" 
                   SelectMethod="GetAllFromMoneda" 
                   TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>   
                <asp:ObjectDataSource ID="odsDetalleRequerimiento" runat="server" 
                    SelectMethod="GetAllFromDetalleRequerimientoByIdReq" 
                    TypeName="SistFoncreagro.BussinesLogic.DetalleRequerimientoBL" 
        OldValuesParameterFormatString="original_{0}">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="idRequerimiento" QueryStringField="IdReq" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                                <asp:ObjectDataSource ID="odsCatalogoBusqueda" runat="server" 
                                    SelectMethod="GetAllFromCatalogoByParametro" 
                                    
        TypeName="SistFoncreagro.BussinesLogic.CatalogoBL" 
        OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="txtTipoCatalogoRequerimiento" Name="tipo" 
                                            PropertyName="Text" Type="Int32" />
                                        <asp:Parameter DefaultValue="$" Name="parametro" Type="String" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
               <asp:ObjectDataSource ID="odsUnidadMedida" runat="server" 
        SelectMethod="GetAllFromUnidadMedida" 
        TypeName="SistFoncreagro.BussinesLogic.UnidadMedidaBL">
    </asp:ObjectDataSource>
               <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
              <Windows>
                <telerik:RadWindow ID="CentroCosto" runat="server" Title="Agregar C. Costo" Height="300px"
                    Width="705px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                    Modal="true" />
                     <telerik:RadWindow ID="Historico" runat="server" Title="Histórico" Height="300px"
                    Width="800px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                    Modal="true" />
                   <telerik:RadWindow ID="VentanaAdjunto" runat="server" 
                            Title="Adjuntar archivo" Height="450px"
                        Width="705px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" />
            </Windows>
                </telerik:RadWindowManager>
              <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
                  Skin="Default">
              </telerik:RadAjaxLoadingPanel>
                 <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                     <AjaxSettings>
                         <telerik:AjaxSetting AjaxControlID="cbRuta">
                         </telerik:AjaxSetting>
                         <telerik:AjaxSetting AjaxControlID="rcbDestino">
                         </telerik:AjaxSetting>
                         <telerik:AjaxSetting AjaxControlID="rcbProyecto">
                             <UpdatedControls>
                                 <telerik:AjaxUpdatedControl ControlID="rcbCentroCosto" />
                             </UpdatedControls>
                         </telerik:AjaxSetting>
                         <telerik:AjaxSetting AjaxControlID="ibActualizar">
                             <UpdatedControls>
                                 <telerik:AjaxUpdatedControl ControlID="PanelEncabezado" 
                                     LoadingPanelID="RadAjaxLoadingPanel1" />
                                 <telerik:AjaxUpdatedControl ControlID="gvDetalleRequerimiento" 
                                     LoadingPanelID="RadAjaxLoadingPanel1" />
                             </UpdatedControls>
                         </telerik:AjaxSetting>
                         <telerik:AjaxSetting AjaxControlID="gvDetalleRequerimiento">
                             <UpdatedControls>
                                 <telerik:AjaxUpdatedControl ControlID="rcbProyecto" />
                             </UpdatedControls>
                         </telerik:AjaxSetting>
                         <telerik:AjaxSetting AjaxControlID="lbAgregar">
                             <UpdatedControls>
                                 <telerik:AjaxUpdatedControl ControlID="gvDetalleRequerimiento" />
                             </UpdatedControls>
                         </telerik:AjaxSetting>
                         <telerik:AjaxSetting AjaxControlID="Timer1">
                             <UpdatedControls>
                                 <telerik:AjaxUpdatedControl ControlID="lbSolicitarAprobacion" />
                             </UpdatedControls>
                         </telerik:AjaxSetting>
                     </AjaxSettings>
    </telerik:RadAjaxManager>
    </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .style5
        {
            width: 21%;
        }
        </style>
</asp:Content>
