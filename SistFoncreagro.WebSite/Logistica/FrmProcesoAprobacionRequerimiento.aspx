<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmProcesoAprobacionRequerimiento.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProcesoAprobacionRequerimiento" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function CargarVentana() {
        var oWnd = radopen("VentaResposablesRequerimiento.aspx", "Ventana");
        return false;
    }
</script>
</telerik:RadCodeBlock>
        <fieldset>
           <legend style="font-family: Arial; font-size: 15px; width: 310px;">Niveles de Aprobación de Requerimiento</legend>
            <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>
                        <telerik:RadGrid ID="RadGrid2" runat="server" 
         AllowSorting="True" AutoGenerateColumns="False" CellSpacing="0" 
             DataSourceID="odsAprobarRequerimiento" GridLines="None" 
                                CssClass="grid" Culture="eu-ES" Skin="Hay" 
            Width="700px">
<ClientSettings>
<Selecting AllowRowSelect="True" />
</ClientSettings>
         <MasterTableView DataKeyNames="IdAprobarRequerimiento" DataSourceID="odsAprobarRequerimiento" ClientDataKeyNames="IdAprobarRequerimiento" 
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
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="EliminarRegistro" 
          ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro de Eliminar el Registro?" 
          ConfirmTitle="Mensaje de Confirmación" 
          FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
          Text="Anular" UniqueName="column">
          <ItemStyle CssClass="cursor" HorizontalAlign="Center" Width="20px" />
       </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="NombreRol" 
            FilterControlAltText="FilterNombreRol" 
            HeaderText="Rol" SortExpression="NombreRol" 
            UniqueName="NombreRol">
            <HeaderStyle HorizontalAlign="Center" Width="300px" />
            <ItemStyle Font-Size="8pt" Width="300px" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            HeaderText="Orden" UniqueName="TemplateColumn">
            <ItemTemplate>
                <asp:TextBox ID="txtOrdenGrilla" runat="server" BorderStyle="None" 
                    ReadOnly="True" Text='<%# Bind("Orden") %>' Width="30px"></asp:TextBox>
            </ItemTemplate>
            <FooterStyle HorizontalAlign="Center" />
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="AreaProyecto" 
            HeaderText="Area / Proyecto" 
            UniqueName="AreaProyecto">
            <HeaderStyle HorizontalAlign="Center" Width="100px" />
            <ItemStyle Width="100px" Font-Size="8pt" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
    </Columns>
    <CommandItemSettings AddNewRecordText="Agregar Nivel de Aprobación" RefreshText="Refrescar" />
        <EditFormSettings EditFormType="WebUserControl" UserControlName="~/Logistica/Controles/ControlManttoNievelAprobacion.ascx">
            <EditColumn UniqueName="EditCommandColumn1">
            </EditColumn>
        </EditFormSettings>
</MasterTableView>
<FilterMenu EnableImageSprites="False"></FilterMenu>
<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
</telerik:RadGrid>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMensaje" runat="server" Font-Size="8pt" ForeColor="#FF3300" 
                            Visible="False"></asp:Label>
                        <br />
                        <asp:LinkButton ID="LinkButton1" runat="server" 
                            onclientclick="return CargarVentana();">Responsables</asp:LinkButton>
                        <br />
                    </td>
                </tr>
            </table>
        </fieldset>
        <br />
                   <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                    <Windows>
                    <telerik:RadWindow ID="Ventana" runat="server" Title="Resposables" Height="600px"
                        Width="960px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" EnableAriaSupport="True" KeepInScreenBounds="True" 
                            Overlay="True" />
                    </Windows>
                </telerik:RadWindowManager>
        <asp:ObjectDataSource ID="odsAprobarRequerimiento" runat="server" 
         SelectMethod="GetAllFromNivelesAprobarRequerimiento" 
         TypeName="SistFoncreagro.BussinesLogic.AprobarRequerimientoBL">
       </asp:ObjectDataSource>
         <asp:TextBox ID="TextBox1" runat="server" Height="0px" Visible="False" 
            Width="0px">0</asp:TextBox>
         <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
            Skin="Default">
        </telerik:RadAjaxLoadingPanel>
         <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
             <AjaxSettings>
                 <telerik:AjaxSetting AjaxControlID="RadGrid2">
                     <UpdatedControls>
                         <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                         <telerik:AjaxUpdatedControl ControlID="TextBox1" />
                     </UpdatedControls>
                 </telerik:AjaxSetting>
                 <telerik:AjaxSetting AjaxControlID="lbResposables">
                     <UpdatedControls>
                         <telerik:AjaxUpdatedControl ControlID="PanelDetalle" />
                     </UpdatedControls>
                 </telerik:AjaxSetting>
                 <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                     <UpdatedControls>
                         <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                             LoadingPanelID="RadAjaxLoadingPanel1" />
                     </UpdatedControls>
                 </telerik:AjaxSetting>
             </AjaxSettings>
        </telerik:RadAjaxManager>
</asp:Content>
