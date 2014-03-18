<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmUnidadMedida.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmUnidadMedida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server"> 
    <fieldset>
        <legend>Unidad de Medida</legend>
         <telerik:RadGrid ID="RadGrid2" runat="server" 
         AllowSorting="True" AutoGenerateColumns="False" CellSpacing="0" 
             DataSourceID="odsUnidadMedida" GridLines="None" 
                                CssClass="grid" Culture="eu-ES" Skin="Hay" 
            Width="650px">
<ClientSettings>
<Selecting AllowRowSelect="True" />
</ClientSettings>
         <MasterTableView DataKeyNames="IdUnidadMedida" DataSourceID="odsUnidadMedida" ClientDataKeyNames="IdUnidadMedida" 
                                    CommandItemDisplay="Top" NoMasterRecordsText="No existen registros.">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Registro" RefreshText="Refrescar"></CommandItemSettings>
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
            <ItemStyle Font-Size="8pt" Width="350px" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Abreviacion" 
            FilterControlAltText="Filter Contacto column" HeaderText="Abreviación" SortExpression="Contacto" 
            UniqueName="Contacto">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="280px" Font-Size="8pt" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
    </Columns>
    <CommandItemSettings AddNewRecordText="Agregar Unidad de Medida" RefreshText="Refrescar" />
        <EditFormSettings EditFormType="WebUserControl" UserControlName="~/Logistica/Controles/ControlManttoUnidadMedida.ascx">
            <EditColumn UniqueName="EditCommandColumn1">
            </EditColumn>
        </EditFormSettings>

</MasterTableView>
<FilterMenu EnableImageSprites="False"></FilterMenu>
<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
</telerik:RadGrid>
    </fieldset>
    <br />
        <asp:TextBox ID="TextBox1" runat="server" Visible="False" Width="1px" 
            Height="1px">1</asp:TextBox>
        <asp:ObjectDataSource ID="odsUnidadMedida" runat="server" 
            SelectMethod="GetAllFromUnidadMedida" 
            TypeName="SistFoncreagro.BussinesLogic.UnidadMedidaBL">
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