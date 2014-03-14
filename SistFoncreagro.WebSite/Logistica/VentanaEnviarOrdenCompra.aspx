<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaEnviarOrdenCompra.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaEnviarOrdenCompra" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <style type="text/css">
        #form1
        {
            width: 433px;
        }
        .style1
        {
            height: 30px;
            width: 180px;
        }
        .style2
        {
            width: 220px;
            height: 3px;
        }
        .style3
        {
            width: 218px;
        }
        .style4
        {
            width: 217px;
        }
        .style7
        {
            height: 24px;
            width: 180px;
        }
        .style8
        {
            width: 217px;
            height: 24px;
        }
        .style9
        {
            height: 23px;
            width: 180px;
        }
        .style10
        {
            width: 217px;
            height: 23px;
        }
        .style11
        {
            width: 100%;
        }
    </style>
</head>
<body style="width: 435px">
   <form id="form1" runat="server">
         <fieldset>  
          <table style="width: 420px">
              <tr>
                  <td class="style9" 
                      
                      style="font-family: Arial, Helvetica, sans-serif; font-size: 9pt; ">
                      Número Orden de compra :</td>
                  <td class="style10" align="right">
                           <asp:TextBox ID="txtNroOrdenCOmpra" runat="server" BorderStyle="None" 
                               Width="215px"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="style7" 
                      
                      style="font-family: Arial, Helvetica, sans-serif; font-size: 9pt; ">
                      Lugar de entrega o ejecución :</td>
                  <td class="style8">
                           </td>
              </tr>
              <tr>
                  <td class="style3" 
                      
                      
                      style="font-family: Arial, Helvetica, sans-serif; font-size: 9pt; height: 30px;" 
                      colspan="2">
                      <telerik:RadComboBox ID="cmbLugarEntrega" Runat="server" 
                          DataSourceID="obsRuta" DataTextField="Nombre" 
                          DataValueField="IdRutaRequerimiento" Skin="Hay" Width="408px">
                      </telerik:RadComboBox>
                  </td>
              </tr>
              <tr>
                  <td class="style1" 
                      
                      style="font-family: Arial, Helvetica, sans-serif; font-size: 9pt; ">
                      Fecha Entrega :</td>
                  <td class="style4" align="right">
                      <telerik:RadDatePicker ID="dpFechaLlegada" Runat="server" Skin="Hay" 
                          Width="180px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x" 
                              Skin="Hay"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                      </telerik:RadDatePicker>
                  </td>
              </tr>
              <tr>
                  <td class="style2" align="center" colspan="2" style="height: 2px;">
                            </td>
              </tr>
              </table>
         </fieldset>
               <table class="style11">
                   <tr>
                       <td align="center">
               <asp:ImageButton ID="imGuardarDatos" runat="server" ImageUrl="~/img/Update.gif" 
                                ToolTip="Guardar" Width="20px" CommandName="Cerrar" />
                       </td>
                   </tr>
         </table>
         <br />
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
         <asp:ObjectDataSource ID="obsRuta" runat="server" 
                  SelectMethod="GetAllFromRutaRequerimiento" 
                  TypeName="SistFoncreagro.BussinesLogic.RutaRequerimientoBL" 
             OldValuesParameterFormatString="original_{0}">
              </asp:ObjectDataSource>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">

            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }    

            function CerrarVentana(indicador) {
                var oWnd = GetRadWindow();
                var oArg = new Object();
                oArg.indicador = indicador;
                oWnd.close(oArg);
            }
        </script>
    </telerik:RadCodeBlock>  
      </form>
</body>
</html>

