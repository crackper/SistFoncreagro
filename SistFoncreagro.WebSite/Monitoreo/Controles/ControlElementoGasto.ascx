<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlElementoGasto.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlElementoGasto" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<table class= "Texto">
    <tr>
        <td align="right" >
            Código:</td>
        <td>
            <asp:TextBox ID="TxtCodigo" runat="server" style="text-transform :uppercase" 
                MaxLength="4" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Nombre:</td>
        <td class="style4">
            <asp:TextBox ID="TxtNombre" runat="server" Height="50px" TextMode="MultiLine" 
                Width="700px" style="text-transform :uppercase"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Descripción:</td>
        <td class="style6">
            <asp:TextBox ID="TxtDesc" runat="server" Height="50px" TextMode="MultiLine" 
                Width="700px" style="text-transform :uppercase"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" >
            Tipo:</td>
        <td >
            <telerik:RadComboBox ID="CbClasificacion" Runat="server" 
                DataSourceID="OdsClasificacion" DataTextField="Descripcion" 
                DataValueField="IdClasificacion" Skin="Default" Width="325px">
            </telerik:RadComboBox>
            <asp:ObjectDataSource ID="OdsClasificacion" runat="server" 
                SelectMethod="GetFromClasificacionByTipo" 
                TypeName="SistFoncreagro.BussinesLogic.ClasificacionBL">
                <SelectParameters>
                    <asp:Parameter DefaultValue="2" Name="_Tipo" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:ImageButton ID="BtnGrabar" runat="server" ImageUrl="~/img/Update.gif" CommandName = "PerformInsert"
            Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
            <asp:ImageButton ID="BtnActualizar" runat="server" CommandName = "Update"
                ImageUrl="~/img/Update.gif"
                
                Visible="<%# not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/cancel.gif" 
                ToolTip="Cancelar" CommandName = "Cancel" CausesValidation="False" 
                />
            <asp:TextBox ID="TxtIdElemGasto" runat="server" 
                style="text-transform :uppercase" Visible="False"></asp:TextBox>
        </td>
    </tr>
    </table>

