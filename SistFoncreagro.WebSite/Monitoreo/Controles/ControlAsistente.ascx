<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlAsistente.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlAsistente" %>



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
   

    .style2
    {
        width: 8%;
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
                                                                                        <td width="11%">
                                                                                            Asistente:</td>
                                                                                        <td>
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" DataTextField="Apellidos" 
                                                                                                DataValueField="IdInteresado" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" AllowCustomText="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="100%" 
                                                                                                EmptyMessage="Ingrese el Asistente..." AutoPostBack="True">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="RadComboBox8" Display="Dynamic" Enabled="False" 
                                                                                                ErrorMessage="¡Debe ingresar el Asistente!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="2%" style="text-align: left">
                                                                                            <asp:ImageButton ID="ImageButton7" runat="server" ImageAlign="Middle" 
                                                                                                ImageUrl="~/img/Agregar.gif" ToolTip="Registrar Cliente" 
                                                                                                CausesValidation="False" />
                                                                                        </td>
                                                                                        <td style="text-align: left" class="style2">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    
                                                                                    <tr class="Texto">
                                                                                        <td colspan="4">
                                                                                            <table cellpadding="0" cellspacing="0" class="style1">
                                                                                                <tr>
                                                                                                    <td class="style3" width="11%">
                                                                                                        Actitud:</td>
                                                                                                    <td class="style3">
                                                                                                            <asp:DropDownList 
                                                                                                                ID="DropDownList4" runat="server" TabIndex="8">
                                                                                                                <asp:ListItem Value="APOYO TOTAL">APOYO TOTAL</asp:ListItem>
                                                                                                                <asp:ListItem>APOYO MODERADO</asp:ListItem>
                                                                                                                <asp:ListItem>NEUTRAL</asp:ListItem>
                                                                                                                <asp:ListItem Value="OPOSICON MODERADA">OPOSICION MODERADA</asp:ListItem>
                                                                                                                <asp:ListItem>OPOSICION RADICAL</asp:ListItem>
                                                                                                                <asp:ListItem>SIN DETERMINAR</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                    </td>
                                                                                                    <td class="style3">
                                                                                                        Poder:</td>
                                                                                                    <td class="style3">
                                                                                                            <asp:DropDownList 
                                                                                                                ID="DropDownList5" runat="server" TabIndex="8">
                                                                                                                <asp:ListItem>ALTO</asp:ListItem>
                                                                                                                <asp:ListItem>MEDIO</asp:ListItem>
                                                                                                                <asp:ListItem>BAJO</asp:ListItem>
                                                                                                                <asp:ListItem Value="NINGUNO"></asp:ListItem>
                                                                                                                <asp:ListItem>SIN DETERMINAR</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                    </td>
                                                                                                    <td class="style3">
                                                                                                        Dialogo:</td>
                                                                                                    <td class="style3">
                                                                                                            <asp:DropDownList 
                                                                                                                ID="DropDownList6" runat="server" TabIndex="8">
                                                                                                                <asp:ListItem>CON DIALOGO</asp:ListItem>
                                                                                                                <asp:ListItem>SIN DIALOGO</asp:ListItem>
                                                                                                                <asp:ListItem>INTRANSIGENTE</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td>
                                                                                                        Comentario:</td>
                                                                                                    <td colspan="5">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="100%" 
                                                                                                CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td>
                                                                                                        Plan de Accion:</td>
                                                                                                    <td colspan="5">
                                                                                            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="100%" 
                                                                                                CssClass="TextBoxAlignIzquierda"></asp:TextBox>
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

        



                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetINTERESADOByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.InteresadosBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
