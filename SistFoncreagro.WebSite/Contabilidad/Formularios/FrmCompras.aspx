<%@ Page Title="Registro de Cuentas por Pagar" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterContabilidad1.master" CodeBehind="FrmCompras.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmCompras" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
  <Windows>
                <telerik:RadWindow ID="Proveedores" runat="server" Behavior="Close" 
                     Height="600px"
                    InitialBehavior="None" Left="" Modal="True" NavigateUrl="" OnClientClose="Cerrar"
                     Style="display: none;" Top="" VisibleStatusbar="True"
                    Width="800px" Title="Registro de Proveedores">
                </telerik:RadWindow>
            </Windows>
                            </telerik:RadWindowManager>

                                                <table align="center" 
        class="tabla3">
                                                   
                                                    <tr>
                                                        <td style="text-align: left" valign="bottom"> 
                                                            <table style="width: 180px">
                                                                <tr>
                                                                    <td >
                                                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                                ToolTip="Grabar" BorderColor="Gray" BorderStyle="Solid" 
                                                                BorderWidth="0px" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/img/Nuevo.gif" 
                                                                ToolTip="Nuevo" BorderColor="Gray" BorderStyle="Solid" BorderWidth="0px" 
                                                                CausesValidation="False" style="width: 19px" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton5" runat="server" 
                                                                ImageUrl="~/img/Proceso.gif" ToolTip="Procesar" BorderColor="Gray" 
                                                                BorderStyle="Solid" BorderWidth="0px" Width="25px" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton6" runat="server" 
                                                                ImageUrl="~/img/Deshacer.gif" ToolTip="Deshacer" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/img/Buscar.gif" 
                                                                            ToolTip="Ver el Voucher" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/img/Aceptar.gif" 
                                                                            ToolTip="Validar Comprobante" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                                    <table cellspacing="0" style="width: 100%" class="0" __designer:mapid="ee6">
                                                                        <tr __designer:mapid="ee7">
                                                                            <td class="Texto" style="font-weight: 700" __designer:mapid="ee8">
                                                                                Datos Generales</td>
                                                                        </tr>
                                                                        <tr __designer:mapid="ee9">
                                                                            <td __designer:mapid="eea">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="eeb">
                                                                                    <tr class="Texto" __designer:mapid="eec">
                                                                                        <td width="8%" __designer:mapid="eed">
                                                                                            Op. Finan.:</td>
                                                                                        <td width="34%" __designer:mapid="eee">
                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                                                                                DataSourceID="odsOpFinanciera" DataTextField="Descripcion" 
                                                                                                DataValueField="IdOpFinanciera" Enabled="False" Width="98%">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ef0">
                                                                                            SubDiario:</td>
                                                                                        <td width="34%" __designer:mapid="ef1">
                                                                                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="odsSubDiario" 
                                                                                                DataTextField="Codigo" DataValueField="IdSubDiario" Enabled="False" 
                                                                                                Width="98%">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ef3">
                                                                                            Codigo:</td>
                                                                                        <td width="8%" __designer:mapid="ef4">
                                                                                            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="70px"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="ef6">
                                                                                        <td colspan="6" style="font-size: 3pt" __designer:mapid="ef7">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="ef8">
                                                                            <td __designer:mapid="ef9">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="efa">
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td width="8%" __designer:mapid="efc">
                                                                                            Proyecto:</td>
                                                                                        <td width="76%" __designer:mapid="efd">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="False" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" TabIndex="1">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox3" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Proyecto!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="f00">
                                                                                            Fecha Cont.:</td>
                                                                                        <td width="8%" __designer:mapid="f01">
                                                                                         <asp:TextBox ID="txtDate" runat="server" Width="70px" TabIndex="2" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                            AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                            TargetControlID="txtDate" />
                                                                                           
                                                                        <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                            ControlExtender="MaskedEditExtender1" ControlToValidate="txtDate" 
                                                                            Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                            InvalidValueMessage="¡Fecha Incorrecta!" />                                                                                            
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                                                                ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Fecha Contable!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="f06">
                                                                                        <td colspan="4" style="font-size: 3pt" __designer:mapid="f07">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="f08">
                                                                                        <td width="8%" __designer:mapid="f09">
                                                                                            Tipo Doc.:</td>
                                                                                        <td width="76%" __designer:mapid="f0a">
                                                                                            <telerik:RadComboBox ID="RadComboBox6" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsDocumentoContabilizado" DataTextField="Documento" 
                                                                                                DataValueField="IdDocumentoCont" EnableAutomaticLoadOnDemand="False" 
                                                                                                EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                                                                                MarkFirstMatch="True" ShowMoreResultsBox="True" ValidationGroup="Transaccion" 
                                                                                                Width="98%" TabIndex="3" 
                                                                                                onclientselectedindexchanged="ValidarTipoDocumento">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="RadComboBox6" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Tipo de Documento!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="f0d">
                                                                                            Serie:</td>
                                                                                        <td width="8%" __designer:mapid="f0e">
                                                                                            <asp:TextBox ID="TextBox5" runat="server" Width="70px" MaxLength="4" 
                                                                                                TabIndex="4"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                                                ControlToValidate="TextBox5" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Serie!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="f11">
                                                                                        <td colspan="4" style="font-size: 3pt" __designer:mapid="f12">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="f13">
                                                                            <td __designer:mapid="f14">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="f15">
                                                                                   
                                                                                    <tr class="Texto" __designer:mapid="f16">
                                                                                        <td width="8%" __designer:mapid="f17">
                                                                                            N° Doc.:</td>
                                                                                        <td width="20%" __designer:mapid="f18">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" Width="70px" TabIndex="5"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                                                                ControlToValidate="TextBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el N° de Documento!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td style="text-align: center" width="10%" __designer:mapid="f1b">
                                                                                            Fecha Emisión:</td>
                                                                                        <td width="18%" __designer:mapid="f1c">
                                                                                            <asp:TextBox ID="txtDate1" runat="server" AutoPostBack="True" 
                                                                                                Width="70px" TabIndex="6" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate1" />
                                                                                            <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender2" 
                                                                                                ControlToValidate="txtDate1" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" />
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                                                                ControlToValidate="txtDate1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Fecha de emisión!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="13%" __designer:mapid="f21">
                                                                                            Tipo Cambio:</td>
                                                                                        <td width="15%" __designer:mapid="f22">
                                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" 
                                                                                                ClientIDMode="AutoID" Value="0" Width="70px" 
                                                                                                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                EnableEmbeddedSkins="False" TabIndex="7">
                                                                                                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                <NumberFormat DecimalDigits="4" />
                                                                                            </telerik:RadNumericTextBox>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="f25">
                                                                                            Vencimiento:</td>
                                                                                        <td width="8%" __designer:mapid="f26">
                                                                                            <asp:TextBox ID="txtDate2" runat="server" ValidationGroup="DtVal" 
                                                                                                Width="70px" TabIndex="8" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender3" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate2" />
                                                                                            <asp:MaskedEditValidator ID="MaskedEditValidator3" runat="server" 
                                                                                                ControlExtender="MaskedEditExtender3" ControlToValidate="txtDate2" 
                                                                                                Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                InvalidValueMessage="¡Fecha Incorrecta!" ValidationGroup="DtVal" />
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="f2a">
                                                                                        <td colspan="8" style="font-size: 3pt" __designer:mapid="f2b">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="f2c">
                                                                            <td __designer:mapid="f2d">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="f2e">
                                                                                    <tr class="Texto" __designer:mapid="f2f">
                                                                                        <td width="8%" __designer:mapid="f30">
                                                                                            Proveedor:</td>
                                                                                        <td width="72%" __designer:mapid="f31">
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" AllowCustomText="True" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="100%" 
                                                                                                EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" 
                                                                                                EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" TabIndex="9" 
                                                                                                onclientselectedindexchanged="ValidarDocumento">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                                                ControlToValidate="RadComboBox8" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Proveedor!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="20%" __designer:mapid="f31" style="text-align: left">
                                                                                            <asp:ImageButton ID="ImageButton7" runat="server" ImageAlign="Middle" 
                                                                                                ImageUrl="~/img/Agregar.gif" ToolTip="Registrar Proveedor" 
                                                                                                CausesValidation="False" />
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="f34">
                                                                                        <td colspan="2" style="width: 100%; font-size: 3pt" width="8%" 
                                                                                            __designer:mapid="f35">
                                                                                            &nbsp;</td>
                                                                                        <td style="width: 100%; font-size: 3pt" width="8%" 
                                                                                            __designer:mapid="f35">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="f36">
                                                                            <td __designer:mapid="f37">
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%" 
                                                                                    __designer:mapid="f38">
                                                                                    <tr class="Texto" __designer:mapid="f39">
                                                                                        <td width="8%" __designer:mapid="f3a">
                                                                                            Glosa:</td>
                                                                                        <td width="48%" __designer:mapid="f3b">
                                                                                            
                                                                                            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="100%" 
                                                                                                TabIndex="10" CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                                                ErrorMessage="¡Debe ingresar la Glosa!" Display="Dynamic" 
                                                                                                ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="18%" style="text-align: center" __designer:mapid="f3e">
                                                                                            Tipo Base Imponible:</td>
                                                                                        <td width="26%" __designer:mapid="f3f">
                                                                                            <asp:DropDownList ID="DropDownList3" runat="server" 
                                                                                                DataSourceID="odsTipoBaseImponible" DataTextField="Descripcion" 
                                                                                                DataValueField="IdTipoBaseImp" Width="100%" TabIndex="11">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="f41">
                                                                                        <td colspan="4" style="font-size: 3pt" __designer:mapid="f42">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="f43">
                                                                            <td __designer:mapid="f44">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="f45">
                                                                                    <tr __designer:mapid="f46">
                                                                                        <td valign="top" width="80%" __designer:mapid="f47">
                                                                                            <table cellpadding="0" cellspacing="0" style="width: 100%" 
                                                                                                __designer:mapid="f48">
                                                                                                <tr __designer:mapid="f49">
                                                                                                    <td class="Texto" style="font-weight: 700" __designer:mapid="f4a">
                                                                                                        Documento de Referencia</td>
                                                                                                </tr>
                                                                                                <tr __designer:mapid="f4b">
                                                                                                    <td __designer:mapid="f4c">
                                                                                                        <table cellpadding="0" cellspacing="0" style="width: 100%" 
                                                                                                            __designer:mapid="f4d">
                                                                                                            <tr __designer:mapid="f4e">
                                                                                                                <td style="font-family: Arial; font-size: 9pt" valign="middle" width="10%" 
                                                                                                                    __designer:mapid="f4f">
                                                                                                                    Tipo Doc.:</td>
                                                                                                                <td width="90%" __designer:mapid="f50">
                                                                                                                    <telerik:RadComboBox ID="RadComboBox9" Runat="server" AllowCustomText="True" 
                                                                                                                        DataSourceID="odsTipoDocumento" DataTextField="Nombre" 
                                                                                                                        DataValueField="IdTipoDocumento" EnableLoadOnDemand="True" 
                                                                                                                        EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                                        ShowMoreResultsBox="True" Width="95%">
                                                                                                                    </telerik:RadComboBox>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                        </table>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr __designer:mapid="f52">
                                                                                                    <td __designer:mapid="f53">
                                                                                                        <table cellpadding="0" cellspacing="0" style="width: 100%" 
                                                                                                            __designer:mapid="f54">
                                                                                                            <tr class="Texto" __designer:mapid="f55">
                                                                                                                <td colspan="8" style="font-size: 3pt; height: 7px;" __designer:mapid="f56">
                                                                                                                    </td>
                                                                                                            </tr>
                                                                                                            <tr class="Texto" __designer:mapid="f57">
                                                                                                                <td width="10%" __designer:mapid="f58">
                                                                                                                    Serie:</td>
                                                                                                                <td width="15%" __designer:mapid="f59">
                                                                                                                    <asp:TextBox ID="TextBox6" runat="server" MaxLength="4" Width="70px"></asp:TextBox>
                                                                                                                </td>
                                                                                                                <td style="text-align: center" width="10%" __designer:mapid="f5b">
                                                                                                                    N° Doc.</td>
                                                                                                                <td width="15%" __designer:mapid="f5c">
                                                                                                                    <asp:TextBox ID="TextBox4" runat="server" Width="70px"></asp:TextBox>
                                                                                                                </td>
                                                                                                                <td style="text-align: center" width="10%" __designer:mapid="f5e">
                                                                                                                    Fecha:</td>
                                                                                                                <td width="15%" __designer:mapid="f5f">
                                                                                                                    <asp:TextBox ID="txtDate3" runat="server" AutoPostBack="True" Width="70px" />
                                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender4" runat="server" 
                                                                                                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                                        TargetControlID="txtDate3" />
                                                                                                                    <asp:MaskedEditValidator ID="MaskedEditValidator4" runat="server" 
                                                                                                                        ControlExtender="MaskedEditExtender4" ControlToValidate="txtDate3" 
                                                                                                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                                                </td>
                                                                                                                <td style="text-align: center" width="10%" __designer:mapid="f63">
                                                                                                                    T.C.:</td>
                                                                                                                <td width="15%" __designer:mapid="f64">
                                                                                                                    <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" Value="0" 
                                                                                                                        Width="70px" EnableEmbeddedBaseStylesheet="False" 
                                                                                                                        EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                                        EnableAjaxSkinRendering="False">
                                                                                                                        <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                                        <NumberFormat DecimalDigits="4" />
                                                                                                                    </telerik:RadNumericTextBox>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                        </table>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                        <td width="20%" __designer:mapid="f67">
                                                                                            <table class="tabla4" __designer:mapid="f68">
                                                                                                <tr __designer:mapid="f69">
                                                                                                    <td style="font-family: Arial; font-size: 8pt; width: 97px" 
                                                                                                        __designer:mapid="f6a">
                                                                                                        TOTAL:</td>
                                                                                                    <td __designer:mapid="f6b">
                                                                                                        <telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" Value="0" Width="70px" 
                                                                                                            EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                            EnableEmbeddedSkins="False" EnableAjaxSkinRendering="False" TabIndex="12">
                                                                                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                            <ClientEvents OnValueChanged="Calcular" />
                                                                                                        </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr __designer:mapid="f6e">
                                                                                                    <td class="Texto" style="width: 97px" __designer:mapid="f6f">
                                                                                                        Base Imponible:</td>
                                                                                                    <td __designer:mapid="f70">
                                                                                                        <telerik:RadNumericTextBox ID="RadNumericTextBox7" Runat="server" 
                                                                                                            Value="0" Width="70px" EnableEmbeddedBaseStylesheet="False" 
                                                                                                            EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                            EnableAjaxSkinRendering="False">
                                                                                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                        </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr __designer:mapid="f72">
                                                                                                    <td style="width: 97px; font-family: Arial; font-size: 9pt;" 
                                                                                                        __designer:mapid="f73">
                                                                                                        Importe IGV:</td>
                                                                                                    <td __designer:mapid="f74">
                                                                                                        <telerik:RadNumericTextBox ID="RadNumericTextBox4" Runat="server" Value="0" 
                                                                                                            Width="70px" EnableEmbeddedBaseStylesheet="False" 
                                                                                                            EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                            EnableAjaxSkinRendering="False">
                                                                                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                        </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr __designer:mapid="f76">
                                                                                                    <td style="width: 97px; font-family: Arial; font-size: 9pt;" 
                                                                                                        __designer:mapid="f77">
                                                                                                        Otros:</td>
                                                                                                    <td __designer:mapid="f78">
                                                                                                        <telerik:RadNumericTextBox ID="RadNumericTextBox6" Runat="server" Value="0" 
                                                                                                            Width="70px" EnableEmbeddedBaseStylesheet="False" 
                                                                                                            EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                            EnableAjaxSkinRendering="False">
                                                                                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                        </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="f7a">
                                                                            <td class="Texto" style="font-weight: 700" __designer:mapid="f7b">
                                                                                Detraccion</td>
                                                                        </tr>
                                                                        <tr __designer:mapid="f7e">
                                                                            <td __designer:mapid="f7f">
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%" 
                                                                                    __designer:mapid="f80">
                                                                                    <tr class="Texto" __designer:mapid="f81">
                                                                                        <td width="8%" __designer:mapid="f82">
                                                                                            Bien/Servicio:</td>
                                                                                        <td width="92%" __designer:mapid="f83">
                                                                                            <telerik:RadComboBox ID="RadComboBox11" Runat="server" AllowCustomText="True" DataSourceID="odsDetraccion" 
                                                                                                DataTextField="Detraccion" DataValueField="IdDetraccion" 
                                                                                                EnableLoadOnDemand="True" MarkFirstMatch="True" Width="100%">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: center">
                                                                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                                                                CellSpacing="0" DataSourceID="odsLinea" GridLines="None" 
                                                                Width="100%" Skin="Hay" style="text-align: left" ShowFooter="True" 
                                                                                EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" 
                                                                                EnableEmbeddedScripts="False">
                                                                                <MasterTableView ClientDataKeyNames="IdLinea" DataKeyNames="IdLinea" 
                                                                                    DataSourceID="odsLinea" NoMasterRecordsText="No existen registros." 
                                                                                    CommandItemDisplay="Top">
                                                                                    <CommandItemSettings AddNewRecordText="Agregar Línea" 
                                                                                        ExportToPdfText="Export to PDF" RefreshText="Refrescar" />
                                                                                    <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                                                                        <HeaderStyle Width="20px" />
                                                                                    </RowIndicatorColumn>
                                                                                    <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                                                                        <HeaderStyle Width="20px" />
                                                                                    </ExpandCollapseColumn>
                                                                                    <Columns>
                                                                                        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                            FilterControlAltText="Filter EditCommandColumn column" UniqueName="editar" 
                                                                                            UpdateText="Editar">
                                                                                            <ItemStyle Width="2%" />
                                                                                        </telerik:GridEditCommandColumn>
                                                                                        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                            ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro que desea Eliminar el Registro?" 
                                                                                            ConfirmTitle="Mensaje de Confirmación" FilterControlAltText="Filter column2 column" 
                                                                                            ImageUrl="~\img\delete.gif" Text="Eliminar" UniqueName="eliminar">
                                                                                            <ItemStyle Width="2%" />
                                                                                        </telerik:GridButtonColumn>
                                                                                        <telerik:GridBoundColumn DataField="Cuenta" 
                                                                                            FilterControlAltText="Filter column column" HeaderText="Cuenta" 
                                                                                            UniqueName="column">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Left" Width="35%" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="CCosto.Codigo" 
                                                                                            FilterControlAltText="Filter column3 column" HeaderText="C.Costo" 
                                                                                            UniqueName="column3" FooterText="TOTAL:">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Center" Width="10%" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="MontoCargo" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter Cargo column" HeaderText="Cargo" 
                                                                                            SortExpression="Cargo" UniqueName="Cargo" DataFormatString="{0:N2}" 
                                                                                            Aggregate="Sum" FooterAggregateFormatString="{0:N2}">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Right" Width="8%" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="MontoAbono" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter Abono column" HeaderText="Abono" 
                                                                                            SortExpression="Abono" UniqueName="Abono" DataFormatString="{0:N2}" 
                                                                                            Aggregate="Sum" FooterAggregateFormatString="{0:N2}">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Right" Width="8%" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Glosa" 
                                                                                            FilterControlAltText="Filter Glosa column" HeaderText="Glosa" 
                                                                                            SortExpression="Glosa" UniqueName="Glosa">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle Width="35%" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdLinea" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter IdLinea column" HeaderText="IdLinea" 
                                                                                            ReadOnly="True" SortExpression="IdLinea" UniqueName="IdLinea" 
                                                                                            Visible="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdTransaccion" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter Transaccion column" HeaderText="Transaccion" 
                                                                                            SortExpression="Transaccion" UniqueName="Transaccion" Visible="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdPlan" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter Cta column" HeaderText="Cuenta" 
                                                                                            SortExpression="Cta" UniqueName="Cta" Visible="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdCCosto" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter ElemGto column" HeaderText="C. Costo" 
                                                                                            SortExpression="ElemGto" UniqueName="ElemGto" Visible="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                    </Columns>
                                                                                    <EditFormSettings EditFormType="WebUserControl" 
                                                                                        UserControlName="~\Contabilidad\Controles\ControlTransaccion.ascx">
                                                                                        <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                                                                        </EditColumn>
                                                                                    </EditFormSettings>
                                                                                    <CommandItemTemplate>
                                                                                        <asp:ImageButton ID="ImageButton8" runat="server" 
                                                                                            ImageUrl="~/img/AgregarLinea.gif" onclick="ImageButton8_Click" />
                                                                                    </CommandItemTemplate>
                                                                                </MasterTableView>
                                                                                <FilterMenu EnableImageSprites="False">
                                                                                </FilterMenu>
                                                                                <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                                                                                </HeaderContextMenu>
                                                                            </telerik:RadGrid>
                                                               
                                                        </td>
                                                    </tr>
                                                    </table>

                                                <asp:ObjectDataSource ID="odsLinea" runat="server" 
                                                    SelectMethod="GetLINEAByIdTransaccionAndFlag" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.LineaBL">
                                                    <SelectParameters>
                                                        <asp:SessionParameter Name="IdTransaccion" SessionField="IdTransaccion" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsOpFinanciera" runat="server" 
                                                    SelectMethod="GetAllFromOperacionFinanciera" 
                                                    TypeName="SistFoncreagro.BussinesLogic.OperacionFinancieraBL">
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsSubDiario" runat="server" 
                                                    SelectMethod="GetAllSUBDIARIO" 
                                                    TypeName="SistFoncreagro.BussinesLogic.SubdiarioBL"></asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsDocumentoContabilizado" runat="server" 
                                                    SelectMethod="GetAllFromDOCUMENTOCONTABILIZADO" 
                                                    TypeName="SistFoncreagro.BussinesLogic.DocumentoContabilizadoBL">
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsTipoDocumento" runat="server" 
                                                    SelectMethod="GetAllFromTIPODOCUMENTO" 
                                                    TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoBL">
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsTipoBaseImponible" runat="server" 
                                                    SelectMethod="GetAllFromTIPOBASEIMPONIBLE" 
                                                    TypeName="SistFoncreagro.BussinesLogic.TipoBaseImponibleBL">
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsDetraccion" runat="server" 
                                                    SelectMethod="GetAllFromDetraccion" 
                                                    TypeName="SistFoncreagro.BussinesLogic.DetraccionBL"></asp:ObjectDataSource>
                                            
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default" 
        EnableEmbeddedScripts="False">
    </telerik:RadAjaxLoadingPanel>
  

                                                                                <telerik:RadNumericTextBox ID="RadNumericTextBox8" Runat="server" 
                                                                                    BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="White" 
                                                                                    Value="0" Width="80px" ReadOnly="True">
                                                                                </telerik:RadNumericTextBox>
  

