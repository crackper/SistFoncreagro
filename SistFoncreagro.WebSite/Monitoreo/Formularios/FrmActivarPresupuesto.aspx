<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmActivarPresupuesto.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmActivarPresupuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<table class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td style="width: 618px">
                            &nbsp;&nbsp;permiso presupuestal</td>
                        <td align="right">
                       
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar" 
                                PostBackUrl="~/Monitoreo/Formularios/Defecto.aspx" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                  <table style="width: 100%">
                        <tr>
                            <td align="left">
                <asp:Panel ID="Panel2" runat="server">
                    <table>
                        <tr>
                            <td align="right" style="width: 187px; height: 29px;">
                                <asp:ImageButton ID="BtnGrabar" runat="server" ImageUrl="~/img/grabar.gif" />
                            </td>
                            <td style="height: 29px;" colspan="3">
                                <asp:Label ID="LblPresup" runat="server" ForeColor="Red" 
                                    Text="No se ha activado ningún Proceso Presupuestal"></asp:Label>
                            </td>
                            <td style="height: 29px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 187px; height: 29px;">
                                Año:</td>
                            <td style="width: 246px; height: 29px;">
                                <telerik:RadNumericTextBox ID="TxtAnio" Runat="server" MaxLength="4" 
                                    MaxValue="9999" MinValue="2000">
                                    <NumberFormat DecimalDigits="0" GroupSeparator="" />
                                </telerik:RadNumericTextBox>
                            </td>
                            <td style="width: 47px; height: 29px">
                            </td>
                            <td align="right" style="height: 29px">
                                Mes inicio Presupuesto:</td>
                            <td style="height: 29px">
                                <asp:TextBox ID="TxtMesIni" runat="server" Width="125px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 187px">
                                Ejercicio Presupuestal:</td>
                            <td style="width: 246px">
                                <asp:TextBox ID="TxtEjerPresup" runat="server" Width="125px"></asp:TextBox>
                            </td>
                            <td style="width: 47px">
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
                            <td style="width: 47px">
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
                            <td align="left">
                <asp:Button ID="BtnGenerar" runat="server" Text="Listar Proyectos" />
                                   
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                <telerik:RadGrid ID="RGDatos" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="OdsActivarPresup" GridLines="None">
<MasterTableView ClientDataKeyNames="IdActPresup" DataKeyNames="IdActPresup" 
                        DataSourceID="OdsActivarPresup">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridTemplateColumn FilterControlAltText="Filter Activar column" 
            HeaderText="Activar" UniqueName="Activar">
            <ItemTemplate>
                <asp:CheckBox ID="ChActivar" runat="server" Checked='<%# Eval("Activar") %>' />
            </ItemTemplate>
            <HeaderStyle Width="10%" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="IdActPresup" DataType="System.Int32" 
            FilterControlAltText="Filter IdActPresup column" HeaderText="IdActPresup" 
            SortExpression="IdActPresup" UniqueName="IdActPresup" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Proyecto.Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            UniqueName="Codigo">
            <HeaderStyle Width="15%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Proyecto.Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
            UniqueName="Nombre">
            <HeaderStyle Width="75%" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                                   
                            </td>
                        </tr>
                        </table>
            
            </td>
        </tr>
    </table>
         <asp:ObjectDataSource ID="OdsActivarPresup" runat="server" 
                    SelectMethod="GetACTIVARPRESUPByIdEjerPresup" 
                    TypeName="SistFoncreagro.BussinesLogic.ActivarPresupuestoBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="HFIdEjerPresup" Name="_IdEjerPresup" 
                            PropertyName="Value" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <telerik:RadWindowManager ID="RWMensajes" runat="server">
                </telerik:RadWindowManager>
</asp:Content>
