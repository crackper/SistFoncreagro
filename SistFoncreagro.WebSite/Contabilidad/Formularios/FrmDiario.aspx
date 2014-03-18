<%@ Page Title="Registro de Comprobantes Diario" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterContabilidad1.master" CodeBehind="FrmDiario.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmDiario" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
      <Windows>
                <telerik:RadWindow ID="Proveedores" runat="server" Behavior="Minimize, Close" 
                    Behaviors="Default" Height="750px"
                    InitialBehavior="None" Left="" Modal="True" NavigateUrl="" 
                     Style="display: none;" Top="" VisibleStatusbar="True"
                    Width="500px" Title="Registro de Proveedores" AutoSize="True">
                </telerik:RadWindow>
            </Windows>
                            </telerik:RadWindowManager>

                                               
                                                <table align="center" 
        class="tabla3">
                                                    <tr>
                                                        <td>
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
                                                                        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/img/Proceso.gif" 
                                                                            ToolTip="Procesar" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton10" runat="server" 
                                                                            ImageUrl="~/img/Deshacer.gif" ToolTip="Deshacer" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/img/Buscar.gif" 
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
                                                                                        <td width="28%" __designer:mapid="fee">
                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                                                                                DataSourceID="odsOpFinanciera" DataTextField="Descripcion" 
                                                                                                DataValueField="IdOpFinanciera" Width="90%" AutoPostBack="True" 
                                                                                                TabIndex="1">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ff0">
                                                                                            SubDiario:</td>
                                                                                        <td __designer:mapid="ff1" style="width: 40%">
                                                                                            <telerik:RadComboBox ID="RadComboBox10" Runat="server" AllowCustomText="True" DataTextField="Codigo" 
                                                                                                DataValueField="IdSubDiario" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="97%" TabIndex="2">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                                                                                ControlToValidate="RadComboBox10" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el SubDiario!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ff3">
                                                                                            Codigo:</td>
                                                                                        <td width="8%" __designer:mapid="ff4">
                                                                                            <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Width="70px" 
                                                                                                TabIndex="3"></asp:TextBox>
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
                                                                                                ValidationGroup="Transaccion" Width="97%" TabIndex="4" >
                                                                                            </telerik:RadComboBox>
                                                                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox3" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Proyecto!"></asp:RequiredFieldValidator>
                                                                                      
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ffd">
                                                                                            Fecha Cont.:</td>
                                                                                        <td width="8%" __designer:mapid="ffe">
                                                                                            <asp:TextBox ID="txtDate" runat="server" Width="70px" TabIndex="5" />
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
                                                                                    <tr class="Texto" __designer:mapid="ff9">
                                                                                        <td __designer:mapid="ffa" colspan="4" style="font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="ff9">
                                                                                        <td width="8%" __designer:mapid="ffa">
                                                                                            Coa:</td>
                                                                                        <td width="76%" __designer:mapid="ffb">
                                                                                            
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" AllowCustomText="True" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="97%" 
                                                                                                TabIndex="6">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ffd">
                                                                                            &nbsp;</td>
                                                                                        <td width="8%" __designer:mapid="ffe">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="ff9">
                                                                                        <td width="8%" __designer:mapid="ffa">
                                                                                            Glosa:</td>
                                                                                        <td width="76%" __designer:mapid="ffb">
                                                                                            
                                                                                            <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Width="96%" 
                                                                                                CssClass="TextBoxAlignIzquierda" TabIndex="7"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                                                ErrorMessage="¡Debe ingresar la Glosa!" Display="Dynamic" 
                                                                                                ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ffd">
                                                                                            Tipo Cambio:</td>
                                                                                        <td width="8%" __designer:mapid="ffe">
                                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" Value="0" 
                                                                                                Width="70px" TabIndex="8">
                                                                                                <NumberFormat DecimalDigits="4" />
                                                                                            </telerik:RadNumericTextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="ff9">
                                                                                        <td __designer:mapid="ffa" colspan="4" style="font-size: 6pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="ff9">
                                                                                        <td __designer:mapid="ffa" colspan="4" style="font-weight: 700">
                                                                                            Buscar Cuentas Pendientes</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="ff9">
                                                                                        <td width="8%" __designer:mapid="ffa" colspan="2" style="width: 84%">
                                                                                            <telerik:RadComboBox ID="RadComboBox11" Runat="server" AllowCustomText="True" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="90%" EnableAjaxSkinRendering="False" 
                                                                                                            EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                            EnableEmbeddedSkins="False" TabIndex="9">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:Button ID="Button1" runat="server" CssClass="Texto" Text="Buscar" />
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ffd">
                                                                                            &nbsp;</td>
                                                                                        <td width="8%" __designer:mapid="ffe">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="ff9">
                                                                                        <td __designer:mapid="ffa" colspan="4" style="font-size: 3pt">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    </table>
                                                                            </td>
                                                                        </tr>
                                                                        </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: left">
                                                                            <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False" 
                                                                                CellSpacing="0" GridLines="None" Skin="Hay" 
                                                                                DataSourceID="SqlCuentasPendientes" EnableEmbeddedBaseStylesheet="False" 
                                                                                EnableEmbeddedScripts="False" Visible="False">
                                                                                <ClientSettings>
                                                                                    <Selecting AllowRowSelect="True" />
                                                                                </ClientSettings>
