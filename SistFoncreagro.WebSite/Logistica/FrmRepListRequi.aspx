<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmRepListRequi.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmRepListRequi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="ListaRequerimientos" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
     <fieldset>
        <legend style="font-family: Arial; font-size: 15px; width: 200px;">Consulta Requerimientos
                </legend>
<div style="height: 500px; overflow: auto; width: 1150px;" class="grid">
    <telerik:RadGrid ID="GridRequi" runat="server" AllowFilteringByColumn="True" 
        AllowPaging="True" AutoGenerateColumns="False" CellSpacing="0" 
        DataSourceID="SqlDataSource1" GridLines="None" Skin="Hay">
        <GroupingSettings CaseSensitive="False" />
<MasterTableView DataKeyNames="idRequerimiento" DataSourceID="SqlDataSource1" 
            NoDetailRecordsText="No se encontro ningún registro hijo para visualizar" 
            NoMasterRecordsText="No se encontro ningún registro" 
            ClientDataKeyNames="idRequerimiento">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Nuevo Registro" ExportToCsvText="Exportar a CSV" 
        ExportToExcelText="Exportar a Excel" ExportToWordText="Exportar a Word" 
        ShowExportToExcelButton="True" RefreshText="Actualizar" 
        ShowRefreshButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter column column" FilterControlWidth="15px" 
            ImageUrl="~\img\Mas.gif" UniqueName="detalle" CommandName="detalle" 
            Text="Ver Detalle">
            <HeaderStyle Width="15px" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn AllowFiltering="False" DataField="IdRequerimiento" 
            DataType="System.Int32" FilterControlAltText="Filter IdRequerimiento column" 
            HeaderText="IdRequerimiento" ReadOnly="True" SortExpression="IdRequerimiento" 
            UniqueName="IdRequerimiento" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroRequerimiento" 
            FilterControlAltText="Filter NroRequerimiento column" 
            FilterControlWidth="70px" HeaderText="Nº Requerimiento" ShowFilterIcon="False" 
            SortExpression="NroRequerimiento" UniqueName="NroRequerimiento" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True">
            <HeaderStyle Width="50px" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaSolicitud" DataType="System.DateTime" 
            FilterControlAltText="Filter FechaSolicitud column" FilterControlWidth="60px" 
            HeaderText="Fecha de Solicitud" ShowFilterIcon="False" 
            SortExpression="FechaSolicitud" UniqueName="FechaSolicitud" 
            DataFormatString="{0:dd/MM/yyyy}" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="60px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaAprobacion" DataType="System.DateTime" 
            FilterControlAltText="Filter FechaAprobacion column" FilterControlWidth="60px" 
            HeaderText="Fecha de Aprobación" ReadOnly="True" ShowFilterIcon="False" 
            SortExpression="FechaAprobacion" UniqueName="FechaAprobacion" 
            DataFormatString="{0:dd/MM/yyyy}" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="60px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" FilterControlWidth="50px" 
            HeaderText="Tipo" ShowFilterIcon="False" SortExpression="Tipo" 
            UniqueName="Tipo" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Area" 
            FilterControlAltText="Filter Area column" FilterControlWidth="30px" 
            HeaderText="Area" ShowFilterIcon="False" SortExpression="Area" 
            UniqueName="Area" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CCosto" 
            FilterControlAltText="Filter CCosto column" FilterControlWidth="50px" 
            HeaderText="CCosto" ShowFilterIcon="False" SortExpression="CCosto" 
            UniqueName="CCosto" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Personal" 
            FilterControlAltText="Filter Personal column" FilterControlWidth="250px" 
            HeaderText="Personal" ReadOnly="True" ShowFilterIcon="False" 
            SortExpression="Personal" UniqueName="Personal" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="250px" />
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Estado" 
            FilterControlAltText="Filter Estado column" FilterControlWidth="50px" 
            HeaderText="Estado" ShowFilterIcon="False" SortExpression="Estado" 
            UniqueName="Estado" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
    <PagerStyle AlwaysVisible="True" FirstPageToolTip="Primera Página" 
        LastPageToolTip="Ultima Página" NextPagesToolTip="Siguientes Páginas" 
        NextPageToolTip="Siguiente Página" PageSizeLabelText="Número de Registros" 
        PrevPagesToolTip="Páginas Anteriores" PrevPageToolTip="Página Anterior" 
        PagerTextFormat="Change page: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, Registros &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." />
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
    </telerik:RadGrid>
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowFilteringByColumn="True" 
        AllowPaging="True" AutoGenerateColumns="False" CellSpacing="0" GridLines="None" 
        Skin="Hay">
    </telerik:RadGrid>
    </div>
    </fieldset>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"  
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Formulario" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" >
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
</asp:Content>
