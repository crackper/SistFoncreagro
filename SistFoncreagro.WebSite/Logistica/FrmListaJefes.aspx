<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaJefes.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaJefes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="ListadoRolesAprobacion" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
    <fieldset>
        <legend style="font-family: Arial; font-size: 15px; width: 300  px;">Consulta Niveles de Aprobación
                </legend>
    <div style="height: 900px; overflow: scroll; width: 910px;" class="grid">
    <telerik:RadGrid ID="GridAprobaciones" runat="server" 
        AllowFilteringByColumn="True" AllowPaging="True" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="SqlDataSource1" GridLines="None" Skin="Hay">
        <GroupingSettings CaseSensitive="False" />
<MasterTableView datasourceid="SqlDataSource1" commanditemdisplay="Top" pagesize="50">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        addnewrecordtext="Agregar Nuevo Registro" exporttocsvtext="Exportar a CSV" 
        exporttoexceltext="Exportar a Excel" exporttowordtext="Exportar a Word" 
        refreshtext="Actualizar" showaddnewrecordbutton="False" 
        showexporttoexcelbutton="True" showrefreshbutton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="IdPersonal" DataType="System.Int32" 
            FilterControlAltText="Filter IdPersonal column" HeaderText="IdPersonal" 
            SortExpression="IdPersonal" UniqueName="IdPersonal" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="Area" 
            FilterControlAltText="Filter Area column" FilterControlWidth="50px" 
            HeaderText="Area" ReadOnly="True" ShowFilterIcon="False" SortExpression="Area" 
            UniqueName="Area">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="Personal" 
            FilterControlAltText="Filter Personal column" FilterControlWidth="200px" 
            HeaderText="Apellidos y Nombres" ReadOnly="True" ShowFilterIcon="False" 
            SortExpression="Personal" UniqueName="Personal">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="NombreRol" 
            FilterControlAltText="Filter NombreRol column" FilterControlWidth="100px" 
            HeaderText="Nivel de Aprobación" ShowFilterIcon="False" 
            SortExpression="NombreRol" UniqueName="NombreRol">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
    <PagerStyle FirstPageToolTip="Primera Página" LastPageToolTip="Ultima Página" 
        NextPagesToolTip="Páginas Siguientes" NextPageToolTip="Página Siguiente" 
        PagerTextFormat="Change page: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, Registro del &lt;strong&gt;{2}&lt;/strong&gt; al &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
        PageSizeLabelText="Registros por página:" PrevPagesToolTip="Páginas Anteriores" 
        PrevPageToolTip="Página Anterior" />
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
    </telerik:RadGrid>
    </div>
    </fieldset>
</asp:Content>
