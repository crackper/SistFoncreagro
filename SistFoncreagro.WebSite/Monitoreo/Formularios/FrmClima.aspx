<%@ Page Title="Clima Social" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmClima.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmClima" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="tabla3">
        <tr>
            <td>
    <telerik:RadGrid ID="RadGrid6" runat="server" AllowFilteringByColumn="True" 
                                AutoGenerateColumns="False" CellSpacing="0" 
                                DataSourceID="SqlCaserios" GridLines="None" Width="100%" 
                                CssClass="grid" Culture="es-PE" 
                                Skin="Hay">
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
        RefreshText="Refrescar">
            </CommandItemSettings>
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
                <asp:SqlDataSource ID="SqlCaserios" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetCLIMASOCIALByIdProyectoDetallado" 
        SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:SessionParameter Name="IdProyecto" SessionField="IdProyecto" 
                            Type="Int32" />
                    </SelectParameters>
    </asp:SqlDataSource>
                                                                                                                            

                <asp:SqlDataSource ID="SqlClimaUbigeo" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetCLIMASOCIALByIdUbigeo" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="RadGrid6" Name="CUBIGEO" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
    </asp:SqlDataSource>
                                                                                                                            

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
     <ClientEvents />
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadGrid6">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid6" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid6" />
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
