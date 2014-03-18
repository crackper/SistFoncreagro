<%@ Page Title="Rendición de Fondo Fijo" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmRendicion.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmRecibo" %>
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
                                                <table align="center" class="tabla3">
                                                    <tr>
                                                        <td>
                                                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                                                    <tr>
                                                        <td>
                                                            Rendición de fondo fijo</td>
                                                       
                                                        <td style="text-align: right">
                

        


                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar" CausesValidation="False" 
                                                                PostBackUrl="~/Contabilidad/Formularios/ListaRendiciones.aspx" />
                

        


                                                            </td>
                                                       
                                                    </tr>
                                                </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <table style="width: 120px">
                                                                <tr>
                                                                    <td >
                                                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                                ToolTip="Grabar" BorderColor="Gray" BorderStyle="Solid" 
                                                                BorderWidth="0px" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/img/Nuevo.gif" 
                                                                ToolTip="Nuevo" BorderColor="Gray" BorderStyle="Solid" BorderWidth="0px" 
                                                                CausesValidation="False" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/img/Aceptar.gif" 
                                                                            ToolTip="Enviar" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/img/Buscar.gif" 
                                                                            ToolTip="Ver el Reporte" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="Texto" style="font-weight: 700">
                                                                    Datos Generales:</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="eeb">
                                                                                    <tr class="Texto" __designer:mapid="eec">
                                                                                        <td width="10%" __designer:mapid="eed">
                                                                                            Op. Finan.:</td>
                                                                                        <td width="32%" __designer:mapid="eee">
                                                                                            <telerik:RadComboBox ID="RadComboBox5" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsOpFinanciera" DataTextField="Descripcion" 
                                                                                                DataValueField="IdOpFinanciera" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                Width="98%" Enabled="False">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ef0">
                                                                                            SubDiario:</td>
                                                                                        <td width="34%" __designer:mapid="ef1">
                                                                                            <telerik:RadComboBox ID="RadComboBox4" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsSubDiario" DataTextField="Descripcion" 
                                                                                                DataValueField="IdSubDiario" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                Width="95%" Enabled="False">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ef3">
                                                                                            Codigo:</td>
                                                                                        <td width="8%" __designer:mapid="ef4">
                                                                                            <telerik:RadTextBox ID="RadTextBox1" Runat="server" Enabled="False" 
                                                                                                ReadOnly="True" Width="70px">
                                                                                            </telerik:RadTextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="ef6">
                                                                                        <td colspan="6" style="font-size: 3pt" __designer:mapid="ef7">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="efa">
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td width="10%" __designer:mapid="efc">
                                                                                            Proyecto:</td>
                                                                                        <td width="74%" __designer:mapid="efd">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox3" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Proyecto!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="f00">
                                                                                            Fecha :</td>
                                                                                        <td width="8%" __designer:mapid="f01">
                                                                                            <asp:TextBox ID="txtDate" runat="server" Width="70px" Enabled="False" />
                                                                                             <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                TargetControlID="txtDate" />
                                                                                            <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                                                ClientIDMode="AutoID" ControlExtender="MaskedEditExtender1" 
                                                                                                ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                EmptyValueMessage="Ingrese la Fecha" InvalidValueMessage="¡Fecha Incorrecta!" 
                                                                                                ValidationGroup="Transaccion" />
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
                                                                                        <td width="10%" __designer:mapid="f30">
                                                                                            Responsable Caja:</td>
                                                                                        <td width="72%" __designer:mapid="f31">
                                                                                            
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" AllowCustomText="True" DataTextField="NombreProveedor" 
                                                                                                DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" ValidationGroup="Transaccion" Width="100%">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                                                ControlToValidate="RadComboBox8" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Responsable de Caja!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="18%" __designer:mapid="f31" style="text-align: left">
                                                                                            <asp:ImageButton ID="ImageButton7" runat="server" ImageAlign="Middle" 
                                                                                                ImageUrl="~/img/Agregar.gif" ToolTip="Registrar Cliente" 
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
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td width="10%" __designer:mapid="efc">
                                                                                            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Observación:" 
                                                                                                Visible="False"></asp:Label>
                                                                                        </td>
                                                                                        <td width="74%" __designer:mapid="efd">
                                                                                            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Label" 
                                                                                                Visible="False"></asp:Label>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="f00">
                                                                                            &nbsp;</td>
                                                                                        <td width="8%" __designer:mapid="f01">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                     
                                                                                   
                                                                                    <tr class="Texto" __designer:mapid="f11">
                                                                                        <td colspan="4" style="font-size: 3pt" __designer:mapid="f12">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                        </td>
                                                    </tr>
                                                    <tr class="Texto">
                                                        <td style="text-align: left; font-weight: 700;">
                                                                            <asp:Label ID="Label3" runat="server" Text="Recibos Pendientes:" 
                                                                                Visible="False"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: center">
                                                                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                                                                CellSpacing="0" DataSourceID="odsRecibos" GridLines="None" Skin="Hay" 
                                                                                style="text-align: right">
