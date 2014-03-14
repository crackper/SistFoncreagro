<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmPosicion.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmPosicion" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    <style type="text/css" >
        .Texto 
        {
            font-size: 9pt;
            font-family: Arial;
            
        }
       
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
    
    </style>

    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
                    <script type="text/javascript">
                        function NuevoColaborador() {
                            var oWnd = radopen("FrmNuevoCargoFlotante.aspx", "NuevoCargo");
                            return false;
                        }
                        function CerrarRadWindow(oWnd, args) {
                            var arg = args.get_argument();
                            if (arg) {
                                if (arg.indicador >= 1) {
                                    $find("<%= AJAX_MANAGER.ClientID %>").ajaxRequest("ActualizarCombo|" + arg.indicador);
                                }
                            }
                        }
                </script>
     </telerik:RadCodeBlock>
   
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <telerik:RadAjaxManager ID="AJAX_MANAGER" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="txtNuevaHabilidad">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PanelAgregarHabilidad" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="BtnCancelaHab">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PanelAgregarHabilidad" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="LbtnAgregarHabilidad">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PanelHabilidadNueva" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnAgregarHabilidad">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PanelHabilidadNueva" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="BtnCancelaReq">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PanelAgregarRequisito" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="BtnAceptarReq">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PanelAgregarRequisito" />
                    <telerik:AjaxUpdatedControl ControlID="gvRequisitoAd" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="LbtnAgregarRequisito">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PanelrequisitoNuevo" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnAgregarRequisito">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="PanelrequisitoNuevo" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <div>
    
        <table class="Texto" width="850">
            <tr>
                <td width="20">
                    &nbsp;</td>
                <td align="center" width="800">
                    <asp:Label ID="lblNombreArea" runat="server" Width="750px"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;</td>
                <td width="800" valign="top">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;</td>
                <td width="800" valign="top">
                    <telerik:RadTreeList ID="RadTreeList1" 
                        runat="server" OnNeedDataSource="RadTreeList1_NeedDataSource" skin="Hay"
                        DataKeyNames="IdPosicion" ParentDataKeyNames="Dependencia" 
                        AutoGenerateColumns="False" AllowMultiItemEdit="False" Culture="(Default)" 
                        IsItemInserted="False">
<EditFormSettings EditFormType="AutoGenerated"></EditFormSettings>

<ValidationSettings CommandsToValidate="PerformInsert,Update"></ValidationSettings>
                     <Columns>
                        <telerik:TreeListTemplateColumn>
                        <ItemTemplate>
                            <asp:Image ID="Empleado" runat="server"  ImageUrl="~/img/empleado.gif" />  
                             <%# Eval("NomCargo")%>
                        </ItemTemplate>
                         <HeaderStyle Width="350px" />
                         <ItemStyle Width="350px" />
                        </telerik:TreeListTemplateColumn>
                        <%--<telerik:TreeListBoundColumn DataField="NomCargo" HeaderText="Posicion" UniqueName="NomCargo"
                            HeaderStyle-Width="350px" />--%>
                        <telerik:TreeListSelectColumn HeaderStyle-Width="35px">
