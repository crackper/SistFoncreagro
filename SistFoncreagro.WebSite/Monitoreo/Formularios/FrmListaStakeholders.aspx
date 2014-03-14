<%@ Page Title="StakeHolders" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmListaStakeholders.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaStakeholders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="tabla3">
        <tr>
            <td>
    <telerik:RadGrid ID="RadGrid4" runat="server" AllowFilteringByColumn="True" 
                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlStakeholders" 
                    GridLines="None" Skin="Hay" CssClass="tabla3">
        <GroupingSettings CaseSensitive="False" />
        <ClientSettings>
            <Selecting AllowRowSelect="True" />
        </ClientSettings>
        <MasterTableView CommandItemDisplay="Top" DataKeyNames="IdInteresado" 
                        DataSourceID="SqlStakeholders">
            <CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Stakeholder" RefreshText="Refrescar" 
        ShowRefreshButton="False">
            </CommandItemSettings>
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
     <asp:SqlDataSource ID="SqlStakeholders" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetINTERESADOSByIdProyectoDetallado" 
        SelectCommandType="StoredProcedure">
         <SelectParameters>
             <asp:SessionParameter Name="IdProyecto" SessionField="IdProyecto" 
                 Type="Int32" />
         </SelectParameters>
    </asp:SqlDataSource>
                                                                                                                            

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
     <ClientEvents />
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadGrid4">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid4" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid4" />
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
