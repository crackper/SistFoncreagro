<%@ Page Title="Tasas de depreciación" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaPorcDepreciacion.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaPorcDepreciacion" %>
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
                        <td style="height: 22px">
                            tasas de depreciación</td>
                        <td style="height: 22px">
                        </td>
                        <td style="text-align: right; width:110px; height: 22px;">
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
                <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="OdsPorcentajes" GridLines="None" Skin="Hay">
<MasterTableView ClientDataKeyNames="IdPorcDepreciacion" DataKeyNames="IdPorcDepreciacion" 
                        DataSourceID="OdsPorcentajes" NoMasterRecordsText="No existen registros." 
                        CommandItemDisplay="Top">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Tasa" RefreshText="Refrescar"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
            FilterControlAltText="Filter EditCommandColumn column">
            <HeaderStyle Width="2.5%" />
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro de Eliminar el Registro?" 
            ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
            Text="Eliminar" UniqueName="column">
            <HeaderStyle Width="2.5%" />
        </telerik:GridButtonColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            HeaderText="Tipo" UniqueName="TemplateColumn">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Tipo") %>' 
                    Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" Display="Dynamic" 
                    ErrorMessage="¡Debe ingresar el Tipo!"></asp:RequiredFieldValidator>
            </EditItemTemplate>
            <InsertItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" Display="Dynamic" 
                    ErrorMessage="¡Debe ingresar el Tipo!"></asp:RequiredFieldValidator>
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Tipo") %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" Width="40%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            HeaderText="Valor (%)" UniqueName="TemplateColumn1">
            <EditItemTemplate>
                <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" 
                    Culture="es-PE" DbValue='<%# Bind("Valor") %>' Width="50px">
                    <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                    <NumberFormat DecimalDigits="1" />
                </telerik:RadNumericTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="RadNumericTextBox1" Display="Dynamic" 
                    ErrorMessage="¡Debe ingresar el Valor!"></asp:RequiredFieldValidator>
            </EditItemTemplate>
            <InsertItemTemplate>
                <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" Width="50px">
                    <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                    <NumberFormat DecimalDigits="1" />
                </telerik:RadNumericTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="RadNumericTextBox2" Display="Dynamic" 
                    ErrorMessage="¡Debe ingresar el Valor!"></asp:RequiredFieldValidator>
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Valor") %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" Width="55%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="IdPorcDepreciacion" DataType="System.Int32" 
            FilterControlAltText="Filter IdPorcDepreciacion column" 
            HeaderText="IdPorcDepreciacion" SortExpression="IdPorcDepreciacion" 
            UniqueName="IdPorcDepreciacion" Visible="False" ReadOnly="True">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings EditColumn-ButtonType="ImageButton" EditColumn-CancelText="Cancelar" EditColumn-UpdateText="Grabar">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsPorcentajes" runat="server" 
                    SelectMethod="GetAllFromPorcDepreciacion" 
                    TypeName="SistFoncreagro.BussinesLogic.PorcDepreciacionBL">
                </asp:ObjectDataSource>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"  
        ReloadOnShow="True" >
    </telerik:RadWindowManager>
                                            
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" 
                    runat="server">
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
            </td>
        </tr>
    </table>
</asp:Content>
