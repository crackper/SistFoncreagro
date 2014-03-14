<%@ Page Title="Elaborar Encuesta" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="ListaEncuesta.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaEncuesta" %>
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
                            LISTADO DE ENCUESTAS</td>
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
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlEncuesta" 
                                GridLines="None" Skin="Hay" PageSize="15">
                    <GroupingSettings CaseSensitive="False" />
                    <SortingSettings SortedAscToolTip="Ordenado ascendente" 
                                    SortedDescToolTip="ordenado descendente" SortToolTip="Clic aqui para ordenar" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
                    <MasterTableView commanditemdisplay="Top" datasourceid="SqlEncuesta" 
                        ClientDataKeyNames="IdEncuesta" 
                        NoMasterRecordsText="No existen registros." DataKeyNames="IdEncuesta" 
                        NoDetailRecordsText="No existen registros.">
                        <DetailTables>
                            <telerik:GridTableView runat="server" 
                                ClientDataKeyNames="IdCaracteristica" CommandItemDisplay="Top" 
                                DataKeyNames="IdDetalle" DataSourceID="SqlDetalle" 
                                Name="Detalle" NoMasterRecordsText="No existen registros." 
                                NoDetailRecordsText="No existen registros.">
                                <ParentTableRelation>
                                    <telerik:GridRelationFields DetailKeyField="IdEncuesta" 
                                        MasterKeyField="IdEncuesta" />
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
                                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                        ConfirmDialogType="RadWindow" 
                                        ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                        ConfirmTitle="Mensaje de Confirmación" 
                                        FilterControlAltText="Filter column column" Text="Eliminar" UniqueName="column">
                                        <HeaderStyle Width="1.5%" />
                                    </telerik:GridButtonColumn>
                                    <telerik:GridBoundColumn DataField="Factor" 
                                        FilterControlAltText="Filter Factor column" HeaderText="Factor" 
                                        UniqueName="Factor">
                                        <HeaderStyle Width="20%" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="Caracteristica" 
                                        FilterControlAltText="Filter Caracteristica column" 
                                        HeaderText="Criterio de Evaluación" ReadOnly="True" 
                                        UniqueName="Caracteristica">
                                        <HeaderStyle Width="78.5%" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="IdFactor" 
                                        FilterControlAltText="Filter IdFactor column" HeaderText="IdFactor" 
                                        ReadOnly="True" UniqueName="IdFactor" Visible="False">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="IdEncuesta" 
                                        FilterControlAltText="Filter IdEncuesta column" HeaderText="IdEncuesta" 
                                        UniqueName="IdEncuesta" Visible="False">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="IdDetalle" 
                                        FilterControlAltText="Filter IdDetalle column" HeaderText="IdDetalle" 
                                        UniqueName="IdDetalle" Visible="False">
                                    </telerik:GridBoundColumn>
                                </Columns>
                                <EditFormSettings EditColumn-ButtonType="ImageButton" 
                                    EditColumn-CancelText="Cancelar" EditColumn-UpdateText="Grabar" 
                                    EditFormType="WebUserControl" 
                                    UserControlName="~\RRHH\Controles\ControlDetalleEncuesta.ascx">
                                    <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                    </EditColumn>
                                </EditFormSettings>
                            </telerik:GridTableView>
                        </DetailTables>
                        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Encuesta" 
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
                            <telerik:GridBoundColumn DataField="IdEncuesta" DataType="System.Int32" 
                                FilterControlAltText="Filter IdEncuesta column" HeaderText="IdEncuesta" 
                                ReadOnly="True" SortExpression="IdEncuesta" UniqueName="IdEncuesta" 
                                Visible="False">
                            </telerik:GridBoundColumn>
                            <telerik:GridTemplateColumn DataField="Descripcion" 
                                FilterControlAltText="Filter Descripcion column" HeaderText="Descripcion" 
                                UniqueName="Descripcion">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Descripcion") %>' 
                                        Width="300px"></asp:TextBox>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle Width="67%" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn DataField="FechaInicio" 
                                FilterControlAltText="Filter FechaInicio column" HeaderText="Inicio" 
                                UniqueName="FechaInicio">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtDate" runat="server" Width="70px" TabIndex="2" 
                                         Text='<%# Eval("FechaInicio") %>' />
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
                                        TabIndex="2" Width="70px" />
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
                                    <asp:Label ID="Label1" runat="server" 
                                        Text='<%# Eval("FechaInicio", "{0:d}") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle Width="15%" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn DataField="FechaFin" 
                                FilterControlAltText="Filter FechaFin column" HeaderText="Fin" 
                                UniqueName="FechaFin">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtDate2" runat="server" 
                                        TabIndex="2" Text='<%# Eval("FechaFin") %>' Width="70px" />
                                    <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                        TargetControlID="txtDate2" />
                                    <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                        ControlExtender="MaskedEditExtender2" ControlToValidate="txtDate2" 
                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                        ControlToValidate="txtDate2" Display="Dynamic" 
                                        ErrorMessage="¡Debe ingresar la Fecha Contable!"></asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:TextBox ID="txtDate2" runat="server"  
                                        TabIndex="2" Width="70px" />
                                    <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                        TargetControlID="txtDate2" />
                                    <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                        ControlExtender="MaskedEditExtender2" ControlToValidate="txtDate2" 
                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                        ControlToValidate="txtDate2" Display="Dynamic" 
                                        ErrorMessage="¡Debe ingresar la Fecha Contable!"></asp:RequiredFieldValidator>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("FechaFin", "{0:d}") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle Width="15%" />
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
                <asp:SqlDataSource ID="SqlDetalle" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    DeleteCommand="DeleteCARACTERISTICA" DeleteCommandType="StoredProcedure" 
                    InsertCommand="SaveCARACTERISTICA" InsertCommandType="StoredProcedure" 
                    SelectCommand="GetDETALLEENCUESTAByIdEncuestaDetallado" SelectCommandType="StoredProcedure" 
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
                        <asp:ControlParameter ControlID="RadGrid1" Name="IdEncuesta" 
                            PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="IdCaracteristica" Type="Int32" />
                        <asp:Parameter Name="Descripcion" Type="String" />
                        <asp:Parameter Name="HabilitarComentario" Type="String" />
                        <asp:Parameter Name="IdFactor" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlEncuesta" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetAllFromENCUESTA" 
                    SelectCommandType="StoredProcedure" DeleteCommand="DeleteENCUESTA" 
                    DeleteCommandType="StoredProcedure" InsertCommand="SaveENCUESTA" 
                    InsertCommandType="StoredProcedure" 
                    UpdateCommand="SaveENCUESTA" UpdateCommandType="StoredProcedure">
                    <DeleteParameters>
                        <asp:Parameter Name="IdEncuesta" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="IdEncuesta" Type="Int32" />
                        <asp:Parameter Name="FechaInicio" DbType="Date" />
                        <asp:Parameter DbType="Date" Name="FechaFin" />
                        <asp:Parameter Name="Descripcion" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="IdEncuesta" Type="Int32" />
                        <asp:Parameter Name="FechaInicio" DbType="Date" />
                        <asp:Parameter DbType="Date" Name="FechaFin" />
                        <asp:Parameter Name="Descripcion" Type="String" />
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


