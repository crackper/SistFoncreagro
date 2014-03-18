<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmReporteCurvaSporProyecto.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmReporteCurvaSporProyecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla5">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;PARÁMETROS PARA MOSTRAR reportE DE EJECUTADOS</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Logistica/DefaultLogistica.aspx" 
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
                        <td colspan="3">
            Indique los datos solicitados, luego haga clic en el botón &quot;Mostrar&quot;.</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3" style="font-family: Arial; font-size: 3pt">
                            &nbsp;</td>
                        <td style="font-family: Arial; font-size: 3pt">
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td class="style4">
                            Proyecto :</td>
                        <td width="1%">
                            &nbsp;</td>
                        <td style="text-align: left" class="style3">

        
                                                                                            <telerik:RadComboBox ID="rcmbProyecto" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" TabIndex="1">
                                                                                            </telerik:RadComboBox>




                        &nbsp;</td>
                        <td style="text-align: left" width="77%">

        
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="rcmbProyecto" ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>




                        </td>
                    </tr>
                    <tr class="Texto">
                        <td class="style4">
                            Componente :</td>
                        <td width="1%">
                            &nbsp;</td>
                        <td style="text-align: left" class="style3">

        
                                                                                            <telerik:RadComboBox ID="rcmbComponente" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsComponente" DataTextField="_Componente" 
                                                                                                DataValueField="IdComponente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" TabIndex="1" AutoPostBack="True">
                                                                                            </telerik:RadComboBox>




                        </td>
                        <td style="text-align: left" width="77%">

        
                                                                                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td class="style4">
                            Actividad :</td>
                        <td width="1%">
                            &nbsp;</td>
                        <td style="text-align: left" class="style3">

        
                                                                                            <telerik:RadComboBox ID="rcmbActividad" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="SDSActividad" DataTextField="Nombre" 
                                                                                                DataValueField="IdActividad" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" TabIndex="1" AutoPostBack="True">
                                                                                            </telerik:RadComboBox>




                        </td>
                        <td style="text-align: left" width="77%">

        
                                                                                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td class="style4">
                            C. Costo :</td>
                        <td width="1%">
                            &nbsp;</td>
                        <td style="text-align: left" class="style3">

        
                                                                                            <telerik:RadComboBox ID="rcmbCcosto" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="SDScCosto" DataTextField="CCosto" 
                                                                                                DataValueField="IdCCosto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" TabIndex="1">
                                                                                            </telerik:RadComboBox>




                        </td>
                        <td style="text-align: left" width="77%">

        
                                                                                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td class="style4">
                            Moneda :</td>
                        <td width="1%">
                            &nbsp;</td>
                        <td style="text-align: left" class="style3">

        
                                                                                            <telerik:RadComboBox ID="rcmbMoneda" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsMoneda" DataTextField="Nombre" 
                                                                                                DataValueField="Nombre" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="20%" TabIndex="1">
                                                                                            </telerik:RadComboBox>




                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="rcmbMoneda" ErrorMessage="*" 
                                                                                                ValidationGroup="a"></asp:RequiredFieldValidator>




                        </td>
                        <td style="text-align: left" width="77%">

        
                                                                                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td class="style4">
                            Fecha :</td>
                        <td width="2%">
                            &nbsp;</td>
                        <td style="text-align: left" class="style3">

        
                            Desde :&nbsp;

        
            <telerik:RadDatePicker ID="rdpFechaInicio" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="rdpFechaInicio" ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
&nbsp;




                        &nbsp; Hasta :&nbsp;

        
            <telerik:RadDatePicker ID="rdpFechaFin" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="rdpFechaFin" ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>




                        </td>
                        <td style="text-align: left" width="77%">

        
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td class="style4">
                            &nbsp;</td>
                        <td width="2%">
                            &nbsp;</td>
                        <td style="text-align: left" class="style3">

        
                            &nbsp;</td>
                        <td style="text-align: left" width="77%">

        
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td class="style4">
                            &nbsp;</td>
                        <td width="2%">
                            &nbsp;</td>
                        <td style="text-align: left" class="style3">

        
                            &nbsp;</td>
                        <td style="text-align: left" width="77%">

        
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                        <td style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                ToolTip="Mostrar" AccessKey="s" ValidationGroup="a" />
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsComponente" runat="server" 
                                                    SelectMethod="GetProyCompByIdProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyCompBL">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="rcmbProyecto" DefaultValue="0" Name="_idProy" 
                                                            PropertyName="SelectedValue" Type="Int32" />
                                                    </SelectParameters>
                            </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsMoneda" runat="server" 
                                                    SelectMethod="GetAllFromMoneda" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.MonedaBL">
                                                </asp:ObjectDataSource>
                            <asp:SqlDataSource ID="SDSActividad" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                SelectCommand="ObtenerActividad" SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="rcmbComponente" Name="IdComponente" 
                                        PropertyName="SelectedValue" Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            <asp:SqlDataSource ID="SDScCosto" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                SelectCommand="ObtenerCCosto" SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="rcmbActividad" Name="IdActividad" 
                                        PropertyName="SelectedValue" Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="rcmbProyecto">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="rcmbComponente" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="rcmbComponente">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="rcmbActividad" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="rcmbActividad">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="rcmbCcosto" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="rcmbProyecto" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>
    </telerik:RadAjaxManager>
                        </td>
                        <td style="text-align: center">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .style3
        {
            width: 68%;
        }
        .style4
        {
            width: 13%;
        }
        .style1
        {
            width: 727px;
        }
    </style>
</asp:Content>

