<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterMonitoreo1.master" CodeBehind="FrmClimaSocial.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmClimaSocial" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                                                <table 
        style="width: 100%">
                                                    <tr>
                                                        <td >
                                                                                    
                                                                                        <table 
                                                                                        align="center" class="tabla3" __designer:mapid="2fb"><tr __designer:mapid="2fc">
                                                                                                <td style="text-align: left" valign="bottom" __designer:mapid="2fd">
                                                                                                    <table 
                                                                                                style="width: 100%" __designer:mapid="2fe"><tr __designer:mapid="2ff"><td width="5%" 
                                                                                                                __designer:mapid="300">
                                                                                                            <asp:ImageButton ID="ImageButton3" 
                                                                                                    runat="server" BorderColor="Gray" BorderStyle="Solid" BorderWidth="0px" 
                                                                                                    ImageUrl="~/img/Grabar.gif" ToolTip="Grabar" /></td>
                                                                                                            <td width="5%" __designer:mapid="302">
                                                                                                    <asp:ImageButton 
                                                                                                        ID="ImageButton4" runat="server" BorderColor="Gray" BorderStyle="Solid" 
                                                                                                        BorderWidth="0px" CausesValidation="False" ImageUrl="~/img/Nuevo.gif" 
                                                                                                        ToolTip="Nueva Actividad" /></td>
                                                                                                            <td style="text-align: right" 
                                                                                                    width="5%" __designer:mapid="304">
                                                                                                                &nbsp;</td>
                                                                                                <td 
                                                                                                    style="text-align: right" width="5%" __designer:mapid="306">
                                                                                                    &nbsp;</td>
                                                                                                <td style="text-align: right; font-weight: bold;" width="70%" __designer:mapid="308">
                                                                                                            </td>
                                                                                                <td style="text-align: left" width="10%" __designer:mapid="309">
                                                                                                    &nbsp;</td>
                                                                                            </tr></table></td></tr><tr __designer:mapid="30b"><td __designer:mapid="30c">
                                                                                                <table 
                                                                                                cellspacing="0" class="0" style="width: 100%" __designer:mapid="30d">
                                                                                                    <tr __designer:mapid="30e"><td class="Texto" __designer:mapid="30f">
                                                                                                        <table 
                                                                                                    style="width: 100%" __designer:mapid="310"><tr __designer:mapid="311">
                                                                                                    <td class="Texto" style="font-weight: 700; text-decoration: underline;" 
                                                                                                                    __designer:mapid="312">DATOS GENERALES</td></tr>
                                                                                                            <tr __designer:mapid="313">
                                                                                                    <td 
                                                                                                        width="12%" style="width: 100%" __designer:mapid="314">
                                                                                                        <table style="width: 100%" __designer:mapid="315">
                                                                                                            <tr __designer:mapid="316">
                                                                                                                <td width="8%" __designer:mapid="317">
                                                                                                                    Caserio:</td>
                                                                                                                <td width="10%" __designer:mapid="318" colspan="2" style="width: 92%">
                                                                                                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                                                                                                                </td>
                                                                                                                <td width="10%" __designer:mapid="318" style="width: 92%">
                                                                                                                    &nbsp;</td>
                                                                                                            </tr>
                                                                                                            <tr __designer:mapid="316">
                                                                                                                <td width="8%" __designer:mapid="317">
                                                                                                                    Fecha:</td>
                                                                                                                <td width="10%" __designer:mapid="318">
                                                                                                                    <asp:TextBox ID="txtDate2" runat="server" TabIndex="1" Width="70px" />
                                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                                                                                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                                        TargetControlID="txtDate2" />
                                                                                                                    <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                                                                                                        ControlExtender="MaskedEditExtender2" ControlToValidate="txtDate2" 
                                                                                                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" 
                                                                                                                        ControlToValidate="txtDate2" Display="Dynamic" 
                                                                                                                        ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator>
                                                                                                                </td>
                                                                                                                <td width="20%" __designer:mapid="31d" style="text-align: right">
                                                                                                                    Fuente:</td>
                                                                                                                <td width="72%" __designer:mapid="31d" style="text-align: left">
                                                                                                                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                                                                                                        RepeatDirection="Horizontal" AutoPostBack="True">
                                                                                                                        <asp:ListItem Selected="True">DIRECTA</asp:ListItem>
                                                                                                                        <asp:ListItem>INDIRECTA</asp:ListItem>
                                                                                                                    </asp:RadioButtonList>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                            </table>
                                                                                                    </td></tr>
                                                                                                </table></td></tr><tr __designer:mapid="33d">
                                                                                                        <td 
                                                                                                    class="Texto" __designer:mapid="33e"><table style="width: 100%" __designer:mapid="33f">
                                                                                                                <tr __designer:mapid="340">
                                                                                                        <td 
                                                                                                            colspan="4" style="font-weight: 700; text-decoration: underline;" 
                                                                                                                        __designer:mapid="341">CRITERIOS DE LECTURA SOCIAL CON FUENTE 
                                                                                                            DIRECTA</td></tr>
                                                                                                                <tr __designer:mapid="342">
                                                                                                        <td 
                                                                                                            width="20%" __designer:mapid="343">Accesibilidad (Riesgo de acceso):</td>
                                                                                                                    <td width="27%" __designer:mapid="344">
                                                                                                            <asp:DropDownList ID="DropDownList5" runat="server" Font-Names="Arial" 
                                                                                                                Font-Size="8pt" Width="170px">
                                                                                                                <asp:ListItem Value="1">Libre acceso y permanencia</asp:ListItem>
                                                                                                                <asp:ListItem Value="2">Acceso sin permanencia</asp:ListItem>
                                                                                                                <asp:ListItem Value="3">Acceso con restricciones</asp:ListItem>
                                                                                                                <asp:ListItem Value="4">Acceso no definido</asp:ListItem>
                                                                                                                <asp:ListItem Value="5">Sin Acceso ni permanencia</asp:ListItem>
                                                                                                                <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                        </td>
                                                                                                        <td style="text-align: left" 
                                                                                                            width="23%" __designer:mapid="34c">Actitud de la Población (agresividad):</td>
                                                                                                                    <td valign="middle" 
                                                                                                            width="15%" style="margin-left: 40px" __designer:mapid="34d">
                                                                                                            <asp:DropDownList ID="DropDownList6" runat="server" Font-Names="Arial" 
                                                                                                                Font-Size="8pt" Width="170px">
                                                                                                                <asp:ListItem Value="1">Hospitalaria</asp:ListItem>
                                                                                                                <asp:ListItem Value="2">Amable</asp:ListItem>
                                                                                                                <asp:ListItem Value="3">Indiferente</asp:ListItem>
                                                                                                                <asp:ListItem Value="4">Incómoda</asp:ListItem>
                                                                                                                <asp:ListItem Value="5">Hostil - Agresiva</asp:ListItem>
                                                                                                                <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                        </td></tr>
                                                                                                    <tr __designer:mapid="355">
                                                                                                        <td width="12%" __designer:mapid="356">
                                                                                                            Actitud frente a movilizaciones:</td>
                                                                                                        <td width="20%" __designer:mapid="357">
                                                                                                            <asp:DropDownList ID="DropDownList7" runat="server" Font-Names="Arial" 
                                                                                                                Font-Size="8pt" Width="170px">
                                                                                                                <asp:ListItem Value="1">Sin participación</asp:ListItem>
                                                                                                                <asp:ListItem Value="2">Participación condicionada</asp:ListItem>
                                                                                                                <asp:ListItem Value="3">Participa eventualmente</asp:ListItem>
                                                                                                                <asp:ListItem Value="4">Participa continuamente</asp:ListItem>
                                                                                                                <asp:ListItem Value="5">Lidera las movilizaciones</asp:ListItem>
                                                                                                                <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                        </td>
                                                                                                        <td style="text-align: left" width="20%" __designer:mapid="35f">
                                                                                                            Atención de quejas y reclamos:</td>
                                                                                                        <td valign="middle" width="15%" __designer:mapid="360">
                                                                                                            <asp:DropDownList ID="DropDownList8" runat="server" Font-Names="Arial" 
                                                                                                                Font-Size="8pt" Width="170px">
                                                                                                                <asp:ListItem Value="1">Ninguno</asp:ListItem>
                                                                                                                <asp:ListItem Value="2">Atendidos</asp:ListItem>
                                                                                                                <asp:ListItem Value="3">En proceso de atención</asp:ListItem>
                                                                                                                <asp:ListItem Value="4">Mal atendidos (inconforme)</asp:ListItem>
                                                                                                                <asp:ListItem Value="5">Sin atender</asp:ListItem>
                                                                                                                <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr __designer:mapid="368">
                                                                                                        <td width="20%" __designer:mapid="369">
                                                                                                            Actividad externa &quot;anti&quot; y Grado de Autonomía de la Comunidad</td>
                                                                                                        <td colspan="3" __designer:mapid="36a">
                                                                                                            <asp:DropDownList ID="DropDownList15" runat="server" Font-Names="Arial" 
                                                                                                                Font-Size="8pt" Width="500px">
                                                                                                                <asp:ListItem Value="1">la actividad es baja frente a una alta autonomía,es lo ideal</asp:ListItem>
                                                                                                                <asp:ListItem Value="2">la actividad es baja frente a una baja autonomía, para tenerlo en cuenta</asp:ListItem>
                                                                                                                <asp:ListItem Value="2">la actividad es regular frente a una alta autonomía, igual debe tenerse en cuenta</asp:ListItem>
                                                                                                                <asp:ListItem Value="4">la actividad es regular frente a una baja autonomía, implica riesgos considerables</asp:ListItem>
                                                                                                                <asp:ListItem Value="3">la actividad es alta pero enfrenta una alta autonomía, implica algún nivel de riesgo</asp:ListItem>
                                                                                                                <asp:ListItem Value="5">la actividad es baja frente a una baja autonomía, implica un alto riesgo</asp:ListItem>
                                                                                                                <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                            </asp:DropDownList>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr __designer:mapid="373">
                                                                                                        <td colspan="4" style="font-weight: 700" __designer:mapid="374">
                                                                                                            Intereses</td>
                                                                                                    </tr>
                                                                                                    <tr __designer:mapid="375">
                                                                                                        <td colspan="4" __designer:mapid="376">
                                                                                                            <table style="width: 100%" __designer:mapid="377">
                                                                                                                <tr __designer:mapid="378">
                                                                                                                    <td width="19%" __designer:mapid="379">
                                                                                                                        Cobertura de Población:</td>
                                                                                                                    <td width="18%" __designer:mapid="37a">
                                                                                                                        <asp:DropDownList ID="DropDownList9" runat="server" Font-Names="Arial" 
                                                                                                                            Font-Size="8pt" Width="170px">
                                                                                                                            <asp:ListItem Value="1">Comunales</asp:ListItem>
                                                                                                                            <asp:ListItem Value="2">Supra-Comunales</asp:ListItem>
                                                                                                                            <asp:ListItem Value="3">Grupales</asp:ListItem>
                                                                                                                            <asp:ListItem Value="4">Familiares</asp:ListItem>
                                                                                                                            <asp:ListItem Value="5">Personales</asp:ListItem>
                                                                                                                            <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                                        </asp:DropDownList>
                                                                                                                    </td>
                                                                                                                    <td width="20%" style="text-align: right" __designer:mapid="382">
                                                                                                                        Tema de Confrontación:</td>
                                                                                                                    <td width="18%" __designer:mapid="383">
                                                                                                                        <asp:DropDownList ID="DropDownList10" runat="server" Font-Names="Arial" 
                                                                                                                            Font-Size="8pt" Width="170px">
                                                                                                                            <asp:ListItem Value="1">Relacionamiento</asp:ListItem>
                                                                                                                            <asp:ListItem Value="2">Agua - Tierra</asp:ListItem>
                                                                                                                            <asp:ListItem Value="3">Daño - Impacto</asp:ListItem>
                                                                                                                            <asp:ListItem Value="4">Empleo</asp:ListItem>
                                                                                                                            <asp:ListItem Value="5">Contratistas</asp:ListItem>
                                                                                                                            <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                                        </asp:DropDownList>
                                                                                                                    </td>
                                                                                                                    <td width="10%" style="text-align: right" __designer:mapid="38b">
                                                                                                                        Dimensión:</td>
                                                                                                                    <td width="15%" __designer:mapid="38c">
                                                                                                                        <asp:DropDownList ID="DropDownList11" runat="server" Font-Names="Arial" 
                                                                                                                            Font-Size="8pt" Width="170px">
                                                                                                                            <asp:ListItem Value="1">Social-cultural</asp:ListItem>
                                                                                                                            <asp:ListItem Value="2">Comunicación</asp:ListItem>
                                                                                                                            <asp:ListItem Value="3">Económico</asp:ListItem>
                                                                                                                            <asp:ListItem Value="4">Ambiental</asp:ListItem>
                                                                                                                            <asp:ListItem Value="5">Político</asp:ListItem>
                                                                                                                            <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                                        </asp:DropDownList>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </table>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr __designer:mapid="394">
                                                                                                        <td colspan="4" style="font-weight: 700" __designer:mapid="395">
                                                                                                            Posición y Liderazgo</td>
                                                                                                    </tr>
                                                                                                    <tr __designer:mapid="396">
                                                                                                        <td colspan="4" __designer:mapid="397">
                                                                                                            <table style="width: 100%" __designer:mapid="398">
                                                                                                                <tr __designer:mapid="399">
                                                                                                                    <td width="19%" __designer:mapid="39a">
                                                                                                                        Autoridades:</td>
                                                                                                                    <td width="18%" __designer:mapid="39b">
                                                                                                                        <asp:DropDownList ID="DropDownList12" runat="server" Font-Names="Arial" 
                                                                                                                            Font-Size="8pt" Width="170px">
                                                                                                                            <asp:ListItem Value="1">Apoyo con liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Value="2">Apoyo  sin liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Value="3">Neutral</asp:ListItem>
                                                                                                                            <asp:ListItem Value="4">Oposición sin liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Value="5">Oposición con liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                                        </asp:DropDownList>
                                                                                                                    </td>
                                                                                                                    <td width="20%" style="text-align: right" __designer:mapid="3a3">
                                                                                                                        Docentes:</td>
                                                                                                                    <td width="18%" __designer:mapid="3a4">
                                                                                                                        <asp:DropDownList ID="DropDownList16" runat="server" Font-Names="Arial" 
                                                                                                                            Font-Size="8pt" Width="170px">
                                                                                                                            <asp:ListItem Value="1">Apoyo con liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Value="2">Apoyo  sin liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Value="3">Neutral</asp:ListItem>
                                                                                                                            <asp:ListItem Value="4">Oposición sin liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Value="5">Oposición con liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                                        </asp:DropDownList>
                                                                                                                    </td>
                                                                                                                    <td width="10%" style="text-align: right" __designer:mapid="3ac">
                                                                                                                        Rondas:</td>
                                                                                                                    <td width="15%" __designer:mapid="3ad">
                                                                                                                        <asp:DropDownList ID="DropDownList17" runat="server" Font-Names="Arial" 
                                                                                                                            Font-Size="8pt" Width="170px">
                                                                                                                            <asp:ListItem Value="1">Apoyo con liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Value="2">Apoyo  sin liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Value="3">Neutral</asp:ListItem>
                                                                                                                            <asp:ListItem Value="4">Oposición sin liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Value="5">Oposición con liderazgo</asp:ListItem>
                                                                                                                            <asp:ListItem Selected="True" Value="0">Sin Determinar</asp:ListItem>
                                                                                                                        </asp:DropDownList>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr __designer:mapid="3b5">
                                                                                                                    <td width="12%" style="color: navy" __designer:mapid="3b6">
                                                                                                                        <em __designer:mapid="3b7"><strong __designer:mapid="3b8">Actitud según lectura 
                                                                                                                        Directa:</strong></em></td>
                                                                                                                    <td colspan="5" __designer:mapid="3b9">
                                                                                                                        <asp:Image ID="Image1" runat="server" ImageUrl="~/img/apoyoTotal.gif" 
                                                                                                                            Visible="False" />
                                                                                                                        <asp:Image ID="Image2" runat="server" ImageUrl="~/img/apoyoModerado.gif" 
                                                                                                                            Visible="False" />
                                                                                                                        <asp:Image ID="Image3" runat="server" ImageUrl="~/img/neutral.gif" 
                                                                                                                            Visible="False" />
                                                                                                                        <asp:Image ID="Image4" runat="server" ImageUrl="~/img/oposicionModerada.gif" 
                                                                                                                            Visible="False" />
                                                                                                                        <asp:Image ID="Image5" runat="server" ImageUrl="~/img/oposicionRadical.gif" 
                                                                                                                            Visible="False" />
                                                                                                                        <asp:Image ID="Image6" runat="server" ImageUrl="~/img/sinDeterminar.gif" 
                                                                                                                            Visible="False" />
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </table>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr __designer:mapid="3c0">
                                                                                                        <td colspan="4" 
                                                                                                            style="font-weight: 700; text-decoration: underline; height: 20px;" 
                                                                                                            __designer:mapid="3c1">
                                                                                                            LECTURA SOCIAL CON FUENTE INDIRECTA</td>
                                                                                                    </tr>
                                                                                                    <tr __designer:mapid="3c0">
                                                                                                        <td colspan="4" 
                                                                                                           >
                                                                                                            <table style="width: 100%">
                                                                                                                <tr>
                                                                                                                    <td width="8%">
                                                                                                                        Actitud:</td>
                                                                                                                    <td width="20%">
                                                                                                                        <asp:DropDownList ID="DropDownList18" runat="server" Enabled="False" 
                                                                                                                            Width="150px" Font-Names="Arial" Font-Size="8pt">
                                                                                                                            <asp:ListItem>APOYO TOTAL</asp:ListItem>
                                                                                                                            <asp:ListItem>APOYO MODERADO</asp:ListItem>
                                                                                                                            <asp:ListItem>NEUTRAL</asp:ListItem>
                                                                                                                            <asp:ListItem>OPOSICION MODERADA</asp:ListItem>
                                                                                                                            <asp:ListItem>OPOSICION RADICAL</asp:ListItem>
                                                                                                                            <asp:ListItem Value="SIN DETERMINAR"></asp:ListItem>
                                                                                                                        </asp:DropDownList>
                                                                                                                    </td>
                                                                                                                    <td width="8%">
                                                                                                                        Razón:</td>
                                                                                                                    <td width="64%">
                                                                                                                        <asp:TextBox ID="TextBox8" runat="server" CssClass="Texto1" TabIndex="7" 
                                                                                                                            TextMode="MultiLine" Width="100%" Enabled="False"></asp:TextBox>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </table>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                    <tr __designer:mapid="3c0">
                                                                                                        <td colspan="4" 
                                                                                                            style="font-weight: 700; text-decoration: underline; height: 20px;" 
                                                                                                            __designer:mapid="3c1">
                                                                                                            COMENTARIOS DE CLIMA SOCIAL</td>
                                                                                                    </tr>
                                                                                                    <tr __designer:mapid="3c2">
                                                                                                        <td colspan="4" __designer:mapid="3c3">
                                                                                                            <table style="width: 100%" __designer:mapid="3c4">
                                                                                                                <tr __designer:mapid="3c5">
                                                                                                                    <td __designer:mapid="3c6">
                                                                                                                        Quejas o Reclamos:</td>
                                                                                                                    <td __designer:mapid="3c7">
                                                                                                                        <asp:TextBox ID="TextBox9" runat="server" CssClass="Texto1" TabIndex="9" 
                                                                                                                            TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                                    </td>
                                                                                                                    <td style="text-align: right" width="14%" __designer:mapid="3c9">
                                                                                                                        Acciones Tomadas:</td>
                                                                                                                    <td __designer:mapid="3ca">
                                                                                                                        <asp:TextBox ID="TextBox10" runat="server" CssClass="Texto1" TabIndex="10" 
                                                                                                                            TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr __designer:mapid="3cc">
                                                                                                                    <td width="14%" __designer:mapid="3cd">
                                                                                                                        Comentarios:</td>
                                                                                                                    <td width="36%" __designer:mapid="3ce">
                                                                                                                        <asp:TextBox ID="TextBox11" runat="server" CssClass="Texto1" TabIndex="11" 
                                                                                                                            TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                                    </td>
                                                                                                                    <td style="text-align: right" __designer:mapid="3d0">
                                                                                                                        &nbsp;</td>
                                                                                                                    <td width="36%" __designer:mapid="3d1">
                                                                                                                        &nbsp;</td>
                                                                                                                </tr>
                                                                                                            </table>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                </table></td></tr></table></td></tr></table>
                                                                                    
                                                                                </td>
                                                    </tr>
                                                    <tr>
                                                        <td >
                                                                                    
                                                                               </td>
                                                    </tr>
    </table>

