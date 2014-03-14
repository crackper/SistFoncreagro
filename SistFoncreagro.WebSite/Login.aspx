<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="SistFoncreagro.WebSite.Login1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="Form1" runat="server">
    <div class="page">
        <div class="header">
            <div class="title">
                <h1>
                    SISTEMA FONCREAGRO - SISFON
                </h1>
            </div>
            <div class="loginDisplay">
            </div>
            <div class="clear hideSkiplink" align="right">
            </div>
        </div>
        <div class="main">
            <table class="style1">
                <tr>
                    <td>
                            <h2>
                            Iniciar sesión
                            </h2>
                                <p>
                                    Ingrese nombre de usuario y contraseña.
                              </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Login ID="LoginUsuarioFoncre" runat="server" EnableViewState="false" 
                            RenderOuterTable="false" DestinationPageUrl="~/Default.aspx#">
                            <LayoutTemplate>
                                <span class="failureNotification">
                                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
                                </span>
                                <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" 
                                    CssClass="failureNotification" ValidationGroup="LoginUserValidationGroup" />
                                <div class="accountInfo">
                                    <fieldset class="login">
                                        <legend>Información de cuenta</legend>
                                        <p>
                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre de usuario:</asp:Label>
                                            <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                                ControlToValidate="UserName" CssClass="failureNotification" 
                                                ErrorMessage="El nombre de usuario es obligatorio." 
                                                ToolTip="El nombre de usuario es obligatorio." 
                                                ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                                        </p>
                                        <p>
                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                            <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" 
                                                TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                                ControlToValidate="Password" CssClass="failureNotification" 
                                                ErrorMessage="La contraseña es obligatoria." 
                                                ToolTip="La contraseña es obligatoria." 
                                                ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                                        </p>
                                        <p>
                                            <asp:CheckBox ID="RememberMe" runat="server" />
                                            <asp:Label ID="RememberMeLabel" runat="server" AssociatedControlID="RememberMe" 
                                                CssClass="inline">Mantenerme conectado</asp:Label>
                                        </p>
                                    </fieldset>
                                    <p class="submitButton">
                                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" 
                                            Text="Iniciar sesión" ValidationGroup="LoginUserValidationGroup" />
                                    </p>
                                </div>
                            </LayoutTemplate>
                        </asp:Login>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        



        </div>
        <div class="clear">
            <div style="border-top: #0B488B 2px solid; width: 1001px;">
                <center style="width: 1004px">
                    <span style="margin-top: 10px; font-size: 10pt; font-family: 'Times New Roman'">
                    © Copyright 2011 - Todos los derechos reservados.</span></center>
            </div>
        </div>
    </div>
    <div class="footer">
        
    </div>
    </form>
</body>
</html>
