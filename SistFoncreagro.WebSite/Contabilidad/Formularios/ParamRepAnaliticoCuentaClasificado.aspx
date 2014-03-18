<%@ Page Title="Reporte Análitico por Cuenta Clasificado" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ParamRepAnaliticoCuentaClasificado.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepAnaliticoCuentaClasificado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;<table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;PARÁMETROS PARA MOSTRAR EL REPORTE ANALITICO POR CUENTA clasificado</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" 
                                ToolTip="Cerrar" CausesValidation="False" />
                        </td>
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
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Hasta:</td>
                        <td style="text-align: left">

        
            <telerik:RadDatePicker ID="RadDatePicker2" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Tipo:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AllowCustomText="True" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="50%">
                                                                                                <Items>
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="General" Value="General" 
                                                                                                        Selected="True" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Institucional" 
                                                                                                        Value="Institucional" />
                                                                                                    <telerik:RadComboBoxItem runat="server" Text="Proyectos" Value="Proyectos" />
                                                                                                </Items>
                                                                                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                ToolTip="Mostrar" AccessKey="s" style="width: 28px" />










                                                
                                                
        




                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                Font-Names="Arial" Font-Size="7pt">
                                <Columns>
                                    <asp:BoundField DataField="CodProyecto" HeaderText="CodProyecto" 
                                        SortExpression="CodProyecto" />
                                    <asp:BoundField DataField="Anio" HeaderText="Anio" SortExpression="Anio" />
                                    <asp:BoundField DataField="Mes" HeaderText="Mes" SortExpression="Mes" />
                                    <asp:BoundField DataField="IdSubDiario" HeaderText="IdSubDiario" 
                                        SortExpression="IdSubDiario" />
                                    <asp:BoundField DataField="Comprobante" HeaderText="Comprobante" 
                                        SortExpression="Comprobante" />
                                    <asp:BoundField DataField="FechaContable" HeaderText="FechaContable" 
                                        SortExpression="FechaContable" />
                                    <asp:BoundField DataField="FechaDocumento" HeaderText="FechaDocumento" 
                                        SortExpression="FechaDocumento" />
                                    <asp:BoundField DataField="Mayor" HeaderText="Mayor" SortExpression="Mayor" />
                                    <asp:BoundField DataField="Cuenta" HeaderText="Cuenta" 
                                        SortExpression="Cuenta" />
                                    <asp:BoundField DataField="CCosto" HeaderText="CCosto" 
                                        SortExpression="CCosto" />
                                    <asp:BoundField DataField="CargoMN" HeaderText="CargoMN" 
                                        SortExpression="CargoMN" />
                                    <asp:BoundField DataField="AbonoMN" HeaderText="AbonoMN" 
                                        SortExpression="AbonoMN" />
                                    <asp:BoundField DataField="CargoME" HeaderText="CargoME" 
                                        SortExpression="CargoME" />
                                    <asp:BoundField DataField="AbonoME" HeaderText="AbonoME" 
                                        SortExpression="AbonoME" />
                                    <asp:BoundField DataField="TipoCambio" HeaderText="TipoCambio" 
                                        SortExpression="TipoCambio" />
                                    <asp:BoundField DataField="IdMoneda" HeaderText="IdMoneda" 
                                        SortExpression="IdMoneda" />
                                    <asp:BoundField DataField="Documento" HeaderText="Documento" 
                                        SortExpression="Documento" />
                                    <asp:BoundField DataField="SerieDocumento" HeaderText="SerieDocumento" 
                                        SortExpression="SerieDocumento" />
                                    <asp:BoundField DataField="NroDocumento" HeaderText="NroDocumento" 
                                        SortExpression="NroDocumento" />
                                    <asp:BoundField DataField="Glosa" HeaderText="Glosa" SortExpression="Glosa" />
                                    <asp:BoundField DataField="Registro" HeaderText="Registro" ReadOnly="True" 
                                        SortExpression="Registro" />
                                    <asp:BoundField DataField="Coa" HeaderText="Coa" ReadOnly="True" 
                                        SortExpression="Coa" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDatos" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                SelectCommand="RepAnaliticoCuentaClasificado" 
                                SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="RadDatePicker1" Name="FechaInicio" 
                                        PropertyName="SelectedDate" Type="DateTime" />
                                    <asp:ControlParameter ControlID="RadDatePicker2" Name="FechaFin" 
                                        PropertyName="SelectedDate" Type="DateTime" />
                                    <asp:ControlParameter ControlID="RadComboBox1" Name="tipo" 
                                        PropertyName="SelectedValue" Type="String"  />
                                </SelectParameters>
                            </asp:SqlDataSource>










                                                
                                                
        




                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                            </telerik:RadAjaxManager>


                                                
                                                
        






                                                
                                                
        



                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

