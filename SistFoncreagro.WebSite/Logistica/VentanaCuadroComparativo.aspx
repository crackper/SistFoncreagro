<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaCuadroComparativo.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaCuadroComparativo" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    var parametro = 0;
    var tipo = 0;

    function CargarVentana(nombre) {
        window.open("../Archivos/Logistica/Requerimientos/" + nombre, nombre, "width=800, height=500")
        //        window.open("../Archivos1/Logistica/" + nombre, nombre, "width=800, height=500")    
    }
</script>
</telerik:RadCodeBlock>
<head id="Head1" runat="server">
    <title></title>
</head>
<body style="width: 716px">
   <form id="form1" runat="server">
     <fieldset style="width: 720px">       
          <table style="width: 645px">
               <tr>
                <td>
                    Cuadro Comparativo
                </td>
               </tr>
              <tr>
                  <td>
                <asp:GridView ID="gvDetalleCotizacion" runat="server" DataSourceID="odsDetalleReqCoti" 
                    AutoGenerateColumns="False" Font-Size="8pt" Width="710px">

<SortedAscendingCellStyle BackColor="#F7F7F7"></SortedAscendingCellStyle>

<SortedAscendingHeaderStyle BackColor="#487575"></SortedAscendingHeaderStyle>

<SortedDescendingCellStyle BackColor="#E5E5E5"></SortedDescendingCellStyle>

<SortedDescendingHeaderStyle BackColor="#275353"></SortedDescendingHeaderStyle>
                <Columns>
                <asp:BoundField DataField="IdCatalogo" HeaderText="IdCatalogo" 
                    SortExpression="IdCatalogo" Visible="False" />

               <asp:BoundField DataField="codigoCatalogo" HeaderText="CÓDIGO" 
                    SortExpression="codigoCatalogo" >
                <HeaderStyle HorizontalAlign="Center" Width="75px" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="nombreCatalogo" HeaderText="PROD. / SERV." 
                    SortExpression="nombreCatalogo" >
               <HeaderStyle Width="300px" />
                    <ItemStyle Font-Size="9pt" />
                </asp:BoundField>
                <asp:BoundField DataField="UnidadMedidaDetalle" HeaderText="UNIDAD" >
                <HeaderStyle HorizontalAlign="Center" Width="30px" />
                <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:BoundField>
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
                                    Width="320px" DataKeyNames="IdProveedor" Font-Size="8pt" 
                                    onrowdatabound="gvProveedor_RowDataBound">
                                <Columns>
                                    <asp:BoundField DataField="NombreProveedor" HeaderText="Razón Social" 
                                        ReadOnly="True" SortExpression="NombreProveedor" >
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" Width="200px" />
                                    </asp:BoundField>
                                    <asp:TemplateField Visible="False">
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
                                    <asp:BoundField DataField="Monto" DataFormatString="{0:N}" HeaderText="Precio">
                                    <HeaderStyle HorizontalAlign="Center" Width="50px" />
                                    <ItemStyle Font-Bold="True" Font-Size="9pt" HorizontalAlign="Center" 
                                        Width="50px" />
                                    </asp:BoundField>
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
                <td>
                </td>
               </tr>
              <tr>
                <td>
                    Monto 
                    por Centro de Costo</td>
               </tr>
              <tr>
                <td>
                <asp:GridView ID="gvDetalleCotizacion0" runat="server" DataSourceID="odsccOfOc" 
                    AutoGenerateColumns="False" Font-Size="8pt" Width="710px">

                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Código" 
                            SortExpression="Codigo" />
                        <asp:BoundField DataField="CodigoElementoGasto" HeaderText="Centro de Costo" 
                            SortExpression="CodigoElementoGasto" ReadOnly="True" />
                            <asp:BoundField HeaderText="Monto" 
                             ReadOnly="True" DataField="Porcentaje" DataFormatString="{0:n}" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                    </Columns>

<SortedAscendingCellStyle BackColor="#F7F7F7"></SortedAscendingCellStyle>

<SortedAscendingHeaderStyle BackColor="#487575"></SortedAscendingHeaderStyle>

<SortedDescendingCellStyle BackColor="#E5E5E5"></SortedDescendingCellStyle>

<SortedDescendingHeaderStyle BackColor="#275353"></SortedDescendingHeaderStyle>
                </asp:GridView>
                    </td>
               </tr>
              </table>
        </fieldset>
                    <asp:ObjectDataSource ID="odsccOfOc" runat="server" 
                        SelectMethod="GetCCOSTOByIdOrdenCompra" 
                        TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="IdOrden" QueryStringField="idOc" 
                                Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
              <asp:ObjectDataSource ID="odsDetalleReqCoti" runat="server" 
                   SelectMethod="GetAllFromDetalleRequerimientoCotizacionByIdDetReqCot" 
                   TypeName="SistFoncreagro.BussinesLogic.CotizacionBL">
                   <SelectParameters>
                       <asp:QueryStringParameter Name="idCotizacion" QueryStringField="IdCot" 
                           Type="Int32" />
                   </SelectParameters>
               </asp:ObjectDataSource>
       <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
       </telerik:RadScriptManager> 
      <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
     </telerik:RadAjaxManager>
      </form>
</body>
</html>

