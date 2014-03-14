<%@ Page Title="Reporte Analítico por Cuenta" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ParamRepAnaliticoCuenta.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepAnaliticoCuenta" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;<table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;PARÁMETROS PARA MOSTRAR EL REPORTE ANALITICO POR CUENTA</td>
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
                            Proyecto Inicio:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox9" Runat="server" AllowCustomText="True" 
                                                                                                
                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                
                                DataValueField="Codigo" EnableLoadOnDemand="True" 
                                                                                                
                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                
                                ValidationGroup="Transaccion" Width="100%" TabIndex="1">
                                                                                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Proyecto Fin:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="False" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="Codigo" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="100%" TabIndex="1">
                                                                                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            C. Costo Inicio:</td>
                        <td style="text-align: left">
            <telerik:RadComboBox ID="RadComboBox2" Runat="server" Width="100%" 
                 EnableLoadOnDemand="True" MarkFirstMatch="True" 
                DataSourceID="SqlDataSource1" DataTextField="CodigoElemGasto" 
                DataValueField="Codigo" AllowCustomText="True" EnableAjaxSkinRendering="False" 
                                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                
                                EnableEmbeddedSkins="False" AutoPostBack="True">
            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            C. Costo Fin:</td>
                        <td style="text-align: left">
            <telerik:RadComboBox ID="RadComboBox10" Runat="server" Width="100%" 
                 EnableLoadOnDemand="True" MarkFirstMatch="True" 
                DataSourceID="SqlDataSource1" DataTextField="CodigoElemGasto" 
                DataValueField="Codigo" AllowCustomText="True" EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                EnableEmbeddedSkins="False">
            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Cuenta Inicio:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox1" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="Codigo" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="100%" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                
                                EnableAjaxSkinRendering="False" EnableVirtualScrolling="True" 
                                                                                                
                                AllowCustomText="True" DataSourceID="SqlCuentas" AutoPostBack="True">
                                                                                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td>
                            Cuenta Fin:</td>
                        <td style="text-align: left">
                                                                                            <telerik:RadComboBox ID="RadComboBox11" 
                Runat="server"  
                                                                                                
                DataTextField="Cuenta" 
                DataValueField="Codigo" 
                                                                                                
                EnableLoadOnDemand="True" 
                ShowDropDownOnTextboxClick="False" 
                                                                                                
                MarkFirstMatch="True" 
                ValidationGroup="Linea" 
                                                                                                
                Width="100%" EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                
                                EnableAjaxSkinRendering="False" EnableVirtualScrolling="True" 
                                                                                                
                                AllowCustomText="True" DataSourceID="SqlCuentas">
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
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>










                                                
                                                
        




                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                DataSourceID="SqlDatos" Font-Names="Arial" Font-Size="7pt">
                                <Columns>
                                    <asp:BoundField DataField="TIPO" HeaderText="Tipo" 
                                        SortExpression="TIPO" />
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
                                    <asp:BoundField DataField="CtaGral" HeaderText="CtaGral" 
                                        SortExpression="CtaGral" />
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
                                    <asp:BoundField DataField="Glosa" HeaderText="Glosa" SortExpression="Glosa" />
                                    <asp:BoundField DataField="Registro" HeaderText="Registro" ReadOnly="True" 
                                        SortExpression="Registro" />
                                    <asp:BoundField DataField="Coa" HeaderText="Coa" ReadOnly="True" 
                                        SortExpression="Coa" />
                                    <asp:BoundField DataField="IdMoneda" HeaderText="Moneda" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDatos" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                SelectCommand="RepAnaliticoCuenta" SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="RadComboBox9" Name="ProyectoInicio" 
                                        PropertyName="SelectedValue" Type="String" />
                                    <asp:ControlParameter ControlID="RadComboBox3" Name="ProyectoFin" 
                                        PropertyName="SelectedValue" Type="String" />
                                    <asp:ControlParameter ControlID="RadComboBox2" Name="CCostoInicio" 
                                        PropertyName="SelectedValue" Type="String" />
                                    <asp:ControlParameter ControlID="RadComboBox10" Name="CCostoFin" 
                                        PropertyName="SelectedValue" Type="String" />
                                    <asp:ControlParameter ControlID="RadComboBox1" Name="CuentaInicio" 
                                        PropertyName="SelectedValue" Type="String" />
                                    <asp:ControlParameter ControlID="RadComboBox11" Name="CuentaFin" 
                                        PropertyName="SelectedValue" Type="String" />
                                    <asp:ControlParameter ControlID="RadDatePicker1" Name="FechaInicio" 
                                        PropertyName="SelectedDate" Type="DateTime" />
                                    <asp:ControlParameter ControlID="RadDatePicker2" Name="FechaFin" 
                                        PropertyName="SelectedDate" Type="DateTime" />
                                </SelectParameters>
                            </asp:SqlDataSource>










                                                
                                                
        




<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="SELECT cCOSTO.IdCCosto, cCOSTO.Codigo + ' ' + ELEMENTOGASTO.NomElemGasto AS CodigoElemGasto ,cCOSTO.Codigo
	FROM CCOSTO AS cCOSTO INNER JOIN PROYACT ON cCOSTO.IdProyAct = PROYACT.IdProyAct 
	INNER JOIN PROYCOMP ON PROYACT.IdProycomp = PROYCOMP.IdProyComp 
	INNER JOIN CONVEPROY ON PROYCOMP.IdConvProy = CONVEPROY.IdConvProy 
INNER JOIN PROYECTO ON PROYECTO.IDPROYECTO=CONVEPROY.IDPROYECTO 
	INNER JOIN ELEMENTOGASTO ON cCOSTO.IdElemGasto = ELEMENTOGASTO.IdElemGasto
	WHERE (PROYECTO.CODIGO = @idProyecto)
	order by cCOSTO.Codigo">
    <SelectParameters>
        <asp:ControlParameter ControlID="RadComboBox9" Name="idProyecto" 
            PropertyName="SelectedValue" Type="String" />
    </SelectParameters>
</asp:SqlDataSource>


                                                
                                                
        






                                                
                                                
        



                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="RadComboBox9">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadComboBox3" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadComboBox2">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadComboBox10" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadComboBox1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadComboBox11" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>
                            </telerik:RadAjaxManager>


                                                
                                                
        






                                                
                                                
        



                            <asp:SqlDataSource ID="SqlCuentas" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                SelectCommand="GetCuentasDetalle" SelectCommandType="StoredProcedure">
                            </asp:SqlDataSource>


                                                
                                                
        






                                                
                                                
        



                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

