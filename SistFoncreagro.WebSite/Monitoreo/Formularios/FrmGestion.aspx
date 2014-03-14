<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmGestion.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmGestion" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.316, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
    function onRequestStart(sender, args) {
        if (args.get_eventTarget().indexOf("ExportToExcelButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToWordButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToPdfButton") >= 0) {
            args.set_enableAjax(false);
        }
    }
   
    </script>
    <table align="center" class="tabla3">
        <tr>
            <td width="40%">
                <telerik:RadGrid ID="RadGrid1" runat="server" Skin="Hay" 
                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlProyectos" 
                    GridLines="None">
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
<MasterTableView DataKeyNames="IdProyecto" DataSourceID="SqlProyectos">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter column1 column" Text="StakeHolders" 
            UniqueName="column1" ImageUrl="~\img\stakeholders.gif" 
            CommandName="stakeholders">
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter column column" Text="Plan Operativo" UniqueName="column" 
            ImageUrl="~\img\poa.gif" CommandName="poa">
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter column2 column" 
            Text="Registro de Actividades/Tareas" UniqueName="column2" 
            ImageUrl="~\img\registrar.gif" CommandName="control">
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="clima" 
            FilterControlAltText="Filter column3 column" ImageUrl="~\img\clima.jpg" 
            Text="Clima Social" UniqueName="column3">
            <ItemStyle Height="25px" Width="25px" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="kardex" 
            FilterControlAltText="Filter kardex column" ImageUrl="~\img\almacen.jpg" 
            Text="Control de Productos" UniqueName="kardex">
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="gastos" 
            FilterControlAltText="Filter column4 column" ImageUrl="~\img\soles.jpg" 
            Text="Gastos por Caserio" UniqueName="column4">
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Nombre" 
            FilterControlAltText="Filter Nombre column" 
            HeaderText="Nombre del Proyecto" ReadOnly="True" 
            SortExpression="Nombre" UniqueName="Nombre">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdProyecto" DataType="System.Int32" 
            FilterControlAltText="Filter IdProyecto column" HeaderText="IdProyecto" 
            ReadOnly="True" SortExpression="IdProyecto" UniqueName="IdProyecto" 
            Visible="False">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Hay"></HeaderContextMenu>
                </telerik:RadGrid>
            </td>
        </tr>
                       
        
        
        
    </table>
   
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td >
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                        </td>
                        <td width="15%"  >
                <asp:Button ID="Button1" runat="server" Text="Generar" 
                    Visible="False" onclientclick="f();" />
                        </td>
                        <td width="15%"  >
                <asp:Button ID="Button2" runat="server" Text="Programación" 
                    Visible="False" Width="120px" />
                            <asp:Button ID="Button4" runat="server" Text="MATRIZ DE CLIMA SOCIAL" 
                                Visible="False" />
                            <asp:Button ID="Button6" runat="server" Text="ACTIVIDADES POR CASERIO" 
                                Visible="False" />
                        </td>
                        <td style="text-align: center; width:30px" width="15%"   >
                            <asp:Button ID="Button5" runat="server" Text="TAREAS POR CASERIO" 
                                Visible="False" />
                <asp:Button ID="Button3" runat="server" Text="Ejecución" 
                    Visible="False" Width="100px" />
                <asp:Button ID="Button7" runat="server" Text="Reporte de Stakeholders" 
                    Visible="False" Width="200px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
                       
        
        
        
        <tr>
            <td width="40%">
                <telerik:RadGrid ID="RadGrid3" runat="server" DataSourceID="SqlSubActividades" 
                    Skin="Hay" AutoGenerateColumns="False" CellSpacing="0" GridLines="None" 
                    Visible="False">
