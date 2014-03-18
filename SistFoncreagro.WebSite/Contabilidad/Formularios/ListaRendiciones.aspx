<%@ Page Title="Lista de Rendiciones" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaRendiciones.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaRendiciones" %>

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
                            lista de rendiciones</td>
                        <td  >
                            </td>
                        <td style="text-align: center; width:30px"   >
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td width="40%">
                            <telerik:RadGrid ID="RadGrid1" runat="server" Skin="Hay" 
                                DataSourceID="odsRendicion" 
                                AutoGenerateColumns="False" CellSpacing="0" Culture="es-PE" 
                                GridLines="None">
                                <GroupingSettings CaseSensitive="False" />
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
<MasterTableView CommandItemDisplay="Top" 
                                    DataSourceID="odsRendicion" NoDetailRecordsText="No existen registros." 
                                    NoMasterRecordsText="No existen registros." ClientDataKeyNames="IdRendicion" 
                                    DataKeyNames="IdRendicion">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Registro" RefreshText="Refrescar"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
       
        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
            FilterControlAltText="Filter EditCommandColumn column" UniqueName="editar">
            <HeaderStyle Width="3%" />
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro que desea Eliminar la Rendición?" ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
            Text="Eliminar" UniqueName="eliminar">
            <HeaderStyle Width="3%" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
            ConfirmDialogType="RadWindow" 
            ConfirmText="¿Está seguro que desea Anular la Rendición?" ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter anular column" ImageUrl="~\img\anular.gif" 
            Text="Anular" UniqueName="anular">
            <HeaderStyle Width="3%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="10%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Fecha" 
            FilterControlAltText="Filter Fecha column" HeaderText="Fecha" 
            SortExpression="Fecha" UniqueName="Fecha" 
            DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime">
            <HeaderStyle HorizontalAlign="Center" Width="15%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>


        <telerik:GridBoundColumn DataField="NomProyecto" 
            FilterControlAltText="Filter Proyecto column" HeaderText="Proyecto" 
            UniqueName="Proyecto" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="50%" />
            <ItemStyle HorizontalAlign="Left" />
        </telerik:GridBoundColumn>
       
        <telerik:GridTemplateColumn DataField="NomEstado" HeaderText="Estado" UniqueName="NomEstado"
                         SortExpression="NomEstado" 
            FilterControlWidth="80%" >
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("NomEstado") %>' ForeColor='<%# Color(Eval("NomEstado")) %>'></asp:Label>
            </ItemTemplate>
             <FilterTemplate>
                            <telerik:RadComboBox ID="RadComboBoxTitle"  DataTextField="NomEstado"
                                DataValueField="NomEstado"  AppendDataBoundItems="true" SelectedValue='<%# TryCast(Container,GridItem).OwnerTableView.GetColumn("NomEstado").CurrentFilterValue %>'
                                runat="server" OnClientSelectedIndexChanged="TitleIndexChanged" Width="100%">
                                <Items>
                                    <telerik:RadComboBoxItem Text="Todos" />
                                    <telerik:RadComboBoxItem runat="server" Selected="True" Text="Pendiente" 
                                        Value="Pendiente" />
                                    <telerik:RadComboBoxItem runat="server" Text="Para Aprobacion" Value="Para Aprobacion" />
                                    <telerik:RadComboBoxItem runat="server" Text="Aprobado" Value="Aprobado" />
                                    <telerik:RadComboBoxItem runat="server" Text="Observado" Value="Observado" />
                                    <telerik:RadComboBoxItem runat="server" Text="Anulado" Value="Anulado" />
                                </Items>
                            </telerik:RadComboBox>
                            <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">

                                <script type="text/javascript">
                                    function TitleIndexChanged(sender, args) {
                                        var tableView = $find("<%# TryCast(Container,GridItem).OwnerTableView.ClientID %>");
                                        tableView.filter("NomEstado", args.get_item().get_value(), "EqualTo");

                                    }
                                </script>

                            </telerik:RadScriptBlock>
                        </FilterTemplate>

<HeaderStyle Width="16%" HorizontalAlign="Center"></HeaderStyle>
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridTemplateColumn>

        <telerik:GridBoundColumn DataField="IdRendicion" DataType="System.Int32" 
            FilterControlAltText="Filter IdRendicion column" HeaderText="IdRendicion" 
            SortExpression="IdRendicion" UniqueName="IdRendicion" Visible="False">
        </telerik:GridBoundColumn>

       
    </Columns>

<EditFormSettings EditFormType="WebUserControl" 
        UserControlName="~\Contabilidad\Controles\ControlRecibo.ascx">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                            </telerik:RadGrid>
                            <asp:ObjectDataSource ID="odsRendicion" runat="server" 
                                SelectMethod="GetRENDICIONPendientes" 
                                TypeName="SistFoncreagro.BussinesLogic.RendicionBL">
                                <SelectParameters>
                                    <asp:SessionParameter Name="mes" SessionField="Mes" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
  
                            <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>
                            </asp:Content>
