<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmArea.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmArea" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="jquery-1.6.2.min.js" type="text/javascript"></script> 
<script type="text/javascript">   
//var terms = document.getElementById("terminos");   
function fijarColumna(){   
//alert("hola")
//if(terms.scrollHeight == (terms.scrollTop + terms.clientHeight)){   
//    $("#aceptar_condiciones").removeAttr("disabled");   
//    }   
}
function ColocarMover() {
    caja = document.getElementById("<%=txtOperacion.ClientID %>");
    caja.value = "mover";
}
 </script>

 <%
     Dim ArgAreaODS As New SistFoncreagro.BussinessEntities.ArgumentosArea(True, False, 1000, False, 0)
 %>

 <telerik:radcodeblock id="RadCodeBlock1" runat="server">
        <script type="text/javascript">
      
            function ver(idArea) {
//                alert(idArea);
                }
       
</script> 
            
        
</telerik:radcodeblock>

    <table style="border: 1px solid #000000; width: 100%">
    <tr>
        <td>
            <table class="fondoTabla" 
                    style="border-width: 0px; padding: 0px; margin: 0px; background-color: #0C3B2A; color: #FFFFFF;">
                <tr>
                    <td class="Titulos" align="left">
                        REGISTRO de AREAS</td>
                    <td width="40px">
                            &nbsp;</td>
                    <td style="text-align: right; width:110px" align="right">
                        <asp:ImageButton ID="ImageButton4" runat="server"  ImageUrl="~/img/Cancel.gif" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table style="width: 100%">
                <tr>
                    <td width="245">
                        <asp:TextBox ID="txtIdArea1" runat="server" Height="18px" Width="40px" 
                            Visible="False"></asp:TextBox>
                        <asp:TextBox ID="txtIdArea2" runat="server" Height="18px" Width="40px" 
                            Visible="False"></asp:TextBox>
                    </td>
                    <td width="645" valign="bottom">
                        <asp:Label ID="lblMensaje" runat="server" Font-Size="Small" Visible="False" 
                            Width="100%"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table style="padding: 0px; margin: 0px; width: 100%; border-spacing: 0px;">
                <tr>
                    <td align="center" rowspan="2" 
                        style="border-right-style: solid; border-right-width: 1px;" width="100">
                        <strong>Ordenar Area<strong></td>
                    <td colspan="2" 
                        style="width: 70px; font-size: x-small; " align="center">
                        Cambiar nivel</td>
                    <td width="35" align="center" 
                        style="border-left: 1px solid #C0C0C0; font-size: x-small;">
                        Mover</td>
                    <td rowspan="2" style="border-left-style: solid; border-left-width: 1px;">
                        &nbsp;</td>
                    <td rowspan="2" width="645">
                        <table style="width: 100%">
                            <tr>
                                <td width="247">
                                    <asp:TextBox ID="txtNomArea1" runat="server" Width="245px" Enabled="False" 
                                        Font-Size="Small" BorderColor="#999999" BorderWidth="1px" ReadOnly="True"></asp:TextBox>
                                </td>
                                <td width="87">
                                    <asp:TextBox ID="txtOperacion" runat="server" Width="85px" Enabled="False" 
                                        Font-Size="Small" BorderColor="#999999" BorderWidth="1px" ReadOnly="True"></asp:TextBox>
                                </td>
                                <td width="247">
                                    <asp:TextBox ID="txtNomArea2" runat="server" Width="245px" Enabled="False" 
                                        Font-Size="Small" BorderColor="#999999" BorderWidth="1px" ReadOnly="True"></asp:TextBox>
                                </td>
                                <td width="32">
                                    <asp:ImageButton ID="imgBtnCancelar" runat="server" 
                                        ImageUrl="~/img/Cancel.gif" Visible="False" />
                                </td>
                                <td width="32">
                                    <asp:ImageButton ID="imgBtnCambiar" runat="server" 
                                        ImageUrl="~/img/Update.gif" Visible="False" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" 
                        width="35">
            
            
            <asp:ImageButton ID="imgBtnSubirNivel" runat="server" ImageUrl="~/img/MoveUp.gif" 
                            style="height: 9px" ToolTip="Subir el área seleccionada un nivel" />
                    </td>
                    <td align="center" width="35">
            
            
            <asp:ImageButton ID="imgBtnBajarNivel" runat="server" ImageUrl="~/img/MoveDown.gif" 
                            ToolTip="Bajar el área seleccionada un nivel" />
            &nbsp;
                    </td>
                    <td align="center" width="35" 
                        style="border-left-style: solid; border-left-width: 1px;">
                        <asp:ImageButton ID="imgBtnMover" runat="server" ImageUrl="~/img/drag.gif" 
                            ToolTip="Mover el área seleccionada bajo otra seleccionada" />
                    </td>
                    <td align="center">
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
    
        <td> <div id="scrollGrilla"  onscroll="fijarColumna()" style="overflow: scroll; border-width: 1px; border-style: solid; width: 890px;">           
        <telerik:RadTreeList ID="RadTreeList1" runat="server" OnNeedDataSource="RadTreeList1_NeedDataSource"
        ParentDataKeyNames="Dependencia" DataKeyNames="IdArea" PageSize="5"
        AutoGenerateColumns="False" AllowSorting="True" AllowMultiItemEdit="False" 
                Culture="(Default)" IsItemInserted="False" Skin="Hay">
        <%--ClientSettings Selecting-AllowItemSelection="true">
                <ClientEvents OnItemSelected="countSelectedItems" OnItemDeselected="countSelectedItems"
                    OnTreeListCreated="countSelectedItems" />
        </ClientSettings>--%>
        
       <EditFormSettings EditFormType="AutoGenerated"></EditFormSettings>

        <ValidationSettings CommandsToValidate="PerformInsert,Update"></ValidationSettings>
                <Columns>
                    <telerik:TreeListBoundColumn DataField="Nombre" UniqueName="Nombre" 
                        HeaderText="Category ID" >
                        <HeaderStyle Width="220px" />
                    </telerik:TreeListBoundColumn>
                    <telerik:TreeListBoundColumn DataField="IdArea" UniqueName="IdArea" 
                        HeaderText="Category ID" Visible="False" >
                        <HeaderStyle Width="30px" />
                    </telerik:TreeListBoundColumn>
                    <telerik:TreeListTemplateColumn UniqueName="TemplateColumn2">
                     <ItemTemplate>
                        <asp:ImageButton ID="ImageButton7" runat="server" UniqueName="seleccion"  onclick="ImageButton7_Click" ImageUrl="~/img/Update2.gif" CommandName="Select" CommandArgument='<%# Eval("IdArea") %>'/>
                        <HeaderStyle Width="35px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle Width="35px" HorizontalAlign="Center" />
                    </ItemTemplate>
                        <HeaderStyle Width="35px" />
                        <ItemStyle Width="35px" />
                    </telerik:TreeListTemplateColumn>
                    <telerik:TreeListTemplateColumn UniqueName="TemplateColumn" HeaderStyle-Width="35px" ItemStyle-Width="35px" >
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton5" runat="server" CommandName="Nuevo" CommandArgument='<%# Eval("IdArea") %>' onclick="ImageButton5_Click" ImageUrl="~/img/AddRecord.gif" />
                    </ItemTemplate>
                        <HeaderStyle Width="35px" />
                        <ItemStyle Width="35px" HorizontalAlign="Center" VerticalAlign="Middle"/>
                    </telerik:TreeListTemplateColumn>

                    <telerik:TreeListTemplateColumn UniqueName="TemplateColumn" HeaderStyle-Width="35px" ItemStyle-Width="35px" >
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton10" runat="server" CommandName="Editar" CommandArgument='<%# Eval("Dependencia") & "/" & Eval("IdArea") %>' onclick="ImageButton10_Click" ImageUrl="~/img/Edit.gif" />
                    </ItemTemplate>
                        <HeaderStyle Width="35px" />
                        <ItemStyle Width="35px" HorizontalAlign="Center" VerticalAlign="Middle"/>
                    </telerik:TreeListTemplateColumn>

                    <telerik:TreeListTemplateColumn UniqueName="TemplateColumn1">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/img/Delete.gif" CommandName="Delete" />
                    </ItemTemplate>
                        <HeaderStyle Width="35px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle Width="35px" HorizontalAlign="Center" />
                    </telerik:TreeListTemplateColumn>
                   <%-- <telerik:TreeListTemplateColumn DataField="CodArea" UniqueName="CodArea" 
                        HeaderText="Cod.">
                        <ItemTemplate>
                            <%# Eval("CodArea")%>
                        </ItemTemplate>
                        <HeaderStyle Width="50px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" Width="50px" />
                    </telerik:TreeListTemplateColumn>--%>
                    <telerik:TreeListBoundColumn DataField="TipoArea" UniqueName="TipoArea" 
                        HeaderText="TipoArea">
                        <HeaderStyle Width="60px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Left" Width="60px" />
                    </telerik:TreeListBoundColumn>
                    <telerik:TreeListBoundColumn DataField="PosicionDeJefatura" UniqueName="PosicionDeJefatura" 
                        HeaderText="Jefatura">
                        <HeaderStyle Width="150px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Left" Width="150px" />
                    </telerik:TreeListBoundColumn>
                    <telerik:TreeListBoundColumn DataField="NombreAreaSuperior" UniqueName="NombreAreaSuperior" 
                        HeaderText="Dependencia">
                        <HeaderStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Left" Width="100px" />
                    </telerik:TreeListBoundColumn>
                     <telerik:TreeListBoundColumn DataField="Dependencia" UniqueName="Dependencia" 
                        HeaderText="Parent Category ID" Visible="False" >
                         <ItemStyle HorizontalAlign="Left" />
                    </telerik:TreeListBoundColumn>
                </Columns>

            </telerik:RadTreeList>
            </br>
            </div>
        </td>
    </tr>
    <tr>
    
        <td>  &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server">
            </asp:ObjectDataSource>
            
            
        </td>
    </tr>
    <tr>
        <td style="height: 76px">
                &nbsp;</td>
    </tr>
</table>
</asp:Content>
