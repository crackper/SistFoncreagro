<%@ Page Title="Tasas de Impuestos" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="ListaImpuestos.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaImpuestos" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
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
                            tasas de
                            impuestos</td>
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
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlParametros" 
                                GridLines="None" Skin="Hay" PageSize="15">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="SqlParametros" 
                        ClientDataKeyNames="IdParametro" 
                        NoMasterRecordsText="No existen registros." DataKeyNames="IdParametro">
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Impuesto" 
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
                                <HeaderStyle Width="2.5%" />
                            </telerik:GridEditCommandColumn>
                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
                                ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro de Anular el Registro?" 
                                ConfirmTitle="Mensaje de Confirmación" 
                                FilterControlAltText="Filter Anular column" ImageUrl="~\img\delete.gif" 
                                Text="Anular" UniqueName="Anular">
                                <HeaderStyle Width="2.5%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="IdParametro" DataType="System.Int32" 
                                FilterControlAltText="Filter IdParametro column" HeaderText="IdParametro" 
                                ReadOnly="True" SortExpression="IdParametro" UniqueName="IdParametro" 
                                Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                                HeaderText="Impuesto" UniqueName="TemplateColumn">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Nombre") %>' 
                                        Width="300px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                        ControlToValidate="TextBox1" Display="Dynamic" 
                                        ErrorMessage="¡Debe ingresar el nombre del Impuesto!"></asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Width="300px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                        ControlToValidate="TextBox2" Display="Dynamic" 
                                        ErrorMessage="¡Debe ingresar el nombre del Impuesto!"></asp:RequiredFieldValidator>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" Width="25%" />
                                <ItemStyle HorizontalAlign="Left" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn DataField="Valor" 
                                FilterControlAltText="Filter TemplateColumn1 column" HeaderText="Valor" 
                                UniqueName="TemplateColumn1">
                                <EditItemTemplate>
                                    <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" 
                                        Culture="es-PE" DbValue='<%# Bind("Valor") %>' Width="125px">
                                    </telerik:RadNumericTextBox>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server">
                                    </telerik:RadNumericTextBox>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Valor", "{0:N2}") %>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn DataField="Montolimite" 
                                FilterControlAltText="Filter TemplateColumn2 column" HeaderText="Monto Límite" 
                                UniqueName="TemplateColumn2">
                                <EditItemTemplate>
                                    <telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" 
                                        Culture="es-PE" DbValue='<%# Bind("MontoLimite") %>' Width="125px">
                                    </telerik:RadNumericTextBox>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <telerik:RadNumericTextBox ID="RadNumericTextBox4" Runat="server">
                                    </telerik:RadNumericTextBox>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" 
                                        Text='<%# Eval("MontoLimite", "{0:N2}") %>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn DataField="FechaInicio" 
                                FilterControlAltText="Filter TemplateColumn3 column" HeaderText="Fecha Inicio" 
                                UniqueName="TemplateColumn3">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtDate" runat="server" 
                                        Text='<%# Bind("FechaInicio") %>' Width="70px" />
                                    <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                        TargetControlID="txtDate" />
                                    <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                        ControlExtender="MaskedEditExtender1" ControlToValidate="txtDate" 
                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                        ControlToValidate="txtDate" Display="Dynamic" 
                                        ErrorMessage="¡Debe ingresar la Fecha Contable!"></asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:TextBox ID="txtDate" runat="server" 
                                        Text='<%# Bind("FechaInicio") %>' Width="70px" />
                                    <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                        TargetControlID="txtDate" />
                                    <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                        ControlExtender="MaskedEditExtender1" ControlToValidate="txtDate" 
                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                        ControlToValidate="txtDate" Display="Dynamic" 
                                        ErrorMessage="¡Debe ingresar la Fecha Contable!"></asp:RequiredFieldValidator>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" 
                                        Text='<%# Eval("FechaInicio", "{0:d}") %>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn DataField="FechaFin" 
                                FilterControlAltText="Filter TemplateColumn4 column" HeaderText="Fecha Fin" 
                                UniqueName="TemplateColumn4">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtDate1" runat="server" Width="70px" 
                                        Text='<%# Bind("FechaFin") %>' />
                                    <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                        TargetControlID="txtDate1" />
                                    <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                        ControlExtender="MaskedEditExtender2" ControlToValidate="txtDate1" 
                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                </EditItemTemplate>
                               
                                <InsertItemTemplate>
                                    <asp:TextBox ID="txtDate1" runat="server" 
                                        Text='<%# Bind("FechaFin") %>' Width="70px" />
                                    <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                        TargetControlID="txtDate1" />
                                    <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                        ControlExtender="MaskedEditExtender2" ControlToValidate="txtDate1" 
                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                </InsertItemTemplate>
                               
                                <ItemTemplate>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("FechaFin", "{0:d}") %>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridBoundColumn DataField="Estado" 
                                FilterControlAltText="Filter column column" HeaderText="Estado" 
                                UniqueName="Estado" ReadOnly="True">
                                <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                <ItemStyle HorizontalAlign="Center" />
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
                <asp:SqlDataSource ID="SqlParametros" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetAllfromPARAMETROSDetallado" 
                    SelectCommandType="StoredProcedure">
                </asp:SqlDataSource>
                <asp:ObjectDataSource ID="OdsParametros" runat="server" 
                    SelectMethod="GetAllfromPARAMETROS" 
                    TypeName="SistFoncreagro.BussinesLogic.ParametrosBL"></asp:ObjectDataSource>
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

