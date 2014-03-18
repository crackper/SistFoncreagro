<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmDatosConvenio.aspx.vb" Inherits="SistFoncreagro.WebSite.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
                    <script type="text/javascript">
                        function NuevoConveMarco(IdConvenio) {
                            var oWnd = radopen("FrmConvenioMarco.aspx?IdConvenio=" + IdConvenio, "AsignarConveMarco");
//                            var oWnd = radopen("FrmConvenioMarco.aspx", "NuevoMarco");
                            return false;
                        }
                        function CerrarRadWindow(oWnd, args) {
                            var arg = args.get_argument();
                            if (arg) {
                                if (arg.indicador >= 1) {
                                    $find("<%= AJAX_MANAGER.ClientID %>").ajaxRequest("ActualizarCombo|" + arg.indicador);
                                }
                            }
                        }
                </script>
     </telerik:RadCodeBlock>

                            <telerik:RadAjaxManager ID="AJAX_MANAGER" 
        runat="server">
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="AJAX_MANAGER">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="CbConveMarco" /></UpdatedControls></telerik:AjaxSetting></AjaxSettings></telerik:RadAjaxManager>
    <telerik:RadWindowManager ID="RadWindowManager1" 
                            runat="server" Skin="Vista">
                            <Windows>
                                <telerik:RadWindow ID="AsignarConveMarco" 
                                    runat="server" Behavior="Close" Behaviors="Close" Height="600px"
                                    InitialBehavior="Close" Left="" Modal="True" NavigateUrl="" OnClientClose="CerrarRadWindow"
                                    Skin="Vista" Style="display: none;" Top="" VisibleStatusbar="False"
                                    Width="900px" InitialBehaviors="Close"></telerik:RadWindow></Windows></telerik:RadWindowManager>

    <telerik:RadTabStrip ID="RadTabStrip1" runat="server"
        SelectedIndex="2" MultiPageID="Datos" Skin="Forest">
        <Tabs>
            <telerik:RadTab Text="Datos Generales">

            </telerik:RadTab>
            <telerik:RadTab Text="Desembolsos">
            </telerik:RadTab>
            <telerik:RadTab Text="Adenda" Selected="True">
            </telerik:RadTab>
        </Tabs>
    </telerik:RadTabStrip>
    <telerik:RadMultiPage ID="Datos" runat="server" SelectedIndex="2" 
        CssClass="Datos Generales">
        <telerik:RadPageView ID="RadPageView1" runat="server" Width="917px" 
            alt = "Datos Generales"><table class="Texto" style="width: 915px"><tr>
                <td align="left" class="style22" style="width: 117px">
                <asp:ImageButton ID="BtnGrabar" runat="server" CommandName="PerformInsert" 
                            ImageUrl="~/img/Grabar.gif" ToolTip="Insertar" />
                            <asp:ImageButton ID="BtnActualizar" runat="server" CommandName="Update" 
                            ImageUrl="~/img/Grabar.gif" ToolTip="Actualizar cambios" />
                </td><td class="style17">
                            <asp:HiddenField ID="HFIdConvenio" runat="server" />
                </td><td align="right" class="style19" style="width: 220px">&nbsp;</td><td class="style11" style="width: 336px">&nbsp;</td></tr><tr>
                <td align="right" class="style22" style="width: 117px">&nbsp;</td><td class="style13" style="width: 371px">
                <asp:CheckBox ID="ChConvenioMarco" runat="server" Text="Tiene Convenio Marco" 
                    AutoPostBack="True" />
                </td><td class="style17" style="width: 47px">&nbsp;</td><td align="right" class="style19" style="width: 220px">&nbsp;</td><td class="style11" style="width: 336px">&nbsp;</td></tr><tr>
                <td align="right" class="style22" style="width: 117px">
                    <asp:Label ID="LblConvenioMarco" runat="server" Text="Convenio Marco"></asp:Label>
                </td><td class="style13" colspan="3">
                <telerik:RadComboBox ID="CbConveMarco" Runat="server" 
                            DataSourceID="OdsConveMarco" DataTextField="Marco" 
                            DataValueField="IdConveMarco" Width="528px" 
                    EnableLoadOnDemand="True" Filter="Contains"></telerik:RadComboBox></td><td class="style11" style="width: 336px">
                        <asp:Button ID="Button2" runat="server" Text="..."/>
                    <asp:RequiredFieldValidator ID="RFVConvenioMarco" runat="server" 
                        ControlToValidate="CbConveMarco" ErrorMessage="Seleccione un Convenio Marco"></asp:RequiredFieldValidator>
                </td></tr><tr><td align="right" class="style22" style="width: 117px">&nbsp;</td><td class="style13" style="width: 371px">&nbsp;</td><td class="style17" style="width: 47px">&nbsp;</td><td align="right" class="style19" style="width: 220px">&nbsp;</td><td class="style11" style="width: 336px">&nbsp;</td></tr><tr>
                <td align="right" class="style22" style="width: 117px">Código:</td><td class="style13" style="width: 371px"><asp:TextBox ID="TxtCodigo" runat="server" MaxLength="10" 
                            style="text-transform:uppercase;"></asp:TextBox></td><td class="style17" style="width: 47px"></td><td align="right" class="style19" style="width: 220px">Estado:</td><td class="style11" style="width: 336px"><asp:DropDownList ID="CbEstado" runat="server"><asp:ListItem>IMPLEMENTACION</asp:ListItem><asp:ListItem>EJECUCION</asp:ListItem><asp:ListItem>ADENDA</asp:ListItem><asp:ListItem>CIERRE</asp:ListItem></asp:DropDownList></td></tr><tr>
                <td align="right" class="style22" style="width: 117px">Nombre:</td><td class="style13" style="width: 371px"><asp:TextBox ID="TxtNombre" runat="server" Height="56px" 
                            style="text-transform:uppercase;" TextMode="MultiLine" Width="370px"></asp:TextBox></td><td class="style17" style="width: 47px"></td><td align="right" class="style19" style="width: 220px">
                Firma:</td><td class="style11" style="width: 336px">
                    <telerik:RadDatePicker ID="DtFechaFirma" Runat="server" MinDate="1985-01-01">
                    </telerik:RadDatePicker>
                </td></tr><tr>
                    <td align="right" class="style22" style="width: 117px">Tipo:</td><td class="style13" style="width: 371px">
                    <asp:DropDownList ID="CbTipoConvenio" runat="server" 
                        DataSourceID="OdsTipoConvenio" DataTextField="Nombre" 
                        DataValueField="IdTipConv" Width="198px">
                    </asp:DropDownList>
                    </td><td class="style17" style="width: 47px"></td><td align="right" class="style19" style="width: 220px">
                    Inicio:</td><td class="style11" style="width: 336px">
                        <telerik:RadDatePicker ID="DTInicio" Runat="server">
                        </telerik:RadDatePicker>
                    </td><tr>
                <td </td="" align="right" class="style22" style="width: 117px">Moneda:<td class="style13" style="width: 371px">
                    <asp:DropDownList ID="CbMoneda" runat="server" 
                                DataSourceID="OdsMoneda" DataTextField="Nombre" 
                                DataValueField="IdMoneda" Width="195px"></asp:DropDownList></td><td class="style17" style="width: 47px"></td><td align="right" class="style19" style="width: 220px">
                    &nbsp;Fin:</td><td class="style11" style="width: 336px">
                        <telerik:RadDatePicker ID="DTFin" Runat="server"></telerik:RadDatePicker></td></tr><tr>
                <td align="right" class="style22" style="width: 117px">Monto Total:</td><td class="style13" style="width: 371px">
                    <telerik:RadNumericTextBox ID="TxtMontoIni" Runat="server">
                    </telerik:RadNumericTextBox>
                </td><td class="style17" style="width: 47px">&nbsp;</td><td align="right" class="style19" style="width: 220px">
                    Fase contractual:</td><td class="style11" style="width: 336px">
                        <asp:DropDownList ID="CbFase" runat="server">
                            <asp:ListItem>VIGENTE</asp:ListItem>
                            <asp:ListItem>POR VENCER</asp:ListItem>
                            <asp:ListItem>VENCIDO</asp:ListItem>
                        </asp:DropDownList>
                </td></tr><tr>
                    <td align="right" class="style23" style="width: 117px; height: 33px;">Instituciones:</td><td class="style14" style="width: 371px; height: 33px;">
                        &nbsp;</td><td class="style18" style="width: 47px; height: 33px;"></td><td align="right" class="style20" Financiador:</td="" 
                        style="width: 220px; height: 33px;"><td class="style24" style="width: 336px; height: 33px;"></td></td></tr><tr><td class="style21" colspan="5" style="height: 44px">&nbsp;&nbsp;<telerik:RadGrid 
                        ID="RGInstitucion" runat="server" AutoGenerateColumns="False" CellSpacing="0" 
                        DataSourceID="OdsInstitucion" GridLines="None" Width="689px" 
                        Skin="Windows7">
                    <MasterTableView ClientDataKeyNames="IdInstitucion" CommandItemDisplay="Top" 
                        DataKeyNames="IdInstitucion" DataSourceID="OdsInstitucion">
                        <CommandItemSettings AddNewRecordText="Agregar Institución" 
                            ExportToPdfText="Export to PDF" ShowRefreshButton="False" />
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px" />
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                            <HeaderStyle Width="20px" />
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                FilterControlAltText="Filter column column" HeaderText="Eliminar" 
                                ImageUrl="~/img/delete.gif" UniqueName="column">
                                <HeaderStyle Width="5%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="IdInstitucion" DataType="System.Int32" 
                                FilterControlAltText="Filter IdInstitucion column" HeaderText="IdInstitucion" 
                                SortExpression="IdInstitucion" UniqueName="IdInstitucion" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="NombreInstituciones" 
                                FilterControlAltText="Filter NombreInstituciones column" 
                                HeaderText="Instituciones" ReadOnly="True" SortExpression="NombreInstituciones" 
                                UniqueName="NombreInstituciones">
                                <HeaderStyle Width="85%" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Tipo" 
                                FilterControlAltText="Filter column1 column" HeaderText="Tipo" 
                                UniqueName="column1">
                                <HeaderStyle Width="10%" />
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings EditFormType="WebUserControl" 
                            UserControlName="~\Monitoreo\Controles\ControlInstConvenio.ascx">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                    </telerik:RadGrid>
                    <asp:ObjectDataSource ID="OdsInstitucion" runat="server" 
                        SelectMethod="GetInstitucionByIdConvenio" 
                        TypeName="SistFoncreagro.BussinesLogic.InstitucionBL">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="HFIdConvenio" Name="_id" PropertyName="Value" 
                                Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    </td></tr><tr><td class="style21" colspan="5" style="height: 61px"><asp:ObjectDataSource ID="OdsFinanciador" runat="server" 
                            SelectMethod="GetAllFromProveedorCliente" 
                            TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL"></asp:ObjectDataSource><asp:ObjectDataSource ID="OdsConvenio" runat="server" 
                            SelectMethod="GetFromConvenioById" 
                            TypeName="SistFoncreagro.BussinesLogic.ConvenioBL"><SelectParameters><asp:QueryStringParameter DefaultValue="0" Name="id" 
                                    QueryStringField="IdConvenio" Type="Int32" /></SelectParameters></asp:ObjectDataSource><asp:ObjectDataSource ID="OdsTipoConvenio" runat="server" 
                            SelectMethod="GetAllFromTipoConvenio" 
                            TypeName="SistFoncreagro.BussinesLogic.TipoConvenioBL"></asp:ObjectDataSource><asp:ObjectDataSource ID="OdsMoneda" runat="server" 
                            SelectMethod="GetAllFromMoneda" 
                            TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource><asp:ObjectDataSource 
                ID="OdsConveMarco" runat="server" 
                            SelectMethod="GetAllFromConveMarco" 
                            TypeName="SistFoncreagro.BussinesLogic.ConveMarcoBL"></asp:ObjectDataSource></td></tr></table>
          </telerik:RadPageView>
        <telerik:RadPageView ID="RadPageView2" runat="server"><table class="Texto"><tr>
            <td style="width: 873px">
            <asp:ImageButton ID="BtnNuevoDesem" runat="server" ImageUrl="~/img/Nuevo.gif" 
                ToolTip="Agregar nuevo Desembolso" />
            </td></tr>
            <tr>
                <td style="width: 873px; font-family: Arial; font-size: 9pt; font-weight: bold;">
                    CRONOGRAMA DE DESEMEBOLSOS:</td>
            </tr>
            <tr><td style="width: 873px; font-weight: bold; font-family: Arial; font-size: 9pt;"><asp:Panel ID="Panel4" runat="server">
                <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="OdsDesembolso" 
                    GridLines="None" PageSize="7" ShowFooter="True">
                    <GroupHeaderItemStyle BackColor="#FFFF99" />
                    <MasterTableView ClientDataKeyNames="IdDesembolso" DataKeyNames="IdDesembolso" 
                        DataSourceID="OdsDesembolso" ShowGroupFooter="True">
                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" 
                                FilterControlAltText="Filter column column" HeaderText="Editar" 
                                ImageUrl="~/img/edit.gif" UniqueName="column">
                                <HeaderStyle Width="5%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                FilterControlAltText="Filter column1 column" HeaderText="Eliminar" 
                                ImageUrl="~/img/delete.gif" UniqueName="column1">
                                <HeaderStyle Width="5%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="IdDesembolso" DataType="System.Int32" 
                                FilterControlAltText="Filter IdDesembolso column" HeaderText="IdDesembolso" 
                                SortExpression="IdDesembolso" UniqueName="IdDesembolso" Visible="False">
                                <HeaderStyle Width="0%" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Numero" DataType="System.Byte" 
                                FilterControlAltText="Filter Numero column" HeaderText="Numero" 
                                SortExpression="Numero" UniqueName="Numero">
                                <HeaderStyle Width="5%" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="_ProveedorCliente.RazonSocial" 
                                FilterControlAltText="Filter Institucion column" HeaderText="Institución" 
                                UniqueName="Institucion">
                                <HeaderStyle Width="20%" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn Aggregate="Sum" DataField="MontoProg" DataType="System.Decimal" 
                                FilterControlAltText="Filter MontoProg column" HeaderText="Monto Prog." 
                                SortExpression="MontoProg" UniqueName="MontoProg" 
                                DataFormatString="{0:0,0.00}">
                            </telerik:GridBoundColumn>
                            <telerik:GridTemplateColumn FilterControlAltText="Filter FechaProg column" 
                                HeaderText="Fec. Prog." UniqueName="FechaProg">
                                <ItemTemplate>
                                    <asp:Label ID="LblFeProg" runat="server" 
                                        Text='<%# ValidarFecha(DataBinder.Eval(Container.DataItem,"FechaProg")) %>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridBoundColumn DataField="MontoEjec" 
                                FilterControlAltText="Filter MontoEjec column" HeaderText="Monto Ejec." 
                                SortExpression="MontoEjec" UniqueName="MontoEjec" Aggregate="Sum" 
                                DataFormatString="{0:0,0.00}" DataType="System.Decimal">
                                <HeaderStyle Width="13%" />
                            </telerik:GridBoundColumn>
                            <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
                                HeaderText="Fec. Ejec" UniqueName="FechaEjec">
                                <ItemTemplate>
                                    <asp:Label ID="LblFeProg" runat="server" 
                                        Text='<%# ValidarFecha(DataBinder.Eval(Container.DataItem,"FechaProg")) %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle Width="14%" />
                                <ItemTemplate>
                                    <asp:Label ID="LblFeEjec" runat="server" 
                                        Text='<%# ValidarFecha(DataBinder.Eval(Container.DataItem,"FechaEjec")) %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle Width="13%" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridBoundColumn DataField="Estado" 
                                FilterControlAltText="Filter Estado column" HeaderText="Estado" 
                                SortExpression="Estado" UniqueName="Estado">
                                <HeaderStyle Width="13%" />
                                <HeaderStyle Width="12%" />
                            </telerik:GridBoundColumn>
                        </Columns>
                        
                        <GroupByExpressions>
                            <telerik:GridGroupByExpression>
                                <GroupByFields>
                                    <telerik:GridGroupByField FieldAlias="Anio" FieldName="Anio" FormatString="" 
                                        HeaderText="" />
                                </GroupByFields>
                                <SelectFields>
                                    <telerik:GridGroupByField FieldName = "Anio" /> 
                                </SelectFields>
                            </telerik:GridGroupByExpression>
                        </GroupByExpressions>
                        
                        <EditFormSettings>
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                        <GroupHeaderItemStyle BorderStyle="Solid" />
                        <FooterStyle BackColor="#0099CC" BorderStyle="Solid" />
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsDesembolso" runat="server" 
                                SelectMethod="GetFromDesembolsoByIdConvenio" 
                                TypeName="SistFoncreagro.BussinesLogic.DesembolsoBL"><SelectParameters>
                        <asp:QueryStringParameter DefaultValue="" Name="_id" 
                                        QueryStringField="IdConvenio" Type="Int32" /></SelectParameters></asp:ObjectDataSource></asp:Panel>
                <asp:Panel ID="PanelDesem" runat="server" Visible="False">
                    <table class="Texto" style="width: 100%">
                        <tr>
                            <td style="width: 106px">
                                <asp:ImageButton ID="BtnAceptarDesem" runat="server"
                                    ImageUrl="~/Img/grabar.gif" ToolTip="Aceptar"  />
                                <asp:ImageButton ID="BtnActDesem" runat="server" ImageUrl="~/img/Grabar.gif" />
                                <asp:ImageButton ID="BtnCancelDesem" runat="server" Height="25px" 
                                    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar acción" />
                            </td>
                            <td style="width: 317px">
                                <asp:TextBox ID="TxtIdDesem" runat="server" Visible="False"></asp:TextBox>
                            </td>
                            <td style="width: 87px">
                                &nbsp;</td>
                            <td style="width: 106px">
                                &nbsp;</td>
                            <td>
                                <telerik:RadNumericTextBox ID="TxtNumDesem" Runat="server" 
                                    DataType="System.Int32" Enabled="False" Visible="False">
                                    <NumberFormat DecimalDigits="0" GroupSeparator="" />
                                </telerik:RadNumericTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 106px">
                                Institución:</td>
                            <td style="width: 317px">
                                <asp:DropDownList ID="CbInstitucionDesem" runat="server" 
                                    DataSourceID="OdsInstitucionDesem" DataTextField="NombreInstituciones" 
                                    DataValueField="IdProveedorCliente" Width="295px">
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="OdsInstitucionDesem" runat="server" 
                                    SelectMethod="GetInstitucionByIdConvenio" 
                                    TypeName="SistFoncreagro.BussinesLogic.InstitucionBL">
                                    <SelectParameters>
                                        <asp:QueryStringParameter Name="_id" QueryStringField="IdConvenio" 
                                            Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                            <td style="width: 87px">
                                &nbsp;</td>
                            <td align="right" style="width: 106px">
                                Monto Desembolsado:</td>
                            <td>
                                <telerik:RadNumericTextBox ID="TxtMontoEjec" Runat="server" Enabled="False">
                                </telerik:RadNumericTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 106px">
                                Monto Programado:</td>
                            <td style="width: 317px">
                                <telerik:RadNumericTextBox ID="TxtMontoDesem" Runat="server">
                                </telerik:RadNumericTextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ControlToValidate="TxtMontoDesem" ErrorMessage="Ingrese el monto"></asp:RequiredFieldValidator>
                            </td>
                            <td style="width: 87px">
                                &nbsp;</td>
                            <td align="right" style="width: 106px">
                                Fecha Desembolso:</td>
                            <td>
                                <telerik:RadDatePicker ID="DtFecEjec" Runat="server" MinDate="1985-01-01" 
                                    Enabled="False">
                                </telerik:RadDatePicker>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 106px">
                                Fecha Programada:</td>
                            <td style="width: 317px">
                                <telerik:RadDatePicker ID="DtFeDesem" Runat="server" MinDate="1985-01-01">
                                </telerik:RadDatePicker>
                            </td>
                            <td style="width: 87px">
                                &nbsp;</td>
                            <td align="right" style="width: 106px">
                                Estado:</td>
                            <td>
                                <asp:DropDownList ID="CbEstadoDesem" runat="server">
                                    <asp:ListItem>SOLICITADO</asp:ListItem>
                                    <asp:ListItem>DESEMBOLSADO</asp:ListItem>
                                    <asp:ListItem>PENDIENTE</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 106px">
                                &nbsp;</td>
                            <td style="width: 317px">
                                &nbsp;</td>
                            <td style="width: 87px">
                                &nbsp;</td>
                            <td style="width: 106px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
                OBSERVACIONES:<br /></td></tr><tr><td style="width: 873px">
                <telerik:RadGrid ID="RGObs" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="OdsObservacion" GridLines="None" 
                    AllowPaging="True" PageSize="5" Skin="Windows7">
                    <MasterTableView ClientDataKeyNames="IdObservacion" CommandItemDisplay="Top" 
                        DataKeyNames="IdObservacion" DataSourceID="OdsObservacion">
                        <CommandItemSettings AddNewRecordText="Agregar Observacion" 
                            ExportToPdfText="Export to PDF" />
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px" />
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                            <HeaderStyle Width="20px" />
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Edit" 
                                FilterControlAltText="Filter column1 column" HeaderText="Editar" 
                                ImageUrl="~/img/edit.gif" UniqueName="column1">
                                <HeaderStyle Width="7%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                FilterControlAltText="Filter column column" HeaderText="Eliminar" 
                                ImageUrl="~/img/delete.gif" UniqueName="column">
                                <HeaderStyle Width="7%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="IdObservacion" DataType="System.Int32" 
                                FilterControlAltText="Filter IdObservacion column" HeaderText="IdObservacion" 
                                SortExpression="IdObservacion" UniqueName="IdObservacion" Visible="False">
                                <HeaderStyle Width="0%" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Observacion" 
                                FilterControlAltText="Filter Observacion column" HeaderText="Observacion" 
                                SortExpression="Observacion" UniqueName="Observacion">
                                <HeaderStyle HorizontalAlign="Center" Width="86%" />
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings EditFormType="WebUserControl" 
                            UserControlName="~\Monitoreo\Controles\ControlObservacionConvenio.ascx">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsObservacion" runat="server" 
                    SelectMethod="GetObservacionByIdAndTabla" 
                    TypeName="SistFoncreagro.BussinesLogic.ObservacionBL">
                    <SelectParameters>
                        <asp:QueryStringParameter DefaultValue="" Name="_id" 
                            QueryStringField="IdConvenio" Type="Int32" />
                        <asp:Parameter DefaultValue="CONVENIO" Name="_Tabla" 
                            Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                </td></tr>
            <tr>
                <td style="width: 873px">
                    &nbsp;</td>
            </tr>
            </table></telerik:RadPageView>
        <telerik:RadPageView ID="RadPageView3" runat="server"><table class="Texto"><tr><td>
            <asp:ImageButton ID="BtnNuevoAd" runat="server" CommandName="PerformInsert" 
                ImageUrl="~/img/Nuevo.gif" ToolTip="Nuevo" />
            </td></tr><tr><td>
            <asp:Panel ID="Panel5" runat="server">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="OdsAdenda" EnableModelValidation="True" Width="879px" 
                    DataKeyNames="IdAdenda" OnSelectedIndexChanged="SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="Editar" ShowHeader="False">
                            <ItemTemplate>
                                <asp:ImageButton ID="BtnEditarAd" runat="server" CausesValidation="False" 
                                    CommandName="Select" ImageUrl="~/img/edit.gif" ToolTip="Editar Adenda" />
                            </ItemTemplate>
                            <HeaderStyle Width="4%" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Eliminar" ShowHeader="False">
                            <ItemTemplate>
                                <asp:ImageButton ID="BtnEliminarAd" runat="server" CausesValidation="False" 
                                    CommandName="BorrarAd" ImageUrl="~/img/delete.gif" 
                                    ToolTip = "Eliminar Adenda" 
                                    CommandArgument='<%# databinder.eval(container.dataitem,"IdAdenda") %>' 
                                     />
                            </ItemTemplate>
                            <HeaderStyle Width="5%" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="IdAdenda" HeaderText="IdAdenda" 
                            SortExpression="IdAdenda" Visible="False" />
                        <asp:BoundField DataField="IdConvenio" HeaderText="IdConvenio" 
                            SortExpression="IdConvenio" Visible="False" />
                        <asp:BoundField DataField="Numero" HeaderText="Nro" SortExpression="Numero">
                        <HeaderStyle Width="3%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Motivo" HeaderText="Justificación" 
                            SortExpression="Motivo">
                        <HeaderStyle Width="48%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Monto" SortExpression="Monto">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Monto") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    Text='<%# validarNumero(DataBinder.Eval(Container.DataItem,"Monto")) %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="9%" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Inicio" SortExpression="VigenciaIni">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("VigenciaIni") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" 
                                    Text='<%# ValidarFecha(DataBinder.Eval(Container.DataItem, "VigenciaIni")) %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="9%" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fin" SortExpression="VigenciaFin">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("VigenciaFin") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" 
                                    Text='<%# ValidarFecha(DataBinder.Eval(Container.DataItem, "VigenciaFin")) %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="9%" />
                        </asp:TemplateField>
                        <asp:CheckBoxField DataField="Costo" HeaderText="Tipo Cst." 
                            SortExpression="Costo">
                        <HeaderStyle Width="6%" />
                        </asp:CheckBoxField>
                        <asp:CheckBoxField DataField="Tiempo" HeaderText="Tipo Tpo." 
                            SortExpression="Tiempo">
                        <HeaderStyle Width="6%" />
                        </asp:CheckBoxField>
                        <asp:CheckBoxField DataField="Alcance" HeaderText="Tipo Alc." 
                            SortExpression="Alcance">
                        <HeaderStyle Height="6%" />
                        </asp:CheckBoxField>
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="OdsAdenda" runat="server" 
                    SelectMethod="GetFromAdendaByIdConvenio" 
                    TypeName="SistFoncreagro.BussinesLogic.AdendaBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="_id" QueryStringField="IdConvenio" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </asp:Panel>
            </td></tr><tr><td>&nbsp;</td></tr><tr><td>
            <asp:Panel ID="PanelAdenda" runat="server"><table class="Texto"><tr><td style="width: 114px">
            <asp:ImageButton ID="BtnGrabarAd" runat="server" ImageUrl="~/img/Grabar.gif" />
            <asp:ImageButton ID="BtnCancelAd" runat="server" ImageUrl="~/img/Cancel.gif" 
                Width="25px" />
            </td>
            <td style="width: 400px">&#160;</td><td style="width: 327px">&#160;</td></tr>
            <tr>
                <td style="width: 114px">
                    &nbsp;</td>
                <td style="width: 400px">
                    <strong>Tipo:</strong></td>
                <td style="width: 327px">
                    <asp:TextBox ID="TxtIdAdenda" runat="server" Visible="False"></asp:TextBox>
                </td>
            </tr>
            <tr><td style="width: 114px"><asp:CheckBox ID="ChCosto" runat="server" Text="Costo" 
                    AutoPostBack="True" /></td>
                <td style="width: 400px">&nbsp;<asp:Panel ID="PanelAdCosto" runat="server">
                    <asp:Label ID="Label3" runat="server" Text="Monto a agregar"></asp:Label>
                    :&nbsp;
                    <telerik:RadNumericTextBox ID="TxtMontoAd" Runat="server">
                    </telerik:RadNumericTextBox>
                    </asp:Panel>
