<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlSustento.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlSustento" %>
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
        <td width="15%">
            Fecha:</td>
        <td colspan="2">
                       <asp:TextBox ID="txtDate1" runat="server" 
             ValidationGroup="Transaccion" Width="70px" />
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
                 ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Nombre del Documento:</td>
        <td colspan="2">
                                                                                                                            <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" 
                runat="server" 
                                                                                                                                
                ControlToValidate="TextBox1" 
                Display="Dynamic" 
                                                                                                                                
                ErrorMessage="¡Debe ingresar el Nombre del Documento!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Archivo:</td>
        <td>
                                                <asp:TextBox ID="TextBox3" runat="server" Width="80%"></asp:TextBox>
                                                                                <asp:ImageButton ID="ImageButton13" runat="server" 
                                                                                    ImageUrl="~/img/OpenFile.gif" 
                                                    ToolTip="Abrir Archivo" />
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" 
                runat="server" 
                                                                                                                                
                ControlToValidate="TextBox3" 
                Display="Dynamic" 
                                                                                                                                
                ErrorMessage="¡Debe ingresar el Archivo!"></asp:RequiredFieldValidator>
        </td>
        <td>
                                                <asp:Label ID="lblMsn" runat="server" style="color: #006699" Width="100%"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
                  <asp:FileUpload ID="FileUploadControl" runat="server" 
                                ToolTip="Adjuntar archivos" Width="380px" />
                            <asp:ImageButton ID="ibSubirArchivo" runat="server" ImageUrl="~/img/upload.gif" 
                                ToolTip="Adjuntar Archivo" Height="20px" ValidationGroup="zz" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Observaciones:</td>
        <td>
                  <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Width="100%" 
                      CssClass="TextBoxAlignIzquierda"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
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








                                                



