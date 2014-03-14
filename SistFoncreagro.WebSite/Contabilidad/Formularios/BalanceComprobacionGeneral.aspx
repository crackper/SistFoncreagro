<%@ Page Title="Balance de Comprobación" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="BalanceComprobacionGeneral.aspx.vb" Inherits="SistFoncreagro.WebSite.BalanceComprobacionGeneral" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="style1">
        <tr>
            <td style="font-weight: 700">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>

    <telerik:RadGrid ID="RadGrid1" runat="server" DataSourceID="Nivel3" 
        CellSpacing="0" GridLines="None" AutoGenerateColumns="False" Skin="Hay" 
                    CellPadding="0">
<MasterTableView DataSourceID="Nivel3" ClientDataKeyNames="Codigo" 
            DataKeyNames="Codigo" NoDetailRecordsText="No existen registros." 
            NoMasterRecordsText="No existen registros." ShowFooter="True" 
            CellPadding="0" CellSpacing="0">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" CssClass="cursor" 
                    ImageUrl="~/img/Agregar.gif" ToolTip="Movimiento detallado de la cuenta" />
            </ItemTemplate>
            <HeaderStyle Width="2%" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter CodigoN1 column" HeaderText="Cuenta" ReadOnly="True" 
            SortExpression="Codigo" UniqueName="Codigo">
            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                Width="6%" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Nombre" ReadOnly="True" 
            SortExpression="Nombre" UniqueName="Nombre" FooterText="TOTAL:">
            <FooterStyle Font-Bold="True" />
            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                Width="20%" />
            <ItemStyle Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SaldoInicialMN" DataType="System.Decimal" 
            FilterControlAltText="Filter SaldoInicialMN column" HeaderText="Saldo Inicial MN" 
            ReadOnly="True" SortExpression="SaldoInicialMN" 
            UniqueName="SaldoInicialMN" Aggregate="Sum" DataFormatString="{0:0,0.00}" 
            FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                Width="9%" />
            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DebeMN" DataType="System.Decimal" 
            FilterControlAltText="Filter DebeMN column" HeaderText="Debe MN" ReadOnly="True" 
            SortExpression="DebeMN" UniqueName="DebeMN" Aggregate="Sum" 
            DataFormatString="{0:0,0.00}" FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                Width="9%" />
            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="HaberMN" DataType="System.Decimal" 
            FilterControlAltText="Filter HaberMN column" HeaderText="Haber MN" 
            ReadOnly="True" SortExpression="HaberMN" UniqueName="HaberMN" 
            Aggregate="Sum" DataFormatString="{0:0,0.00}" 
            FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                Width="9%" />
            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SaldoActualMN" DataType="System.Decimal" 
            FilterControlAltText="Filter SaldoActualMN column" HeaderText="Saldo Actual MN" 
            ReadOnly="True" SortExpression="SaldoActualMN" UniqueName="SaldoActualMN" 
            Aggregate="Sum" DataFormatString="{0:0,0.00}" 
            FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                Width="9%" />
            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SaldoInicialME" DataType="System.Decimal" 
            FilterControlAltText="Filter SaldoInicialME column" HeaderText="Saldo Inicial ME" 
            ReadOnly="True" SortExpression="SaldoInicialME" 
            UniqueName="SaldoInicialME" Aggregate="Sum" DataFormatString="{0:0,0.00}" 
            FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                Width="9%" />
            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DebeME" DataType="System.Decimal" 
            FilterControlAltText="Filter DebeME column" HeaderText="Debe ME" ReadOnly="True" 
            SortExpression="DebeME" UniqueName="DebeME" Aggregate="Sum" 
            DataFormatString="{0:0,0.00}" FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                Width="9%" />
            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="HaberME" DataType="System.Decimal" 
            FilterControlAltText="Filter HaberME column" HeaderText="Haber ME" 
            ReadOnly="True" SortExpression="HaberME" UniqueName="HaberME" 
            Aggregate="Sum" DataFormatString="{0:0,0.00}" 
            FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                Width="9%" />
            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SaldoActualME" DataType="System.Decimal" 
            FilterControlAltText="Filter SaldoActualME column" HeaderText="Saldo Actual ME" 
            ReadOnly="True" SortExpression="SaldoActualME" UniqueName="SaldoActualME" 
            Aggregate="Sum" DataFormatString="{0:0,0.00}" 
            FooterAggregateFormatString="{0:0,0.00}">
            <FooterStyle Font-Bold="True" HorizontalAlign="Right" />
            <HeaderStyle HorizontalAlign="Center" Font-Names="Arial" Font-Size="8pt" 
                Width="9%" />
            <ItemStyle HorizontalAlign="Right" Font-Names="Arial" Font-Size="8pt" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
    <FormTableStyle CellPadding="0" CellSpacing="0" />
    <FormMainTableStyle CellPadding="0" CellSpacing="0" />
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
    </telerik:RadGrid>
            </td>
        </tr>
    </table>
    <asp:SqlDataSource ID="Nivel3" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetBalanceComprobacionN3G" 
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter Name="Fecha" QueryStringField="Fecha" 
                Type="DateTime" />
            <asp:QueryStringParameter Name="idProyecto" QueryStringField="Proyecto" 
                Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
                                            
             

                                            
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Height="750px" 
        Width="1200px">
  <Windows>
                <telerik:RadWindow ID="Movimiento" runat="server" Behavior="Resize, Close, Move" 
                    Behaviors="Resize, Close, Move" Height="750px"
                    InitialBehavior="None" Left="" NavigateUrl="" 
                     Style="display: none;" Top="" VisibleStatusbar="True"
                    Width="1150px" Title="Movimiento detallado de la cuenta" AutoSize="True">
                    <Localization Cancel="Cancelar" Close="Cerrar" Maximize="Maximizar" 
                        Minimize="Minimizar" Restore="Restaurar" />
                </telerik:RadWindow>
            </Windows>
                            </telerik:RadWindowManager>
  <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">

        function Abrir(Fecha, Proyecto, Cuenta) {
            var oWnd = radopen("MovDetCuenta.aspx?Fecha=" + Fecha + "&Proyecto=" + Proyecto + "&Cuenta=" + Cuenta, "Movimiento");
        }
                
     </script>
    </telerik:RadCodeBlock>
</asp:Content>