<HeaderStyle Width="35px"></HeaderStyle>
                        </telerik:TreeListSelectColumn>
                        <telerik:TreeListTemplateColumn UniqueName="TemplateColumn" HeaderStyle-Width="35px" ItemStyle-Width="35px" >
                        <ItemTemplate>
                            <asp:ImageButton ID="ImageButton5" runat="server" CommandName="Nuevo" CommandArgument='<%# Eval("IdPosicion") %>' onclick="ImageButton5_Click" ImageUrl="~/img/AddRecord.gif" />
                        </ItemTemplate>
                        <%--<HeaderTemplate>
                            <asp:ImageButton ID="ImageButton5" runat="server" CommandName="NuevoC"  onclick="ImageButton5_Click" ImageUrl="~/img/AddRecord.gif" />
                        </HeaderTemplate>--%>
                            <HeaderStyle Width="35px" />
                            <ItemStyle Width="35px" HorizontalAlign="Center" VerticalAlign="Middle"/>
                        </telerik:TreeListTemplateColumn>
                        <telerik:TreeListTemplateColumn UniqueName="TemplateColumn1">
                        <ItemTemplate>
                            <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/img/Delete.gif" CommandName="Delete" />
                        </ItemTemplate>
                            <HeaderStyle Width="35px" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle Width="35px" HorizontalAlign="Center" />
                        </telerik:TreeListTemplateColumn>
                        <telerik:TreeListBoundColumn DataField="IdPosicion" HeaderText="IdPosicion" 
                             UniqueName="IdPosicion" Visible="False" />
                        <telerik:TreeListBoundColumn DataField="Dependencia" HeaderText="Dependencia" 
                             UniqueName="Dependencia" Visible="False" />
                        <telerik:TreeListBoundColumn DataField="NombreArea" HeaderText="NombreArea" UniqueName="NombreArea" /> 
                         
                    </Columns>

                    </telerik:RadTreeList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;</td>
                <td width="800">
                                    <asp:TextBox ID="txtIdArea" runat="server" Height="20px" 
                        Width="30px" AutoPostBack="True" Visible="False"></asp:TextBox>
                                    <asp:TextBox ID="txtIdPosicionPadre" runat="server" Height="20px" 
                                        Width="30px" Visible="False"></asp:TextBox>
                                    <asp:TextBox ID="txtIdPosicion" runat="server" Height="20px" 
                        Width="30px" Visible="False"></asp:TextBox>
                                    </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;</td>
                <td width="800">
                                                            &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;</td>
                <td width="800" valign="top">
                
                    <asp:Panel ID="panelPosicion" runat="server" BorderColor="#666666" 
                        BorderStyle="Solid" CssClass="Texto" Height="100%" 
                        Width="100%" BorderWidth="1px">
                        <table width="100%">
                            <tr>
                                <td align="left" 
                                    
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #C0C0C0" 
                                    colspan="3">
                                    <table class="fondoTabla" 
                                        style="border-width: 0px; padding: 0px; margin: 0px; background-color: #0C3B2A; color: #FFFFFF;">
                                        <tr>
                                            <td align="left" class="Titulos">
                                                &nbsp;crear nueva posición / editar posicón</td>
                                            <td width="40px">
                                                &nbsp;</td>
                                            <td align="right" style="text-align: right; width: 110px">
                                                <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/img/Cancel.gif" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" 
                                    style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #C0C0C0" 
                                    width="110">
                                    <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/img/Grabar.gif" />
                                </td>
                                <td style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #C0C0C0">
                                    &nbsp;</td>
                                <td style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #C0C0C0" 
                                    width="50">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right" width="110">
                                    Posición:</td>
                                <td>
                                    <telerik:RadComboBox ID="rcbPosicion" Runat="server" AllowCustomText="True" 
                                        CssClass="Texto" DataSourceID="odsCargos" DataTextField="NomCargo" 
                                        DataValueField="IdCargo" EnableAutomaticLoadOnDemand="True" Skin="Hay" 
                                        Width="100%">
                                    </telerik:RadComboBox>
                                </td>
                                <td width="50">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td width="110" align="right" valign="top">
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtDescripcion" runat="server" BorderColor="#999999" 
                                                    BorderStyle="Solid" BorderWidth="0px" Height="16px" style="font-size: small" 
                                                    TextMode="MultiLine" Width="100%" Visible="False"></asp:TextBox>
                                </td>
                                <td width="50">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td width="110" align="right">
                                    Area:</td>
                                <td>
                                    <asp:TextBox ID="txtArea" runat="server" BorderColor="#999999" 
                                                                BorderStyle="Solid" BorderWidth="0px" 
                                                                
                                        style="font-size: 9pt; margin-top: 0px; font-family: Arial;" Width="100%"></asp:TextBox>
                                </td>
                                <td width="50">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td width="110" align="right">
                                    Jefe Inmediato:</td>
                                <td>
                                    <asp:TextBox ID="txtPosicionJefe" runat="server" BorderColor="#999999" 
                                                                BorderStyle="Solid" BorderWidth="0px" 
                                                                
                                        style="font-size: 9pt; margin-top: 0px; font-family: Arial;" Width="100%"></asp:TextBox>
                                </td>
                                <td width="50">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td width="110" align="right">
                                    &nbsp;</td>
                                <td>
                                    <asp:CheckBox ID="cbJefeArea" runat="server" style="font-size: 9pt" 
                                                                Text="Es Jefe de Area" />
                                </td>
                                <td width="50">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right" width="110">
                                    &nbsp;</td>
                                <td>
                                    <table class="style1">
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                                <td width="50">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right" width="110">
                                    &nbsp;</td>
                                <td>
                                    <asp:Panel ID="Panel1" runat="server" Visible="False">
                                        <table width="100%">
                                            <tr>
                                                <td align="right" width="90">
                                                    Adjuntar Memo:</td>
                                                <td width="350">
                                                    <asp:FileUpload ID="FileUploadControl" runat="server" 
                                                        ToolTip="Adjuntar archivos" Width="320px" />
                                                </td>
                                                <td width="50">
                                                    NroDoc:</td>
                                                <td width="100">
                                                    <asp:TextBox ID="txtNroArchivo" runat="server" Width="100px"></asp:TextBox>
                                                </td>
                                                <td width="25">
                                                    <asp:ImageButton ID="btnAceptar1" runat="server" ImageUrl="~/img/Update.gif" />
                                                </td>
                                                <td width="25">
                                                    <asp:ImageButton ID="btnCancelar1" runat="server" ImageUrl="~/img/Cancel.gif" />
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                                <td width="50">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                    
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="20">
                    &nbsp;</td>
                <td width="800" valign="top">
                
                                                <asp:ObjectDataSource ID="odsCargos" runat="server" 
                                                    SelectMethod="GetAllFromCargo" 
                                                    
                        TypeName="SistFoncreagro.BussinesLogic.CargoBL">
                                                </asp:ObjectDataSource>
                    
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <%# Eval("NomCargo")%>

        <telerik:RadWindowManager ID="RadWindowManager2" runat="server">
                    <Windows>
                        <telerik:RadWindow ID="NuevoCargo" runat="server" Title="Nuevo Cargo" Height="800px"
                        Width="800px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" Animation="Resize" />                        
                    </Windows>
        </telerik:RadWindowManager>
    </form>
</body>
</html>
