<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmSistemaPensiones.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmSistemaPensiones" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<fieldset class="jcv">
       <legend class="legendJcv">SISTEMA DE PENSIONES</legend>
       <table style="width: 100%">
           <tr>
               <td style="width: 190px">
                    <asp:ImageButton ID="ibGuardar" runat="server" ImageUrl="~/img/Grabar.gif" 
                        ValidationGroup="periodo" />
                </td>
               <td colspan="2">
                   &nbsp;</td>
           </tr>
           <tr>
               <td style="width: 190px">
                   Tipo de sistema de pensiones :</td>
               <td colspan="2">
                    <telerik:RadComboBox ID="rcmbTipoSistemaPension" Runat="server" DataTextField="Tipo" 
                        DataValueField="IdTipoSP" Skin="Hay" Width="300px" AutoPostBack="True">
                    </telerik:RadComboBox>
                </td>
           </tr>
           <tr>
               <td style="width: 190px">
                   Sistema de pensiones :</td>
               <td colspan="2">
                    <telerik:RadComboBox ID="rcmbSistemaPensiones" Runat="server" DataTextField="Descripcion" 
                        DataValueField="IdSistemaPensiones" Skin="Hay" Width="300px" 
                        AutoPostBack="True">
                    </telerik:RadComboBox>
                </td>
           </tr>
           <tr>
               <td style="width: 190px">
                   Periodo :</td>
               <td colspan="2">
                   <table style="border-style: hidden; width: 100%" border="0" cellspacing="0" cellpadding="0">
                       <tr>
                           <td style="width: 310px">
                                                <telerik:RadComboBox ID="rcmbPeridoDos" 
                        Runat="server" AccessibilityMode="True" 
                                                    AllowCustomText="True" 
                                                    DataTextField="Nacionalidad" DataValueField="IdNacionalidad" 
                                                    MarkFirstMatch="True" Skin="Hay" Width="300px" 
                        AutoPostBack="True" ValidationGroup="periodo">
                                                </telerik:RadComboBox>
                           </td>
                           <td>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                   ControlToValidate="rcmbPeridoDos" ErrorMessage="Seleccione el periodo." 
                                   Font-Size="8pt" ValidationGroup="periodo"></asp:RequiredFieldValidator>
                           </td>
                       </tr>
                   </table>
               </td>
           </tr>
           <tr>
               <td style="width: 190px">
                   Aportes :</td>
               <td style="width: 200px">
                    <asp:CheckBox ID="cbPeridoAnterior" runat="server" 
                        Text="Igual periodo anterior" />
               </td>
               <td style="width: 400px">
                   &nbsp;</td>
           </tr>
           <tr>
               <td style="width: 190px; height: 16px;">
                   </td>
               <td style="width: 200px; height: 16px;">
                   </td>
               <td style="width: 400px; height: 16px;">
                   </td>
           </tr>
           <tr>
               <td style="width: 190px">
                   <asp:Label ID="Label1" runat="server" Text="Periodo actual :"></asp:Label>
               </td>
               <td style="width: 200px">
                   &nbsp;</td>
               <td style="width: 450px">
                   <asp:Label ID="lblPeridoAnterior" runat="server" Text="Perido anterior :" 
                       Visible="False"></asp:Label>
               </td>
           </tr>
           <tr>
               <td colspan="2" style="width: 450px">
                    <asp:GridView ID="gvAportesSp" runat="server" AutoGenerateColumns="False" 
                        DataKeyNames="IdAporteSp" Width="355px" 
                        Font-Size="8pt">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtIdAporteSp" runat="server" BackColor="White" BorderColor="White" 
                                        BorderStyle="None" Height="0px" Text='<%# Bind("IdAporteSp") %>' Width="0px"></asp:TextBox>
                                </ItemTemplate>
                                <FooterStyle Width="0px" />
                                <HeaderStyle Width="0px" />
                                <ItemStyle Width="0px" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="IdAporteSp" HeaderText="IdAporteSp" 
                                SortExpression="IdAporteSp" Visible="False" />
                            <asp:BoundField DataField="Descripcion" HeaderText="DESCRIPCIÓN" 
                                SortExpression="Descripcion">
                            <HeaderStyle HorizontalAlign="Center" Width="200px" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="PORCENTAJE">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtPorcentaje" runat="server" Width="45px" 
                                        Text='<%# Bind("Porcentaje") %>'></asp:TextBox>
                                </ItemTemplate>
                                <FooterStyle HorizontalAlign="Center" />
                                <HeaderStyle HorizontalAlign="Center" Width="70px" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
               <td style="width: 450px">
                    <asp:GridView ID="gvAportesSpAnterior" runat="server" AutoGenerateColumns="False" 
                        DataKeyNames="IdAporteSp" Width="355px" 
                        Font-Size="8pt">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtIdAporteSp0" runat="server" BackColor="White" BorderColor="White" 
                                        BorderStyle="None" Height="0px" Text='<%# Bind("IdAporteSp") %>' 
                                        Width="0px"></asp:TextBox>
                                </ItemTemplate>
                                <FooterStyle Width="0px" />
                                <HeaderStyle Width="0px" />
                                <ItemStyle Width="0px" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="IdAporteSp" HeaderText="IdAporteSp" 
                                SortExpression="IdAporteSp" Visible="False" />
                            <asp:BoundField DataField="Descripcion" HeaderText="DESCRIPCIÓN" 
                                SortExpression="Descripcion">
                            <HeaderStyle HorizontalAlign="Center" Width="200px" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="PORCENTAJE">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtPorcentaje0" runat="server" Width="45px" 
                                        Text='<%# Bind("Porcentaje") %>' ReadOnly="True"></asp:TextBox>
                                </ItemTemplate>
                                <FooterStyle HorizontalAlign="Center" />
                                <HeaderStyle HorizontalAlign="Center" Width="70px" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
           </tr>
           <tr>
               <td colspan="2">
                   <asp:Label ID="lblMensajeError" runat="server" Font-Size="8pt" ForeColor="Red" 
                       Visible="False"></asp:Label>
               </td>
               <td style="width: 450px">
                   &nbsp;</td>
           </tr>
           </table>
      </fieldset>
       <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                        <AjaxSettings>
                            <telerik:AjaxSetting AjaxControlID="rcmbSistemaPensiones">
                                <UpdatedControls>
                                    <telerik:AjaxUpdatedControl ControlID="gvAportesSpAnterior" />
                                    <telerik:AjaxUpdatedControl ControlID="rcmbPeridoDos" />
                                    <telerik:AjaxUpdatedControl ControlID="lblPeridoAnterior" />
                                </UpdatedControls>
                            </telerik:AjaxSetting>
                            <telerik:AjaxSetting AjaxControlID="rcmbTipoSistemaPension">
                                <UpdatedControls>
                                    <telerik:AjaxUpdatedControl ControlID="gvAportesSpAnterior" />
                                    <telerik:AjaxUpdatedControl ControlID="rcmbSistemaPensiones" />
                                    <telerik:AjaxUpdatedControl ControlID="rcmbPeridoDos" />
                                    <telerik:AjaxUpdatedControl ControlID="lblPeridoAnterior" />
                                </UpdatedControls>
                            </telerik:AjaxSetting>
                            <telerik:AjaxSetting AjaxControlID="rcmbPeridoDos">
                                <UpdatedControls>
                                    <telerik:AjaxUpdatedControl ControlID="gvAportesSpAnterior" 
                                        LoadingPanelID="RadAjaxLoadingPanel1" />
                                    <telerik:AjaxUpdatedControl ControlID="lblPeridoAnterior" />
                                </UpdatedControls>
                            </telerik:AjaxSetting>
                        </AjaxSettings>
                    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
</asp:Content>
