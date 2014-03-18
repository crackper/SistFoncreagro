<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="ProbandoRadWindowNuevoCargo.aspx.vb" Inherits="SistFoncreagro.WebSite.ProbandoRadWindowNuevoCargo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
                    <script type="text/javascript">
                    function NuevoCargo() {
                        var oWnd = radopen("FrmNuevoCargo.aspx", "AsignarCargo");
                        return false;
                    }
                    function CerrarRadWindow(oWnd, args) {
                        var arg = args.get_argument();
                        if (arg) {
                            if (arg.indicador >= 1) {
                                $find("<%= AJAX_MANAGER.ClientID %>").ajaxRequest("ActualizarCombo|" + arg.indicador);
                            }
                        }
                    }
                </script>
     </telerik:RadCodeBlock>

        <telerik:RadAjaxManager ID="AJAX_MANAGER" runat="server">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="AJAX_MANAGER">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="RadComboBox1" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
</telerik:RadAjaxManager>

    <telerik:RadComboBox ID="RadComboBox1" Runat="server" 
        DataSourceID="ObjectDataSource1" DataTextField="NomCargo" 
        DataValueField="IdCargo" DropDownWidth="450px" Width="224px">
    </telerik:RadComboBox>
    <asp:Button ID="Button1" runat="server" Text="..." OnClientClick="return NuevoCargo();" />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetAllFromCargo" TypeName="SistFoncreagro.BussinesLogic.CargoBL">
    </asp:ObjectDataSource>
    <br />
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Skin="Vista">
            <Windows>
                <telerik:RadWindow ID="AsignarCargo" runat="server" Behavior="Close" Behaviors="Close" Height="420px"
                    InitialBehavior="Close" Left="" Modal="True" NavigateUrl="" OnClientClose="CerrarRadWindow"
                    Skin="Vista" Style="display: none;" Top="" VisibleStatusbar="False"
                    Width="450px" InitialBehaviors="Close">
                </telerik:RadWindow>
            </Windows>
        </telerik:RadWindowManager>

        </asp:Content>
