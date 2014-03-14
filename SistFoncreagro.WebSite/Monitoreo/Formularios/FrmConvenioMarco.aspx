<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmConvenioMarco.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmConvenioMarco" enableEventValidation="true" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type ="text/javascript">
            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }
            function CerrarVentana(indicador) {
                var oWnd = GetRadWindow();
                var oArg = new Object();
                oArg.indicador = indicador;
                oWnd.close(oArg);
            }
          </script>
    </telerik:RadCodeBlock>

    <table class="tabla3">
        <tr>
            <td align="right" >
                <table class="fondoTabla">
                    <tr>
                        <td align="left">
                            MANTENIMIENTO DE CONVENIOS MARCO</td>
                        <td>
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="OdsConvenioMarco" GridLines="None" 
                    Skin="Hay" AllowPaging="True">
<MasterTableView datasourceid="OdsConvenioMarco" CommandItemDisplay="Top" 
                        ClientDataKeyNames="IdConveMarco" DataKeyNames="IdConveMarco">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Registro"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridEditCommandColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter EditCommandColumn column" 
            EditText="Editar">
            <HeaderStyle Width = "1.5%" />
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter column column" 
            ImageUrl="~\img\delete.gif" UniqueName="column" CommandName="Delete" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro de eliminar el registro?" Text="Eliminar">
            <HeaderStyle Width = "1.5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdConveMarco" DataType="System.Int32" 
            FilterControlAltText="Filter IdConveMarco column" HeaderText="IdConveMarco" 
            SortExpression="IdConveMarco" UniqueName="IdConveMarco" Visible="False" 
            ReadOnly="True">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo">
            <HeaderStyle Width = "10%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
            SortExpression="Nombre" UniqueName="Nombre">
            <HeaderStyle Width="87%" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings EditFormType="WebUserControl" 
        UserControlName="~\Monitoreo\Controles\ControlConveMarco.ascx">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
        
                </td>
        </tr>
        <tr>
            <td style="width: 937px">
                <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                </telerik:RadWindowManager>
                <asp:TextBox ID="TxtIdConvenio" runat="server" Visible="False">0</asp:TextBox>
                <asp:ObjectDataSource ID="OdsConvenioMarco" runat="server" 
                    SelectMethod="GetAllFromConveMarco" 
                    TypeName="SistFoncreagro.BussinesLogic.ConveMarcoBL"></asp:ObjectDataSource>
                <asp:TextBox ID="TxtConveMarco" runat="server" BorderStyle="Dashed" 
                    Visible="False"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
