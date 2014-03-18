<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ProbandoCombo.aspx.vb" Inherits="SistFoncreagro.WebSite.ProbandoCombo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <telerik:RadComboBox ID="RadComboBox1" Runat="server" 
            DataSourceID="ObjectDataSource1" DataTextField="NomCargo" 
            DataValueField="IdCargo">
        </telerik:RadComboBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetAllFromCargo" 
            TypeName="SistFoncreagro.DataAccess.CargoRepository"></asp:ObjectDataSource>
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
            <Windows>
                <telerik:RadWindow runat="server" NavigateUrl="FrmNuevoCargo">
                </telerik:RadWindow>
            </Windows>
        </telerik:RadWindowManager>
        <br />
    
    </div>
    </form>
</body>
</html>