<MasterTableView CommandItemDisplay="Top" NoMasterRecordsText="No existen registros." DataSourceID="SqlCuentasPendientes">
<CommandItemSettings ExportToPdfText="Export to PDF" ShowAddNewRecordButton="False" 
        ShowRefreshButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn" AllowFiltering="False">
            <HeaderTemplate>
                <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" 
                    oncheckedchanged="CheckBox3_CheckedChanged" />
            </HeaderTemplate>
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox2" runat="server" 
                    />
            </ItemTemplate>
            <HeaderStyle Width="2%" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="Cuenta" 
            FilterControlAltText="Filter Cuenta column" HeaderText="Cuenta" ReadOnly="True" 
            SortExpression="Cuenta" UniqueName="Cuenta" AllowFiltering="False">
            <HeaderStyle HorizontalAlign="Center" Width="8%" />
            <ItemStyle HorizontalAlign="Center" Font-Names="Arial" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Ruc" 
            FilterControlAltText="Filter Coa column" HeaderText="Coa" ReadOnly="True" 
            SortExpression="Coa" UniqueName="Coa" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle HorizontalAlign="Center" Font-Names="Arial" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Registro" 
            FilterControlAltText="Filter Registro column" HeaderText="Registro" 
            SortExpression="Registro" UniqueName="Registro" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="13%" />
            <ItemStyle HorizontalAlign="Center" Font-Names="Arial" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AllowFiltering="False" DataField="IdMoneda" 
            FilterControlAltText="Filter IdMoneda column" HeaderText="M." 
            UniqueName="IdMoneda">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn AllowFiltering="False" DataField="Monto" 
            FilterControlAltText="Filter TemplateColumn1 column" HeaderText="Monto" 
            UniqueName="TemplateColumn1">
            <ItemTemplate>
                <telerik:RadNumericTextBox ID="MontoIngresado" Runat="server" Culture="es-PE" 
                    DbValue='<%# Bind("Monto") %>' Width="50px">
                    <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                </telerik:RadNumericTextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Right" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="CargoMN" DataType="System.Decimal" 
            FilterControlAltText="Filter Debe column" HeaderText="CargoMN" 
            SortExpression="CargoMN" UniqueName="CargoMN" 
            DataFormatString="{0:0,0.00}" AllowFiltering="False" Visible="False">
            <HeaderStyle HorizontalAlign="Center" Width="8%" />
            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="AbonoMN" DataType="System.Decimal" 
            FilterControlAltText="Filter Haber column" HeaderText="AbonoMN" 
            SortExpression="AbonoMN" UniqueName="AbonoMN" 
            DataFormatString="{0:0,0.00}" AllowFiltering="False" Visible="False">
            <HeaderStyle HorizontalAlign="Center" Width="8%" />
            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaDocumento" 
            DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime" 
            FilterControlAltText="Filter FechaDocumento column" HeaderText="Fecha Doc." 
            SortExpression="FechaDocumento" UniqueName="FechaDocumento" 
            AllowFiltering="False">
            <HeaderStyle HorizontalAlign="Center" Width="8%" />
            <ItemStyle HorizontalAlign="Center" Font-Names="Arial" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter Glosa1 column" 
            HeaderText="Glosa" UniqueName="Glosa1" AllowFiltering="False">
            <ItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" 
                    style="font-family: Arial; font-size: 8pt" Width="100%" 
                    CssClass="TextBoxAlignIzquierda"></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" Width="38%" />
            <ItemStyle Font-Names="Arial" HorizontalAlign="Left" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="IdTransaccion" DataType="System.Int32" 
            FilterControlAltText="Filter IdTransaccion column" HeaderText="IdTransaccion" 
            SortExpression="IdTransaccion" UniqueName="IdTransaccion" Visible="False" 
            AllowFiltering="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdLinea" DataType="System.Int32" 
            FilterControlAltText="Filter IdLinea column" HeaderText="IdLinea" 
            SortExpression="IdLinea" UniqueName="IdLinea" Visible="False" 
            AllowFiltering="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SerieDocumento" 
            FilterControlAltText="Filter SerieDocumento column" UniqueName="SerieDocumento" 
            Visible="False" AllowFiltering="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroDocumento" 
            FilterControlAltText="Filter NroDocumento column" UniqueName="NroDocumento" 
            Visible="False" AllowFiltering="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdPlan" 
            FilterControlAltText="Filter IdPlan column" UniqueName="IdPlan" 
            Visible="False" AllowFiltering="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdProveedorCliente" 
            FilterControlAltText="Filter IdProveedorCliente column" 
            UniqueName="IdProveedorCliente" Visible="False" AllowFiltering="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdTipoDocumento" 
            FilterControlAltText="Filter IdTipoDocumento column" 
            UniqueName="IdTipoDocumento" Visible="False" AllowFiltering="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoCambio" 
            FilterControlAltText="Filter TipoCambio column" UniqueName="TipoCambio" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Monto" 
            FilterControlAltText="Filter Monto column" 
            HeaderText="Monto" UniqueName="Monto" Visible="False">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
    <CommandItemTemplate>
        <table width="100%">
            <tr>
                <td>
                    Cuentas Pendientes</td>
                <td width="10%" style="text-align: right">
                    <asp:ImageButton ID="Cerrar" runat="server" ImageUrl="~/img/Cancel.gif" 
                        onclick="Cerrar_Click" />
                    </td>
            </tr>
        </table>
    </CommandItemTemplate>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                                                                            </telerik:RadGrid>
                                                               
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: center; font-family: Arial; font-size: 3pt;">
                                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: center">
                                                                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                                                                CellSpacing="0" DataSourceID="SqlLineas" GridLines="None" 
                                                                Width="100%" Skin="Hay" style="text-align: left" ShowFooter="True" 
                                                                                EnableEmbeddedBaseStylesheet="False" AllowSorting="True">
                                                                                <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                                                                    SortedDescToolTip="Ordenado descendente" SortToolTip="Click para ordenar" />
                                                                                <ClientSettings>
                                                                                    <Selecting AllowRowSelect="True" />
                                                                                </ClientSettings>
                                                                                <MasterTableView ClientDataKeyNames="IdLinea" DataKeyNames="IdLinea" 
                                                                                    DataSourceID="SqlLineas" NoMasterRecordsText="No existen registros." 
                                                                                    CommandItemDisplay="Top">
                                                                                    <CommandItemSettings AddNewRecordText="Agregar Línea" 
                                                                                        ExportToPdfText="Export to PDF" RefreshText="Refrescar" />
