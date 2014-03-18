<%@ Page Title="Cierre de Mes" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmEjercicio.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmEjercicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla5">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td class="Titulos" >
                            cierre de mes&nbsp;</td>
                        <td  >
                            &nbsp;</td>
                        <td style="text-align: right; width:110px"   >
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table align="center" class="tabla4" >
                    <tr>
                        <td>
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                ToolTip="Grabar" />
                            <asp:TextBox ID="TextBox15" runat="server" Visible="False" Width="30px"></asp:TextBox>
                            
                        </td>
                    </tr>
                    <tr>
                        <td style="font-family: Arial; font-size: 3pt">
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td style="font-weight: 700">
                            Estado del Mes: A=Abierto, C=Cerrado</td>
                    </tr>
                    <tr>
                        <td style="font-family: Arial; font-size: 3pt">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Panel1" runat="server" Width="100%">
                                <table style="width: 100%">
                                    <tr class="Texto">
                                        <td style="text-align: center; font-weight: 700">
                                            Ejercicio:
                                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-family: Arial; font-size: 3pt">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table align="center" style="width: 100%">
                                                <tr class="Texto">
                                                    <td width="8%" style="text-align: center">
                                                        Apertura</td>
                                                    <td width="7%" style="text-align: center">
                                                        Enero</td>
                                                    <td width="7%" style="text-align: center">
                                                        Febrero</td>
                                                    <td width="7%" style="text-align: center">
                                                        Marzo</td>
                                                    <td width="7%" style="text-align: center">
                                                        Abril</td>
                                                    <td width="7%" style="text-align: center">
                                                        Mayo</td>
                                                    <td width="7%" style="text-align: center">
                                                        Junio</td>
                                                    <td width="7%" style="text-align: center">
                                                        Julio</td>
                                                    <td width="7%" style="text-align: center">
                                                        Agosto</td>
                                                    <td width="7%" style="text-align: center">
                                                        Setiembre</td>
                                                    <td width="7%" style="text-align: center">
                                                        Octubre</td>
                                                    <td width="7%" style="text-align: center">
                                                        Noviembre</td>
                                                    <td width="7%" style="text-align: center">
                                                        Diciembre</td>
                                                    <td width="8%" style="text-align: center">
                                                        Cierre</td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox1" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox2" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox3" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox4" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox5" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox6" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox7" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox8" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox9" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox10" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox11" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox12" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox13" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox14" runat="server" Width="30px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="ImageButton2">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="Panel1" 
                                                LoadingPanelID="RadAjaxLoadingPanel1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>
                            </telerik:RadAjaxManager>
</asp:Content>
