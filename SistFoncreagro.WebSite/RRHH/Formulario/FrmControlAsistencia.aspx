<%@ Page Title="Control de Asistencia" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmControlAsistencia.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmControlAsistencia" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%" class="tabla5">
        <tr>
            <td >
                                                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                                                    <tr class="Titulos">
                                                        <td class="Titulos">
                                                            control de asistencia</td>
                                                       
                                                        <td style="text-align: right">
                

        


                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar"  
                                                                CausesValidation="False" PostBackUrl="~/RRHH/Formulario/Plantilla.aspx" />
                

        


                                                            </td>
                                                       
                                                    </tr>
                                                </table>
                                                        </td>
        </tr>
        <tr>
            <td style="font-weight: 700; text-align: center">
                Fecha de control:
                <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" AutoPostBack="True" 
                    Culture="es-PE">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" autopostback="True"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" tooltip="Abrir calendario."></DatePopupButton>
                </telerik:RadDatePicker>
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td style="text-align: center; font-weight: 700">
                            Lista de Personal</td>
                        <td style="text-align: center; font-weight: 700">
                            Asistencia</td>
                    </tr>
                    <tr>
                        <td valign="top" width="35%">
                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                CellSpacing="0" DataSourceID="odsPersonal" GridLines="None" Skin="Hay">
                                <ClientSettings>
                                    <Selecting AllowRowSelect="True" />
                                </ClientSettings>
<MasterTableView DataSourceID="odsPersonal" ClientDataKeyNames="IdPersonal" 
                                    DataKeyNames="IdPersonal">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="nombreCompleto" 
            FilterControlAltText="Filter nombreCompleto column" HeaderText="Personal" 
            ReadOnly="True" SortExpression="nombreCompleto" UniqueName="nombreCompleto">
            <HeaderStyle HorizontalAlign="Center" Width="80%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroDI" 
            FilterControlAltText="Filter NroDI column" HeaderText="DNI" 
            SortExpression="NroDI" UniqueName="NroDI">
            <HeaderStyle HorizontalAlign="Center" Width="20%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="PeriodoLaboral.IdPeriodoLaboral" 
            DataType="System.Int32" FilterControlAltText="Filter IdPeriodoLaboral column" 
            HeaderText="IdPeriodoLaboral" ReadOnly="True" SortExpression="IdPeriodoLaboral" 
            UniqueName="IdPeriodoLaboral" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdPersonal" DataType="System.Int32" 
            FilterControlAltText="Filter IdPersonal column" HeaderText="IdPersonal" 
            SortExpression="IdPersonal" UniqueName="IdPersonal" Visible="False">
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>
 <clientsettings allowkeyboardnavigation="True" enablepostbackonrowclick="True">
                <Selecting AllowRowSelect="True" />
            </clientsettings>
<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                            </telerik:RadGrid>
                            <asp:ObjectDataSource ID="odsPersonal" runat="server" 
                                SelectMethod="GetPERSONALinControlAsistencia" 
                                TypeName="SistFoncreagro.BussinesLogic.PersonalBL">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="RadDatePicker1" Name="Fecha" 
                                        PropertyName="SelectedDate" Type="DateTime" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                           
                           
                        </td>
                        <td valign="top" width="65%">
                            <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False" 
                                CellSpacing="0" DataSourceID="odsControlAsistencia" GridLines="None" Skin="Hay">
<MasterTableView DataSourceID="odsControlAsistencia" ClientDataKeyNames="IdControlAsistencia,IdPeriodoLaboral" 
                                    DataKeyNames="IdControlAsistencia,IdPeriodoLaboral">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="IdControlAsistencia" 
            DataType="System.Int32" 
            FilterControlAltText="Filter IdControlAsistencia column" 
            HeaderText="IdControlAsistencia" SortExpression="IdControlAsistencia" 
            UniqueName="IdControlAsistencia" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdPeriodoLaboral" DataType="System.Int32" 
            FilterControlAltText="Filter IdPeriodoLaboral column" 
            HeaderText="IdPeriodoLaboral" SortExpression="IdPeriodoLaboral" 
            UniqueName="IdPeriodoLaboral" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Turno" 
            FilterControlAltText="Filter Turno column" HeaderText="Turno" 
            SortExpression="Turno" UniqueName="Turno">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn3 column" 
            HeaderText="Faltó" UniqueName="TemplateColumn3">
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Eval("CondicionReal")="F" %>' />
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="HoraIngresoProg" 
            FilterControlAltText="Filter HoraIngresoProg column" 
            HeaderText="H.I. Prog." SortExpression="HoraIngresoProg" 
            UniqueName="HoraIngresoProg">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            HeaderText="H.I. Real" UniqueName="TemplateColumn">
            <ItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Width="50px" 
                    Text='<%# Eval("HoraIngresoReal") %>'></asp:TextBox>
                            <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                Mask="99:99" MaskType="Time" TargetControlID="TextBox1" 
                                UserTimeFormat="TwentyFourHour">
                            </asp:MaskedEditExtender>
                            <asp:RegularExpressionValidator runat="server" 
                                ID="RegularExpressionValidator1"      ControlToValidate="TextBox1" 
                                Display="Dynamic" ErrorMessage="¡Hora incorrecta!"      
                                ValidationExpression="\d*[0-2]\d*[0-9]:\d*[0-5]\d*[0-9]" /> 
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="HoraSalidaProg" 
            FilterControlAltText="Filter HoraSalidaProg column" 
            HeaderText="H.S. Prog." SortExpression="HoraSalidaProg" 
            UniqueName="HoraSalidaProg">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            HeaderText="H.S. Real" UniqueName="TemplateColumn1">
            <ItemTemplate>
                 <asp:TextBox ID="TextBox2" runat="server" Width="50px" 
                     Text='<%# Eval("HoraSalidaReal") %>'></asp:TextBox>
                            <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                Mask="99:99" MaskType="Time" TargetControlID="TextBox2" 
                                UserTimeFormat="TwentyFourHour">
                            </asp:MaskedEditExtender>
                            <asp:RegularExpressionValidator runat="server" 
                                ID="RegularExpressionValidator2"      ControlToValidate="TextBox2" 
                                Display="Dynamic" ErrorMessage="¡Hora incorrecta!"      
                                ValidationExpression="\d*[0-2]\d*[0-9]:\d*[0-5]\d*[0-9]" /> 
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn2 column" 
            HeaderText="Comentario" UniqueName="TemplateColumn2">
            <ItemTemplate>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" 
                    Text='<%# Eval("Observacion") %>'></asp:TextBox>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Grabar" 
            FilterControlAltText="Filter grabar column" ImageUrl="~\img\aceptar.gif" 
            UniqueName="grabar">
        </telerik:GridButtonColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>


<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Hay"></HeaderContextMenu>
                            </telerik:RadGrid>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadDatePicker1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadGrid1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadGrid2">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
    
                            <asp:ObjectDataSource ID="odsControlAsistencia" runat="server" 
                                SelectMethod="GetControlAsistenciaByIdPersonalAndByFecha" 
                                TypeName="SistFoncreagro.BussinesLogic.ControlAsistenciaBL">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="RadGrid1" Name="IdPersonal" 
                                        PropertyName="SelectedValue" Type="Int32" DefaultValue="" />
                                    <asp:ControlParameter ControlID="RadDatePicker1" Name="Fecha" 
                                        PropertyName="SelectedDate" Type="DateTime" DefaultValue="01/01/2011" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            
</asp:Content>
