<%@ Page Title="Parametros para Validar Votación" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="ParamVotacion.aspx.vb" Inherits="SistFoncreagro.WebSite.ParamVotacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    function onRequestStart(sender, args) {
        if (args.get_eventTarget().indexOf("ExportToExcelButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToWordButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToPdfButton") >= 0) {
            args.set_enableAjax(false);
        }
    }
    </script>
    <table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;PARÁMETROS PARA verificar votacion</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/RRHH/Formulario/PrincipalRRHH.aspx" 
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
                            Año:</td>
                        <td style="text-align: left" width="77%">

        
                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" MaxLength="4" 
                                ShowSpinButtons="True" Width="75px" AutoPostBack="True">
                                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                <NumberFormat DecimalDigits="0" GroupSeparator="" />
                            </telerik:RadNumericTextBox>




                        </td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%">
                            Encuesta:</td>
                        <td style="text-align: left" width="77%">

        
                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" 
                                DataSourceID="SqlEncuestas" DataTextField="Descripcion" 
                                DataValueField="IdEncuesta" Width="300px">
                            </telerik:RadComboBox>




                        </td>
                    </tr>
                    <tr class="Texto">
                        <td width="10%" colspan="2" style="width: 87%; text-align: center;">
                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/Buscar.gif" />
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td colspan="2">
                            <asp:SqlDataSource ID="SqlEncuestas" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                SelectCommand="GetENCUESTAByAnio" SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="RadNumericTextBox1" Name="Anio" 
                                        PropertyName="Text" Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                            <ClientEvents OnRequestStart="onRequestStart" />
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="RadNumericTextBox1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadComboBox1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadComboBox1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
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




