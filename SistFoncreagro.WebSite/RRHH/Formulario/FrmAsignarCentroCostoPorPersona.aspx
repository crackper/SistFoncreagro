<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmAsignarCentroCostoPorPersona.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmAsignarCentroCostoPorPersona" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .modalBackground
        { background-color: Gray;     
          filter: alpha(opacity=50);     
          opacity: 0.50;  
        }
        .style1
        {
            width: 100%;
        }
        .style2
        {
            font-family: Arial;
            font-size: 9pt;
        }
             
    
     .fondoTabla
{
    width: 100%;
    background-color: #0C3B2A;
    color: #FFFFFF;
    font-weight: bold;
    font-variant: normal;
    width: 100%;
    text-transform: uppercase;
}
    
        .style3
        {
            width: 735px;
        }
    
    </style>

    <script  type ="text/javascript" >
<!--
        function CalcularValor(idValor, montoP, idDist, condicion, IdDisponible) {
            valor = 0;
            dist = 0;
            objValor = document.getElementById(idValor);
            if (idDist != ''){
            objDist = document.getElementById(idDist);
            dist = objDist.value * 1;
            }
            
            objDisp = document.getElementById(IdDisponible);
            obj = document.getElementById("txtValorEstimado")
            valor = objValor.value * 1;
            montoP = montoP * 1;
            
            condicion = condicion * 1;

            alert("" + valor + "  " + montoP + " " + dist + " " + condicion + ""); 

            if (condicion == 0) {
                obj.value = montoP * (valor / 100);
                objDisp.value = montoP - (dist + (obj.value * 1));
            }
            else {
                if (condicion == 1) {
                    obj.value = valor;
                    objDisp.value = montoP - (dist + (obj.value * 1));
                }
                else {
                    if (condicion == 2) {
                        obj.value = montoP - dist;
                        objDisp.value = montoP - dist;
                    }
                }
        }

            return false;
        }


//-->
    </script>

