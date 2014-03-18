<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaSubirFotoyCV.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaSubirFotoyCV" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    var parametro = 0;
    var tipo = 0;

    function CargarVentana(nombre) {
        window.open("../../Archivos/RRHH/CV/" + nombre, nombre, "width=800, height=500")
//        window.open("../Archivos/RRHH/CV/" + nombre, nombre, "width=800, height=500")
    }
    function CargarVentanaFoto(nombre) {
        window.open("../../Archivos/RRHH/Fotos/" + nombre, nombre, "width=400, height=400")
    }
</script>
</telerik:RadCodeBlock>
<head runat="server">
    <title></title>
</head>
<body style="width: 610px;">
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div>
    
        <table width="100%" style="font-family: Arial; font-size: 9pt">
            <tr>
                <td width="100">
                    Adjuntar Foto</td>
                <td width="430">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="100" align="right">
                    Archivo:</td>
                <td width="430">
                    <asp:FileUpload ID="FileUploadControl" runat="server" 
                        ToolTip="Adjuntar archivos" Width="430px" />
                </td>
                <td align="left">
                    <asp:ImageButton ID="btnAdjuntarFoto" runat="server" 
                        ImageUrl="~/img/upload.gif" />
                </td>
            </tr>
            <tr>
                <td width="100">
                    &nbsp;</td>
                <td width="430">
                    <asp:Label ID="lblMsnFoto" runat="server" style="color: #006699" Width="100%"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="100">
                    &nbsp;</td>
                <td width="430">
                    <asp:Panel ID="PanelFoto" runat="server">
                        <table style="border: 1px solid #808080; background-color: #FFFFFF;" 
    width="100%" cellpadding = "0" cellspacing="0" >
                            <tr>
                                <td>
                                    <asp:Label ID="lblFoto" runat="server" Width="100%"></asp:Label>
                                </td>
                                <td width="28" align="center" style="border-style: none solid none solid; border-width: 1px; border-color: #808080;" 
                                valign="middle">
                                    <asp:ImageButton ID="btnEliminarFoto" runat="server" 
                                    ImageUrl="~/img/Cancel.gif" />
                                </td>
                                <td width="28">
                                    <asp:ImageButton ID="btnAbrirFoto" runat="server" 
                                    ImageUrl="~/img/OpenFile.gif" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" width="530">
                    Adjuntar Curriculum Vitae</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="100" align="right">
                    Archivo:</td>
                <td width="430">
                    <asp:FileUpload ID="FileUploadControl2" runat="server" 
                        ToolTip="Adjuntar archivos" Width="430px" />
                </td>
                <td align="left">
                    <asp:ImageButton ID="btnAdjuntarCV" runat="server" 
                        ImageUrl="~/img/upload.gif" />
                </td>
            </tr>
            <tr>
                <td width="100">
                    &nbsp;</td>
                <td width="430">
                    <asp:Label ID="lblMsnCV" runat="server" style="color: #006699" Width="100%"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="100">
                    &nbsp;</td>
                <td width="430">
                    <asp:Panel ID="PanelArchivo" runat="server">
                        <table style="border: 1px solid #808080; background-color: #FFFFFF;" 
    width="100%" cellpadding = "0" cellspacing="0" >
                            <tr>
                                <td>
                                    <asp:Label ID="lblCV" runat="server" Width="100%"></asp:Label>
                                </td>
                                <td width="28" align="center" style="border-style: none solid none solid; border-width: 1px; border-color: #808080;" 
                                valign="middle">
                                    <asp:ImageButton ID="btnEliminarCV" runat="server" 
                                    ImageUrl="~/img/Cancel.gif" />
                                </td>
                                <td width="28">
                                    <asp:ImageButton ID="btnAbriCv" runat="server" 
                                    ImageUrl="~/img/OpenFile.gif" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