<MasterTableView DataKeyNames="IdSubActividad" 
                        DataSourceID="SqlSubActividades" CommandItemDisplay="Top" 
                        NoMasterRecordsText="No existen registros">
    <DetailTables>
        <telerik:GridTableView runat="server" BackColor="#CCCCCC" BorderColor="Black" 
            ClientDataKeyNames="IdTarea" CommandItemDisplay="Top" DataKeyNames="IdTarea" 
            DataSourceID="SqlDataSource1" Name="Tareas" 
            NoMasterRecordsText="No existen registros.">
            <ParentTableRelation>
                <telerik:GridRelationFields DetailKeyField="IdSubActividad" 
                    MasterKeyField="IdSubActividad" />
            </ParentTableRelation>
            <CommandItemSettings AddNewRecordText="Agregar Tarea" 
                ExportToPdfText="Export to PDF" RefreshText="Refrescar" />
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            </RowIndicatorColumn>
            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
            </ExpandCollapseColumn>
            <Columns>
                <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                    FilterControlAltText="Filter EditCommandColumn column">
                </telerik:GridEditCommandColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                    ConfirmDialogType="RadWindow" 
                    ConfirmText="¿Está seguro de Eliminar el Registro?" 
                    ConfirmTitle="Mensaje de Confirmacion" 
                    FilterControlAltText="Filter column column" Text="Eliminar" UniqueName="column">
                </telerik:GridButtonColumn>
                <telerik:GridBoundColumn DataField="IdTarea" 
                    FilterControlAltText="Filter IdTarea column" HeaderText="IdTarea" 
                    UniqueName="IdTarea" Visible="False">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="NomTarea" 
                    FilterControlAltText="Filter NomTarea column" HeaderText="Tarea" 
                    UniqueName="NomTarea">
                    <HeaderStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Unidad" 
                    FilterControlAltText="Filter Unidad column" HeaderText="Unidad" 
                    UniqueName="Unidad">
                    <HeaderStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
            </Columns>
            <EditFormSettings>
                <EditColumn FilterControlAltText="Filter EditCommandColumn1 column" 
                    UniqueName="EditCommandColumn1">
                </EditColumn>
            </EditFormSettings>
        </telerik:GridTableView>
    </DetailTables>
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Sub Actividad" RefreshText="Refrescar" 
        ShowRefreshButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
        Visible="True">
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
            FilterControlAltText="Filter EditCommandColumn column">
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro de Eliminar el Registro?" 
            ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter column column" Text="Eliminar" UniqueName="column">
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdSubActividad" DataType="System.Int32" 
            FilterControlAltText="Filter IdSubActividad column" HeaderText="IdSubActividad" 
            ReadOnly="True" SortExpression="IdSubActividad" 
            UniqueName="IdSubActividad" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NomTarea" 
            FilterControlAltText="Filter NomTarea column" HeaderText="Sub Actividad" 
            ReadOnly="True" SortExpression="NomTarea" UniqueName="NomTarea">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Unidad" 
            FilterControlAltText="Filter Unidad column" HeaderText="Unidad" 
            SortExpression="Unidad" UniqueName="Unidad">
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
                <telerik:RadGrid ID="RadGrid4" runat="server" AllowFilteringByColumn="True" 
                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlStakeholders" 
                    GridLines="None" Skin="Hay" Visible="False">
                    <GroupingSettings CaseSensitive="False" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
