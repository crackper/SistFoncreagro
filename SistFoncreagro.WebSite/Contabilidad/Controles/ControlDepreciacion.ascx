<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlDepreciacion.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlDepreciacion" %>
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
        <td width="13%">
            Meses Depreciados:</td>
        <td width="12%" style="text-align: left">
            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" Value="0" 
                Width="50px">
            </telerik:RadNumericTextBox>
        </td>
        <td width="18%" style="text-align: left">
            Depreciación Acumulada:</td>
        <td width="57%" style="text-align: left">
            <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" Value="0" 
                Width="50px">
            </telerik:RadNumericTextBox>
        </td>
    </tr>
    <tr>
        <td colspan="4" style="text-align: left">
            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                style="width: 18px" />
<asp:ImageButton ID="ImageButton2" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />&nbsp;
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
    </td>
    </tr>
    </table>
                                                


            <asp:HiddenField ID="HiddenField2" runat="server" />
            <asp:HiddenField ID="HiddenField1" runat="server" />
        
                                                


            <asp:HiddenField ID="HiddenField3" runat="server" />
        
                                                


