<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmProyectoPresupuestoAnual.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProyectoPresupuestoAnual" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="LblProyecto" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
                    DynamicHorizontalOffset="2" Font-Names="Arial" Font-Size="Small" 
                    ForeColor="#284E98" StaticSubMenuIndent="10px">
                    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#B5C7DE" />
                    <DynamicSelectedStyle BackColor="#507CD1" />
                    <Items>
                        <asp:MenuItem Text="Ir a..." Value="Ir a...">
                            <asp:MenuItem Text="Estructura" Value="Estructura">
                                <asp:MenuItem Text="Convenio" Value="Convenio"></asp:MenuItem>
                                <asp:MenuItem Text="Componentes" Value="Componentes"></asp:MenuItem>
                                <asp:MenuItem Text="Actividades" Value="Actividades"></asp:MenuItem>
                                <asp:MenuItem Text="Centros de Costo" Value="CCostos"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="Datos Generales" Value="Datos"></asp:MenuItem>
                            <asp:MenuItem Text="Ambito/Beneficiarios" Value="Ambito"></asp:MenuItem>
                            <asp:MenuItem Text="Informes" Value="Informes"></asp:MenuItem>
                            <asp:MenuItem Text="Avance Físico" Value="AvanFis"></asp:MenuItem>
                            <asp:MenuItem Text="Forecast Mensual" Value="ForFin"></asp:MenuItem>
                            <asp:MenuItem Text="Forecast Anual" Value="ForAnual"></asp:MenuItem>
                        </asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <StaticSelectedStyle BackColor="#507CD1" />
                </asp:Menu>
                <asp:HiddenField ID="HIdProyecto" runat="server" />
                <telerik:RadWindowManager ID="RWMensajes" runat="server">
                </telerik:RadWindowManager>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblPresup" runat="server" ForeColor="Red" 
                    Text="No se ha activado ningún Proceso Presupuestal"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel2" runat="server">
                    <table style="width: 100%">
                        <tr>
                            <td align="right" style="width: 187px; height: 29px;">
                                Año:</td>
                            <td style="width: 246px; height: 29px;">
                                <telerik:RadNumericTextBox ID="TxtAnio" Runat="server" MaxLength="4" 
                                    MaxValue="9999" MinValue="2000" ReadOnly="True">
                                    <NumberFormat DecimalDigits="0" GroupSeparator="" />
                                </telerik:RadNumericTextBox>
                            </td>
                            <td style="width: 146px; height: 29px">
                                </td>
                            <td align="right" style="height: 29px">
                                Mes inicio Presupuesto:</td>
                            <td style="height: 29px">
                                <asp:TextBox ID="TxtMesIni" runat="server" Width="125px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 187px">
                                Ejercicio Presupuestal:</td>
                            <td style="width: 246px">
                                <asp:TextBox ID="TxtEjerPresup" runat="server" Width="125px" ReadOnly="True"></asp:TextBox>
                            </td>
                            <td style="width: 146px">
                                &nbsp;</td>
                            <td align="right">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 187px">
                                <asp:HiddenField ID="HFIdEjerPresup" runat="server" />
                            </td>
                            <td style="width: 246px">
                                &nbsp;</td>
                            <td style="width: 146px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="BtnNuevo" runat="server" Text="Nuevo Presupuesto" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="CbAnio" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                <asp:HiddenField ID="HFAnioActual" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RGDatos" runat="server" CellSpacing="0" GridLines="None" 
                    AutoGenerateColumns="False" DataSourceID="OdsPresupAnual" 
                    ShowFooter="True">
<MasterTableView clientdatakeynames="IdCCosto" datakeynames="IdCCosto" 
                        datasourceid="OdsPresupAnual">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="IdCCosto" DataType="System.Int32" 
            FilterControlAltText="Filter IdCCosto column" HeaderText="IdCCosto" 
            SortExpression="IdCCosto" UniqueName="IdCCosto" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Componente" 
            FilterControlAltText="Filter Componente column" HeaderText="Componente" 
            SortExpression="Componente" UniqueName="Componente">
            <HeaderStyle Width="25%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Actividad" 
            FilterControlAltText="Filter Actividad column" HeaderText="Actividad" 
            SortExpression="Actividad" UniqueName="Actividad">
            <HeaderStyle Width="25%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ElementoGasto" 
            FilterControlAltText="Filter ElementoGasto column" HeaderText="ElementoGasto" 
            SortExpression="ElementoGasto" UniqueName="ElementoGasto">
            <HeaderStyle Width="25%" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn DataField="PresupAnual" 
            FilterControlAltText="Filter Presupuesto column" HeaderText="Presupuesto" 
            UniqueName="Presupuesto" Aggregate="Sum" DataType="System.Decimal" 
            FooterAggregateFormatString="{0:0,0.00}" FooterText="Total:  ">
            <ItemTemplate>
                <asp:Label ID="LblPresup" runat="server" Text='<%# Eval("PresupAnual") %>'></asp:Label>
                <telerik:RadNumericTextBox ID="TxtPresup" Runat="server" Culture="es-PE" 
                    Value='<%# ValidarNumero(databinder.eval(container.dataitem, "PresupAnual")) %>' 
                    Width="125px">
                </telerik:RadNumericTextBox>
            </ItemTemplate>
            <HeaderStyle Width="15%" />
        </telerik:GridTemplateColumn>
        <telerik:GridButtonColumn CommandName="Grabar" 
            FilterControlAltText="Filter column column" HeaderText="Grabar" Text="Grabar" 
            UniqueName="column">
            <HeaderStyle Width="10%" />
        </telerik:GridButtonColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsPresupAnual" runat="server" 
                    SelectMethod="GetDatosPresupAnualByParameters" 
                    TypeName="SistFoncreagro.BussinesLogic.DatosPresupAnualBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="_IdProyecto" QueryStringField="IdProyecto" 
                            Type="Int32" />
                        <asp:ControlParameter ControlID="HFIdEjerPresup" Name="_IdEjerPresup" 
                            PropertyName="Value" Type="Int32" />
                        <asp:ControlParameter ControlID="CbAnio" Name="_Anio" 
                            PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadWindowManager ID="RWMensaje" runat="server">
                </telerik:RadWindowManager>
            </td>
        </tr>
    </table>
</asp:Content>
