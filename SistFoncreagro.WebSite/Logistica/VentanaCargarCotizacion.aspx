﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaCargarCotizacion.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaCargarCotizacion" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    var parametro = 0;
    var tipo = 0;

    function CargarVentana(nombre) {
        aviso = open("../Archivos/Logistica/" + nombre, "Documento", "status=no, directories=no, toolbar=no, width=800, height=500, left=100, top=100")
//        window.open("../Archivos1/Logistica/" + nombre, nombre, "width=800, height=500")    
    }
</script>
</telerik:RadCodeBlock>
<head id="Head1" runat="server">
    <title></title>
</head>
<body style="width: 646px">
   <form id="form1" runat="server">
     <fieldset style="width: 630px">       
          <table style="width: 645px">
              <tr>
                  <td class="style1" 
                      
                      style="font-family: Arial, Helvetica, sans-serif; font-size: 9pt; ">
                      </td>
                  <td colspan="2" class="style1">
                           </td>
              </tr>
              <tr>
                  <td class="style3" 
                      
                      style="font-family: Arial, Helvetica, sans-serif; font-size: 9pt; height: 30px;">
                      Nombre :</td>
                  <td class="style5">
                      <asp:TextBox ID="txtNombre" runat="server" Width="200px"></asp:TextBox>
                      &nbsp;&nbsp;
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                          ControlToValidate="txtNombre" ErrorMessage="Campo Requerido" Font-Size="8pt" 
                          ValidationGroup="zz"></asp:RequiredFieldValidator>
                  </td>
                  <td align="justify">
                            &nbsp;</td>
              </tr>
              <tr>
                  <td class="style3" 
                      
                      style="font-family: Arial, Helvetica, sans-serif; font-size: 9pt; height: 30px;">
                      Archivo :</td>
                  <td class="style5">
                  <asp:FileUpload ID="FileUploadControl" runat="server" 
                                ToolTip="Adjuntar archivos" Width="380px" />
                            <asp:ImageButton ID="ibSubirArchivo" runat="server" ImageUrl="~/img/upload.gif" 
                                ToolTip="Adjuntar Archivo" Height="20px" ValidationGroup="zz" />
                  </td>
                  <td align="justify">
                            &nbsp;</td>
              </tr>
              <tr>
                  <td class="style3" 
                      style="height: 10px;">
                      &nbsp;</td>
                  <td class="style5">
                      &nbsp;</td>
                  <td align="justify">
                            &nbsp;</td>
              </tr>
              <tr>
                  <td colspan="3">
                      <asp:GridView ID="gvCotizacion" runat="server" AutoGenerateColumns="False" Width="625px" 
                          DataKeyNames="IdCotizacion" DataSourceID="odsAdjuntoCotizacion" 
                          Font-Size="9pt">
                          <Columns>
                            <asp:ButtonField ButtonType="Image" CommandName="Eliminar" 
                                  ImageUrl="~/img/Delete.gif" FooterText="Eliminar" >
                              <FooterStyle HorizontalAlign="Center" />
                              <HeaderStyle HorizontalAlign="Center" Width="20px" />
                              <ItemStyle Width="20px" HorizontalAlign="Center" />
                              </asp:ButtonField>
                              <asp:BoundField DataField="Fecha" HeaderText="Fecha" 
                                  SortExpression="Fecha" DataFormatString="{0:dd/MM/yyyy}" >
                              <ItemStyle Width="60px" HorizontalAlign="Center" />
                              </asp:BoundField>
                              <asp:BoundField DataField="Nombre" HeaderText="Documento" 
                                  SortExpression="Nombre" >
                              <ItemStyle Width="250px" />
                              </asp:BoundField>
                           <asp:TemplateField SortExpression="">
                                    <ItemTemplate>
                                    <asp:TextBox ID="txtIdAdjuntoCotizacion" runat="server"
                                    Text='<%# Bind("IdAdjuntoCotizacion") %>' Width="0px" Visible="False" ReadOnly="True"></asp:TextBox>
                                 <asp:TextBox ID="txtNombreArchivo" runat="server" BackColor="Info" CssClass="TextoCentro"
                                    Text='<%# Bind("Nombre") %>' Width="0px" Visible="False" ReadOnly="True"></asp:TextBox>
                                         <asp:Label ID="lblEstado" runat="server" ForeColor="White" Height="0px" 
                                             Text='<%# Bind("Estado") %>' Visible="False" Width="0px"></asp:Label>
                                        <asp:LinkButton ID="lbAbrir" runat="server">Ver...</asp:LinkButton>
                                    </ItemTemplate>
                                    <ControlStyle Width="20px" />
                                    <FooterStyle HorizontalAlign="Center" Width="20px" />
                                    <HeaderStyle Width="20px" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" Width="20px" />
                                </asp:TemplateField>
                          </Columns>
                      </asp:GridView>
                  </td>
              </tr>
              <tr>
                  <td class="style2" align="center" colspan="3" style="height: 10px;">
                            </td>
              </tr>
              <tr>
                  <td class="style2" align="center" colspan="3">
      <asp:ImageButton ID="CtnCancelarAdj" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cancelar" Width="20px" Visible="False" />
                            </td>
              </tr>
          </table>
        </fieldset>
      <asp:ObjectDataSource ID="odsAdjuntoCotizacion" runat="server" 
             SelectMethod="GetAllFromAdjuntoCotizacionByIdCotizacion" 
             TypeName="SistFoncreagro.BussinesLogic.AdjuntoCotizacionBL">
                  <SelectParameters>
                      <asp:QueryStringParameter Name="idCotizacion" QueryStringField="IdCotizacion" 
                          Type="Int32" />
                  </SelectParameters>
         </asp:ObjectDataSource>
      <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
          <AjaxSettings>
              <telerik:AjaxSetting AjaxControlID="ibSubirArchivo">
                  <UpdatedControls>
                      <telerik:AjaxUpdatedControl ControlID="GridView1" />
                  </UpdatedControls>
              </telerik:AjaxSetting>
          </AjaxSettings>
      </telerik:RadAjaxManager>
       <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
       </telerik:RadScriptManager> 
      </form>
</body>
</html>