
 <%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmPersonal.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmPersonal" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
                 <script type="text/javascript">

//                        function GetRadWindow() {
//                            var oWindow = null; if (window.radWindow) oWindow = window.radWindow;
//                            else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
//                            return oWindow;
//                        }

//                        function Close() {
//                            var oWindow = GetRadWindow();
//                            oWindow.argument = null;
//                            oWindow.close(); return false;
//                        } 

                        function NuevoColaborador() {
                            var oWnd = radopen("FrmEditarPersonal.aspx?ficha=0", "EditarPersonal");
                            return false;
                        }

                        function AsignarHorario() {
                            var oWnd = radopen("FrmAsignarHorario.aspx", "AsignarHorario");
                            return false;
                        }

                        function AsignarCC() {
                            var oWnd = radopen("FrmAsignarCentroCostoPorPersona.aspx", "AsignarCC");
                            return false;
                        }

                        function RegistrarAusencia() {
                            var oWnd = radopen("FrmAusencia.aspx", "RegistrarAusencia");
                            return false;
                        }

                        function CerrarRadWindow(oWnd, args) {
                            $find("<%= AjaxManager.ClientID %>").ajaxRequest("cerrarpagina"); 
                        }

//                        function CargarVentanaCotizacion() {
//                            var oWnd = radopen("VentanaCargarCotizacion.aspx?IdRequerimiento=" + idReq + "&Estado=" + esta, "VentanaCotizacion");

