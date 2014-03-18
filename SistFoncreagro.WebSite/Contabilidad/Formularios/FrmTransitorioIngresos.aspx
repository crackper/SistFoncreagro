<%@ Page Title="Movimientos Transitorios - Ingresos" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterContabilidad1.master" CodeBehind="FrmTransitorioIngresos.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmTransitorioIngresos" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
  <Windows>
                <telerik:RadWindow ID="Coa" runat="server" Behavior="Minimize, Close" 
                    Behaviors="Default" Height="750px"
                    InitialBehavior="None" Left="" Modal="True" NavigateUrl="" OnClientClose="Cerrar"
                     Style="display: none;" Top="" VisibleStatusbar="True"
                    Width="500px" Title="Registro de Coa" AutoSize="True">
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
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/img/Proceso.gif" 
                                                                            ToolTip="Procesar" CausesValidation="False" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton10" runat="server" 
                                                                            ImageUrl="~/img/Deshacer.gif" ToolTip="Deshacer" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/img/Buscar.gif" 
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
                                                                                        <td width="25%" __designer:mapid="eee">
                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                                                                                DataSourceID="odsOpFinanciera" DataTextField="Descripcion" 
                                                                                                DataValueField="IdOpFinanciera" Width="90%" TabIndex="1" Enabled="False">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ef0">
                                                                                            SubDiario:</td>
                                                                                        <td width="43%" __designer:mapid="ef1">
                                                                                            <telerik:RadComboBox ID="RadComboBox10" Runat="server" AllowCustomText="True" DataTextField="Codigo" 
                                                                                                DataValueField="IdSubDiario" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="97%" TabIndex="2" AutoPostBack="True" 
                                                                                                DataSourceID="odsSubDiario">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                                                                                ControlToValidate="RadComboBox10" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el SubDiario!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ef3">
                                                                                            Codigo:</td>
                                                                                        <td width="8%" __designer:mapid="ef4">
                                                                                            <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Width="70px"></asp:TextBox>
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
                                                                                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" TabIndex="3">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox3" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Proyecto!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="f00">
                                                                                            Fecha Cont.:</td>
                                                                                        <td width="8%" __designer:mapid="f01">
                                                                                            <asp:TextBox ID="txtDate" runat="server" Width="68px" TabIndex="4" />
                                                                                             <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate" />
                                                                                            <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender1" 
                                                                                                ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" />
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                                                                ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Fecha Contable!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td __designer:mapid="efc" colspan="4" style="font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td __designer:mapid="efc" colspan="4">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="f2e">
                                                                                    <tr class="Texto" __designer:mapid="f2f">
                                                                                        <td __designer:mapid="f30" colspan="3" style="width: 28%; font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="f2f">
                                                                                        <td width="9%" __designer:mapid="f30">
                                                                                            Cta. Banco:</td>
                                                                                        <td width="91%" __designer:mapid="f31" colspan="2" style="margin-left: 80px">
                                                                                            <telerik:RadComboBox ID="RadComboBox9" Runat="server" DataTextField="Descripcion" 
                                                                                                DataValueField="IdCtaBancaria"  
                                                                                               
                                                                                                ValidationGroup="Transaccion" Width="100%" 
                                                                                                EmptyMessage="Ingrese la Cuenta Bancaria..." 
                                                                                                onclientselectedindexchanged="Actualizar" TabIndex="5" 
                                                                                                DataSourceID="SqlCuentaBancaria2">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                                                                                ControlToValidate="RadComboBox9" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Cuenta Bancaria!"></asp:RequiredFieldValidator>
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
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td __designer:mapid="efc" colspan="4" style="font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="f06">
                                                                                        <td colspan="4" style="font-size: 9pt" __designer:mapid="f07">
                                                                                            <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                                <tr>
                                                                                                    <td width="8%">
                                                                                                        Coa:</td>
                                                                                                    <td width="72%">
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" AllowCustomText="True" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="100%" EnableAjaxSkinRendering="False" 
                                                                                                            EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                            EnableEmbeddedSkins="False" TabIndex="6">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                                                ControlToValidate="RadComboBox8" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Proveedor!"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                    <td style="text-align: left" width="4%">
                                                                                            <asp:ImageButton ID="ImageButton7" runat="server" ImageAlign="Middle" 
                                                                                                ImageUrl="~/img/Agregar.gif" ToolTip="Registrar Cliente" 
                                                                                                CausesValidation="False" />
                                                                                                    </td>
                                                                                                    <td width="8%">
                                                                                                        T. Cambio:</td>
                                                                                                    <td width="8%">
                                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" 
                                                                                                ClientIDMode="AutoID" Value="0" Width="70px" 
                                                                                                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                EnableEmbeddedSkins="False" TabIndex="7">
                                                                                                <NumberFormat DecimalDigits="4" />
                                                                                            </telerik:RadNumericTextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td width="8%">
                                                                                            Glosa:</td>
                                                                                                    <td width="72%">
                                                                                            
                                                                                            <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Width="95%" 
                                                                                                TabIndex="8" CssClass="TextBoxAlignIzquierda" Rows="2"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                                                ErrorMessage="¡Debe ingresar la Glosa!" Display="Dynamic" 
                                                                                                ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
                                                                                                    </td>
                                                                                                    <td style="text-align: left" width="4%">
                                                                                                        &nbsp;</td>
                                                                                                    <td width="8%">
                                                                                                        &nbsp;</td>
                                                                                                    <td width="8%">
                                                                                                        &nbsp;</td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                    
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="f36">
                                                                            <td __designer:mapid="f37">
                                                                                &nbsp;</td>
                                                                        </tr>
                                                                        </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: center">
                                                                            
                                                               
                                                                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                                                                CellSpacing="0" DataSourceID="odsLinea" GridLines="None" 
                                                                Width="100%" Skin="Hay" style="text-align: left" ShowFooter="True" EnableEmbeddedBaseStylesheet="False" 
                                                                                                EnableEmbeddedScripts="False">
                                                                                <MasterTableView ClientDataKeyNames="IdLinea" DataKeyNames="IdLinea" 
                                                                                    DataSourceID="odsLinea" NoMasterRecordsText="No existen registros." 
                                                                                    CommandItemDisplay="Top">
                                                                                    <CommandItemSettings AddNewRecordText="Agregar Línea" 
                                                                                        ExportToPdfText="Export to PDF" RefreshText="Refrescar" />
                                                                                    <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                                                                    </RowIndicatorColumn>
                                                                                    <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                                                                    </ExpandCollapseColumn>
                                                                                    <Columns>
                                                                                        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                            FilterControlAltText="Filter EditCommandColumn column" UniqueName="editar" 
                                                                                            UpdateText="Editar">
                                                                                            <HeaderStyle Width="2%" />
                                                                                        </telerik:GridEditCommandColumn>
                                                                                        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                            ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro que desea Eliminar el Registro?" 
                                                                                            ConfirmTitle="Mensaje de Confirmación" FilterControlAltText="Filter column2 column" 
                                                                                            ImageUrl="~\img\delete.gif" Text="Eliminar" UniqueName="eliminar">
                                                                                            <HeaderStyle Width="2%" />
                                                                                        </telerik:GridButtonColumn>
                                                                                        <telerik:GridBoundColumn DataField="Cuenta" 
                                                                                            FilterControlAltText="Filter column column" HeaderText="Cuenta" 
                                                                                            UniqueName="column">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="30%" />
                                                                                            <ItemStyle HorizontalAlign="Left" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Coa" 
                                                                                            FilterControlAltText="Filter column1 column" HeaderText="Coa" 
                                                                                            UniqueName="Coa">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Registro" 
                                                                                            FilterControlAltText="Filter column3 column" HeaderText="Registro" 
                                                                                            UniqueName="Registro" FooterText="TOTAL:">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="12%" />
                                                                                            <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="FechaDocumento" 
                                                                                            DataFormatString="{0:dd/MM/yyyy}" 
                                                                                            FilterControlAltText="Filter FechaDocumento column" HeaderText="Fecha Doc." 
                                                                                            UniqueName="FechaDocumento">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdMoneda" 
                                                                                            FilterControlAltText="Filter IdMoneda column" HeaderText="M." 
                                                                                            UniqueName="IdMoneda">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="TipoCambio" 
                                                                                            FilterControlAltText="Filter TipoCambio1 column" HeaderText="T.C." 
                                                                                            UniqueName="TipoCambio">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="CargoMN" DataFormatString="{0:N2}" 
                                                                                            FilterControlAltText="Filter CargoMN column" HeaderText="Debe MN" 
                                                                                            UniqueName="CargoMN" Aggregate="Sum" DataType="System.Decimal" 
                                                                                            FooterAggregateFormatString="{0:N2}">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="AbonoMN" 
                                                                                            FilterControlAltText="Filter AbonoMN column" HeaderText="Haber MN" 
                                                                                            UniqueName="AbonoMN" Aggregate="Sum" DataFormatString="{0:N2}" 
                                                                                            FooterAggregateFormatString="{0:N2}" DataType="System.Decimal">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="CargoME" 
                                                                                            FilterControlAltText="Filter CargoME column" HeaderText="Debe ME" 
                                                                                            UniqueName="CargoME" Aggregate="Sum" DataFormatString="{0:N2}" 
                                                                                            FooterAggregateFormatString="{0:N2}" DataType="System.Decimal">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="AbonoME" 
                                                                                            FilterControlAltText="Filter AbonoME column" HeaderText="Haber ME" 
                                                                                            UniqueName="AbonoME" Aggregate="Sum" DataFormatString="{0:N2}" 
                                                                                            FooterAggregateFormatString="{0:N2}" DataType="System.Decimal">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="MontoCargo" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter Cargo column" HeaderText="Debe" 
                                                                                            SortExpression="Cargo" UniqueName="Cargo" DataFormatString="{0:N2}" 
                                                                                            Aggregate="Sum" FooterAggregateFormatString="{0:N2}" Visible="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="MontoAbono" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter Abono column" HeaderText="Haber" 
                                                                                            SortExpression="Abono" UniqueName="Abono" DataFormatString="{0:N2}" 
                                                                                            Aggregate="Sum" FooterAggregateFormatString="{0:N2}" Visible="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Glosa" 
                                                                                            FilterControlAltText="Filter Glosa column" HeaderText="Glosa" 
                                                                                            SortExpression="Glosa" UniqueName="Glosa">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="30%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
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
                                                                                            SortExpression="Cta" UniqueName="IdPlan" Visible="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdProveedorCliente" 
                                                                                            FilterControlAltText="Filter IdProveedorCliente column" 
                                                                                            UniqueName="IdProveedorCliente" Visible="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdTipoDocumento" 
                                                                                            FilterControlAltText="Filter IdTipoDocumento column" 
                                                                                            UniqueName="IdTipoDocumento" Visible="False" DataType="System.Int32" 
                                                                                            EmptyDataText="">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="SerieDocumento" 
                                                                                            FilterControlAltText="Filter SerieDocumento column" UniqueName="SerieDocumento" 
                                                                                            Visible="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="NroDocumento" 
                                                                                            FilterControlAltText="Filter NroDocumento column" UniqueName="NroDocumento" 
                                                                                            Visible="False" EmptyDataText="">
                                                                                        </telerik:GridBoundColumn>
                                                                                    </Columns>
                                                                                    <EditFormSettings EditFormType="WebUserControl" 
                                                                                        UserControlName="~\Contabilidad\Controles\ControlDiario.ascx">
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
                                                                                <telerik:RadNumericTextBox ID="RadNumericTextBox8" Runat="server" 
                                                                                    BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="White" 
                                                                                    Value="0" Width="80px" ReadOnly="True">
                                                                                </telerik:RadNumericTextBox>
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                                               
                                                                                            <asp:HiddenField ID="HiddenField1" runat="server" />
                                                <asp:ObjectDataSource ID="odsOpFinanciera" runat="server" 
                                                    SelectMethod="GetAllFromOperacionFinanciera" 
                                                    TypeName="SistFoncreagro.BussinesLogic.OperacionFinancieraBL">
                                                </asp:ObjectDataSource>
                                                               
                                                <asp:ObjectDataSource ID="odsSubDiario" runat="server" 
                                                    SelectMethod="GetSUBDIARIOByIdOpFinanciera" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.SubdiarioBL" 
        OldValuesParameterFormatString="original_{0}">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="1" Name="IdOpFinanciera" Type="Int32" />
                                                    </SelectParameters>
    </asp:ObjectDataSource>
                                                                                            <asp:SqlDataSource ID="SqlCuentaBancaria" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetCUENTABANCOT" SelectCommandType="StoredProcedure">
                                                                                                <SelectParameters>
                                                                                                    <asp:ControlParameter ControlID="RadComboBox3" Name="IdProyecto" 
                                                                                                        PropertyName="SelectedValue" Type="Int32" />
                                                                                                    <asp:ControlParameter ControlID="RadComboBox10" Name="idSubdiario" 
                                                                                                        PropertyName="SelectedValue" Type="Int32" />
                                                                                                </SelectParameters>
    </asp:SqlDataSource>
                                                               
                                                                                            <asp:SqlDataSource ID="SqlCuentaBancaria2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetCUENTABANCO2" SelectCommandType="StoredProcedure">
                                                                                                <SelectParameters>
                                                                                                    <asp:ControlParameter ControlID="RadComboBox3" Name="IdProyecto" 
                                                                                                        PropertyName="SelectedValue" Type="Int32" />
                                                                                                    <asp:ControlParameter ControlID="RadComboBox10" Name="idSubdiario" 
                                                                                                        PropertyName="SelectedValue" Type="Int32" />
                                                                                                </SelectParameters>
    </asp:SqlDataSource>
                                                               
                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                            
             

                                            
                                                <asp:ObjectDataSource ID="odsProveedor1" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL" 
        OldValuesParameterFormatString="original_{0}">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                            
             

                                            
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
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton9" />
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox3" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton9">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton10" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton13" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox9" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton10">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton9" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton13" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox9" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton13">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox10">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox9" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox9" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="txtDate">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton9" />
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox3" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox9" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="HiddenField1">
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                                <telerik:AjaxUpdatedControl ControlID="HiddenField1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>


