<%@ Page Title="Registro y Facturación de Ventas" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterContabilidad1.master" CodeBehind="FrmFacturar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmFacturar" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
  <Windows>
                <telerik:RadWindow ID="Proveedores" runat="server" Behavior="Close" 
                   Height="600px"
                    InitialBehavior="None" Left="" Modal="True" NavigateUrl="" OnClientClose="Cerrar"
                     Style="display: none;" Top="" VisibleStatusbar="True"
                    Width="800px" Title="Registro de Proveedores" >
                </telerik:RadWindow>
            </Windows>
                            </telerik:RadWindowManager>

                                                <table align="center" 
        class="tabla3">
                                                   
                                                    <tr>
                                                        <td style="text-align: left" valign="bottom"> 
                                                            <table style="width: 150px">
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
                                                                ImageUrl="~/img/Proceso.gif" ToolTip="Facturar" BorderColor="Gray" 
                                                                BorderStyle="Solid" BorderWidth="0px" Width="25px" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/img/Aceptar.gif" 
                                                                            ToolTip="Enviar" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/img/Buscar.gif" 
                                                                            ToolTip="Ver Comprobante de Venta" />
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
                                                                                <table class="style6">
                                                                                    <tr>
                                                                                        <td width="13%">
                                                                                            Tipo Documento:</td>
                                                                                        <td width="15%">
                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                                                                                DataSourceID="SqlTipoDocumento" DataTextField="Documento" 
                                                                                                DataValueField="IdTipoDocumento" Font-Names="arial" Font-Size="8pt" 
                                                                                                Width="140px" AutoPostBack="True" TabIndex="1">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td width="14%" style="text-align: right">
                                                                                            Tipo Venta:</td>
                                                                                        <td width="17%">
                                                                                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlTipoVenta" 
                                                                                                DataTextField="Tipo" DataValueField="IdTipoVenta" Font-Names="Arial" 
                                                                                                Font-Size="8pt" Width="140px" TabIndex="2">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td width="9%" style="text-align: right">
                                                                                            Fecha:</td>
                                                                                        <td width="8%">
                                                                                            <asp:TextBox ID="txtDate" runat="server" Width="70px" TabIndex="3" />
                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                            AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                            TargetControlID="txtDate" />
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                                                                ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator>
                                                                                           
                                                                        <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                            ControlExtender="MaskedEditExtender1" ControlToValidate="txtDate" 
                                                                            Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                            InvalidValueMessage="¡Fecha Incorrecta!" />                                                                                            
                                                                                                </td>
                                                                                        <td width="6%" style="text-align: right">
                                                                                            Serie:</td>
                                                                                        <td width="5%">
                                                                                            <asp:TextBox ID="TextBox1" runat="server" Width="50px" Enabled="False" 
                                                                                                TabIndex="4"></asp:TextBox>
                                                                                        </td>
                                                                                        <td width="6%" style="text-align: right">
                                                                                            N°:</td>
                                                                                        <td width="7%">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" Width="50px" Enabled="False" 
                                                                                                TabIndex="5"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td>
                                                                                            Modalidad:</td>
                                                                                        <td>
                                                                                            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" 
                                                                                                Font-Names="Arial" Font-Size="8pt" style="height: 20px" TabIndex="6">
                                                                                                <asp:ListItem Value="I" Selected="True">Venta Interna</asp:ListItem>
                                                                                                <asp:ListItem Value="E">Venta Terceros</asp:ListItem>
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td style="text-align: right">
                                                                                            N° Nota Interna:</td>
                                                                                        <td>
                                                                                            <asp:TextBox ID="TextBox3" runat="server" Width="140px" TabIndex="7"></asp:TextBox>
                                                                                        </td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td>
                                                                                            Tipo Pago:</td>
                                                                                        <td>
                                                                                            <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" 
                                                                                                Font-Names="Arial" Font-Size="8pt" TabIndex="8">
                                                                                                <asp:ListItem Value="C" Selected="True">Contado</asp:ListItem>
                                                                                                <asp:ListItem Value="R">Credito</asp:ListItem>
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td style="text-align: right">
                                                                                            Banco:</td>
                                                                                        <td>
                                                                                            <asp:DropDownList ID="DropDownList3" runat="server" AppendDataBoundItems="True" 
                                                                                                Font-Names="Arial" Font-Size="8pt" Width="140px" DataSourceID="odsBanco" 
                                                                                                DataTextField="Nombre" DataValueField="IdBanco" TabIndex="9">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td style="text-align: right">
                                                                                            N° Voucher:</td>
                                                                                        <td colspan="4">
                                                                                            <asp:TextBox ID="TextBox4" runat="server" Width="98%" TabIndex="10"></asp:TextBox>
                                                                                                </td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td>
                                                                                            Proyecto:</td>
                                                                                        <td colspan="8">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="False" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="100%" TabIndex="11">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox3" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Proyecto!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td style="height: 43px">
                                                                                            Cliente:</td>
                                                                                        <td colspan="8" style="height: 43px">
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" AllowCustomText="True" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="100%" 
                                                                                                EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" 
                                                                                                EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" TabIndex="12">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                                                ControlToValidate="RadComboBox8" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Cliente!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td style="height: 43px">
                                                                                            <asp:ImageButton ID="ImageButton7" runat="server" ImageAlign="Middle" 
                                                                                                ImageUrl="~/img/Agregar.gif" ToolTip="Registrar Proveedor" 
                                                                                                CausesValidation="False" />
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td>
                                                                                            Observacion:</td>
                                                                                        <td colspan="8">
                                                                                            <asp:TextBox ID="TextBox6" runat="server" TabIndex="13" TextMode="MultiLine" 
                                                                                                Width="98%"></asp:TextBox>
                                                                                        </td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td>
                                                                                            Doc.
                                                                                            Referencia:</td>
                                                                                        <td colspan="4">
                                                                                            <asp:TextBox ID="TextBox5" runat="server" Rows="1" Width="98%" TabIndex="14"></asp:TextBox>
                                                                                        </td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                        <td colspan="4">
                                                                                            <asp:CheckBox ID="CheckBox1" runat="server" 
                                                                                                Text="Transferencia a Título Gratuíto" TabIndex="15" />
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td>
                                                                                            Afecto IGV:</td>
                                                                                        <td colspan="4">
                                                                                            <asp:CheckBox ID="CheckBox2" runat="server" Checked="True" TabIndex="16" />
                                                                                        </td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                        <td colspan="4">
                                                                                            <asp:CheckBox ID="CheckBox3" runat="server" Text="Precios incluyen IGV" 
                                                                                                TabIndex="17" />
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td>
                                                                                            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Observación:" 
                                                                                                Visible="False"></asp:Label>
                                                                                        </td>
                                                                                        <td colspan="4">
                                                                                            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Label" 
                                                                                                Visible="False"></asp:Label>
                                                                                        </td>
                                                                                        <td>
                                                                                            &nbsp;</td>
                                                                                        <td colspan="4">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr __designer:mapid="ef8">
                                                                            <td __designer:mapid="ef9" class="Texto" style="font-weight: 700">
                                                                                Detalle de la venta</td>
                                                                        </tr>
                                                                        <tr __designer:mapid="f13">
                                                                            <td __designer:mapid="f14">
                                                                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                                                                CellSpacing="0" DataSourceID="SqlDetalle" GridLines="None" 
                                                                Width="100%" Skin="Hay" style="text-align: left" ShowFooter="True" 
                                                                                EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" 
                                                                                EnableEmbeddedScripts="False">
                                                                                <MasterTableView ClientDataKeyNames="IdDetalleVenta" DataKeyNames="IdDetalleVenta" 
                                                                                    DataSourceID="SqlDetalle" NoMasterRecordsText="No existen registros." 
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
                                                                                            <HeaderStyle Width="2%" />
                                                                                            <ItemStyle Width="2%" />
                                                                                        </telerik:GridEditCommandColumn>
                                                                                        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                            ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro que desea Eliminar el Registro?" 
                                                                                            ConfirmTitle="Mensaje de Confirmación" FilterControlAltText="Filter column2 column" 
                                                                                            ImageUrl="~\img\delete.gif" Text="Eliminar" UniqueName="eliminar">
                                                                                            <HeaderStyle Width="2%" />
                                                                                            <ItemStyle Width="2%" />
                                                                                        </telerik:GridButtonColumn>
                                                                                        <telerik:GridBoundColumn DataField="Cantidad" 
                                                                                            FilterControlAltText="Filter Cantidad column" HeaderText="Cantidad" 
                                                                                            UniqueName="Cantidad">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Descripcion" 
                                                                                            FilterControlAltText="Filter Descripcion column" HeaderText="Descripción" 
                                                                                            UniqueName="Descripcion">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="56%" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="UnidadMedida" 
                                                                                            FilterControlAltText="Filter UnidadMedida column" HeaderText="U. Medida" 
                                                                                            UniqueName="UnidadMedida">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="PrecioUnitario" 
                                                                                            FilterControlAltText="Filter PrecioUnitario column" FooterText="TOTAL:" 
                                                                                            HeaderText="P. Unitario" UniqueName="PrecioUnitario" 
                                                                                            DataFormatString="{0:N4}">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn Aggregate="Sum" DataField="Total" 
                                                                                            DataFormatString="{0:N2}" DataType="System.Decimal" 
                                                                                            FilterControlAltText="Filter column column" 
                                                                                            FooterAggregateFormatString="{0:N2}" HeaderText="Sub Total" UniqueName="column">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridCalculatedColumn Aggregate="Sum" 
                                                                                            DataFields="PrecioUnitario,Cantidad" DataFormatString="{0:N2}" 
                                                                                            DataType="System.Decimal" Expression="{0}*{1}" 
                                                                                            FilterControlAltText="Filter SubTotal column" 
                                                                                            FooterAggregateFormatString="{0:N2}" HeaderText="Sub Total" 
                                                                                            UniqueName="SubTotal" Visible="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </telerik:GridCalculatedColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdDetalleVenta" 
                                                                                            FilterControlAltText="Filter column column" HeaderText="IdDetalleVenta" 
                                                                                            UniqueName="IdDetalleVenta" Visible="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Left" Width="35%" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdVenta" 
                                                                                            FilterControlAltText="Filter column3 column" HeaderText="IdVenta" 
                                                                                            UniqueName="IdVenta" Visible="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Center" Width="10%" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                    </Columns>
                                                                                    <EditFormSettings EditFormType="WebUserControl" 
                                                                                        UserControlName="~\Contabilidad\Controles\ControlVentas.ascx">
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
                                                                        <tr __designer:mapid="f7a">
                                                                            <td class="Texto" style="font-weight: 700" __designer:mapid="f7b">
                                                                                Bonificación (venta de leche)</td>
                                                                        </tr>
                                                                        <tr __designer:mapid="f7e">
                                                                            <td __designer:mapid="f7f" class="style4">
                                                                            <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False" 
                                                                                CellSpacing="0" DataSourceID="SqlBonificacion" GridLines="None" 
                                                                Width="100%" Skin="Hay" style="text-align: left" ShowFooter="True" 
                                                                                EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" 
                                                                                EnableEmbeddedScripts="False">
                                                                                <MasterTableView ClientDataKeyNames="IdBonificacion" DataKeyNames="IdBonificacion" 
                                                                                    DataSourceID="SqlBonificacion" NoMasterRecordsText="No existen registros." 
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
                                                                                            <HeaderStyle Width="2%" />
                                                                                            <ItemStyle Width="2%" />
                                                                                        </telerik:GridEditCommandColumn>
                                                                                        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                            ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro que desea Eliminar el Registro?" 
                                                                                            ConfirmTitle="Mensaje de Confirmación" FilterControlAltText="Filter column2 column" 
                                                                                            ImageUrl="~\img\delete.gif" Text="Eliminar" UniqueName="eliminar">
                                                                                            <HeaderStyle Width="2%" />
                                                                                            <ItemStyle Width="2%" />
                                                                                        </telerik:GridButtonColumn>
                                                                                        <telerik:GridBoundColumn DataField="Cantidad" 
                                                                                            FilterControlAltText="Filter Cantidad column" HeaderText="Cantidad" 
                                                                                            UniqueName="Cantidad">
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Descripcion" 
                                                                                            FilterControlAltText="Filter Descripcion column" HeaderText="Descripción" 
                                                                                            UniqueName="Descripcion" FooterText="TOTAL:">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="56%" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="Importe" 
                                                                                            FilterControlAltText="Filter PrecioUnitario column" HeaderText="Importe" 
                                                                                            UniqueName="Importe" Aggregate="Sum" DataFormatString="{0:N2}" 
                                                                                            FooterAggregateFormatString="{0:N2}">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdBonificacion" 
                                                                                            FilterControlAltText="Filter column column" HeaderText="IdBonificacion" 
                                                                                            UniqueName="IdBonificacion" Visible="False">
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Left" Width="35%" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                        <telerik:GridBoundColumn DataField="IdVenta" 
                                                                                            FilterControlAltText="Filter column3 column" HeaderText="IdVenta" 
                                                                                            UniqueName="IdVenta" Visible="False">
                                                                                            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                            <ItemStyle HorizontalAlign="Center" Width="10%" Font-Names="Arial" 
                                                                                                Font-Size="8pt" />
                                                                                        </telerik:GridBoundColumn>
                                                                                    </Columns>
                                                                                    <EditFormSettings EditFormType="WebUserControl" 
                                                                                        UserControlName="~\Contabilidad\Controles\ControlBonificacion.ascx">
                                                                                        <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                                                                        </EditColumn>
                                                                                    </EditFormSettings>
                                                                                    <CommandItemTemplate>
                                                                                        <asp:ImageButton ID="ImageButton10" runat="server" 
                                                                                            ImageUrl="~/img/AgregarLinea.gif" onclick="ImageButton10_Click" />
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
                                                        </td>
                                                    </tr>
                                                    </table>


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

       
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Mensaje");
        }
        function confirmCallBackFn(arg) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Enviar|" + arg);
        }

        function getRadWindow() {
            if (window.radWindow) {
                return window.radWindow;
            }
            if (window.frameElement && window.frameElement.radWindow) {
                return window.frameElement.radWindow;
            }
            return null;
        }

        // Fires when the changes are saved
        function onClientClose(arg) {
            // Pass the arguments from the dialog to the callback function on the main page.    
            getRadWindow().close(arg);
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
                                                        <telerik:AjaxSetting AjaxControlID="DropDownList1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="CheckBox2" />
                                                                <telerik:AjaxUpdatedControl ControlID="CheckBox3" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="DropDownList4">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox3" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="DropDownList5">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList3" />
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox4" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid2">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>


                                                                                <telerik:RadNumericTextBox ID="RadNumericTextBox8" Runat="server" 
                                                                                    BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="White" 
                                                                                    Value="0" Width="80px" ReadOnly="True">
                                                                                </telerik:RadNumericTextBox>
  

                                                                                <asp:ObjectDataSource ID="odsBanco" runat="server" 
                                                                                    SelectMethod="GetAllFromBANCO" TypeName="SistFoncreagro.BussinesLogic.BancoBL">
                                                                                </asp:ObjectDataSource>
                                                <asp:SqlDataSource ID="SqlDetalle" 
        runat="server" ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetDETALLEVENTAByIdVentaDetallado" 
        SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdVenta" QueryStringField="IdVenta" 
                                                            Type="Int32" />
                                                    </SelectParameters>
    </asp:SqlDataSource>
                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
  

                                                                                <asp:SqlDataSource ID="SqlTipoDocumento" runat="server" 
                                                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                                                    SelectCommand="GetTIPODOCUMENTOVentas" SelectCommandType="StoredProcedure">
                                                                                </asp:SqlDataSource>
                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                               
                                                                                <asp:SqlDataSource ID="SqlBonificacion" runat="server" 
                                                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                                                    SelectCommand="GetBONIFICACIONVENTAByIdVentaDetallado" 
                                                                                    SelectCommandType="StoredProcedure">
                                                                                    <SelectParameters>
                                                                                        <asp:QueryStringParameter Name="IdVenta" QueryStringField="IdVenta" 
                                                                                            Type="Int32" />
                                                                                    </SelectParameters>
                                                                                </asp:SqlDataSource>
                                                                                <asp:SqlDataSource ID="SqlTipoVenta" runat="server" 
                                                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                                                    SelectCommand="GetAllFromTIPOVENTA" SelectCommandType="StoredProcedure">
                                                                                </asp:SqlDataSource>
                                                                            

                                                </asp:Content>