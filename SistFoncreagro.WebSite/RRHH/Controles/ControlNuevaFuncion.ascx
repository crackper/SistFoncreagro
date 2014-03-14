 <%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlNuevaFuncion.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlNuevaFuncion" %>
 <table width="100%">
     <tr>
         <td width="20">
             &nbsp;</td>
         <td align="right" width="100">
             Función:</td>
         <td>
             <asp:TextBox ID="txtFuncion" runat="server" TextMode="MultiLine" Width="450px"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td width="20">
             &nbsp;</td>
         <td align="left" width="100">
&nbsp;<asp:ImageButton ID="ImgBtnGuardar" runat="server" 
                ImageUrl="~/img/Update.gif" />
&nbsp;<asp:ImageButton ID="ImgBtnCancelar" runat="server" ImageUrl="~/img/Cancel.gif" 
                CommandName="Cancel" />
         </td>
         <td>
             &nbsp;</td>
     </tr>
 </table>

