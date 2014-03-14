<%@ Page Title="Control de Actividades/Tareas" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterMonitoreo1.master" CodeBehind="FrmControl.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmControl" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                                                <table 
        style="width: 100%">
                                                    <tr>
                                                        <td style="height: 30px">
                                                                                    
                                                                                <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                                                                                </telerik:RadWindowManager>
                                                                                    
                                                                                <telerik:RadTabStrip ID="RadTabStrip1" runat="server" 
                                                                                    MultiPageID="RadMultiPage1" SelectedIndex="0" Width="100%">
                                                                                    <Tabs>
                                                                                        <telerik:RadTab runat="server" Text="Información General" Selected="True">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Vehículos">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Equipo de Trabajo">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Documentación">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Control de Gastos">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Asistentes">
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
                                                                                                    ImageUrl="~/img/Grabar.gif" ToolTip="Grabar" /></td><td width="5%"><asp:ImageButton 
                                                                                                        ID="ImageButton4" runat="server" BorderColor="Gray" BorderStyle="Solid" 
                                                                                                        BorderWidth="0px" CausesValidation="False" ImageUrl="~/img/Nuevo.gif" 
                                                                                                        ToolTip="Nuevo" /></td><td style="text-align: right" width="80%">&nbsp;</td><td 
                                                                                                    style="text-align: left" width="10%">&nbsp;</td></tr></table></td></tr><tr><td><table 
                                                                                                cellspacing="0" class="0" style="width: 100%"><tr><td class="Texto"><table 
                                                                                                    style="width: 100%"><tr><td class="Texto" colspan="2" style="font-weight: 700" 
                                                                                                        width="12%">Datos de la Actividad o Tarea Realizada</td></tr><tr><td 
                                                                                                        width="12%">Fecha:</td><td width="88%">
                                                                                                        <asp:TextBox ID="txtDate" runat="server" AutoPostBack="True" TabIndex="1" 
                                                                                                            Width="70px" />
                                                                                                        <asp:MaskedEditExtender ID="MaskedEditExtender" runat="server" 
                                                                                                            AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                            TargetControlID="txtDate" />
                                                                                                        <asp:MaskedEditValidator ID="MaskedEditValidator" runat="server" 
                                                                                                            ControlExtender="MaskedEditExtender" ControlToValidate="txtDate" 
                                                                                                            Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                            InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" 
                                                                                                            ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator>
                                                                                                    </td></tr>
                                                                                                <tr>
                                                                                                    <td width="12%">
                                                                                                        Actividad/Tarea:</td>
                                                                                                    <td width="88%">
                                                                                                        <telerik:RadComboBox ID="RadComboBox6" Runat="server" DataSourceID="SqlTareas" 
                                                                                                            DataTextField="NomTarea" DataValueField="IdTarea" TabIndex="2" Width="100%">
                                                                                                        </telerik:RadComboBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                </table></td></tr><tr><td 
                                                                                                    class="Texto"><table style="width: 100%"><tr><td width="12%">Descripción:</td><td>
                                                                                                    <asp:TextBox 
                                                                                                        ID="TextBox5" runat="server" CssClass="Texto1" TabIndex="3" 
                                                                                                        TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" 
                                                                                                        ControlToValidate="TextBox5" Display="Dynamic" 
                                                                                                        ErrorMessage="¡Debe ingresar la Descripción!"></asp:RequiredFieldValidator>
                                                                                                    </td><td 
                                                                                                        style="text-align: right">Cantidad:</td><td>
                                                                                                        <telerik:RadNumericTextBox 
                                                                                                            ID="RadNumericTextBox2" Runat="server" Value="1" TabIndex="4"><incrementsettings 
                                                                                                            interceptarrowkeys="False" /></telerik:RadNumericTextBox>
                                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" 
                                                                                                            ControlToValidate="RadNumericTextBox2" Display="Dynamic" 
                                                                                                            ErrorMessage="¡Debe ingresar la Cantidad!"></asp:RequiredFieldValidator>
                                                                                                    </td></tr><tr><td 
                                                                                                            width="12%">Caserio:</td><td colspan="3">
                                                                                                            <telerik:RadComboBox ID="RadComboBox1" 
                                                                                                                Runat="server" DataTextField="Nombre" DataValueField="CUBIGEO" 
                                                                                                                EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                ShowDropDownOnTextboxClick="False" Skin="Hay" style="margin-left: 0px" 
                                                                                                                TabIndex="5" Width="80%"></telerik:RadComboBox>
                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                                ErrorMessage="¡Debe ingresar el Caserio!"></asp:RequiredFieldValidator>
                                                                                                        </td></tr><tr><td 
                                                                                                            width="12%">Jefe Familia:</td><td colspan="3">
                                                                                                            <telerik:RadComboBox 
                                                                                                                ID="RadComboBox7" Runat="server" Width="80%" TabIndex="6"></telerik:RadComboBox></td></tr><tr><td 
                                                                                                            colspan="4" style="font-weight: 700">Datos de Lectura Social</td></tr><tr><td 
                                                                                                            width="10%">Clima Social:</td><td width="38%">
                                                                                                            <asp:TextBox ID="TextBox8" 
                                                                                                                runat="server" CssClass="Texto1" TabIndex="7" TextMode="MultiLine" 
                                                                                                                Width="100%"></asp:TextBox></td><td style="text-align: right" 
                                                                                                            width="12%">Actitud:</td><td valign="middle" width="38%">
                                                                                                            <asp:DropDownList 
                                                                                                                ID="DropDownList4" runat="server" TabIndex="8"><asp:ListItem Value="APOYO TOTAL">APOYO TOTAL</asp:ListItem><asp:ListItem>APOYO MODERADO</asp:ListItem><asp:ListItem>NEUTRAL</asp:ListItem>
                                                                                                                <asp:ListItem Value="OPOSICON MODERADA">OPOSICION MODERADA</asp:ListItem>
                                                                                                                <asp:ListItem>OPOSICION RADICAL</asp:ListItem>
                                                                                                                <asp:ListItem>SIN DETERMINAR</asp:ListItem>
                                                                                                            </asp:DropDownList></td></tr><tr><td>Quejas o Reclamos:</td><td>
                                                                                                        <asp:TextBox 
                                                                                                            ID="TextBox9" runat="server" CssClass="Texto1" TabIndex="9" 
                                                                                                            TextMode="MultiLine" Width="100%"></asp:TextBox></td><td 
                                                                                                            style="text-align: right">Acciones Tomadas:</td><td>
                                                                                                            <asp:TextBox ID="TextBox10" 
                                                                                                                runat="server" CssClass="Texto1" TabIndex="10" TextMode="MultiLine" 
                                                                                                                Width="100%"></asp:TextBox></td></tr>
                                                                                                    <tr>
                                                                                                        <td>
                                                                                                            Observaciones:</td>
                                                                                                        <td>
                                                                                                            <asp:TextBox ID="TextBox11" runat="server" CssClass="Texto1" TabIndex="11" 
                                                                                                                TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                        </td>
                                                                                                        <td style="text-align: right">
                                                                                                            &nbsp;</td>
                                                                                                        <td>
                                                                                                            &nbsp;</td>
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
                                                                                        style="width: 100%"><tr><td><telerik:RadGrid ID="RadGrid1" runat="server" 
                                                                                                AutoGenerateColumns="False" CellSpacing="0" GridLines="None" Skin="Hay" 
                                                                                                DataSourceID="SqlEquipo">
                                                                                            <mastertableview 
                                                                                                clientdatakeynames="IdIntegrante" commanditemdisplay="Top" 
                                                                                                datakeynames="IdIntegrante" nomasterrecordstext="No existen registros." 
                                                                                                DataSourceID="SqlEquipo"><commanditemsettings 
                                                                                                addnewrecordtext="Agregar Miembro del Equipo" exporttopdftext="Export to PDF" 
                                                                                                refreshtext="Refrescar" showrefreshbutton="False" /><rowindicatorcolumn 
                                                                                                filtercontrolalttext="Filter RowIndicator column"><HeaderStyle 
                                                                                                Width="20px" /></rowindicatorcolumn><expandcollapsecolumn 
                                                                                                filtercontrolalttext="Filter ExpandColumn column"><HeaderStyle 
                                                                                                Width="20px" /></expandcollapsecolumn><Columns><telerik:GridEditCommandColumn 
                                                                                                    ButtonType="ImageButton" EditText="Editar" 
                                                                                                    FilterControlAltText="Filter EditCommandColumn column"><HeaderStyle 
                                                                                                    Width="1.5%" /></telerik:GridEditCommandColumn><telerik:GridButtonColumn 
                                                                                                    ButtonType="ImageButton" CommandName="Delete" ConfirmDialogType="RadWindow" 
                                                                                                    ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                                                                                    ConfirmTitle="Mensaje de Confirmación" 
                                                                                                    FilterControlAltText="Filter column column" FilterImageUrl="~\img\delete.gif" 
                                                                                                    Text="Eliminar" UniqueName="column"><HeaderStyle Width="1.5%" /></telerik:GridButtonColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                                    DataField="Personal" FilterControlAltText="Filter Personal column" 
                                                                                                    HeaderText="Personal" SortExpression="Personal" UniqueName="Personal">
                                                                                                        <HeaderStyle 
                                                                                                    HorizontalAlign="Center" Width="37%" /><ItemStyle 
                                                                                                    HorizontalAlign="Center" /></telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                                    DataField="EsResponsable" 
                                                                                                    FilterControlAltText="Filter EsResponsable column" HeaderText="Responsable" 
                                                                                                    SortExpression="EsResponsable" UniqueName="EsResponsable">
                                                                                                        <HeaderStyle 
                                                                                                    HorizontalAlign="Center" Width="5%" /><ItemStyle 
                                                                                                    HorizontalAlign="Center" /></telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                                    DataField="Vehiculo" DataType="System.Decimal" 
                                                                                                    FilterControlAltText="Filter Vehiculo column" HeaderText="Vehiculo" 
                                                                                                    SortExpression="Vehiculo" UniqueName="Vehiculo"><HeaderStyle 
                                                                                                    HorizontalAlign="Center" Width="10%" /><ItemStyle 
                                                                                                    HorizontalAlign="Center" /></telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                                    DataField="Conduce" DataFormatString="{0:N2}" DataType="System.Decimal" 
                                                                                                    FilterControlAltText="Filter Conduce column" HeaderText="Conduce" 
                                                                                                    SortExpression="Conduce" UniqueName="Conduce">
                                                                                                        <HeaderStyle 
                                                                                                    HorizontalAlign="Center" Width="5%" /><ItemStyle HorizontalAlign="Center" /></telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                                    DataField="Observacion" 
                                                                                                    DataType="System.DateTime" FilterControlAltText="Filter Observacion column" 
                                                                                                    HeaderText="Observacion" SortExpression="Observacion" UniqueName="Observacion">
                                                                                                        <HeaderStyle 
                                                                                                    HorizontalAlign="Center" Width="40%" /><ItemStyle 
                                                                                                    HorizontalAlign="Center" /></telerik:GridBoundColumn></Columns><editformsettings 
                                                                                                editformtype="WebUserControl" 
                                                                                                usercontrolname="~\Monitoreo\Controles\ControlIntegrante.ascx"><editcolumn 
                                                                                                filtercontrolalttext="Filter EditCommandColumn column"></editcolumn></editformsettings></mastertableview><filtermenu 
                                                                                                enableimagesprites="False"></filtermenu><headercontextmenu 
                                                                                                cssclass="GridContextMenu GridContextMenu_Default"></headercontextmenu></telerik:RadGrid></td></tr></table></telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView4" runat="server">
                                                                                        <telerik:RadGrid 
                                                                                        ID="RadGrid2" runat="server" AutoGenerateColumns="False" CellSpacing="0" 
                                                                                        GridLines="None" Skin="Hay" DataSourceID="SqlDocumentos">
                                                                                            <mastertableview 
                                                                                        clientdatakeynames="IdSustento" commanditemdisplay="Top" 
                                                                                        datakeynames="IdSustento" 
                                                                                        nomasterrecordstext="No existen registros." DataSourceID="SqlDocumentos"><commanditemsettings 
                                                                                        addnewrecordtext="Agregar Documento" exporttopdftext="Export to PDF" 
                                                                                        showrefreshbutton="False" /><rowindicatorcolumn 
                                                                                        filtercontrolalttext="Filter RowIndicator column"></rowindicatorcolumn><expandcollapsecolumn 
                                                                                        filtercontrolalttext="Filter ExpandColumn column"></expandcollapsecolumn><Columns><telerik:GridEditCommandColumn 
                                                                                            ButtonType="ImageButton" EditText="Editar" 
                                                                                            FilterControlAltText="Filter EditCommandColumn column"><HeaderStyle 
                                                                                            Width="1.5%" /></telerik:GridEditCommandColumn><telerik:GridButtonColumn 
                                                                                            ButtonType="ImageButton" CommandName="Delete" ConfirmDialogType="RadWindow" 
                                                                                            ConfirmText="¿Está seguro de Eliminar e Registro?" 
                                                                                            ConfirmTitle="Mensaje de Confirmación" 
                                                                                            FilterControlAltText="Filter column column" FilterImageUrl="~\img\delete.gif" 
                                                                                            Text="Eliminar" UniqueName="column"><HeaderStyle Width="1.5%" /></telerik:GridButtonColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                            DataField="Nombre" FilterControlAltText="Filter Nombre column" 
                                                                                            HeaderText="Nombre" ReadOnly="True" SortExpression="Nombre" 
                                                                                            UniqueName="Nombre"><HeaderStyle HorizontalAlign="Center" Width="32%" /></telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                            DataField="Archivo" 
                                                                                            DataType="System.DateTime" FilterControlAltText="Filter FechaInicio column" 
                                                                                            HeaderText="Archivo" SortExpression="Archivo" UniqueName="Archivo">
                                                                                                        <HeaderStyle 
                                                                                            HorizontalAlign="Center" Width="30%" /><ItemStyle 
                                                                                            HorizontalAlign="Center" /></telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                            DataField="Fecha" DataFormatString="{0:dd/MM/yyyy}" 
                                                                                            DataType="System.DateTime" FilterControlAltText="Filter Fecha column" 
                                                                                            HeaderText="Fecha" SortExpression="Fecha" UniqueName="Fecha"><HeaderStyle 
                                                                                            HorizontalAlign="Center" Width="10%" /><ItemStyle 
                                                                                            HorizontalAlign="Center" /></telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                            DataField="Descripcion" 
                                                                                            FilterControlAltText="Filter Descripcion column" 
                                                                                            HeaderText="Descripcion" UniqueName="Descripcion">
                                                                                                        <HeaderStyle Width="25%" />
                                                                                                    </telerik:GridBoundColumn></Columns><editformsettings 
                                                                                        editformtype="WebUserControl" 
                                                                                        usercontrolname="~\Monitoreo\Controles\ControlSustento.ascx"><editcolumn 
                                                                                        filtercontrolalttext="Filter EditCommandColumn column"></editcolumn></editformsettings></mastertableview><filtermenu 
                                                                                        enableimagesprites="False"></filtermenu><headercontextmenu 
                                                                                        cssclass="GridContextMenu GridContextMenu_Hay"></headercontextmenu></telerik:RadGrid></telerik:RadPageView>
                                                                               
                                                                                <telerik:RadPageView ID="RadPageView5" runat="server">
                                                                                    <telerik:RadGrid 
                                                                                        ID="RadGrid3" runat="server" AutoGenerateColumns="False" CellSpacing="0" 
                                                                                        GridLines="None" Skin="Hay" DataSourceID="SqlGastos" ShowFooter="True">
                                                                                        <mastertableview clientdatakeynames="IdInsumo" 
                                                                                        commanditemdisplay="Top" datakeynames="IdInsumo" 
                                                                                        nomasterrecordstext="No existen registros." DataSourceID="SqlGastos"><commanditemsettings 
                                                                                        addnewrecordtext="Agregar Gasto" exporttopdftext="Export to PDF" 
                                                                                        showrefreshbutton="False" /><rowindicatorcolumn 
                                                                                        filtercontrolalttext="Filter RowIndicator column"><HeaderStyle 
                                                                                        Width="20px" /></rowindicatorcolumn><expandcollapsecolumn 
                                                                                        filtercontrolalttext="Filter ExpandColumn column"><HeaderStyle 
                                                                                        Width="20px" /></expandcollapsecolumn><Columns><telerik:GridEditCommandColumn 
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
                                                                                                </telerik:GridButtonColumn>
                                                                                                <telerik:GridBoundColumn 
                                                                                            DataField="Descripcion" FilterControlAltText="Filter Descripcion column" 
                                                                                            HeaderText="Descripcion" SortExpression="Descripcion" UniqueName="Descripcion">
                                                                                                    <HeaderStyle 
                                                                                            HorizontalAlign="Center" Width="20%" /></telerik:GridBoundColumn>
                                                                                                <telerik:GridBoundColumn 
                                                                                            DataField="Cantidad" FilterControlAltText="Filter Cantidad column" 
                                                                                            HeaderText="Cantidad" SortExpression="Cantidad" UniqueName="Cantidad">
                                                                                                    <HeaderStyle 
                                                                                            HorizontalAlign="Center" Width="10%" /></telerik:GridBoundColumn>
                                                                                                <telerik:GridBoundColumn 
                                                                                            DataField="PrecioUnitario" DataType="System.DateTime" 
                                                                                            FilterControlAltText="Filter PrecioUnitario column" HeaderText="PrecioUnitario" 
                                                                                            SortExpression="PrecioUnitario" UniqueName="PrecioUnitario">
                                                                                                    <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                                    <HeaderStyle 
                                                                                            HorizontalAlign="Center" Width="10%" /><ItemStyle HorizontalAlign="Center" /></telerik:GridBoundColumn>
                                                                                                <telerik:GridBoundColumn 
                                                                                            DataField="Unidad" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter Unidad column" 
                                                                                            HeaderText="Unidad" ReadOnly="True" 
                                                                                            SortExpression="Unidad" UniqueName="Unidad">
                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                </telerik:GridBoundColumn>
                                                                                                <telerik:GridBoundColumn 
                                                                                            DataField="Observaciones" DataType="System.Int32" 
                                                                                            FilterControlAltText="Filter Observaciones column" HeaderText="Observaciones" 
                                                                                            SortExpression="Observaciones" UniqueName="Observaciones" Visible="False">
                                                                                                    <HeaderStyle Width="37%" />
                                                                                                </telerik:GridBoundColumn>
                                                                                                <telerik:GridCalculatedColumn Aggregate="Custom" 
                                                                                                    DataFields="PrecioUnitario,Cantidad" DataFormatString="{0:N2}" 
                                                                                                    Expression="{0}*{1}" FilterControlAltText="Filter Total column" 
                                                                                                    FooterAggregateFormatString="{0:N2}" HeaderText="Sub Total" UniqueName="Total">
                                                                                                    <FooterStyle Font-Bold="True" />
                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                                                </telerik:GridCalculatedColumn>
                                                                                            </Columns><editformsettings 
                                                                                        editformtype="WebUserControl" 
                                                                                        usercontrolname="~\Monitoreo\Controles\ControlInsumos.ascx"><editcolumn 
                                                                                        filtercontrolalttext="Filter EditCommandColumn column"></editcolumn></editformsettings></mastertableview><filtermenu 
                                                                                        enableimagesprites="False"></filtermenu><headercontextmenu 
                                                                                        cssclass="GridContextMenu GridContextMenu_Default"></headercontextmenu></telerik:RadGrid></telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView6" runat="server">
                                                                                        <telerik:RadGrid ID="RadGrid5" runat="server" AutoGenerateColumns="False" 
                                                                                            CellSpacing="0" DataSourceID="SqlAsistentes" GridLines="None" ShowFooter="True" 
                                                                                            Skin="Hay">
                                                                                            <mastertableview clientdatakeynames="IdAsistente,IdActitud" commanditemdisplay="Top" 
                                                                                                datakeynames="IdAsistente,IdActitud" DataSourceID="SqlAsistentes" 
                                                                                                nomasterrecordstext="No existen registros.">
                                                                                                <commanditemsettings addnewrecordtext="Agregar Asistente" 
                                                                                                    exporttopdftext="Export to PDF" showrefreshbutton="False" />
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
                                                                                                        FilterControlAltText="Filter column column" Text="Eliminar" UniqueName="column">
                                                                                                        <HeaderStyle Width="1.5%" />
                                                                                                    </telerik:GridButtonColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdAsistente" 
                                                                                                        FilterControlAltText="Filter IdAsistente column" HeaderText="IdAsistente" 
                                                                                                        SortExpression="IdAsistente" UniqueName="IdAsistente" 
                                                                                                        DataType="System.Int32" ReadOnly="True" Visible="False">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Asistente" 
                                                                                                        FilterControlAltText="Filter Asistente column" HeaderText="Asistente" 
                                                                                                        ReadOnly="True" SortExpression="Asistente" UniqueName="Asistente">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="35%" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Cargo" 
                                                                                                        FilterControlAltText="Filter Cargo column" HeaderText="Cargo" 
                                                                                                        SortExpression="Cargo" UniqueName="Cargo">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="27%" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Actitud" 
                                                                                                        FilterControlAltText="Filter Actitud column" HeaderText="Actitud" 
                                                                                                        SortExpression="Actitud" UniqueName="Actitud">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="35%" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                </Columns>
                                                                                                <editformsettings editformtype="WebUserControl" 
                                                                                                    usercontrolname="~\Monitoreo\Controles\ControlAsistente.ascx">
                                                                                                    <editcolumn filtercontrolalttext="Filter EditCommandColumn column">
                                                                                                    </editcolumn>
                                                                                                </editformsettings>
                                                                                            </mastertableview>
                                                                                            <filtermenu enableimagesprites="False">
                                                                                            </filtermenu>
                                                                                            <headercontextmenu cssclass="GridContextMenu GridContextMenu_Default">
                                                                                            </headercontextmenu>
                                                                                        </telerik:RadGrid>
                                                                                    </telerik:RadPageView>
                                                                                </telerik:RadMultiPage>    
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


        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Mensaje");
        }

        function ValidarFecha() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarFecha");

        }
        function CargarVentana(nombre) {
            aviso = open("/SistIntegral/Monitoreo/Adjuntos/" + nombre, "Documento", "status=no, directories=no, toolbar=no, width=800, height=500, left=100, top=100")
            //        window.open("../Archivos1/Logistica/" + nombre, nombre, "width=800, height=500")    
        }
     </script>
    </telerik:RadCodeBlock>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="txtDate">
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
    

                                                                                                                            <asp:SqlDataSource ID="SqlTareas" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="TareasPoaTecnico" SelectCommandType="StoredProcedure">
                                                                                                                                <SelectParameters>
                                                                                                                                    <asp:QueryStringParameter Name="idProyecto" QueryStringField="IdProyecto" 
                                                                                                                                        Type="Int32" />
                                                                                                                                </SelectParameters>
                                                </asp:SqlDataSource>
                                                                                                                            

                                                <asp:SqlDataSource ID="SqlEquipo" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetINTEGRANTEByIdControlDetallado" 
                                                    SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdControl" QueryStringField="IdControl" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                                                                        <asp:SqlDataSource ID="SqlAsistentes" runat="server" 
                                                                                            ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                                                            SelectCommand="GetASISTENTEByIdControlDetallado" 
                                                                                            
                                                    SelectCommandType="StoredProcedure">
                                                                                            <SelectParameters>
                                                                                                <asp:QueryStringParameter Name="IdControl" QueryStringField="IdControl" 
                                                                                                    Type="Int32" />
                                                                                            </SelectParameters>
                                                                                        </asp:SqlDataSource>
                                                <asp:SqlDataSource ID="SqlDocumentos" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetSUSTENTOByIdControl" SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdControl" QueryStringField="IdControl" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                                <asp:SqlDataSource ID="SqlGastos" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetINSUMOSByIdControl" SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdControl" QueryStringField="IdControl" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                                                                                                            

                                                <asp:SqlDataSource ID="SqlVehiculos" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetVEHICULOByIdControl" SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="idControl" QueryStringField="IdControl" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                                                                                                            

                                                </asp:Content>

