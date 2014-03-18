<%@ Page Title="Lista de Locales y Oficinas" Language="vb" AutoEventWireup="false" MasterPageFile="~/Patrimonio/MasterPagePatrimonio.master" CodeBehind="ListaLocales.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaLocales" %>
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
                            Lista de bienes muebles</td>
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
                            <telerik:RadGrid ID="RadGrid1" runat="server" 
                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="OdsLocales" 
                                GridLines="None" Skin="Hay">
<MasterTableView CommandItemDisplay="Top" DataKeyNames="IdLocal" DataSourceID="OdsLocales" 
                                    NoMasterRecordsText="No existen registros." ClientDataKeyNames="IdLocal">
    <DetailTables>
        <telerik:GridTableView runat="server" ClientDataKeyNames="IdOficina" 
            DataKeyNames="IdOficina" DataSourceID="SqlOficinas" Name="Oficinas" 
            CommandItemDisplay="Top" BackColor="#CCCCCC" BorderColor="Black" 
            BorderStyle="Solid" BorderWidth="1pt" 
            NoDetailRecordsText="No existen Oficinas Registradas.">
            <ParentTableRelation>
                <telerik:GridRelationFields DetailKeyField="IdLocal" MasterKeyField="IdLocal" />
            </ParentTableRelation>
            <CommandItemSettings ExportToPdfText="Export to PDF" 
                AddNewRecordText="Agregar Oficina" ShowRefreshButton="False" />
            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                <HeaderStyle Width="20px" />
            </RowIndicatorColumn>
            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                <HeaderStyle Width="20px" />
            </ExpandCollapseColumn>
            <Columns>
                <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                    FilterControlAltText="Filter EditCommandColumn column" UniqueName="Editar">
                    <HeaderStyle Width="1.5%" />
                </telerik:GridEditCommandColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
                    ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro de Anular la Oficina?" 
                    ConfirmTitle="Mensaje de Confirmación" 
                    FilterControlAltText="Filter Anular column" ImageUrl="~\img\anular.gif" 
                    Text="Anular" UniqueName="Anular">
                    <HeaderStyle Width="1.5%" />
                </telerik:GridButtonColumn>
                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                    ConfirmDialogType="RadWindow" 
                    ConfirmText="¿Está seguro de Eliminar la Oficina?" 
                    ConfirmTitle="Mensaje de Confirmación" 
                    FilterControlAltText="Filter Eliminar column" ImageUrl="~\img\delete.gif" 
                    Text="Eliminar" UniqueName="Eliminar">
                    <HeaderStyle Width="1.5%" />
                </telerik:GridButtonColumn>
                <telerik:GridBoundColumn DataField="IdLocal" 
                    FilterControlAltText="Filter IdLocal column" HeaderText="IdLocal" 
                    UniqueName="IdLocal" Visible="False" ReadOnly="True">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="IdOficina" 
                    FilterControlAltText="Filter IdOficina column" HeaderText="IdOficina" 
                    UniqueName="IdOficina" Visible="False" ReadOnly="True">
                </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn DataField="Nombre" 
                    FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
                    UniqueName="Nombre">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Eval("Nombre") %>' 
                            Width="400px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TextBox7" Display="Dynamic" 
                            ErrorMessage="¡Debe ingresar el Nombre de la Oficina!"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Width="400px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TextBox8" Display="Dynamic" 
                            ErrorMessage="¡Debe ingresar el Nombre de la Oficina!"></asp:RequiredFieldValidator>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" Width="45%" />
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn DataField="Descripcion" 
                    FilterControlAltText="Filter Descripcion column" HeaderText="Descripcion" 
                    UniqueName="Descripcion">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%# Eval("Descripcion") %>' 
                            Width="400px"></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%# Eval("Descripcion") %>' 
                            Width="400px"></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" Width="45%" />
                </telerik:GridTemplateColumn>
                <telerik:GridBoundColumn DataField="Estado" 
                    FilterControlAltText="Filter Estado column" HeaderText="Estado" 
                    UniqueName="Estado" ReadOnly="True">
                    <HeaderStyle HorizontalAlign="Center" Width="5.5%" />
                    <ItemStyle HorizontalAlign="Center" />
                </telerik:GridBoundColumn>
            </Columns>
           <EditFormSettings 
                           EditColumn-ButtonType="ImageButton" EditColumn-CancelText="Cancelar" EditColumn-UpdateText="Grabar">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn1 column">
                            </EditColumn>
                        </EditFormSettings>
        </telerik:GridTableView>
    </DetailTables>
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Local" ShowRefreshButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
        Visible="True">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridEditCommandColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter EditCommandColumn column" EditText="Editar" 
            UniqueName="Editar">
            <HeaderStyle Width="1.5%" />
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
            ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro de Anular el Local?" 
            ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter column column" ImageUrl="~\img\anular.gif" 
            Text="Anular" UniqueName="Anular">
            <HeaderStyle Width="1.5%" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro de Eliminar el Local?" 
            ConfirmTitle="Mensaje de Confirmación" 
            FilterControlAltText="Filter Eliminar column" ImageUrl="~\img\delete.gif" 
            Text="Eliminar" UniqueName="Eliminar">
            <HeaderStyle Width="1.5%" />
        </telerik:GridButtonColumn>
        <telerik:GridTemplateColumn DataField="Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
            UniqueName="Nombre">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Nombre") %>' 
                    Width="400px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" Display="Dynamic" 
                    ErrorMessage="¡Debe ingresar el Nombre del Local!"></asp:RequiredFieldValidator>
            </EditItemTemplate>
            <InsertItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Width="400px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox2" Display="Dynamic" 
                    ErrorMessage="¡Debe ingresar el Nombre del Local!"></asp:RequiredFieldValidator>
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" Width="30%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Descripción" 
            UniqueName="Descripcion">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("Descripcion") %>' 
                    Width="400px"></asp:TextBox>
            </EditItemTemplate>
            <InsertItemTemplate>
                <asp:TextBox ID="TextBox4" runat="server" Width="400px"></asp:TextBox>
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" Width="30%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn DataField="Direccion" 
            FilterControlAltText="Filter Direccion column" HeaderText="Dirección" 
            UniqueName="Direccion">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Eval("Direccion") %>' 
                    Width="400px"></asp:TextBox>
            </EditItemTemplate>
            <InsertItemTemplate>
                <asp:TextBox ID="TextBox6" runat="server" Width="400px"></asp:TextBox>
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Direccion") %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" Width="30%" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="Estado" 
            FilterControlAltText="Filter Estado column" HeaderText="Estado" ReadOnly="True" 
            SortExpression="Estado" UniqueName="Estado">
            <HeaderStyle HorizontalAlign="Center" Width="5.5%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdLocal" DataType="System.Int32" 
            FilterControlAltText="Filter IdLocal column" HeaderText="IdLocal" 
            ReadOnly="True" SortExpression="IdLocal" UniqueName="IdLocal" Visible="False">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings 
                           EditColumn-ButtonType="ImageButton" EditColumn-CancelText="Cancelar" EditColumn-UpdateText="Grabar">
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
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
                                            
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <asp:SqlDataSource ID="SqlOficinas" 
        runat="server" ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="SELECT * FROM [OFICINA] WHERE ([IdLocal] = @IdLocal)" 
        
        InsertCommand="INSERT INTO OFICINA(Nombre, Descripcion, IdLocal,Estado) VALUES (@Nombre, @Descripcion, @IdLocal,'A')" 
        
        DeleteCommand="UPDATE OFICINA SET ESTADO='I' WHERE IdOficina = @IDOFICINA" UpdateCommand="UPDATE OFICINA SET NOMBRE=@NOMBRE, DESCRIPCION=@DESCRIPCION
