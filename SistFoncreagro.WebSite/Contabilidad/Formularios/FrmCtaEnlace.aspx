<%@ Page Title="Cuentas de Enlace" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmCtaEnlace.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmCtaEnlace" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos">
                            cuentas de enlace&nbsp;</td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar"  
                                                                CausesValidation="False" 
                                                                
                                PostBackUrl="~/Contabilidad/Formularios/ListaCtaEnlace.aspx" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr class="Texto">
            <td>
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
                            <td width="12%">
                                Tipo:</td>
                            <td width="88%">
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem Value="I">Ingreso</asp:ListItem>
                                    <asp:ListItem Selected="True" Value="E">Egreso</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr class="Texto">
                            <td width="12%">
                                Cta. Operación:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox1" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" EmptyMessage="Ingrese la Cuenta..." 
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
                                Cta. Cobrar:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox2" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" EmptyMessage="Ingrese la Cuenta..." 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="RadComboBox2" Display="Dynamic" 
                                    ErrorMessage="¡Debe ingresar la Cuenta!"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Cta. Pagar:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox3" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="Codigo" EmptyMessage="Ingrese la Cuenta..." 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    ValidationGroup="Linea" Width="100%">
                                </telerik:RadComboBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ControlToValidate="RadComboBox3" Display="Dynamic" 
                                    ErrorMessage="¡Debe ingresar la Cuenta!"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Area Origen:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox4" Runat="server" AllowCustomText="True" 
                                    DataSourceID="odsProyecto1" DataTextField="AreaProyecto" 
                                    DataValueField="Codigo" EnableLoadOnDemand="True" 
                                    EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                    ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="100%" 
                                    EmptyMessage="Ingrese el Area...">
                                </telerik:RadComboBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                    ControlToValidate="RadComboBox4" Display="Dynamic" 
                                    ErrorMessage="¡Debe ingresar el Area!"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="12%">
                                Area Destino:</td>
                            <td width="88%">
                                <telerik:RadComboBox ID="RadComboBox5" Runat="server" AllowCustomText="True" 
                                    DataSourceID="odsProyecto1" DataTextField="AreaProyecto" 
                                    DataValueField="Codigo" EmptyMessage="Ingrese el Area..." 
                                    EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                    MarkFirstMatch="True" ShowMoreResultsBox="True" ValidationGroup="Transaccion" 
                                    Width="100%">
                                </telerik:RadComboBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                    ControlToValidate="RadComboBox5" Display="Dynamic" 
                                    ErrorMessage="¡Debe ingresar el Area!"></asp:RequiredFieldValidator>
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










                                                
                                                
        



                                                <asp:ObjectDataSource ID="odsProyecto1" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>

        

         <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>

                                                <asp:ObjectDataSource ID="odsProyecto2" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>










                                                
                                                
        



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
