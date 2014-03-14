<%@ Page Title="Validar Bienes Muebles" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterContabilidad.Master" CodeBehind="FrmValidarMueble.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmValidarMueble" %>
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
                <telerik:RadWindow ID="Marcas" runat="server" Behavior="Close" 
                   Height="600px"
                    InitialBehavior="None" Left="" Modal="True" NavigateUrl="" OnClientClose="Cerrar1"
                     Style="display: none;" Top="" VisibleStatusbar="True"
                    Width="600px" Title="Registro de Marcas">
                </telerik:RadWindow>
            </Windows>
                            <Localization Close="Cerrar" Maximize="Maximizar" 
            Minimize="Minimizar" />
                            </telerik:RadWindowManager>

                                                <table 
        style="width: 100%">
                                                    <tr>
                                                        <td style="height: 30px">
                                                                                    
                                                                                <telerik:RadTabStrip ID="RadTabStrip1" runat="server" 
                                                                                    MultiPageID="RadMultiPage1" SelectedIndex="0" Width="100%">
                                                                                    <Tabs>
                                                                                        <telerik:RadTab runat="server" Selected="True" Text="Información General">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Personal Responsable">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Informacion Histórica">
                                                                                        </telerik:RadTab>
                                                                                    </Tabs>
                                                                                </telerik:RadTabStrip>
                                                                                    
                                                                                </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="height: 30px">
                                                                                    
                                                                                <telerik:RadMultiPage ID="RadMultiPage1" Runat="server" SelectedIndex="0">
                                                                                    <telerik:RadPageView ID="RadPageView1" runat="server"><table align="center" class="tabla3"><tr><td style="text-align: left" valign="bottom"><table style="width: 100%"><tr><td width="5%">
                                                                                        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                                                            ToolTip="Grabar" />
                                                                                        </td><td width="5%">
                                                                                            <asp:ImageButton ID="ImageButton3" runat="server" BorderColor="Gray" 
                                                                                                BorderStyle="Solid" BorderWidth="0px" ImageUrl="~/img/Aceptar.gif" 
                                                                                                ToolTip="Validar" />
                                                                                        </td><td style="text-align: right" width="80%">Código:</td><td style="text-align: left" width="10%"><asp:TextBox ID="TextBox1" runat="server" Enabled="False" TabIndex="27" 
                                                                                                                    Width="70px"></asp:TextBox></td></tr></table></td></tr><tr><td><table cellspacing="0" class="0" style="width: 100%"><tr><td class="Texto" style="font-weight: 700">Datos Generales</td></tr><tr><td class="Texto"><table style="width: 100%"><tr><td width="12%">Catálogo:</td><td width="88%"><telerik:RadComboBox ID="RadComboBox1" Runat="server" AutoPostBack="True" 
                                                                                                                                DataSourceID="odsCatalogoBusqueda" DataTextField="CodigoDescripcion" 
                                                                                                                                DataValueField="IdCatalogo" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                                ShowDropDownOnTextboxClick="False" Skin="Hay" style="margin-left: 0px" 
                                                                                                                                TabIndex="1" ValidationGroup="Transaccion" Width="100%"></telerik:RadComboBox><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar el Catálogo!"></asp:RequiredFieldValidator></td></tr><tr><td width="12%">Proyecto:</td><td width="88%"><telerik:RadComboBox ID="RadComboBox2" Runat="server" AllowCustomText="True" 
                                                                                                                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                                                ShowMoreResultsBox="True" Skin="Hay" TabIndex="2" ValidationGroup="Transaccion" 
                                                                                                                                Width="100%"></telerik:RadComboBox><asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                                                                                                                ControlToValidate="RadComboBox2" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar el Proyecto!"></asp:RequiredFieldValidator></td></tr><tr><td width="12%">C. Costo:</td><td><telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                                                DataSourceID="SqlDSCCosto" DataTextField="CodigoElemGasto" 
                                                                                                                                DataValueField="IdCCosto" EnableAjaxSkinRendering="False" 
                                                                                                                                EnableEmbeddedBaseStylesheet="False" EnableEmbeddedScripts="False" 
                                                                                                                                EnableEmbeddedSkins="False" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                                Skin="Hay" TabIndex="3" Width="100%"></telerik:RadComboBox></td></tr></table></td></tr><tr><td class="Texto"><table style="width: 100%"><tr><td width="12%">Estado:</td><td><asp:DropDownList ID="DropDownList1" runat="server" Font-Names="Arial" 
                                                                                                                                Font-Size="8pt" TabIndex="4" Width="140px"><asp:ListItem Selected="True">OPERATIVO</asp:ListItem><asp:ListItem>INOPERATIVO</asp:ListItem></asp:DropDownList></td><td><asp:CheckBox ID="CheckBox1" runat="server" TabIndex="5" Text="Donación" /></td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td width="12%">Cod. Referencia:</td><td><asp:TextBox ID="TextBox11" runat="server" CssClass="Texto1" TabIndex="6" 
                                                                                                                                Width="99%"></asp:TextBox></td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td width="12%">Bien Padre:</td><td colspan="8"><telerik:RadComboBox ID="RadComboBox9" Runat="server" DataTextField="Bien" 
                                                                                                                                DataValueField="IdBienMueble" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                                ShowDropDownOnTextboxClick="False" Skin="Hay" style="margin-left: 0px" 
                                                                                                                                TabIndex="7" Width="100%"></telerik:RadComboBox></td></tr><tr><td width="12%">Descripción:</td><td colspan="8"><asp:TextBox ID="TextBox10" runat="server" CssClass="Texto1" Rows="1" 
                                                                                                                                TabIndex="8" Width="99%"></asp:TextBox></td></tr></table></td></tr><tr><td class="Texto" style="font-weight: 700">Datos de la Adquisición</td></tr><tr><td class="Texto"><table style="width: 100%"><tr><td width="12%">Tipo Documento:</td><td width="15%"><asp:DropDownList ID="DropDownList4" runat="server" AppendDataBoundItems="True" 
                                                                                                                                DataSourceID="SqlTipoDocumento" DataTextField="Documento" 
                                                                                                                                DataValueField="IdTipoDocumento" Font-Names="arial" Font-Size="8pt" 
                                                                                                                                TabIndex="9" Width="140px"><asp:ListItem Value="0">---</asp:ListItem></asp:DropDownList></td><td style="text-align: right" width="6%">Serie:</td><td width="10%"><asp:TextBox ID="TextBox3" runat="server" CssClass="Texto1" MaxLength="4" 
                                                                                                                                TabIndex="10" Width="70px"></asp:TextBox></td><td style="text-align: right" width="5%">N°:</td><td width="10%"><asp:TextBox ID="TextBox2" runat="server" CssClass="Texto1" TabIndex="11" 
                                                                                                                                Width="80px"></asp:TextBox></td><td style="text-align: right" width="12%">Fecha Compra:</td><td width="10%"><asp:TextBox ID="txtDate" runat="server" AutoPostBack="True" TabIndex="12" 
                                                                                                                                Width="70px" /><asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                                                TargetControlID="txtDate" /><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                                                                                                ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator><asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                                                                                ControlExtender="MaskedEditExtender1" ControlToValidate="txtDate" 
                                                                                                                                Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                                                InvalidValueMessage="¡Fecha Incorrecta!" /></td><td style="text-align: right" width="10%">Valor (S/.):</td><td width="10%"><telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" 
                                                                                                                                AutoPostBack="True" TabIndex="13" Value="0" Width="70px"><IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" /></telerik:RadNumericTextBox></td></tr><tr><td width="12%">Proveedor:</td><td colspan="8" width="86%"><telerik:RadComboBox ID="RadComboBox4" Runat="server" AllowCustomText="True" 
                                                                                                                                DataTextField="NombreProveedor" DataValueField="IdProveedorCliente" 
                                                                                                                                EnableAjaxSkinRendering="False" EnableEmbeddedBaseStylesheet="False" 
                                                                                                                                EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
                                                                                                                                EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                                                                                                                MarkFirstMatch="True" ShowMoreResultsBox="True" Skin="Hay" TabIndex="14" 
                                                                                                                                Width="100%"></telerik:RadComboBox></td><td width="2%"><asp:ImageButton ID="ImageButton7" runat="server" CausesValidation="False" 
                                                                                                                                ImageAlign="Middle" ImageUrl="~/img/Agregar.gif" 
                                                                                                                                ToolTip="Registrar Proveedor" /></td></tr></table></td></tr><tr><td class="Texto" style="font-weight: 700">Datos Técnicos</td></tr><tr><td class="Texto"><table style="width: 100%"><tr><td width="12%">Marca:</td><td width="20%"><telerik:RadComboBox ID="RadComboBox10" Runat="server" AllowCustomText="True" 
                                                                                                                                DataSourceID="SqlMarca" DataTextField="Descripcion" DataValueField="IdMarca" 
                                                                                                                                EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                                                                                                                MarkFirstMatch="True" ShowMoreResultsBox="True" Skin="Hay" TabIndex="15" 
                                                                                                                                Width="100%"></telerik:RadComboBox></td><td width="5%"><asp:ImageButton ID="ImageButton8" runat="server" CausesValidation="False" 
                                                                                                                                ImageAlign="Middle" ImageUrl="~/img/Agregar.gif" ToolTip="Registrar Marca" /></td><td width="7%">Modelo:</td><td width="25%"><asp:TextBox ID="TextBox4" runat="server" CssClass="Texto1" TabIndex="16" 
                                                                                                                                Width="96%"></asp:TextBox></td><td width="6%">Serie:</td><td width="25%"><asp:TextBox ID="TextBox5" runat="server" CssClass="Texto1" TabIndex="17" 
                                                                                                                                Width="96%"></asp:TextBox></td></tr><tr><td>Placa:</td><td><asp:TextBox ID="TextBox6" runat="server" CssClass="Texto1" TabIndex="18" 
                                                                                                                                Width="96%"></asp:TextBox></td><td>&nbsp;</td><td>Motor:</td><td><asp:TextBox ID="TextBox7" runat="server" CssClass="Texto1" TabIndex="19" 
                                                                                                                                Width="96%"></asp:TextBox></td><td>Color:</td><td><asp:TextBox ID="TextBox8" runat="server" CssClass="Texto1" TabIndex="20" 
                                                                                                                                Width="96%"></asp:TextBox></td></tr><tr><td>Otros:</td><td colspan="6"><asp:TextBox ID="TextBox9" runat="server" CssClass="Texto1" Rows="1" 
                                                                                                                                TabIndex="21" Width="99%"></asp:TextBox></td></tr></table></td></tr><tr><td class="Texto" style="font-weight: 700">Ubicación</td></tr><tr><td class="Texto"><table class="style6" width="100%"><tr><td width="12%">Oficina:</td><td><telerik:RadComboBox ID="RadComboBox11" Runat="server" AllowCustomText="True" 
                                                                                                                                DataSourceID="SqlOficinas" DataTextField="Nombre" DataValueField="IdOficina" 
                                                                                                                                EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                                                                                                                MarkFirstMatch="True" ShowMoreResultsBox="True" Skin="Hay" TabIndex="22" 
                                                                                                                                Width="100%"></telerik:RadComboBox></td></tr></table></td></tr><tr><td class="Texto" style="font-weight: 700">Datos Contables</td></tr><tr><td class="Texto"><table class="style6" width="100%"><tr><td width="12%">Tipo de Bien:</td><td style="text-align: left" width="88%"><asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="Texto1" 
                                                                                                                                RepeatDirection="Horizontal" TabIndex="23"><asp:ListItem Selected="True" Value="A">Activo Fijo</asp:ListItem><asp:ListItem Value="C">Cuentas de Orden</asp:ListItem>
                                                                                            <asp:ListItem Value="I">Intangibles</asp:ListItem>
                                                                                            </asp:RadioButtonList></td></tr><tr><td width="12%">Cta. Activo Fijo:</td><td width="88%"><telerik:RadComboBox ID="RadComboBox6" Runat="server" DataTextField="Cuenta" 
                                                                                                                                DataValueField="Codigo" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                                ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" Skin="Hay" 
                                                                                                                                TabIndex="24" Width="100%"></telerik:RadComboBox></td></tr><tr><td>
                                                                                                Cta. Depreciación:</td><td><telerik:RadComboBox ID="RadComboBox7" Runat="server" DataTextField="Cuenta" 
                                                                                                                                DataValueField="Codigo" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                                ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" Skin="Hay" 
                                                                                                                                TabIndex="25" Width="100%"></telerik:RadComboBox></td></tr><tr><td>
                                                                                                Cta. Gasto:</td><td><telerik:RadComboBox ID="RadComboBox8" Runat="server" DataTextField="Cuenta" 
                                                                                                                                DataValueField="Codigo" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                                ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" Skin="Hay" 
                                                                                                                                TabIndex="26" Width="100%"></telerik:RadComboBox></td></tr></table></td></tr></table></td></tr></table></telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView2" runat="server"><table class="tabla3" style="width: 100%"><tr><td><telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                                                                                        CellSpacing="0" DataSourceID="SqlResponsables" GridLines="None" Skin="Hay"><MasterTableView ClientDataKeyNames="IdResponsable" CommandItemDisplay="Top" 
                                                                                                            DataKeyNames="IdResponsable" DataSourceID="SqlResponsables" 
                                                                                                            NoMasterRecordsText="No existen registros."><CommandItemSettings AddNewRecordText="Agregar Responsable" 
                                                                                                                ExportToPdfText="Export to PDF" RefreshText="Refrescar" 
                                                                                                                ShowRefreshButton="False" /><RowIndicatorColumn FilterControlAltText="Filter RowIndicator column"><HeaderStyle Width="20px" /></RowIndicatorColumn><ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column"><HeaderStyle Width="20px" /></ExpandCollapseColumn><Columns><telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                                    FilterControlAltText="Filter EditCommandColumn column"><HeaderStyle Width="1.5%" /></telerik:GridEditCommandColumn><telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                                    ConfirmDialogType="RadWindow" 
                                                                                                                    ConfirmText="¿Está seguro de eliminar el Responsable?" 
                                                                                                                    ConfirmTitle="Mensaje de Confirmación" 
                                                                                                                    FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
                                                                                                                    Text="Eliminar" UniqueName="column"><HeaderStyle Width="1.5%" /></telerik:GridButtonColumn><telerik:GridBoundColumn DataField="Personal" 
                                                                                                                    FilterControlAltText="Filter Personal column" HeaderText="Responsable" 
                                                                                                                    ReadOnly="True" SortExpression="Personal" UniqueName="Personal"><HeaderStyle HorizontalAlign="Center" Width="38%" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="FechaInicio" 
                                                                                                                    DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime" 
                                                                                                                    FilterControlAltText="Filter FechaInicio column" HeaderText="Fecha Inicio" 
                                                                                                                    SortExpression="FechaInicio" UniqueName="FechaInicio"><HeaderStyle HorizontalAlign="Center" Width="10%" /><ItemStyle HorizontalAlign="Center" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="FechaFin" DataFormatString="{0:dd/MM/yyyy}" 
                                                                                                                    DataType="System.DateTime" FilterControlAltText="Filter FechaFin column" 
                                                                                                                    HeaderText="Fecha Fin" SortExpression="FechaFin" UniqueName="FechaFin"><HeaderStyle HorizontalAlign="Center" Width="10%" /><ItemStyle HorizontalAlign="Center" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="Observacion" 
                                                                                                                    FilterControlAltText="Filter Observacion column" HeaderText="Observación" 
                                                                                                                    SortExpression="Observacion" UniqueName="Observacion"><HeaderStyle HorizontalAlign="Center" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="IdPersonal" DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdPersonal column" HeaderText="IdPersonal" 
                                                                                                                    SortExpression="IdPersonal" UniqueName="IdPersonal" Visible="False"><HeaderStyle Width="39%" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="IdBienMueble" DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdBienMueble column" HeaderText="IdBienMueble" 
                                                                                                                    SortExpression="IdBienMueble" UniqueName="IdBienMueble" Visible="False"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="IdResponsable" DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdResponsable column" HeaderText="IdResponsable" 
                                                                                                                    ReadOnly="True" SortExpression="IdResponsable" UniqueName="IdResponsable" 
                                                                                                                    Visible="False"></telerik:GridBoundColumn></Columns><EditFormSettings EditFormType="WebUserControl" 
                                                                                                                UserControlName="~\Patrimonio\Controles\ControlResponsable.ascx"><EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn></EditFormSettings></MasterTableView><FilterMenu EnableImageSprites="False"></FilterMenu><HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu></telerik:RadGrid></td></tr></table></telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView3" runat="server"><table class="tabla3" style="width: 100%"><tr><td><telerik:RadGrid ID="RadGrid2" runat="server" Skin="Hay" 
                                                                                                        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlEstados" 
                                                                                                        GridLines="None"><MasterTableView ClientDataKeyNames="IdEstado" CommandItemDisplay="Top" 
                                                                                                            DataKeyNames="IdEstado" DataSourceID="SqlEstados" 
                                                                                                            NoMasterRecordsText="No existen registros."><CommandItemSettings AddNewRecordText="Agregar Registro" 
                                                                                                                ExportToPdfText="Export to PDF" ShowRefreshButton="False" /><RowIndicatorColumn FilterControlAltText="Filter RowIndicator column"><HeaderStyle Width="20px" /></RowIndicatorColumn><ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column"><HeaderStyle Width="20px" /></ExpandCollapseColumn><Columns><telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                                    FilterControlAltText="Filter EditCommandColumn column"><HeaderStyle HorizontalAlign="Center" Width="1.5%" /></telerik:GridEditCommandColumn><telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                                    ConfirmDialogType="RadWindow" 
                                                                                                                    ConfirmText="¿Está seguro de eliminar el Registro?" 
                                                                                                                    ConfirmTitle="Mensaje de Confirmación" 
                                                                                                                    FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
                                                                                                                    UniqueName="column"><HeaderStyle Width="1.5%" /></telerik:GridButtonColumn><telerik:GridBoundColumn DataField="Tipo" 
                                                                                                                    FilterControlAltText="Filter Tipo column" HeaderText="Tipo" 
                                                                                                                    SortExpression="Tipo" UniqueName="Tipo"><HeaderStyle HorizontalAlign="Center" Width="20%" /><ItemStyle HorizontalAlign="Center" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="FechaInicio" 
                                                                                                                    DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime" 
                                                                                                                    FilterControlAltText="Filter FechaInicio column" HeaderText="Fecha Inicio" 
                                                                                                                    SortExpression="FechaInicio" UniqueName="FechaInicio"><HeaderStyle HorizontalAlign="Center" Width="10%" /><ItemStyle HorizontalAlign="Center" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="Observacion" 
                                                                                                                    FilterControlAltText="Filter Observacion column" HeaderText="Observación" 
                                                                                                                    SortExpression="Observacion" UniqueName="Observacion"><HeaderStyle HorizontalAlign="Center" Width="67%" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="IdBienMueble" DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdBienMueble column" HeaderText="IdBienMueble" 
                                                                                                                    SortExpression="IdBienMueble" UniqueName="IdBienMueble" Visible="False"><HeaderStyle HorizontalAlign="Center" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="IdEstado" DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdEstado column" HeaderText="IdEstado" 
                                                                                                                    ReadOnly="True" SortExpression="IdEstado" UniqueName="IdEstado" Visible="False"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="IdTipo" DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdTipo column" HeaderText="IdTipo" 
                                                                                                                    SortExpression="IdTipo" UniqueName="IdTipo" Visible="False"></telerik:GridBoundColumn></Columns><EditFormSettings EditFormType="WebUserControl" 
                                                                                                                UserControlName="~\Patrimonio\Controles\ControlEstado.ascx"><EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn></EditFormSettings></MasterTableView><FilterMenu EnableImageSprites="False"></FilterMenu><HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Hay"></HeaderContextMenu></telerik:RadGrid></td></tr></table></telerik:RadPageView>
                                                                                </telerik:RadMultiPage>
                                                                                    
                                                                                </td>
                                                    </tr>
    </table>

                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="OdsBienPadre" runat="server" 
        SelectMethod="GetBIENMUEBLEByParameter" 
        TypeName="SistFoncreagro.BussinesLogic.BienMuebleBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="texto" Type="String" />
                                                    </SelectParameters>
    </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                                                                    <asp:SqlDataSource ID="SqlEstados" 
        runat="server" 
                                                                                                        
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                                                                        
        SelectCommand="GetESTADOBIENMUEBLEDetallado" 
                                                                                                        
        SelectCommandType="StoredProcedure">
                                                                                                        <SelectParameters>
                                                                                                            <asp:QueryStringParameter Name="IdBienMueble" QueryStringField="IdBienMueble" 
                                                                                                                Type="Int32" />
                                                                                                        </SelectParameters>
                                                                                                    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlResponsables" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetRESPONSABLEBIENMUEBLEByIdBienMuebleDetallado" 
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter Name="IdBienMueble" QueryStringField="IdBienMueble" 
                Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
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

                                                                                            <asp:SqlDataSource ID="SqlMarca" runat="server" 
                                                                                                ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="GetAllFromMarca" 
                                                                                                SelectCommandType="StoredProcedure"></asp:SqlDataSource>