//                        }
                        
                </script>
     </telerik:RadCodeBlock>
    <table style="border: 1px solid #000000; width: 100%">
        <tr>
            <td>
                <table class="fondoTabla"                     
                    style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td class="Titulos">
                            REGISTRO DE COLABORADORES</td>
                        <td width="40px">
                            &nbsp;</td>
                        <td style="text-align: right; width:110px">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadAjaxManager ID="AjaxManager" runat="server">
                    <AjaxSettings>
                        <telerik:AjaxSetting AjaxControlID="RCBFiltro">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="txtIdCategoria" />
                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                <telerik:AjaxUpdatedControl ControlID="Panel1" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="txtFechaIni">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="txtFechaFin">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                    </AjaxSettings>
                </telerik:RadAjaxManager>
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 100%" class="Texto">
                    <tr>
                        <td width="20">
                            &nbsp;</td>
                        <td class="Texto" style="font-family: Arial, Helvetica, sans-serif" width="25">
                            Ver:</td>
                        <td width="180">
                            <telerik:RadComboBox ID="RCBFiltro" Runat="server" Skin="Hay" Width="170px" 
                                AutoPostBack="True">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="Colaboradores Activos" 
                                        Value="1" Owner="RCBFiltro" Selected="True" />
                                    <telerik:RadComboBoxItem runat="server" Text="Colaboradores Liquidados" 
                                        Value="2" Owner="RCBFiltro" />
                                    <telerik:RadComboBoxItem runat="server" Text="Sin Vinculo Laboral" Value="3" 
                                        Owner="RCBFiltro" />
                                    <telerik:RadComboBoxItem runat="server" Text="Prácticantes" Value="4" 
                                        Owner="RCBFiltro" />
                                    <telerik:RadComboBoxItem runat="server" Text="Todos" Value="10" 
                                        Owner="RCBFiltro" Visible="False" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                        <td width="20">
                            &nbsp;</td>
                        <td>
                            <asp:Panel ID="Panel1" runat="server" Visible="False">
                                <table>
                                    <tr>
                                        <td width="150" align="right" valign="middle" 
                                        style="font-weight: 700">
                                            Fechas de Liquidación:</td>
                                        <td width="50" align="right" valign="middle" 
                                        style="font-weight: 700">
                                            Entre</td>
                                        <td width="120">
                                            <telerik:RadDatePicker ID="txtFechaIni" Runat="server" 
                                            Width="118px" FocusedDate="2011-01-01" MinDate="1990-01-01">
                                            </telerik:RadDatePicker>
                                        </td>
                                        <td align="right" valign="middle" width="20" 
                                        style="font-weight: 700">
                                            y:&nbsp;&nbsp;
                                        </td>
                                        <td width="120">
                                            <telerik:RadDatePicker ID="txtFechaFin" Runat="server" 
                                            Width="118px" FocusedDate="2011-01-01" MinDate="1990-01-01">
                                            </telerik:RadDatePicker>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                        <td width="20">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td width="20">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="20">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td width="180">
                            <asp:TextBox ID="txtIdCategoria" runat="server" Width="40px" Visible="False"></asp:TextBox>
                        </td>
                        <td width="20">
                            &nbsp;</td>
                        <td>
                            <table style="width: 100%">
                                <tr>
                                    <td width="100">
                                        &nbsp;</td>
                                    <td width="100">
                                        &nbsp;</td>
                                    <td width="180">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
                        <td width="20">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td width="20">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <div style="overflow: scroll; border-width: 1px; border-style: solid; width: 930px;">
                    <asp:ObjectDataSource ID="ODSPersonal" runat="server" 
                        SelectMethod="GetListaPersonalPorParametro" 
                        TypeName="SistFoncreagro.BussinesLogic.PersonalBL">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="RCBFiltro" Name="parametro" 
                                PropertyName="SelectedValue" Type="Int32" />
                            <asp:ControlParameter ControlID="txtIdCategoria" Name="idCategoria" 
                                PropertyName="Text" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" AllowFilteringByColumn="True"
                        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="ODSPersonal" 
                        GridLines="None" ShowGroupPanel="True" Skin="Hay" 
                        style="font-family: Arial; font-size: 9pt">
                        <GroupingSettings CaseSensitive="False" 
                            GroupSplitDisplayFormat="Mostrando {0} de {1} items." />
                        <ClientSettings AllowDragToGroup="True" AllowColumnHide="True" 
                            AllowColumnsReorder="True" ReorderColumnsOnClient="True">
                            <DataBinding EnableCaching="True">
                            </DataBinding>
                            <Selecting AllowRowSelect="True" />
                            <ClientMessages DragToGroupOrReorder="Arrastre el Item con el que desea Agrupar los datos" 
                                DropHereToReorder="Coloque aqui para reordenar" 
                                PagerTooltipFormatString="Pagina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;" />
                        </ClientSettings>
<MasterTableView datasourceid="ODSPersonal" pagesize="15" CommandItemDisplay="Top" 
                            NoMasterRecordsText="No existen registros." 
                            DataKeyNames="IdPersonal,IdPeriodoLaboralActual">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Nuevo Colaborador" ExportToCsvText="Exportar a CSV" 
        ExportToExcelText="Exportar a Excel" ExportToWordText="Exportar a Word" 
        RefreshText="Refrescar" ShowExportToExcelButton="True" 
        ShowExportToPdfButton="True"></CommandItemSettings>


