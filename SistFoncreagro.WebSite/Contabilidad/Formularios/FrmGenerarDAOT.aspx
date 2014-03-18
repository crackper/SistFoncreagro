<%@ Page Title="Generar PDT de Operaciones con Terceros" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmGenerarDAOT.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmGenerarDAOT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    function onRequestStart(sender, args) {
        if (args.get_eventTarget().indexOf("ExportToExcelButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToCsvButton") >= 0 ||
                    args.get_eventTarget().indexOf("ExportToPdfButton") >= 0) {
            args.set_enableAjax(false);
        }
    }
    </script>
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            PDT DE OPeRACIONES CON TERCEROS</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Contabilidad/Formularios/DefaultContabilidad.aspx" 
                                ToolTip="Cerrar" CausesValidation="False" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table align="center" class="style1" width="100%" >
                    <tr class="Texto">
                        <td width="7%">
                            Valor UIT:</td>
                        <td style="text-align: left;  width="15%" width="10%">
                            <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server">
                                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                            </telerik:RadNumericTextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="RadNumericTextBox2" Display="Dynamic" 
                                ErrorMessage="¡Debe ingresar el valor de la UIT!"></asp:RequiredFieldValidator>
                        </td>
                        <td style="text-align: left; width: 38%;">
                                                                        <telerik:RadButton ID="RadButton1" runat="server" Skin="Telerik" 
                                                                            Text="Operaciones que generan Costos">
                                                                        </telerik:RadButton>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td style="height: 26px">
                            N° Límite de UIT:</td>
                        <td style="text-align: left; height: 26px;" width="10%">
                            <telerik:RadNumericTextBox ID="RadNumericTextBox3" Runat="server" Value="2">
                                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                            </telerik:RadNumericTextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="RadNumericTextBox3" Display="Dynamic" 
                                ErrorMessage="¡Debe ingresar el número límite de UIT!"></asp:RequiredFieldValidator>
                        </td>
                        <td style="text-align: left; height: 26px;">
                                                                        <telerik:RadButton ID="RadButton2" runat="server" 
                                                                            Text="Operaciones que generan Ingresos" Skin="Telerik">
                                                                        </telerik:RadButton>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td colspan="3">
                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                CellSpacing="0" GridLines="None" Width="100%" Skin="Hay">
<MasterTableView CommandItemDisplay="Top" NoMasterRecordsText="No existen registros.">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        ExportToCsvText="Exportar a texto" ExportToExcelText="Exportar a Excel" 
        ShowAddNewRecordButton="False" ShowExportToCsvButton="True" 
        ShowExportToExcelButton="True" ShowRefreshButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="Row" 
            FilterControlAltText="Filter column column" HeaderText="N°" UniqueName="column">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoDocDeclarante" 
            FilterControlAltText="Filter TipoDocDeclarante column" 
            HeaderText="TD.Declarante" UniqueName="TipoDocDeclarante" Visible="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="RucDeclarante" 
            FilterControlAltText="Filter RucDeclarante column" HeaderText="RucDeclarante" 
            UniqueName="RucDeclarante" Visible="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Periodo" 
            FilterControlAltText="Filter Periodo column" HeaderText="Periodo" 
            UniqueName="Periodo">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoPersonaDeclarado" 
            FilterControlAltText="Filter TipoPersonaDeclarado column" 
            HeaderText="Persona" UniqueName="TipoPersonaDeclarado">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="TipoDocDeclarado" 
            FilterControlAltText="Filter TipoDocDeclarado column" 
            HeaderText="Doc." UniqueName="TipoDocDeclarado">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="RucDeclarado" 
            FilterControlAltText="Filter RucDeclarado column" HeaderText="Ruc" 
            UniqueName="RucDeclarado">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Monto" 
            FilterControlAltText="Filter Monto column" UniqueName="Monto" 
            HeaderText="Monto">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Right" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ApellidoPaterno" 
            FilterControlAltText="Filter ApellidoPaterno column" 
            HeaderText="Apellido Paterno" UniqueName="ApellidoPaterno">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ApellidoMaterno" 
            FilterControlAltText="Filter column2 column" UniqueName="column2" 
            HeaderText="Apellido Materno">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="PrimerNombre" 
            FilterControlAltText="Filter column3 column" UniqueName="column3" 
            HeaderText="Primer Nombre">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SegundoNombre" 
            FilterControlAltText="Filter SegundoNombre column" HeaderText="Segundo Nombre" 
            UniqueName="SegundoNombre">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="RazonSocial" 
            FilterControlAltText="Filter RazonSocial column" UniqueName="RazonSocial" 
            HeaderText="Razon Social">
            <HeaderStyle HorizontalAlign="Center" />
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
                    <tr class="Texto">
                        <td colspan="3" style="height: 70px">
                            <asp:SqlDataSource ID="Costos" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="RepDAOTCostos" 
                                SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:Parameter Name="monto" Type="Decimal" />
                                    <asp:Parameter Name="anio" Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            <asp:SqlDataSource ID="Ingresos" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="RepDAOTIngresos" 
                                SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="0000" Name="monto" Type="Decimal" />
                                    <asp:Parameter DefaultValue="0000" Name="anio" Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            <asp:HiddenField ID="HiddenField1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: center">
                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                            <ClientEvents OnRequestStart="onRequestStart" />
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="RadButton1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="HiddenField1" />
                                            <telerik:AjaxUpdatedControl ControlID="Costos" />
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadButton2">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="Ingresos" />
                                            <telerik:AjaxUpdatedControl ControlID="HiddenField1" />
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                    <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>
                            </telerik:RadAjaxManager>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