<MasterTableView CommandItemDisplay="Top" DataKeyNames="IdInteresado" 
                        DataSourceID="SqlStakeholders">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Stakeholder" RefreshText="Refrescar" 
        ShowRefreshButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
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
        <telerik:GridBoundColumn DataField="IdInteresado" DataType="System.Int32" 
            FilterControlAltText="Filter IdInteresado column" HeaderText="IdInteresado" 
            ReadOnly="True" SortExpression="IdInteresado" UniqueName="IdInteresado" 
            Visible="False">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="Provincia" 
            FilterControlAltText="Filter Provincia column" FilterControlWidth="100%" 
            HeaderText="Provincia" ReadOnly="True" ShowFilterIcon="False" 
            SortExpression="Provincia" UniqueName="Provincia">
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="Distrito" 
            FilterControlAltText="Filter Distrito column" FilterControlWidth="100%" 
            HeaderText="Distrito" ShowFilterIcon="False" UniqueName="Distrito">
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="CentroPoblado" 
            FilterControlAltText="Filter CentroPoblado column" FilterControlWidth="100%" 
            HeaderText="C. Poblado" ShowFilterIcon="False" UniqueName="CentroPoblado">
            <HeaderStyle HorizontalAlign="Center" Width="15%" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="Caserio" 
            FilterControlAltText="Filter Caserio column" FilterControlWidth="100%" 
            HeaderText="Caserio" ShowFilterIcon="False" UniqueName="Caserio">
            <HeaderStyle HorizontalAlign="Center" Width="15%" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="Interesado" 
            FilterControlAltText="Filter Interesado column" FilterControlWidth="100%" 
            HeaderText="Apellidos y Nombres" ReadOnly="True" ShowFilterIcon="False" 
            SortExpression="Interesado" UniqueName="Interesado">
            <HeaderStyle HorizontalAlign="Center" Width="17%" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Cargo" 
            FilterControlAltText="Filter Cargo column" HeaderText="Cargo" 
            SortExpression="Cargo" UniqueName="Cargo" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="15%" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="dni" 
            FilterControlAltText="Filter dni column" FilterControlWidth="100%" 
            HeaderText="DNI" ShowFilterIcon="False" 
            UniqueName="dni">
            <HeaderStyle HorizontalAlign="Center" Width="5%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="Telefono" 
            FilterControlAltText="Filter Telefono column" FilterControlWidth="100%" 
            HeaderText="Telefono" ShowFilterIcon="False" UniqueName="Telefono">
            <HeaderStyle HorizontalAlign="Center" Width="5%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" DataField="Actitud" 
            FilterControlAltText="Filter Actitud column" FilterControlWidth="100%" 
            HeaderText="Actitud" ShowFilterIcon="False" SortExpression="Actitud" 
            UniqueName="Actitud" Visible="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                                <telerik:RadGrid ID="RadGrid2" runat="server" AllowFilteringByColumn="True" 
                                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlDetalleEje"  AllowPaging="True" EnableLinqExpressions="False"
                                    GridLines="None" Skin="Hay" Visible="False" 
                    ShowFooter="True">
                                    <GroupingSettings CaseSensitive="False" />
                                    <GroupingSettings CaseSensitive="False" />
                                    <HierarchySettings CollapseTooltip="Ocultar Actividades/Tareas" 
                                        ExpandTooltip="Mostrar Actividades/Tareas" />
                                    <ClientSettings>
                                        <Selecting AllowRowSelect="True" />
                                        <Selecting AllowRowSelect="True" />
                                    </ClientSettings>
                                    <MasterTableView CommandItemDisplay="Top" DataKeyNames="IdDetalleEje" 
                                        DataSourceID="SqlDetalleEje" NoMasterRecordsText="No existen registros." 
                                        ClientDataKeyNames="IdDetalleEje" Name="Gestion" Font-Names="Arial" 
                                        NoDetailRecordsText="No existen registros." PageSize="20">
                                        <CommandItemSettings AddNewRecordText=" Agregar Registro" 
                                            ExportToExcelText="Exportar a Excel" ExportToPdfText="Export to PDF" 
                                            RefreshText="Refrescar" ShowRefreshButton="False" />
                                        <CommandItemSettings AddNewRecordText=" Agregar Registro" 
                                            ExportToExcelText="Exportar a Excel" ExportToPdfText="Export to PDF" 
                                            RefreshText="Refrescar" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                            <HeaderStyle Width="20px" />
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                            <HeaderStyle Width="20px" />
                                        </ExpandCollapseColumn>
                                        <Columns>
                                            <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                FilterControlAltText="Filter EditCommandColumn column">
                                            </telerik:GridEditCommandColumn>
                                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                ConfirmDialogType="RadWindow" 
                                                ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                                ConfirmTitle="Mensaje de Confirmacion" 
                                                FilterControlAltText="Filter column column" 
                                                Text="Eliminar" UniqueName="column">
                                            </telerik:GridButtonColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="FechaProgramada" 
                                                DataFormatString="{0:dd/MM/yyyy}" 
                                                FilterControlAltText="Filter FechaProgramada column" FilterControlWidth="100%" 
                                                HeaderText="Programado" ShowFilterIcon="False" UniqueName="FechaProgramada">
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle Font-Names="Arial" Font-Size="7.5pt" HorizontalAlign="Center" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AllowFiltering="False" DataField="IdDetalleEje" 
                                                DataType="System.Int32" FilterControlAltText="Filter IdDetalleEje column" 
                                                HeaderText="IdDetalleEje" ReadOnly="True" SortExpression="IdDetalleEje" 
                                                UniqueName="IdDetalleEje" Visible="False">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn  DataField="Fecha" 
                                                DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime" 
                                                 HeaderText="Ejecutado" SortExpression="Fecha" 
                                                UniqueName="Fecha" 
                                                CurrentFilterFunction="Between" FilterControlWidth="50%" >
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle Font-Names="Arial" Font-Size="7.5pt" HorizontalAlign="Center" />
                                               <FilterTemplate>
 <telerik:RadDatePicker ID="dateFrom" runat="server" ClientEvents-OnDateSelected="FromDateSelected" SelectedDate='<%# fromDate %>' Width="95px" Font-Size="7pt" Font-Names="Arial" />
 <telerik:RadDatePicker ID="dateTo" runat="server" ClientEvents-OnDateSelected="ToDateSelected" SelectedDate='<%# toDate %>' Width="95px" />
