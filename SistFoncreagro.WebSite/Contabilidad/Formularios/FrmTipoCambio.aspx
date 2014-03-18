<%@ Page Title="Tipo de Cambio" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="FrmTipoCambio.aspx.vb" Inherits="SistFoncreagro.WebSite.RegTipoCambioDet" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td class="Titulos" >
                            Registro de
                            Tipo de Cambio</td>
                        <td  >
                            &nbsp;</td>
                        <td style="text-align: right; width:110px"   >
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                
                    <table align="center" class="tabla4" >
                        <tr>
                            <td>
                                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                ToolTip="Grabar" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Panel ID="Panel1" runat="server" Width="100%">
                                    <table align="center" class="tabla4">
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td colspan="2">
                                                <strong style="font-family: Arial; font-size: 9pt">Tipo Cambio Cierre:</strong></td>
                                        </tr>
                                        <tr class="Texto">
                                            <td valign="top">
                                                Moneda:</td>
                                            <td style="font-family: Arial; font-size: 9pt">
                                                <asp:ComboBox ID="ComboBox1" runat="server" AutoCompleteMode="SuggestAppend" 
                                                DataSourceID="odsMoneda" DataTextField="Nombre" DataValueField="IdMoneda" 
                                                MaxLength="0" style="display: inline; font-family: Arial; font-size: 9pt;" 
                                                Font-Names="Arial" Font-Size="9pt" Width="250px">
                                                </asp:ComboBox>
                                                <asp:ObjectDataSource ID="odsMoneda" runat="server" 
                                                SelectMethod="GetAllFromMoneda" 
                                                TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>
                                            </td>
                                            <td valign="top">
                                                Compra:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox63" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                <asp:MaskedEditExtender ID="TextBox63_MaskedEditExtender" runat="server" 
                                                    Mask="9.9999" MaskType="Number" TargetControlID="TextBox63">
                                                </asp:MaskedEditExtender>
                                            </td>
                                        </tr>
                                        <tr class="Texto">
                                            <td valign="top">
                                                Mes:</td>
                                            <td style="font-family: Arial; font-size: 9pt">
                                                <asp:ComboBox ID="ComboBox2" runat="server" AutoCompleteMode="SuggestAppend" 
                                                Font-Names="Arial" Font-Size="9pt" Width="250px">
                                                    <asp:ListItem Value="1">ENERO</asp:ListItem>
                                                    <asp:ListItem Value="2">FEBRERO</asp:ListItem>
                                                    <asp:ListItem Value="3">MARZO</asp:ListItem>
                                                    <asp:ListItem Value="4">ABRIL</asp:ListItem>
                                                    <asp:ListItem Value="5">MAYO</asp:ListItem>
                                                    <asp:ListItem Value="6">JUNIO</asp:ListItem>
                                                    <asp:ListItem Value="7">JULIO</asp:ListItem>
                                                    <asp:ListItem Value="8">AGOSTO</asp:ListItem>
                                                    <asp:ListItem Value="9">SETIEMBRE</asp:ListItem>
                                                    <asp:ListItem Value="10">OCTUBRE</asp:ListItem>
                                                    <asp:ListItem Value="11">NOVIEMBRE</asp:ListItem>
                                                    <asp:ListItem Value="12">DICIEMBRE</asp:ListItem>
                                                </asp:ComboBox>
                                            </td>
                                            <td valign="top">
                                                Venta:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox64" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                <asp:MaskedEditExtender ID="TextBox64_MaskedEditExtender" runat="server" 
                                                    Mask="9.9999" MaskType="Number" TargetControlID="TextBox64">
                                                </asp:MaskedEditExtender>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                               
                                                
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr class="Texto">
                                            <td colspan="4">
                                                <table align="center" class="tabla4">
                                                    <tr>
                                                        <td>
                                                            Dia</td>
                                                        <td>
                                                            Compra</td>
                                                        <td>
                                                            Venta</td>
                                                        <td>
                                                            Dia</td>
                                                        <td>
                                                            Compra</td>
                                                        <td>
                                                            Venta</td>
                                                        <td>
                                                            Dia</td>
                                                        <td>
                                                            Compra</td>
                                                        <td>
                                                            Venta</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            01</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox1" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox1">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox2" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender0" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox2">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            02</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox3" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender1" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox3">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox4" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender2" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox4">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            03</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox5" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender3" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox5">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox6" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender4" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox6">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            04</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox7" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender5" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox7">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox8" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender6" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox8">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            05</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox9" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender7" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox9">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox10" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender8" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox10">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            06</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox11" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender9" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox11">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox12" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender10" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox12">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            07</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox13" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender11" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox13">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox14" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender12" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox14">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            08</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox15" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender13" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox15">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox16" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender14" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox16">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            09</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox17" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender15" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox17">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox18" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender16" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox18">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            10</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox19" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender17" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox19">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox20" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender18" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox20">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            11</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox21" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender19" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox21">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox22" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender20" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox22">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            12</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox23" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender21" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox23">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox24" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender22" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox24">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            13</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox25" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender23" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox25">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox26" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender24" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox26">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            14</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox27" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender25" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox27">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox28" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender26" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox28">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            15</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox29" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender27" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox29">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox30" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender28" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox30">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            16</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox31" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender29" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox31">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox32" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender30" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox32">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            17</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox33" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender31" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox33">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox34" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender32" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox34">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            18</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox35" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender33" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox35">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox36" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender34" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox36">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            19</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox37" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender35" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox37">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox38" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender36" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox38">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            20</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox39" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender37" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox39">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox40" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender38" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox40">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            21</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox41" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender39" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox41">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox42" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender40" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox42">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            22</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox43" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender41" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox43">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox44" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender42" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox44">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            23</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox45" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender43" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox45">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox46" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender44" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox46">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            24</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox47" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender45" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox47">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox48" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender46" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox48">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            25</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox49" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender47" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox49">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox50" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender48" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox50">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            26</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox51" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender49" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox51">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox52" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender50" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox52">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            27</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox53" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender51" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox53">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox54" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender52" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox54">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            28</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox55" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender53" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox55">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox56" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender54" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox56">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            29</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox57" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender55" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox57">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox58" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender56" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox58">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            30</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox59" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender57" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox59">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox60" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender58" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox60">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            31</td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox61" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender59" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox61">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox62" runat="server" MaxLength="6" Width="50px">0.0000</asp:TextBox>
                                                            <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender60" runat="server" 
                                                                Mask="9.9999" MaskType="Number" TargetControlID="TextBox62">
                                                            </asp:MaskedEditExtender>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                    </table>
               
            </td>
        </tr>
                           
    </table>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
      
                            <telerik:RadAjaxManager ID="RadAjaxManager1" 
        runat="server">
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="ImageButton2">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="Panel1" 
                                                LoadingPanelID="RadAjaxLoadingPanel1" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>
    </telerik:RadAjaxManager>
          
</asp:Content>
