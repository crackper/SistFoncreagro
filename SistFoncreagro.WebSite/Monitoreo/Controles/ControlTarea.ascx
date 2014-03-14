<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlTarea.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlTarea" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>



<style type="text/css">
    .style1
    {
        width: 100%;
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
   

    .style3
    {
        height: 26px;
    }
   

    </style>



<table class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td style="text-align: left">
                                                                                <table cellpadding="0" cellspacing="0" >
                                                                                                                                                                        
                                                                                    <tr class="Texto">
                                                                                        <td>
                                                                                            <table cellpadding="0" cellspacing="0" class="style1">
                                                                                                <tr>
                                                                                                    <td class="style3" width="11%">
                                                                                                        Nombre:</td>
                                                                                                    <td class="style3" colspan="5">
                                                                                                        <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="400px"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style3" width="11%">
                                                                                                        Código:</td>
                                                                                                    <td class="style3">
                                                                                                        <asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>
                                                                                                        </td>
                                                                                                    <td class="style3">
                                                                                                        Unidad:</td>
                                                                                                    <td class="style3">
                                                                                                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                                                                                    </td>
                                                                                                    <td class="style3">
                                                                                                        Porcentaje 
                                                                                                        (%):</td>
                                                                                                    <td class="style3">
                                                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" Width="50px">
                                                                                                                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                                <NumberFormat DecimalDigits="0" />
                                                                                                            </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style3" width="11%" colspan="6">
                                                                                                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Finaliza la Actividad" />
                                                                                                    </td>
                                                                                                </tr>
                                                                                                </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                    
                                                                                    </table>
                                                                                                    </td>
    </tr>
    <tr>
        <td style="text-align: left; font-family: Arial; font-size: 8pt;">
            <asp:ImageButton ID="ImageButton1" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                style="width: 18px" />
<asp:ImageButton ID="ImageButton2" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />&nbsp;
<asp:ImageButton ID="ImageButton3" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
             &nbsp;</td>
    </tr>
    </table>

        



                                                


        



                                                