WHERE IDOFICINA=@IDOFICINA">
                                                    <DeleteParameters>
                                                        <asp:Parameter Name="IDOFICINA" />
                                                    </DeleteParameters>
                                                    <InsertParameters>
                                                        <asp:Parameter Name="Nombre" />
                                                        <asp:Parameter Name="Descripcion" />
                                                        <asp:Parameter Name="IdLocal" />
                                                         
                                                    </InsertParameters>
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="RadGrid1" Name="IdLocal" 
                                                            PropertyName="SelectedValue" Type="Int32" />
                                                    </SelectParameters>
                                                    <UpdateParameters>
                                                        <asp:Parameter Name="NOMBRE" />
                                                        <asp:Parameter Name="DESCRIPCION" />
                                                        <asp:Parameter Name="IDOFICINA" />
                                                    </UpdateParameters>
    </asp:SqlDataSource>
  

        <asp:ObjectDataSource ID="OdsLocales" runat="server" 
    SelectMethod="GetAllFromLOCAL" TypeName="SistFoncreagro.BussinesLogic.LocalBL" 
            OldValuesParameterFormatString="original_{0}">
        </asp:ObjectDataSource>
  

                                                <asp:SqlDataSource ID="SqlLocales" 
        runat="server" ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="SELECT LOCAL.* FROM LOCAL" 
        DeleteCommand="UPDATE LOCAL SET ESTADO='I' WHERE IdLocal=@IdLocal" 
        InsertCommand="INSERT INTO LOCAL(Nombre, Descripcion, Direccion,Estado) VALUES (@Nombre, @Descripcion, @Direccion,'A')" 
        UpdateCommand="UPDATE LOCAL SET Nombre = @Nombre, Descripcion = @Descripcion, Direccion = @Direccion WHERE (IdLocal = @IdLocal)">
                                                    <DeleteParameters>
                                                        <asp:Parameter Name="IdLocal" />
                                                    </DeleteParameters>
                                                    <InsertParameters>
                                                        <asp:Parameter Name="Nombre" />
                                                        <asp:Parameter Name="Descripcion" />
                                                        <asp:Parameter Name="Direccion" />
                                                    </InsertParameters>
                                                    <UpdateParameters>
                                                        <asp:Parameter Name="Nombre" />
                                                        <asp:Parameter Name="Descripcion" />
                                                        <asp:Parameter Name="Direccion" />
                                                        <asp:Parameter Name="IdLocal" />
                                                    </UpdateParameters>
    </asp:SqlDataSource>
  

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

