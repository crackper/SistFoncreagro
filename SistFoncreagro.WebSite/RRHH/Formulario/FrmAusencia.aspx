<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmAusencia.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmAusencia" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 550px;
        }
        .style2
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Grabar.gif" 
                        ToolTip="Grabar" />
                </td>
            </tr>
            <tr>
                <td>
                    <table class="style1">
                        <tr>
                            <td width="10%">
                                Motivo:</td>
                            <td colspan="5" style="width: 90%">
                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                    DataSourceID="odsMotivos" DataTextField="Motivo" 
                                    DataValueField="IdMotivoAusencia" style="font-family: Arial; font-size: 8pt" 
                                    Width="100%" AppendDataBoundItems="True">
                                    <asp:ListItem Value="0">Elija el Motivo...</asp:ListItem>
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="odsMotivos" runat="server" 
                                    SelectMethod="GetAllFromMOTIVOAUSENCIA" 
                                    TypeName="SistFoncreagro.BussinesLogic.MotivoAusenciaBL">
                                </asp:ObjectDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Desde:</td>
                            <td>
                                <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Width="100px" 
                                    AutoPostBack="True">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" AutoPostBack="True"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                                </telerik:RadDatePicker>
                            </td>
                            <td width="8%">
                                Hasta:</td>
                            <td>
                                <telerik:RadDatePicker ID="RadDatePicker2" Runat="server" Width="100px" 
                                    AutoPostBack="True">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" AutoPostBack="True"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                                </telerik:RadDatePicker>
                            </td>
                            <td>
                                Total Días:</td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="30px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Motivo:" Visible="False"></asp:Label>
                            </td>
                            <td colspan="5" style="text-align: left">
                                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Visible="False" 
                                    Width="100%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:Label ID="Label2" runat="server" Text="Archivo:" Visible="False"></asp:Label>
                            </td>
                            <td colspan="5">
                                <asp:Panel ID="Panel1" runat="server" Visible="False">
                                    <table class="style2">
                                        <tr>
                                            <td>
                                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:FileUpload ID="FileUploadControl" runat="server" 
                                                    ToolTip="Adjuntar archivos" Width="430px" />
                                                <asp:ImageButton ID="btnAdjuntar" runat="server" ImageUrl="~/img/upload.gif" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblMsn" runat="server" style="color: #006699" Width="100%"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table cellpadding="0" cellspacing="0" 
                                                    style="border: 1px solid #808080; background-color: #FFFFFF;" width="100%">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="lbl" runat="server" Width="100%"></asp:Label>
                                                        </td>
                                                        <td align="center" 
                                                            style="border-style: none solid none solid; border-width: 1px; border-color: #808080;" 
                                                            valign="middle" width="28">
                                                            <asp:ImageButton ID="btnEliminar" runat="server" ImageUrl="~/img/Cancel.gif" />
                                                        </td>
                                                        <td width="28">
                                                            <asp:ImageButton ID="btnAbrir" runat="server" ImageUrl="~/img/OpenFile.gif" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td colspan="5">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td colspan="5">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
     <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        
        function AdjuntarArchivos() {
            var oWnd = radopen("VentanaAdjuntarCITT.aspx", "VentanaAdjuntar");
            return false;
        }

        function CerrarRadWindow(oWnd, args) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ActualizarPagina");
        }


        //                    var oWnd = radopen("WFormSolicitarCierreOT.aspx?IdOT=" + idord,"SolicitarCierre");
        //            return false;
     </script>
</telerik:RadCodeBlock>
     <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                    <Windows>
                            <telerik:RadWindow ID="VentanaAdjuntar" runat="server" Animation="Resize" AnimationDuration="200" Width="780 px" 
                            Height="300px" Title="Adjuntar Archivo" Left="150px" ReloadOnShow="True" 
                            ShowContentDuringLoad="False" Modal="True" OnClientClose="CerrarRadWindow"></telerik:RadWindow>
                    </Windows>

      </telerik:RadWindowManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    </form>
</body>
</html>
