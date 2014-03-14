<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmEditarArea.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmEditarArea"  %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="border-style: solid; border-width: 1px; width: 100%">
        <tr>
            <td>
            <table class="fondoTabla" 
                    style="border-width: 0px; padding: 0px; margin: 0px; background-color: #0C3B2A; color: #FFFFFF;">
                <tr>
                    <td class="Titulos" align="left">
                        &nbsp;AREAS</td>
                    <td width="40px">
                            &nbsp;</td>
                    <td style="text-align: right; width:110px" align="right">
                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/img/Cancel.gif" />
                    </td>
                </tr>
            </table>
            </td>
        </tr>
        <tr>
            <td>   
                           <telerik:RadTabStrip ID="RadTabStrip1" runat="server" Height="28px" 
                                Width="100%" SelectedIndex="0"  MultiPageID="RadMultiPage1"
                                 CssClass="tabStrip"> 
                                <Tabs>
                                    <telerik:RadTab Text="Editar Area" Selected = "True" SelectedIndex="1">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Posiciones">
                                    </telerik:RadTab>
                                </Tabs>
                            </telerik:RadTabStrip>
                            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadMultiPage ID="RadMultiPage1" Runat="server" Width="100%" 
                    SelectedIndex="0">
                    <telerik:RadPageView ID="RPVEditarCargo" runat="server" BorderColor="#999999" 
                        BorderStyle="Solid" BorderWidth="1px">
                        <table style="font-family: Arial; font-size: 9pt;" width="100%">
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td width="10">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <table class="texto" 
                                        style="padding: 2px; margin: 2px; border: 1px solid #C0C0C0; width: 100%" 
                                        cellpadding="3" cellspacing="3">
                                        <tr>
                                            <td align="left" style="width: 86px">
                                                &nbsp;
                                                <asp:ImageButton ID="btnGrabar" runat="server" AlternateText="Grabar" 
                                                    ImageUrl="~/img/Grabar.gif" ToolTip="Grabar" />
                                                &nbsp;<asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/img/Nuevo.gif" />
                                                &nbsp;</td>
                                            <td align="left" style="width: 350px">
                                                <asp:TextBox ID="txtIdArea" runat="server" Width="30px" Visible="False"></asp:TextBox>
                                                <asp:TextBox ID="txtNivel" runat="server" Width="30px" Visible="False"></asp:TextBox>
                                                <asp:TextBox ID="txtSuperArea" runat="server" Width="30px" Visible="False"></asp:TextBox>
                                            </td>
                                            <td width="30">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 86px">
                                                Dependencia:</td>
                                            <td align="left" style="width: 350px">
                                                <asp:Label ID="lblDependencia" runat="server" Width="100%"></asp:Label>
                                            </td>
                                            <td width="30">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 86px">
                                                Area:</td>
                                            <td style="width: 350px">
                                                <asp:TextBox ID="txtNombreArea" runat="server" Width="100%"></asp:TextBox>
                                            </td>
                                            <td width="30">
                                                &nbsp;</td>
                                            <td>
                                                <asp:CheckBox ID="cbAdministra" runat="server" Text="Administrativa" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 86px">
                                                Tipo Area:</td>
                                            <td style="width: 350px">
                                                <asp:DropDownList ID="DDLTipoArea" runat="server" DataSourceID="XmlDataSource1" 
                                                    DataTextField="texto" DataValueField="valor" Width="154px">
                                                </asp:DropDownList>
                                            </td>
                                            <td width="30">
                                                &nbsp;</td>
                                            <td>
                                                <asp:CheckBox ID="cbProyectos" runat="server" 
                                                    Text="De Proyectos" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 86px">
                                                &nbsp;</td>
                                            <td style="width: 350px">
                                                <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
                                                    DataFile="~/RRHH/XML/XMLTipos.xml"></asp:XmlDataSource>
                                            </td>
                                            <td width="30">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                                <td width="10">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel1" runat="server">
                                        <table cellpadding="3" cellspacing="3" 
                                            style="padding: 4px; margin: 4px; border: 1px solid #C0C0C0; width: 100%">
                                            <tr>
                                                <td align="left" colspan="3" valign="top" width="700">
                                                    Proyectos por Area:</td>
                                                <td width="200">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="right" valign="top" width="70">
                                                    Proyecto:</td>
                                                <td valign="top" style="width: 600px">
                                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                        <ContentTemplate>
                                                            <telerik:RadComboBox ID="RCBProyecto" Runat="server" AllowCustomText="True" 
                                                                Filter="Contains" Skin="Hay" Width="100%">
                                                            </telerik:RadComboBox>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                    <asp:ObjectDataSource ID="ODSAreaPresupuestal" runat="server">
                                                    </asp:ObjectDataSource>
                                                </td>
                                                <td valign="top" width="30" align="left" colspan="1">
                                                    <asp:ImageButton ID="BtnAgregarProyecto" runat="server" 
                                                        ImageUrl="~/img/Update.gif" />
                                                </td>
                                                <td width="200">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                        <ContentTemplate>
                                                            <asp:ObjectDataSource ID="odsProyectoArea" runat="server" 
                                                                SelectMethod="GetProyectoAreaByIdAreaByProyectoVigentes" 
                                                                TypeName="SistFoncreagro.BussinesLogic.ProyectoAreaBL">
                                                                <SelectParameters>
                                                                    <asp:ControlParameter ControlID="txtIdArea" Name="IdArea" PropertyName="Text" 
                                                                        Type="Int32" />
                                                                </SelectParameters>
                                                            </asp:ObjectDataSource>
                                                            <asp:GridView ID="gvProyectoArea" runat="server" AutoGenerateColumns="False" 
                                                                DataSourceID="odsProyectoArea" Width="800px">
                                                                <Columns>
                                                                    <asp:TemplateField>
                                                                        <ItemTemplate>
                                                                            <asp:ImageButton ID="btnEliminarPA" runat="server" 
                                                                                CommandArgument='<%# Bind("IdProyectoArea") %>' ImageUrl="~/img/Delete.gif" 
                                                                                onclick="btnEliminarPA_Click" />
                                                                        </ItemTemplate>
                                                                        <HeaderStyle Width="40px" />
                                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="40px" />
                                                                    </asp:TemplateField>
                                                                    <asp:BoundField DataField="IdProyectoArea" HeaderText="IdProyectoArea" 
                                                                        SortExpression="IdProyectoArea" Visible="False" />
                                                                    <asp:BoundField DataField="IdProyecto" HeaderText="IdProyecto" 
                                                                        SortExpression="IdProyecto" Visible="False" />
                                                                    <asp:BoundField DataField="IdArea" HeaderText="IdArea" SortExpression="IdArea" 
                                                                        Visible="False" />
                                                                    <asp:BoundField DataField="CodAreaProyecto" HeaderText="Proyecto" 
                                                                        ReadOnly="True" SortExpression="CodAreaProyecto" />
                                                                    <asp:BoundField DataField="estadoProyecto" HeaderText="estadoProyecto" 
                                                                        SortExpression="estadoProyecto">
                                                                    <HeaderStyle Width="100px" />
                                                                    <ItemStyle Width="100px" />
                                                                    </asp:BoundField>
                                                                </Columns>
                                                            </asp:GridView>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    &nbsp;</td>
                                                <td width="30">
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                                <td width="10">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </telerik:RadPageView>
                    <telerik:RadPageView ID="Posiciones" runat="server" Height="800px">                      
                    </telerik:RadPageView>
                   <%-- <telerik:RadPageView ID="Posiciones" runat="server" 
                        ContentUrl="~/RRHH/Formulario/FrmPosicion.aspx?IdArea=1" Height="800px">                      
                    </telerik:RadPageView>--%>
                </telerik:RadMultiPage>
            </td>
        </tr>  
        <tr>
        <td>
            &nbsp;</td></tr>      
    </table>
</asp:Content>
