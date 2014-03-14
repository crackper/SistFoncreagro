<%@ Page Title="Actividades" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmListaActividades.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaActividades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
                <table class="tabla3">
                    <tr>
                        <td>
                <asp:Button ID="Button1" runat="server" Text="Copiar desde C. Costo" 
                    Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td>
    <telerik:RadGrid ID="RadGrid3" runat="server" DataSourceID="SqlSubActividades" 
                    Skin="Hay" AutoGenerateColumns="False" CellSpacing="0" 
        GridLines="None">
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
                        <telerik:GridBoundColumn DataField="Codigo" 
                    FilterControlAltText="Filter Codigo column" HeaderText="Código" 
                    UniqueName="Codigo">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="NomTarea" 
                    FilterControlAltText="Filter NomTarea column" HeaderText="Tarea" 
                    UniqueName="NomTarea">
                            <HeaderStyle HorizontalAlign="Center" />
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="IdSubActividad" 
                            FilterControlAltText="Filter IdSubActividad column" HeaderText="IdSubActividad" 
                            UniqueName="IdSubActividad" Visible="False">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Unidad" 
                            FilterControlAltText="Filter Unidad column" HeaderText="Unidad" 
                            UniqueName="Unidad">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Porcentaje" 
                            FilterControlAltText="Filter Porcentaje column" HeaderText="Porcentaje (%)" 
                            UniqueName="Porcentaje">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="FinalizaActividad" 
                            FilterControlAltText="Filter FinalizaActividad column" 
                            HeaderText="Finaliza Actividad" UniqueName="FinalizaActividad">
                        </telerik:GridBoundColumn>
                    </Columns>
                    <EditFormSettings EditFormType="WebUserControl" 
                        UserControlName="~\Monitoreo\Controles\ControlTarea.ascx">
                        <EditColumn FilterControlAltText="Filter EditCommandColumn1 column" 
                    UniqueName="EditCommandColumn1">
                        </EditColumn>
                    </EditFormSettings>
                </telerik:GridTableView>
            </DetailTables>
            <CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Sub Actividad" RefreshText="Refrescar" 
        ShowRefreshButton="False">
            </CommandItemSettings>
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
                <telerik:GridBoundColumn DataField="IdElemGasto" 
                    FilterControlAltText="Filter column1 column" UniqueName="column1" 
                    Visible="False">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IdProyAct" 
                    FilterControlAltText="Filter IdProyAct column" HeaderText="IdProyAct" 
                    UniqueName="IdProyAct" Visible="False">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Actividad" 
                    FilterControlAltText="Filter Actividad column" 
                    HeaderText="Componente/Actividad" UniqueName="Actividad">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Codigo" 
                    FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
                    UniqueName="Codigo">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="SubActividad" 
            FilterControlAltText="Filter NomTarea column" HeaderText="Sub Actividad" 
            ReadOnly="True" SortExpression="SubActividad" UniqueName="SubActividad">
                    <HeaderStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Unidad" 
            FilterControlAltText="Filter Unidad column" HeaderText="Unidad" 
            SortExpression="Unidad" UniqueName="Unidad">
                    <HeaderStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Porcentaje" 
                    FilterControlAltText="Filter Porcentaje column" HeaderText="%" 
                    UniqueName="Porcentaje">
                </telerik:GridBoundColumn>
            </Columns>
            <EditFormSettings EditFormType="WebUserControl" 
                UserControlName="~\Monitoreo\Controles\ControlSubActividad.ascx">
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
                <asp:SqlDataSource ID="SqlSubActividades" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetSUBACTIVIDADByIdProyecto" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="" Name="IdProyecto" 
                            SessionField="IdProyecto" Type="Int32" />
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
                                                                                                                            

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
     <ClientEvents />
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="Button1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid3" />
                    <telerik:AjaxUpdatedControl ControlID="RadCodeBlock1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadGrid3">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid3" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="Button1" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid3" />
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
        function alertCallBackFn(arg) {
            window.open("ListaDiario.aspx", "_self");
        }
        function confirmCallBackFn(arg) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Generar|" + arg);
        }       
       
     </script>
    </telerik:RadCodeBlock>
     </asp:Content>
    
