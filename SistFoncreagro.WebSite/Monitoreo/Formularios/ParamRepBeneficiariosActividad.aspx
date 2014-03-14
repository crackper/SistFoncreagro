<%@ Page Title="Beneficiarios por Actividad" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="ParamRepBeneficiariosActividad.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepBeneficiariosActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;PARÁMETROS PARA MOSTRAR EL reporte</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table align="center" class="style1" >
                    <tr class="Texto">
                        <td colspan="2">
            Indique los datos solicitados, luego haga clic en el botón &quot;Mostrar&quot;.</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="font-family: Arial; font-size: 3pt">
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%">
                            Desde:</td>
                        <td style="text-align: left" width="77%">
                            <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
                                <Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x">
                                </Calendar>
                                <DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy">
                                </DateInput>
                                <DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario.">
                                </DatePopupButton>
                            </telerik:RadDatePicker>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Hasta:</td>
                        <td style="text-align: left">
                            <telerik:RadDatePicker ID="RadDatePicker2" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
                                <Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x">
                                </Calendar>
                                <DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy">
                                </DateInput>
                                <DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario.">
                                </DatePopupButton>
                            </telerik:RadDatePicker>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Actividad:</td>
                        <td style="text-align: left">
                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                DataSourceID="SqlActividades" DataTextField="NomTarea" 
                                                                                                
                                DataValueField="IdSubActividad" EnableLoadOnDemand="True" 
                                                                                                
                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                
                                ValidationGroup="Transaccion" Width="98%" TabIndex="1">
                            </telerik:RadComboBox>
                            <asp:SqlDataSource ID="SqlActividades" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                SelectCommand="GetActividdesPoaTecnico" SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:SessionParameter Name="IdProyecto" SessionField="IdProyecto" 
                                        Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                ToolTip="Mostrar" AccessKey="s" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