<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function Validar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
        }
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }
        function ValidarFecha() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ValidarFecha");
        }
        function Foco() {
            document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDate1').value = '';

        }
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Mensaje");
        }
        function busque(sender, args) {
            var IdDetalleEje = args.getDataKeyValue("IdDetalleEje");
            var IdControl = args.getDataKeyValue("IdControl");
            radopen("FrmTarea.aspx?IdDetalleEje=" + IdDetalleEje + "&IdControl" + IdControl, "Formulario1");
            return false;
        }
        function CargarVentana(nombre) {
            aviso = open("/SistIntegral/Monitoreo/Adjuntos/" + nombre, "Documento", "status=no, directories=no, toolbar=no, width=800, height=500, left=100, top=100")
            //        window.open("../Archivos1/Logistica/" + nombre, nombre, "width=800, height=500")    
        }
     </script>
    </telerik:RadCodeBlock>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadioButtonList1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList5" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList6" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList7" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList8" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList15" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList9" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList10" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList11" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList12" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList16" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList17" />
                                                                <telerik:AjaxUpdatedControl ControlID="TextBox8" />
                                                                <telerik:AjaxUpdatedControl ControlID="DropDownList18" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
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
    

     <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"   
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Formulario1" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" OnClientClose="Validar">
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
                                                                                    
                                                
                                                </asp:Content>



