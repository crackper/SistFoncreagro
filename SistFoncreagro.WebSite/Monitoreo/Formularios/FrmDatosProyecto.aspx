<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmDatosProyecto.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmDatosProyecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td style="width: 150px">
                                    <asp:ImageButton ID="BtnGrabar" runat="server" 
                                ImageUrl="~/img/grabar.gif" />
                                    <asp:ImageButton ID="BtnCancelar" runat="server" ImageUrl="~/img/cancel.gif" 
                                        Width="25px" />
                                </td>
                        <td>
                            <asp:HiddenField ID="HFIdProyecto" runat="server" />
                            <telerik:RadWindowManager ID="RWMensajes" runat="server">
                            </telerik:RadWindowManager>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 150px">
                                    &nbsp;</td>
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
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 150px">
                            Area:</td>
                        <td>
                                    <asp:TextBox ID="TxtCodigo" runat="server" MaxLength="4" Width="148px" 
                                    style="text-transform:uppercase;" Enabled="False"></asp:TextBox>
                                </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 150px">
                            Nombre:</td>
                        <td>
                                    <asp:TextBox ID="TxtNombre" runat="server" Height="92px" TextMode="MultiLine" 
                                        Width="797px" style="text-transform:uppercase;"></asp:TextBox>
                                </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 150px">
                            Alias</td>
                        <td>
                                    <asp:TextBox ID="TxtAlias" runat="server" Height="42px" TextMode="MultiLine" 
                                        Width="797px" style="text-transform:uppercase;"></asp:TextBox>
                                </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 150px">
                            Responsable:</td>
                        <td>
                                    <telerik:RadComboBox ID="CbResponsable" Runat="server" width = "790px" 
                                        DataSourceID="OdsResponsable" DataTextField="nombreCompleto" 
                                        DataValueField="IdPersonal" Skin="Default" AllowCustomText="True" 
                                        EnableLoadOnDemand="True" MarkFirstMatch="True">
                                    </telerik:RadComboBox>
                                    <asp:ObjectDataSource ID="OdsResponsable" runat="server" 
                                        SelectMethod="GetAllFromPersonal" 
                                        TypeName="SistFoncreagro.BussinesLogic.PersonalBL"></asp:ObjectDataSource>
                                </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 150px">
                            Alineamiento:</td>
                        <td>
                                    <asp:DropDownList ID="CbAlineamiento" runat="server" Width="270px">
                                        <asp:ListItem>VACIO</asp:ListItem>
                                        <asp:ListItem>SALUD</asp:ListItem>
                                        <asp:ListItem>EDUCACION</asp:ListItem>
                                        <asp:ListItem>GESTION DEL AGUA</asp:ListItem>
                                        <asp:ListItem>DESARROLLO ECONOMICO</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 150px">
                            Línea de Intervención:</td>
                        <td>
                                    <asp:DropDownList ID="CbPrograma" runat="server" Width="270px">
                                        <asp:ListItem>VACIO</asp:ListItem>
                                        <asp:ListItem>DESARROLLO GANADERO</asp:ListItem>
                                        <asp:ListItem>SEGURIDAD ALIMENTARIA</asp:ListItem>
                                        <asp:ListItem>SANEAMIENTO BASICO</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 150px">
                            Inicio Programado:</td>
                        <td>
                                    <telerik:RadDatePicker ID="DtIniProg" Runat="server" 
                                FocusedDate="1985-01-01">
                                    </telerik:RadDatePicker>
                                </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 150px">
                            Fin Programado:</td>
                        <td>
                                    <telerik:RadDatePicker ID="DtFinProg" Runat="server" 
                                FocusedDate="1985-01-01">
                                    </telerik:RadDatePicker>
                                </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 150px">
                            Estado:</td>
                        <td>
                                    <asp:DropDownList ID="cbEstado" runat="server" Width="290px">
                                        <asp:ListItem>IMPLEMENTACION</asp:ListItem>
                                        <asp:ListItem>EJECUCION</asp:ListItem>
                                        <asp:ListItem>CIERRE</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 150px">
                            Código Adicional:</td>
                        <td>
                                    <asp:TextBox ID="TxtCodAdic" runat="server" MaxLength="30" Width="288px"></asp:TextBox>
                                </td>
                    </tr>
                    <tr>
                        <td style="width: 150px">
                            &nbsp;</td>
                        <td>
                                    <telerik:RadDatePicker ID="DtIniReal" Runat="server" FocusedDate="1985-01-01" 
                                        Visible="False">
                                    </telerik:RadDatePicker>
                                </td>
                    </tr>
                    <tr>
                        <td style="width: 150px">
                            &nbsp;</td>
                        <td>
                                    <telerik:RadDatePicker ID="DtFinReal" Runat="server" FocusedDate="1985-01-01" 
                                        Visible="False">
                                    </telerik:RadDatePicker>
                                </td>
                    </tr>
                    <tr>
                        <td style="width: 150px" align="right">
                            Adjuntos:</td>
                        <td>
                            <asp:ImageButton ID="BtnNuevoAdj" runat="server" ImageUrl="~/img/nuevo.gif" 
                                ToolTip="Nuevo Archivo" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 150px">
                            &nbsp;</td>
                        <td>
                            <asp:GridView ID="GVAdjuntos" runat="server" AutoGenerateColumns="False" 
                                DataSourceID="OdsAdjuntoProy" DataKeyNames="IdAdjMonit" Width="793px">
                                <Columns>
                                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/img/Edit.gif" 
                                        SelectText="Selec." ShowSelectButton="True" HeaderText="Editar">
                                    <HeaderStyle Width="7%" />
                                    </asp:CommandField>
                                    <asp:CommandField ButtonType="Image" DeleteImageUrl="~/img/Delete.gif" 
                                        ShowDeleteButton="True" HeaderText="Eliminar">
                                    <HeaderStyle Width="7%" />
                                    </asp:CommandField>
                                    <asp:BoundField DataField="IdAdjMonit" HeaderText="IdAdjMonit" 
                                        SortExpression="IdAdjMonit" Visible="False">
                                    <HeaderStyle Width="0%" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Ruta" HeaderText="Archivo" SortExpression="Ruta">
                                    <HeaderStyle Width="36%" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" 
                                        SortExpression="Descripcion">
                                    <HeaderStyle Width="43%" />
                                    </asp:BoundField>
                                    <asp:ButtonField ButtonType="Image" CommandName="Ver" HeaderText="Ver" 
                                        ImageUrl="~/img/OpenFile.gif" Text="Botón">
                                    <HeaderStyle Width="7%" />
                                    </asp:ButtonField>
                                </Columns>
                            </asp:GridView>
                            <asp:ObjectDataSource ID="OdsAdjuntoProy" runat="server" 
                                SelectMethod="GetADJMONITByIdAndTabla" 
                                TypeName="SistFoncreagro.BussinesLogic.AdjMonitBL">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="_Id" QueryStringField="IdProyecto" 
                                        Type="Int32" />
                                    <asp:Parameter DefaultValue="PROYECTO" Name="_Tabla" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 150px">
                            &nbsp;</td>
                        <td>
                            <asp:Panel ID="Panel1" runat="server" Visible="False">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 125px">
                                            <asp:ImageButton ID="BtnAdjuntar" runat="server" ImageUrl="~/img/Upload.gif" />
                                            <asp:ImageButton ID="BtnActualArch" runat="server" ImageUrl="~/img/update.gif" 
                                                Width="25px" />
                                            <asp:ImageButton ID="BtnCancelAdj" runat="server" ImageUrl="~/img/cancel.gif" 
                                                Width="25px" />
                                        </td>
                                        <td>
                                            <asp:HiddenField ID="HFIdArchivo" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="width: 125px">
                                            &nbsp;</td>
                                        <td>
                                            <asp:FileUpload ID="FileUploadControl" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 125px" align="right">
                                            Descripción:</td>
                                        <td>
                                            <asp:TextBox ID="TxtDescAdj" runat="server" TextMode="MultiLine" Width="629px"
                                            style="text-transform:uppercase;"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 125px">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
                <telerik:RadWindowManager ID="RWMMensajes" runat="server">
                </telerik:RadWindowManager>
                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                </telerik:RadAjaxManager>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
