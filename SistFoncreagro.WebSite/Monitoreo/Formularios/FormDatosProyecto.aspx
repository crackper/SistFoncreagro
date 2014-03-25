<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FormDatosProyecto.aspx.vb" Inherits="SistFoncreagro.WebSite.FormDatosProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="rgConvenios">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rapGridComponentes" LoadingPanelID="RadAjaxLoadingPanel1"/>
                    <telerik:AjaxUpdatedControl ControlID="rapGridActividades" LoadingPanelID="RadAjaxLoadingPanel1"/>
                    <telerik:AjaxUpdatedControl ControlID="rapGridCCostos" LoadingPanelID="RadAjaxLoadingPanel1"/>
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="rgComponentes">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rapGridActividades" LoadingPanelID="RadAjaxLoadingPanel1"/>
                    <telerik:AjaxUpdatedControl ControlID="rapGridCCostos" LoadingPanelID="RadAjaxLoadingPanel1"/>
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="rgActividades">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rapGridCCostos" LoadingPanelID="RadAjaxLoadingPanel1"/>
                    <telerik:AjaxUpdatedControl ControlID="rwShowAddCCosto" LoadingPanelID="RadAjaxLoadingPanel1"/>
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnAddCCosto">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rapGridCCostos" LoadingPanelID="RadAjaxLoadingPanel1"/>
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server"/>
    <telerik:RadWindowManager ID="rwmMessages" runat="server"/>
    <br/>
    <div class="row">
    <div class="span4">
        <fieldset>
            <legend>Información General del Proyecto</legend>
            <asp:HiddenField ID="hfIdProyecto" runat="server" />
            <label> Area: </label>
            <asp:TextBox ID="txtArea" Enabled="False" runat="server" Width="270px"/>
            <label>Nombre Proyecto:</label>
            <asp:TextBox ID="txtNombreProyecto" runat="server" TextMode="MultiLine" Width="270px"/>
            <label>Alias Proyecto:</label>
            <asp:TextBox ID="txtAliasProyecto" runat="server" Width="270px"/>
             <label>Responsable: </label>
             <telerik:RadAutoCompleteBox ID="radcbPersonal" runat="server" Culture="es-ES" 
                        DataSourceID="odsPersonal" AutoPostBack="True" 
                        EmptyMessage="Ingrese apellidos o nombres"
                        DataTextField="nombreCompleto" 
                        DataValueField="IdPersonal"  
                        DropDownWidth="270px"
                        Width="270px"
                        TextSettings-SelectionMode="Single" InputType="Text">
                    <TextSettings SelectionMode="Single"></TextSettings>
                    </telerik:RadAutoCompleteBox>
                    <asp:ObjectDataSource ID="odsPersonal" runat="server" 
                        SelectMethod="GetAllFromPersonal" 
                        TypeName="SistFoncreagro.BussinesLogic.PersonalBL"/>
             <label>Alineamiento:</label>
             <asp:DropDownList ID="cbAlineamiento" runat="server" Width="270px">
                <asp:ListItem Value="0">[- Seleccione uno -]</asp:ListItem>
                <asp:ListItem>SALUD</asp:ListItem>
                <asp:ListItem>EDUCACION</asp:ListItem>
                <asp:ListItem>GESTION DEL AGUA</asp:ListItem>
                <asp:ListItem>DESARROLLO ECONOMICO</asp:ListItem>
             </asp:DropDownList>
             <label>Línea de Intervención:</label>
             <asp:DropDownList ID="cbPrograma" runat="server" Width="270px">
                <asp:ListItem Value="0">[- Seleccione uno -]</asp:ListItem>
                <asp:ListItem>DESARROLLO GANADERO</asp:ListItem>
                <asp:ListItem>SEGURIDAD ALIMENTARIA</asp:ListItem>
                <asp:ListItem>SANEAMIENTO BASICO</asp:ListItem>
             </asp:DropDownList>
             <label>Inicio Programado:</label>
            <telerik:RadDatePicker ID="rdpInicioProgramado" Runat="server" FocusedDate="1985-01-01"/>
             <label>Fin Programado:</label>
            <telerik:RadDatePicker ID="rdpFinProgramado" Runat="server" FocusedDate="1985-01-01"/>
            <label>Estado:</label>
            <asp:DropDownList ID="cbEstado" runat="server" Width="270px">
                <asp:ListItem>IMPLEMENTACION</asp:ListItem>
                <asp:ListItem>EJECUCION</asp:ListItem>
                <asp:ListItem>CIERRE</asp:ListItem>
            </asp:DropDownList>     
            <label>Código Adicional:</label>  
            <asp:TextBox ID="txtCodigoAdicional" runat="server"/>       
        </fieldset>
    </div>
    <div class="span10">
        <telerik:RadTabStrip ID="rtsEstructura" runat="server" 
            MultiPageID="rmpEstructura" SelectedIndex="0">
            <Tabs>
                <telerik:RadTab runat="server" ImageUrl="../../img/category16x16.png" Text="Estructura" Selected="True"/>
                <telerik:RadTab runat="server" ImageUrl="../../img/clip16x16.png" Text="Adjuntos"/>
            </Tabs>
        </telerik:RadTabStrip>
        <telerik:RadMultiPage ID="rmpEstructura" runat="server" SelectedIndex="0">
            <telerik:RadPageView ID="RadPageView1" runat="server" alt="Estructura">
                <fieldset>
                    <legend>Convenios</legend>
                    
                    <telerik:RadAjaxPanel ID="rapGridConvenios" runat="server" EnableAJAX="True">
                    <telerik:RadGrid ID="rgConvenios" runat="server" AutoGenerateColumns="False" 
                        CellSpacing="0" 
                        GridLines="None" 
                        ShowFooter="True" 
                        AllowPaging="True">
                        <MasterTableView  ClientDataKeyNames="IdConvProy" 
                            DataKeyNames="IdConvProy">
                        <CommandItemSettings ExportToPdfText="Export to PDF"/>

                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                            <HeaderStyle Width="20px"/>
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridButtonColumn Text="Seleccionar" CommandName="Select"/>
                            
                            <telerik:GridBoundColumn DataField="IdConvProy" DataType="System.Int32" 
                                FilterControlAltText="Filter IdConvProy column" HeaderText="IdConvProy" 
                                SortExpression="IdConvProy" UniqueName="IdConvProy" Visible="False">
                                <HeaderStyle Width="0%" />
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="Convenio" 
                                FilterControlAltText="Filter column column" HeaderText="Convenio" 
                                UniqueName="column" FooterText="TOTAL">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn Aggregate="Sum" DataField="MontoAprobado" 
                                DataFormatString="{0:0,0.00}" DataType="System.Decimal" 
                                FilterControlAltText="Filter MontoAprobado column" HeaderText="Monto" 
                                SortExpression="MontoAprobado" UniqueName="MontoAprobado" 
                                FooterText="TOTAL">
                            </telerik:GridBoundColumn>
                        </Columns>

                        <EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
                        </MasterTableView>
                         <FilterMenu EnableImageSprites="False"/>
                         <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"/>
                     </telerik:RadGrid>
                     </telerik:RadAjaxPanel>
                </fieldset>
                <fieldset>
                    <legend>Componentes</legend>
                    <telerik:RadAjaxPanel ID="rapGridComponentes" EnableAJAX="True" runat="server">
                    <telerik:RadGrid runat="server" ID="rgComponentes"
                        AutoGenerateColumns="False"
                        CellSpacing="0" 
                        GridLines="None" 
                        ShowFooter="True">
                        <MasterTableView ClientDataKeyNames="IdProyComp" DataKeyNames="IdProyComp">
                            <Columns>
                                <telerik:GridButtonColumn Text="Seleccionar" CommandName="Select"/>
                                <telerik:GridBoundColumn HeaderText="Componente" DataField="Componente" FooterText="TOTAL"/>
                                <telerik:GridBoundColumn HeaderText="Porcentaje" Aggregate="Sum" DataField="Porcentaje"
                                DataType="System.Decimal" DataFormatString="{0:0,0.00}" />
                            </Columns>    
                        </MasterTableView>
                    </telerik:RadGrid>
                    </telerik:RadAjaxPanel>
                </fieldset>
                <fieldset>
                    <legend>Actividades</legend>
                    <telerik:RadAjaxPanel ID="rapGridActividades" runat="server" EnableAJAX="True">
                    <telerik:RadGrid ID="rgActividades" AutoGenerateColumns="False" CellPadding="0" GridLines="None" ShowFooter="True" runat="server">
                        <MasterTableView ClientDataKeyNames="IdProyAct" DataKeyNames="IdProyAct">
                            <Columns>
                                <telerik:GridButtonColumn Text="Seleccionar" CommandName="Select"/>
                                <telerik:GridBoundColumn HeaderText="Actividad" DataField="Actividad" FooterText="TOTAL"/>
                                <telerik:GridBoundColumn HeaderText="Porcentaje" Aggregate="Sum" DataField="Porcentaje"
                                DataType="System.Decimal" DataFormatString="{0:0,0.00}" />
                            </Columns>
                        </MasterTableView>
                    </telerik:RadGrid>
                    </telerik:RadAjaxPanel>
                </fieldset>
                <fieldset>
                    <legend>Centros de Costo</legend>
                    <div style="padding-bottom: 8px;">
                        <asp:Button ID="btnShowAddCCosto" runat="server" Text="Agregar Centro de Costo" CssClass="btn btn-success" 
                            OnClientClick="rbShowAddCCosto_OnClientClicked(); return false;"/>
                    </div>
                    <telerik:RadFormDecorator ID="rfdAddCCosto" DecorationZoneID="fsAddCCosto" DecoratedControls="All" runat="server"/>
                         <telerik:RadWindow ID="rwShowAddCCosto" runat="server" Modal="True" Behaviors="Close"  
                         AutoSize="True" AutoSizeBehaviors="Width" Height="450px" >
                         <ContentTemplate>
                             <telerik:RadAjaxPanel ID="rapShowAddCCosto" runat="server" EnableAJAX="True" LoadingPanelID="RadAjaxLoadingPanel1">
                             <fieldset id="fsAddCCosto" style="padding: 10px;">
                               <legend>Agregar Centro de Costo</legend>
                               <asp:HiddenField ID="hfIdProyAct" runat="server"/>
                               <asp:HiddenField ID="hfIdProycomp" runat="server"/>
                                <label>Actividad:</label>
                               <telerik:RadTextBox ID="rtxtDescActividad" ReadOnly="True" TextMode="MultiLine" runat="server" 
                                   Width="400px"/>
                               <label>Elemento de Gasto:</label>
                               <telerik:RadAutoCompleteBox ID="radcbElementoGasto" runat="server" Culture="es-ES"  
                                DataSourceID="OdsElementoGasto"
                               AutoPostBack="True" 
                                EmptyMessage="Ingrese criterio"
                                DataTextField="NomElemGasto" 
                                DataValueField="IdElemGasto"  
                                DropDownWidth="400px"
                                Width="400px"
                                TextSettings-SelectionMode="Single" InputType="Text">
                                <TextSettings SelectionMode="Single"></TextSettings>
                            </telerik:RadAutoCompleteBox>   
                            <asp:ObjectDataSource ID="OdsElementoGasto" runat="server" 
                                        SelectMethod="GetAllFromElementoGasto" 
                                        TypeName="SistFoncreagro.BussinesLogic.ElementoGastoBL">
                                    </asp:ObjectDataSource>
                               <label>Unidad:</label>
                               <telerik:RadTextBox ID="rtxtUnidad" runat="server" Width="200px"/>
                               <label>Porcentaje</label>
                               <telerik:RadNumericTextBox ID="rntxtPorcentaje" runat="server" MaxValue="100" 
                                   MinValue="0" ShowSpinButtons="True" Type="Percent">
                                   <NumberFormat ZeroPattern="n %" />
                               </telerik:RadNumericTextBox>
                               <br/> <br/>
                               <asp:Button ID="btnAddCCosto" Text="Agregar" CssClass="btn btn-info" runat="server" OnClick="btnAddCCosto_Click"/>
                               <asp:Button  ID="btnCloseAddCCosto" Text="Terminar" CssClass="btn btn-warning" OnClientClick="CloseAddCCosto(); return false;" runat="server"/>
                           </fieldset>
                           </telerik:RadAjaxPanel>
                         </ContentTemplate>
                     </telerik:RadWindow>
                   <telerik:RadAjaxPanel ID="rapGridCCostos" runat="server">
                    <telerik:RadGrid ID="rgCCostos" AutoGenerateColumns="False" CellPadding="0" GridLines="none" ShowFooter="True" runat="server">
                        <MasterTableView ClientDataKeyNames="IdCCosto" DataKeyNames="IdCCosto">
                            <Columns>
                                <telerik:GridBoundColumn HeaderText="Codigo" DataField="Codigo"/>
                                <telerik:GridBoundColumn HeaderText="Elemento de Gasto" DataField="NomElemGasto"/>
                                <telerik:GridBoundColumn HeaderText="Unidad" DataField="Unidad" FooterText="TOTAL"/>
                                <telerik:GridBoundColumn HeaderText="Porcentaje" DataField="Porcentaje" Aggregate="Sum" DataType="System.Decimal" DataFormatString="{0:0,0.00}"/>
                            </Columns>
                        </MasterTableView>
                    </telerik:RadGrid>
                    </telerik:RadAjaxPanel>
                </fieldset>
            </telerik:RadPageView>
            <telerik:RadPageView ID="RadPageView2" runat="server" alt="Adjuntos">
                <fieldset>
                    <legend>Documentos Adjuntos</legend>
                </fieldset>
            </telerik:RadPageView>
        </telerik:RadMultiPage>
    </div>
 </div>
 <telerik:RadCodeBlock runat="server" ID="rdbScripts">
     <script type="text/javascript">
         function rbShowAddCCosto_OnClientClicked() {
             var radWindow = $find('<%= rwShowAddCCosto.ClientID %>');
             radWindow.show();
         }

         function CloseAddCCosto() {
             var radWindow = $find('<%= rwShowAddCCosto.ClientID %>');
             radWindow.close();
         }
    </script>
 </telerik:RadCodeBlock>
</asp:Content>