<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function kH(e) {

            var pK = document.all ? window.event.keyCode : e.which;
            return pK != 13;
        }

        document.onkeypress = kH;
        if (document.layers) document.captureEvents(Event.KEYPRESS);

      
        function Calcular() {
            var base = 0;
            var montoIgv = 0;
            var total = 0;
            var T_total = $find("<%= RadNumericTextBox3.ClientID %>");
            var T_igv = $find("<%= RadNumericTextBox8.ClientID %>");
            var T_base = $find("<%= RadNumericTextBox7.ClientID %>");
            var T_otros = $find("<%= RadNumericTextBox6.ClientID %>");
            var T_tipo = document.getElementById('ctl00_ctl00_MainContent_MainContent_DropDownList3')
            var T_MontoIgv = $find("<%= RadNumericTextBox4.ClientID %>");

            if (T_tipo.value == 3) {
                base = T_total.get_value();
                T_base.set_value(base);
                montoIgv = 0;
                T_MontoIgv.set_value(montoIgv);
                T_otros.focus();
            }
            else {
                base = T_total.get_value() / (1.00 + (T_igv.get_value() / 100.00));
                T_base.set_value(base);
                montoIgv = base * (T_igv.get_value() / 100.00);
                T_MontoIgv.set_value(montoIgv);
                T_otros.focus();
            }
            total = T_base.get_value() + T_MontoIgv.get_value() + T_otros.get_value();
            if (total != T_total.get_value()) {
                alert('¡No coinciden los Montos!');
            }

         }

        function Validar() {
            var total = 0;
            var T_total = $find("<%= RadNumericTextBox3.ClientID %>");
            var T_base = $find("<%= RadNumericTextBox7.ClientID %>");
            var T_otros = $find("<%= RadNumericTextBox6.ClientID %>");
            var T_MontoIgv = $find("<%= RadNumericTextBox4.ClientID %>");

            total = T_base.get_value() + T_MontoIgv.get_value() + T_otros.get_value();
            if (total != T_total.get_value()) {
                alert('¡No coinciden los Montos!');
            }
        }

        function Abrir() {
            var oWnd = radopen("/SistIntegral/Logistica/FrmProveedores.aspx", "Proveedores");
        }
        function Cerrar() {

            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ActualizarLista");
        }
        
        function Foco() {
            document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDate1').value = ''

        }
        function Foco1() {
            document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDate3').value = ''

        }
        function Foco2() {
            document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDate').value = '';

        }
        function Foco3() {
            document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox5').value = '';
            document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox5').focus;
        }
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Mensaje");
        }
        function ponerCeros() {
            var obj = document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox5');
            while (obj.value.length < 4)
                obj.value='0' + obj.value;
        }
        function ponerCeros1() {
            var obj = document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox6');
            while (obj.value.length < 4)
                obj.value = '0' + obj.value;
        }
        function ValidarFecha() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarFecha");

        }
        function ValidarDocumento() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarDocumento");
        }
        function ValidarTipoDocumento() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarTipoDocumento");
        }
     </script>
    </telerik:RadCodeBlock>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadWindowManager1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox8" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton5">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton6" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton13" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton6">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton5" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton13" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox6">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox6" />
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox5" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList3" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="txtDate1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                                <telerik:AjaxUpdatedControl ControlID="txtDate2" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="txtDate3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox2" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton5" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton6" />
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox5" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList3" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>


                                                </asp:Content>