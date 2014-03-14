<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmClasificacionProductos.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmClasificacionProductos" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server"> 
    <fieldset>
        <legend>
            <asp:Label ID="lblTitulo" runat="server" Text="Clasificación de Productos"></asp:Label>
        </legend>
         <telerik:RadGrid ID="RadGrid2" runat="server" 
         AllowSorting="True" AutoGenerateColumns="False" CellSpacing="0" 
             DataSourceID="odsClasificacion" GridLines="None" 
                                CssClass="grid" Culture="eu-ES" Skin="Hay" 
            Width="890px">
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
         <MasterTableView DataKeyNames="IdClasificacion" DataSourceID="odsClasificacion" ClientDataKeyNames="IdClasificacion" 
                                    CommandItemDisplay="Top" NoMasterRecordsText="No existen registros.">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Registro"></CommandItemSettings>
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
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
          ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro de Eliminar el Registro?" 
          ConfirmTitle="Mensaje de Confirmación" 
          FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
          Text="Anular" UniqueName="column">
          <ItemStyle CssClass="cursor" HorizontalAlign="Center" Width="20px" />
       </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="Filter Rubro column" 
            HeaderText="Descripción" SortExpression="Rubro" 
            UniqueName="Rubro">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Font-Size="8pt" Width="400px" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NombrePlan" 
            FilterControlAltText="Filter Contacto column" HeaderText="Cuenta" SortExpression="Cuenta" 
            UniqueName="Contacto">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="450px" Font-Size="8pt" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
    </Columns>
    <CommandItemSettings AddNewRecordText="Agregar Clasificación" RefreshText="Refrescar" />
        <EditFormSettings EditFormType="WebUserControl" UserControlName="~/Logistica/Controles/ControlManttoClasificacion.ascx">
            <EditColumn UniqueName="EditCommandColumn1">
            </EditColumn>
        </EditFormSettings>

</MasterTableView>
<FilterMenu EnableImageSprites="False"></FilterMenu>
<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
</telerik:RadGrid>
    </fieldset>
    <br />
        <asp:TextBox ID="txtTipo" runat="server" Visible="False" Width="0px" 
            Height="0px" ReadOnly="True">0</asp:TextBox>
        <asp:ObjectDataSource ID="odsClasificacion" runat="server" 
            SelectMethod="GetFromClasificacionByTipo" 
            TypeName="SistFoncreagro.BussinesLogic.ClasificacionBL" 
        OldValuesParameterFormatString="original_{0}">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtTipo" Name="_Tipo" PropertyName="Text" 
                    Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadGrid2">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    </asp:Content>