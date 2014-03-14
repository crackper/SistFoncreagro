<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmRequerimientoAprobar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmRequerimientoAprobar" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    var parametro = 0;
    var tipo = 0;

    function eliminarFila(param, tip) {
        var parametro = param;
        var tipo = tip;

        if (parametro == 2) {
            var tabla = document.getElementById('tablaRequerimiento');
            tabla.deleteRow(10);
            tabla.deleteRow(10);
        }
        else {
            if (parametro == 9) {
            }
            else {
                var tabla = document.getElementById('tablaRequerimiento');
                tabla.deleteRow(11);
            }
        }

        if (tipo == 0) {
            var tabla1 = document.getElementById('tablaRequerimiento');
            tabla1.deleteRow(5);

        }
    }

    function CargarVentana(idDetalle, idProyecto, producto) {
        var oWnd = radopen("VentanaCentroCostoxDetalleReq.aspx?IdDetalle=" + idDetalle + "&IdProyecto=" + idProyecto + "&Producto=" + producto, "CentroCosto");
    }
    
</script>
</telerik:RadCodeBlock>
    <fieldset>
                <asp:LinkButton ID="lbAprobarRequerimiento" runat="server" Visible="False">Aprobar Requerimiento</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lbAnularRequerimiento" runat="server" Visible="False">Anular Requerimiento</asp:LinkButton>
    </fieldset>
      <fieldset class="jcv">
       <legend class="legendJcv">REQUERIMIENTO DE COMPRA</legend>
       <asp:Panel ID="PanelEncabezado" runat="server">
    <table id="tablaRequerimiento" class="tabla4" cellpadding="0" cellspacing="0">
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
                      style="height: 20px; width: 70%;" colspan="2">
                      <table border="0" cellpadding="0" cellspacing="0">
                          <tr>
                              <td align="right" style="width: 126.5px; font-weight: bold; height: 22px;">
                                  Periodo :</td>
                              <td align="right" style="width: 10.5px; ">
                                  &nbsp;</td>
                              <td align="left" style="width: 500px; height: 22px;">
                                  <asp:Label ID="lblPeridoInicio" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td align="right" style="width: 126.5px; font-weight: bold;" rowspan="2" 
                                  valign="middle">
                                  Ruta :</td>
                              <td align="right" rowspan="2" style="width: 10.5px; " valign="middle">
                                  &nbsp;</td>
                              <td align="left" style="width: 500px; height: 22px;">
                              <asp:Label ID="lblOrigen" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td align="left" style="width: 500px; height: 22px;">
                                    <asp:Label ID="lblDestino" runat="server"></asp:Label>
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
                        <asp:Label ID="lblMoneda" runat="server"></asp:Label>
                    </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Área/Proyecto :</td>
                  <td style="width: 70%;" class="tablaJcv">
                        <asp:Label ID="lblAreaProyecto" runat="server"></asp:Label>
                    </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Sustento :</td>
                  <td style="width: 70%;" class="tablaJcv">
                        <asp:Label ID="lblSustento" runat="server"></asp:Label>
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
                            TextMode="MultiLine" Width="441px" ReadOnly="True"></asp:TextBox>
                        </td>
              </tr>
                   <tr>
                       <td align="left" style="width: 2%">
                           <asp:TextBox ID="txtCentroCostoHabilitado" runat="server" Visible="False" 
                               Width="0px">0</asp:TextBox>
                       </td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 21px;">
                           <asp:Label ID="lblJefeArea" runat="server" Font-Bold="True" 
                               Text="Jefe Área/Proyecto :"></asp:Label>
                       </td>
                       <td style="width: 70%; " class="tablaJcv">
                           <asp:Label ID="lblNombreJefeAreaProyecto" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 20px;">
                           <asp:Label ID="lblAdministracion" runat="server" Font-Bold="True" 
                               Text="Administración :"></asp:Label>
                       </td>
                       <td style="width: 70%; " class="tablaJcv">
                           <asp:Label ID="lblNombreResponsableAdministracion" runat="server"></asp:Label>
                       </td>
                   </tr>
              <tr>
                  <td style="width: 2%">
                        <asp:TextBox ID="txtIdProyecto" runat="server" BorderStyle="None" Height="0px" 
                            ReadOnly="True" Visible="False" Width="0px"></asp:TextBox>
                  </td>
                  <td style="width: 13%;" class="Texto">
                    
                  </td>
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
                            DataSourceID="odsDetalleRequerimiento" EnableModelValidation="True" 
                            Font-Size="9pt" Width="1100px">
                            <Columns>
                                <asp:TemplateField SortExpression="IdDetalleRequerimiento">
                                    <EditItemTemplate>
                                        <asp:Label ID="Label1" runat="server" 
                                            Text='<%# Bind("IdDetalleRequerimiento") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtIdDetReq" runat="server" BackColor="Info" 
                                            CssClass="TextoCentro" Text='<%# Bind("IdDetalleRequerimiento") %>' Width="0px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ControlStyle BorderStyle="None" BorderWidth="0pt" Font-Size="0pt" 
                                        ForeColor="White" Width="0pt" />
                                    <FooterStyle Font-Size="0pt" ForeColor="White" Width="0pt" />
                                    <ItemStyle Width="1px" />
                                </asp:TemplateField>
                                <asp:ButtonField ButtonType="Image" CommandName="Eliminar" 
                                    FooterText="Eliminar" ImageUrl="~/img/Delete.gif">
                                <ItemStyle HorizontalAlign="Center" Width="15px" />
                                </asp:ButtonField>
                                <asp:BoundField DataField="IdCatalogo" HeaderText="IdCatalogo" 
                                    SortExpression="IdCatalogo" Visible="False" />
                                <asp:BoundField DataField="codigoCatalogo" HeaderText="Código" 
                                    SortExpression="codigoCatalogo">
                                <HeaderStyle HorizontalAlign="Center" Width="75px" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="nombreCatalogo" HeaderText="Producto / Servicio" 
                                    SortExpression="nombreCatalogo">
                                <HeaderStyle Width="300px" />
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="Observación" SortExpression="Observacion">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtDetalleObservacion" runat="server" BackColor="Info" 
                                            CssClass="TextoCentro" Text='<%# Bind("observacion") %>' Width="200px" 
                                            ReadOnly="True"></asp:TextBox>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="210px" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="UnidadMedidaDetalle" HeaderText="Unidad">
                                <HeaderStyle HorizontalAlign="Center" Width="65px" />
                                <ItemStyle HorizontalAlign="Center" Width="25px" />
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="Cantidad" SortExpression="Cantidad">
                                    <EditItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Cantidad") %>'></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtCantidad" runat="server" BackColor="Info" 
                                            CssClass="TextoCentro" Text='<%# Bind("Cantidad") %>' Width="50px"></asp:TextBox>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="40px" />
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
                                <asp:TemplateField HeaderText="Igv" SortExpression="AfectoIgv">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="cbAfectoIgv" runat="server" 
                                            Checked='<%# Bind("AfectoIgv") %>' />
                                    </ItemTemplate>
                                    <HeaderStyle Width="65px" />
                                    <ItemStyle HorizontalAlign="Center" Width="30px" />
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
                                            DataSourceID="odsCentroCostoDetalle" DataTextField="Codigo" 
                                            DataValueField="IdCCosto" SelectedValue='<%# Bind("IdCentroCosto") %>'>
                                        </telerik:RadComboBox>
                                        <asp:ObjectDataSource ID="odsCentroCostoDetalle" runat="server" 
                                            SelectMethod="GetCCOSTOByIdProyecto" 
                                            TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="txtIdProyecto" Name="_IdProyecto" 
                                                    PropertyName="Text" Type="Int32" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                                    </ItemTemplate>
                                    <HeaderStyle Width="65px" />
                                    <ItemStyle HorizontalAlign="Center" Width="50px" />
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <br />
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
                  &nbsp;</td>
          </tr>
      </table>
   </fieldset>
                <asp:ObjectDataSource ID="odsDetalleRequerimiento" runat="server" 
                    SelectMethod="GetAllFromDetalleRequerimientoByIdReq" 
                    TypeName="SistFoncreagro.BussinesLogic.DetalleRequerimientoBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="idRequerimiento" QueryStringField="IdReq" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
               <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
              <Windows>
                <telerik:RadWindow ID="CentroCosto" runat="server" Title="Editing record" Height="300px"
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
                     </AjaxSettings>
    </telerik:RadAjaxManager>
    </asp:Content>