<MasterTableView DataSourceID="odsRecibos" NoDetailRecordsText="No existen registros." NoMasterRecordsText="No existen registros.">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        RefreshImageUrl="~\img\cancel.gif" RefreshText="" 
        ShowAddNewRecordButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Monto" DataType="System.Decimal" 
            FilterControlAltText="Filter Monto column" HeaderText="Monto" 
            SortExpression="Monto" UniqueName="Monto">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Right" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Fecha" DataType="System.DateTime" 
            FilterControlAltText="Filter Fecha column" HeaderText="Fecha" 
            SortExpression="Fecha" UniqueName="Fecha" 
            DataFormatString="{0:dd/MM/yyyy}">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Glosa" 
            FilterControlAltText="Filter Glosa column" HeaderText="Glosa" 
            SortExpression="Glosa" UniqueName="Glosa">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Left" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="EntregadoA" 
            FilterControlAltText="Filter EntregadoA column" HeaderText="Entregado A" 
            ReadOnly="True" SortExpression="EntregadoA" UniqueName="EntregadoA">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Left" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdRecibo" DataType="System.Int32" 
            FilterControlAltText="Filter IdRecibo column" HeaderText="IdRecibo" 
            SortExpression="IdRecibo" UniqueName="IdRecibo" Visible="False">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                                                                            </telerik:RadGrid>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: left; font-weight: 700;" class="Texto">
                                                                            Recibos rendidos:</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: center">
                                                                            <telerik:RadGrid ID="RadGrid2" runat="server" CellSpacing="0" 
                                                                                DataSourceID="SqlRecibosRendicion" GridLines="None" Skin="Hay" 
                                                                                AutoGenerateColumns="False" ShowFooter="True">
