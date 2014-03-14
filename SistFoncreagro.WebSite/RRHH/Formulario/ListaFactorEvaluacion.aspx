<%@ Page Title="Factores de Evaluación" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="ListaFactorEvaluacion.aspx.vb" Inherits="SistFoncreagro.WebSite.ListFactorEvaluacion" %>
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
                            factores de evaluacion</td>
                        <td style="height: 22px">
                        </td>
                        <td style="text-align: right; width:110px; height: 22px;">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/RRHH/Formulario/PrincipalRRHH.aspx" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid1" runat="server" 
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlFactores" 
                                GridLines="None" Skin="Hay" PageSize="15" 
                    AllowAutomaticDeletes="True" AllowAutomaticInserts="True" 
                    AllowAutomaticUpdates="True">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="SqlFactores" 
                        ClientDataKeyNames="IdFactor" 
                        NoMasterRecordsText="No existen registros." DataKeyNames="IdFactor" 
                        NoDetailRecordsText="No existen registros.">
                        <DetailTables>
                            <telerik:GridTableView runat="server" 
                                ClientDataKeyNames="IdCaracteristica" CommandItemDisplay="Top" 
                                DataKeyNames="IdCaracteristica" DataSourceID="SqlCaracteristica" 
                                Name="Caracteristica" NoMasterRecordsText="No existen registros." 
                                NoDetailRecordsText="No existen registros.">
                                <ParentTableRelation>
                                    <telerik:GridRelationFields DetailKeyField="IdFactor" 
                                        MasterKeyField="IdFactor" />
                                </ParentTableRelation>
                                <CommandItemSettings AddNewRecordText="Agregar Criterio de Evaluación" 
                                    ExportToPdfText="Export to PDF" ShowRefreshButton="False" />
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
                                        ConfirmTitle="Mensaje de Confirmación" 
                                        FilterControlAltText="Filter column column" Text="Eliminar" UniqueName="column">
                                        <HeaderStyle Width="1.5%" />
                                    </telerik:GridButtonColumn>
                                    <telerik:GridBoundColumn DataField="Descripcion" 
                                        FilterControlAltText="Filter Descripcion column" HeaderText="Descripcion" 
                                        UniqueName="Descripcion">
                                        <HeaderStyle Width="92%" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridCheckBoxColumn DataField="HabilitarComentario" 
                                        FilterControlAltText="Filter HabilitarComentario column" 
                                        HeaderText="Acepta Comentarios" UniqueName="HabilitarComentario">
                                        <HeaderStyle Width="5%" />
                                    </telerik:GridCheckBoxColumn>
                                    <telerik:GridBoundColumn DataField="IdCaracteristica" 
                                        FilterControlAltText="Filter IdCaracteristica column" 
                                        HeaderText="IdCaracteristica" ReadOnly="True" UniqueName="IdCaracteristica" 
                                        Visible="False">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="IdFactor" 
                                        FilterControlAltText="Filter IdFactor column" HeaderText="IdFactor" 
                                        ReadOnly="True" UniqueName="IdFactor" Visible="False">
                                    </telerik:GridBoundColumn>
                                </Columns>
                                <EditFormSettings EditColumn-ButtonType="ImageButton" EditColumn-CancelText="Cancelar" EditColumn-UpdateText="Grabar">
                                    <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                    </EditColumn>
                                </EditFormSettings>
                            </telerik:GridTableView>
                        </DetailTables>
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Factor de Evaluación" 
        exporttoexceltext="Exportar a Excel" showrefreshbutton="False">
                        </CommandItemSettings>
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                            Visible="True">
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
                            <telerik:GridBoundColumn DataField="IdFactor" DataType="System.Int32" 
                                FilterControlAltText="Filter IdFactor column" HeaderText="IdFactor" 
                                ReadOnly="True" SortExpression="IdFactor" UniqueName="IdFactor" Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Nombre" 
                                FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
                                SortExpression="Nombre" UniqueName="Nombre">
                                <HeaderStyle HorizontalAlign="Center" Width="97%" />
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings EditColumn-ButtonType="ImageButton" 
                            EditColumn-CancelText="Cancelar" EditColumn-UpdateText="Grabar">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:SqlDataSource ID="SqlCaracteristica" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    DeleteCommand="DeleteCARACTERISTICA" DeleteCommandType="StoredProcedure" 
                    InsertCommand="SaveCARACTERISTICA" InsertCommandType="StoredProcedure" 
                    SelectCommand="GetCARACTERISTICAByIdFactor" SelectCommandType="StoredProcedure" 
                    UpdateCommand="SaveCARACTERISTICA" UpdateCommandType="StoredProcedure">
                    <DeleteParameters>
                        <asp:Parameter Name="IdCaracteristica" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="IdCaracteristica" Type="Int32" />
                        <asp:Parameter Name="Descripcion" Type="String" />
                        <asp:Parameter Name="HabilitarComentario" Type="String" />
                        <asp:Parameter Name="IdFactor" Type="Int32" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="RadGrid1" Name="IdFactor" 
                            PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="IdCaracteristica" Type="Int32" />
                        <asp:Parameter Name="Descripcion" Type="String" />
                        <asp:Parameter Name="HabilitarComentario" Type="String" />
                        <asp:Parameter Name="IdFactor" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlFactores" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetAllFromFACTOREVALUACION" 
                    SelectCommandType="StoredProcedure" DeleteCommand="DeleteFACTOREVALUACION" 
                    DeleteCommandType="StoredProcedure" InsertCommand="SaveFACTOR" 
                    InsertCommandType="StoredProcedure" UpdateCommand="SaveFACTOR" 
                    UpdateCommandType="StoredProcedure">
                    <DeleteParameters>
                        <asp:Parameter Name="IdFactor" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="IdFactor" Type="Int32" />
                        <asp:Parameter Name="Nombre" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="IdFactor" Type="Int32" />
                        <asp:Parameter Name="Nombre" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
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

