<%@ Page Title="Reporte Analítico por Centro de Costos" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ParamRepAnaliticoCCosto.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamRepAnaliticoCCosto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;PARÁMETROS PARA MOSTRAR EL REPORTE ANALITICO POR CENTRO DE COSTOS</td>
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
                                                                                                
                                AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="Proyecto" 
                                                                                                
                                DataValueField="codigo" EnableLoadOnDemand="True" 
                                                                                                
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
                                                                                                DataSourceID="SqlDataSource2" DataTextField="Proyecto" 
                                                                                                DataValueField="codigo" EnableLoadOnDemand="True" 
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
                    <tr>
                        <td colspan="2" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                ToolTip="Mostrar" AccessKey="s" style="width: 28px" />
                                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="SELECT
	substring(codigo+' '+nombre,1,70) as Proyecto,
codigo
FROM [dbo].[PROYECTO] [pROYECTO]
ORDER BY [pROYECTO].[Codigo]"></asp:SqlDataSource>










                                                
                                                
        




<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="SELECT cCOSTO.IdCCosto, cCOSTO.Codigo + ' ' + ELEMENTOGASTO.NomElemGasto AS CodigoElemGasto ,cCOSTO.Codigo
	FROM CCOSTO AS cCOSTO INNER JOIN PROYACT ON cCOSTO.IdProyAct = PROYACT.IdProyAct 
	INNER JOIN PROYCOMP ON PROYACT.IdProycomp = PROYCOMP.IdProyComp 
	INNER JOIN CONVEPROY ON PROYCOMP.IdConvProy = CONVEPROY.IdConvProy 
INNER JOIN PROYECTO ON PROYECTO.IDPROYECTO=CONVEPROY.IDPROYECTO 
	INNER JOIN ELEMENTOGASTO ON cCOSTO.IdElemGasto = ELEMENTOGASTO.IdElemGasto
	WHERE (PROYECTO.CODIGO = @idProyecto) and SUBSTRING(CCOSTO.Codigo,1,4)&lt;&gt;'ZZZZ'
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
                                </AjaxSettings>
                            </telerik:RadAjaxManager>


                                                
                                                
        






                                                
                                                
        



                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