<asp:ObjectDataSource ID="odsPlanContable3" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


                                                                                <asp:SqlDataSource ID="SqlTipoDocumento" runat="server" 
                                                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                                                    SelectCommand="GetTIPODOCUMENTOVentas" SelectCommandType="StoredProcedure">
                                                                                </asp:SqlDataSource>
                                <asp:ObjectDataSource ID="odsCatalogoBusqueda" runat="server" 
                                    SelectMethod="GetAllFromCatalogoByParametro" 
                                    
        TypeName="SistFoncreagro.BussinesLogic.CatalogoBL" 
        OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="0" Name="tipo" Type="Int32" />
                                        <asp:Parameter DefaultValue="$" Name="parametro" Type="String" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
<asp:SqlDataSource ID="SqlDSCCosto" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetCCOSTOByIdProyecto1" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:ControlParameter ControlID="RadComboBox2" Name="idProyecto" 
            PropertyName="SelectedValue" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>

             

                                            
    <asp:SqlDataSource ID="SqlOficinas" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="GetOFICINALista" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>

             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default" 
        EnableEmbeddedScripts="False">
    </telerik:RadAjaxLoadingPanel>
  

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

        function Abrir1() {
            var oWnd = radopen("FrmMarcas.aspx", "Marcas");
        }
        function Cerrar1() {

            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ActualizarLista1");
        }
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Mensaje");
        }
        function ponerCeros() {
            var obj = document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox3');
            while (obj.value.length < 4)
                obj.value = '0' + obj.value;
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
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox10" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox6" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox7" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox8" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox2">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox3" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="txtDate">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadioButtonList1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadNumericTextBox3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadioButtonList1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox6">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox5" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox6" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>


                                                </asp:Content>
