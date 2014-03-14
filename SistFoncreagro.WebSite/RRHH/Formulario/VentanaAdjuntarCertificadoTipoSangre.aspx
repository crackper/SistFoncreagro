<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaAdjuntarCertificadoTipoSangre.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaAdjuntarCertificadoTipoSangre" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table width="100%" style="font-family: Arial; font-size: 9pt">
            <tr>
                <td width="100">
                    Adjuntar Archivo</td>
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
                        ToolTip="Adjuntar archivos" Width="425px" />
                </td>
                <td align="left">
                    <asp:ImageButton ID="btnAdjuntarArchivo" runat="server" 
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
                                    <asp:Label ID="lblArchivo" runat="server" Width="100%"></asp:Label>
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
            </table>
    
    </div>
    </form>
</body>
</html>
