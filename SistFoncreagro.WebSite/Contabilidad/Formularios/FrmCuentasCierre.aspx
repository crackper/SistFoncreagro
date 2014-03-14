<%@ Page Title="Cuentas de Cierre" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmCuentasCierre.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmCuentasCierre" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos">
                            cuentas de cierre&nbsp;</td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar"  
                                                                CausesValidation="False" 
                                                                
                                PostBackUrl="~/Contabilidad/Formularios/ListaCuentasCierre.aspx" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr class="Texto">
            <td style="height: 35px">
                <table style="width: 60px">
                    <tr>
                        <td >
                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                                ToolTip="Grabar" BorderColor="Gray" BorderStyle="Solid" 
                                                                BorderWidth="0px" />
                        </td>
                        <td >
                            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/img/Nuevo.gif" 
                                                                ToolTip="Nuevo" BorderColor="Gray" BorderStyle="Solid" BorderWidth="0px" 
                                                                CausesValidation="False" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr class="Texto">
            <td>
                <asp:Panel ID="Panel1" runat="server">
                    <table width="100%">
                        <tr class="Texto">
                            <td width="14%">
                                Descripción:</td>
                            <td width="88%">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBoxAlignIzquierda" 
                                    Width="99%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="Texto">
                            <td width="12%">
                                Cta. de Traslado 1:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox1" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="RadComboBox1" Display="Dynamic" 
                                    ErrorMessage="¡Debe ingresar la Cuenta!"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. de Traslado 2:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox2" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. de Traslado 3:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox3" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. de Traslado 4:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox4" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. de Traslado 5:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox5" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. de Traslado 6:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox6" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. de Traslado 7:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox7" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. de Traslado 8:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox8" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. de Traslado 9:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox9" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. de Traslado 10:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox10" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. Receptora:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox11" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                    ControlToValidate="RadComboBox11" Display="Dynamic" 
                                    ErrorMessage="¡Debe ingresar la Cuenta!"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
        <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
<asp:ObjectDataSource ID="odsPlanContable1" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable2" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable3" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable4" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable5" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable6" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable7" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable8" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable9" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable10" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable11" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



         <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>










                                                
                                                
        



    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="ImageButton3">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Panel1" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
</asp:Content>
