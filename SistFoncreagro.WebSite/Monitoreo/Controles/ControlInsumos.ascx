<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlInsumos.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlInsumos" %>
<style type="text/css">
    .style1
    {
        width: 100%;
         font-family: Arial;
    font-size: 8pt;
    }
.Texto
{
   
    font-family: Arial;
    font-size: 8pt;
}
.TextBoxAlignIzquierda
{
	text-align: left;
	text-transform: uppercase;
}
   

   

    </style>

   


<table class="style1">
    <tr>
        <td width="10%">
            Tipo Recurso:</td>
        <td width="70%">
                                                                                                                            <telerik:RadComboBox ID="RadComboBox5" Runat="server" AutoPostBack="True">
                                                                                                                                <Items>
                                                                                                                                    <telerik:RadComboBoxItem runat="server" Text="INSUMOS/PRODUCTOS" Value="P" />
                                                                                                                                    <telerik:RadComboBoxItem runat="server" Text="DINERO" Value="D" />
                                                                                                                                </Items>
                                                                                                                            </telerik:RadComboBox>
                                                                                                                            </td>
        <td width="5%">
            &nbsp;</td>
        <td width="15%">
                                                                                                                            &nbsp;</td>
    </tr>
    <tr>
        <td width="10%">
            Tipo Adquisic.:</td>
        <td width="70%">
                                                                                                                            <telerik:RadComboBox ID="RadComboBox1" Runat="server" AutoPostBack="True">
                                                                                                                                <Items>
                                                                                                                                    <telerik:RadComboBoxItem runat="server" Text="CON ORDEN DE COMPRA" Value="C" 
                                                                                                                                        Selected="True" />
                                                                                                                                    <telerik:RadComboBoxItem runat="server" Text="SIN ORDEN DE COMPRA" Value="S" />
                                                                                                                                </Items>
                                                                                                                            </telerik:RadComboBox>
                                                                                                                            </td>
        <td width="5%">
            &nbsp;</td>
        <td width="15%">
                                                                                                                            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Descripción:</td>
        <td>
                                                                                                                            <telerik:RadComboBox ID="RadComboBox2" Runat="server" AutoPostBack="True" 
                                                                                                                                DataSourceID="SqlProductos" DataTextField="Producto" DataValueField="Codigo" 
                                                                                                                                EnableLoadOnDemand="True" MarkFirstMatch="True" Width="100%">
                                                                                                                                <ExpandAnimation Type="OutElastic"></ExpandAnimation>
                    <ItemTemplate>
                                                <table style="font-size: 7pt; font-family: Arial; width: 100%;">
                                                    <tr>
                                                        <td style="width: 50%">
                                                            <%#DataBinder.Eval(Container.DataItem, "Producto")%>
                                                        </td>
                                                         <td style="width: 10%; text-align: center;">
                                                            <%#DataBinder.Eval(Container.DataItem, "CCosto")%>
                                                        </td>
                                                         <td style="width: 10%; text-align: center;">
                                                            <%#DataBinder.Eval(Container.DataItem, "Unidad")%>
                                                        </td>
                                                        <td style="width: 10%; text-align: right;">
                                                            <%#DataBinder.Eval(Container.DataItem, "CantidadDisponible")%>
                                                        </td>
                                                         <td style="width: 8%; text-align: right;">
                                                            <%#DataBinder.Eval(Container.DataItem, "PrecioUnitario")%>
                                                        </td>
                                                        <td style="width: 12%; text-align: right;">
                                                            <%#DataBinder.Eval(Container.DataItem, "NumeroOrdenCompra")%>
                                                        </td>
                                                    </tr>
                                                </table>
                        
                    </ItemTemplate>
                    <HeaderTemplate>
                                                <table style="font-size: 8pt;  font-family: Arial; width: 100%;">
                                                    <tr>
                                                        <td class="TextoCentro" 
                                                            style="color: #FFFFFF; font-weight: bold; text-align: center; width: 50%;" 
                                                            bgcolor="#000066" >
                                                            Producto</td>
                                                         <td class="TextoCentro" 
                                                            style="color: #FFFFFF; font-weight: bold; text-align: center; width: 10%;" 
                                                            bgcolor="#000066">
                                                            C. Costo</td>
                                                        <td class="TextoCentro" 
                                                            style="text-align: center; color: #FFFFFF; font-weight: bold; width: 10%;" 
                                                            bgcolor="#000066">
                                                            Uni.</td>
                                                         <td class="TextoCentro" 
                                                            style="text-align: center; color: #FFFFFF; font-weight: bold; width: 10%;" 
                                                            bgcolor="#000066">
                                                            Cant. Disp.</td>
                                                        <td class="TextoCentro" 
                                                            style="text-align: center; color: #FFFFFF; font-weight: bold; width: 8%;" 
                                                            bgcolor="#000066">
                                                            Precio</td>
                                                        <td class="TextoCentro" 
                                                            style="text-align: center; color: #FFFFFF; font-weight: bold; width: 12%;" 
                                                            bgcolor="#000066">
                                                            Orden Compra</td>
                                                    </tr>
                                                </table>
                        
                    </HeaderTemplate>
                                                                                                                                    </telerik:RadComboBox>
                                                                                                                            <asp:TextBox ID="TextBox1" runat="server" Width="100%" 
                                                                                                                                CssClass="TextBoxAlignIzquierda" Visible="False"></asp:TextBox>
                                                                                                                            <telerik:RadComboBox ID="RadComboBox6" Runat="server" Visible="False" 
                                                                                                                                Width="500px">
                                                                                                                                <Items>
                                                                                                                                    <telerik:RadComboBoxItem runat="server" Text="PASAJES" Value="PASAJES" />
                                                                                                                                    <telerik:RadComboBoxItem runat="server" Text="PAGO POR ASISTENCIAS" 
                                                                                                                                        Value="PAGO POR ASISTENCIAS" />
                                                                                                                                    <telerik:RadComboBoxItem runat="server" Text="PAGO DE JORNALES INFRAESTRUCTURA" 
                                                                                                                                        Value="PAGO DE JORNALES INFRAESTRUCTURA" />
                                                                                                                                    <telerik:RadComboBoxItem runat="server" 
                                                                                                                                        Text="PAGO DE JORNALES TROCHAS Y CAMINOS" 
                                                                                                                                        Value="PAGO DE JORNALES TROCHAS Y CAMINOS" />
                                                                                                                                    <telerik:RadComboBoxItem runat="server" Text="OTROS" Value="OTROS" />
                                                                                                                                </Items>
                                                                                                                            </telerik:RadComboBox>
                                                                                                                            </td>
        <td class="RadComboBox_rtl">
            Unidad:</td>
        <td>
                                                                                                                            <telerik:RadComboBox ID="RadComboBox3" Runat="server" 
                                                                                                                                DataSourceID="SqlUnidades" DataTextField="Descripcion" 
                                                                                                                                DataValueField="IdUnidadMedida" Enabled="False" Width="100%">
                                                                                                                            </telerik:RadComboBox>
        </td>
    </tr>
    <tr>
        <td>
            C. Costo:</td>
        <td>
            <telerik:RadComboBox ID="RadComboBox4" Runat="server" Width="100%" MarkFirstMatch="True" 
                DataSourceID="SqlDataSource1" DataTextField="CodigoElemGasto" 
                DataValueField="IdCCosto" EnableAjaxSkinRendering="False">
            </telerik:RadComboBox>
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                ControlToValidate="RadComboBox2" Display="Dynamic" 
                                                                                                ErrorMessage="¡Debe ingresar el C. Costo!" Enabled="False"></asp:RequiredFieldValidator>
        </td>
        <td class="RadComboBox_rtl">
            &nbsp;</td>
        <td>
                                                                                                                            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Cantidad:</td>
        <td>
            <telerik:RadNumericTextBox ID="RadNumericTextBox2" Runat="server" Width="70px" 
                Value="1">
                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
            </telerik:RadNumericTextBox>
        </td>
        <td class="RadComboBox_rtl">
            P. Unit.:</td>
        <td>
                                                                                                                            <telerik:RadNumericTextBox ID="RadNumericTextBox1" Runat="server" Width="70px" 
                                                                                                                                Value="0" Enabled="False">
                                                                                                                                <IncrementSettings InterceptArrowKeys="False" InterceptMouseWheel="False" />
                                                                                                                            </telerik:RadNumericTextBox>
        </td>
    </tr>
    <tr>
        <td>
            Beneficiario:</td>
        <td>
                                                                                            <telerik:RadComboBox ID="RadComboBox8" Runat="server" 
                DataTextField="Apellidos" 
                                                                                                
                DataValueField="IdInteresado" 
                EnableLoadOnDemand="True" 
                                                                                                
                EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                AllowCustomText="True" 
                                                                                                
                ShowMoreResultsBox="True" ValidationGroup="Transaccion" 
                Width="100%" 
                                                                                                
                EmptyMessage="Ingrese el Beneficiario..." AutoPostBack="True">
                                                                                            </telerik:RadComboBox>
        </td>
        <td>
                                                                                            <asp:ImageButton ID="ImageButton7" runat="server" 
                ImageAlign="Middle" 
                                                                                                
                ImageUrl="~/img/Agregar.gif" 
                ToolTip="Registrar StakeHolder" 
                                                                                                
                CausesValidation="False" />
                                                                                        </td>
        <td>
                                                                                                                            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Observaciones:</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="100%" 
                CssClass="TextBoxAlignIzquierda"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td>
                                                                                                                            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:ImageButton ID="ImageButton15" runat="server" CommandName="PerformInsert"
    ImageUrl="~/img/Update.gif" ToolTip="Grabar" 
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" 
                style="width: 18px" />
