<%@ Page Title="Control de Actividades" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterMonitoreo1.master" CodeBehind="FrmDetalleEje.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmDetalleEje" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                                                <table 
        style="width: 100%">
                                                    <tr>
                                                        <td style="height: 30px">
                                                                                    
                                                                                <telerik:RadTabStrip ID="RadTabStrip1" runat="server" 
                                                                                    MultiPageID="RadMultiPage1" SelectedIndex="0" Width="100%">
                                                                                    <Tabs>
                                                                                        <telerik:RadTab runat="server" Text="Información General" Selected="True">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Vehículos">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Equipo">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Documentación">
                                                                                        </telerik:RadTab>
                                                                                    </Tabs>
                                                                                </telerik:RadTabStrip>
                                                                                    
                                                                                </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="height: 30px">
                                                                                    
                                                                                <telerik:RadMultiPage ID="RadMultiPage1" Runat="server" SelectedIndex="0" 
                                                                                    Width="100%">
                                                                                    <telerik:RadPageView ID="RadPageView1" runat="server" Width="100%"><table 
                                                                                        align="center" class="tabla3"><tr><td style="text-align: left" valign="bottom"><table 
                                                                                                style="width: 100%"><tr><td width="5%"><asp:ImageButton ID="ImageButton3" 
                                                                                                    runat="server" BorderColor="Gray" BorderStyle="Solid" BorderWidth="0px" 
                                                                                                    ImageUrl="~/img/Grabar.gif" ToolTip="Grabar" /></td><td width="5%">
                                                                                                    <asp:ImageButton 
                                                                                                        ID="ImageButton4" runat="server" BorderColor="Gray" BorderStyle="Solid" 
                                                                                                        BorderWidth="0px" CausesValidation="False" ImageUrl="~/img/Nuevo.gif" 
                                                                                                        ToolTip="Nueva Actividad" /></td><td style="text-align: right" 
                                                                                                    width="5%">
                                                                                                    <asp:ImageButton ID="ImageButton6" runat="server" Height="25px" 
                                                                                                        ImageUrl="~/img/Calendario.gif" ToolTip="Reprogramar Actividad" Width="25px" />
                                                                                                </td>
                                                                                                <td 
                                                                                                    style="text-align: right" width="5%">
                                                                                                    <asp:ImageButton ID="ImageButton5" runat="server" Height="25px" 
                                                                                                        ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar Actividad" Width="25px" />
                                                                                                </td>
                                                                                                <td style="text-align: right; font-weight: bold;" width="70%">
                                                                                                    Estado:</td>
                                                                                                <td style="text-align: left" width="10%">
                                                                                                    <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True"></asp:Label>
                                                                                                </td>
                                                                                            </tr></table></td></tr><tr><td><table 
                                                                                                cellspacing="0" class="0" style="width: 100%"><tr><td class="Texto"><table 
                                                                                                    style="width: 100%"><tr>
                                                                                                    <td class="Texto" style="font-weight: 700; text-decoration: underline;" 
                                                                                                        width="12%">DATOS GENERALES</td></tr><tr>
                                                                                                    <td 
                                                                                                        width="12%" style="width: 100%">
                                                                                                        <table style="width: 100%">
                                                                                                            <tr>
                                                                                                                <td width="12%">
                                                                                                                    Registro:</td>
                                                                                                                <td width="21%">
                                                                                                                    <asp:TextBox ID="txtDate2" runat="server" TabIndex="1" Width="70px" />
                                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                                                                                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                                        TargetControlID="txtDate2" />
                                                                                                                    <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                                                                                                        ControlExtender="MaskedEditExtender2" ControlToValidate="txtDate2" 
                                                                                                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" 
                                                                                                                        ControlToValidate="txtDate2" Display="Dynamic" 
                                                                                                                        ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator>
                                                                                                                </td>
                                                                                                                <td width="12%">
                                                                                                                    Programación:</td>
                                                                                                                <td width="21%">
                                                                                                                    <asp:TextBox ID="txtDate1" runat="server" TabIndex="2" Width="70px" />
                                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                                                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                                        TargetControlID="txtDate1" />
                                                                                                                    <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                                                                        ControlExtender="MaskedEditExtender1" ControlToValidate="txtDate1" 
                                                                                                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                                                </td>
                                                                                                                <td width="12%">
                                                                                                                    Ejecución:</td>
                                                                                                                <td>
                                                                                                                    <asp:TextBox ID="txtDate" runat="server" TabIndex="3" 
                                                                                                                        Width="70px" />
                                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender" runat="server" 
                                                                                                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                                        TargetControlID="txtDate" />
                                                                                                                    <asp:MaskedEditValidator ID="MaskedEditValidator" runat="server" 
                                                                                                                        ControlExtender="MaskedEditExtender" ControlToValidate="txtDate" 
                                                                                                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                            <tr>
                                                                                                                <td width="12%">
                                                                                                                    Hora:</td>
                                                                                                                <td width="21%">
                                                                                                                    <asp:TextBox ID="TextBox12" runat="server" Width="70px" TabIndex="4"></asp:TextBox>
                                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender4" runat="server" 
                                                                                                                        AcceptAMPM="true" ErrorTooltipEnabled="true" InputDirection="RightToLeft" 
                                                                                                                        Mask="99:99" MaskType="Time" MessageValidatorTip="true" 
                                                                                                                        OnFocusCssClass="MaskedEditFocus" OnInvalidCssClass="MaskedEditError" 
                                                                                                                        TargetControlID="TextBox12">
                                                                                                                    </asp:MaskedEditExtender>
                                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                                        ControlToValidate="TextBox12" Display="Dynamic" 
                                                                                                                        ErrorMessage="¡Debe ingresar la Hora!"></asp:RequiredFieldValidator>
                                                                                                                </td>
                                                                                                                <td colspan="2" style="width: 33%" width="12%">
                                                                                                                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                                                                                                        RepeatDirection="Horizontal" TabIndex="5">
                                                                                                                        <asp:ListItem Selected="True">OFICINA</asp:ListItem>
                                                                                                                        <asp:ListItem>SALIDA A CAMPO</asp:ListItem>
                                                                                                                    </asp:RadioButtonList>
                                                                                                                </td>
                                                                                                                <td width="12%">
                                                                                                                    &nbsp;</td>
                                                                                                                <td>
                                                                                                                    &nbsp;</td>
                                                                                                            </tr>
                                                                                                            <tr>
                                                                                                                <td width="12%">
                                                                                                                    Caserio:</td>
                                                                                                                <td colspan="5" width="21%">
                                                                                                                    <telerik:RadComboBox ID="RadComboBox1" Runat="server" DataTextField="Nombre" 
                                                                                                                        DataValueField="CUBIGEO" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                        ShowDropDownOnTextboxClick="False" Skin="Hay" style="margin-left: 0px" 
                                                                                                                        TabIndex="6" Width="80%">
                                                                                                                    </telerik:RadComboBox>
                                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                                                                                                                        ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                                        ErrorMessage="¡Debe ingresar el Caserio!"></asp:RequiredFieldValidator>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                            <tr>
                                                                                                                <td width="12%">
                                                                                                                    Jefe Familia:</td>
                                                                                                                <td colspan="5" width="21%">
                                                                                                                    <telerik:RadComboBox ID="RadComboBox7" Runat="server" TabIndex="7" Width="80%">
                                                                                                                    </telerik:RadComboBox>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                        </table>
                                                                                                    </td></tr>
                                                                                                </table></td></tr><tr><td 
                                                                                                    class="Texto"><table style="width: 100%">
                                                                                                    <tr>
                                                                                                        <td style="font-weight: 700; text-decoration: underline; height: 20px;">
                                                                                                            COMENTARIOS DE CLIMA SOCIAL</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <td>
                                                                                                            <table style="width: 100%">
                                                                                                                <tr>
                                                                                                                    <td>
                                                                                                                        Clima Social:</td>
                                                                                                                    <td>
                                                                                                                        <asp:TextBox ID="TextBox8" runat="server" CssClass="Texto1" TabIndex="8" 
                                                                                                                            TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                                    </td>
                                                                                                                    <td style="text-align: right" width="14%">
                                                                                                                        Quejas o Reclamos:</td>
                                                                                                                    <td>
                                                                                                                        <asp:TextBox ID="TextBox9" runat="server" CssClass="Texto1" TabIndex="9" 
                                                                                                                            TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td width="14%">
                                                                                                                        Acciones Tomadas:</td>
                                                                                                                    <td width="36%">
                                                                                                                        <asp:TextBox ID="TextBox10" runat="server" CssClass="Texto1" TabIndex="10" 
                                                                                                                            TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                                    </td>
                                                                                                                    <td style="text-align: right">
                                                                                                                        Observaciones:</td>
                                                                                                                    <td width="36%">
                                                                                                                        <asp:TextBox ID="TextBox11" runat="server" CssClass="Texto1" TabIndex="11" 
                                                                                                                            TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="4" 
                                                                                                                        style="font-weight: 700; text-decoration: underline; height: 20px;" width="14%">
                                                                                                                        ACTIVIDADES/TAREAS</td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="4" style="width: 50%" width="14%">
                                                                                                                        <telerik:RadGrid ID="RadGrid5" runat="server" AutoGenerateColumns="False" 
                                                                                                                            CellSpacing="0" DataSourceID="SqlControl" GridLines="None" Skin="Hay">
                                                                                                                            <MasterTableView CommandItemDisplay="Top" DataKeyNames="IdControl" 
                                                                                                                                DataSourceID="SqlControl" NoMasterRecordsText="No existen registros.">
                                                                                                                                <CommandItemSettings AddNewRecordText="Agregar Tarea" 
                                                                                                                                    ExportToPdfText="Export to PDF" ShowRefreshButton="False" />
                                                                                                                                <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                                                                                                                    <HeaderStyle Width="20px" />
                                                                                                                                </RowIndicatorColumn>
                                                                                                                                <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                                                                                                                    <HeaderStyle Width="20px" />
                                                                                                                                </ExpandCollapseColumn>
                                                                                                                                <Columns>
                                                                                                                                    <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                                                        FilterControlAltText="Filter EditCommandColumn column">
                                                                                                                                        <HeaderStyle Width="1.5%" />
                                                                                                                                    </telerik:GridEditCommandColumn>
                                                                                                                                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                                                        ConfirmDialogType="RadWindow" 
                                                                                                                                        ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                                                                                                                        ConfirmTitle="Mensaje de Confirmación" 
                                                                                                                                        FilterControlAltText="Filter column column" Text="Eliminar" UniqueName="column">
                                                                                                                                        <HeaderStyle Width="1.5%" />
                                                                                                                                    </telerik:GridButtonColumn>
                                                                                                                                    <telerik:GridBoundColumn DataField="Tarea" 
                                                                                                                                        FilterControlAltText="Filter Tarea column" HeaderText="Tarea" ReadOnly="True" 
                                                                                                                                        SortExpression="Tarea" UniqueName="Tarea">
                                                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="32%" />
                                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                                    <telerik:GridBoundColumn DataField="Descripcion" 
                                                                                                                                        FilterControlAltText="Filter Descripcion column" HeaderText="Descripcion" 
                                                                                                                                        SortExpression="Descripcion" UniqueName="Descripcion">
                                                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="32%" />
                                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                                    <telerik:GridBoundColumn DataField="Capacitacion" 
                                                                                                                                        FilterControlAltText="Filter Capacitacion column" HeaderText="Capacitacion" 
                                                                                                                                        ReadOnly="True" SortExpression="Capacitacion" UniqueName="Capacitacion">
                                                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="33%" />
                                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                                    <telerik:GridBoundColumn DataField="IdControl" DataType="System.Int32" 
                                                                                                                                        FilterControlAltText="Filter IdControl column" HeaderText="IdControl" 
                                                                                                                                        ReadOnly="True" SortExpression="IdControl" UniqueName="IdControl" 
                                                                                                                                        Visible="False">
                                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                                    <telerik:GridBoundColumn DataField="IdSubActividad" DataType="System.Int32" 
                                                                                                                                        FilterControlAltText="Filter IdSubActividad column" HeaderText="IdSubActividad" 
                                                                                                                                        SortExpression="IdSubActividad" UniqueName="IdSubActividad" Visible="False">
                                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                                    <telerik:GridBoundColumn DataField="IdUser" DataType="System.Int32" 
                                                                                                                                        FilterControlAltText="Filter IdUser column" HeaderText="IdUser" 
                                                                                                                                        SortExpression="IdUser" UniqueName="IdUser" Visible="False">
                                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                                    <telerik:GridBoundColumn DataField="IdTarea" DataType="System.Int32" 
                                                                                                                                        FilterControlAltText="Filter IdTarea column" HeaderText="IdTarea" 
                                                                                                                                        SortExpression="IdTarea" UniqueName="IdTarea" Visible="False">
                                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                                    <telerik:GridBoundColumn DataField="IdDetalleEje" DataType="System.Int32" 
                                                                                                                                        FilterControlAltText="Filter IdDetalleEje column" HeaderText="IdDetalleEje" 
                                                                                                                                        SortExpression="IdDetalleEje" UniqueName="IdDetalleEje" Visible="False">
                                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                                    <telerik:GridBoundColumn DataField="Estado" 
                                                                                                                                        FilterControlAltText="Filter column1 column" HeaderText="Estado" 
                                                                                                                                        UniqueName="column1">
                                                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                                                        <ItemStyle HorizontalAlign="Center" />
                                                                                                                                    </telerik:GridBoundColumn>
                                                                                                                                </Columns>
                                                                                                                                <EditFormSettings>
                                                                                                                                    <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                                                                                                                    </EditColumn>
                                                                                                                                </EditFormSettings>
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
                                                                                                </table></td></tr></table></td></tr></table></telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView2" runat="server"><table class="tabla3" 
                                                                                        style="width: 100%"><tr><td><telerik:RadGrid ID="RadGrid4" runat="server" 
                                                                                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlVehiculos" 
                                                                                                GridLines="None" Skin="Hay">
                                                                                            <mastertableview 
                                                                                                clientdatakeynames="IdVehiculo" commanditemdisplay="Top" 
                                                                                                datakeynames="IdVehiculo" datasourceid="SqlVehiculos" 
                                                                                                nomasterrecordstext="No existen registros."><commanditemsettings 
                                                                                                addnewrecordtext="Agregar Vehiculo" exporttopdftext="Export to PDF" 
                                                                                                showrefreshbutton="False" /><rowindicatorcolumn 
                                                                                                filtercontrolalttext="Filter RowIndicator column"></rowindicatorcolumn><expandcollapsecolumn 
                                                                                                filtercontrolalttext="Filter ExpandColumn column"></expandcollapsecolumn><Columns><telerik:GridEditCommandColumn 
                                                                                                    ButtonType="ImageButton" EditText="Editar" 
                                                                                                    FilterControlAltText="Filter EditCommandColumn column">
                                                                                                    <HeaderStyle Width="1.5%" />
                                                                                                    </telerik:GridEditCommandColumn><telerik:GridButtonColumn 
                                                                                                    ButtonType="ImageButton" CommandName="Delete" ConfirmDialogType="RadWindow" 
                                                                                                    FilterControlAltText="Filter column column" FilterImageUrl="~\img\delete.gif" 
                                                                                                    Text="Eliminar" UniqueName="column" 
                                                                                                        ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                                                                                        ConfirmTitle="Mensaje de Confirmación">
                                                                                                        <HeaderStyle Width="1.5%" />
                                                                                                    </telerik:GridButtonColumn><telerik:GridBoundColumn 
                                                                                                    DataField="Marca" FilterControlAltText="Filter Marca column" HeaderText="Marca" 
                                                                                                    SortExpression="Marca" UniqueName="Marca">
                                                                                                        <HeaderStyle 
                                                                                                    HorizontalAlign="Center" Width="15%" /></telerik:GridBoundColumn><telerik:GridBoundColumn 
                                                                                                    DataField="Modelo" FilterControlAltText="Filter Modelo column" 
                                                                                                    HeaderText="Modelo" SortExpression="Modelo" UniqueName="Modelo">
                                                                                                        <HeaderStyle 
                                                                                                    HorizontalAlign="Center" Width="15%" /></telerik:GridBoundColumn><telerik:GridBoundColumn 
                                                                                                    DataField="Placa" DataType="System.DateTime" 
                                                                                                    FilterControlAltText="Filter Placa column" HeaderText="Placa" 
                                                                                                    SortExpression="Placa" UniqueName="Placa">
                                                                                                        <HeaderStyle 
                                                                                                    HorizontalAlign="Center" Width="15%" /><ItemStyle HorizontalAlign="Center" /></telerik:GridBoundColumn><telerik:GridBoundColumn 
                                                                                                    DataField="Tipo" DataType="System.Int32" 
                                                                                                    FilterControlAltText="Filter Tipo column" HeaderText="Tipo" ReadOnly="True" 
                                                                                                    SortExpression="Tipo" UniqueName="Tipo">
                                                                                                        <HeaderStyle Width="15%" />
                                                                                                    </telerik:GridBoundColumn><telerik:GridBoundColumn 
                                                                                                    DataField="Observaciones" DataType="System.Int32" 
                                                                                                    FilterControlAltText="Filter Observaciones column" HeaderText="Observaciones" 
                                                                                                    SortExpression="Observaciones" UniqueName="Observaciones">
                                                                                                        <HeaderStyle Width="37%" />
                                                                                                    </telerik:GridBoundColumn></Columns><editformsettings 
                                                                                                editformtype="WebUserControl" 
                                                                                                usercontrolname="~\Monitoreo\Controles\ControlVehiculo.ascx"><editcolumn 
                                                                                                filtercontrolalttext="Filter EditCommandColumn column"></editcolumn></editformsettings></mastertableview><filtermenu 
                                                                                                enableimagesprites="False"></filtermenu><headercontextmenu 
                                                                                                cssclass="GridContextMenu GridContextMenu_Default"></headercontextmenu></telerik:RadGrid></td></tr></table></telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView3" runat="server"><table class="tabla3" 
                                                                                        style="width: 100%"><tr><td>
                                                                                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                                                                                CellSpacing="0" DataSourceID="SqlEquipo" GridLines="None" Skin="Hay">
                                                                                                <mastertableview clientdatakeynames="IdIntegrante" commanditemdisplay="Top" 
                                                                                                    datakeynames="IdIntegrante" DataSourceID="SqlEquipo" 
                                                                                                    nomasterrecordstext="No existen registros.">
                                                                                                    <commanditemsettings addnewrecordtext="Agregar Miembro del Equipo" 
                                                                                                        exporttopdftext="Export to PDF" refreshtext="Refrescar" 
                                                                                                        showrefreshbutton="False" />
                                                                                                    <rowindicatorcolumn filtercontrolalttext="Filter RowIndicator column">
                                                                                                        <HeaderStyle Width="20px" />
                                                                                                    </rowindicatorcolumn>
                                                                                                    <expandcollapsecolumn filtercontrolalttext="Filter ExpandColumn column">
                                                                                                        <HeaderStyle Width="20px" />
                                                                                                    </expandcollapsecolumn>
                                                                                                    <Columns>
                                                                                                        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                            FilterControlAltText="Filter EditCommandColumn column">
                                                                                                            <HeaderStyle Width="1.5%" />
                                                                                                        </telerik:GridEditCommandColumn>
                                                                                                        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                            ConfirmDialogType="RadWindow" 
                                                                                                            ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                                                                                            ConfirmTitle="Mensaje de Confirmación" 
                                                                                                            FilterControlAltText="Filter column column" FilterImageUrl="~\img\delete.gif" 
                                                                                                            Text="Eliminar" UniqueName="column">
                                                                                                            <HeaderStyle Width="1.5%" />
                                                                                                        </telerik:GridButtonColumn>
                                                                                                        <telerik:GridBoundColumn DataField="Personal" 
                                                                                                            FilterControlAltText="Filter Personal column" HeaderText="Personal" 
                                                                                                            SortExpression="Personal" UniqueName="Personal">
                                                                                                            <HeaderStyle HorizontalAlign="Center" Width="37%" />
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </telerik:GridBoundColumn>
                                                                                                        <telerik:GridBoundColumn DataField="Vehiculo" DataType="System.Decimal" 
                                                                                                            FilterControlAltText="Filter Vehiculo column" HeaderText="Vehiculo" 
                                                                                                            SortExpression="Vehiculo" UniqueName="Vehiculo">
                                                                                                            <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </telerik:GridBoundColumn>
                                                                                                        <telerik:GridBoundColumn DataField="Conduce" DataFormatString="{0:N2}" 
                                                                                                            DataType="System.Decimal" FilterControlAltText="Filter Conduce column" 
                                                                                                            HeaderText="Conduce" SortExpression="Conduce" UniqueName="Conduce">
                                                                                                            <HeaderStyle HorizontalAlign="Center" Width="5%" />
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </telerik:GridBoundColumn>
                                                                                                        <telerik:GridBoundColumn DataField="Observacion" DataType="System.DateTime" 
                                                                                                            FilterControlAltText="Filter Observacion column" HeaderText="Observacion" 
                                                                                                            SortExpression="Observacion" UniqueName="Observacion">
                                                                                                            <HeaderStyle HorizontalAlign="Center" Width="40%" />
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </telerik:GridBoundColumn>
                                                                                                    </Columns>
                                                                                                    <editformsettings editformtype="WebUserControl" 
                                                                                                        usercontrolname="~\Monitoreo\Controles\ControlIntegrante.ascx">
                                                                                                        <editcolumn filtercontrolalttext="Filter EditCommandColumn column">
                                                                                                        </editcolumn>
                                                                                                    </editformsettings>
                                                                                                </mastertableview>
                                                                                                <filtermenu enableimagesprites="False">
                                                                                                </filtermenu>
                                                                                                <headercontextmenu cssclass="GridContextMenu GridContextMenu_Default">
                                                                                                </headercontextmenu>
                                                                                            </telerik:RadGrid>
                                                                                            </td></tr></table></telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView4" runat="server">
                                                                                        <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False" 
                                                                                            CellSpacing="0" DataSourceID="SqlDocumentos" GridLines="None" Skin="Hay">
                                                                                            <mastertableview clientdatakeynames="IdSustento" commanditemdisplay="Top" 
                                                                                                datakeynames="IdSustento" DataSourceID="SqlDocumentos" 
                                                                                                nomasterrecordstext="No existen registros.">
                                                                                                <commanditemsettings addnewrecordtext="Agregar Documento" 
                                                                                                    exporttopdftext="Export to PDF" showrefreshbutton="False" />
                                                                                                <rowindicatorcolumn filtercontrolalttext="Filter RowIndicator column">
                                                                                                </rowindicatorcolumn>
                                                                                                <expandcollapsecolumn filtercontrolalttext="Filter ExpandColumn column">
                                                                                                </expandcollapsecolumn>
                                                                                                <Columns>
                                                                                                    <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                        FilterControlAltText="Filter EditCommandColumn column">
                                                                                                        <HeaderStyle Width="1.5%" />
                                                                                                    </telerik:GridEditCommandColumn>
                                                                                                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                        ConfirmDialogType="RadWindow" 
                                                                                                        ConfirmText="¿Está seguro de Eliminar e Registro?" 
                                                                                                        ConfirmTitle="Mensaje de Confirmación" 
                                                                                                        FilterControlAltText="Filter column column" FilterImageUrl="~\img\delete.gif" 
                                                                                                        Text="Eliminar" UniqueName="column">
                                                                                                        <HeaderStyle Width="1.5%" />
                                                                                                    </telerik:GridButtonColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Nombre" 
                                                                                                        FilterControlAltText="Filter Nombre column" HeaderText="Nombre" ReadOnly="True" 
                                                                                                        SortExpression="Nombre" UniqueName="Nombre">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="32%" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Fecha" DataFormatString="{0:dd/MM/yyyy}" 
                                                                                                        DataType="System.DateTime" FilterControlAltText="Filter Fecha column" 
                                                                                                        HeaderText="Fecha" SortExpression="Fecha" UniqueName="Fecha">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                        <ItemStyle HorizontalAlign="Center" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Descripcion" 
                                                                                                        FilterControlAltText="Filter Descripcion column" HeaderText="Descripcion" 
                                                                                                        UniqueName="Descripcion">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="25%" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Archivo" DataType="System.DateTime" 
                                                                                                        FilterControlAltText="Filter FechaInicio column" HeaderText="Archivo" 
                                                                                                        SortExpression="Archivo" UniqueName="Archivo">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="30%" />
                                                                                                        <ItemStyle HorizontalAlign="Center" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Descargar" 
                                                                                                        FilterControlAltText="Filter descargar column" ImageUrl="~/img/OpenFile.gif" 
                                                                                                        Text="Abrir" UniqueName="descargar">
                                                                                                    </telerik:GridButtonColumn>
                                                                                                </Columns>
                                                                                                <editformsettings editformtype="WebUserControl" 
                                                                                                    usercontrolname="~\Monitoreo\Controles\ControlSustento.ascx">
                                                                                                    <editcolumn filtercontrolalttext="Filter EditCommandColumn column">
                                                                                                    </editcolumn>
                                                                                                </editformsettings>
                                                                                            </mastertableview>
                                                                                            <filtermenu enableimagesprites="False">
                                                                                            </filtermenu>
                                                                                            <headercontextmenu cssclass="GridContextMenu GridContextMenu_Hay">
                                                                                            </headercontextmenu>
                                                                                        </telerik:RadGrid>
                                                                                    </telerik:RadPageView>
                                                                               
                                                                                </telerik:RadMultiPage>    
                                                                                </td>
                                                    </tr>
    </table>

