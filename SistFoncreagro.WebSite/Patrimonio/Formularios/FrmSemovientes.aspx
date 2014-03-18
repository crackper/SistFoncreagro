<%@ Page Title="Activo Biológico" Language="vb" AutoEventWireup="false" MasterPageFile="~/Patrimonio/MasterPatrimonio1.master" CodeBehind="FrmSemovientes.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmSemovientes" %>
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
                                                                                        <telerik:RadTab runat="server" Selected="True" Text="Información General">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Características">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Ubicación">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Archivos Adjuntos">
                                                                                        </telerik:RadTab>
                                                                                    </Tabs>
                                                                                </telerik:RadTabStrip>
                                                                                    
                                                                                </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="height: 30px">
                                                                                    
                                                                                <telerik:RadMultiPage ID="RadMultiPage1" Runat="server" SelectedIndex="0" 
                                                                                    Width="100%">
                                                                                    <telerik:RadPageView ID="RadPageView1" runat="server" Width="100%">

                                                                                       
                                                                                        <table align="center" class="tabla3">
                                                                                            <tr>
                                                                                                <td style="text-align: left" valign="bottom">
                                                                                                    <table style="width: 100%">
                                                                                                        <tr>
                                                                                                            <td width="5%">
                                                                                                                <asp:ImageButton ID="ImageButton3" runat="server" BorderColor="Gray" 
                                                                                                                    BorderStyle="Solid" BorderWidth="0px" ImageUrl="~/img/Grabar.gif" 
                                                                                                                    ToolTip="Grabar" />
                                                                                                            </td>
                                                                                                            <td width="5%">
                                                                                                                <asp:ImageButton ID="ImageButton4" runat="server" BorderColor="Gray" 
                                                                                                                    BorderStyle="Solid" BorderWidth="0px" CausesValidation="False" 
                                                                                                                    ImageUrl="~/img/Nuevo.gif"  ToolTip="Nuevo" />
                                                                                                            </td>
                                                                                                            <td style="text-align: right" width="80%">
                                                                                                                &nbsp;</td>
                                                                                                            <td style="text-align: left" width="10%">
                                                                                                                &nbsp;</td>
                                                                                                        </tr>
                                                                                                    </table>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td>
                                                                                                    <table cellspacing="0" class="0" style="width: 100%">
                                                                                                        <tr>
                                                                                                            <td class="Texto">
                                                                                                                <table style="width: 100%">
                                                                                                                    <tr>
                                                                                                                        <td width="10%">
                                                                                                                            Proy. Origen:</td>
                                                                                                                        <td width="88%">
                                                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AllowCustomText="True" 
                                                                                                                                DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                                                ShowMoreResultsBox="True" Skin="Hay" TabIndex="1" ValidationGroup="Transaccion" 
                                                                                                                                Width="100%">
                                                                                                                            </telerik:RadComboBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar el Proyecto!"></asp:RequiredFieldValidator>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td width="10%">
                                                                                                                            CPD:</td>
                                                                                                                        <td>
                                                                                                                            <telerik:RadComboBox ID="RadComboBox2" Runat="server" AllowCustomText="True" 
                                                                                                                                DataSourceID="SqlCPD" DataTextField="AreaProyecto" 
                                                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                                                ShowMoreResultsBox="True" Skin="Hay" TabIndex="2" ValidationGroup="Transaccion" 
                                                                                                                                Width="100%">
                                                                                                                            </telerik:RadComboBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                                                                                                                                ControlToValidate="RadComboBox2" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar el CPD!"></asp:RequiredFieldValidator>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                </table>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                        <tr>
                                                                                                            <td class="Texto">
                                                                                                                <table style="width: 100%">
                                                                                                                    <tr>
                                                                                                                        <td width="10%">
                                                                                                                            Nombre:</td>
                                                                                                                        <td width="41%">
                                                                                                                            <asp:TextBox ID="TextBox1" runat="server" Width="300px" CssClass="Texto1" 
                                                                                                                                TabIndex="3"></asp:TextBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                                                                                                                                ControlToValidate="TextBox1" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar el Nombre!"></asp:RequiredFieldValidator>
                                                                                                                        </td>
                                                                                                                        <td width="8%">
                                                                                                                            Color:</td>
                                                                                                                        <td width="41%" colspan="2" style="width: 82%">
                                                                                                                            <asp:TextBox ID="TextBox2" runat="server" CssClass="Texto1" TabIndex="4"></asp:TextBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" 
                                                                                                                                ControlToValidate="TextBox2" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar el Color!"></asp:RequiredFieldValidator>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td width="10%">
                                                                                                                            Microchip</td>
                                                                                                                        <td>
                                                                                                                            <asp:TextBox ID="TextBox3" runat="server" CssClass="Texto1" TabIndex="5"></asp:TextBox>
                                                                                                                        </td>
                                                                                                                        <td>
                                                                                                                            Arete:</td>
                                                                                                                        <td colspan="2">
                                                                                                                            <asp:TextBox ID="TextBox4" runat="server" CssClass="Texto1" TabIndex="6"></asp:TextBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                                                                                                                                ControlToValidate="TextBox4" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar el Arete!"></asp:RequiredFieldValidator>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td width="10%">
                                                                                                                            Fecha Nacim.:</td>
                                                                                                                        <td>
                                                                                                                            <asp:TextBox ID="txtDate" runat="server" AutoPostBack="True" TabIndex="7" 
                                                                                                                                Width="70px" />
                                                                                                                            <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" 
                                                                                                                                AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                                                TargetControlID="txtDate" />
                                                                                                                            <asp:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                                                                                                ControlExtender="MaskedEditExtender1" ControlToValidate="txtDate" 
                                                                                                                                Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                                                InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                                                                                                ControlToValidate="txtDate" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator>
                                                                                                                        </td>
                                                                                                                        <td>
                                                                                                                            Edad :</td>
                                                                                                                        <td valign="middle" width="15%">
                                                                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" TabIndex="8">
                                                                                                                            </telerik:RadNumericTextBox>
                                                                                                                            &nbsp;</td>
                                                                                                                        <td valign="middle">
                                                                                                                            (meses)<asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                                                                                                                                ControlToValidate="RadNumericTextBox1" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar la Edad!"></asp:RequiredFieldValidator>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            Especie:</td>
                                                                                                                        <td>
                                                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" 
                                                                                                                                DataSourceID="SqlEspecieAnimal" DataTextField="especie" 
                                                                                                                                DataValueField="idespecieanimal" TabIndex="9" Width="100%">
                                                                                                                            </asp:DropDownList>
                                                                                                                        </td>
                                                                                                                        <td>
                                                                                                                            Raza:</td>
                                                                                                                        <td colspan="2">
                                                                                                                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlRaza" 
                                                                                                                                DataTextField="raza" DataValueField="idrazaanimal" TabIndex="10" Width="100%">
                                                                                                                            </asp:DropDownList>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            Sexo:</td>
                                                                                                                        <td>
                                                                                                                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                                                                                                                RepeatDirection="Horizontal" TabIndex="11">
                                                                                                                                <asp:ListItem Value="M">Macho</asp:ListItem>
                                                                                                                                <asp:ListItem Value="H">Hembra</asp:ListItem>
                                                                                                                            </asp:RadioButtonList>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                                                                                                                                ControlToValidate="RadioButtonList1" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar el Sexo!"></asp:RequiredFieldValidator>
                                                                                                                        </td>
                                                                                                                        <td>
                                                                                                                            Descripción:</td>
                                                                                                                        <td colspan="2">
                                                                                                                            <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Width="100%" 
                                                                                                                                CssClass="Texto1" TabIndex="12"></asp:TextBox>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            Tipo Ingreso:</td>
                                                                                                                        <td>
                                                                                                                            <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
                                                                                                                                RepeatDirection="Horizontal" AutoPostBack="True" TabIndex="13">
                                                                                                                                <asp:ListItem Value="1">Interno</asp:ListItem>
                                                                                                                                <asp:ListItem Value="2">Externo</asp:ListItem>
                                                                                                                            </asp:RadioButtonList>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" 
                                                                                                                                ControlToValidate="RadioButtonList2" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar el Tipo de Ingreso!"></asp:RequiredFieldValidator>
                                                                                                                        </td>
                                                                                                                        <td>
                                                                                                                            Origen:</td>
                                                                                                                        <td colspan="2">
                                                                                                                            <telerik:RadComboBox ID="RadComboBox5" Runat="server" DataTextField="Nombre" 
                                                                                                                                DataValueField="CUBIGEO" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                                ShowDropDownOnTextboxClick="False" Skin="Hay" style="margin-left: 0px" 
                                                                                                                                TabIndex="14" Width="100%">
                                                                                                                            </telerik:RadComboBox>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            Padre:</td>
                                                                                                                        <td>
                                                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" Width="100%" 
                                                                                                                                AllowCustomText="True" DataSourceID="SqlMachos" DataTextField="Semoviente" 
                                                                                                                                DataValueField="IdSemoviente" EnableLoadOnDemand="True" 
                                                                                                                                ShowMoreResultsBox="True" TabIndex="15">
                                                                                                                            </telerik:RadComboBox>
                                                                                                                        </td>
                                                                                                                        <td>
                                                                                                                            Madre:</td>
                                                                                                                        <td colspan="2">
                                                                                                                            <telerik:RadComboBox ID="RadComboBox4" Runat="server" Width="100%" 
                                                                                                                                AllowCustomText="True" DataSourceID="SqlHembras" DataTextField="Semoviente" 
                                                                                                                                DataValueField="IdSemoviente" EnableLoadOnDemand="True" 
                                                                                                                                ShowMoreResultsBox="True" TabIndex="16">
                                                                                                                            </telerik:RadComboBox>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            Cta. Contable:</td>
                                                                                                                        <td colspan="4">
                                                                                                                            <telerik:RadComboBox ID="RadComboBox6" Runat="server" DataTextField="PlanContable" 
                                                                                                                                DataValueField="IdPlan" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                                                ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" Skin="Hay" 
                                                                                                                                TabIndex="17" Width="100%" DataSourceID="SqlPlanContable" 
                                                                                                                                AllowCustomText="True">
                                                                                                                            </telerik:RadComboBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" 
                                                                                                                                ControlToValidate="RadComboBox6" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar la Cuenta Contable!"></asp:RequiredFieldValidator>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                </table>
                                                                                                            </td>
                                                                                                        </tr>
                                                                                                    </table>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>

                                                                                       
                                                                                    </telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView2" runat="server">
                                                                                        <table class="tabla3" style="width: 100%">
                                                                                            <tr>
                                                                                                <td>
                                                                                                    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                                                                                        CellSpacing="0" DataSourceID="SqlCaracteristicas" GridLines="None" 
                                                                                                        Skin="Hay">
                                                                                                        <MasterTableView ClientDataKeyNames="IdPropiedadSemoviente" CommandItemDisplay="Top" 
                                                                                                            DataKeyNames="IdPropiedadSemoviente" DataSourceID="SqlCaracteristicas" 
                                                                                                            NoMasterRecordsText="No existen registros.">
                                                                                                            <CommandItemSettings AddNewRecordText="Agregar Característica" 
                                                                                                                ExportToPdfText="Export to PDF" RefreshText="Refrescar" 
                                                                                                                ShowRefreshButton="False" />
                                                                                                            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                                                                                                <HeaderStyle Width="20px" />
                                                                                                            </RowIndicatorColumn>
                                                                                                            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                                                                                                <HeaderStyle Width="20px" />
                                                                                                            </ExpandCollapseColumn>
                                                                                                            <Columns>
                                                                                                                <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                                    FilterControlAltText="Filter EditCommandColumn column">
                                                                                                                    <HeaderStyle Width="1.5%" />
                                                                                                                </telerik:GridEditCommandColumn>
                                                                                                                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                                    ConfirmDialogType="RadWindow" 
                                                                                                                    ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                                                                                                    ConfirmTitle="Mensaje de Confirmación" 
                                                                                                                    FilterControlAltText="Filter column column" FilterImageUrl="~\img\delete.gif" 
                                                                                                                    Text="Eliminar" UniqueName="column">
                                                                                                                    <HeaderStyle Width="1.5%" />
                                                                                                                </telerik:GridButtonColumn>
                                                                                                                <telerik:GridBoundColumn DataField="categoria" 
                                                                                                                    FilterControlAltText="Filter categoria column" HeaderText="Categoría" 
                                                                                                                    SortExpression="categoria" UniqueName="categoria">
                                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="28%" />
                                                                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="NomEstadoSemoviente" 
                                                                                                                    FilterControlAltText="Filter NomEstadoSemoviente column" HeaderText="Estado" 
                                                                                                                    SortExpression="NomEstadoSemoviente" UniqueName="NomEstadoSemoviente">
                                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="25%" />
                                                                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="Peso" DataType="System.Decimal" 
                                                                                                                    FilterControlAltText="Filter Peso column" HeaderText="Peso" 
                                                                                                                    SortExpression="Peso" UniqueName="Peso">
                                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="Valor" DataFormatString="{0:N2}" 
                                                                                                                    DataType="System.Decimal" FilterControlAltText="Filter Valor column" 
                                                                                                                    HeaderText="Valor" SortExpression="Valor" UniqueName="Valor">
                                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                                    <ItemStyle HorizontalAlign="Right" />
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="FechaInicio" 
                                                                                                                    DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime" 
                                                                                                                    FilterControlAltText="Filter FechaInicio column" HeaderText="Fec. Inicio" 
                                                                                                                    SortExpression="FechaInicio" UniqueName="FechaInicio">
                                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="FechaFin" DataFormatString="{0:dd/MM/yyyy}" 
                                                                                                                    DataType="System.DateTime" FilterControlAltText="Filter FechaFin column" 
                                                                                                                    HeaderText="Fec. Fin" SortExpression="FechaFin" UniqueName="FechaFin">
                                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="IdPropiedadSemoviente" 
                                                                                                                    DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdPropiedadSemoviente column" 
                                                                                                                    HeaderText="IdPropiedadSemoviente" ReadOnly="True" 
                                                                                                                    SortExpression="IdPropiedadSemoviente" UniqueName="IdPropiedadSemoviente" 
                                                                                                                    Visible="False">
                                                                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="IdEstadoSemoviente" DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdEstadoSemoviente column" 
                                                                                                                    HeaderText="IdEstadoSemoviente" SortExpression="IdEstadoSemoviente" 
                                                                                                                    UniqueName="IdEstadoSemoviente" Visible="False">
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="IdSemoviente" 
                                                                                                                    FilterControlAltText="Filter IdSemoviente column" 
                                                                                                                    HeaderText="IdSemoviente" SortExpression="IdSemoviente" 
                                                                                                                    UniqueName="IdSemoviente" DataType="System.Int32" Visible="False">
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="IdCategoriaAnimal" DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdCategoriaAnimal column" 
                                                                                                                    HeaderText="IdCategoriaAnimal" SortExpression="IdCategoriaAnimal" 
                                                                                                                    UniqueName="IdCategoriaAnimal" Visible="False">
                                                                                                                </telerik:GridBoundColumn>
                                                                                                            </Columns>
                                                                                                            <EditFormSettings EditFormType="WebUserControl" 
                                                                                                                UserControlName="~\Patrimonio\Controles\ControlCaracteristicas.ascx">
                                                                                                                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                                                                                                </EditColumn>
                                                                                                            </EditFormSettings>
                                                                                                        </MasterTableView>
                                                                                                        <FilterMenu EnableImageSprites="False">
                                                                                                        </FilterMenu>
                                                                                                        <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                                                                                                        </HeaderContextMenu>
                                                                                                    </telerik:RadGrid>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView3" runat="server">
                                                                                        <table class="tabla3" style="width: 100%">
                                                                                            <tr>
                                                                                                <td>
                                                                                                    <telerik:RadGrid ID="RadGrid2" runat="server" Skin="Hay" 
                                                                                                        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlUbicacion" 
                                                                                                        GridLines="None">
                                                                                                        <MasterTableView ClientDataKeyNames="IdUbicacionSemoviente" CommandItemDisplay="Top" 
                                                                                                            DataKeyNames="IdUbicacionSemoviente" DataSourceID="SqlUbicacion" 
                                                                                                            NoMasterRecordsText="No existen registros.">
                                                                                                            <CommandItemSettings AddNewRecordText="Agregar Ubicación" 
                                                                                                                ExportToPdfText="Export to PDF" ShowRefreshButton="False" />
                                                                                                            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                                                                                                <HeaderStyle Width="20px" />
                                                                                                            </RowIndicatorColumn>
                                                                                                            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                                                                                                <HeaderStyle Width="20px" />
                                                                                                            </ExpandCollapseColumn>
                                                                                                            <Columns>
                                                                                                                <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                                    FilterControlAltText="Filter EditCommandColumn column">
                                                                                                                    <HeaderStyle Width="1.5%" />
                                                                                                                </telerik:GridEditCommandColumn>
                                                                                                                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                                    ConfirmDialogType="RadWindow" 
                                                                                                                    ConfirmText="¿Está seguro de Eliminar e Registro?" 
                                                                                                                    ConfirmTitle="Mensaje de Confirmación" 
                                                                                                                    FilterControlAltText="Filter column column" FilterImageUrl="~\img\delete.gif" 
                                                                                                                    Text="Eliminar" UniqueName="column">
                                                                                                                    <HeaderStyle Width="1px" />
                                                                                                                </telerik:GridButtonColumn>
                                                                                                                <telerik:GridBoundColumn DataField="Proyecto" 
                                                                                                                    FilterControlAltText="Filter Proyecto column" HeaderText="Ubicación" 
                                                                                                                    ReadOnly="True" SortExpression="Proyecto" UniqueName="Proyecto">
                                                                                                                    <HeaderStyle HorizontalAlign="Center" />
                                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="77%" />
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="FechaInicio" 
                                                                                                                    DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime" 
                                                                                                                    FilterControlAltText="Filter FechaInicio column" HeaderText="Fec. Inicio" 
                                                                                                                    SortExpression="FechaInicio" UniqueName="FechaInicio">
                                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="FechaFin" DataFormatString="{0:dd/MM/yyyy}" 
                                                                                                                    DataType="System.DateTime" FilterControlAltText="Filter FechaFin column" 
                                                                                                                    HeaderText="Fec. Fin" SortExpression="FechaFin" UniqueName="FechaFin">
                                                                                                                    <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                                    <ItemStyle HorizontalAlign="Center" />
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="IdUbicacionSemoviente" 
                                                                                                                    DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdUbicacionSemoviente column" 
                                                                                                                    HeaderText="IdUbicacionSemoviente" ReadOnly="True" 
                                                                                                                    SortExpression="IdUbicacionSemoviente" UniqueName="IdUbicacionSemoviente" 
                                                                                                                    Visible="False">
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="IdSemoviente" DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdSemoviente column" 
                                                                                                                    HeaderText="IdSemoviente" SortExpression="IdSemoviente" 
                                                                                                                    UniqueName="IdSemoviente" Visible="False">
                                                                                                                </telerik:GridBoundColumn>
                                                                                                                <telerik:GridBoundColumn DataField="IdProyecto" DataType="System.Int32" 
                                                                                                                    FilterControlAltText="Filter IdProyecto column" HeaderText="IdProyecto" 
                                                                                                                    SortExpression="IdProyecto" UniqueName="IdProyecto" Visible="False">
                                                                                                                </telerik:GridBoundColumn>
                                                                                                            </Columns>
                                                                                                            <EditFormSettings EditFormType="WebUserControl" 
                                                                                                                UserControlName="~\Patrimonio\Controles\ControlUbicacion.ascx">
                                                                                                                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                                                                                                </EditColumn>
                                                                                                            </EditFormSettings>
                                                                                                        </MasterTableView>
                                                                                                        <FilterMenu EnableImageSprites="False">
                                                                                                        </FilterMenu>
                                                                                                        <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Hay">
                                                                                                        </HeaderContextMenu>
                                                                                                    </telerik:RadGrid>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView4" runat="server">
                                                                                        <telerik:RadGrid ID="RadGrid3" runat="server" AutoGenerateColumns="False" 
                                                                                            CellSpacing="0" DataSourceID="SqlAdjuntos" GridLines="None" Skin="Hay">
                                                                                            <MasterTableView ClientDataKeyNames="IdAdjuntoSemoviente" 
                                                                                                CommandItemDisplay="Top" DataKeyNames="IdAdjuntoSemoviente" 
                                                                                                DataSourceID="SqlAdjuntos" NoMasterRecordsText="No existen registros.">
                                                                                                <CommandItemSettings AddNewRecordText="Agregar Archivo Adjunto" 
                                                                                                    ExportToPdfText="Export to PDF" ShowRefreshButton="False" />
                                                                                                <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                                                                                    <HeaderStyle Width="20px" />
                                                                                                </RowIndicatorColumn>
                                                                                                <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                                                                                    <HeaderStyle Width="20px" />
                                                                                                </ExpandCollapseColumn>
                                                                                                <Columns>
                                                                                                    <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                        FilterControlAltText="Filter EditCommandColumn column">
                                                                                                    </telerik:GridEditCommandColumn>
                                                                                                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                        ConfirmDialogType="RadWindow" FilterControlAltText="Filter column column" 
                                                                                                        FilterImageUrl="~\img\delete.gif" Text="Eliminar" UniqueName="column">
                                                                                                    </telerik:GridButtonColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Nombre" 
                                                                                                        FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
                                                                                                        SortExpression="Nombre" UniqueName="Nombre">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Archivo" 
                                                                                                        FilterControlAltText="Filter Archivo column" HeaderText="Archivo" 
                                                                                                        SortExpression="Archivo" UniqueName="Archivo">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Fecha" DataType="System.DateTime" 
                                                                                                        FilterControlAltText="Filter Fecha column" HeaderText="Fecha" 
                                                                                                        SortExpression="Fecha" UniqueName="Fecha">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                        <ItemStyle HorizontalAlign="Center" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdAdjuntoSemoviente" 
                                                                                                        DataType="System.Int32" 
                                                                                                        FilterControlAltText="Filter IdAdjuntoSemoviente column" 
                                                                                                        HeaderText="IdAdjuntoSemoviente" ReadOnly="True" 
                                                                                                        SortExpression="IdAdjuntoSemoviente" UniqueName="IdAdjuntoSemoviente" 
                                                                                                        Visible="False">
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdSemoviente" DataType="System.Int32" 
                                                                                                        FilterControlAltText="Filter IdSemoviente column" HeaderText="IdSemoviente" 
                                                                                                        SortExpression="IdSemoviente" UniqueName="IdSemoviente" Visible="False">
                                                                                                    </telerik:GridBoundColumn>
                                                                                                </Columns>
                                                                                                <EditFormSettings EditFormType="WebUserControl" 
                                                                                                    UserControlName="~\Patrimonio\Controles\ControlAdjuntos.ascx">
                                                                                                    <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                                                                                    </EditColumn>
                                                                                                </EditFormSettings>
                                                                                            </MasterTableView>
                                                                                            <FilterMenu EnableImageSprites="False">
                                                                                            </FilterMenu>
                                                                                            <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                                                                                            </HeaderContextMenu>
                                                                                        </telerik:RadGrid>
                                                                                    </telerik:RadPageView>
                                                                                </telerik:RadMultiPage>
                                                                                    
                                                                                </td>
                                                    </tr>
    </table>

                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProyectoBL" 
        OldValuesParameterFormatString="original_{0}"></asp:ObjectDataSource>
    <asp:SqlDataSource ID="SqlPlanContable" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetPLANCONTABLEBSemovientes" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlMachos" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetSEMOVIENTESMachos" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlHembras" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetSEMOVIENTESHembras" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlCPD" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="GetPROYECTOCpd" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlEspecieAnimal" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetAllFromEspecieAnimal" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlRaza" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetAllFromRazaAnimal" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" DefaultValue="1" 
                Name="idespecieanimal" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>

             

                                            
    <asp:ObjectDataSource ID="OdsUbigeo" runat="server" 
        SelectMethod="GetUBIGEODATOSByParameter" 
        TypeName="SistFoncreagro.BussinesLogic.UbigeoDatosBL" 
        OldValuesParameterFormatString="original_{0}">
        <SelectParameters>
            <asp:Parameter DefaultValue="*" Name="texto" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:SqlDataSource ID="SqlAdjuntos" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetADJUNTOSEMOVIENTESByIdSemoviente" 
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter Name="IdSemoviente" QueryStringField="IdSemoviente" 
                Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
                                                                                                    <asp:SqlDataSource ID="SqlUbicacion" 
        runat="server" 
                                                                                                        
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                                                                        
        SelectCommand="GetUBICACIONSEMOVIENTESByIdSemovienteDetallado" 
                                                                                                        
        SelectCommandType="StoredProcedure">
                                                                                                        <SelectParameters>
                                                                                                            <asp:QueryStringParameter Name="IdSemoviente" QueryStringField="IdSemoviente" 
                                                                                                                Type="Int32" />
                                                                                                        </SelectParameters>
                                                                                                    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlCaracteristicas" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetPROPIEDADSEMOVIENTESByIdSemovienteDetallado" 
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter Name="IdSemoviente" QueryStringField="IdSemoviente" 
                Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource> 

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
            aviso = open("/SistIntegral/Patrimonio/Adjuntos/" + nombre, "Documento", "status=no, directories=no, toolbar=no, width=800, height=500, left=100, top=100")
            //        window.open("../Archivos1/Logistica/" + nombre, nombre, "width=800, height=500")    
        }
     </script>
    </telerik:RadCodeBlock>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="txtDate">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadNumericTextBox1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadioButtonList2">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox5" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox3" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox4" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid2">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>


                                                </asp:Content>

