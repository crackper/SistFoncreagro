<%@ Page Title="Subdiarios" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaSubdiarios.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaSubdiarios" %>
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
                            subdiarios</td>
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
                <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsSubDiario" 
                                GridLines="None" Skin="Hay" PageSize="15" 
                    AllowFilteringByColumn="True">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="odsSubDiario" 
                        ClientDataKeyNames="IdSubDiario" 
                        NoMasterRecordsText="No existen registros.">
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar SubDiario" 
        exporttoexceltext="Exportar a Excel" showrefreshbutton="False" ShowExportToExcelButton="True" 
                            ShowExportToPdfButton="True">
                        </CommandItemSettings>
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                FilterControlAltText="Filter EditCommandColumn column" UniqueName="Editar">
                                <HeaderStyle Width="5%" />
                            </telerik:GridEditCommandColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
                                ConfirmDialogType="RadWindow" 
                                ConfirmText="¿Está seguro que desea Eliminar el SubDiario?" 
                                ConfirmTitle="Mensaje de Confirmación" 
                                FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
                                Text="Eliminar" UniqueName="Eliminar">
                                <HeaderStyle Width="5%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridTemplateColumn FilterControlAltText="Filter IdSubDiario column" 
                                HeaderText="Código" UniqueName="IdSubDiario" 
                                AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
                                DataField="IdSubDiario" FilterControlWidth="100%" ShowFilterIcon="False">
                                <EditItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# eval("IdSubDiario") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# eval("IdSubDiario") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" Width="5%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn FilterControlAltText="Filter Descripcion column" 
                                HeaderText="Descripción" UniqueName="Descripcion" 
                                AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
                                DataField="Descripcion" FilterControlWidth="100%" ShowFilterIcon="False">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# eval("Descripcion") %>' 
                                        Width="400px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                        ControlToValidate="TextBox1" Display="Dynamic" 
                                        ErrorMessage="¡Debe ingresar la Descripción!"></asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Width="400px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                        ControlToValidate="TextBox1" Display="Dynamic" 
                                        ErrorMessage="¡Debe ingresar la Descripción!"></asp:RequiredFieldValidator>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" Text='<%# eval("Descripcion") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" Width="35%" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
                                HeaderText="Operación Financiera" UniqueName="TemplateColumn1" 
                                AllowFiltering="False">
                                <EditItemTemplate>
                                    <asp:DropDownList ID="DropDownList2" runat="server" 
                                        DataSourceID="odsOpFinanciera" DataTextField="Descripcion" 
                                        DataValueField="IdOpFinanciera" SelectedValue='<%# Eval("IdOpFinanciera") %>' 
                                        Width="200px">
                                    </asp:DropDownList>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:DropDownList ID="DropDownList2" runat="server" 
                                        DataSourceID="odsOpFinanciera" DataTextField="Descripcion" 
                                        DataValueField="IdOpFinanciera" 
                                        Width="200px">
                                    </asp:DropDownList>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("NomOpFinanciera") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" Width="35%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                                HeaderText="Tipo Proceso" UniqueName="TemplateColumn" 
                                AllowFiltering="False">
                                <EditItemTemplate>
                                    <asp:DropDownList ID="DropDownList1" runat="server" 
                                        DataSourceID="odsTipoProceso" DataTextField="Descripcion" 
                                        DataValueField="IdTipoProceso" SelectedValue='<%# eval("IdTipoProceso") %>' 
                                        Width="200px">
                                    </asp:DropDownList>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:DropDownList ID="DropDownList1" runat="server" 
                                        DataSourceID="odsTipoProceso" DataTextField="Descripcion" 
                                        DataValueField="IdTipoProceso" Width="200px">
                                    </asp:DropDownList>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# eval("NomTipoProceso") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" Width="15%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn AllowFiltering="False" 
                                FilterControlAltText="Filter TemplateColumn2 column" HeaderText="Estado" 
                                ReadOnly="True" UniqueName="TemplateColumn2">
                                <ItemTemplate>
                                    <asp:Label ID="Label7" runat="server"  Text='<%# DescEstado(eval("Estado")) %>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
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
                <asp:ObjectDataSource ID="odsSubDiario" runat="server" 
                    SelectMethod="GetAllSUBDIARIO" 
                    TypeName="SistFoncreagro.BussinesLogic.SubdiarioBL" 
                    DataObjectTypeName="SistFoncreagro.BussinessEntities.Subdiario" 
                    InsertMethod="SaveSUBDIARIO" UpdateMethod="SaveSUBDIARIO"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="odsOpFinanciera" runat="server" 
                    SelectMethod="GetAllFromOperacionFinanciera" 
                    TypeName="SistFoncreagro.BussinesLogic.OperacionFinancieraBL">
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="odsTipoProceso" runat="server" 
                    SelectMethod="GetAllFromTIPOPROCESO" 
                    TypeName="SistFoncreagro.BussinesLogic.TipoProcesoBL">
                </asp:ObjectDataSource>
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
