<%@ Page Title="Seleccionar Proyecto" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmElegirProyecto.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmElegirProyecto" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

       <table align="center" class="tabla6">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;Seleccion de proyecto</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table align="center" class="style1" width="100%" >
                    <tr class="Texto">
                        <td colspan="2">
                            Seleccione el proyecto, luego haga click en el boton &quot;Aceptar&quot;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="font-family: Arial; font-size: 3pt">
                            &nbsp;</td>
                    </tr>
                    <tr class="Texto">
                        <td width="6%">
                            Proyecto:</td>
                        <td style="text-align: left" width="94%">
                                                                                            <telerik:RadComboBox ID="RadComboBox9" Runat="server" 
                                                                                                
                                AutoPostBack="True" DataSourceID="SqlProyectos" DataTextField="Nombre" 
                                                                                                
                                DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                
                                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                                                                                ShowMoreResultsBox="True" 
                                                                                                
                                ValidationGroup="Transaccion" Width="100%" TabIndex="1">
                                                                                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center; font-family: Arial; font-size: 3pt;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
     <asp:SqlDataSource ID="SqlProyectos" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:cnx %>" 
                    SelectCommand="GetPersonalProyecto" 
            SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:SessionParameter Name="idPersonal" SessionField="IdUser" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/Aceptar.gif" 
                ToolTip="Aceptar" AccessKey="s" />


                                                
                                                
        






                                                
                                                
        



                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
