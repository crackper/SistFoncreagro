<%@ Page Title="Plan Contable" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmPlanContable.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmPlanContable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                                                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                                                    <tr class="Titulos">
                                                        <td class="Titulos">
                                                            plan contable</td>
                                                       
                                                        <td style="text-align: right">
                

        


                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar"  
                                                                CausesValidation="False" 
                                                                PostBackUrl="~/Contabilidad/Formularios/ListaPlanContable.aspx" />
                

        


                                                            </td>
                                                       
                                                    </tr>
                                                </table>
                                                        </td>
        </tr>
        <tr class="Texto">
            <td>
                                                            <table style="width: 60px">
                                                                <tr>
                                                                    <td >
                                                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                                ToolTip="Grabar" BorderColor="Gray" BorderStyle="Solid" 
                                                                BorderWidth="0px" />
                                                                    </td>
                                                                    <td >
                                                                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/img/Nuevo.gif" 
                                                                ToolTip="Nuevo" BorderColor="Gray" BorderStyle="Solid" BorderWidth="0px" 
                                                                CausesValidation="False" />
                                                                    </td>
                                                                </tr>
                                                            </table>
            </td>
        </tr>
        <tr class="Texto">
            <td>
                                                            <asp:Panel ID="Panel1" runat="server">
                                                                <table class="style1" width="100%">
                                                                    <tr>
                                                                        <td>
                                                                            <table class="style1">
                                                                                <tr>
                                                                                    <td width="15%">
                                                                                        Cuenta Contable:</td>
                                                                                    <td style="text-align: left" width="15%">
                                                                                        <asp:TextBox ID="TextBox1" runat="server" Width="100px"></asp:TextBox>
                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                                            ControlToValidate="TextBox1" Display="Dynamic" 
                                                                                            ErrorMessage="¡Debe ingresar el Código!"></asp:RequiredFieldValidator>
                                                                                    </td>
                                                                                    <td width="70%">
                                                                                        <asp:TextBox ID="TextBox2" runat="server" Width="90%"></asp:TextBox>
                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                            ControlToValidate="TextBox2" Display="Dynamic" 
                                                                                            ErrorMessage="¡Debe ingresar el Nombre!"></asp:RequiredFieldValidator>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <table class="style1" width="100%">
                                                                                <tr class="Texto">
                                                                                    <td width="15%">
                                                                                        Tipo de Cuenta:</td>
                                                                                    <td width="85%">
                                                                                        <asp:DropDownList ID="DropDownList1" runat="server" 
                                                                                            DataSourceID="odsTipoCtaContable" DataTextField="Descripcion" 
                                                                                            DataValueField="IdTipoCtaCont" style="font-family: Arial; font-size: 8pt" 
                                                                                            Width="400px">
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr class="Texto">
                                                                                    <td>
                                                                                        Título/Detalle:</td>
                                                                                    <td style="text-align: left">
                                                                                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                                                                            RepeatDirection="Horizontal">
                                                                                            <asp:ListItem Value="T">Titulo</asp:ListItem>
                                                                                            <asp:ListItem Value="D">Detalle</asp:ListItem>
                                                                                        </asp:RadioButtonList>
                                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                                            ControlToValidate="RadioButtonList1" Display="Dynamic" 
                                                                                            ErrorMessage="¡Debe ingresar Titulo/Detalle!"></asp:RequiredFieldValidator>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr class="TextoNegrita">
                                                                                    <td colspan="2">
                                                                                        Estados Financieros</td>
                                                                                </tr>
                                                                                <tr class="Texto">
                                                                                    <td>
                                                                                        Tipo Est. Financiero:</td>
                                                                                    <td>
                                                                                        <asp:DropDownList ID="DropDownList6" runat="server" 
                                                                                            DataSourceID="odsEstadosFinancieros" DataTextField="Descripcion" 
                                                                                            DataValueField="IdEstFinanciero" style="font-family: Arial; font-size: 8pt" 
                                                                                            Width="400px">
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr class="Texto">
                                                                                    <td style="height: 19px">
                                                                                        Cta. Rubro Princ.:</td>
                                                                                    <td style="height: 19px">
                                                                                        <telerik:RadComboBox ID="RadComboBox1" Runat="server" DataTextField="Cuenta" 
                                                                                            DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                                                                            EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                            ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                                                                            ValidationGroup="Linea" Width="100%">
                                                                                        </telerik:RadComboBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr class="Texto">
                                                                                    <td>
                                                                                        Cta. Rubro Opc.:</td>
                                                                                    <td>
                                                                                        <telerik:RadComboBox ID="RadComboBox2" Runat="server" DataTextField="Cuenta" 
                                                                                            DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                                                                            EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                            ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                                                                            ValidationGroup="Linea" Width="100%">
                                                                                        </telerik:RadComboBox>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="TextoNegrita">
                                                                        <td>
                                                                            Exigencia de Datos</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <table width="100%">
                                                                                <tr class="Texto">
                                                                                    <td class="15%">
                                                                                        Tipo Cancelación:</td>
                                                                                    <td width="23%">
                                                                                        <asp:DropDownList ID="DropDownList2" runat="server" 
                                                                                            DataSourceID="odsTipoCancelacion" DataTextField="Descripcion" 
                                                                                            DataValueField="IdTipoCancelacion" style="font-family: Arial; font-size: 8pt">
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                    <td style="text-align: center" width="10%">
                                                                                        Cod. Auxiliar:</td>
                                                                                    <td width="12%">
                                                                                        <asp:DropDownList ID="DropDownList3" runat="server" 
                                                                                            style="font-family: Arial; font-size: 8pt">
                                                                                            <asp:ListItem Value="N">No Requiere</asp:ListItem>
                                                                                            <asp:ListItem Value="S">Si Requiere</asp:ListItem>
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                    <td style="text-align: center" width="8%">
                                                                                        Registro:</td>
                                                                                    <td width="12%">
                                                                                        <asp:DropDownList ID="DropDownList4" runat="server" 
                                                                                            style="font-family: Arial; font-size: 8pt">
                                                                                            <asp:ListItem Value="N">No Requiere</asp:ListItem>
                                                                                            <asp:ListItem Value="S">Si Requiere</asp:ListItem>
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                    <td style="text-align: center" width="8%">
                                                                                        C. Costo:</td>
                                                                                    <td width="12%">
                                                                                        <asp:DropDownList ID="DropDownList5" runat="server" 
                                                                                            style="font-family: Arial; font-size: 8pt">
                                                                                            <asp:ListItem Value="N">No Requiere</asp:ListItem>
                                                                                            <asp:ListItem Value="S">Si Requiere</asp:ListItem>
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr class="Texto">
                                                                                    <td class="15%">
                                                                                        Moneda</td>
                                                                                    <td width="23%">
                                                                                        <asp:DropDownList ID="DropDownList9" runat="server" AppendDataBoundItems="True" 
                                                                                            DataSourceID="SqlMoneda" DataTextField="Nombre" DataValueField="IdMoneda" 
                                                                                            style="font-family: Arial; font-size: 8pt">
                                                                                            <asp:ListItem Selected="True" Value="0">Ninguno</asp:ListItem>
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                    <td style="text-align: center" width="10%">
                                                                                        &nbsp;</td>
                                                                                    <td width="12%">
                                                                                        &nbsp;</td>
                                                                                    <td style="text-align: center" width="8%">
                                                                                        &nbsp;</td>
                                                                                    <td width="12%">
                                                                                        &nbsp;</td>
                                                                                    <td style="text-align: center" width="8%">
                                                                                        &nbsp;</td>
                                                                                    <td width="12%">
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="TextoNegrita">
                                                                        <td>
                                                                            Diferencia de Cambio/Traducción Monetaria</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <table width="100%">
                                                                                <tr class="Texto">
                                                                                    <td width="15%">
                                                                                        Tipo Ajuste:</td>
                                                                                    <td width="32%">
                                                                                        <asp:DropDownList ID="DropDownList7" runat="server" 
                                                                                            DataSourceID="odsTipoAjuste" DataTextField="Descripcion" 
                                                                                            DataValueField="IdTipoAjuste" style="font-family: Arial; font-size: 8pt">
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                    <td width="19%">
                                                                                        Aplicación Tipo Cambio:</td>
                                                                                    <td width="32%">
                                                                                        <asp:DropDownList ID="DropDownList8" runat="server" 
                                                                                            DataSourceID="odsAplicacionTipoCambio" DataTextField="Descripcion" 
                                                                                            DataValueField="IdAplTipoCambio" style="font-family: Arial; font-size: 8pt">
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr class="Texto">
                                                                                    <td>
                                                                                        Cta. Ganancia:</td>
                                                                                    <td colspan="3">
                                                                                        <telerik:RadComboBox ID="RadComboBox3" Runat="server" DataTextField="Cuenta" 
                                                                                            DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                                                                            EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                            ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                                                                            ValidationGroup="Linea" Width="100%">
                                                                                        </telerik:RadComboBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr class="Texto">
                                                                                    <td>
                                                                                        Cta. Pérdida:</td>
                                                                                    <td colspan="3">
                                                                                        <telerik:RadComboBox ID="RadComboBox4" Runat="server" DataTextField="Cuenta" 
                                                                                            DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                                                                            EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                            ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                                                                            ValidationGroup="Linea" Width="100%">
                                                                                        </telerik:RadComboBox>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="TextoNegrita">
                                                                        <td>
                                                                            Asiento de Destino</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <table width="100%">
                                                                                <tr>
                                                                                    <td width="15%">
                                                                                        Genera Destino:</td>
                                                                                    <td width="85%">
                                                                                        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        Cargo:</td>
                                                                                    <td>
                                                                                        <telerik:RadComboBox ID="RadComboBox5" Runat="server" DataTextField="Cuenta" 
                                                                                            DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                                                                            EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                            ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                                                                            ValidationGroup="Linea" Width="100%" Enabled="False">
                                                                                        </telerik:RadComboBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td style="height: 21px">
                                                                                        Abono:</td>
                                                                                    <td style="height: 21px">
                                                                                        <telerik:RadComboBox ID="RadComboBox6" Runat="server" DataTextField="Cuenta" 
                                                                                            DataValueField="IdPlan" EmptyMessage="Ingrese la Cuenta..." 
                                                                                            EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                                                                            ShowDropDownOnTextboxClick="False" ShowMoreResultsBox="True" 
                                                                                            ValidationGroup="Linea" Width="100%" Enabled="False">
                                                                                        </telerik:RadComboBox>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </asp:Panel>
            </td>
        </tr>
        </table>
        <asp:ObjectDataSource ID="odsTipoCtaContable" runat="server" 
                    SelectMethod="GetAllFromTIPOCTACONTABLE" 
                    TypeName="SistFoncreagro.BussinesLogic.TipoCtaContableBL">
                </asp:ObjectDataSource>
    <asp:SqlDataSource ID="SqlMoneda" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetAllFromMONEDA" SelectCommandType="StoredProcedure">
    </asp:SqlDataSource>
    <asp:ObjectDataSource ID="odsEstadosFinancieros" runat="server" 
        SelectMethod="GetAllFromESTADOSFINANCIEROS" 
        TypeName="SistFoncreagro.BussinesLogic.EstadosFinancierosBL">
    </asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsPlanContable1" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



    <asp:ObjectDataSource ID="odsAplicacionTipoCambio" runat="server" 
        SelectMethod="GetAllFromAPLICACIONTIPOCAMBIO" 
        TypeName="SistFoncreagro.BussinesLogic.AplicacionTipoCambioBL">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsTipoAjuste" runat="server" 
        SelectMethod="GetAllFromTIPOAJUSTE" 
        TypeName="SistFoncreagro.BussinesLogic.TipoAjusteBL"></asp:ObjectDataSource>

        

         <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>

    <asp:ObjectDataSource ID="odsTipoCancelacion" runat="server" 
        SelectMethod="GetAllFromTIPOCANCELACION" 
        TypeName="SistFoncreagro.BussinesLogic.TipoCancelacioBL">
    </asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsPlanContable2" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable3" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable4" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable5" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



<asp:ObjectDataSource ID="odsPlanContable6" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        



    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                    <AjaxSettings>
                                                        <telerik:AjaxSetting AjaxControlID="ImageButton3">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="Panel1" 
                                                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                        <telerik:AjaxSetting AjaxControlID="CheckBox1">
                                                            <UpdatedControls>
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox5" />
                                                                <telerik:AjaxUpdatedControl ControlID="RadComboBox6" />
                                                            </UpdatedControls>
                                                        </telerik:AjaxSetting>
                                                    </AjaxSettings>
    </telerik:RadAjaxManager>










                                                
                                                
        



    </asp:Content>
