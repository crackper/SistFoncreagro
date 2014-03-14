<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlEstado.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlEstado" %>
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
        <td width="10%">
            Estado:</td>
        <td colspan="6" width="93%">
                                                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AllowCustomText="True" 
                DataSourceID="SqlTipos" 
                DataTextField="Descripcion" 
                                                                                                                                
                DataValueField="IdTipo" 
                EnableLoadOnDemand="True" 
                                                                                                                                
                EnableVirtualScrolling="True" ItemsPerRequest="10" 
                MarkFirstMatch="True" 
                                                                                                                                
                ShowMoreResultsBox="True" TabIndex="16" 
                ValidationGroup="Transaccion" 
                                                                                                                                
                Width="50%" Skin="Hay" AutoPostBack="True">
                                                                                                                            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td>
            Fecha:</td>
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
        <td width="20%">
             &nbsp;</td>
        <td width="20%" colspan="2">
             &nbsp;</td>
        <td width="7%">
            &nbsp;</td>
        <td>
             &nbsp;</td>
    </tr>
    <tr>
        <td>
            Observación:</td>
        <td colspan="6">
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="50%"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="7">
            <asp:CheckBox ID="CheckBox1" runat="server" Enabled="False" 
                Text="Baja Contable" Checked="True" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox2" runat="server" Enabled="False" 
                Text="Baja Patrimonial" />
        </td>
    </tr>
    <tr>
        <td>
            Motivo de Baja:</td>
        <td colspan="6">
                                                                                                                            <telerik:RadComboBox ID="RadComboBox2" Runat="server" AllowCustomText="True" 
                DataSourceID="SqlMotivoBaja" 
                DataTextField="Descripcion" 
                                                                                                                                
                DataValueField="IdMotivo" 
                EnableLoadOnDemand="True" 
                                                                                                                                
                EnableVirtualScrolling="True" ItemsPerRequest="10" 
                MarkFirstMatch="True" 
                                                                                                                                
                ShowMoreResultsBox="True" TabIndex="16" 
                ValidationGroup="Transaccion" 
                                                                                                                                
                Width="50%" Skin="Hay" Enabled="False">
                                                                                                                            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td>
            Informe de Baja:</td>
        <td colspan="3">
                                                <asp:TextBox ID="TextBox3" runat="server" Width="80%" Enabled="False"></asp:TextBox>
                                                                                <asp:ImageButton ID="ImageButton13" runat="server" 
                                                                                    ImageUrl="~/img/OpenFile.gif" 
                                                    ToolTip="Abrir Archivo" Enabled="False" />
        </td>
        <td colspan="3">
                                                <asp:Label ID="lblMsn" runat="server" style="color: #006699" Width="100%"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td colspan="3">
                  <asp:FileUpload ID="FileUploadControl" runat="server" 
                                ToolTip="Adjuntar archivos" Width="380px" Enabled="False" />
                            <asp:ImageButton ID="ibSubirArchivo" runat="server" ImageUrl="~/img/upload.gif" 
                                ToolTip="Adjuntar Archivo" Height="20px" ValidationGroup="zz" 
                      Enabled="False" />
        </td>
        <td colspan="3">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="7">
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

<asp:SqlDataSource ID="SqlTipos" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromTIPOESTADOBIEN" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>



<asp:SqlDataSource ID="SqlMotivoBaja" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromMOTIVOBAJA" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>




