<%@ Page Title="Validar Bienes Inmuebles" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterContabilidad1.master" CodeBehind="FrmValidarInmueble.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmValidarInmueble" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <telerik:RadWindowManager ID="RadWindowManager1" runat="server" 
        InitialBehavior="Resize, Close" InitialBehaviors="Resize, Close" Modal="True">
            <Windows>
                <telerik:RadWindow ID="Proveedores" runat="server" Behavior="Close" 
                    Height="600px"
                    InitialBehavior="None" Left="" Modal="True" NavigateUrl="" OnClientClose="Cerrar"
                     Style="display: none;" Top="" VisibleStatusbar="True"
                    Width="800px" Title="Registro de Proveedores" >
                </telerik:RadWindow>
            </Windows>
                            <Localization Close="Cerrar" Maximize="Maximizar" 
            Minimize="Minimizar" />
  </telerik:RadWindowManager>

    <table align="center" class="tabla3" __designer:mapid="75">
        <tr __designer:mapid="76">
            <td style="text-align: left" valign="bottom" __designer:mapid="77">
                <table style="width: 60px" __designer:mapid="78">
                    <tr __designer:mapid="79">
                        <td __designer:mapid="7a">
                            <asp:ImageButton ID="ImageButton3" runat="server" 
                                BorderColor="Gray" 
                                                                                                                    
                                BorderStyle="Solid" BorderWidth="0px" 
                                ImageUrl="~/img/Aceptar.gif" 
                                                                                                                    
                                ToolTip="Validar" />
                        </td>
                        <td __designer:mapid="7c">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr __designer:mapid="7e">
            <td __designer:mapid="7f">
                <table cellspacing="0" class="0" style="width: 100%" __designer:mapid="80">
                    <tr __designer:mapid="81">
                        <td class="Texto" style="font-weight: 700" __designer:mapid="82">
                                                                                                                Datos Generales</td>
                    </tr>
                    <tr __designer:mapid="83">
                        <td class="Texto" __designer:mapid="84">
                            <table class="style6" __designer:mapid="85" width="100%">
                                <tr __designer:mapid="86">
                                    <td style="height: 26px" width="12%" __designer:mapid="87">
                                        Nombre:</td>
                                    <td style="height: 26px" width="59%" __designer:mapid="88">
                                        <asp:TextBox ID="TextBox1" runat="server" 
                                            Width="100%" 
                                                                                                                                
                                            TabIndex="1" CssClass="Texto1"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" 
                                            runat="server" 
                                                                                                                                
                                            ControlToValidate="TextBox1" 
                                            Display="Dynamic" 
                                                                                                                                
                                            ErrorMessage="¡Debe ingresar el Nombre!"></asp:RequiredFieldValidator>
                                    </td>
                                    <td style="height: 26px; text-align: right;" __designer:mapid="8b" width="6%">
                                        Tipo:</td>
                                    <td style="height: 26px; width: 18%;" __designer:mapid="8c" colspan="3">
                                        <asp:DropDownList ID="DropDownList1" runat="server" TabIndex="2" 
                                            Width="100%" 
                                                                                                                                
                                            Font-Names="Arial" Font-Size="8pt" DataSourceID="SqlTipos" 
                                            DataTextField="Tipo" DataValueField="IdTipo">
                                            <asp:ListItem Selected="True">OPERATIVO</asp:ListItem>
                                            <asp:ListItem>INOPERATIVO</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr __designer:mapid="86">
                                    <td style="height: 26px" width="12%" __designer:mapid="87">
                                        Ubicación:</td>
                                    <td style="height: 26px" width="59%" __designer:mapid="88">
                                        <telerik:RadComboBox ID="RadComboBox1" Runat="server" 
                                            DataTextField="Nombre" 
                                                                                                                                
                                            DataValueField="CUBIGEO" EnableLoadOnDemand="True" 
                                            MarkFirstMatch="True" 
                                                                                                                                
                                            ShowDropDownOnTextboxClick="False" TabIndex="3" 
                                            Width="100%" 
                                                                                                                                
                                            style="margin-left: 0px" Skin="Hay">
                                        </telerik:RadComboBox>
                                    </td>
                                    <td style="height: 26px" __designer:mapid="8b">
                                        &nbsp;</td>
                                    <td style="height: 26px" width="8%" __designer:mapid="8c">
                                        &nbsp;</td>
                                    <td style="height: 26px; text-align: right;" width="6%" __designer:mapid="8d">
                                        &nbsp;</td>
                                    <td style="height: 26px" width="10%" __designer:mapid="8e">
                                        &nbsp;</td>
                                </tr>
                                <tr __designer:mapid="86">
                                    <td style="height: 26px" width="12%" __designer:mapid="87">
                                        Dirección:</td>
                                    <td style="height: 26px" width="59%" __designer:mapid="88">
                                        <asp:TextBox ID="TextBox2" runat="server" TabIndex="4" 
                                            Width="100%" 
                                                                                                                                
                                            CssClass="Texto1"></asp:TextBox>
                                    </td>
                                    <td style="height: 26px" __designer:mapid="8b">
                                        &nbsp;</td>
                                    <td style="height: 26px" width="8%" __designer:mapid="8c">
                                        &nbsp;</td>
                                    <td style="height: 26px; text-align: right;" width="6%" __designer:mapid="8d">
                                        &nbsp;</td>
                                    <td style="height: 26px" width="10%" __designer:mapid="8e">
                                        &nbsp;</td>
                                </tr>
                                <tr __designer:mapid="90">
                                    <td __designer:mapid="91">
                                                                                                                            Proyecto:</td>
                                    <td __designer:mapid="92">
                                        <telerik:RadComboBox ID="RadComboBox2" Runat="server" 
                                            AllowCustomText="True" 
                                                                                                                                
                                            AutoPostBack="True" DataSourceID="odsProyecto" 
                                            DataTextField="AreaProyecto" 
                                                                                                                                
                                            DataValueField="IdProyecto" 
                                            EnableLoadOnDemand="True" 
                                                                                                                                
                                            EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                            MarkFirstMatch="True" 
                                                                                                                                
                                            ShowMoreResultsBox="True" Skin="Hay" TabIndex="5" 
                                            ValidationGroup="Transaccion" 
                                                                                                                                
                                            Width="100%">
                                        </telerik:RadComboBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" 
                                            runat="server" 
                                                                                                                                
                                            ControlToValidate="RadComboBox2" 
                                            Display="Dynamic" 
                                                                                                                                
                                            ErrorMessage="¡Debe ingresar el Proyecto!"></asp:RequiredFieldValidator>
                                    </td>
                                    <td __designer:mapid="95">
                                                                                                                            &nbsp;</td>
                                    <td __designer:mapid="96">
                                                                                                                            &nbsp;</td>
                                    <td __designer:mapid="97">
                                                                                                                            &nbsp;</td>
                                    <td __designer:mapid="98">
                                                                                                                            &nbsp;</td>
                                </tr>
                                <tr __designer:mapid="99">
                                    <td __designer:mapid="9a">
                                                                                                                            Centro de Costo:</td>
                                    <td __designer:mapid="9b">
                                        <telerik:RadComboBox ID="RadComboBox3" Runat="server" 
                                            AllowCustomText="True" 
                                                                                                                                
                                            DataSourceID="SqlDSCCosto" 
                                            DataTextField="CodigoElemGasto" 
                                                                                                                                
                                            DataValueField="IdCCosto" 
                                            EnableAjaxSkinRendering="False" 
                                                                                                                                
                                            EnableEmbeddedBaseStylesheet="False" 
                                            EnableEmbeddedScripts="False" 
                                                                                                                                
                                            EnableEmbeddedSkins="False" EnableLoadOnDemand="True" 
                                            MarkFirstMatch="True" 
                                                                                                                                
                                            TabIndex="6" Width="100%" Skin="Hay">
                                        </telerik:RadComboBox>
                                    </td>
                                    <td __designer:mapid="9d">
                                                                                                                            &nbsp;</td>
                                    <td __designer:mapid="9e">
                                                                                                                            &nbsp;</td>
                                    <td __designer:mapid="9f">
                                                                                                                            &nbsp;</td>
                                    <td __designer:mapid="a0">
                                                                                                                            &nbsp;</td>
                                </tr>
                                <tr __designer:mapid="ae">
                                    <td __designer:mapid="af">
                                                                                                                            Vendedor:</td>
                                    <td __designer:mapid="b0">
                                        <telerik:RadComboBox ID="RadComboBox4" Runat="server" 
                                            AllowCustomText="True" 
                                                                                                                                
                                            DataTextField="NombreProveedor" 
                                            DataValueField="IdProveedorCliente" 
                                                                                                                                
                                            EnableAjaxSkinRendering="False" 
                                            EnableEmbeddedBaseStylesheet="False" 
                                                                                                                                
                                            EnableEmbeddedScripts="False" 
                                            EnableEmbeddedSkins="False" 
                                                                                                                                
                                            EnableLoadOnDemand="True" EnableVirtualScrolling="True" 
                                            ItemsPerRequest="10" 
                                                                                                                                
                                            MarkFirstMatch="True" ShowMoreResultsBox="True" TabIndex="7" 
                                            Width="100%" 
                                                                                                                                
                                            Skin="Hay">
                                        </telerik:RadComboBox>
                                    </td>
                                    <td __designer:mapid="b2">
                                        <asp:ImageButton ID="ImageButton7" runat="server" 
                                            CausesValidation="False" 
                                                                                                                                
                                            ImageAlign="Middle" 
                                            ImageUrl="~/img/Agregar.gif" 
                                                                                                                                
                                            ToolTip="Registrar Proveedor" />
                                    </td>
                                    <td __designer:mapid="b4">
                                                                                                                            &nbsp;</td>
                                    <td __designer:mapid="b5">
                                                                                                                            &nbsp;</td>
                                    <td __designer:mapid="b6">
                                                                                                                            &nbsp;</td>
                                </tr>
                                </table>
                        </td>
                    </tr>
                    <tr __designer:mapid="83">
                        <td class="Texto" __designer:mapid="84">
                            <table style="width: 100%">
                                <tr>
                                    <td width="12%">
                                        Fecha de Compra:</td>
                                    <td width="14%">
                                        <asp:TextBox ID="txtDate" runat="server" TabIndex="8" 
                                            Width="70px" 
                                                                                                                                
                                            CssClass="Texto1" />
                                        <asp:MaskedEditExtender ID="MaskedEditExtender1" 
                                            runat="server" 
                                                                                                                                
                                            AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" 
                                            MaskType="Date" 
                                                                                                                                
                                            TargetControlID="txtDate" />
                                        <asp:MaskedEditValidator ID="MaskedEditValidator1" 
                                            runat="server" 
                                                                                                                                
                                            ControlExtender="MaskedEditExtender1" 
                                            ControlToValidate="txtDate" 
                                                                                                                                
                                            Display="Dynamic" 
                                            EmptyValueMessage="Ingrese la Fecha" 
                                                                                                                                
                                            InvalidValueMessage="¡Fecha Incorrecta!" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                                            runat="server" 
                                                                                                                                
                                            ControlToValidate="txtDate" 
                                            Display="Dynamic" 
                                                                                                                                
                                            ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator>
                                        </td>
                                    <td width="15%">
                                        Valor Compra:</td>
                                    <td width="14%">
                                        <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" 
                                            TabIndex="10" 
                                                                                                                                
                                            Value="0" Width="70px">
                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                        </telerik:RadNumericTextBox>
                                        </td>
                                    <td width="6%">
                                        Moneda</td>
                                    <td width="15%">
                                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="OdsMoneda" 
                                            DataTextField="Nombre" DataValueField="IdMoneda" Font-Names="Arial" 
                                            Font-Size="7pt" TabIndex="11">
                                        </asp:DropDownList>
                                    </td>
                                    <td width="9%">
                                        Tipo Cambio:</td>
                                    <td width="15%">
                                        <telerik:RadNumericTextBox ID="RadNumericTextBox4" Runat="server" 
                                            TabIndex="9" Width="70px">
                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                        </telerik:RadNumericTextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                                            ControlToValidate="RadNumericTextBox4" Display="Dynamic" 
                                            ErrorMessage="¡Debe ingresar el Tipo de Cambio!"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td width="12%">
                                        Área Total (m2):</td>
                                    <td width="16%">
                                        <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" 
                                            TabIndex="12" 
                                                                                                                                
                                            Value="0" Width="70px">
                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                        </telerik:RadNumericTextBox>
                                    </td>
                                    <td width="11%">
                                        Área Construída (m2):</td>
                                    <td width="15%">
                                        <telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" 
                                            TabIndex="13" 
                                                                                                                                
                                            Value="0" Width="70px">
                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                        </telerik:RadNumericTextBox>
                                    </td>
                                    <td width="5%">
                                        &nbsp;</td>
                                    <td width="15%">
                                        &nbsp;</td>
                                    <td width="6%">
                                        &nbsp;</td>
                                    <td width="20%">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="12%">
                                                                                                                            Observaciones:</td>
                                    <td colspan="7">
                                        <asp:TextBox ID="TextBox3" runat="server" 
                                            CssClass="Texto1" 
                                                                                                                                
                                            Rows="2" TabIndex="14" Width="99%" TextMode="MultiLine"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    </table>
            </td>
        </tr>
    </table>

                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
    <asp:SqlDataSource ID="SqlTipos" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetAllFromTIPOINMUEBLE" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
    <asp:ObjectDataSource ID="OdsUbigeo" runat="server" 
        SelectMethod="GetUBIGEODATOSByParameter" 
        TypeName="SistFoncreagro.BussinesLogic.UbigeoDatosBL">
        <SelectParameters>
            <asp:Parameter DefaultValue="*" Name="texto" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="OdsMoneda" runat="server" 
        SelectMethod="GetAllFromMoneda" 
        TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>
<asp:SqlDataSource ID="SqlDSCCosto" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetCCOSTOByIdProyecto1" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:ControlParameter ControlID="RadComboBox2" Name="idProyecto" 
            PropertyName="SelectedValue" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>

   <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function kH(e) {

            var pK = document.all ? window.event.keyCode : e.which;
            return pK != 13;
        }

        document.onkeypress = kH;
        if (document.layers) document.captureEvents(Event.KEYPRESS);




        function Abrir() {
            var oWnd = radopen("/SistIntegral/Logistica/FrmProveedores.aspx", "Proveedores");
        }
        function Cerrar() {

            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ActualizarLista");
        }

        function ValidarFecha() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarFecha");

        }
       
     </script>
    </telerik:RadCodeBlock>          

                         <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadWindowManager1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox4" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox2">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox3" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>
                    
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
                    
    </asp:Content>
