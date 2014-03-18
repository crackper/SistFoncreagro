<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmReporte.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmReporte" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    function habilitar() {
        var rbFec = document.getElementById('<%= rdFechas.ClientId %>');
        var rbTodo = document.getElementById('<%= rbTodo.ClientId %>');
        var txtFecI = document.getElementById('<%= txtFechaInicio.ClientId %>');
        var txtFecF = document.getElementById('<%= txtFechaFin.ClientId %>');
        if (rbFec.checked == true) {
            //            txtFecI.style = 'hidden';
            txtFecI.disabled = false;
            txtFecF.disabled = false;
            txtFecI.value = '';
            txtFecF.value = '';
            txtFecI.focus();
        }
        if (rbTodo.checked == true) {
            txtFecI.disabled = true;
            txtFecF.disabled = true;

            txtFecI.value = '';
            txtFecF.value = '';
        }
    }
</script>
  <fieldset class="jcv">
       <legend class="legendJcv">Reportes</legend>
       <table>
           <tr>
               <td>
                   Requerimientos rechazados :</td>
               <td>
                   <asp:RadioButton ID="rbTodo" runat="server" Checked="True" GroupName="m" 
                       Text="Todo" />
               </td>
               <td>
                   <asp:RadioButton ID="rdFechas" runat="server" GroupName="m" Text="Fechas" />
               </td>
               <td>
                   &nbsp;</td>
               <td>
                   <asp:TextBox ID="txtFechaInicio" runat="server" Width="100px" Enabled="False"></asp:TextBox>
                   <asp:CalendarExtender ID="CalendarExtender1" runat="server" 
                       TargetControlID="txtFechaInicio" Format="dd/MM/yyyy">
                   </asp:CalendarExtender>
               </td>
               <td>
                   y</td>
               <td>
                   <asp:TextBox ID="txtFechaFin" runat="server" Width="100px" Enabled="False"></asp:TextBox>
                 <asp:CalendarExtender ID="CalendarExtender2" runat="server" 
                       TargetControlID="txtFechaFin" Format="dd/MM/yyyy">
                   </asp:CalendarExtender>
               </td>
               <td>
                   <asp:Button ID="btnReporte" runat="server" Text="Mostrar" />
               </td>
           </tr>
           <tr>
               <td>
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
       </table>
  </fieldset>
</asp:Content>
