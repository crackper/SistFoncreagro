<%@ Page Title="Documento Contable" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmDocumentoConta.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmDocumentoConta" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos">
                            documento contable</td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar"  
                                                                CausesValidation="False" 
                                                                
                                PostBackUrl="~/Contabilidad/Formularios/ListaDocumentoConta.aspx" />
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
                    <table cellpadding="0" cellspacing="3" style="width: 100%">
                        <tr class="Texto">
                            <td width="15%" style="text-align: left; font-size: 9pt;">
                                Tipo Documento:</td>
                            <td width="85%">
                                <telerik:RadComboBox ID="RadComboBox6" Runat="server" AllowCustomText="True" 
                                                                                                
                                    DataSourceID="odsTipoDocumento" DataTextField="Documento" 
                                                                                                DataValueField="IdTipoDocumento" 
                                                                                                
                                    EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                                                                                
                                    MarkFirstMatch="True" ShowMoreResultsBox="True" ValidationGroup="Transaccion" 
                                                                                                Width="88%" 
                                    style="font-family: Arial; font-size: 9pt" 
                                    onclientselectedindexchanged="Copiar">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr class="Texto">
                            <td width="15%" style="text-align: left; font-size: 9pt;">
                                Código:</td>
                            <td width="85%">
                                <asp:TextBox ID="TextBox2" runat="server" 
                                                                                                
                                    style="font-family: Arial; font-size: 9pt" MaxLength="3" Width="70px"></asp:TextBox>
                                (* Dos números y una Letra mayúscula)<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ControlToValidate="TextBox2" Display="Dynamic" 
                                    ErrorMessage="¡Formato incorrecto!" 
                                    ValidationExpression="\d*[0-9]\d*[0-9]\d*[A-Z]{1,1}"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                     
                           
                            <tr class="Texto">
                                <td style="text-align: left; font-size: 9pt;" width="15%">
                                    Moneda:</td>
                                <td width="85%">
                                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="odsMoneda" 
                                        DataTextField="Nombre" DataValueField="IdMoneda" 
                                        style="font-family: Arial; font-size: 8pt" Width="70px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr class="Texto">
                                <td style="text-align: left; font-size: 9pt;" width="15%">
                                    Descripción:</td>
                                <td width="85%">
                                    <asp:TextBox ID="TextBox1" runat="server" 
                                        style="font-family: Arial; font-size: 9pt" Width="89%"></asp:TextBox>
                                </td>
                            </tr>
                            <tr class="Texto">
                                <td style="text-align: left; font-size: 9pt;" width="15%">
                                    Cuenta IGV:</td>
                                <td width="85%">
                                    <telerik:RadComboBox ID="RadComboBox1" Runat="server" DataTextField="Cuenta" 
                                        DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                        EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                        ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                        style="font-family: Arial; font-size: 9pt" ValidationGroup="Linea" Width="90%">
                                    </telerik:RadComboBox>
                                </td>
                            </tr>
                            <tr class="Texto">
                                <td style="text-align: left; font-size: 9pt;" width="15%">
                                    Cuenta Debe:</td>
                                <td width="85%">
                                    <telerik:RadComboBox ID="RadComboBox2" Runat="server" DataTextField="Cuenta" 
                                        DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                        EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                        ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                        style="font-family: Arial; font-size: 9pt" ValidationGroup="Linea" Width="90%">
                                    </telerik:RadComboBox>
                                </td>
                            </tr>
                            <tr class="Texto">
                                <td style="text-align: left; font-size: 9pt;" width="15%">
                                    Cuenta Haber:</td>
                                <td width="85%">
                                    <telerik:RadComboBox ID="RadComboBox3" Runat="server" DataTextField="Cuenta" 
                                        DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                        EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                        ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                        style="font-family: Arial; font-size: 9pt" ValidationGroup="Linea" Width="90%">
                                    </telerik:RadComboBox>
                                </td>
                            </tr>
                            <tr class="Texto">
                                <td style="text-align: left; font-size: 9pt;" width="15%">
                                    Cuenta Detracción:</td>
                                <td width="85%">
                                    <telerik:RadComboBox ID="RadComboBox4" Runat="server" DataTextField="Cuenta" 
                                        DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                        EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                        ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                        style="font-family: Arial; font-size: 9pt" ValidationGroup="Linea" Width="90%">
                                    </telerik:RadComboBox>
                                </td>
                            </tr>
                            <tr class="Texto">
                                <td style="text-align: left; font-size: 9pt;" width="15%">
                                    Cuenta Retención:</td>
                                <td width="85%">
                                    <telerik:RadComboBox ID="RadComboBox5" Runat="server" DataTextField="Cuenta" 
                                        DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                        EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                        ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                        style="font-family: Arial; font-size: 9pt" ValidationGroup="Linea" Width="90%">
                                    </telerik:RadComboBox>
                                </td>
                            </tr>
                            <tr class="Texto">
                                <td style="text-align: left; font-size: 9pt;" width="15%">
                                    Flag IVAP:</td>
                                <td width="85%">
                                    <asp:DropDownList ID="DropDownList2" runat="server" 
                                        style="font-family: Arial; font-size: 9pt" AutoPostBack="True">
                                        <asp:ListItem Selected="True" Value="N">NO</asp:ListItem>
                                        <asp:ListItem Value="S">SI</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </caption>
                        <tr class="Texto">
                            <td style="text-align: left; font-size: 9pt;" width="15%">
                                Cuenta Ingreso:</td>
                            <td width="85%">
                                <telerik:RadComboBox ID="RadComboBox7" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    style="font-family: Arial; font-size: 9pt" ValidationGroup="Linea" Width="90%">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr class="Texto">
                            <td style="text-align: left; font-size: 9pt;" width="15%">
                                Cuenta Gasto:</td>
                            <td width="85%">
                                <telerik:RadComboBox ID="RadComboBox8" Runat="server" DataTextField="Cuenta" 
                                    DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                    EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                    style="font-family: Arial; font-size: 9pt" ValidationGroup="Linea" Width="90%">
                                </telerik:RadComboBox>
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




            
        




            
        






    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
<asp:ObjectDataSource ID="odsMoneda" runat="server" 
    SelectMethod="GetAllFromMoneda" 
    TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>

                                                <asp:ObjectDataSource ID="odsTipoDocumento" runat="server" 
                                                    SelectMethod="GetAllFromTIPODOCUMENTO" 
                                                    TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoBL">
                                                </asp:ObjectDataSource>
                                                
        

        
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="ImageButton3">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Panel1" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="DropDownList2">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadComboBox7" />
                    <telerik:AjaxUpdatedControl ControlID="RadComboBox8" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function Copiar() {
        var obj = document.getElementById('ctl00_ctl00_MainContent_MainContent_RadComboBox6').value;
        var cod = document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox2');
        var des = document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox1');
        cod.value = obj.substring(0,2);
        des.value = obj.substring(3, obj.length);
    }
    function Validar() {
        var cod = document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox2');
//        para quitar espacios en blanco
        var cadena = cod.value.replace(/^\s+/g, '').replace(/\s+$/g, '')

        if (cadena.length < 3 ) {
           radalert('¡El Código debe tener 3 caracteres!', 300, 50, "¡Alerta!");
         

        }
    }
    </script>
</telerik:RadCodeBlock>
</asp:Content>


                                                