<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">

        function Abrir() {
            var oWnd = radopen("/SistIntegral/Logistica/FrmProveedores.aspx", "Coa");
        }
        function Cerrar() {

            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ActualizarLista");

        }
        function ponerCeros() {
            var obj = document.getElementById('ctl00_ctl00_MainContent_MainContent_RadGrid1_ctl00_ctl05_EditFormControl_TextBox3')
            if (obj == null) {
                var obj = document.getElementById('ctl00_ctl00_MainContent_MainContent_RadGrid1_ctl00_ctl02_ctl02_EditFormControl_TextBox3')
            }
            while (obj.value.length < 4)
                obj.value = '0' + obj.value;
        }
        function ValidarFecha() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarFecha");

        }
        function Foco() {
            document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDate').value = ''

        }
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }
        function Actualizar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Actualizar");
        }
        function ActualizarGrilla() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ActualizarGrilla");
        }
        function CalcularDolares() {
            var obj = document.getElementById('NTextBox4')
            var obj1 = document.getElementById('NTextBox6')
            var obj2 = document.getElementById('NHiddenField1')

            obj1.value = SepararMiles(obj.value / obj2.value);
            obj.value = SepararMiles(obj.value);

        }
        function CalcularDolares1() {
            var obj = document.getElementById('NTextBox5')
            var obj1 = document.getElementById('NTextBox7')
            var obj2 = document.getElementById('NHiddenField1')

            obj1.value = SepararMiles(obj.value / obj2.value);
            obj.value = SepararMiles(obj.value);

        }
        function CalcularSoles() {
            var obj = document.getElementById('NTextBox6')
            var obj1 = document.getElementById('NTextBox4')
            var obj2 = document.getElementById('NHiddenField1')

            obj1.value = SepararMiles(obj.value * obj2.value);
            obj.value = SepararMiles(obj.value);

        }
        function CalcularSoles1() {
            var obj = document.getElementById('NTextBox7')
            var obj1 = document.getElementById('NTextBox5')
            var obj2 = document.getElementById('NHiddenField1')

            obj1.value = SepararMiles(obj.value * obj2.value);
            obj.value = SepararMiles(obj.value);

        }
        function Formatear(numero) {
            var obj = document.getElementById('NTextBox4')
            obj.value = SepararMiles(obj.value);

        }
        function Formatear1(numero) {
            var obj = document.getElementById('NTextBox5')
            obj.value = SepararMiles(obj.value);

        }
        function Formatear2(numero) {
            var obj = document.getElementById('NTextBox6')
            obj.value = SepararMiles(obj.value);

        }
        function Formatear3(numero) {
            var obj = document.getElementById('NTextBox7')
            obj.value = SepararMiles(obj.value);

        }
        function SepararMiles(numero) {
            var parteEntera = parseInt(numero);
            var parteDecimal = numero - parteEntera;
            var cadDecimal = "";
            if (parteDecimal > 0) {
                var potencia = Math.pow(10, 2);
                var decimales = parteDecimal * potencia;
                var decimalesParteEntera = parseInt(decimales);
                var decimalesParteDecimal = decimales - decimalesParteEntera;
                if (decimalesParteDecimal >= 0.5) decimalesParteEntera++;
                cadDecimal = decimalesParteEntera.toString();
                if (cadDecimal.length > 2) {
                    cadDecimal = "";
                    for (var i = 0; i < 2; i++) {
                        cadDecimal += "0";
                    }
                    parteEntera++;
                } else if (cadDecimal.length < 2) {
                    for (var i = cadDecimal.length; i < 2; i++) {
                        cadDecimal = "0" + cadDecimal;
                    }
                }
            } else if (parteDecimal == 0) {
                for (var i = 0; i < 2; i++) {
                    cadDecimal += "0";
                }
            }

            var cad1 = parteEntera.toString();
            var cad2 = "";
            for (var i = (cad1.length - 1); i > -1; i = i - 3) {
                var cad3 = cad1.substring(i - 2, i + 1);
                if (cad2 != "") {
                    cad2 = cad3 + "," + cad2;
                } else {
                    cad2 = cad3;
                }

            }
            //Devolvemos la cadena de número formateada 
            return cad2 + "." + cadDecimal;

        }
     </script>
    </telerik:RadCodeBlock>
                                                </asp:Content>
