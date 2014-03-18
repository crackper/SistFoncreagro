<%@ Page Title="StakeHolders" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterMonitoreo1.master" CodeBehind="FrmStakeholders.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmStakeholders" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                                                <table 
        style="width: 100%">
                                                    <tr>
                                                        <td style="height: 30px">
                                                                                    
                                                                                <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                                                                                </telerik:RadWindowManager>
                                                                                    
                                                                                <telerik:RadTabStrip ID="RadTabStrip1" runat="server" 
                                                                                    MultiPageID="RadMultiPage1" SelectedIndex="0" Width="100%">
                                                                                    <Tabs>
                                                                                        <telerik:RadTab runat="server" Text="Información General" Selected="True">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Actitud">
                                                                                        </telerik:RadTab>
                                                                                    </Tabs>
                                                                                </telerik:RadTabStrip>
                                                                                    
                                                                                </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="height: 30px">
                                                                                    
                                                                                <telerik:RadMultiPage ID="RadMultiPage1" Runat="server" SelectedIndex="0" 
                                                                                    Width="100%">
                                                                                    <telerik:RadPageView ID="RadPageView1" runat="server" Width="100%"><table 
                                                                                        align="center" class="tabla3"><tr><td style="text-align: left" valign="bottom"><table 
                                                                                                style="width: 100%"><tr><td width="5%"><asp:ImageButton ID="ImageButton3" 
                                                                                                    runat="server" BorderColor="Gray" BorderStyle="Solid" BorderWidth="0px" 
                                                                                                    ImageUrl="~/img/Grabar.gif" ToolTip="Grabar" /></td><td width="5%"><asp:ImageButton 
                                                                                                        ID="ImageButton4" runat="server" BorderColor="Gray" BorderStyle="Solid" 
                                                                                                        BorderWidth="0px" CausesValidation="False" ImageUrl="~/img/Nuevo.gif" 
                                                                                                        ToolTip="Nuevo" /></td><td style="text-align: right" width="80%">&nbsp;</td><td 
                                                                                                    style="text-align: left" width="10%">&nbsp;</td></tr></table></td></tr><tr><td><table 
                                                                                                cellspacing="0" class="0" style="width: 100%"><tr><td 
                                                                                                    class="Texto"><table style="width: 100%"><tr><td width="12%">Fecha de Registro:</td><td>
                                                                                                    <asp:TextBox ID="txtDate" runat="server" TabIndex="1" 
                                                                                                        Width="70px" />
                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender" runat="server" 
                                                                                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                        TargetControlID="txtDate" />
                                                                                                    <asp:MaskedEditValidator ID="MaskedEditValidator" runat="server" 
                                                                                                        ControlExtender="MaskedEditExtender" ControlToValidate="txtDate" 
                                                                                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" 
                                                                                                        ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                        ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator>
                                                                                                    </td><td 
                                                                                                        style="text-align: right">
                                                                                                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Red de Líderes" 
                                                                                                            TextAlign="Left" />
                                                                                                    </td><td>
                                                                                                        &nbsp;</td></tr><tr><td 
                                                                                                            width="12%">Caserio:</td><td colspan="3">
                                                                                                            <telerik:RadComboBox ID="RadComboBox1" 
                                                                                                                Runat="server" DataTextField="Nombre" DataValueField="CUBIGEO" 
                                                                                                                EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                ShowDropDownOnTextboxClick="False" Skin="Hay" style="margin-left: 0px" 
                                                                                                                TabIndex="2" Width="98%"></telerik:RadComboBox>
                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                                ErrorMessage="¡Debe ingresar el Caserio!"></asp:RequiredFieldValidator>
                                                                                                        </td></tr><tr><td 
                                                                                                            width="10%">Apellidos:</td><td width="38%">
                                                                                                            <asp:TextBox ID="TextBox1" runat="server" CssClass="Texto1" Width="98%" 
                                                                                                                TabIndex="3"></asp:TextBox>
                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" 
                                                                                                                ControlToValidate="TextBox1" Display="Dynamic" 
                                                                                                                ErrorMessage="¡Debe Ingresar los Apellidos!"></asp:RequiredFieldValidator>
                                                                                                        </td><td style="text-align: right" 
                                                                                                            width="12%">Nombres:</td><td valign="middle" width="38%">
                                                                                                            <asp:TextBox ID="TextBox2" runat="server" CssClass="Texto1" Width="98%" 
                                                                                                                TabIndex="4"></asp:TextBox>
                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" 
                                                                                                                ControlToValidate="TextBox2" Display="Dynamic" 
                                                                                                                ErrorMessage="¡Debe Ingresar el Nombre!"></asp:RequiredFieldValidator>
                                                                                                        </td></tr><tr><td>Dni:</td><td>
                                                                                                        <asp:TextBox ID="TextBox4" runat="server" CssClass="Texto1" TabIndex="5"></asp:TextBox>
                                                                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                                                                            ErrorMessage="¡Formato Incorrecto!" ControlToValidate="TextBox4" 
                                                                                                            Display="Dynamic" ValidationExpression="\d{8}"></asp:RegularExpressionValidator>
                                                                                                        </td><td 
                                                                                                            style="text-align: right">Teléfono:</td><td>
                                                                                                            <asp:TextBox ID="TextBox3" runat="server" CssClass="Texto1" TabIndex="6"></asp:TextBox>
                                                                                                        </td></tr>
                                                                                                    <tr>
                                                                                                        <td class="style4">
                                                                                                            Dirección:</td>
                                                                                                        <td class="style4">
                                                                                                            <asp:TextBox ID="TextBox5" runat="server" CssClass="Texto1" Width="98%" 
                                                                                                                TabIndex="7"></asp:TextBox>
                                                                                                        </td>
                                                                                                        <td class="style4" style="text-align: right">
                                                                                                        </td>
                                                                                                        <td class="style4">
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <td>
                                                                                                            Institución:</td>
                                                                                                        <td>
                                                                                                            <asp:DropDownList ID="DropDownList3" runat="server" AppendDataBoundItems="True" 
                                                                                                                DataSourceID="SqlInstitucopnes" DataTextField="Nombre" 
                                                                                                                DataValueField="IdInstitucion" Width="98%" TabIndex="8">
                                                                                                                <asp:ListItem Value="0">NINGUNA</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                        </td>
                                                                                                        <td style="text-align: right">
                                                                                                            Cargo:</td>
                                                                                                        <td>
                                                                                                            <asp:TextBox ID="TextBox6" runat="server" CssClass="Texto1" Width="98%" 
                                                                                                                TabIndex="9">POBLADOR</asp:TextBox>
                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" 
                                                                                                                ControlToValidate="TextBox6" Display="Dynamic" 
                                                                                                                ErrorMessage="¡Debe Ingresar el Cargo!"></asp:RequiredFieldValidator>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <td>
                                                                                                            Interes.:</td>
                                                                                                        <td>
                                                                                                            <asp:TextBox ID="TextBox7" runat="server" CssClass="Texto1" 
                                                                                                                TextMode="MultiLine" Width="98%" TabIndex="10"></asp:TextBox>
                                                                                                        </td>
                                                                                                        <td style="text-align: right">
                                                                                                            Actividad Económica:</td>
                                                                                                        <td>
                                                                                                            <asp:TextBox ID="TextBox8" runat="server" CssClass="Texto1" 
                                                                                                                TextMode="MultiLine" Width="98%" TabIndex="11"></asp:TextBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <td>
                                                                                                            Relaciones:</td>
                                                                                                        <td>
                                                                                                            <asp:TextBox ID="TextBox9" runat="server" CssClass="Texto1" 
                                                                                                                TextMode="MultiLine" Width="98%" TabIndex="12"></asp:TextBox>
                                                                                                        </td>
                                                                                                        <td style="text-align: right">
                                                                                                            Operaciones:</td>
                                                                                                        <td>
                                                                                                            <asp:TextBox ID="TextBox10" runat="server" CssClass="Texto1" 
                                                                                                                TextMode="MultiLine" Width="98%" TabIndex="13"></asp:TextBox>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                </table></td></tr></table></td></tr></table></telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView2" runat="server"><table class="tabla3" 
                                                                                        style="width: 100%"><tr><td>
                                                                                            <telerik:RadGrid ID="RadGrid4" runat="server" 
                                                                                                AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlActitud" 
                                                                                                GridLines="None" Skin="Hay">
                                                                                            <mastertableview 
                                                                                                clientdatakeynames="IdActitud" commanditemdisplay="Top" 
                                                                                                datakeynames="IdActitud" datasourceid="SqlActitud" 
                                                                                                nomasterrecordstext="No existen registros.">
                                                                                                <commanditemsettings 
                                                                                                addnewrecordtext="Agregar Actitud" exporttopdftext="Export to PDF" 
                                                                                                showrefreshbutton="False" /><rowindicatorcolumn 
                                                                                                filtercontrolalttext="Filter RowIndicator column"></rowindicatorcolumn><expandcollapsecolumn 
                                                                                                filtercontrolalttext="Filter ExpandColumn column"></expandcollapsecolumn><Columns>
                                                                                                    <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                        FilterControlAltText="Filter EditCommandColumn column">
                                                                                                        <HeaderStyle Width="1%" />
                                                                                                    </telerik:GridEditCommandColumn>
                                                                                                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                        ConfirmDialogType="RadWindow" 
                                                                                                        ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                                                                                        ConfirmTitle="Mensaje de Confirmación" 
                                                                                                        FilterControlAltText="Filter column column" UniqueName="column">
                                                                                                        <HeaderStyle Width="1%" />
                                                                                                    </telerik:GridButtonColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                                    DataField="IdActitud" FilterControlAltText="Filter IdActitud column" HeaderText="IdActitud" 
                                                                                                    SortExpression="IdActitud" UniqueName="IdActitud" DataType="System.Int32" 
                                                                                                        ReadOnly="True" Visible="False">
                                                                                                        </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                                    DataField="IdInteresado" FilterControlAltText="Filter IdInteresado column" 
                                                                                                    HeaderText="IdInteresado" SortExpression="IdInteresado" 
                                                                                                        UniqueName="IdInteresado" DataType="System.Int32" Visible="False">
                                                                                                        </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                                    DataField="Actitud" 
                                                                                                    FilterControlAltText="Filter Actitud column" HeaderText="Actitud" 
                                                                                                    SortExpression="Actitud" UniqueName="Actitud">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="7pt" />
                                                                                                        </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                                    DataField="Poder" 
                                                                                                    FilterControlAltText="Filter Poder column" HeaderText="Poder" 
                                                                                                    SortExpression="Poder" UniqueName="Poder">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="7pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn 
                                                                                                    DataField="Comentario" 
                                                                                                    FilterControlAltText="Filter Comentario column" HeaderText="Comentario" 
                                                                                                    SortExpression="Comentario" UniqueName="Comentario">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="41%" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="7pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="PlanAccion" 
                                                                                                        FilterControlAltText="Filter PlanAccion column" HeaderText="Plan Acción" 
                                                                                                        SortExpression="PlanAccion" UniqueName="PlanAccion">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="25%" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="7pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Dialogo" 
                                                                                                        FilterControlAltText="Filter Dialogo column" HeaderText="Dialogo" 
                                                                                                        SortExpression="Dialogo" UniqueName="Dialogo">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="7pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="FechaInicio" DataType="System.DateTime" 
                                                                                                        FilterControlAltText="Filter FechaInicio column" HeaderText="Fecha" 
                                                                                                        SortExpression="FechaInicio" UniqueName="FechaInicio" 
                                                                                                        DataFormatString="{0:dd/MM/yyyy}">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="8%" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="7pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdUsuario" DataType="System.Int32" 
                                                                                                        FilterControlAltText="Filter IdUsuario column" HeaderText="IdUsuario" 
                                                                                                        SortExpression="IdUsuario" UniqueName="IdUsuario" Visible="False">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="FechaFin" DataType="System.DateTime" 
                                                                                                        FilterControlAltText="Filter FechaFin column" HeaderText="FechaFin" 
                                                                                                        SortExpression="FechaFin" UniqueName="FechaFin" Visible="False">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                </Columns>
                                                                                                <editformsettings 
                                                                                                editformtype="WebUserControl" 
                                                                                                usercontrolname="~\Monitoreo\Controles\ControlActitud.ascx"><editcolumn 
                                                                                                filtercontrolalttext="Filter EditCommandColumn column"></editcolumn></editformsettings></mastertableview><filtermenu 
                                                                                                enableimagesprites="False"></filtermenu><headercontextmenu 
                                                                                                cssclass="GridContextMenu GridContextMenu_Default"></headercontextmenu></telerik:RadGrid>
                                                                                            </td></tr></table></telerik:RadPageView>
                                                                                </telerik:RadMultiPage>    
                                                                                </td>
                                                    </tr>
    </table>

