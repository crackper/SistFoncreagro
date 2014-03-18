﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FormDatosProyecto.aspx.vb" Inherits="SistFoncreagro.WebSite.FormDatosProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    
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
    <div class="span8">
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
                    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                        CellSpacing="0" Culture="es-ES" GridLines="None">
                        <MasterTableView>
                            <CommandItemSettings AddNewRecordText="Asociar Convenio con el Proyecto"/>
                            <Columns>
                                <telerik:GridBoundColumn HeaderText="Convenio"/>
                                <telerik:GridBoundColumn HeaderText="Monto"/>
                            </Columns>
                        </MasterTableView>
                    </telerik:RadGrid>
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

       
</asp:Content>