<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>



    <Columns>
        <telerik:GridBoundColumn DataField="IdPersonal" 
            FilterControlAltText="Filter IdPersonal column" HeaderText="IdPersonal" 
            SortExpression="IdPersonal" UniqueName="IdPersonal" 
            DataType="System.Int32" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn AllowFiltering="False" 
            FilterControlAltText="Filter TemplateColumn2 column" 
            UniqueName="TemplateColumn2">
            <ItemTemplate>
                <asp:ImageButton ID="imgBtnEditar" runat="server" 
                    CommandArgument='<%# Eval("IdPersonal") %>' CommandName="Editar" 
                    ImageUrl="~/img/Edit.gif" onclick="ImageButton2_Click" />
            </ItemTemplate>
            <HeaderStyle Width="20px" />
            <ItemStyle Width="20px" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn AllowFiltering="False" 
            FilterControlAltText="Filter TemplateColumn1 column" 
            UniqueName="TemplateColumn1">
            <ItemTemplate>
                <asp:ImageButton ID="imgBtnEliminar" runat="server" 
                    CommandArgument='<%# Eval("IdPersonal") %>' CommandName="Eliminar" 
                    ImageUrl="~/img/Delete.gif" onclick="imgBtnEliminar_Click" />
            </ItemTemplate>
            <HeaderStyle Width="20px" />
            <ItemStyle Width="20px" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn3 column" 
            UniqueName="TemplateColumn3" AllowFiltering="False" ShowFilterIcon="False">
            <ItemTemplate>
                <asp:ImageButton ID="btnAsignarHorario" runat="server" 
                    
                    
                    CommandArgument='<%# Eval("IdPeriodoLaboralActual") & "/" & Eval("NombreCompleto") & "/" & Eval("NombreArea") & "/" &  Eval("NombrePosicion") %>' Height="19px" 
                   
                    ImageUrl="~/img/Calendario.gif" onclick="btnAsignarHorario_Click" 
                    Width="19px" />
            </ItemTemplate>
            <HeaderStyle Width="20px" />
            <ItemStyle Width="20px" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn4 column" 
            UniqueName="TemplateColumn4" AllowFiltering="False">
            <ItemTemplate>
                <asp:ImageButton ID="btnCentroCosto" runat="server" 
                    CommandArgument='<%# Eval("IdPeriodoLaboralActual") & "/" & Eval("NombreCompleto") & "/" & Eval("NombreArea") & "/" &  Eval("NombrePosicion") %>' 
                    Height="21px" ImageUrl="~/img/imgDineroP1.png" onclick="btnCentroCosto_Click" 
                    Width="19px" />
            </ItemTemplate>
            <HeaderStyle Width="20px" />
            <ItemStyle Width="20px" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn AllowFiltering="False" 
            FilterControlAltText="Filter TemplateColumn5 column" 
            UniqueName="TemplateColumn5">
            <ItemTemplate>
                <asp:ImageButton ID="btnAusencias" runat="server" 
                    CommandArgument='<%# Eval("IdPeriodoLaboralActual") & "/" & Eval("NombreCompleto") & "/" & Eval("NombreArea") & "/" &  Eval("NombrePosicion") %>' 
                    ImageUrl="~/img/Rendir.gif" onclick="btnAusencias_Click" />
            </ItemTemplate>
            <HeaderStyle Width="20px" />
            <ItemStyle Width="20px" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="NombreCompleto" 
            FilterControlAltText="Filter column column" HeaderText="Apellidos y Nombres" 
            SortExpression="NombreCompleto" UniqueName="column" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
            <HeaderStyle Width="250px" />
            <ItemStyle Width="250px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroDI" 
            FilterControlAltText="Filter NroDI column" HeaderText="Nro DNI" 
            SortExpression="NroDI" UniqueName="NroDI" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle Width="60px" />
            <ItemStyle Width="60px" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn AutoPostBackOnFilter="True" 
            DataField="FechaNacimiento" FilterControlAltText="Filter TemplateColumn column" 
            FilterControlWidth="60%" HeaderText="Fecha Nacimiento" 
            SortExpression="FechaNacimiento" UniqueName="TemplateColumn" 
            Visible="False">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" 
                    Text='<%# String.Format("{0:dd/MM/yyyy}", Eval("FechaNacimiento")) %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle Width="60px" />
            <ItemStyle Width="60px" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="TipoSangre" 
            FilterControlAltText="Filter TipoSangre column" 
            HeaderText="T.S." SortExpression="TipoSangre" 
            UniqueName="TipoSangre" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False" AllowFiltering="False">
            <HeaderStyle Width="40px" />
            <ItemStyle Width="40px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdPeriodoLaboralActual" 
            FilterControlAltText="Filter IdPeriodoLaboralActual column" HeaderText="IdPeriodoLaboral" 
            SortExpression="IdPeriodoLaboralActual" UniqueName="IdPeriodoLaboralActual" 
            FilterControlWidth="100px" ShowFilterIcon="False" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdContrato" 
            FilterControlAltText="Filter IdContrato column" HeaderText="IdContrato" 
            SortExpression="IdContrato" UniqueName="IdContrato" 
            ShowFilterIcon="False" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroContrato" 
            FilterControlAltText="Filter NroContrato column" HeaderText="NroContrato" 
            SortExpression="NroContrato" UniqueName="NroContrato" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
            <HeaderStyle Width="80px" />
            <ItemStyle Width="80px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            DataField="FechaCese" DataFormatString="{0:dd/MMM/yyyy}" 
            FilterControlAltText="Filter FechaCese column" FilterControlWidth="100%" 
            HeaderText="F. Cese" ShowFilterIcon="False" SortExpression="FechaCese" 
            UniqueName="FechaCese">
            <HeaderStyle Width="60px" />
            <ItemStyle Width="60px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdPosicionActual" 
            FilterControlAltText="Filter IdPosicionActual column" HeaderText="IdPosicion" 
            SortExpression="IdPosicionActual" UniqueName="IdPosicionActual" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False" 
            AndCurrentFilterFunction="Contains" Visible="False">
            <HeaderStyle Width="60px" />
            <ItemStyle Width="60px" />
            <HeaderStyle Width="80px" />
            <ItemStyle Width="80px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NombrePosicion" 
            FilterControlAltText="Filter NombrePosicion column" 
            HeaderText="NombrePosicion" SortExpression="NombrePosicion" 
            UniqueName="NombrePosicion" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" FilterControlWidth="100%" 
            ShowFilterIcon="False" CurrentFilterFunction="Contains">
            <HeaderStyle Width="150px" />
            <ItemStyle Width="150px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdArea" 
            FilterControlAltText="Filter IdArea column" HeaderText="IdArea" 
            SortExpression="IdArea" UniqueName="IdArea" ShowFilterIcon="False" 
            Visible="False">
            <HeaderStyle Width="180px" />
            <ItemStyle Width="180px" />
            <HeaderStyle Width="50px" />
            <ItemStyle Width="50px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NombreArea" 
            FilterControlAltText="Filter NombreArea column" HeaderText="Area" 
            SortExpression="NombreArea" UniqueName="NombreArea" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle Width="150px" />
            <ItemStyle Width="150px" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings EditFormType="Template">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
    <PagerStyle PagerTextFormat="Change página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, items &lt;strong&gt;{2}&lt;/strong&gt; to &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
        PageSizeLabelText="Tamaño de Página" />
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                    </telerik:RadGrid>
                    </br>
                </div>
            </td>
        </tr>
<tr>
<td>
    <telerik:RadWindowManager ID="RadWindowManager2" runat="server">
              <Windows>
                        <telerik:RadWindow ID="EditarPersonal" runat="server" Title="Editar Personal" Height="840px"
                        Width="880px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" Animation="Resize" OnClientClose="CerrarRadWindow"/> 
                        
                        <telerik:RadWindow ID="AsignarHorario" runat="server" Title="Asignar Horario" Height="480px"
                        Width="680px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" Animation="Resize"></telerik:RadWindow>  

                        <telerik:RadWindow ID="AsignarCC" runat="server" Title="Asignar Centro de Costo" Height="700px"
                        Width="850px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" Animation="Resize" ></telerik:RadWindow>    

                        <telerik:RadWindow ID="RegistrarAusencia" runat="server" Title="Registrar Ausencia" Height="450px"
                        Width="590px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" Animation="Resize"></telerik:RadWindow>   
                                        
              </Windows>
     </telerik:RadWindowManager>

    </td>
</tr>
    </table>
</asp:Content>
