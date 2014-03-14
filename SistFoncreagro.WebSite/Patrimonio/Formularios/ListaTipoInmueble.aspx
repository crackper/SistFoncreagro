<%@ Page Title="Tipos de Inmuebles" Language="vb" AutoEventWireup="false" MasterPageFile="~/Patrimonio/MasterPagePatrimonio.master" CodeBehind="ListaTipoInmueble.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmTipoInmueble" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
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
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td >
                            tipos de inmuebles</td>
                        <td  >
                            </td>
                        <td style="text-align: center; width:30px"   >
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Patrimonio/Formularios/DefaultPatrimonio.aspx" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td width="40%">
    <telerik:RadGrid ID="RadGrid2" runat="server" 
         AllowSorting="True" AutoGenerateColumns="False" CellSpacing="0" 
             DataSourceID="SqlTipos" GridLines="None" 
                                CssClass="grid" Culture="eu-ES" Skin="Hay" 
            Width="100%">
        <GroupingSettings CaseSensitive="False" />
    <ClientSettings>
        <Selecting AllowRowSelect="True" />
    </ClientSettings>
    <MasterTableView DataKeyNames="IdTipo" DataSourceID="SqlTipos" ClientDataKeyNames="IdTipo" 
                                    CommandItemDisplay="Top" 
            NoMasterRecordsText="No existen registros.">
        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Tipo" RefreshText="Refrescar">
        </CommandItemSettings>
        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            <HeaderStyle Width="20px"></HeaderStyle>
        </RowIndicatorColumn>
        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
            <HeaderStyle Width="20px"></HeaderStyle>
        </ExpandCollapseColumn>
        <Columns>
            <telerik:GridEditCommandColumn ButtonType="ImageButton" CancelText="Cancelar" EditText="Editar"
            InsertText="Insertar" UpdateText="Actualizar" 
            EditImageUrl="~/img/Edit.gif">
                <ItemStyle CssClass="cursor" HorizontalAlign="Center" Width="20px" />
            </telerik:GridEditCommandColumn>
            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
          ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro de Eliminar el Registro?" 
          ConfirmTitle="Mensaje de Confirmación" 
          FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
          Text="Anular" UniqueName="column">
                <ItemStyle CssClass="cursor" HorizontalAlign="Center" Width="20px" />
            </telerik:GridButtonColumn>
            <telerik:GridBoundColumn DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" 
            HeaderText="Tipo" SortExpression="Tipo" 
            UniqueName="Tipo" AutoPostBackOnFilter="True" 
                CurrentFilterFunction="Contains" FilterControlWidth="100%" 
                ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle Font-Size="8pt" Width="480px" HorizontalAlign="Center" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="PlanActivo" 
                FilterControlAltText="Filter PlanActivo column" HeaderText="Cta. Activo" 
                UniqueName="PlanActivo">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="PlanDepreciacion" 
                FilterControlAltText="Filter PlanDepreciacion column" 
                HeaderText="Cta. Depreciacion" UniqueName="PlanDepreciacion">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="PlanGasto" 
                FilterControlAltText="Filter PlanGasto column" HeaderText="Cta. Gasto" 
                UniqueName="PlanGasto">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="porcentaje" 
                FilterControlAltText="Filter porcentaje column" HeaderText="% Dep." 
                UniqueName="porcentaje" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="IdPlanActivo" 
                FilterControlAltText="Filter column1 column" UniqueName="column1" 
                Visible="False">
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="IdPlanDepreciacion" 
                FilterControlAltText="Filter column5 column" UniqueName="column5" 
                Visible="False">
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="IdPlanGasto" 
                FilterControlAltText="Filter column6 column" UniqueName="column6" 
                Visible="False">
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="IdPorcDepreciacion" 
                FilterControlAltText="Filter column7 column" UniqueName="column7" 
                Visible="False">
            </telerik:GridBoundColumn>
        </Columns>
        <CommandItemSettings AddNewRecordText="Agregar Clasificación" RefreshText="Refrescar" />
        <EditFormSettings EditFormType="WebUserControl" UserControlName="~/Patrimonio/Controles/ControlTipoInmueble.ascx">
            <EditColumn UniqueName="EditCommandColumn1">
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
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"  
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Formulario" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" OnClientClose="Validar" >
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
                                            
             

                                            
    <asp:SqlDataSource ID="SqlTipos" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetAllFromTIPOINMUEBLEDetallado" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                                            
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                <ClientEvents OnRequestStart="onRequestStart" />
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
    </telerik:RadAjaxManager>
     <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }
     </script>
    </telerik:RadCodeBlock>
                            </asp:Content>