<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }
        function ValidarFecha() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarFecha");
        }
        function Foco() {
            document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDate1').value = '';

        }
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Mensaje");
        }
        function busque(sender, args) {
            var IdDetalleEje = args.getDataKeyValue("IdDetalleEje");
            var IdControl = args.getDataKeyValue("IdControl");
            radopen("FrmTarea.aspx?IdDetalleEje=" + IdDetalleEje + "&IdControl" + IdControl , "Formulario1");
            return false;
        }
        function CargarVentana(nombre) {
            aviso = open("/SistIntegral/Monitoreo/Adjuntos/" + nombre, "Documento", "status=no, directories=no, toolbar=no, width=800, height=500, left=100, top=100")
            //        window.open("../Archivos1/Logistica/" + nombre, nombre, "width=800, height=500")    
        }
        
         
         function openWin(IdDetalleEje) {
             var oWnd = radopen("Dialog4.aspx?IdDetalleEje=" + IdDetalleEje, "RadWindow1");
         }
         

       
            function OnClientClose(oWnd, args) {
            //get the transferred arguments
            var arg = args.get_argument();
            if (arg) {
                var fecha = arg.cityName;
                var IdControl = arg.idOC;
                var observacion = arg.observacion;

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Reprogramar|" + fecha + "|" + IdControl + "|" + observacion);
            }
        }
        function openWin1(IdDetalleEje) {
            var oWnd = radopen("Dialog5.aspx?IdDetalleEje=" + IdDetalleEje, "RadWindow2");
        }



        function OnClientClose1(oWnd, args) {
            //get the transferred arguments
            var arg = args.get_argument();
            if (arg) {
                
                var IdControl = arg.idOC;
                var observacion = arg.observacion;

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Cancelar|" + IdControl + "|" + observacion);

            }
        }
        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }
     </script>
    </telerik:RadCodeBlock>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid5" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadWindowManager1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid5" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>


    <asp:ObjectDataSource ID="OdsUbigeo" runat="server" 
        SelectMethod="GetUBIGEODATOSByParameter" 
        TypeName="SistFoncreagro.BussinesLogic.UbigeoDatosBL" 
        OldValuesParameterFormatString="original_{0}">
        <SelectParameters>
            <asp:Parameter DefaultValue="*" Name="texto" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    

                                                <asp:SqlDataSource ID="SqlEquipo" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetINTEGRANTEByIdDetalleEjeDetallado" 
                                                    SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdDetalleEje" QueryStringField="IdDetalleEje" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlControl" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetCONTROLByIdDetalleEjeDetallado" 
        SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="IdDetalleEje" QueryStringField="IdDetalleEje" 
                            Type="Int32" />
                    </SelectParameters>
    </asp:SqlDataSource>
                                                <asp:SqlDataSource ID="SqlDocumentos" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetSUSTENTOByIdDetalleEje" 
                                                    SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdDetalleEje" QueryStringField="IdDetalleEje" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                                                                    
     <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"   
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Formulario1" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" OnClientClose="Validar">
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
              <telerik:RadWindow ID="RadWindow1" runat="server" 
                Behaviors="Close" OnClientClose="OnClientClose" Width="1000px" AutoSize="True">
            </telerik:RadWindow>
             <telerik:RadWindow ID="RadWindow2" runat="server" 
                Behaviors="Close" OnClientClose="OnClientClose1" Width="1000px" AutoSize="True">
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
                                                                                    

                                                <asp:SqlDataSource ID="SqlVehiculos" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetVEHICULOByIdDetalleEje" 
                                                    SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdDetalleEje" QueryStringField="IdDetalleEje" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
   <telerik:RadCodeBlock ID="RadCodeBlock2" runat="server">
    <script type="text/javascript">
        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }
     
     </script>
    </telerik:RadCodeBlock>                                                              

                                                </asp:Content>


