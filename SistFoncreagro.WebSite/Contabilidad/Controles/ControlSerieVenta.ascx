<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlSerieVenta.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlSerieVenta" %>
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
        <td width="15%">
            Serie</td>
        <td width="85%">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="TextBox1" Display="Dynamic" 
                ErrorMessage="¡Debe ingresar la Serie!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Tipo Documento:</td>
        <td>
                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                                                                                DataSourceID="SqlTipoDocumento" DataTextField="Documento" 
                                                                                                DataValueField="IdTipoDocumento">
                                                                                            </asp:DropDownList>
                                                                                            </td>
    </tr>
    <tr>
        <td>
            Proyecto:</td>
        <td>
                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" 
                AllowCustomText="True" 
                                                                                                
                AutoPostBack="False" DataSourceID="odsProyecto" 
                DataTextField="AreaProyecto" 
                                                                                                
                DataValueField="IdProyecto" 
                EnableLoadOnDemand="True" 
                                                                                                
                EnableVirtualScrolling="True" ItemsPerRequest="10" 
                MarkFirstMatch="True" 
                                                                                                
                ShowMoreResultsBox="True" 
                                                                                                
                ValidationGroup="Transaccion" Width="100%">
                                                                                            </telerik:RadComboBox>
                                                                                            </td>
    </tr>
    <tr>
        <td>
            Último Emitido:</td>
        <td>
                                                                                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                                                ControlToValidate="TextBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el número del último emitido!"></asp:RequiredFieldValidator>
                                                                                            </td>
    </tr>
    <tr>
        <td colspan="2">
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
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                                

        




<asp:SqlDataSource ID="SqlTipoDocumento" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetTIPODOCUMENTOVentas" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>


