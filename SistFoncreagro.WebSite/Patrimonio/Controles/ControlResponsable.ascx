<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlResponsable.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlResponsable" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<style type="text/css">
    .style1
    {
        width: 100%;
         font-family: Arial;
    font-size: 8pt;
    }
.Texto
{
   
    font-family: Arial;
    font-size: 8pt;
}
.TextBoxAlignIzquierda
{
	text-align: left;
	text-transform: uppercase;
}
   

    </style>

<table class="style1">
    <tr>
        <td width="7%">
            Responsable:</td>
        <td colspan="3" width="93%">
            <telerik:RadComboBox ID="RadComboBox1" Runat="server" Width="50%" 
                DataSourceID="SqlPersonal" DataTextField="Personal" DataValueField="IdPersonal" 
                EnableLoadOnDemand="True" MarkFirstMatch="True" Skin="Hay">
            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td>
            Fecha Inicio:</td>
        <td width="20%">
             <asp:TextBox ID="txtDate1" runat="server" 
             ValidationGroup="Transaccion" Width="70px" AutoPostBack="True" />
             <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
              AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
             TargetControlID="txtDate1" />
            <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
           ClientIDMode="AutoID" ControlExtender="MaskedEditExtender1" 
           ControlToValidate="txtDate1" Display="Dynamic" 
          EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
          />
        </td>
        <td width="7%">
            Fecha Fin:</td>
        <td>
             <asp:TextBox ID="txtDate2" runat="server" 
             ValidationGroup="Transaccion" Width="70px" AutoPostBack="True" />
               <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
              AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
             TargetControlID="txtDate2" />
            <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
           ClientIDMode="AutoID" ControlExtender="MaskedEditExtender2" 
           ControlToValidate="txtDate2" Display="Dynamic" 
          EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
          />
        </td>
    </tr>
    <tr>
        <td>
            Observación</td>
        <td colspan="3">
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="50%"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                style="width: 18px" />
<asp:ImageButton ID="ImageButton2" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
             </td>
    </tr>
</table>

<asp:SqlDataSource ID="SqlPersonal" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetPERSONALResumen" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>


