<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlIntegrante.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlIntegrante" %>
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
   

   

    .Texto1
{
	text-align: left;
	text-transform: uppercase;
	font-family: Arial;
    font-size: 8pt;
}
   

   

    </style>

<table class="style1">
    <tr>
        <td width="8%">
            Integrante:</td>
        <td>
            <telerik:RadComboBox ID="RadComboBox1" Runat="server" Width="100%" 
                DataSourceID="SqlPersonal" DataTextField="Personal" DataValueField="IdPersonal" 
                EnableLoadOnDemand="True" MarkFirstMatch="True" Skin="Hay">
            </telerik:RadComboBox>
        </td>
        <td>
                       &nbsp;</td>
    </tr>
    <tr>
        <td width="12%">
            Vehiculo:</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlVehiculos" 
                DataTextField="Vehiculo" DataValueField="IdVehiculo">
            </asp:DropDownList>
        </td>
        <td>
                       <asp:CheckBox ID="CheckBox2" runat="server" Text="Conductor:" 
                           TextAlign="Left" />
        </td>
    </tr>
    <tr>
        <td>
            Observaciones:</td>
        <td colspan="2">
                                                                                                                            <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" 
                Width="100%" 
                                                                                                                                
                CssClass="TextBoxAlignIzquierda" TabIndex="12"></asp:TextBox>
                                                                                                                        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:ImageButton ID="ImageButton15" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                style="width: 18px" />
<asp:ImageButton ID="ImageButton16" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
<asp:ImageButton ID="ImageButton17" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
             </td>
    </tr>
</table>








                                                



<asp:SqlDataSource ID="SqlPersonal" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetPERSONALResumen" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>
<asp:SqlDataSource ID="SqlVehiculos" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetVEHICULOByIdDetalleEjeDetallado" 
    SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:QueryStringParameter Name="IdDetalleEje" QueryStringField="IdDetalleEje" 
            Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>









                                                