<MasterTableView DataSourceID="SqlRecibosRendicion" NoDetailRecordsText="No existen registros." NoMasterRecordsText="No existen registros." 
                                                                                    ClientDataKeyNames="IdReciboRendicion" DataKeyNames="IdReciboRendicion" 
                                                                                    Name="Recibos">
    <DetailTables>
        <telerik:GridTableView runat="server" ClientDataKeyNames="IdDocRendido" 
            CommandItemDisplay="Top" DataKeyNames="IdDocRendido" 
            DataSourceID="odsDocumentoRendido" Name="Documentos" 
            NoDetailRecordsText="No existen documentos" 
            NoMasterRecordsText="No existen documentos.">
            <ParentTableRelation>
                <telerik:GridRelationFields DetailKeyField="IdReciboRendicion" 
                    MasterKeyField="IdReciboRendicion" />
            </ParentTableRelation>
            <CommandItemSettings AddNewRecordText="Agregar Documento" 
                ExportToPdfText="Export to PDF" RefreshText="Refrescar" />
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                <HeaderStyle Width="20px" />
            </RowIndicatorColumn>
            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                <HeaderStyle Width="20px" />
            </ExpandCollapseColumn>
            <Columns>
                <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                    FilterControlAltText="Filter EditCommandColumn column" UniqueName="editar">
                    <HeaderStyle Width="3%" />
                </telerik:GridEditCommandColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                    ConfirmDialogType="RadWindow" 
                    ConfirmText="¿Está seguro que desea eliminar el Documento?" ConfirmTitle="Mensaje de Confirmación" 
                    FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
                    Text="Eliminar" UniqueName="eliminar">
                </telerik:GridButtonColumn>
                <telerik:GridBoundColumn DataField="Proveedor" 
                    FilterControlAltText="Filter IdProveedorCliente column" 
                    HeaderText="Proveedor" UniqueName="Proveedor">
                    <HeaderStyle HorizontalAlign="Center" Width="30%" />
                    <ItemStyle HorizontalAlign="Left" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Serie" 
                    FilterControlAltText="Filter Serie column" HeaderText="Serie Doc." 
                    UniqueName="Serie">
                    <HeaderStyle HorizontalAlign="Center" Width="8%" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="NroDocumento" 
                    FilterControlAltText="Filter NroDocumento column" HeaderText="N° Doc." 
                    UniqueName="NroDocumento">
                    <HeaderStyle HorizontalAlign="Center" Width="8%" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="FechaDocumento" 
                    DataFormatString="{0:dd/MM/yyyy}" 
                    FilterControlAltText="Filter FechaDocumento column" HeaderText="Fecha Doc." 
                    UniqueName="FechaDocumento">
                    <HeaderStyle HorizontalAlign="Center" Width="8%" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Monto" DataFormatString="{0:0,0.00}" 
                    FilterControlAltText="Filter Monto column" HeaderText="Monto" 
                    UniqueName="Monto">
                    <HeaderStyle HorizontalAlign="Center" Width="8%" />
                    <ItemStyle HorizontalAlign="Right" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Glosa" 
                    FilterControlAltText="Filter Glosa column" HeaderText="Glosa" 
                    UniqueName="Glosa">
                    <HeaderStyle HorizontalAlign="Center" Width="30%" />
                    <ItemStyle HorizontalAlign="Left" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IdDocRendido" DataType="System.Int32" 
                    FilterControlAltText="Filter IdDocRendido column" HeaderText="IdDocRendido" 
                    UniqueName="IdDocRendido" Visible="False">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IdTipoGasto" 
                    FilterControlAltText="Filter IdTipoGasto column" HeaderText="IdTipoGasto" 
                    UniqueName="IdTipoGasto" Visible="False">
                </telerik:GridBoundColumn>
            </Columns>
            <EditFormSettings EditFormType="WebUserControl" 
                UserControlName="~\Contabilidad\Controles\ControlDocumento.ascx">
                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                </EditColumn>
            </EditFormSettings>
        </telerik:GridTableView>
    </DetailTables>
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
        Visible="True">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro que desea eliminar el Registro?" ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
            UniqueName="eliminar" Text="Eliminar">
            <HeaderStyle Width="3%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="N° Recibo" 
            UniqueName="Codigo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Beneficiario" 
            FilterControlAltText="Filter Beneficiario column" HeaderText="Entregado A" 
            UniqueName="Beneficiario">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Left" />
        </telerik:GridBoundColumn>
<telerik:GridBoundColumn DataField="Glosa" HeaderText="Glosa" 
            UniqueName="Glosa" FilterControlAltText="Filter Glosa column" 
            FooterText="TOTAL:">

    <FooterStyle Font-Bold="True" HorizontalAlign="Right" />

