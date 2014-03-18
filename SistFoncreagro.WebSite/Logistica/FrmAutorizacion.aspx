<%@ Page Title="Autorizacion para enviar Requerimientos" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmAutorizacion.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmAutorizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
        <fieldset>
           <legend style="font-family: Arial; font-size: 15px; width: 310px;">Autorizacion para 
               enviar Requerimientos</legend>
            <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>
                        <telerik:RadGrid ID="RadGrid2" runat="server" 
         AllowSorting="True" AutoGenerateColumns="False" CellSpacing="0" 
             DataSourceID="SqlDataSource" GridLines="None" 
                                CssClass="grid" Culture="eu-ES" Skin="Hay" 
            Width="700px">
<ClientSettings>
<Selecting AllowRowSelect="True" />
</ClientSettings>
         <MasterTableView DataKeyNames="IdPermisoUsuario" DataSourceID="SqlDataSource" 
                                ClientDataKeyNames="IdPermisoUsuario" 
                                NoMasterRecordsText="No existen registros.">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Registro" RefreshText="Refrescar"></CommandItemSettings>
<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>
<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>
    <Columns>
        <telerik:GridEditCommandColumn EditText="Editar" 
            FilterControlAltText="Filter EditCommandColumn column" 
            ButtonType="ImageButton">
        </telerik:GridEditCommandColumn>
        <telerik:GridBoundColumn DataField="Nro" 
            FilterControlAltText="Filter Nro column" 
            HeaderText="Nº" SortExpression="Nro" 
            UniqueName="Nro" DataType="System.Int64" ReadOnly="True">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ApellidosNombres" 
            HeaderText="Apellidos y Nombres" 
            UniqueName="ApellidosNombres" 
            FilterControlAltText="Filter ApellidosNombres column" ReadOnly="True" 
            SortExpression="ApellidosNombres">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdPersonal" DataType="System.Int32" 
            FilterControlAltText="Filter IdPersonal column" HeaderText="IdPersonal" 
            ReadOnly="True" SortExpression="IdPersonal" UniqueName="IdPersonal" 
            Visible="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdPermisoUsuario" 
            FilterControlAltText="Filter column column" UniqueName="column" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Estado" 
            FilterControlAltText="Filter column1 column" HeaderText="Estado" 
            UniqueName="column1">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
    </Columns>
  
<EditFormSettings>
<EditColumn UniqueName="EditCommandColumn1" FilterControlAltText="Filter EditCommandColumn1 column"></EditColumn>
</EditFormSettings>
  
</MasterTableView>
<FilterMenu EnableImageSprites="False"></FilterMenu>
<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
</telerik:RadGrid>
                        <asp:SqlDataSource ID="SqlDataSource" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:cnx %>" 
                            SelectCommand="GetPERMISOUSUARIO" SelectCommandType="StoredProcedure">
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </fieldset>
        <br />
                   <telerik:RadWindowManager ID="RadWindowManager1" runat="server" 
            Width="500px">
                    <Windows>
                    <telerik:RadWindow ID="Ventana" runat="server" Title="Resposables" Height="300px"
                        Width="500px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" EnableAriaSupport="True" KeepInScreenBounds="True" OnClientClose="Validar"
                            Overlay="True" />
                    </Windows>
                </telerik:RadWindowManager>
         <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
             <AjaxSettings>
                 <telerik:AjaxSetting AjaxControlID="RadGrid2">
                     <UpdatedControls>
                         <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
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
          <telerik:RadCodeBlock ID="RadCodeBlock2" runat="server">
    <script type="text/javascript">
        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }

        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }
   
     </script>
    </telerik:RadCodeBlock>
</asp:Content>

