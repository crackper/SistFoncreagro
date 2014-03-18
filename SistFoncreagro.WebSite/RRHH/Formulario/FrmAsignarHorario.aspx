<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmAsignarHorario.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmAsignarHorario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        
    
    
     .fondoTabla
{
    width: 100%;
    background-color: #0C3B2A;
    color: #FFFFFF;
    font-weight: bold;
    font-variant: normal;
    width: 100%;
    text-transform: uppercase;
}
    
        .style2
        {
            font-family: Arial;
            font-size: 9pt;
        }
        
    
    
     </style>
</head>
<body style="width: 630px; background-color: #FFCC00;">
    <form id="form1" runat="server">
    <div>
    
        <table width="605" bgcolor="White">
            <tr>
                <td width="10">
                    &nbsp;</td>
                <td>
                            <table width="100%">
                                <tr>
                                    <td align="center" rowspan="4" width="10">
                                        &nbsp;</td>
                                    <td valign="top">
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblNombre" runat="server" Height="25px" 
                                                        style="font-weight: 700; font-size: medium" Width="100%"></asp:Label>
                                                </td>
                                                <td align="left" valign="middle" width="100">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                        <asp:Label ID="lblArea" runat="server" 
                                            style="font-weight: 700; font-size: medium" Width="100%">
                                </asp:Label>
                                        <asp:Label ID="lblCargo" runat="server" 
                                            style="font-weight: 700; font-size: medium" Width="100%">
                                </asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                <td width="10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="10">
                    &nbsp;</td>
                <td>
    
        <table width="600" style="border: 1px solid #C0C0C0">
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    <table class="style1">
                        <tr>
                            <td style="font-family: Arial; font-size: 9pt; text-align: right" width="80">
                                Horario:</td>
                            <td width="200">
                                <asp:DropDownList ID="ddlHorario" runat="server" DataSourceID="odsHorario" 
                                    DataTextField="DescripcionCompleta" DataValueField="ClavesPrimarias" 
                                    Width="100%">
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="odsHorario" runat="server" 
                                    SelectMethod="GetAllFromHORARIO" 
                                    TypeName="SistFoncreagro.BussinesLogic.HorarioBL"></asp:ObjectDataSource>
                            </td>
                            <td width="20">
                                &nbsp;</td>
                            <td style="font-family: Arial; font-size: 9pt; text-align: right" width="50">
                                Desde:</td>
                            <td width="120">
                                <telerik:RadDatePicker ID="rdpIniHorario" Runat="server" Width="115px" 
                                    AutoPostBack="True" Culture="es-PE">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" AutoPostBack="True"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                                </telerik:RadDatePicker>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td width="80">
                                &nbsp;</td>
                            <td width="200">
                                &nbsp;</td>
                            <td width="20">
                                &nbsp;</td>
                            <td width="50">
                                &nbsp;</td>
                            <td width="120">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    <asp:Panel ID="Panel1" runat="server">
                        <table class="style1">
                            <tr>
                                <td colspan="7">
                                    <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                                        <tr>
                                            <td class="style2">
                                                GENERAR CONTROL DE ASISTENCIA DEL MES</td>
                                            <td width="40px">
                                                &nbsp;</td>
                                            <td style="text-align: right; width:110px">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-family: Arial; font-size: 9pt; text-align: right" width="60">
                                    &nbsp;</td>
                                <td style="font-family: Arial; font-size: 9pt; text-align: right" width="60">
                                    Desde:</td>
                                <td width="120">
                                    <asp:TextBox ID="txtFechaIni" runat="server" Width="115px"></asp:TextBox>
                                </td>
                                <td style="font-family: Arial; font-size: 9pt; text-align: right" width="60">
                                    Hasta:</td>
                                <td width="120">
                                    <asp:TextBox ID="txtFechaFin" runat="server" Width="115px"></asp:TextBox>
                                </td>
                                <td width="40">
                                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Update.gif" />
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="font-family: Arial; font-size: 9pt; text-align: right" width="60">
                                    &nbsp;</td>
                                <td style="font-family: Arial; font-size: 9pt; text-align: right" width="60">
                                    &nbsp;</td>
                                <td width="120">
                                    &nbsp;</td>
                                <td style="font-family: Arial; font-size: 9pt; text-align: right" width="60">
                                    &nbsp;</td>
                                <td width="120">
                                    &nbsp;</td>
                                <td width="40">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        style="font-family: Arial; font-size: 9pt" 
                        DataSourceID="ODSHorariosAsignados">
                        <Columns>
                            <asp:BoundField DataField="IdAsignacionHorario" 
                                HeaderText="IdAsignacionHorario" SortExpression="IdAsignacionHorario" />
                            <asp:BoundField DataField="IdPeriodoLaboral" HeaderText="IdPeriodoLaboral" 
                                SortExpression="IdPeriodoLaboral" />
                            <asp:BoundField DataField="IdHorario" HeaderText="IdHorario" 
                                SortExpression="IdHorario" />
                            <asp:BoundField DataField="IdJornadaTrabajo" HeaderText="IdJornadaTrabajo" 
                                SortExpression="IdJornadaTrabajo" />
                            <asp:BoundField DataField="FechaInicio" HeaderText="FechaInicio" 
                                SortExpression="FechaInicio" />
                            <asp:BoundField DataField="FechaFin" HeaderText="FechaFin" 
                                SortExpression="FechaFin" />
                        </Columns>
                    </asp:GridView>
                    <asp:ObjectDataSource ID="ODSHorariosAsignados" runat="server" 
                        SelectMethod="GetHorarioAsignadoByIdPeriodoLaboral" 
                        TypeName="SistFoncreagro.BussinesLogic.HorarioAsignadoBL">
                        <SelectParameters>
                            <asp:SessionParameter Name="IdPeriodoLaboral" SessionField="IdPeriodoLaboral" 
                                Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td width="15">
                    &nbsp;</td>
            </tr>
        </table>
    
                </td>
                <td width="10">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
