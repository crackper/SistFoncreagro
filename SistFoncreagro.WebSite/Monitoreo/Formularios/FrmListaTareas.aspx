<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmListaTareas.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="tabla3">
        <tr>
            <td>
    <telerik:RadGrid ID="RadGrid2" runat="server" AllowFilteringByColumn="True" 
                                    AutoGenerateColumns="False" CellSpacing="0" 
        DataSourceID="SqlDetalleEje"  AllowPaging="True" EnableLinqExpressions="False"
                                    GridLines="None" Skin="Hay">
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
                    <HeaderStyle Width="1.5%" />
                </telerik:GridEditCommandColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                ConfirmDialogType="RadWindow" 
                                                ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                                ConfirmTitle="Mensaje de Confirmacion" 
                                                FilterControlAltText="Filter column column" 
                                                Text="Eliminar" UniqueName="column">
                    <HeaderStyle Width="1.5%" />
                </telerik:GridButtonColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                    CurrentFilterFunction="Contains" DataField="FechaProgramada" 
                    DataFormatString="{0:dd/MM/yyyy}" FilterControlAltText="Filter column4 column" 
                    FilterControlWidth="100%" HeaderText="Programado" ShowFilterIcon="False" 
                    UniqueName="column4">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn  DataField="Fecha" 
                                                DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime" 
                                                 HeaderText="Ejecutado" SortExpression="Fecha" 
                                                UniqueName="Fecha" 
                                                CurrentFilterFunction="Between" FilterControlWidth="50%" >
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
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
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                    <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="Distrito" 
                                                FilterControlAltText="Filter column2 column" FilterControlWidth="100%" 
                                                HeaderText="Distrito" ShowFilterIcon="False" UniqueName="column2">
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                    <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="CentroPoblado" 
                                                FilterControlAltText="Filter CentroPoblado column" FilterControlWidth="100%" 
                                                HeaderText="C. Poblado" ShowFilterIcon="False" UniqueName="CentroPoblado">
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                    <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="Caserio" 
                                                FilterControlAltText="Filter column3 column" FilterControlWidth="100%" 
                                                HeaderText="Caserio" ShowFilterIcon="False" UniqueName="column3">
                    <FooterStyle Font-Bold="True" />
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                    <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="Tipo" 
                                                FilterControlAltText="Filter Tipo column" FilterControlWidth="100%" 
                                                HeaderText="Tipo" ShowFilterIcon="False" UniqueName="Tipo" 
                                                Aggregate="Count">
                    <FooterStyle Font-Bold="True" />
                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                    <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="Estado" 
                                                FilterControlAltText="Filter Estado column" FilterControlWidth="100%" 
                                                HeaderText="Estado" ShowFilterIcon="False" UniqueName="Estado">
                    <HeaderStyle HorizontalAlign="Center" Width="7%" />
                    <ItemStyle Font-Names="Arial" Font-Size="7.5pt" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                    CurrentFilterFunction="Contains" DataField="Tarea" 
                    FilterControlAltText="Filter column1 column" FilterControlWidth="100%" 
                    HeaderText="Actividad/Tarea" ShowFilterIcon="False" UniqueName="column1">
                    <HeaderStyle HorizontalAlign="Center" Width="30%" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AllowFiltering="False" DataField="IdDetalleEje" 
                                                DataType="System.Int32" FilterControlAltText="Filter IdDetalleEje column" 
                                                HeaderText="IdDetalleEje" ReadOnly="True" SortExpression="IdDetalleEje" 
                                                UniqueName="IdDetalleEje" Visible="False">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="FechaProgramada" 
                                                DataFormatString="{0:dd/MM/yyyy}" 
                                                
                    FilterControlAltText="Filter FechaProgramada column" FilterControlWidth="100%" 
                                                HeaderText="Programado" ShowFilterIcon="False" 
                    UniqueName="FechaProgramada" Visible="False">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle Font-Names="Arial" Font-Size="7.5pt" HorizontalAlign="Center" />
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
            </td>
        </tr>
    </table>
                                                                                                                            

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
     <ClientEvents />
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadGrid2">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
        </telerik:RadAjaxManager>
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
         
        </Windows>
    </telerik:RadWindowManager>
     <asp:SqlDataSource ID="SqlDetalleEje" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetDETALLEEJECUCIONByIdProyectoDetallado" 
        SelectCommandType="StoredProcedure">
         <SelectParameters>
             <asp:SessionParameter Name="IdProyecto" SessionField="IdProyecto" 
                 Type="Int32" />
         </SelectParameters>
    </asp:SqlDataSource>
                                                                                                                            

      <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }

        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }

      
       
       
     </script>
    </telerik:RadCodeBlock>
     </asp:Content>
