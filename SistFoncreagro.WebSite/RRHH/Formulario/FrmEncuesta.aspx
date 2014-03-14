<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmEncuesta.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmEncuesta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function Grabar() {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Grabar");
        }
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }

        function alertCallBackFn(arg) {
            window.open("PrincipalRRHH.aspx", "_self");
        }
        
    </script>
</telerik:RadCodeBlock>
    <table style="width: 100%; border: 1px solid #000000">
        <tr>
            <td>
                <table  style="width: 100%">
                    <tr>
                        <td width="20%" style="height: 56px">
                            <asp:Image ID="Image4" runat="server" 
                                ImageUrl="~/img/logotipo foncreagro.jpg" />
                        </td>
                        <td style="font-size: 20px; font-weight: bold; text-align: center; height: 56px;" 
                            width="50%">
                            COLABORADOR DEL MES</td>
                        <td style="font-size: 20px; font-weight: bold; text-align: left; height: 56px;" 
                            width="30%">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Aceptar.gif" 
                                ToolTip="Enviar Encuesta" Height="33px" Width="43px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="style6">
                    <tr>
                        <td class="TextoNegrita" colspan="2">
                            Gracias por apoyarnos, tu opinión es importante para seleccionar al trabajador 
                            más destacado durante el mes</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="14%">
                            Área a la que Ud. pertenece:</td>
                        <td>
                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AllowCustomText="True" 
                                                                                                
                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                
                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                
                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                
                                ValidationGroup="Transaccion" Width="70%" EmptyMessage="Seleccione de la lista desplegable">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                                ControlToValidate="RadComboBox1" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Área!"></asp:RequiredFieldValidator>
                                                                                        </td>
                    </tr>
                    <tr>
                        <td>
                            Candidato:</td>
                        <td>
                                                                                            <telerik:RadComboBox ID="RadComboBox2" Runat="server" AllowCustomText="True" 
                                DataSourceID="SqlPersonal" DataTextField="Personal" 
                                                                                                
                                DataValueField="IdPersonal" EnableLoadOnDemand="True" 
                                                                                                
                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                
                                ValidationGroup="Transaccion" Width="70%" AutoPostBack="True" EmptyMessage="Seleccione de la lista desplegable">
                                                                                            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="RadComboBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el Candidato!"></asp:RequiredFieldValidator>
                                                                                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            De los siguientes criterios de evaluación coloque la calificación que crea conveniente 
                            del 1 al 5, teniendo en 
                            cuenta que 1 representa el calificativo más bajo y 5 el más alto.</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                CellSpacing="0" DataSourceID="SqlRespuestas" GridLines="None" Skin="Hay">
<MasterTableView DataKeyNames="IdRespuesta" DataSourceID="SqlRespuestas">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="IdRespuesta" DataType="System.Int32" 
            FilterControlAltText="Filter IdRespuesta column" HeaderText="IdRespuesta" 
            ReadOnly="True" SortExpression="IdRespuesta" UniqueName="IdRespuesta" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdEncuestaLlena" DataType="System.Int32" 
            FilterControlAltText="Filter IdEncuestaLlena column" 
            HeaderText="IdEncuestaLlena" SortExpression="IdEncuestaLlena" 
            UniqueName="IdEncuestaLlena" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Factor" 
            FilterControlAltText="Filter Factor column" HeaderText="Factor" 
            SortExpression="Factor" UniqueName="Factor">
            <HeaderStyle HorizontalAlign="Center" Width="15%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Criterio" 
            FilterControlAltText="Filter Criterio column" HeaderText="Criterio" 
            SortExpression="Criterio" UniqueName="Criterio">
            <HeaderStyle HorizontalAlign="Center" Width="50%" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            HeaderText="Puntuación" UniqueName="TemplateColumn">
            <ItemTemplate>
                <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" 
                    DataType="System.Int32" Width="25px">
                    <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                    <NumberFormat DecimalDigits="0" />
                    <ClientEvents OnValueChanged="Grabar" />
                </telerik:RadNumericTextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ControlToValidate="RadNumericTextBox1" Display="Dynamic" 
                    ErrorMessage="¡Solo números del 1 al 5!" MaximumValue="5" MinimumValue="1" 
                    Type="Integer"></asp:RangeValidator>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" Width="5%" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            HeaderText="Comentario" UniqueName="TemplateColumn1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Width="100%" 
                    CssClass="TextBoxAlignIzquierda"></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="HabilitarComentario" 
            FilterControlAltText="Filter HabilitarComentario column" 
            UniqueName="HabilitarComentario" Visible="False">
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
           <asp:ObjectDataSource ID="odsProyecto" runat="server" 
        SelectMethod="GetAllFromProyecto" 
        TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>                                                     
   
             

                                            
         <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>

             

                                            
    <asp:SqlDataSource ID="SqlPersonal" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetPersonalNotINProyecto" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="RadComboBox1" Name="idProyecto" 
                PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
                            <asp:SqlDataSource ID="SqlRespuestas" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                SelectCommand="GetRESPUESTAByIdEncuestaLlenaDetallado" 
                                SelectCommandType="StoredProcedure">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="IdEncuestaLlena" 
                                        QueryStringField="IdEncuestaLlena" Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadComboBox1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadComboBox2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
   
       
       
  
</asp:Content>