<asp:ImageButton ID="ImageButton16" runat="server" CommandName="Update" ImageUrl="~/img/Update.gif"
    ToolTip="Grabar" 
                
                
                Visible="<%# Not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>" />
<asp:ImageButton ID="ImageButton17" runat="server" CausesValidation="False" CommandName="Cancel"
    ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
             </td>
    </tr>
</table>
<asp:SqlDataSource ID="SqlUnidades" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetAllFromUnidadMedidad" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>
<asp:SqlDataSource ID="SqlProductos" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetProductosAdquiridosXProyecto" 
    SelectCommandType="StoredProcedure" 
    ProviderName="<%$ ConnectionStrings:cnx.ProviderName %>">
    <SelectParameters>
        <asp:QueryStringParameter Name="IdDetalleEje" QueryStringField="IdDetalleEje" 
            Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>

        



                                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                                    SelectMethod="GetINTERESADOByParametro" 
                                                    
        TypeName="SistFoncreagro.BussinesLogic.InteresadosBL" 
    OldValuesParameterFormatString="original_{0}">
                                                    <SelectParameters>
                                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
<asp:HiddenField ID="HiddenField1" runat="server" />
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="GetCCOSTOByIdProyecto1" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:ControlParameter ControlID="HiddenField1" Name="idProyecto" 
            PropertyName="Value" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>


                                                
                                                
        






                                                
                                                
        














                                                