</td>
                <td style="width: 327px">&#160;</td></tr><tr>
                <td style="width: 114px; height: 28px;"><asp:CheckBox ID="ChTiempo" runat="server" 
                        Text="Tiempo" AutoPostBack="True" /></td>
            <td style="width: 400px; height: 28px;">&nbsp;<asp:Panel ID="PanelAdTiempo" 
                    runat="server">
                <asp:Label ID="LblFecha" runat="server" Text="Fecha Final:"></asp:Label>
                <telerik:RadDatePicker ID="DtFeFinAd" Runat="server">
                </telerik:RadDatePicker>
                </asp:Panel>
                </td>
            <td style="width: 327px; height: 28px;"></td></tr>
            <tr>
                <td style="width: 114px">
                    &nbsp;</td>
                <td style="width: 400px">
                    &nbsp;</td>
                <td style="width: 327px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 114px">
                    <asp:CheckBox ID="ChAlcance" runat="server" Text="Alcance" 
                        AutoPostBack="True" />
                </td>
                <td colspan="2">
                    <asp:Panel ID="PanelAdAlcance" runat="server">
                        <table style="width: 100%">
                            <tr>
                                <td style="width: 395px">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 395px">
                                    <asp:FileUpload ID="FileUploadControl" runat="server" Width="364px" 
                                        ToolTip="Adjuntar POA" />
                                    <asp:TextBox ID="TxtDescAd" runat="server" TextMode="MultiLine" Width="324px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 395px">
                                    <asp:Panel ID="Panel6" runat="server">
                                        <br />
                                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                            DataKeyNames="IdAdjMonit" DataSourceID="OdsAdendaAdjunto" 
                                            EnableModelValidation="True" Width="721px"  OnSelectedIndexChanged="SelectedIndexChanged1">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Ver" ShowHeader="False">
                                                    <ItemStyle HorizontalAlign="Center" />
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="BtnVerAd" runat="server" CausesValidation="False" 
                                                            CommandName="Select" ImageUrl="~/img/OpenFile.gif" Tooltip = "ver" 
                                                            onclick="BtnVerAd_Click" />
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="8%" />
                                                </asp:TemplateField>                                           



                                                <asp:CommandField ButtonType="Image" EditImageUrl="~/img/Delete.gif" 
                                                    HeaderText="Eliminar" ShowEditButton="True" >
                                                <HeaderStyle Width="8%" />
                                                </asp:CommandField>
                                                <asp:BoundField DataField="IdAdjMonit" HeaderText="IdAdjMonit" 
                                                    SortExpression="IdAdjMonit" Visible="False" >
                                                <HeaderStyle Width="0%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Ruta" HeaderText="Archivo" SortExpression="Ruta" >
                                                <HeaderStyle Width="26%" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" 
                                                    SortExpression="Descripcion" >
                                                <HeaderStyle Width="58%" />
                                                </asp:BoundField>
                                            </Columns>
                                        </asp:GridView>
                                        <asp:ObjectDataSource ID="OdsAdendaAdjunto" runat="server" 
                                            SelectMethod="GetADJMONITByIdAndTabla" 
                                            TypeName="SistFoncreagro.BussinesLogic.AdjMonitBL">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="TxtIdAdenda" Name="_Id" PropertyName="Text" 
                                                    Type="Int32" />
                                                <asp:Parameter DefaultValue="ADENDA" Name="_Tabla" Type="String" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr><td colspan="3">
                <hr />
                </td></tr><tr><td style="width: 114px">&#160;</td><td style="width: 400px">
                <strong>Datos Adenda:</strong></td><td style="width: 327px">&nbsp;</td></tr>
            <tr>
                <td style="width: 114px" align="right">
                    Número:</td>
                <td style="width: 400px">
                    &nbsp;<asp:TextBox ID="TxtNumAd" runat="server" Width = "60px" Enabled="False"></asp:TextBox>
                </td>
                <td style="width: 327px">
                    Firma:
                    <telerik:RadDatePicker ID="DtFirmaAd" Runat="server">
                    </telerik:RadDatePicker>
                </td>
            </tr>
            <tr><td style="width: 114px" align="right">Justificación:</td><td style="width: 400px">
                &nbsp;<asp:TextBox ID="TxtJustif" runat="server" TextMode="MultiLine" Width="340px"
                style="text-transform:uppercase;"></asp:TextBox></td>
                <td style="width: 327px">Vigencia Inicio:&nbsp; <telerik:RadDatePicker ID="DtFeIniVigAd" 
                        Runat="server"></telerik:RadDatePicker></td></tr><tr>
            <td style="width: 114px" align="right">Responsable:</td>
            <td style="width: 400px">&nbsp;<asp:TextBox ID="TxtRespAd" runat="server" 
                    Width="340px" style="text-transform:uppercase;"></asp:TextBox></td>
            <td style="width: 327px">&nbsp;&nbsp;&nbsp;Vigencia Fin:&nbsp; <telerik:RadDatePicker ID="DtFeFinVigAd" 
                    Runat="server"></telerik:RadDatePicker>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="DtFeIniVigAd" ControlToValidate="DtFeFinVigAd" 
                    ErrorMessage="Debe ser mayor a inicio" Operator="GreaterThanEqual"></asp:CompareValidator>
                    </td></tr><tr><td>&#160;</td>
            <td style="width: 400px">&#160;</td></tr><tr><td>&#160;</td>
            <td style="width: 400px">&#160;</td></tr></table></asp:Panel></td></tr></table></telerik:RadPageView>
    </telerik:RadMultiPage>








            </asp:Content>
