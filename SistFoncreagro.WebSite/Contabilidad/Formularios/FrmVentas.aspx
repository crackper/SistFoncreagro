<%@ Page Title="Registro de Ventas" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterContabilidad1.master" CodeBehind="FrmVentas.aspx.vb" Inherits="SistFoncreagro.WebSite.RegTransaccion" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
     <Windows>
                <telerik:RadWindow ID="Clientes" runat="server" Behavior="Close" 
                    Height="600px"
                    InitialBehavior="None" Left="" Modal="True" NavigateUrl="" OnClientClose="Cerrar"
                     Style="display: none;" Top="" VisibleStatusbar="True"
                    Width="800px" Title="Registro de Clientes" >
                </telerik:RadWindow>
            </Windows>
                            </telerik:RadWindowManager>

                                                <table align="center" 
        class="tabla3">
                                                    <tr>
                                                        <td style="width: 892px">
                                                            <table style="width: 180px">
                                                                <tr>
                                                                    <td>
                                                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                                ToolTip="Grabar" BorderColor="Gray" BorderStyle="Solid" 
                                                                BorderWidth="0px" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/img/Nuevo.gif" 
                                                                ToolTip="Nuevo" BorderColor="Gray" BorderStyle="Solid" BorderWidth="0px" 
                                                                CausesValidation="False" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton5" runat="server" 
                                                                ImageUrl="~/img/Proceso.gif" ToolTip="Procesar" BorderColor="Gray" 
                                                                BorderStyle="Solid" BorderWidth="0px" Width="25px" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton6" runat="server" 
                                                                ImageUrl="~/img/Deshacer.gif" ToolTip="Deshacer" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/img/Buscar.gif" 
                                                                            ToolTip="Ver el Voucher" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/img/Aceptar.gif" 
                                                                            ToolTip="Validar Comprobante" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                                    <table cellpadding="0" cellspacing="0" style="width: 100%" 
                                                                        __designer:mapid="fe6">
                                                                        <tr __designer:mapid="fe7">
                                                                            <td class="Texto" style="font-weight: 700" __designer:mapid="fe8">
                                                                                Datos Generales</td>
                                                                        </tr>
                                                                        <tr __designer:mapid="fe9">
                                                                            <td __designer:mapid="fea">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="feb">
                                                                                    <tr class="Texto" __designer:mapid="fec">
                                                                                        <td width="8%" __designer:mapid="fed">
                                                                                            Op. Finan.:</td>
                                                                                        <td width="34%" __designer:mapid="fee">
                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                                                                                DataSourceID="odsOpFinanciera" DataTextField="Descripcion" 
                                                                                                DataValueField="IdOpFinanciera" Width="90%" Enabled="False">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ff0">
                                                                                            SubDiario:</td>
                                                                                        <td width="34%" __designer:mapid="ff1">
                                                                                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="odsSubDiario" 
                                                                                                DataTextField="Codigo" DataValueField="IdSubDiario" Width="95%" 
                                                                                                Enabled="False">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ff3">
                                                                                            Codigo:</td>
                                                                                        <td width="8%" __designer:mapid="ff4">
                                                                                            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="70px"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="fec">
                                                                                        <td __designer:mapid="fed" colspan="6" style="font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="ff6">
                                                                            <td __designer:mapid="ff7">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="ff8">
                                                                                    <tr class="Texto" __designer:mapid="ff9">
                                                                                        <td width="8%" __designer:mapid="ffa">
                                                                                            Proyecto:</td>
                                                                                        <td width="76%" __designer:mapid="ffb">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="False" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                 ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" TabIndex="1" >
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox3" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Proyecto!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ffd">
                                                                                            Fecha Cont.:</td>
                                                                                        <td width="8%" __designer:mapid="ffe">
                                                                                            <asp:TextBox ID="txtDate" runat="server" Width="70px" TabIndex="2" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                            AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                            TargetControlID="txtDate" />
                                                                                           
                                                                        <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                            ControlExtender="MaskedEditExtender1" ControlToValidate="txtDate" 
                                                                            Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                            InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="ff9">
                                                                                        <td __designer:mapid="ffa" colspan="4" style="font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="1003">
                                                                                        <td width="8%" __designer:mapid="1004">
                                                                                            Tipo Doc.:</td>
                                                                                        <td width="76%" __designer:mapid="1005">
                                                                                            <telerik:RadComboBox ID="RadComboBox6" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsDocumentoContabilizado" DataTextField="Documento" 
                                                                                                DataValueField="IdDocumentoCont" EnableAutomaticLoadOnDemand="False" 
                                                                                                EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                                                                                MarkFirstMatch="True" ShowMoreResultsBox="True" ValidationGroup="Transaccion" 
                                                                                                Width="98%" onclientselectedindexchanged="Actualizar" TabIndex="3">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="RadComboBox6" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Tipo de Documento!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="1007">
                                                                                            Serie:</td>
                                                                                        <td width="8%" __designer:mapid="1008">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" MaxLength="4" Width="70px" 
                                                                                                TabIndex="4"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                                                ControlToValidate="TextBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Serie!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="100a">
                                                                            <td __designer:mapid="100b">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="100c">
                                                                                    <tr class="Texto" __designer:mapid="100d">
                                                                                        <td colspan="8" style="font-size: 3pt" __designer:mapid="100e">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="100f">
                                                                                        <td width="8%" __designer:mapid="1010">
                                                                                            N° Doc:</td>
                                                                                        <td width="20%" __designer:mapid="1011">
                                                                                            <asp:TextBox ID="TextBox3" runat="server" Width="70px" TabIndex="5"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                                                ControlToValidate="TextBox3" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el N° de Documento!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td style="text-align: center" width="10%" __designer:mapid="1013">
                                                                                            Fecha Emisión:</td>
                                                                                        <td width="18%" __designer:mapid="1014">
                                                                                           <asp:TextBox ID="txtDate1" runat="server" AutoPostBack="True" 
                                                                            ValidationGroup="Transaccion" Width="70px" TabIndex="6" />
                                                                        <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                                                            AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                            TargetControlID="txtDate1" />
                                                                        <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                                                            ClientIDMode="AutoID" ControlExtender="MaskedEditExtender2" 
                                                                            ControlToValidate="txtDate1" Display="Dynamic" 
                                                                            EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                            ValidationGroup="Transaccion" />
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                                                                ControlToValidate="txtDate1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Fecha de Emisión!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="10%" __designer:mapid="1019">
                                                                                            Tipo Cambio:</td>
                                                                                        <td width="18%" __designer:mapid="101a" style="text-align: left">
                                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" 
                                                                                                ClientIDMode="AutoID" Value="0" Width="70px" 
                                                                                                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                EnableEmbeddedSkins="False" TabIndex="7">
                                                                                                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                <NumberFormat DecimalDigits="4" />
                                                                                            </telerik:RadNumericTextBox>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="101d">
                                                                                            Vencimiento:</td>
                                                                                        <td width="8%" __designer:mapid="101e">
                                                                                             <asp:TextBox ID="txtDate2" runat="server" ValidationGroup="DtVal" 
                                                Width="70px" TabIndex="8" />
                                            <asp:MaskedEditExtender ID="MaskedEditExtender3" runat="server" 
                                                AcceptNegative="None" CultureName="en-GB" 
                                Mask="99/99/9999" MaskType="Date" 
                                                TargetControlID="txtDate2" />
                                            <asp:MaskedEditValidator ID="MaskedEditValidator3" runat="server" 
                                                ControlExtender="MaskedEditExtender3" ControlToValidate="txtDate2" 
                                                Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                InvalidValueMessage="¡Fecha Incorrecta!" ValidationGroup="DtVal" />
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="1022">
                                                                            <td __designer:mapid="1023">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="1024">
                                                                                    <tr class="Texto" __designer:mapid="1025">
                                                                                        <td width="8%" __designer:mapid="1026" colspan="2" 
                                                                                            style="width: 100%; font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                        <td width="8%" __designer:mapid="1026" 
                                                                                            style="width: 100%; font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="1025">
                                                                                        <td width="8%" __designer:mapid="1026">
                                                                                            Cliente:</td>
                                                                                        <td width="72%" __designer:mapid="1027">
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" AllowCustomText="True" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="100%" 
                                                                                                EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" 
                                                                                                EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" TabIndex="9">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                                                ControlToValidate="RadComboBox8" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Cliente!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="20%" __designer:mapid="1027" style="text-align: left">
                                                                                            <asp:ImageButton ID="ImageButton7" runat="server" ImageAlign="Middle" 
                                                                                                ImageUrl="~/img/Agregar.gif" ToolTip="Registrar Cliente" 
                                                                                                CausesValidation="False" />
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="1025">
                                                                                        <td width="8%" __designer:mapid="1026" colspan="2" 
                                                                                            style="width: 100%; font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                        <td width="8%" __designer:mapid="1026" 
                                                                                            style="width: 100%; font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="1030">
                                                                            <td __designer:mapid="1031">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="1032">
                                                                                    <tr __designer:mapid="1033">
                                                                                        <td valign="top" width="80%" __designer:mapid="1034">
                                                                                            <table cellpadding="0" cellspacing="0" style="width: 100%" 
                                                                                                __designer:mapid="1035">
                                                                                                <tr __designer:mapid="1038">
                                                                                                    <td __designer:mapid="1039">
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%" 
                                                                                    __designer:mapid="102b">
                                                                                    <tr class="Texto" >
                                                                                        <td width="11%" __designer:mapid="102d">
                                                                                            Glosa:</td>
                                                                                        <td width="73%" __designer:mapid="102e">
                                                                                            
                                                                                            <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Width="95%" 
                                                                                                TabIndex="10" CssClass="TextBoxAlignIzquierda"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                                                ErrorMessage="¡Debe ingresar la Glosa!" Display="Dynamic" 
                                                                                                ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="16%" __designer:mapid="102e" colspan="2" 
                                                                                            style="text-align: left; width: 16%">
                                                                                            &nbsp;&nbsp;&nbsp;
                                                                                            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="False" 
                                                                                                Text="Afecto IGV:" TextAlign="Left" />
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="102c">
                                                                                        <td width="8%" __designer:mapid="102d" colspan="2" 
                                                                                            style="width: 100%; font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                        <td width="8%" __designer:mapid="102d" style="width: 100%; font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                        <td width="8%" __designer:mapid="102d" style="width: 100%; font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr __designer:mapid="103f">
                                                                                                    <td __designer:mapid="1040">
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
                                                                                                                    <asp:TextBox ID="TextBox5" runat="server" MaxLength="4" Width="70px"></asp:TextBox>
                                                                                                                </td>
                                                                                                                <td style="text-align: center" width="10%" __designer:mapid="f5b">
                                                                                                                    N° Doc.</td>
                                                                                                                <td width="15%" __designer:mapid="f5c">
                                                                                                                    <asp:TextBox ID="TextBox6" runat="server" MaxLength="4" Width="70px"></asp:TextBox>
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
                                                                                                                        EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
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
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                        <td width="20%" __designer:mapid="1054">
                                                                                            <table class="tabla4" __designer:mapid="1055">
                                                                                                <tr __designer:mapid="1056">
                                                                                                    <td style="font-family: Arial; font-size: 9pt; width: 97px" 
                                                                                                        __designer:mapid="1057">
                                                                                                        TOTAL:</td>
                                                                                                    <td __designer:mapid="1058">
                                                                                                        <telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" Value="0" Width="70px" 
                                                                                                            EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                            EnableEmbeddedSkins="False" TabIndex="11">
                                                                                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                            <ClientEvents OnValueChanged="Calcular" />
                                                                                                        </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr __designer:mapid="105b">
                                                                                                    <td class="Texto" style="width: 97px" __designer:mapid="105c">
                                                                                                        Base Imponible:</td>
                                                                                                    <td __designer:mapid="105d">
                                                                                                        <telerik:RadNumericTextBox ID="RadNumericTextBox7" Runat="server" 
                                                                                                            Value="0" Width="70px" EnableEmbeddedBaseStylesheet="False" 
                                                                                                            EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
                                                                                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                        </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr __designer:mapid="105f">
                                                                                                    <td style="width: 97px; font-family: Arial; font-size: 9pt;" 
                                                                                                        __designer:mapid="1060">
                                                                                                        <asp:Label ID="Label3" runat="server" Text="Importe IGV:"></asp:Label>
                                                                                                    </td>
                                                                                                    <td __designer:mapid="1061">
                                                                                                        <telerik:RadNumericTextBox ID="RadNumericTextBox4" Runat="server" Value="0" 
                                                                                                            Width="70px" EnableEmbeddedBaseStylesheet="False" 
                                                                                                            EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
                                                                                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                        </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr __designer:mapid="1063">
                                                                                                    <td style="width: 97px; font-family: Arial; font-size: 9pt;" 
                                                                                                        __designer:mapid="1064">
                                                                                                        Base no Afecto:</td>
                                                                                                    <td __designer:mapid="1065">
                                                                                                        <telerik:RadNumericTextBox ID="RadNumericTextBox11" Runat="server" Value="0" 
                                                                                                            Width="70px" EnableEmbeddedBaseStylesheet="False" 
                                                                                                            EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
                                                                                                            <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                        </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr __designer:mapid="1067">
                                                                                                    <td style="width: 97px; font-family: Arial; font-size: 9pt;" 
                                                                                                        __designer:mapid="1068">
                                                                                                        Otros:</td>
                                                                                                    <td __designer:mapid="1069">
                                                                                                        <telerik:RadNumericTextBox ID="RadNumericTextBox6" Runat="server" Value="0" 
                                                                                                            Width="70px" EnableEmbeddedBaseStylesheet="False" 
                                                                                                            EnableEmbeddedScripts="False" EnableEmbeddedSkins="False">
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


                                                                                <telerik:RadNumericTextBox ID="RadNumericTextBox8" 
        Runat="server" 
                                                                                    
        BackColor="White" BorderColor="White" BorderStyle="None" 
        ForeColor="White" 
                                                                                    
        Value="0" Width="80px">
                                                                                </telerik:RadNumericTextBox>


    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadWindowManager1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox8" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton5" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton6" />
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox1" />
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
                                                                <telerik:AjaxUpdatedControl ControlID="CheckBox1" />
                                                                <telerik:AjaxUpdatedControl ControlID="Label3" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox6" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox8" />
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
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton7">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox8" />
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
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton13" />
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="CheckBox1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox7" />
                                                                <telerik:AjaxUpdatedControl ControlID="Label3" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox4" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox11" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox8" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>


