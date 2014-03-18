<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlManttoClasificacion.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlManttoClasificacion" %>
<style type="text/css">
    .style1
    {
        text-align: left;
    }
    .style2
    {
        text-align: left;
        font-weight: bold;
    }
    .style3
    {
        text-align: left;
        font-weight: 700;
    }
</style>
<table style="width: 850px">
    <tr>
        <td style="font-size: 9pt; " align="center">
            <table class="style1" style="width: 810px">
                <tr>
                    <td align="right" class="style3" colspan="5">
                        DATOS GENERALES</td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style1">
                        Descripción:</td>
                    <td align="left">
         <asp:TextBox ID="txtDescripcion" runat="server" Width="320px" Font-Size="8pt"></asp:TextBox>
                    </td>
                    <td align="left">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtDescripcion" ErrorMessage="Ingrese descripción." 
                            ValidationGroup="grupo">*</asp:RequiredFieldValidator>
                    </td>
                    <td align="left">
                        Código:</td>
                    <td align="left">
         <asp:TextBox ID="txtCodigo" runat="server" Width="100px" Font-Size="8pt"></asp:TextBox>
                    </td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style1">
                        Cta. de Gasto:</td>
                    <td align="left">
                    <telerik:RadComboBox ID="rcbPlan" Runat="server" 
                        Width="320px" DataTextField="Cuenta" 
                        DataValueField="IdPlan" AllowCustomText="True" 
                                    EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                    MarkFirstMatch="True" EmptyMessage="Ingrese la Cuenta..." 
                ShowDropDownOnTextboxClick="False" EnableEmbeddedBaseStylesheet="False" 
                            EnableEmbeddedScripts="False" EnableEmbeddedSkins="False" 
 EnableAjaxSkinRendering="False" DataSourceID="odsPlanContable">
                    </telerik:RadComboBox>
                    </td>
                    <td align="left">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="rcbPlan" ErrorMessage="Seleccione cuenta." 
                            ValidationGroup="grupo">*</asp:RequiredFieldValidator>
                    </td>
                    <td align="left">
                        Cta. de Donación:</td>
                    <td align="left">
                    <telerik:RadComboBox ID="rcbPlanDonacion" Runat="server" 
                        Width="320px" DataTextField="Cuenta" 
                        DataValueField="IdPlan" AllowCustomText="True" 
                                    EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                    MarkFirstMatch="True" EmptyMessage="Ingrese la Cuenta..." 
                            DataSourceID="odsPlanContable4">
                    </telerik:RadComboBox>
                    </td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style2" colspan="5">
                        ACTIVO FIJO</td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style1">
                        Cta. Activo Fijo:</td>
                    <td align="left">
                    <telerik:RadComboBox ID="rcbPlanActivoFijo" Runat="server" 
                        Width="320px" DataTextField="Cuenta" 
                        DataValueField="IdPlan" AllowCustomText="True" 
                                    EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                    MarkFirstMatch="True" EmptyMessage="Ingrese la Cuenta..." 
                            DataSourceID="odsPlanContable1">
                    </telerik:RadComboBox>
                    </td>
                    <td align="left">
                        &nbsp;</td>
                    <td align="left">
                        Cta.
                        Depreciación- Gasto:</td>
                    <td align="left">
                    <telerik:RadComboBox ID="rcbDepreciacionGasto" Runat="server" 
                        Width="320px" DataTextField="Cuenta" 
                        DataValueField="IdPlan" AllowCustomText="True" 
                                    EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                    MarkFirstMatch="True" EmptyMessage="Ingrese la Cuenta..." 
                            DataSourceID="odsPlanContable3">
                    </telerik:RadComboBox>
                    </td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style1">
                        Cta. Depreciación:</td>
                    <td align="left">
                    <telerik:RadComboBox ID="rcbPlanDepreciacion" Runat="server" 
                        Width="320px" DataTextField="Cuenta" 
                        DataValueField="IdPlan" AllowCustomText="True" 
                                    EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                    MarkFirstMatch="True" EmptyMessage="Ingrese la Cuenta..." 
                            DataSourceID="odsPlanContable2">
                    </telerik:RadComboBox>
                    </td>
                    <td align="left">
                        &nbsp;</td>
                    <td align="left">
                        Procentaje Depreciación:</td>
                    <td align="left">
                    <telerik:RadComboBox ID="rcbPorcentaje" Runat="server" 
                        Width="320px" DataTextField="NombreMostrar" 
                        DataValueField="IdPorcDepreciacion" DataSourceID="odsPorcentaje" AllowCustomText="True" 
                                    EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                    MarkFirstMatch="True" EmptyMessage="Porcentaje de Depreciación...">
                    </telerik:RadComboBox>
                    </td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td style="font-size: 9pt; " align="center">
            <asp:ImageButton ID="ImageButton2" runat="server" CommandName="PerformInsert" 
                ImageUrl="~/img/Update.gif" ToolTip="Insertar" ValidationGroup="grupo" />
            <asp:ImageButton ID="ImageButton3" runat="server" CommandName="Update" 
                ImageUrl="~/img/Update.gif" ToolTip="Actualizar" 
                CausesValidation="False" ValidationGroup="grupo" />
            &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                CommandName="Cancel" ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
        </td>
    </tr>
    <tr>
        <td style="font-size: 9pt; " align="center">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                ValidationGroup="grupo" />
        </td>
    </tr>
</table>
<asp:ObjectDataSource ID="odsPorcentaje" runat="server" 
    SelectMethod="GetAllFromPorcDepreciacion" 
    TypeName="SistFoncreagro.BussinesLogic.PorcDepreciacionBL">
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsPlanContable" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        




<asp:ObjectDataSource ID="odsPlanContable1" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL" 
    OldValuesParameterFormatString="original_{0}">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        




<asp:ObjectDataSource ID="odsPlanContable2" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL" 
    OldValuesParameterFormatString="original_{0}">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        




<asp:ObjectDataSource ID="odsPlanContable3" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL" 
    OldValuesParameterFormatString="original_{0}">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        




<asp:ObjectDataSource ID="odsPlanContable4" runat="server" 
    SelectMethod="GetPLANCONTABLEByParameter" 
    TypeName="SistFoncreagro.BussinesLogic.PlanContableBL" 
    OldValuesParameterFormatString="original_{0}">
    <SelectParameters>
        <asp:Parameter DefaultValue="*" Name="Texto" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>










                                                
                                                
        




