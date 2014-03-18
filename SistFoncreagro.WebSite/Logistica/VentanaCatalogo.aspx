<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaCatalogo.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaCatalogo" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">

            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }

            function CerrarVentana(indicador) {
                var oWnd = GetRadWindow();
                var oArg = new Object();
                oArg.indicador = indicador;
                oWnd.close(oArg);
            }
        </script>
    </telerik:RadCodeBlock>
    <style type="text/css">
        #form1
        {
            width: 740px;
            height: 370px;
        }
    </style>
</head>
<body style="height: 390px; width: 69%;">
<form id="form1" runat="server">
 <asp:ObjectDataSource ID="odsMoneda" runat="server" 
        SelectMethod="GetAllFromMoneda" 
        TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsUnidad" runat="server" 
        SelectMethod="GetAllFromUnidadMedida" 
        TypeName="SistFoncreagro.BussinesLogic.UnidadMedidaBL">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsMarca" runat="server" 
        SelectMethod="GetAllFromMarca" TypeName="SistFoncreagro.BussinesLogic.MarcaBL">
    </asp:ObjectDataSource>
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <asp:ObjectDataSource ID="odsClasificacion" runat="server" 
        SelectMethod="GetFromClasificacionByTipo" 
        TypeName="SistFoncreagro.BussinesLogic.ClasificacionBL">
        <SelectParameters>
            <asp:Parameter DefaultValue="0" Name="_Tipo" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
<fieldset>
   <legend style="font-family: Arial; font-size: 15px;">
       <asp:Label ID="lbTitulo" runat="server">EDITAR PRODUCTO</asp:Label>
    </legend>
    <table style="width: 100%;">
        <tr>
            <td style="width: 20%; font-size: 17px;" class="style1">
                <asp:Label ID="lblTituloNumero" runat="server">Código :</asp:Label>
            </td>
            <td style="width: 49%;">
                <asp:Label ID="lblNumero" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 20%; font-size: 17px;" class="style1">
                Descripción :</td>
            <td style="width: 49%;">
                <asp:TextBox ID="txtDescripcion" runat="server" Width="500px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtDescripcion" ErrorMessage="Ingrese descripción." 
                    Font-Size="8pt" ValidationGroup="validar">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 20%; font-size: 17px;" class="style1">
                Clasificación :</td>
            <td style="width: 49%;">
                        <telerik:RadComboBox ID="rcbClasificacion" Runat="server" 
                    AllowCustomText="True" DataTextField="Descripcion" 
                            DataValueField="IdClasificacion" EnableLoadOnDemand="True" 
                            EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                            ShowMoreResultsBox="True" Height="200px" Width="400px" 
                            DataSourceID="odsClasificacion" Skin="Sitefinity">
                        </telerik:RadComboBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="rcbClasificacion" 
                    ErrorMessage="Seleccione clasificación." Font-Size="8pt" 
                    ValidationGroup="validar">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 20%; font-size: 17px;" class="style1">
                Afecto Igv :</td>
            <td style="width: 49%;">
                <asp:CheckBox ID="cbIgv" runat="server" Checked="True" />
            </td>
        </tr>
        <tr>
            <td style="width: 20%; font-size: 17px;" class="style1">
                Precio Referencial :</td>
            <td style="width: 49%;">
                <telerik:RadNumericTextBox ID="rtxtPrecioReferencia" Runat="server">
                </telerik:RadNumericTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="rtxtPrecioReferencia" ErrorMessage="Ingrese precio referencial." 
                    Font-Size="8pt" ValidationGroup="validar">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 20%; font-size: 17px;" class="style1">
                Moneda Compra :</td>
            <td style="width: 49%;">
                <asp:DropDownList ID="ddlMonedaCompra" runat="server" Width="250px" 
                    DataSourceID="odsMoneda" DataTextField="Nombre" DataValueField="IdMoneda">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 20%; font-size: 17px;" class="style1">
                Unidad :</td>
            <td style="width: 49%;">
                <asp:DropDownList ID="ddlUnidadMedida" runat="server" Width="250px" 
                    DataSourceID="odsUnidad" DataTextField="Descripcion" 
                    DataValueField="IdUnidadMedida">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 20%; font-size: 17px;" class="style1">
                Marca :</td>
            <td style="width: 49%;">
                <asp:DropDownList ID="ddlMarca" runat="server" Width="250px" 
                    DataSourceID="odsMarca" DataTextField="Descripcion" 
                    DataValueField="IdMarca">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 20%; font-size: 17px;" class="style1">
                &nbsp;</td>
            <td style="width: 49%;">
                        &nbsp;</td>
        </tr>
        <tr>
            <td style="font-size: 18px;" class="style1" align="center" colspan="2">
                <asp:ImageButton ID="ImageButton2" runat="server" CommandName="PerformInsert" 
                    ImageUrl="~/img/Update.gif" ToolTip="Insertar" ValidationGroup="validar" />
                &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                    CommandName="Cancel" ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
            </td>
        </tr>
        <tr>
            <td style="font-size: 18px;" class="style1" colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Size="9pt" 
                    ValidationGroup="validar" />
            </td>
        </tr>
        </table>       
</fieldset>
    </form>
</body>
</html>
