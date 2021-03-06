﻿<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlCaracteristicas.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlCaracteristicas" %>
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
            Categoría:</td>
        <td width="40%">
             <asp:DropDownList ID="DropDownList1" runat="server" 
                 DataSourceID="SqlCategorias" DataTextField="categoria" 
                 DataValueField="idcategoriaanimal" Width="200px">
             </asp:DropDownList>
        </td>
        <td width="7%">
            Estado:</td>
        <td>
             <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlEstados" 
                 DataTextField="NomEstadoSemoviente" DataValueField="IdEstadoSemoviente" 
                 Width="200px">
             </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Peso (Kg.):</td>
        <td width="20%">
             <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server">
             </telerik:RadNumericTextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                 ControlToValidate="RadNumericTextBox1" Display="Dynamic" 
                 ErrorMessage="¡Debe ingresar el Peso!"></asp:RequiredFieldValidator>
        </td>
        <td width="7%">
            Valor (S/.):</td>
        <td>
             <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server">
             </telerik:RadNumericTextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                 ControlToValidate="RadNumericTextBox2" Display="Dynamic" 
                 ErrorMessage="¡Debe ingresar el Valor!"></asp:RequiredFieldValidator>
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
             <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                 ControlToValidate="txtDate1" Display="Dynamic" 
                 ErrorMessage="¡Debe ingresar la Fecha de Inicio!"></asp:RequiredFieldValidator>
        </td>
        <td width="7%">
            Fecha Fin:</td>
        <td>
             <asp:TextBox ID="txtDate2" runat="server" 
             ValidationGroup="Transaccion" Width="70px" AutoPostBack="True" 
                 ReadOnly="True" />
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

                                                <asp:SqlDataSource ID="SqlCategorias" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetCategorianimalByIdSemoviente" 
    SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdSemoviente" QueryStringField="IdSemoviente" 
                                                            Type="Int32" />
                                                    </SelectParameters>
</asp:SqlDataSource>
<asp:SqlDataSource ID="SqlEstados" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromESTADOSEMOVIENTE" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>




