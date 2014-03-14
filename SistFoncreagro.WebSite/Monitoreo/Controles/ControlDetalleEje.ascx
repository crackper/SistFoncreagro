<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlDetalleEje.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlDetalleEje" %>
<style type="text/css">


.Texto
{
    font-family: Arial;
    font-size: 9pt;
}

.Texto1
{
	text-align: left;
	text-transform: uppercase;
	font-family: Arial;
    font-size: 8pt;
}</style>
                                                                                                <table 
                                                                                                
    cellspacing="0" class="0" style="width: 100%">
                                                                                                    <tr>
                                                                                                        <td 
                                                                                                    class="Texto"><table style="width: 100%">
                                                                                                                <tr>
                                                                                                                    <td 
                                                                                                            width="12%">Caserio:</td><td colspan="3">
                                                                                                            <telerik:RadComboBox ID="RadComboBox1" 
                                                                                                                Runat="server" DataTextField="Nombre" DataValueField="CUBIGEO" 
                                                                                                                EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                ShowDropDownOnTextboxClick="False" Skin="Hay" style="margin-left: 0px" 
                                                                                                                TabIndex="5" Width="99%"></telerik:RadComboBox>
                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                                ErrorMessage="¡Debe ingresar el Caserio!"></asp:RequiredFieldValidator>
                                                                                                        </td></tr><tr>
                                                                                                                    <td 
                                                                                                            width="12%">Jefe Familia:</td><td colspan="3">
                                                                                                            <telerik:RadComboBox 
                                                                                                                ID="RadComboBox7" Runat="server" Width="99%" TabIndex="6"></telerik:RadComboBox></td></tr>
                                                                                                                <tr>
                                                                                                                    <td 
                                                                                                            width="10%">Clima Social:</td><td width="38%">
                                                                                                            <asp:TextBox ID="TextBox8" 
                                                                                                                runat="server" CssClass="Texto1" TabIndex="7" TextMode="MultiLine" 
                                                                                                                Width="100%"></asp:TextBox></td>
                                                                                                                    <td style="text-align: right" 
                                                                                                            width="12%">Actitud:</td><td valign="middle" width="38%">
                                                                                                            <asp:DropDownList 
                                                                                                                ID="DropDownList4" runat="server" TabIndex="8">
                                                                                                                <asp:ListItem Value="APOYO TOTAL">APOYO TOTAL</asp:ListItem>
                                                                                                                <asp:ListItem>APOYO MODERADO</asp:ListItem>
                                                                                                                <asp:ListItem>NEUTRAL</asp:ListItem>
                                                                                                                <asp:ListItem Value="OPOSICON MODERADA">OPOSICION MODERADA</asp:ListItem>
                                                                                                                <asp:ListItem>OPOSICION RADICAL</asp:ListItem>
                                                                                                                <asp:ListItem>SIN DETERMINAR</asp:ListItem>
                                                                                                            </asp:DropDownList></td></tr><tr><td>Quejas o Reclamos:</td>
                                                                                                                    <td>
                                                                                                        <asp:TextBox 
                                                                                                            ID="TextBox9" runat="server" CssClass="Texto1" TabIndex="9" 
                                                                                                            TextMode="MultiLine" Width="100%"></asp:TextBox></td>
                                                                                                                    <td 
                                                                                                            style="text-align: right">Acciones Tomadas:</td>
                                                                                                                    <td>
                                                                                                            <asp:TextBox ID="TextBox10" 
                                                                                                                runat="server" CssClass="Texto1" TabIndex="10" TextMode="MultiLine" 
                                                                                                                Width="100%"></asp:TextBox></td></tr>
                                                                                                    <tr>
                                                                                                        <td>
                                                                                                            Observaciones:</td>
                                                                                                        <td>
                                                                                                            <asp:TextBox ID="TextBox11" runat="server" CssClass="Texto1" TabIndex="11" 
                                                                                                                TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                        </td>
                                                                                                        <td style="text-align: right">
                                                                                                            &nbsp;</td>
                                                                                                        <td>
                                                                                                            &nbsp;</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <td colspan="4">
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
                                                                                                </table></td></tr></table>


    <asp:ObjectDataSource ID="OdsUbigeo" runat="server" 
        SelectMethod="GetUBIGEODATOSByParameter" 
        TypeName="SistFoncreagro.BussinesLogic.UbigeoDatosBL" 
        OldValuesParameterFormatString="original_{0}">
        <SelectParameters>
            <asp:Parameter DefaultValue="*" Name="texto" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    

                                                                                                                            
