<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmMarca.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmMarca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server"> 
    <fieldset>
        <legend>Marca</legend>
         <telerik:RadGrid ID="RadGrid2" runat="server" 
         AllowSorting="True" AutoGenerateColumns="False" CellSpacing="0" 
             DataSourceID="odsMarca" GridLines="None" 
                                CssClass="grid" Culture="eu-ES" Skin="Hay" 
            Width="500px">
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
         <MasterTableView DataKeyNames="IdMarca" DataSourceID="odsMarca" ClientDataKeyNames="IdMarca" 
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
            <ItemStyle Font-Size="8pt" Width="480px" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
    </Columns>
    <CommandItemSettings AddNewRecordText="Agregar Marca" RefreshText="Refrescar" />
        <EditFormSettings EditFormType="WebUserControl" UserControlName="~/Logistica/Controles/ControlManttoMarca.ascx">
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
        <asp:ObjectDataSource ID="odsMarca" runat="server" 
            SelectMethod="GetAllFromMarca" 
            TypeName="SistFoncreagro.BussinesLogic.MarcaBL">
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