<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function kH(e) {

            var pK = document.all ? window.event.keyCode : e.which;
            return pK != 13;
        }

        document.onkeypress = kH;
        if (document.layers) document.captureEvents(Event.KEYPRESS);


        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Mensaje");
        }

        function ValidarFecha() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarFecha");

        }
        function CargarVentana(nombre) {
            aviso = open("/SistIntegral/Monitoreo/Adjuntos/" + nombre, "Documento", "status=no, directories=no, toolbar=no, width=800, height=500, left=100, top=100")
            //        window.open("../Archivos1/Logistica/" + nombre, nombre, "width=800, height=500")    
        }
     </script>
    </telerik:RadCodeBlock>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="txtDate">
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>


    <asp:ObjectDataSource ID="OdsUbigeo" runat="server" 
        SelectMethod="GetUBIGEODATOSByParameter" 
        TypeName="SistFoncreagro.BussinesLogic.UbigeoDatosBL" 
        OldValuesParameterFormatString="original_{0}">
        <SelectParameters>
            <asp:Parameter DefaultValue="*" Name="texto" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    

                                                                                                                            <asp:SqlDataSource ID="SqlInstitucopnes" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetAllFromINSTITUCIONES" SelectCommandType="StoredProcedure">
                                                </asp:SqlDataSource>
                                                                                            <asp:SqlDataSource ID="SqlActitud" runat="server" 
                                                                                                ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                                                                SelectCommand="GetACTITUDINTERESADOByIdInteresado" 
                                                                                                
                                                    SelectCommandType="StoredProcedure">
                                                                                                <SelectParameters>
                                                                                                    <asp:QueryStringParameter Name="IdInteresado" QueryStringField="IdInteresado" 
                                                                                                        Type="Int32" />
                                                                                                </SelectParameters>
                                                                                            </asp:SqlDataSource>
                                                                                            <asp:SqlDataSource ID="SqlAnillos" 
                                                    runat="server" ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetAllFromANILLO" SelectCommandType="StoredProcedure">
                                                </asp:SqlDataSource>
    

                                                                                                                            </asp:Content>

