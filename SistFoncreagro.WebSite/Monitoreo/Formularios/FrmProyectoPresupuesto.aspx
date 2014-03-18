<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmProyectoPresupuesto.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProyectoPresupuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <SCRIPT type = "text/javascript">
        var Total = 0
//        function dar_formato(num) {
//           var cadena = ""; var aux;
//           var cont = 1, m, k;

//            if (num < 0) aux = 1; else aux = 0;
//            num = num.toString();
//            for (m = num.length - 1; m >= 0; m--) {
//                cadena = num.charAt(m) + cadena;
//                if (cont % 3 == 0 && m > aux) cadena = "." + cadena; else cadena = cadena;
//                if (cont == 3) cont = 1; else cont++;
//         }
//            cadena = cadena.replace(/.,/, ",");
//            
//            return cadena;

//        }  
  

        function CalcularTotalPresup1(Dato, Suma)
        {
        var Dato1 = document.getElementById(Dato);
        var Suma1 = document.getElementById(Suma);

        if (Dato1.value == '') 
        {Dato1.value = 0
        }
        if (Suma1.value == '') {
            Suma1.value = 0
        }
        Total = Suma1.value * 1 - Dato1.value * 1;
        
     }

     function CalcularTotalPresup2(Dato, Suma) {
         var Dato1 = document.getElementById(Dato);
         var Suma1 = document.getElementById(Suma);
         
         if (Dato1.value == '') {
             Dato1.value = 0
         }
         if (Suma1.value == '') {
             Suma1.value = 0
         }
            Suma1.value = Total * 1 + Dato1.value * 1;
     }

    </SCRIPT> 
    <table width="100%">
        <tr>
            <td>
                <asp:Label ID="LblProyecto" runat="server" Font-Bold="True" Font-Size="Small"></asp:Label>
                <asp:HiddenField ID="HIdProyecto" runat="server" />
                <telerik:RadWindowManager ID="RWMensajes" runat="server">
                </telerik:RadWindowManager>
            </td>
        </tr>
        <tr>
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
                                <asp:HiddenField ID="HFIdEjerPresup" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblPresup" runat="server" ForeColor="Red" 
                    Text="No se ha activado ningún Proceso Presupuestal"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel2" runat="server">
                    <table>
                        <tr>
                            <td align="right" style="width: 187px; height: 29px;">
                                Año:</td>
                            <td style="width: 246px; height: 29px;">
                                <telerik:RadNumericTextBox ID="TxtAnio" Runat="server" MaxLength="4" 
                                    MaxValue="9999" MinValue="2000">
                                    <NumberFormat DecimalDigits="0" GroupSeparator="" />
                                </telerik:RadNumericTextBox>
                            </td>
                            <td style="width: 47px; height: 29px">
                                </td>
                            <td align="right" style="height: 29px">
                                Mes inicio Presupuesto:</td>
                            <td style="height: 29px">
                                <asp:TextBox ID="TxtMesIni" runat="server" Width="125px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 187px">
                                Ejercicio Presupuestal:</td>
                            <td style="width: 246px">
                                <asp:TextBox ID="TxtEjerPresup" runat="server" Width="125px"></asp:TextBox>
                            </td>
                            <td style="width: 47px">
                                &nbsp;</td>
                            <td align="right">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="BtnNuevo" runat="server" Text="Nuevo Presupuesto" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel3" runat="server" Width="850px">
                    <div 
    
                        
                        
                        
                        style="visibility: visible; overflow: auto; clip: rect(auto, auto, auto, auto); width: 1130px;">
                        <telerik:RadGrid ID="RGDatos" runat="server" CellSpacing="0" 
                        DataSourceID="OdsDatosPresup" GridLines="None" AutoGenerateColumns="False" 
                        ShowFooter="True" AllowPaging="True" Width="100%">
                            <MasterTableView datasourceid="OdsDatosPresup" ClientDataKeyNames="IdCCosto" 
                                DataKeyNames="IdCCosto" ShowFooter="False">
                                <CommandItemSettings ExportToPdfText="Export to PDF">
                                </CommandItemSettings>
                                <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                    <HeaderStyle Width="20px"></HeaderStyle>
                                </RowIndicatorColumn>
                                <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                    <HeaderStyle Width="20px"></HeaderStyle>
                                </ExpandCollapseColumn>
                                <Columns>
                                    <telerik:GridBoundColumn DataField="IdCCosto" DataType="System.Int32" 
            FilterControlAltText="Filter IdCCosto column" HeaderText="IdCCosto" 
            SortExpression="IdCCosto" UniqueName="IdCCosto" Visible="False">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="Componente" DataType="System.Int32" 
            FilterControlAltText="Filter Componente column" HeaderText="Componente" 
            SortExpression="Componente" UniqueName="Componente" Visible="False">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="Actividad" DataType="System.Int32" 
            FilterControlAltText="Filter Actividad column" HeaderText="Actividad" 
            SortExpression="Actividad" UniqueName="Actividad">
                                        <ItemStyle Font-Names="Arial" Font-Size="6pt" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="ElementoGasto" DataType="System.Int32" 
            FilterControlAltText="Filter ElementoGasto column" HeaderText="ElementoGasto" 
            SortExpression="ElementoGasto" UniqueName="ElementoGasto">
                                        <ItemStyle Font-Names="Arial" Font-Size="6pt" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="Unidad" 
            FilterControlAltText="Filter Unidad column" HeaderText="Unidad" 
            SortExpression="Unidad" UniqueName="Unidad" Visible="False">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="TipoPres" 
                                        FilterControlAltText="Filter Tipo column" HeaderText="Tipo" 
                                        UniqueName="Tipo" Visible="False">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridTemplateColumn DataField="Ene" 
            FilterControlAltText="Filter Ene column" HeaderText="Enero" 
            UniqueName="Ene">
                                        <ItemTemplate>
                                            <asp:Label ID="LblEne" runat="server" Text='<%# Eval("Ene") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtEne" runat="server" Text='<%# Eval("Ene") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Feb" 
            FilterControlAltText="Filter Feb column" HeaderText="Febrero" 
            UniqueName="Feb">
                                        <ItemTemplate>
                                            <asp:Label ID="LblFeb" runat="server" Text='<%# Eval("Feb") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtFeb" runat="server" Text='<%# Eval("Feb") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Mar" 
            FilterControlAltText="Filter Mar column" HeaderText="Marzo" 
            UniqueName="Mar">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMar" runat="server" Text='<%# Eval("Mar") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtMar" runat="server" Text='<%# Eval("Mar") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Abr" 
            FilterControlAltText="Filter Abr column" HeaderText="Abril" 
            UniqueName="Abr">
                                        <ItemTemplate>
                                            <asp:Label ID="LblAbr" runat="server" Text='<%# Eval("Abr") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtAbr" runat="server" Text='<%# Eval("Abr") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="May" 
            FilterControlAltText="Filter May column" HeaderText="Mayo" 
            UniqueName="Mayo">
                                        <ItemTemplate>
                                            <asp:Label ID="LblMayo" runat="server" Text='<%# Eval("Mayo") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtMayo" runat="server" Text='<%# Eval("Mayo") %>' 
                    Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Jun" 
            FilterControlAltText="Filter Jun column" HeaderText="Junio" 
            UniqueName="Jun">
                                        <ItemTemplate>
                                            <asp:Label ID="LblJun" runat="server" Text='<%# Eval("Jun") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtJun" runat="server" Text='<%# Eval("Jun") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Jul" 
            FilterControlAltText="Filter Jul column" HeaderText="Julio" 
            UniqueName="Jul" InitializeTemplatesFirst="False">
                                        <ItemTemplate>
                                            <asp:Label ID="LblJul" runat="server" Text='<%# Eval("Jul") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtJul" runat="server" Text='<%# Eval("Jul") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Ago" 
            FilterControlAltText="Filter Ago column" HeaderText="Agosto" 
            UniqueName="Ago">
                                        <ItemTemplate>
                                            <asp:Label ID="LblAgo" runat="server" Text='<%# Eval("Ago") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtAgo" runat="server" Text='<%# Eval("Ago") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Sep" 
            FilterControlAltText="Filter Sep column" HeaderText="Septiembre" 
            UniqueName="Sep">
                                        <ItemTemplate>
                                            <asp:Label ID="LblSep" runat="server" Text='<%# Eval("Sep") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtSep" runat="server" Text='<%# Eval("Sep") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Oct" 
            FilterControlAltText="Filter Oct column" HeaderText="Octubre" 
            UniqueName="Oct">
                                        <ItemTemplate>
                                            <asp:Label ID="LblOct" runat="server" Text='<%# Eval("Oct") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtOct" runat="server" Text='<%# Eval("Oct") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Nov" 
            FilterControlAltText="Filter Nov column" HeaderText="Noviembre" 
            UniqueName="Nov">
                                        <ItemTemplate>
                                            <asp:Label ID="LblNov" runat="server" Text='<%# Eval("Nov") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtNov" runat="server" Text='<%# Eval("Nov") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Dic" 
            FilterControlAltText="Filter Dic column" HeaderText="Diciembre" 
            UniqueName="Dic">
                                        <ItemTemplate>
                                            <asp:Label ID="LblDic" runat="server" Text='<%# Eval("Dic") %>' Width="90px"></asp:Label>
                                            <asp:TextBox ID="TxtDic" runat="server" Text='<%# Eval("Dic") %>' Width="50px"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Total" 
            FilterControlAltText="Filter Total column" HeaderText="TOTAL" 
            UniqueName="Total" FooterText="TOTAL  " 
            DataType= "System.Decimal">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TxtTotal" runat="server" Text='<%# Eval("Total") %>' 
                    Width="50px" BorderStyle="None" ReadOnly="True"></asp:TextBox>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridButtonColumn CommandName="Grabar" 
            FilterControlAltText="Filter Grabar column" HeaderText="Grabar" Text="Grabar" 
            UniqueName="Grabar">
                                    </telerik:GridButtonColumn>
                                </Columns>
                                <EditFormSettings>
                                    <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                    </EditColumn>
                                </EditFormSettings>
                            </MasterTableView>
                            <FilterMenu EnableImageSprites="False">
                            </FilterMenu>
                            <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                            </HeaderContextMenu>
                        </telerik:RadGrid>
                    </div>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                    <asp:ObjectDataSource ID="OdsDatosPresup" runat="server" 
                        SelectMethod="GetDatosPresupByParameters" 
                        TypeName="SistFoncreagro.BussinesLogic.DatosPresupBL">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="_IdProyecto" QueryStringField="IdProyecto" 
                                Type="Int32" />
                            <asp:ControlParameter ControlID="HFIdEjerPresup" Name="_IdEjerPresup" 
                                PropertyName="Value" Type="Int32" />
                            <asp:ControlParameter ControlID="TxtAnio" Name="_Anio" PropertyName="Text" 
                                Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td align="right">
                    <asp:Panel ID="Panel4" runat="server" style="text-align: left">
                        <asp:Label ID="Label1" runat="server" style="font-weight: 700" 
                    Text="Total Presupueto Financiero: "></asp:Label>
                        <telerik:RadNumericTextBox ID="TxtTotalFin" Runat="server">
                        </telerik:RadNumericTextBox>
                    </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                    &nbsp;</td>
        </tr>
        </table>
                </asp:Content>