<CommandItemSettings AddNewRecordText="Agregar L&#237;nea" RefreshText="Refrescar" ExportToPdfText="Export to PDF"></CommandItemSettings>

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
                                                                                            UniqueName="column" SortExpression="Cuenta">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="CentroCosto" 
                                                                                            FilterControlAltText="Filter column1 column" HeaderText="C.Costo" 
                                                                                            UniqueName="column1" SortExpression="CentroCosto">
                                                                                            <HeaderStyle Width="8%" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Coa" 
                                                                                            FilterControlAltText="Filter column1 column" HeaderText="Coa" 
                                                                                            UniqueName="Coa" SortExpression="Coa">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Registro" 
                                                                                            FilterControlAltText="Filter column3 column" HeaderText="Registro" 
                                                                                            UniqueName="Registro" FooterText="TOTAL:" SortExpression="Registro">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="FechaDocumento" 
                                                                                            DataFormatString="{0:dd/MM/yyyy}" 
                                                                                            FilterControlAltText="Filter FechaDocumento column" HeaderText="Fecha Doc." 
                                                                                            UniqueName="FechaDocumento" SortExpression="FechaDocumento">
                                                                                            <HeaderStyle Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdMoneda" 
                                                                                            FilterControlAltText="Filter IdMoneda column" HeaderText="M." 
                                                                                            UniqueName="IdMoneda" SortExpression="IdMoneda">
                                                                                            <HeaderStyle Width="1%" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="TipoCambio" 
                                                                                            FilterControlAltText="Filter TipoCambio1 column" HeaderText="T.C." 
                                                                                            UniqueName="TipoCambio" AllowSorting="False">
                                                                                            <HeaderStyle Width="5%" />
                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="CargoMN" DataFormatString="{0:N2}" 
                                                                                            FilterControlAltText="Filter CargoMN column" HeaderText="Debe MN" 
                                                                                            UniqueName="CargoMN" Aggregate="Sum" DataType="System.Decimal" 
                                                                                            FooterAggregateFormatString="{0:N2}" AllowSorting="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="AbonoMN" 
                                                                                            FilterControlAltText="Filter AbonoMN column" HeaderText="Haber MN" 
                                                                                            UniqueName="AbonoMN" Aggregate="Sum" DataFormatString="{0:N2}" 
                                                                                            FooterAggregateFormatString="{0:N2}" DataType="System.Decimal" 
                                                                                            AllowSorting="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="CargoME" 
                                                                                            FilterControlAltText="Filter CargoME column" HeaderText="Debe ME" 
                                                                                            UniqueName="CargoME" Aggregate="Sum" DataFormatString="{0:N2}" 
                                                                                            FooterAggregateFormatString="{0:N2}" DataType="System.Decimal" 
                                                                                            AllowSorting="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="AbonoME" 
                                                                                            FilterControlAltText="Filter AbonoME column" HeaderText="Haber ME" 
                                                                                            UniqueName="AbonoME" Aggregate="Sum" DataFormatString="{0:N2}" 
                                                                                            FooterAggregateFormatString="{0:N2}" DataType="System.Decimal" 
                                                                                            AllowSorting="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Glosa" 
                                                                                            FilterControlAltText="Filter Glosa column" HeaderText="Glosa" 
                                                                                            UniqueName="Glosa" AllowSorting="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="18%" />
                                                                                            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="MontoCargo" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter Cargo column" HeaderText="Debe" 
                                                                                            UniqueName="Cargo" DataFormatString="{0:N2}" 
                                                                                            FooterAggregateFormatString="{0:N2}" Visible="False" AllowSorting="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="MontoAbono" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter Abono column" HeaderText="Haber" 
                                                                                            UniqueName="Abono" DataFormatString="{0:N2}" 
                                                                                            FooterAggregateFormatString="{0:N2}" Visible="False" AllowSorting="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdLinea" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter IdLinea column" HeaderText="IdLinea" 
                                                                                            ReadOnly="True" SortExpression="IdLinea" UniqueName="IdLinea" 
                                                                                            Visible="False" AllowSorting="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdTransaccion" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter Transaccion column" HeaderText="Transaccion" 
                                                                                            UniqueName="Transaccion" Visible="False" AllowSorting="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdPlan" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter Cta column" HeaderText="Cuenta" 
                                                                                            UniqueName="IdPlan" Visible="False" AllowSorting="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdCCosto" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter ElemGto column" HeaderText="C. Costo" 
                                                                                            UniqueName="ElemGto" Visible="False" AllowSorting="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdProveedorCliente" 
                                                                                            FilterControlAltText="Filter IdProveedorCliente column" 
                                                                                            UniqueName="IdProveedorCliente" Visible="False" AllowSorting="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdTipoDocumento" 
                                                                                            FilterControlAltText="Filter IdTipoDocumento column" 
                                                                                            UniqueName="IdTipoDocumento" Visible="False" DataType="System.Int32" 
                                                                                            EmptyDataText="" AllowSorting="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="SerieDocumento" 
                                                                                            FilterControlAltText="Filter SerieDocumento column" UniqueName="SerieDocumento" 
                                                                                            Visible="False" AllowSorting="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="NroDocumento" 
                                                                                            FilterControlAltText="Filter NroDocumento column" UniqueName="NroDocumento" 
                                                                                            Visible="False" EmptyDataText="" AllowSorting="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Enlace" 
                                                                                            FilterControlAltText="Filter Enlace column" UniqueName="Enlace" 
                                                                                            Visible="False" AllowSorting="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Flag" 
                                                                                            FilterControlAltText="Filter Flag column" HeaderText="Flag" UniqueName="Flag" 
                                                                                            Visible="False" AllowSorting="False">
                                                                                        </telerik:GridBoundColumn>
                                                                                    </Columns>
                                                                                    <EditFormSettings EditFormType="WebUserControl" 
                                                                                        UserControlName="~\Contabilidad\Controles\ControlDiario1.ascx">
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

                                                <asp:ObjectDataSource SortParameterName="SortExpression"  ID="odsLinea" runat="server" 
                                                    SelectMethod="GetLINEAByIdTransaccion" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.LineaBL">
                                                    <SelectParameters>
                                                        <asp:SessionParameter Name="IdTransaccion" SessionField="IdTransaccion" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsMoneda" runat="server" 
        SelectMethod="GetAllFromMoneda" 
        TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsCtasPorPagar" runat="server" 
        SelectMethod="GetLINEADiario" TypeName="SistFoncreagro.BussinesLogic.LineaBL">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="RadComboBox8" Name="Coa" 
                                                            PropertyName="SelectedValue" Type="Int32" />
                                                        <asp:ControlParameter ControlID="DropDownList1" Name="OpFinan" 
                                                            PropertyName="SelectedValue" Type="Int32" />
                                                    </SelectParameters>
    </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                            
             

                                            
                                                <asp:ObjectDataSource ID="odsProveedor1" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL" 
        OldValuesParameterFormatString="original_{0}">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                            
             

                                            
                                                <asp:SqlDataSource ID="SqlLineas" 
        runat="server" ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetLINEAByIdTransaccion1" SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:SessionParameter Name="idTransaccion" SessionField="IdTransaccion" 
                                                            Type="Int32" />
                                                    </SelectParameters>
    </asp:SqlDataSource>
                                                <asp:SqlDataSource ID="SqlCuentasPendientes" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetCuentasPendientesxProveedorProyecto" 
        SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="RadComboBox11" Name="idProveedor" 
                                                            PropertyName="SelectedValue" Type="Int32" DefaultValue="0" />
                                                        <asp:ControlParameter ControlID="RadComboBox3" DefaultValue="" 
                                                            Name="idProyecto" PropertyName="SelectedValue" Type="Int32" />
                                                        <asp:SessionParameter Name="anio" SessionField="Anio" Type="Int32" />
                                                    </SelectParameters>
    </asp:SqlDataSource>
                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsOpFinanciera" runat="server" 
                                                    SelectMethod="GetAllFromOperacionFinanciera" 
                                                    TypeName="SistFoncreagro.BussinesLogic.OperacionFinancieraBL">
                                                </asp:ObjectDataSource>
                                                               
                                                <asp:ObjectDataSource ID="odsSubDiario" runat="server" 
                                                    SelectMethod="GetSUBDIARIOByIdOpFinanciera" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.SubdiarioBL">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="DropDownList1" DefaultValue="4" 
                                                            Name="IdOpFinanciera" PropertyName="SelectedValue" Type="Int32" />
                                                    </SelectParameters>
    </asp:ObjectDataSource>
                                                               
                                                <asp:ObjectDataSource ID="odsSubDiario1" runat="server" 
                                                    SelectMethod="GetAllSUBDIARIO" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.SubdiarioBL">
    </asp:ObjectDataSource>

             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton9" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton13" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox10" />
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox3" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton9">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton10" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton13" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton10">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton9" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton13" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton13">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="DropDownList1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox10" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="txtDate">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="Button1">
                                                            <updatedcontrols>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </updatedcontrols>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid2">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton9" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton10" />
                                                                <telerik:AjaxUpdatedControl ControlID="ImageButton13" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox10" />
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox3" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
    </telerik:RadAjaxManager>
  
  <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
      
        function Abrir() {
            var oWnd = radopen("/SistIntegral/Logistica/FrmProveedores.aspx", "Proveedores");
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
            return  cad2 + "." + cadDecimal;

        }

     </script>
    </telerik:RadCodeBlock>
    
                                  
                                                </asp:Content>