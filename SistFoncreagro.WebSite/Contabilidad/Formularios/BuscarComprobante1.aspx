<%@ Page Title="Buscar Comprobantes" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="BuscarComprobante1.aspx.vb" Inherits="SistFoncreagro.WebSite.BuscarComprobante1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;PARÁMETROS PARA buscar comprobantes</td>
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
                <table align="center" class="tabla6" width="100%" >
                    <tr class="Texto">
                        <td colspan="2">
            Indique los datos solicitados, luego haga clic en el botón &quot;Mostrar&quot;.</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="font-family: Arial; font-size: 3pt; height: 9px;">
                            </td>
                    </tr>
                    <tr class="Texto">
                        <td width="15%">
                            Tipo Doc. :</td>
                        <td style="text-align: left" width="85%">
                                                                                            <telerik:RadComboBox ID="RadComboBox2" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsTipoDocumento" DataTextField="Documento" 
                                                                                                DataValueField="IdTipoDocumento" 
                                                                                                EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                                                                                MarkFirstMatch="True" ShowMoreResultsBox="True" ValidationGroup="Transaccion" 
                                                                                                Width="100%">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                                                                ControlToValidate="RadComboBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Tipo de Documento!"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr class="Texto">
                        <td width="15%">
                            Serie:</td>
                        <td style="text-align: left" width="85%">
                                                                                            <asp:TextBox ID="TextBox5" runat="server" Width="70px" MaxLength="4" 
                                                                                                TabIndex="4"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                                                ControlToValidate="TextBox5" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Serie!"></asp:RequiredFieldValidator>
                                                                                        </td>
                    </tr>
                    <tr class="Texto">
                        <td width="15%">
                            Número:</td>
                        <td style="text-align: left" width="85%">
                                                                                            <asp:TextBox ID="TextBox2" runat="server" Width="70px" TabIndex="5"></asp:TextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                                                                ControlToValidate="TextBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el N° de Documento!"></asp:RequiredFieldValidator>
                                                                                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                ToolTip="Mostrar" AccessKey="s" />
                                              
        



                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
      <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" GridLines="None" Skin="Hay">
<MasterTableView NoMasterRecordsText="No existen Registros.">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="Subdiario" 
            FilterControlAltText="Filter Subdiario column" HeaderText="Subdiario" 
            ReadOnly="True" SortExpression="Subdiario" UniqueName="Subdiario">
            <HeaderStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" 
                Width="15%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo">
            <HeaderStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" 
                Width="5%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaContable" 
            DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime" 
            FilterControlAltText="Filter FechaContable column" HeaderText="Fecha Cont." 
            SortExpression="FechaContable" UniqueName="FechaContable">
            <HeaderStyle Font-Names="Arial" Font-Overline="False" Font-Size="8pt" 
                HorizontalAlign="Center" Width="5%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Registro" 
            FilterControlAltText="Filter Registro column" HeaderText="Registro" 
            ReadOnly="True" SortExpression="Registro" UniqueName="Registro">
            <HeaderStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" 
                Width="10%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaDocumento" 
            DataFormatString="{0:dd/MMyyyy}" DataType="System.DateTime" 
            FilterControlAltText="Filter FechaDocumento column" HeaderText="Fecha Doc." 
            SortExpression="FechaDocumento" UniqueName="FechaDocumento">
            <HeaderStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" 
                Width="5%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Monto" 
            FilterControlAltText="Filter column1 column" HeaderText="Monto" 
            UniqueName="column1">
            <HeaderStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Proyecto" 
            FilterControlAltText="Filter Proyecto column" HeaderText="Proyecto" 
            ReadOnly="True" SortExpression="Proyecto" UniqueName="Proyecto">
            <HeaderStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" 
                Width="25%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Proveedor" 
            FilterControlAltText="Filter Proveedor column" HeaderText="Proveedor" 
            ReadOnly="True" SortExpression="Proveedor" UniqueName="Proveedor">
            <HeaderStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Center" 
                Width="25%" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Glosa" 
            FilterControlAltText="Filter column column" HeaderText="Glosa" 
            UniqueName="column">
            <HeaderStyle Font-Names="Arial" Font-Size="7pt" HorizontalAlign="Center" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
    </telerik:RadGrid>

                                                <asp:ObjectDataSource ID="odsTipoDocumento" runat="server" 
                                                    SelectMethod="GetAllFromTIPODOCUMENTO" 
                                                    TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoBL">
                                                     </asp:ObjectDataSource>
    <asp:SqlDataSource ID="sqlComprobantes" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetLINEAByRegistro1" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:Parameter Name="TipoDocumento" Type="Int32" />
            <asp:Parameter Name="SerieDocumento" Type="String" />
            <asp:Parameter Name="NroDocumento" Type="Int64" />
        </SelectParameters>
    </asp:SqlDataSource>
      <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetAllFromProveedorClienteByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton2">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
    </telerik:RadAjaxManager>
 <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
       
        function ponerCeros() {
            var obj = document.getElementById('ctl00_ctl00_MainContent_MainContent_TextBox5');
            while (obj.value.length < 4)
                obj.value = '0' + obj.value;
        }
        </script>
    </telerik:RadCodeBlock>                                              
                                                
</asp:Content>