<telerik:RadScriptBlock ID="scriptFilterEventDate" runat="server">
 <script type="text/javascript">
     function FromDateSelected(sender, args) {
         var tableView = $find("<%# TryCast(Container,GridItem).OwnerTableView.ClientID %>");
         var ToPicker = $find('<%# TryCast(Container, GridItem).FindControl("dateTo").ClientID %>');
        

         var fromDate = FormatSelectedDate(sender);
         var toDate = FormatSelectedDate(ToPicker);

         if (toDate != '') {
             tableView.filter("Fecha", fromDate + " " + toDate, "Between");
         }
//         alert("EventDate"+ fromDate + " " + toDate);
     }
     function ToDateSelected(sender, args) {
         var tableView = $find("<%# TryCast(Container,GridItem).OwnerTableView.ClientID %>");

         var FromPicker = $find('<%# TryCast(Container, GridItem).FindControl("dateFrom").ClientID %>');

         var fromDate = FormatSelectedDate(FromPicker);
         var toDate = FormatSelectedDate(sender);

         if (fromDate != '') {
             tableView.filter("Fecha", fromDate + " " + toDate, "Between");
           }
     }
     function FormatSelectedDate(picker) {
         var date = picker.get_selectedDate();
         var dateInput = picker.get_dateInput();
         var formattedDate = dateInput.get_dateFormatInfo().FormatDate(date, dateInput.get_displayDateFormat());

         return formattedDate;
     }
 </script>
 </telerik:RadScriptBlock>
 </FilterTemplate>
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="Provincia" 
                                                FilterControlAltText="Filter Provincia column" FilterControlWidth="100%" 
                                                HeaderText="Provincia" ReadOnly="True" ShowFilterIcon="False" 
                                                SortExpression="Provincia" UniqueName="Provincia">
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="Distrito" 
                                                FilterControlAltText="Filter column2 column" FilterControlWidth="100%" 
                                                HeaderText="Distrito" ShowFilterIcon="False" UniqueName="column2">
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="CentroPoblado" 
                                                FilterControlAltText="Filter CentroPoblado column" FilterControlWidth="100%" 
                                                HeaderText="C. Poblado" ShowFilterIcon="False" UniqueName="CentroPoblado">
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="Caserio" 
                                                FilterControlAltText="Filter column3 column" FilterControlWidth="100%" 
                                                HeaderText="Caserio" ShowFilterIcon="False" UniqueName="column3">
                                                <FooterStyle Font-Bold="True" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="Tipo" 
                                                FilterControlAltText="Filter Tipo column" FilterControlWidth="100%" 
                                                HeaderText="Tipo" ShowFilterIcon="False" UniqueName="Tipo" 
                                                Aggregate="Count" FooterText="Total:">
                                                <FooterStyle Font-Bold="True" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="Estado" 
                                                FilterControlAltText="Filter Estado column" FilterControlWidth="100%" 
                                                HeaderText="Estado" ShowFilterIcon="False" UniqueName="Estado">
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                                            </telerik:GridBoundColumn>
                                        </Columns>
                                        <EditFormSettings>
                                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                            </EditColumn>
                                        </EditFormSettings>
                                        <FilterItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                                    </MasterTableView>
                                    <PagerStyle PageButtonCount="20" />
                                    <FilterMenu EnableImageSprites="False">
                                    </FilterMenu>
                                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                                    </HeaderContextMenu>
                                </telerik:RadGrid>
                            <telerik:RadGrid ID="RadGrid7" runat="server" Skin="Hay" 
                    Visible="False" Width="100%">
                </telerik:RadGrid>
                            <telerik:RadGrid ID="RadGrid6" runat="server" AllowFilteringByColumn="True" 
                                AutoGenerateColumns="False" CellSpacing="0" 
                                DataSourceID="SqlCaserios" GridLines="None" Width="100%" 
                                CssClass="grid" Culture="es-PE" 
                                Skin="Hay" Visible="False">
                                <GroupingSettings CaseSensitive="False" />
                                <ExportSettings ExportOnlyData="True" OpenInNewWindow="True">
                                </ExportSettings>
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
<MasterTableView DataSourceID="SqlCaserios" ClientDataKeyNames="CUBIGEO" NoMasterRecordsText="No existen registros." 
                                    Name="Proveedor" NoDetailRecordsText="No existen registros." 
                                    DataKeyNames="CUBIGEO">
    <DetailTables>
        <telerik:GridTableView runat="server" ClientDataKeyNames="IdClima" 
            DataKeyNames="IdClima" DataSourceID="SqlClimaUbigeo" 
            Name="Clima" AllowFilteringByColumn="False" Width="100%" 
            NoDetailRecordsText="No existen registros." 
            NoMasterRecordsText="No existen registros." CommandItemDisplay="Top">
            <ParentTableRelation>
                <telerik:GridRelationFields DetailKeyField="CUBIGEO" 
                    MasterKeyField="CUBIGEO" />
            </ParentTableRelation>
            <CommandItemSettings ExportToPdfText="Export to PDF" 
                AddNewRecordText="Agregar Registro" ShowRefreshButton="False" />
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            </RowIndicatorColumn>
            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
            </ExpandCollapseColumn>
            <Columns>
                <telerik:GridEditCommandColumn ButtonType="ImageButton" 
                    FilterControlAltText="Filter EditCommandColumn column">
                    <HeaderStyle Width="1.5%" />
                </telerik:GridEditCommandColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                    ConfirmDialogType="RadWindow" 
                    ConfirmText="¿Está seguro que desea Eliminar el Registro?" ConfirmTitle="Mensaje de Confirmación" 
                    FilterControlAltText="Filter column1 column" ImageUrl="~\img\delete.gif" 
                    Text="Eliminar" UniqueName="eliminar">
                    <HeaderStyle Width="1.5%" />
                </telerik:GridButtonColumn>
                <telerik:GridBoundColumn DataField="CUBIGEO" 
                    FilterControlAltText="Filter CUBIGEO column" HeaderText="CUBIGEO" 
                    UniqueName="CUBIGEO" Visible="False">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IdClima" 
                    FilterControlAltText="Filter IdClima column" HeaderText="IdClima" 
                    UniqueName="IdClima" Visible="False">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Fecha" DataFormatString="{0:dd/MM/yyyy}" 
                    FilterControlAltText="Filter Fecha column" HeaderText="Fecha" 
                    UniqueName="Fecha">
                    <HeaderStyle Width="15%" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Tipo" 
                    FilterControlAltText="Filter Tipo column" HeaderText="Tipo" UniqueName="Tipo">
                    <HeaderStyle Width="15%" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Actitud" 
                    FilterControlAltText="Filter Actitud column" HeaderText="Actitud" 
                    UniqueName="Actitud">
                    <HeaderStyle Width="67%" />
                </telerik:GridBoundColumn>
            </Columns>
            <EditFormSettings>
                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                </EditColumn>
            </EditFormSettings>
        </telerik:GridTableView>
    </DetailTables>
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Registro" ExportToCsvText="Exportar a CSV" 
        ExportToExcelText="Exportar a Excel" ExportToWordText="Exportar a Word" 
        RefreshText="Refrescar"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
        Visible="True">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="IdProyecto" 
            FilterControlAltText="Filter IdProyecto column" HeaderText="IdProyecto" 
            SortExpression="IdProyecto" UniqueName="IdProyecto" 
            DataType="System.Int32" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CUBIGEO" HeaderText="CUBIGEO" 
            SortExpression="CUBIGEO" UniqueName="CUBIGEO" 
            FilterControlAltText="Filter CUBIGEO column" Visible="False"  >
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Provincia" 
            FilterControlAltText="Filter Provincia column" HeaderText="Provincia" 
            SortExpression="Provincia" UniqueName="Provincia" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Distrito" 
            FilterControlAltText="Filter Distrito column" HeaderText="Distrito" 
            SortExpression="Distrito" UniqueName="Distrito" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CentroPoblado" 
            FilterControlAltText="Filter CentroPoblado column" HeaderText="CentroPoblado" 
            ReadOnly="True" SortExpression="CentroPoblado" UniqueName="CentroPoblado" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Caserio" 
            FilterControlAltText="Filter Caserio column" HeaderText="Caserio" 
            ReadOnly="True" SortExpression="Caserio" UniqueName="Caserio" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
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
     <asp:SqlDataSource ID="SqlProyectos" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetPersonalProyecto" 
            SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:SessionParameter Name="idPersonal" SessionField="IdUser" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
     <asp:SqlDataSource ID="SqlDetalleEje" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetDETALLEEJECUCIONByIdProyectoDetallado" 
        SelectCommandType="StoredProcedure">
         <SelectParameters>
             <asp:ControlParameter ControlID="HiddenField1" Name="IdProyecto" 
                 PropertyName="Value" Type="Int32" />
         </SelectParameters>
    </asp:SqlDataSource>
     <asp:SqlDataSource ID="SqlStakeholders" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetINTERESADOSByIdProyectoDetallado" 
        SelectCommandType="StoredProcedure">
         <SelectParameters>
             <asp:ControlParameter ControlID="HiddenField1" Name="IdProyecto" 
                 PropertyName="Value" Type="Int32" />
         </SelectParameters>
    </asp:SqlDataSource>
     <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"   
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Formulario" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" OnClientClose="Validar">
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
            <telerik:RadWindow ID="Formulario1" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" OnClientClose="Validar1">
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
            <telerik:RadWindow ID="Formulario2" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" OnClientClose="Validar2">
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
                <asp:SqlDataSource ID="SqlClimaUbigeo" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetCLIMASOCIALByIdUbigeo" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="RadGrid6" Name="CUBIGEO" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
    </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetTAREAByIdSubActividad" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="RadGrid3" Name="IdSubActividad" 
                            PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
    </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlCaserios" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetCLIMASOCIALByIdProyectoDetallado" 
        SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="HiddenField1" Name="IdProyecto" 
                            PropertyName="Value" Type="Int32" />
                    </SelectParameters>
    </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlSubActividades" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetSUBACTIVIDADByIdProyecto" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="HiddenField1" Name="IdProyecto" 
                            PropertyName="Value" Type="Int32" DefaultValue="" />
                    </SelectParameters>
                </asp:SqlDataSource>
                                                                                                                            

                                                <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Skin="Default">
    </telerik:RadAjaxLoadingPanel>
                                                                                                                            

                                                <asp:HiddenField ID="HiddenField1" 
        runat="server" />
                                                                                                                            

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
     <ClientEvents OnRequestStart="onRequestStart" />
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadGrid1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Label1" />
                    <telerik:AjaxUpdatedControl ControlID="Button1" />
                    <telerik:AjaxUpdatedControl ControlID="Button2" />
                    <telerik:AjaxUpdatedControl ControlID="Button4" />
                    <telerik:AjaxUpdatedControl ControlID="Button6" />
                    <telerik:AjaxUpdatedControl ControlID="Button5" />
                    <telerik:AjaxUpdatedControl ControlID="Button3" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid3" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid4" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid7" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid6" />
                    <telerik:AjaxUpdatedControl ControlID="RadWindowManager1" />
                    <telerik:AjaxUpdatedControl ControlID="HiddenField1" />
                    <telerik:AjaxUpdatedControl ControlID="RadCodeBlock1" />
                    <telerik:AjaxUpdatedControl ControlID="Button7" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadGrid3">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Button1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadGrid4">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid4" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadGrid2">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadGrid6">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid6" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid4" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid6" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
        </telerik:RadAjaxManager>
         <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }
        function Validar1() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar1");
        }
        function Validar2() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar2");
        }
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }

        function alertCallBackFn(arg) {
            window.open("FrmGestion.aspx", "_self");
        }
        function confirmCallBackFn(arg) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Generar|" + arg);
        }
        function f() {
            radconfirm('¡Se Generará la Programacion Operativa de Actividades!', confirmCallBackFn, 330, 100, null, 'Mensaje de Confirmación');
            Sys.Application.remove_load(f);
        }; 
       
     </script>
    </telerik:RadCodeBlock>
</asp:Content>
