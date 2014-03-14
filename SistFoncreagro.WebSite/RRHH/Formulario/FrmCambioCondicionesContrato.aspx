<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmCambioCondicionesContrato.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmCambioCondicionesContrato" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


    </style>

   <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
         function nodeClicking(sender, args) {
            var comboBox = $find("<%= RadComboBox1.ClientID %>");
            var node = args.get_node()
            comboBox.set_text(node.get_text());
            comboBox.set_value(node.get_value());
            comboBox.trackChanges();
            comboBox.get_items().getItem(0).set_text(node.get_text());
            comboBox.get_items().getItem(0).set_value(node.get_value());
            comboBox.commitChanges();
            comboBox.hideDropDown();

        }

        function StopPropagation(e) {
            if (!e) {
                e = window.event;
            }
            e.cancelBubble = true;
        }

        function OnClientDropDownOpenedHandler(sender, eventArgs) {
            var tree = sender.get_items().getItem(0).findControl("RadTreeView1");
            var selectedNode = tree.get_selectedNode();
            if (selectedNode) {
                selectedNode.scrollIntoView();
            }
        }

     </script>

     </telerik:RadCodeBlock>

      <script type="text/javascript">
          function GetRadWindow() {
              var oWindow = null;
              if (window.radWindow) oWindow = window.radWindow;
              else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
              return oWindow;
          }

          function CerrarVentana(indicador) {
              var oWnd = GetRadWindow();
              var oArg = new Object();
              oArg.indicador = indicador;
              oWnd.close(oArg);
          }

      </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="font-family: arial; font-size: 9pt" width="700">
            <tr>
                <td width="10">
                    &nbsp;</td>
                <td>
                    <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
                    </telerik:RadScriptManager>
                </td>
                <td width="10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="10">
                    &nbsp;</td>
                <td style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #C0C0C0">
                    <asp:ImageButton ID="btnCancelar" runat="server" Height="25px" 
                        ImageUrl="~/img/Cancelar.gif" Width="25px" />
                                                        <strong>&nbsp;<asp:ImageButton ID="btnAceptar" runat="server" ImageUrl="~/img/Grabar.gif" />
                    </strong>
                </td>
                <td width="10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td width="10">
                    &nbsp;</td>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                            <table width="100%">
                                <tr>
                                    <td colspan="4" 
                                                            style="width: 320px">
                                        <strong>Condiciones&nbsp; del Contrato Actual:</strong></td>
                                    <td width="200">
                                        <asp:TextBox ID="txtCondicionCambio" runat="server" Height="15px" Width="20px" 
                                                                            Visible="False"></asp:TextBox>
                                        <asp:TextBox ID="txtIdCondicion" 
                                                                runat="server" Height="15px" Width="20px" 
                                                                            Visible="False"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right" width="210">
                                        <asp:CheckBox ID="cbxAdenda" runat="server" 
                                                            Text="Con Adenda" TextAlign="Left" AutoPostBack="True" />
                                    </td>
                                    <td align="right" width="150">
                                        Nro:</td>
                                    <td width="150">
                                        <asp:TextBox ID="txtNroAdemda" runat="server" Width="100%" Enabled="False"></asp:TextBox>
                                    </td>
                                    <td width="110">
                                        &nbsp;</td>
                                    <td width="200">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right" width="210">
                                        &nbsp;</td>
                                    <td align="right" width="150">
                                        &nbsp;</td>
                                    <td width="150">
                                        &nbsp;</td>
                                    <td width="110">
                                        &nbsp;</td>
                                    <td width="200">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right" width="210">
                                        <asp:CheckBox ID="cbxFecha" runat="server" 
                                                            Text="Ampliación de Fecha" TextAlign="Left" 
                                            AutoPostBack="True" />
                                    </td>
                                    <td align="right" width="150">
                                        Fecha de Fin:</td>
                                    <td width="150">
                                        <telerik:RadDatePicker ID="rpFechaFinContrato" Runat="server" Culture="es-PE" 
                                                                            Width="100%" Enabled="False">
                                            <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                                                ViewSelectorText="x">
                                            </Calendar>
                                            <DateInput DateFormat="dd/MMM/yyyy" DisplayDateFormat="dd/MMM/yyyy">
                                            </DateInput>
                                            <DatePopupButton HoverImageUrl="" 
                                                                ImageUrl="" />
                                            <DatePopupButton HoverImageUrl="" 
                                                                ImageUrl="" />
                                        </telerik:RadDatePicker>
                                    </td>
                                    <td width="110">
                                        &nbsp;&nbsp;</td>
                                    <td width="200">
                                        <asp:TextBox ID="txtUltFechaCamCond" runat="server" Width="90%" Visible="False"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right" width="210">
                                        <asp:CheckBox ID="cbxSueldo" runat="server" 
                                                            Text="Aumento de Sueldo" TextAlign="Left" 
                                            AutoPostBack="True" />
                                    </td>
                                    <td align="right" width="150">
                                        Sueldo Bruto:
                                    </td>
                                    <td width="150">
                                        <asp:TextBox ID="txtSueldo" runat="server" 
                                                                Width="100%" Enabled="False"></asp:TextBox>
                                    </td>
                                    <td width="110">
                                        &nbsp;&nbsp;</td>
                                    <td width="200">
                                        (no incluye asignacion familiar)</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right" width="210">
                                        &nbsp;</td>
                                    <td align="right" width="150">
                                        Fecha de Cambio:</td>
                                    <td width="150">
                                        <asp:Label ID="lblFechaCambio" 
                                                            runat="server" Width="120px"></asp:Label>
                                    </td>
                                    <td width="110">
                                        &nbsp;</td>
                                    <td width="200">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
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
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>
                            <table width="100%">
                                <tr>
                                    <td align="right" 
                                                            width="160" valign="top">
                                        &nbsp;</td>
                                    <td align="right" 
                                                            width="150" valign="top">
                                        Area (organigrama):</td>
                                    <td width="300" valign="top">
                                        <telerik:RadComboBox ID="RadComboBox1" runat="server" Width="290px"
                                                                            ShowToggleImage="True" 
                                            Style="vertical-align: middle;" OnClientDropDownOpened="OnClientDropDownOpenedHandler"
                                                                            EmptyMessage="Elige el área" ExpandAnimation-Type="None" 
                                                                            CollapseAnimation-Type="None" 
                                            AutoPostBack="True" Enabled="False">
                                            <Items>
                                                <telerik:RadComboBoxItem Text="" />
                                            </Items>
                                            <ItemTemplate>
                                                <div ID="div1">
                                                    <telerik:RadTreeView ID="RadTreeView1" runat="server" DataFieldID="IdArea" 
                                                                                        DataFieldParentID="Dependencia" DataSourceID="ObjectDataSource1" 
                                                                                        DataTextField="Nombre" 
                                                        DataValueField="IdArea" Height="250px" 
                                                                                        OnClientNodeClicking="nodeClicking"  
                                                                                        Width="100%" 
                                                        onnodeclick="RadTreeView1_NodeClick1">
                                                        <DataBindings>
                                                            <telerik:RadTreeNodeBinding Expanded="true" />
                                                        </DataBindings>
                                                    </telerik:RadTreeView>
                                                </div>
                                            </ItemTemplate>
                                            <ExpandAnimation Type="None" />
                                            <CollapseAnimation Type="None" />
                                        </telerik:RadComboBox>
                                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                                                                            SelectMethod="GetAllFromArea2" 
                                                                TypeName="SistFoncreagro.BussinesLogic.AreaBL">
                                        </asp:ObjectDataSource>
                                    </td>
                                    <td valign="top">
                                        <asp:TextBox ID="txtIdArea" runat="server" 
                                                                Width="40px" Visible="False"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right" width="160" valign="top">
                                        <asp:CheckBox ID="cbxPosicion" runat="server" 
                                                            Text="Cambio de Posición" TextAlign="Left" 
                                            AutoPostBack="True" />
                                    </td>
                                    <td align="right" width="150" valign="top">
                                        Cargo (Posición):</td>
                                    <td width="300" valign="top">
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="ddlPosicion" runat="server" 
                                                                                    DataSourceID="ObjectDataSource2" DataTextField="NomCargo" 
                                                                                    DataValueField="IdPosicion" style="font-family: arial; font-size: 9pt" 
                                                                                    Width="290px" Enabled="False">
                                                </asp:DropDownList>
                                                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                                                                                    SelectMethod="GetPosicionByIdArea2" 
                                                                                    
                                                    TypeName="SistFoncreagro.BussinesLogic.PosicionBL">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="RadComboBox1" Name="IdArea" 
                                                                                            PropertyName="SelectedValue" 
                                                            Type="Int32" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </td>
                                    <td valign="top">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right" width="160" valign="top">
                                        &nbsp;</td>
                                    <td align="right" width="150" valign="top">
                                        &nbsp;&nbsp;</td>
                                    <td width="300" valign="top">
                                        &nbsp;</td>
                                    <td valign="top">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="right" width="180" valign="top" colspan="2" 
                                                        style="width: 330px">
                                        Los cambios aplican a partir de:</td>
                                    <td width="300" valign="top">
                                        <telerik:RadDatePicker ID="rpFechaAplica" Runat="server" Culture="es-PE" 
                                                                            Width="150px">
                                            <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                                                ViewSelectorText="x">
                                            </Calendar>
                                            <DateInput DateFormat="dd/MMM/yyyy" DisplayDateFormat="dd/MMM/yyyy">
                                            </DateInput>
                                            <DatePopupButton HoverImageUrl="" 
                                                                ImageUrl="" />
                                        </telerik:RadDatePicker>
                                    </td>
                                    <td valign="top">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
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
                    &nbsp;</td>
                <td width="10">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
