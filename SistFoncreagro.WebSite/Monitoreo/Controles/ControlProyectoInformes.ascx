<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlProyectoInformes.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlProyectoInformes" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 194px;
    }
    .style3
    {
        width: 194px;
        height: 29px;
    }
    .style4
    {
        height: 29px;
    }
</style>

<table class="style1" style="font-family: Arial; font-size: 9pt">
    <tr>
        <td class="style2">
            <asp:ImageButton ID="BtnGrabar" runat="server"
                ImageUrl="~/img/Update.gif" 
                ToolTip="Grabar" />
            <asp:ImageButton ID="BtnCancelar" runat="server" ImageUrl="/img/cancel.gif"
            ToolTip="Cancelar" CausesValidation="False" 
               />
        </td>
        <td>
            <asp:HiddenField ID="HFIdInforme" runat="server" />
        </td>
    </tr>
    <tr>
        <td align="right" class="style2">
            Informe:</td>
        <td>
            <asp:FileUpload ID="FileUploadControl" runat="server" Width="536px" />
            <asp:HiddenField ID="HFIdArchivo" runat="server" />
            <br />
            <asp:Panel ID="Panel1" runat="server">
                <telerik:RadGrid ID="RGArchivo" runat="server" 
    CellSpacing="0" DataSourceID="OdsArchivos" GridLines="None" AutoGenerateColumns="False" 
                    Width="551px" ShowHeader="False">
                    <MasterTableView DataSourceID="OdsArchivos">
                        <CommandItemSettings ExportToPdfText="Export to PDF">
                        </CommandItemSettings>
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridButtonColumn CommandName="Borrar" 
                                FilterControlAltText="Filter column column" HeaderText="Eliminar" 
                                ImageUrl="~/img/delete.gif" UniqueName="column" Text="Eliminar">
                                <HeaderStyle Width="10%" />
                            </telerik:GridButtonColumn>
                            <telerik:GridBoundColumn DataField="IdAdjMonit" DataType="System.Int32" 
                                FilterControlAltText="Filter IdAdjMonit column" HeaderText="IdAdjMonit" 
                                SortExpression="IdAdjMonit" UniqueName="IdAdjMonit" Visible="False">
                                <HeaderStyle Width="0%" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Ruta" 
                                FilterControlAltText="Filter Ruta column" HeaderText="Informe" 
                                SortExpression="Ruta" UniqueName="Archivo">
                                <HeaderStyle Width="90%" />
                            </telerik:GridBoundColumn>
                        </Columns>
                        <EditFormSettings>
                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                            </EditColumn>
                        </EditFormSettings>
                    </MasterTableView>
                    <FilterMenu EnableImageSprites="False">
                    </FilterMenu>
                    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                    </HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsArchivos" runat="server" 
    SelectMethod="GetADJMONITByIdAdjMonit" 
    TypeName="SistFoncreagro.BussinesLogic.AdjMonitBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="HFIdArchivo" Name="_Id" PropertyName="Value" 
            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td align="right" class="style2">
            Tipo:</td>
        <td>
            <asp:DropDownList ID="CbTipo" runat="server" Height="18px" Width="168px">
                <asp:ListItem>MENSUAL</asp:ListItem>
                <asp:ListItem>TRIMESTRAL</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right" class="style2">
            Fecha Programada:</td>
        <td>
            <telerik:RadDatePicker ID="RDFeProg" Runat="server" Culture="es-PE" 
                Height="22px" Width="170px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" height="22px"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
            </telerik:RadDatePicker>
        </td>
    </tr>
    <tr>
        <td align="right" class="style2">
            Fecha de Presentacion:</td>
        <td>
            <telerik:RadDatePicker ID="RDFePres" Runat="server" Height="24px" 
                Width="170px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" height="24px"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
            </telerik:RadDatePicker>
        </td>
    </tr>
    <tr>
        <td align="right" class="style3">
            Estado:</td>
        <td class="style4">
            <asp:DropDownList ID="CbEstado" runat="server" Height="25px" Width="168px">
                <asp:ListItem>PRESENTO</asp:ListItem>
                <asp:ListItem>PENDIENTE</asp:ListItem>
            </asp:DropDownList>
            <br />
        </td>
    </tr>
</table>

