﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaHistoricoRequerimiento.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaHistoricoRequerimiento" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .CajaDialogo
        {}
        .jcv
        {
            width: 735px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="PanelDetalleRechazo" runat="server" CssClass="CajaDialogo" 
        Width="726px">
                <fieldset class="jcv">
<legend class="legendJcv">Histórico Requerimiento</legend>
    <table style="width: 93%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="height: 30px;" colspan="2">
                <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
                </telerik:RadScriptManager>
            </td>
        </tr>
        <tr>
            <td colspan="2">
               <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="odsHistorico" Width="720px" Font-Size="10pt">
                    <Columns>
                        <asp:BoundField DataField="NombrePersonaRechaza" HeaderText="Rechazado Por" 
                            ReadOnly="True" SortExpression="NombrePersonaRechaza" >
                        <HeaderStyle HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Motivo" HeaderText="Motivo" 
                            SortExpression="Motivo" />
                        <asp:BoundField DataField="DetalleAprobacion" HeaderText="Detalle Aprobación" 
                            SortExpression="DetalleAprobacion" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="odsHistorico" runat="server" 
                    SelectMethod="GetAllFromHistoricoByIdRequerimiento" 
                    TypeName="SistFoncreagro.BussinesLogic.HistoricoRequerimientoBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="idRequerimiento" QueryStringField="IdReq" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 65px">
                &nbsp;</td>
            <td align="right">
                &nbsp;</td>
        </tr>
    </table>
</fieldset>
    </asp:Panel>
    </div>
    </form>
</body>
</html>
