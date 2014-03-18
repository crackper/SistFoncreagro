<%@ Page Title="Tareas" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterMonitoreo1.master" CodeBehind="FrmTarea.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmTarea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                                                <table 
        style="width: 100%">
                                                    <tr>
                                                        <td style="height: 30px">
                                                                                    
                                                                                <telerik:RadTabStrip ID="RadTabStrip1" runat="server" 
                                                                                    MultiPageID="RadMultiPage1" SelectedIndex="0" Width="100%">
                                                                                    <Tabs>
                                                                                        <telerik:RadTab runat="server" Text="Información General" Selected="True">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Responsables">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Beneficiarios">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Documentación" Visible="False">
                                                                                        </telerik:RadTab>
                                                                                        <telerik:RadTab runat="server" Text="Entrega de Recursos">
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
                                                                                                                    ImageUrl="~/img/Nuevo.gif" ToolTip="Nuevo" />
                                                                                                            </td>
                                                                                                            <td style="text-align: right" width="5%">
                                                                                                                <asp:ImageButton ID="ImageButton6" runat="server" Height="25px" 
                                                                                                                    ImageUrl="~/img/Calendario.gif" ToolTip="Reprogramar Actividad" Width="25px" />
                                                                                                            </td>
                                                                                                            

                                                                                                            <td style="text-align: right" width="5%">
                                                                                                                <asp:ImageButton ID="ImageButton5" runat="server" Height="25px" 
                                                                                                                    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar Actividad" Width="25px" />
                                                                                                            </td>
                                                                                                            

                                                                                                            <td style="text-align: left" width="80%">
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
                                                                                                                            Estado:</td>
                                                                                                                        <td width="90%">
                                                                                                                            

                                                                                                                            <asp:Label ID="Label1" runat="server" style="font-weight: 700; font-size: 8pt"></asp:Label>
                                                                                                                            

                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    

                                                                                                                    <tr>
                                                                                                                        

                                                                                                                        <td>
                                                                                                                            

                                                                                                                        
                                                                                                                            Actividad/Tarea:<td>
                                                                                                                            
                                                                                                                                <telerik:RadComboBox ID="RadComboBox6" Runat="server" 
                                                                                                                                    AppendDataBoundItems="True" DataSourceID="SqlTareas" DataTextField="NomTarea" 
                                                                                                                                    DataValueField="IdTarea" TabIndex="2" Width="100%">
                                                                                                                                    <Items>
                                                                                                                                        <telerik:RadComboBoxItem runat="server" Text="TAREA NO CONTEMPLADA EN EL POA" 
                                                                                                                                            Value="N" />
                                                                                                                                    </Items>
                                                                                                                                </telerik:RadComboBox>
                                                                                                                            
                                                                                                                        </td>
                                                                                                                        
                                                                                                                    </tr>
                                                                                                                    
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            Cantidad<td>
                                                                                                                                <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" TabIndex="4" 
                                                                                                                                    Value="1">
                                                                                                                                    <incrementsettings interceptarrowkeys="False" />
                                                                                                                                </telerik:RadNumericTextBox>
                                                                                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" 
                                                                                                                                    ControlToValidate="RadNumericTextBox2" Display="Dynamic" 
                                                                                                                                    ErrorMessage="¡Debe ingresar la Cantidad!"></asp:RequiredFieldValidator>
                                                                                                                            </td>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    
                                                                                                                    <tr>
                                                                                                                        
                                                                                                                        <td>
                                                                                                                            
                                                                                                                            Taller:</td>
                                                                                                                        
                                                                                                                       <td>
                                                                                                                            
                                                                                                                            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" 
                                                                                                                                DataSourceID="SqlTalleres" DataTextField="Nombre" DataValueField="IdTaller" 
                                                                                                                                Font-Names="Arial" Font-Size="8pt" Width="100%">
                                                                                                                <asp:ListItem Value="0">NO APLICA</asp:ListItem>
                                                                                                                            </asp:DropDownList>
                                                                                                                            
                                                                                                                        </td>
                                                                                                                        
                                                                                                                    </tr>
                                                                                                                    
                                                                                                                    <tr>
                                                                                                                        
                                                                                                                        <td>
                                                                                                                            
                                                                                                                            Nº Documento:</td>
                                                                                                                        
                                                                                                                        <td>
                                                                                                                            
                                                                                                                            <asp:TextBox ID="TextBox12" runat="server" Width="320px"></asp:TextBox>
                                                                                                                            
                                                                                                                        </td>
                                                                                                                        
                                                                                                                    </tr>
                                                                                                                    
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            Descripción /Comentario:</td>
                                                                                                                        <td>
                                                                                                                            <asp:TextBox ID="TextBox11" runat="server" CssClass="Texto1" TabIndex="11" 
                                                                                                                                TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                                                                                                                                ControlToValidate="TextBox11" Display="Dynamic" 
                                                                                                                                ErrorMessage="¡Debe ingresar la Descripción o Comentario!"></asp:RequiredFieldValidator>
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
                                                                                                    
                                                                                                    <telerik:RadGrid ID="RadGrid4" runat="server" AutoGenerateColumns="False" 
                                                                                                        CellSpacing="0" DataSourceID="SqlResponsables" GridLines="None" Skin="Hay">
                                                                                                        <ClientSettings>
                                                                                                            <Selecting AllowRowSelect="True" />
                                                                                                        </ClientSettings>
                                                                                            <mastertableview clientdatakeynames="IdResponsable" commanditemdisplay="Top" 
                                                                                                        datakeynames="IdResponsable" datasourceid="SqlResponsables" 
                                                                                                        nomasterrecordstext="No existen registros.">
                                                                                                <commanditemsettings addnewrecordtext="Agregar Responsables" 
                                                                                                        exporttopdftext="Export to PDF" showrefreshbutton="False" />
                                                                                                <rowindicatorcolumn filtercontrolalttext="Filter RowIndicator column"></rowindicatorcolumn>
                                                                                                <expandcollapsecolumn filtercontrolalttext="Filter ExpandColumn column"></expandcollapsecolumn>
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
                                                                                                    <telerik:GridBoundColumn DataField="Responsable" 
                                                                                                        FilterControlAltText="Filter Responsable column" HeaderText="Responsable" 
                                                                                                        SortExpression="Responsable" UniqueName="Responsable">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="15%" /></telerik:GridBoundColumn><telerik:GridBoundColumn 
                                                                                                        DataField="Observaciones" DataType="System.Int32" 
                                                                                                        FilterControlAltText="Filter Observaciones column" HeaderText="Observaciones" 
                                                                                                        SortExpression="Observaciones" UniqueName="Observaciones">
                                                                                                        <HeaderStyle Width="37%" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    </Columns>
                                                                                                    
                                                                                                <editformsettings editformtype="WebUserControl" 
                                                                                                        usercontrolname="~\Monitoreo\Controles\ControlResponsable.ascx">
                                                                                                    <editcolumn filtercontrolalttext="Filter EditCommandColumn column"></editcolumn></editformsettings></mastertableview>
                                                                                                <filtermenu enableimagesprites="False"></filtermenu>
                                                                                                <headercontextmenu cssclass="GridContextMenu GridContextMenu_Default"></headercontextmenu></telerik:RadGrid>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView3" runat="server">
                                                                                        <table class="tabla3" style="width: 100%">
                                                                                            <tr>
                                                                                                
                                                                                                <td>
                                                                                                    
                                                                                                    <telerik:RadGrid ID="RadGrid5" runat="server" AutoGenerateColumns="False" 
                                                                                                        CellSpacing="0" DataSourceID="SqlAsistentes" GridLines="None" ShowFooter="True" 
                                                                                                        Skin="Hay">
                                                                                                        <ClientSettings>
                                                                                                            <Selecting AllowRowSelect="True" />
                                                                                                        </ClientSettings>
                                                                                                <mastertableview clientdatakeynames="IdAsistente,IdActitud" 
                                                                                                        commanditemdisplay="Top" datakeynames="IdAsistente,IdActitud" 
                                                                                                        datasourceid="SqlAsistentes" nomasterrecordstext="No existen registros.">
                                                                                                    <commanditemsettings addnewrecordtext="Agregar Asistente" 
                                                                                                        exporttopdftext="Export to PDF" showrefreshbutton="False" />
                                                                                                    <rowindicatorcolumn filtercontrolalttext="Filter RowIndicator column">
                                                                                                        <HeaderStyle Width="20px" />
                                                                                                    </rowindicatorcolumn>
                                                                                                    <expandcollapsecolumn filtercontrolalttext="Filter ExpandColumn column">
                                                                                                        <HeaderStyle Width="20px" />
                                                                                                    </expandcollapsecolumn>
                                                                                                    <Columns>
                                                                                                        <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                            FilterControlAltText="Filter EditCommandColumn column">
                                                                                                            <HeaderStyle Width="1.5%" />
                                                                                                        </telerik:GridEditCommandColumn>
                                                                                                        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                            ConfirmDialogType="RadWindow" 
                                                                                                            ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                                                                                            ConfirmTitle="Mensaje de Confirmación" 
                                                                                                            FilterControlAltText="Filter column column" Text="Eliminar" UniqueName="column">
                                                                                                            <HeaderStyle Width="1.5%" />
                                                                                                        </telerik:GridButtonColumn>
                                                                                                        <telerik:GridBoundColumn DataField="IdAsistente" DataType="System.Int32" 
                                                                                                            FilterControlAltText="Filter IdAsistente column" HeaderText="IdAsistente" 
                                                                                                            ReadOnly="True" SortExpression="IdAsistente" UniqueName="IdAsistente" 
                                                                                                            Visible="False">
                                                                                                            <HeaderStyle HorizontalAlign="Center" />
                                                                                                        </telerik:GridBoundColumn>
                                                                                                        <telerik:GridBoundColumn DataField="Asistente" 
                                                                                                            FilterControlAltText="Filter Asistente column" HeaderText="Asistente" 
                                                                                                            ReadOnly="True" SortExpression="Asistente" UniqueName="Asistente">
                                                                                                            <HeaderStyle HorizontalAlign="Center" Width="35%" />
                                                                                                        </telerik:GridBoundColumn>
                                                                                                        <telerik:GridBoundColumn DataField="Cargo" 
                                                                                                            FilterControlAltText="Filter Cargo column" HeaderText="Cargo" 
                                                                                                            SortExpression="Cargo" UniqueName="Cargo">
                                                                                                            <HeaderStyle HorizontalAlign="Center" Width="27%" />
                                                                                                        </telerik:GridBoundColumn>
                                                                                                        <telerik:GridBoundColumn Aggregate="Count" DataField="Actitud" 
                                                                                                            FilterControlAltText="Filter Actitud column" FooterText="TOTAL:" 
                                                                                                            HeaderText="Actitud" SortExpression="Actitud" UniqueName="Actitud">
                                                                                                            <HeaderStyle HorizontalAlign="Center" Width="35%" />
                                                                                                        </telerik:GridBoundColumn>
                                                                                                    </Columns>
                                                                                                    
                                                                                                    <editformsettings editformtype="WebUserControl" 
                                                                                                        usercontrolname="~\Monitoreo\Controles\ControlAsistente.ascx">
                                                                                                        <editcolumn filtercontrolalttext="Filter EditCommandColumn column">
                                                                                                        </editcolumn>
                                                                                                    </editformsettings>
                                                                                                </mastertableview>
                                                                                                <filtermenu enableimagesprites="False">
                                                                                                </filtermenu>
                                                                                                <headercontextmenu cssclass="GridContextMenu GridContextMenu_Default">
                                                                                                </headercontextmenu>
                                                                                            </telerik:RadGrid>
                                                                                                    
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </telerik:RadPageView>
                                                                                    <telerik:RadPageView ID="RadPageView4" runat="server">
                                                                                        
                                                                                        <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False" 
                                                                                            CellSpacing="0" DataSourceID="SqlInsumos" GridLines="None" ShowFooter="True" 
                                                                                            Skin="Hay">
                                                                                            <ClientSettings>
                                                                                                <Selecting AllowRowSelect="True" />
                                                                                            </ClientSettings>
                                                                                            <mastertableview clientdatakeynames="IdInsumo" commanditemdisplay="Top" 
                                                                                            datakeynames="IdInsumo" datasourceid="SqlInsumos" 
                                                                                            nomasterrecordstext="No existen registros.">
                                                                                                <commanditemsettings addnewrecordtext="Agregar Recurso" 
                                                                                            exporttopdftext="Export to PDF" showrefreshbutton="False" />
                                                                                                <rowindicatorcolumn filtercontrolalttext="Filter RowIndicator column">
                                                                                                </rowindicatorcolumn>
                                                                                                <expandcollapsecolumn filtercontrolalttext="Filter ExpandColumn column">
                                                                                                </expandcollapsecolumn>
                                                                                                <Columns>
                                                                                                    <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                                                                        FilterControlAltText="Filter EditCommandColumn column">
                                                                                                        <HeaderStyle Width="1.5%" />
                                                                                                    </telerik:GridEditCommandColumn>
                                                                                                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                                                                        ConfirmDialogType="RadWindow" 
                                                                                                        ConfirmText="¿Está seguro de Eliminar el Registro?" 
                                                                                                        ConfirmTitle="Mensaje de Confirmación" 
                                                                                                        FilterControlAltText="Filter column column" Text="Eliminar" UniqueName="column">
                                                                                                        <HeaderStyle Width="1.5%" />
                                                                                                    </telerik:GridButtonColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Producto" 
                                                                                                        FilterControlAltText="Filter Producto column" HeaderText="Descripción" 
                                                                                                        SortExpression="Producto" UniqueName="Producto">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="20%" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="CCosto" 
                                                                                                        FilterControlAltText="Filter CCosto column" HeaderText="C.Costo" 
                                                                                                        SortExpression="CCosto" UniqueName="CCosto">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                                                                                        <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Beneficiario" 
                                                                                                        FilterControlAltText="Filter Beneficiario column" HeaderText="Beneficiario" 
                                                                                                        UniqueName="Beneficiario">
                                                                                                        <HeaderStyle Width="22%" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Factura" 
                                                                                                        FilterControlAltText="Filter Factura column" HeaderText="Factura" 
                                                                                                        ReadOnly="True" SortExpression="Factura" UniqueName="Factura" 
                                                                                                        Visible="False">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="10%" />
                                                                                                        <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Observaciones" 
                                                                                                        FilterControlAltText="Filter Observaciones column" HeaderText="Observaciones" 
                                                                                                        SortExpression="Observaciones" UniqueName="Observaciones">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="15%" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Unidad" 
                                                                                                        FilterControlAltText="Filter Unidad column" HeaderText="Unidad" 
                                                                                                        SortExpression="Unidad" UniqueName="Unidad">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                                                                                        <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="Cantidad" DataType="System.Decimal" 
                                                                                                        FilterControlAltText="Filter Cantidad column" HeaderText="Cant." 
                                                                                                        SortExpression="Cantidad" UniqueName="Cantidad">
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                                                                                        <ItemStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="PrecioUnitario" DataType="System.Decimal" 
                                                                                                        FilterControlAltText="Filter PrecioUnitario column" FooterText="Total:" 
                                                                                                        HeaderText="P. Unit." SortExpression="PrecioUnitario" 
                                                                                                        UniqueName="PrecioUnitario">
                                                                                                        <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="6%" />
                                                                                                        <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdUnidad" DataType="System.Int32" 
                                                                                                        FilterControlAltText="Filter IdUnidad column" HeaderText="IdUnidad" 
                                                                                                        SortExpression="IdUnidad" UniqueName="IdUnidad" Visible="False">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                        <ItemStyle HorizontalAlign="Left" Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdControl" DataType="System.Int32" 
                                                                                                        FilterControlAltText="Filter IdControl column" HeaderText="IdControl" 
                                                                                                        SortExpression="IdControl" UniqueName="IdControl" Visible="False">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdInsumo" DataType="System.Int32" 
                                                                                                        FilterControlAltText="Filter IdInsumo column" HeaderText="IdInsumo" 
                                                                                                        ReadOnly="True" SortExpression="IdInsumo" UniqueName="IdInsumo" Visible="False">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdOcxFactura" DataType="System.Int32" 
                                                                                                        FilterControlAltText="Filter IdOcxFactura column" HeaderText="IdOcxFactura" 
                                                                                                        SortExpression="IdOcxFactura" UniqueName="IdOcxFactura" Visible="False">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdCCosto" DataType="System.Int32" 
                                                                                                        FilterControlAltText="Filter IdCCosto column" HeaderText="IdCCosto" 
                                                                                                        SortExpression="IdCCosto" UniqueName="IdCCosto" Visible="False">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdCatalogo" DataType="System.Int32" 
                                                                                                        FilterControlAltText="Filter IdCatalogo column" HeaderText="IdCatalogo" 
                                                                                                        SortExpression="IdCatalogo" UniqueName="IdCatalogo" Visible="False">
                                                                                                        <HeaderStyle HorizontalAlign="Center" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridBoundColumn DataField="IdInteresado" 
                                                                                                        FilterControlAltText="Filter IdInteresado column" HeaderText="IdInteresado" 
                                                                                                        UniqueName="IdInteresado" Visible="False">
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="8pt" />
                                                                                                    </telerik:GridBoundColumn>
                                                                                                    <telerik:GridCalculatedColumn Aggregate="Sum" 
                                                                                                        DataFields="PrecioUnitario,Cantidad" DataFormatString="{0:N2}" 
                                                                                                        DataType="System.Decimal" Expression="{0}*{1}" 
                                                                                                        FilterControlAltText="Filter column1 column" FooterText="Total:" 
                                                                                                        HeaderText="Sub Total" UniqueName="column1">
                                                                                                        <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
                                                                                                        <HeaderStyle HorizontalAlign="Center" Width="7%" />
                                                                                                        <ItemStyle Font-Names="Arial" Font-Size="8pt" HorizontalAlign="Right" />
                                                                                                    </telerik:GridCalculatedColumn>
                                                                                                </Columns>
                                                                                        
                                                                                                <editformsettings editformtype="WebUserControl" 
                                                                                            usercontrolname="~\Monitoreo\Controles\ControlInsumos.ascx">
                                                                                                    <editcolumn filtercontrolalttext="Filter EditCommandColumn column">
                                                                                                    </editcolumn>
                                                                                                </editformsettings>
                                                                                            </mastertableview>
                                                                                            <filtermenu enableimagesprites="False">
                                                                                            </filtermenu>
                                                                                            <headercontextmenu cssclass="GridContextMenu GridContextMenu_Hay">
                                                                                            </headercontextmenu>
                                                                                        </telerik:RadGrid>
                                                                                        
                                                                                        <asp:SqlDataSource ID="SqlInsumos" runat="server" 
                                                                                            ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                                                            SelectCommand="GetINSUMOSByIdControlDetallado" 
                                                                                            SelectCommandType="StoredProcedure">
                                                                                            <SelectParameters>
                                                                                                <asp:QueryStringParameter Name="IdControl" QueryStringField="IdControl" 
                                                                                                    Type="Int32" />
                                                                                            </SelectParameters>
                                                                                            
                                                                                        </asp:SqlDataSource>
                                                                                        
                                                                                    </telerik:RadPageView>
                                                                               
                                                                                </telerik:RadMultiPage>    
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

        function CargarVentana(nombre) {
            aviso = open("/SistIntegral/Monitoreo/Adjuntos/" + nombre, "Documento", "status=no, directories=no, toolbar=no, width=800, height=500, left=100, top=100")
            //        window.open("../Archivos1/Logistica/" + nombre, nombre, "width=800, height=500")    
        }
        function Abrir(IdProyecto) {
            var oWnd = radopen("/SistIntegral/Monitoreo/Formularios/FrmStakeholders.aspx?IdProyecto=" + IdProyecto, "Ventana");
        }
        function openWin(IdControl) {
            var oWnd = radopen("Dialog3.aspx?IdControl=" + IdControl, "RadWindow1");
        }

        function OnClientClose(oWnd, args) {
            //get the transferred arguments
            var arg = args.get_argument();
            if (arg) {
                var fecha = arg.cityName;
                var IdControl = arg.idOC;
                var observacion = arg.observacion;

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Reprogramar|" + fecha + "|" + IdControl + "|" + observacion);
            }
        }
        function openWin1(IdControl) {
            var oWnd = radopen("Dialog6.aspx?IdControl=" + IdControl, "RadWindow2");
        }
        function OnClientClose1(oWnd, args) {
            //get the transferred arguments
            var arg = args.get_argument();
            if (arg) {
               
                var IdControl = arg.idOC;
                var observacion = arg.observacion;

                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Cancelar|" +  IdControl + "|" + observacion);
            }
        }
     </script>
    </telerik:RadCodeBlock>
    

  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="RadGrid2">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
                                                </telerik:RadAjaxManager>


                                                <asp:SqlDataSource ID="SqlDocumentos" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetSUSTENTOByIdControl" 
                                                    SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdControl" QueryStringField="IdControl" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                                                                    

                                                                                                                            <asp:SqlDataSource ID="SqlTareas" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetTareasPoaTecnico" SelectCommandType="StoredProcedure">
                                                                                                                                <SelectParameters>
                                                                                                                                    <asp:QueryStringParameter Name="IdDetalleEje" QueryStringField="IdDetalleEje" 
                                                                                                                                        Type="Int32" />
                                                                                                                                </SelectParameters>
                                                </asp:SqlDataSource>
                                                                                                                            

                                                <asp:SqlDataSource ID="SqlTalleres" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetTALLERByIdProyecto" SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="idDetalleEje" QueryStringField="IdDetalleEje" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                                <asp:SqlDataSource ID="SqlAsistentes" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetASISTENTEByIdControlDetallado" 
                                                    SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdControl" QueryStringField="IdControl" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                                                                                                            

                                                <asp:SqlDataSource ID="SqlResponsables" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                                    SelectCommand="GetRESPONSABLEByIdControlDetallado" 
                                                    SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:QueryStringParameter Name="IdControl" QueryStringField="IdControl" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                                                                                                            

     <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"   
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Ventana" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" Title="Registro de StakeHolders">
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
            <telerik:RadWindow ID="RadWindow1" runat="server" 
                Behaviors="Close" OnClientClose="OnClientClose" Width="1000px" AutoSize="True">
            </telerik:RadWindow>
             <telerik:RadWindow ID="RadWindow2" runat="server" 
                Behaviors="Close" OnClientClose="OnClientClose1" Width="1000px" AutoSize="True">
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
                                                                                    
                                                
                                                </asp:Content>