<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function kH(e) {

            var pK = document.all ? window.event.keyCode : e.which;
            return pK != 13;
        }

        document.onkeypress = kH;
        if (document.layers) document.captureEvents(Event.KEYPRESS);

        function ModifyEnterKeyPressAsTab() {
            if (event.keyCode == 13) {
                var serie = $find("<%= RadComboBox8.ClientID %>");
             if (serie.get_value().length != 0) {

                    event.keyCode = 8;
                    return event.keyCode;

                }

            }

        }
        function Calcular() {
            var base = 0;
            var baseNA = 0;
            var montoIgv = 0;
            var total = 0;
            var T_total = $find("<%= RadNumericTextBox3.ClientID %>");
            var T_igv = $find("<%= RadNumericTextBox8.ClientID %>");
            var T_base = $find("<%= RadNumericTextBox7.ClientID %>");
            var T_baseNA = $find("<%= RadNumericTextBox11.ClientID %>");
            var T_otros = $find("<%= RadNumericTextBox6.ClientID %>");
            var T_MontoIgv = $find("<%= RadNumericTextBox4.ClientID %>");
            var Check = document.getElementById('ctl00_ctl00_MainContent_MainContent_CheckBox1');

            if (Check.checked == true) {
                base = T_total.get_value() / (1.00 + (T_igv.get_value() / 100.00));
                T_base.set_value(base);
                montoIgv = base * (T_igv.get_value() / 100.00);
                T_MontoIgv.set_value(montoIgv);
                T_baseNA.set_value(baseNA);
                T_otros.focus();

                total = T_base.get_value() + T_MontoIgv.get_value() + T_baseNA.get_value()+T_otros.get_value();
            }
            else {
                
                T_base.set_value(base);
                T_MontoIgv.set_value(montoIgv);
                T_baseNA.set_value(T_total.get_value());
                T_otros.focus();

                total = T_base.get_value() + T_MontoIgv.get_value() + T_baseNA.get_value()+T_otros.get_value();
            }

               
            if (total != T_total.get_value()) {
                alert('¡No coinciden los Montos!');
            }

             
        }

        function Abrir() {
            var oWnd = radopen("/SistIntegral/Logistica/FrmProveedores.aspx", "Clientes");
        }
        function Cerrar() {
           
                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ActualizarLista");
                }
        function Alerta(Texto) {
            radalert(Texto, 300, 50,'Alerta');
        }
        function ponerCeros() {
            var obj = document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox2');
            while (obj.value.length < 4)
                obj.value = '0' + obj.value;
        }
        function ponerCeros1() {
            var obj = document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox5');
            while (obj.value.length < 4)
                obj.value = '0' + obj.value;
        }
        function ValidarFecha() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarFecha");

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
        function Actualizar() {
           $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Actualizar");

       }
       function ValidarDocumento() {
           $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarDocumento");

       }
     </script>
    </telerik:RadCodeBlock>
                                                </asp:Content>