<HeaderStyle HorizontalAlign="Center" Width="35%"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
</telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Total" DataFormatString="{0:0,0.00}" 
            DataType="System.Decimal" FilterControlAltText="Filter Total column" 
            HeaderText="Total" SortExpression="Total" UniqueName="Total" 
            Aggregate="Sum" FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Width="8%" />
            <ItemStyle HorizontalAlign="Center" />
            <HeaderStyle HorizontalAlign="Center" Width="8%" />
            <ItemStyle HorizontalAlign="Right" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Rendido" DataFormatString="{0:0,0.00}" 
            DataType="System.Decimal" FilterControlAltText="Filter Rendido column" 
            HeaderText="Rendido" SortExpression="Rendido" UniqueName="Rendido" 
            Aggregate="Sum" FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Width="30%" />
            <ItemStyle HorizontalAlign="Left" />
            <HeaderStyle HorizontalAlign="Center" Width="8%" />
            <ItemStyle HorizontalAlign="Right" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Diferencia" DataFormatString="{0:0,0.00}" 
            DataType="System.Decimal" FilterControlAltText="Filter Diferencia column" 
            HeaderText="Diferencia" SortExpression="Diferencia" 
            UniqueName="Diferencia" Aggregate="Sum" 
            FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Width="8%" />
            <ItemStyle HorizontalAlign="Right" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdRecibo" DataType="System.Int32" 
            FilterControlAltText="Filter IdRecibo column" HeaderText="IdRecibo" 
            SortExpression="IdRecibo" UniqueName="IdRecibo" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdRendicion" DataType="System.Int32" 
            FilterControlAltText="Filter IdRendicion column" HeaderText="IdRendicion" 
            SortExpression="IdRendicion" UniqueName="IdRendicion" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdReciboRendicion" DataType="System.Int32" 
            FilterControlAltText="Filter IdReciboRendicion column" 
            HeaderText="IdReciboRendicion" SortExpression="IdReciboRendicion" 
            UniqueName="IdReciboRendicion" Visible="False">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                                                                            </telerik:RadGrid>
                                                        </td>
                                                    </tr>
                                                    </table>

                                                <telerik:RadTextBox ID="RadTextBox2" Runat="server" 
                             Text="0" BackColor="White" BorderColor="White" BorderStyle="None" 
                             ForeColor="White">
                                                </telerik:RadTextBox>

                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>

                                                <asp:ObjectDataSource ID="odsDocumentoRendido" runat="server" 
                                                    SelectMethod="GetDOCUMENTORENDIDOByIdReciboRendicion" 
                                                    TypeName="SistFoncreagro.BussinesLogic.DocumentoRendidoBL">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="RadGrid2" Name="IdReciboRendicion" 
                                                            PropertyName="SelectedValue" Type="Int32" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                                                            <asp:SqlDataSource ID="SqlRecibosRendicion" runat="server" 
                             ConnectionString="<%$ ConnectionStrings:cnx %>" 
                             SelectCommand="GetMontosRECIBOSRENDICIONByIdRendicion" 
                             SelectCommandType="StoredProcedure">
                                                                                <SelectParameters>
                                                                                    <asp:ControlParameter ControlID="RadTextBox2" Name="idRendicion" 
                                                                                        PropertyName="Text" Type="Int32" />
                                                                                </SelectParameters>
                         </asp:SqlDataSource>

                                                <asp:ObjectDataSource ID="odsOpFinanciera" runat="server" 
                                                    SelectMethod="GetAllFromOperacionFinanciera" 
                                                    TypeName="SistFoncreagro.BussinesLogic.OperacionFinancieraBL">
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsSubDiario" runat="server" 
                                                    SelectMethod="GetAllSUBDIARIO" 
                                                    TypeName="SistFoncreagro.BussinesLogic.SubdiarioBL"></asp:ObjectDataSource>

                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>

                                                                            <asp:ObjectDataSource ID="odsRecibos" runat="server" 
                                                                                SelectMethod="GetRECIBOByIdProyecto" 
                                                                                TypeName="SistFoncreagro.BussinesLogic.ReciboBL">
                                                                                <SelectParameters>
                                                                                    <asp:ControlParameter ControlID="RadComboBox3" Name="IdProyecto" 
                                                                                        PropertyName="SelectedValue" Type="Int32" />
                                                                                </SelectParameters>
                                                                            </asp:ObjectDataSource>

    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadTextBox1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadTextBox2" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="txtDate">
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadTextBox1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid2">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
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
        function Cerrar() {

            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ActualizarLista");
            
        }
        function alertCallBackFn(arg) {
            radalert("<strong>radalert</strong> returned the following result: <h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Result");
        }

        function confirmCallBackFn(arg) {
//            radalert("<strong>radconfirm</strong> returned the following result: <h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Result");
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Enviar|" + arg);
        }

        function promptCallBackFn(arg) {
            radalert("After 7.5 million years, <strong>Deep Thought</strong> answers:<h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Deep Thought");
        }
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }
        function ponerCeros() {
            var obj = document.getElementById('RadTextBox2')
            
                     while (obj.value.length < 4)
                    obj.value = '0' + obj.value;
          

        }
       
        function ValidarFecha() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarFecha");

        }
        function Foco() {
            document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDate').value = ''

        }
     </script>
    </telerik:RadCodeBlock>
    
                                  
                                                </asp:Content>