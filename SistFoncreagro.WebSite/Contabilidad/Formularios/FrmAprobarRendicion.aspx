<%@ Page Title="Aprobar Rendición" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmAprobarRendicion.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmAprobarRendicion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                         <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
  <Windows>
                <telerik:RadWindow ID="Proveedores" runat="server" Behavior="Minimize, Close" 
                    Behaviors="Default" Height="750px"
                    InitialBehavior="None" Left="" Modal="True" NavigateUrl="" 
                     Style="display: none;" Top="" VisibleStatusbar="True"
                    Width="500px" Title="Registro de Proveedores" AutoSize="True">
                </telerik:RadWindow>
            </Windows>
                            </telerik:RadWindowManager>                       
                                                <table align="center" class="tabla3">
                                                    <tr>
                                                        <td colspan="2">
                                                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                                                    <tr>
                                                        <td>
                                                            Rendición de fondo fijo</td>
                                                       
                                                        <td style="text-align: right">
                

        


                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar" CausesValidation="False" 
                                                                PostBackUrl="~/Contabilidad/Formularios/ListaRendicionesPorAprobar.aspx" />
                

        


                                                            </td>
                                                       
                                                    </tr>
                                                </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 892px" colspan="2">
                                                            <table style="width: 90px">
                                                                <tr>
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/img/Aceptar.gif" 
                                                                            ToolTip="Aprobar Rendición" CausesValidation="False" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/img/alerta.gif" 
                                                                            ToolTip="Observar Rendición" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/img/Buscar.gif" 
                                                                            ToolTip="Ver el Reporte" CausesValidation="False" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="Texto" style="font-weight: 700; width: 892px;" colspan="2">
                                                                    Datos Generales:</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="eeb">
                                                                                    <tr class="Texto" __designer:mapid="eec">
                                                                                        <td width="10%" __designer:mapid="eed">
                                                                                            Op. Finan.:</td>
                                                                                        <td width="32%" __designer:mapid="eee">
                                                                                            <telerik:RadComboBox ID="RadComboBox5" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsOpFinanciera" DataTextField="Descripcion" 
                                                                                                DataValueField="IdOpFinanciera" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                Width="98%" Enabled="False">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ef0">
                                                                                            SubDiario:</td>
                                                                                        <td width="34%" __designer:mapid="ef1">
                                                                                            <telerik:RadComboBox ID="RadComboBox4" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="odsSubDiario" DataTextField="Descripcion" 
                                                                                                DataValueField="IdSubDiario" EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                                Width="95%" Enabled="False">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="ef3">
                                                                                            Codigo:</td>
                                                                                        <td width="8%" __designer:mapid="ef4">
                                                                                            <telerik:RadTextBox ID="RadTextBox1" Runat="server" Enabled="False" 
                                                                                                ReadOnly="True" Width="70px">
                                                                                            </telerik:RadTextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="ef6">
                                                                                        <td colspan="6" style="font-size: 3pt" __designer:mapid="ef7">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                                                <table cellpadding="0" cellspacing="0" class="tabla4" __designer:mapid="efa">
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td width="10%" __designer:mapid="efc">
                                                                                            Proyecto:</td>
                                                                                        <td width="74%" __designer:mapid="efd">
                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" AllowCustomText="True" 
                                                                                                AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="Nombre" 
                                                                                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                ValidationGroup="Transaccion" Width="98%" Enabled="False">
                                                                                            </telerik:RadComboBox>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="f00">
                                                                                            Fecha :</td>
                                                                                        <td __designer:mapid="f01" style="width: 8%">
                                                                                            <asp:TextBox ID="txtDate" runat="server" Width="70px" Enabled="False" />
                                                                                             
                                                                                        </td>
                                                                                    </tr>
                                                                                     <tr class="Texto" __designer:mapid="f06">
                                                                                        <td colspan="4" style="font-size: 3pt" __designer:mapid="f07">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                    <tr class="Texto" __designer:mapid="efb">
                                                                                        <td width="10%" __designer:mapid="efc">
                                                                                            Observación:</td>
                                                                                        <td width="74%" __designer:mapid="efd">
                                                                                            <telerik:RadTextBox ID="RadTextBox3" Runat="server" Rows="1" 
                                                                                                TextMode="MultiLine" Width="98%">
                                                                                            </telerik:RadTextBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="RadTextBox3" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar la Observación!"></asp:RequiredFieldValidator>
                                                                                        </td>
                                                                                        <td width="8%" __designer:mapid="f00">
                                                                                            &nbsp;</td>
                                                                                        <td __designer:mapid="f01" style="width: 8%">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                   
                                                                                    <tr class="Texto" __designer:mapid="f11">
                                                                                        <td colspan="4" style="font-size: 3pt" __designer:mapid="f12">
                                                                                            &nbsp;</td>
                                                                                    </tr>
                                                                                </table>
                                                        </td>
                                                    </tr>
                                                    <tr class="Texto">
                                                        <td style="text-align: left; width: 892px;" colspan="2">
                                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: left; font-weight: 700; width: 892px;" class="Texto">
                                                                            Documentos rendidos:</td>
                                                        <td style="text-align: left; font-weight: 700; width: 892px;" class="Texto">
                                                                            Total: S/.&nbsp;&nbsp;
                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" 
                                                                                BorderColor="White" BorderStyle="None" BorderWidth="0px" ReadOnly="True" 
                                                                                style="font-weight: 700" Width="50px">
                                                                            </telerik:RadNumericTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: center; " colspan="2">
                                                                            
                                                            <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
                                                                AutoGenerateRows="False" BackColor="White" BorderColor="#336666" 
                                                                BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                                                                DataSourceID="odsDocumentosrendidos" 
                                                                GridLines="Horizontal" Height="50px" Width="100%">
                                                                <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                                                <Fields>
                                                                    <asp:BoundField DataField="TipoDocumento" 
                                                                        HeaderText="Tipo Documento:">
                                                                    <HeaderStyle HorizontalAlign="Left" Width="20%" />
                                                                    <ItemStyle HorizontalAlign="Left" Width="80%" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="Proveedor" HeaderText="Proveedor:">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="Serie" HeaderText="Serie Documento:">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="NroDocumento" HeaderText="N° Documento:">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="FechaDocumento" HeaderText="Fecha Documento:" 
                                                                        DataFormatString="{0:dd/MM/yyyy}">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="FechaVencimiento" DataFormatString="{0:dd/MM/yyyy}" 
                                                                        HeaderText="Fecha Vencimiento:">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="FechaPago" DataFormatString="{0:dd/MM/yyyy}" 
                                                                        HeaderText="Fecha Pago:">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="TipoCambio" DataFormatString="{0:0.0000}" 
                                                                        HeaderText="Tipo Cambio:">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="CentroCosto" HeaderText="C. Costo:">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="Gasto" HeaderText="Tipo de Gasto:">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="Monto" DataFormatString="{0:0.00}" 
                                                                        HeaderText="Monto:">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="Glosa" HeaderText="Glosa:">
                                                                    <HeaderStyle HorizontalAlign="Left" />
                                                                    <ItemStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                </Fields>
                                                                <FooterStyle BackColor="White" ForeColor="#333333" />
                                                                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                                                <PagerSettings Mode="NumericFirstLast" />
                                                                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                                                <RowStyle BackColor="White" ForeColor="#333333" />
                                                            </asp:DetailsView>
                                                                            
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: left; font-weight: 700; width: 892px;" class="Texto" 
                                                            colspan="2">
                                                                            &nbsp;</td>
                                                    </tr>
                                                    </table>

                                                <telerik:RadTextBox ID="RadTextBox2" Runat="server" 
                             Text="0" BackColor="White" BorderColor="White" BorderStyle="None" 
                             ForeColor="White">
                                                </telerik:RadTextBox>

                                                <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                                    SelectMethod="GetAllFromProyecto" 
                                                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>

                                                <asp:ObjectDataSource ID="odsDocumentosrendidos" 
                             runat="server" SelectMethod="GetDOCUMENTORENDIDOByIdRendicion" 
                             TypeName="SistFoncreagro.BussinesLogic.DocumentoRendidoBL">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdRendicion" QueryStringField="IdRendicion" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                         </asp:ObjectDataSource>

                                                <asp:ObjectDataSource ID="odsOpFinanciera" runat="server" 
                                                    SelectMethod="GetAllFromOperacionFinanciera" 
                                                    TypeName="SistFoncreagro.BussinesLogic.OperacionFinancieraBL">
                                                </asp:ObjectDataSource>
                                                <asp:ObjectDataSource ID="odsSubDiario" runat="server" 
                                                    SelectMethod="GetAllSUBDIARIO" 
                                                    TypeName="SistFoncreagro.BussinesLogic.SubdiarioBL"></asp:ObjectDataSource>

    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadComboBox3">
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="txtDate">
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="DetailsView1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="DetailsView1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
    </telerik:RadAjaxManager>
  
  <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">


        function alertCallBackFn(arg) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Redireccionar|" + arg);
        }

        function confirmCallBackFn(arg) {
            //            radalert("<strong>radconfirm</strong> returned the following result: <h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Result");
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Enviar|" + arg);
        }
        function confirmCallBackFn1(arg) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Observar|" + arg);
            }
        function promptCallBackFn(arg) {
            radalert("After 7.5 million years, <strong>Deep Thought</strong> answers:<h3 style='color: #ff0000;'>" + arg + "</h3>", null, null, "Deep Thought");
        }

        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }
     </script>
    </telerik:RadCodeBlock>
    
                                  
                                                </asp:Content>