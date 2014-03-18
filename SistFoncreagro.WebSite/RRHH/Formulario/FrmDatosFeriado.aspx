<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmDatosFeriado.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmDatosFeriado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td align="left" style="width: 146px">
                <asp:ImageButton ID="BtnGrabar" runat="server" ImageUrl="~/img/grabar.gif" />
                <asp:ImageButton ID="BtnCancelar" runat="server" ImageUrl="~/img/cancel.gif" 
                    Width="25px" />
            </td>
            <td>
                <asp:HiddenField ID="HFIdFeriado" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 146px">
                Fecha:</td>
            <td>
                <telerik:RadDatePicker ID="RDFecha" Runat="server">
                </telerik:RadDatePicker>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="RDFecha" ErrorMessage="Es necesario ingresar la fecha"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 146px">
                Origen:</td>
            <td>
                <asp:DropDownList ID="CbOrigen" runat="server" Height="19px" Width="215px">
                    <asp:ListItem>OFICIAL</asp:ListItem>
                    <asp:ListItem>NO OFICIAL</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 146px">
                Recuperable:</td>
            <td>
                <asp:DropDownList ID="CbRec" runat="server" Height="20px" Width="85px">
                    <asp:ListItem>NO</asp:ListItem>
                    <asp:ListItem>SI</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="BtnRec" runat="server" Text="Cronograma de Recuperacion" 
                    Visible="False" />
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 146px">
                &nbsp;</td>
            <td>
                <asp:Panel ID="Panel2" runat="server" Visible="False">
                    <table style="width: 100%">
                        <tr>
                            <td align="right" style="width: 245px">
                                Nro de días a recuperar:</td>
                            <td>
                                <telerik:RadNumericTextBox ID="TxtNDias" Runat="server">
                                </telerik:RadNumericTextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="TxtNDias" ErrorMessage="este dato es obligatorio"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 245px">
                                Desde que fecha:<br /> (debe ser un dia laborable)</td>
                            <td>
                                <telerik:RadDatePicker ID="RdFechaInicio" Runat="server">
                                </telerik:RadDatePicker>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ControlToValidate="RdFechaInicio" ErrorMessage="este dato es obligatorio"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 245px">
                                Hora Inicio:</td>
                            <td>
                                <telerik:RadTimePicker ID="RTInicio" Runat="server" Culture="es-ES" 
                                    Skin="Forest">
                                    <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                        ViewSelectorText="x">
                                    </Calendar>
                                    <DatePopupButton CssClass="" HoverImageUrl="" ImageUrl="" Visible="False" />
                                    <TimeView CellSpacing="-1" Columns="4" Culture="es-ES" EndTime="22:00:00" 
                                        Interval="00:30:00" StartTime="08:00:00" TimeFormat="hh:mm t">
                                    </TimeView>
                                    <TimePopupButton CssClass="" HoverImageUrl="" ImageUrl="" />
                                    <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy" Width="">
                                    </DateInput>
                                </telerik:RadTimePicker>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                    ControlToValidate="RTInicio" ErrorMessage="este dato es obligatorio"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 245px">
                                Hora Fin:</td>
                            <td>
                                <telerik:RadTimePicker ID="RTFin" Runat="server" Culture="es-ES" Skin="Forest">
                                    <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                        ViewSelectorText="x">
                                    </Calendar>
                                    <DatePopupButton CssClass="" HoverImageUrl="" ImageUrl="" Visible="False" />
                                    <TimeView CellSpacing="-1" Columns="4" Culture="es-ES" EndTime="22:00:00" 
                                        Interval="00:30:00" StartTime="08:00:00">
                                    </TimeView>
                                    <TimePopupButton CssClass="" HoverImageUrl="" ImageUrl="" />
                                    <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy" Width="">
                                    </DateInput>
                                </telerik:RadTimePicker>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                    ControlToValidate="RTFin" ErrorMessage="este dato es obligatorio"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 245px">
                                Turno:</td>
                            <td>
                                <asp:DropDownList ID="CbTurno" runat="server" DataSourceID="OdsTurno" 
                                    DataTextField="DatosTurno" DataValueField="IdTurno" Width="347px">
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="OdsTurno" runat="server" 
                                    SelectMethod="GetAllFromTURNOSREGULARES" 
                                    TypeName="SistFoncreagro.BussinesLogic.TurnosRegularesBL">
                                </asp:ObjectDataSource>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                    ControlToValidate="CbTurno" ErrorMessage="este dato es obligatorio"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 245px">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="BtnGenerar" runat="server" 
                                    Text="Generar Calendario de Recuperación" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                &nbsp;</td>
            <td>
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <telerik:RadGrid ID="RGRecuperacion" runat="server" AutoGenerateColumns="False" 
                                    CellSpacing="0" DataSourceID="OdsCronRecup" GridLines="None">
                                    <MasterTableView DataSourceID="OdsCronRecup">
                                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                            <HeaderStyle Width="20px" />
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                            <HeaderStyle Width="20px" />
                                        </ExpandCollapseColumn>
                                        <Columns>
                                            <telerik:GridBoundColumn DataField="IdRecuperacion" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdRecuperacion column" HeaderText="IdRecuperacion" 
                                                SortExpression="IdRecuperacion" UniqueName="IdRecuperacion">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="IdFeriado" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdFeriado column" HeaderText="IdFeriado" 
                                                SortExpression="IdFeriado" UniqueName="IdFeriado">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="Fecha" DataType="System.DateTime" 
                                                FilterControlAltText="Filter Fecha column" HeaderText="Fecha" 
                                                SortExpression="Fecha" UniqueName="Fecha">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="IdTurno" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdTurno column" HeaderText="IdTurno" 
                                                SortExpression="IdTurno" UniqueName="IdTurno">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="IdHorario" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdHorario column" HeaderText="IdHorario" 
                                                SortExpression="IdHorario" UniqueName="IdHorario">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="IdJornadaTrabajo" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdJornadaTrabajo column" 
                                                HeaderText="IdJornadaTrabajo" SortExpression="IdJornadaTrabajo" 
                                                UniqueName="IdJornadaTrabajo">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="HoraInicio" 
                                                FilterControlAltText="Filter HoraInicio column" HeaderText="HoraInicio" 
                                                SortExpression="HoraInicio" UniqueName="HoraInicio">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="HoraFin" 
                                                FilterControlAltText="Filter HoraFin column" HeaderText="HoraFin" 
                                                SortExpression="HoraFin" UniqueName="HoraFin">
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
                                <asp:ObjectDataSource ID="OdsCronRecup" runat="server" 
                                    SelectMethod="GetCronogramaRecuperacionByIdFeriado" 
                                    TypeName="SistFoncreagro.BussinesLogic.CronogramaRecuperacionBL">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="HFIdFeriado" Name="_IdFeriado" 
                                            PropertyName="Value" Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 215px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