</head>
<body style=" background-color: #FFCC00;">
    <form id="form1" runat="server" 
    style="width: 790px; height: 700px; background-color: #FFFFFF;">
    <div style="width: 780px; font-family: Arial; font-size: 9pt;">
    
        &nbsp;<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                    </asp:ToolkitScriptManager>
                <table bgcolor="White" width="100%">
                    <tr>
                        <td width="10">
                            &nbsp;</td>
                        <td>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <table width="100%">
                                <tr>
                                    <td valign="top">
                                        <asp:Label ID="lblNombre" runat="server" Height="25px" 
                                            style="font-weight: 700; font-size: medium" Width="100%"></asp:Label>
                                        <asp:Label ID="lblArea" runat="server" 
                                            style="font-weight: 700; font-size: medium" Width="100%">
                                </asp:Label>
                                        <asp:Label ID="lblCargo" runat="server" 
                                            style="font-weight: 700; font-size: medium" Width="100%">
                                </asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                        </td>
                        <td width="10">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="10">
                            &nbsp;</td>
                        <td>
                            <table width="100%" style="border: 1px solid #C0C0C0;">
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtAdministracion" runat="server" Width="20px" Visible="False"></asp:TextBox>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td style="font-size: 9pt; font-family: Arial">
                                    <table class="fondoTabla" 
                        style="background-color: #0C3B2A; color: #FFFFFF;">
                                        <tr>
                                            <td style="font-family: Arial; font-size: 9pt">
                    Configuración de la distribución de Remuneración en las Areas Presupuestales.</td>
                                            <td width="40px">
                                                &nbsp;</td>
                                            <td style="text-align: right; width:110px">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td style="font-family: arial; font-size: 9pt">
                                                &nbsp;<table width="265">
                                                    <tr>
                                                        <td width="200">
                                                <asp:ImageButton ID="btnNuevaDistrib" runat="server" 
                                                    ImageUrl="~/img/Nuevo1.gif" />
                                                <asp:ModalPopupExtender ID="btnNuevaDistrib_ModalPopupExtender" runat="server" 
                        BackgroundCssClass="modalBackground" CancelControlID="btnCancelFecha" 
                        DropShadow="True" DynamicServicePath="" Enabled="True" 
                        PopupControlID="Panel6" TargetControlID="btnNuevaDistrib">
                    </asp:ModalPopupExtender>
                &nbsp;Nueva distribución</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td class="style3">
                    <table width="100%">
                        <tr>
                            <td width="500">
                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                    DataKeyNames="IdDistribucionCCP" DataSourceID="odsDCCP" 
                                    style="font-family: Arial; font-size: 9pt" Width="264px">
                                    <Columns>
                                        <asp:TemplateField></asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:ImageButton ID="btnEditarD" runat="server" CommandName="Edit" 
                                                    ImageUrl="~/img/Edit.gif" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:ImageButton ID="btnEliminarD" runat="server" CommandName="Eliminar" 
                                                    ImageUrl="~/img/Delete.gif" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="IdDistribucionCCP" 
                                            SortExpression="IdDistribucionCCP" Visible="False">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtIdDistribucionEdit" runat="server" 
                                                    Text='<%# Bind("IdDistribucionCCP") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblIdDistribucion" runat="server" 
                                                    Text='<%# Bind("IdDistribucionCCP") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="IdPeriodoLaboral" 
                                            SortExpression="IdPeriodoLaboral" Visible="False">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtIdPeriodoLaboralEdit" runat="server" 
                                                    Text='<%# Bind("IdPeriodoLaboral") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblIdPeriodoLaboral" runat="server" 
                                                    Text='<%# Bind("IdPeriodoLaboral") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="FechaIni" SortExpression="FechaIni">
                                            <EditItemTemplate>
                                                <telerik:RadDatePicker ID="rdpFechaD" Runat="server" Width="100px" 
                                                    Culture="es-PE" DbSelectedDate='<%# Bind("FechaIni") %>'>
                                                </telerik:RadDatePicker>
                                                <asp:ImageButton ID="btnActualizarD" runat="server" 
                                                    ImageUrl="~/img/Update.gif" CommandName="Actualizar" />
                                                &nbsp;<asp:ImageButton ID="btnCancelarD" runat="server" ImageUrl="~/img/Cancel.gif" 
                                                    onclick="btnCancelarD_Click" />
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbtnFecha" runat="server" CommandName="Select" 
                                                    Text='<%# Bind("FechaIni") %>'></asp:LinkButton>
                                            </ItemTemplate>
                                            <HeaderStyle Width="200px" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </td>
                            <td width="20">
                                &nbsp;</td>
                            <td valign="top">
                                &nbsp;</td>
                        </tr>
                        </table>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    <asp:ObjectDataSource ID="odsDCCP" runat="server" 
                        SelectMethod="GetDISTRIBUCIONCCPByIdPeriodoLaboral" 
                        TypeName="SistFoncreagro.BussinesLogic.DistribucionCCPBL">
                        <SelectParameters>
                            <asp:SessionParameter Name="IdPeriodoLaboral" SessionField="IdPeriodoLaboral" 
                                Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        Visible="False" Width="740px">
                        <table width="740">
                            <tr>
                                <td colspan="3">
                                    <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                                        <tr>
                                            <td style="font-family: Arial; font-size: 9pt">
                                                REGISTRO DE nueva asignacion de c.costos para el periodo</td>
                                            <td width="40px">
                                                &nbsp;</td>
                                            <td style="text-align: right; width:110px">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td width="140">
                                    <asp:ImageButton ID="btnGrabarCC" runat="server" ImageUrl="~/img/Grabar.gif" 
                                        ToolTip="Clic para grabar" />
                                    &nbsp;<asp:ImageButton ID="btnCancelar" runat="server" Height="27px" 
                                        ImageUrl="~/img/Cancelar.gif" ToolTip="Clic para grabar" Width="30px" />
                                </td>
                                <td width="600">
                                    <asp:TextBox ID="txtRestante" runat="server" Width="30px" Enabled="False" 
                                        Visible="False">-1</asp:TextBox>
                                    <asp:TextBox ID="txtSeleccionado" runat="server" Width="30px" Enabled="False" 
                                        Visible="False"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td width="140" align="right" style="font-family: arial; font-size: 9pt">
                                    Area Presupuestal:</td>
                                <td width="600">
                                    <telerik:RadComboBox ID="rcbPresupuesto" Runat="server" AllowCustomText="True" Filter="Contains" 
                                        Width="600px" AutoPostBack="True">
                                    </telerik:RadComboBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td width="140" align="right" style="font-family: arial; font-size: 9pt">
                                    Centro Costos:</td>
                                <td width="600">
                                    <asp:ObjectDataSource ID="ODSAreaPresupuestal" runat="server">
                                    </asp:ObjectDataSource>
                                    <asp:ObjectDataSource ID="ODSCCostos" runat="server" 
                                        SelectMethod="GetCCOSTOByIdProyecto" 
                                        TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="rcbPresupuesto" DefaultValue="" 
                                                Name="_IdProyecto" PropertyName="SelectedValue" Type="Int32" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>
                                    <telerik:RadComboBox ID="rcbCC" Runat="server" AllowCustomText="True" DataTextField="CodigoElementoGasto" 
                                        DataValueField="IdCCosto" Filter="StartsWith" style="margin-bottom: 0px" 
                                        Width="600px" AutoPostBack="True" DataSourceID="ODSCCostos">
                                    </telerik:RadComboBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2" width="760">
                                    <table width="100%">
                                        <tr>
                                            <td align="right" style="font-family: Arial; font-size: 9pt" width="100">
                                                &nbsp;Distribución por:</td>
                                            <td width="95">
                                                <asp:DropDownList ID="ddlCondicion" runat="server" AutoPostBack="True" 
                                                    Width="100%">
                                                    <asp:ListItem Value="-1">Seleccionar</asp:ListItem>
                                                    <asp:ListItem Value="0">Porcentaje</asp:ListItem>
                                                    <asp:ListItem Value="1">Valor Fijo</asp:ListItem>
                                                    <asp:ListItem Value="2">Valor Restante</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td width="5">
                                                &nbsp;</td>
                                            <td align="right" style="font-family: Arial; font-size: 9pt" width="33">
                                                Valor:</td>
                                            <td width="80">
                                                <asp:TextBox ID="txtValor" runat="server" Width="95%"></asp:TextBox>
                                            </td>
                                            <td align="left" width="30">
                                                <asp:Label ID="lblValor" runat="server" 
                                                    style="font-family: Arial; font-size: 9pt; font-weight: 700" Width="40px"></asp:Label>
                                            </td>
                                            <td width="5">
                                                &nbsp;</td>
                                            <td>
                                                <table align="right" style="border: 1px solid #C0C0C0" width="328">
                                                    <tr>
                                                        <td style="font-family: Arial; font-size: 9pt" width="58">
                                                            Monto S/.</td>
                                                        <td width="90">
                                                            <asp:TextBox ID="txtValorEstimado" runat="server" BorderColor="Silver" 
                                                                BorderStyle="Solid" BorderWidth="1px" Width="100%" Enabled="False"></asp:TextBox>
                                                        </td>
                                                        <td align="right" style="font-family: arial; font-size: 9pt" width="80">
                                                            Nuevo Disp.:</td>
                                                        <td width="100">
                                                            <asp:TextBox ID="txtNuevoDisponible" runat="server" BorderColor="Silver" 
                                                                BorderStyle="Solid" BorderWidth="1px" Enabled="False" Width="90px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td align="right">
                                    <asp:TextBox ID="txtIdDistribucion" runat="server" Width="30px" Enabled="False" 
                                        Visible="False"></asp:TextBox>
                                <asp:LinkButton ID="lbtnNuevoPartir" runat="server" 
                                    style="font-family: Arial; font-size: 9pt">Crear Nueva Distribución a partir de la mostrada</asp:LinkButton>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Panel ID="Panel4" runat="server" Visible="False">
                        <table style="border: 1px solid #C0C0C0" width="100%">
                            <tr>
                                <td>
                                    <table width="100%">
                                        <tr>
                                            <td style="font-size: 9pt; font-family: arial; text-align: right;" width="80">
                                                Rem.Bruta:</td>
                                            <td width="120">
                                                <asp:TextBox ID="txtRemuneracion" runat="server" BorderColor="#CCCCCC" 
                                                    BorderWidth="1px" Width="99%"></asp:TextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                            <td align="right" style="font-size: 9pt; font-family: arial" width="110">
                                                <asp:ImageButton ID="btnAgregar" runat="server" 
                                                    ImageUrl="~/img/AddRecord.gif" />
                                                &nbsp;Agregar CC</td>
                                            <td align="right" style="font-size: 9pt; font-family: arial" width="110">
                                                <asp:ImageButton ID="btnEliminarTodo" runat="server" 
                                                    ImageUrl="~/img/Delete.gif" />
                                                Eliminar todo</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                DataKeyNames="IdCCosto,IdDistribucionCCP" DataSourceID="ODDistribucionCC" 
                                ShowFooter="True" style="font-family: Arial; font-size: 9pt; margin-top: 0px;" 
                                Width="100%">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="btnEditar" runat="server" CommandName="Editar" 
                                                ImageUrl="~/img/Edit.gif" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="30px" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="btnEliminar" runat="server" CommandName="Eliminar" 
                                                ImageUrl="~/img/Delete.gif" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="30px" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="IdDistribucionCCP" 
                                        SortExpression="IdDistribucionCCP" Visible="False">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox4" runat="server" 
                                                Text='<%# Bind("IdDistribucionCC") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("IdDistribucionCCP") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="IdCCosto" SortExpression="IdCCosto" 
                                        Visible="False">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("IdCCosto") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="lblCCosto" runat="server" Text='<%# Bind("IdCCosto") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="CodigoElementoGasto" 
                                        SortExpression="CodigoElementoGasto">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCodigoElemento" runat="server" 
                                                Text='<%# Bind("CodigoElementoGasto") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox7" runat="server" 
                                                Text='<%# Bind("CodigoElementoGasto") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="CondicionMonto" SortExpression="CondicionMonto" 
                                        Visible="False">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("CondicionMonto") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="lblCondicionMonto" runat="server" 
                                                Text='<%# Bind("CondicionMonto") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField SortExpression="NombreCondicion">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("NombreCondicion") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="lblNombreCond" runat="server" 
                                                Text='<%# Bind("NombreCondicion") %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle Width="40px" />
                                        <ItemStyle Width="40px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Valor" SortExpression="Valor">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Valor") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <table width="100%">
                                                <tr>
                                                    <td align="right" class="style2">
                                                        Total Distribuido:</td>
                                                </tr>
                                                <tr>
                                                    <td align="right" class="style2">
                                                        Disponible:</td>
                                                </tr>
                                            </table>
                                        </FooterTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="lblValor" runat="server" Text='<%# Bind("Valor") %>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle Width="100px" />
                                        <ItemStyle Width="100px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Monto">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <table class="style1" width="100">
                                                <tr>
                                                    <td width="100">
                                                        <asp:TextBox ID="txtTotalDistribuido" runat="server" BorderStyle="None" 
                                                            Enabled="False" Width="100%"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td width="100">
                                                        <asp:TextBox ID="TxtDisponible" runat="server" BorderStyle="None" 
                                                            Enabled="False" Width="100%"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                            </table>
                                        </FooterTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="lblMonto" runat="server" Text="Label"></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle Width="100px" />
                                        <ItemStyle Width="100px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="IdProyecto" Visible="False">
                                        <ItemTemplate>
                                            <asp:Label ID="lblIdProyecto" runat="server" Text='<%# Bind("IdProyecto") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <FooterStyle BackColor="#EFEFEF" />
                            </asp:GridView>
                            <asp:ObjectDataSource ID="ODDistribucionCC" runat="server" 
                                SelectMethod="GetDistribucionCCostosPersonalByIdDistribucionCCP" 
                                TypeName="SistFoncreagro.BussinesLogic.DistribucionCCostosPersonalBL">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="txtIdDistribucion" Name="IdDistribucionCCP" 
                                        PropertyName="Text" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td width="15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="15">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td width="15">
                    &nbsp;</td>
            </tr>
        </table>
    
                        </td>
                        <td width="10">
                            &nbsp;</td>
                    </tr>
        </table>
    
    </div>
    <asp:Panel ID="Panel6" runat="server" BackColor="White">
        <table style="border: 1px solid #C0C0C0" width="215">
            <tr>
                <td align="right" 
            style="font-size: 9pt; font-family: arial" width="45">
                    Desde:</td>
                <td width="110">
                    <telerik:RadDatePicker ID="rdpFechaConsulta" Runat="server" Culture="es-PE" 
                                                    Width="105px">
                        <Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" 
                    ViewSelectorText="x">
                        </Calendar>
                        <DateInput DisplayDateFormat="dd/MMM/yyyy" DateFormat="dd/MMM/yyyy">
                        </DateInput>
                        <DatePopupButton ImageUrl="" HoverImageUrl="">
                        </DatePopupButton>
                    </telerik:RadDatePicker>
                </td>
                <td width="25">
                    <asp:ImageButton ID="btnOKFecha" runat="server" ImageUrl="~/img/Update.gif" />
                </td>
                <td width="25">
                    <asp:ImageButton ID="btnCancelFecha" runat="server" 
                        ImageUrl="~/img/Cancel.gif" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    </form>
    </body>
</html>
