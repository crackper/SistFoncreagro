<%@ Page Title="Plan Contable" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaPlanContable.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaPlanContable" %>
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
                        <td>
                            PLAN CONTABLE</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right; width:110px">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                            <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsPlanContable" 
                                GridLines="None" Skin="Hay" AllowFilteringByColumn="True" PageSize="30">
                                <GroupingSettings CaseSensitive="False" />
                                <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
<MasterTableView commanditemdisplay="Top" datasourceid="odsPlanContable" ClientDataKeyNames="IdPlan" 
                                    DataKeyNames="IdPlan" NoDetailRecordsText="No existen registros." 
                                    NoMasterRecordsText="No existen registros.">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Cuenta Contable" 
        exporttoexceltext="Exportar a Excel" showexporttoexcelbutton="True" 
        showexporttopdfbutton="True" showrefreshbutton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
            FilterControlAltText="Filter EditCommandColumn column">
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro que desea Eliminar la Cuenta Contable?" 
            ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
            Text="Eliminar" UniqueName="column">
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdPlan" DataType="System.Int32" 
            FilterControlAltText="Filter IdPlan column" HeaderText="IdPlan" 
            SortExpression="IdPlan" UniqueName="IdPlan" Visible="False" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            ShowFilterIcon="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="StartsWith" ShowFilterIcon="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
            SortExpression="Nombre" UniqueName="Nombre" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Nivel" 
            FilterControlAltText="Filter Nivel column" HeaderText="Nivel" 
            SortExpression="Nivel" UniqueName="Nivel" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DscEstado" 
            FilterControlAltText="Filter Estado column" HeaderText="Estado" 
            SortExpression="Estado" UniqueName="Estado" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False">
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
     <asp:ObjectDataSource ID="odsPlanContable" runat="server" 
                                SelectMethod="GetAllPLANCONTABLE" 
                                TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
                            </asp:ObjectDataSource>
       
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
       
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
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  
                            </asp:Content>
