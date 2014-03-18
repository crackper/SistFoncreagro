<%@ Page Title="Progrmacion POA Tecnico" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmProgramacionPoa.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProgramacionPoa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <SCRIPT type = "text/javascript">
     var Total = 0
     //        function dar_formato(num) {
     //           var cadena = ""; var aux;
     //           var cont = 1, m, k;

     //            if (num < 0) aux = 1; else aux = 0;
     //            num = num.toString();
     //            for (m = num.length - 1; m >= 0; m--) {
     //                cadena = num.charAt(m) + cadena;
     //                if (cont % 3 == 0 && m > aux) cadena = "." + cadena; else cadena = cadena;
     //                if (cont == 3) cont = 1; else cont++;
     //         }
     //            cadena = cadena.replace(/.,/, ",");
     //            
     //            return cadena;

     //        }  


     function CalcularTotalPresup1(Dato, Suma) {
         var Dato1 = document.getElementById(Dato);
         var Suma1 = document.getElementById(Suma);

         if (Dato1.value == '') {
             Dato1.value = 0
         }
         if (Suma1.value == '') {
             Suma1.value = 0
         }
         Total = Suma1.value * 1 - Dato1.value * 1;

     }

     function CalcularTotalPresup2(Dato, Suma) {
         var Dato1 = document.getElementById(Dato);
         var Suma1 = document.getElementById(Suma);

         if (Dato1.value == '') {
             Dato1.value = 0
         }
         if (Suma1.value == '') {
             Suma1.value = 0
         }
         Suma1.value = Total * 1 + Dato1.value * 1;
     }

    function format(input) {
        var num = input.value;
    if(!isNaN(num)){
        num = num.toString().split('').reverse().join('').replace(/(?=\d*\,?)(\d{3})/g, '$1,');
        num= num.toString().split(/(?=(?:\d{3})+(?:\.|$))/g).join(",");


        num = num.split('').reverse().join('').replace(/^[\,]/, '');
        input.value = num;
   
    }

    else{ alert('Solo se permiten numeros');
    input.value = input.value.replace(/[^\d\.]*/g,'');
    }
}
function validar(e) {
    tecla = (document.all) ? e.keyCode : e.which;
    if (tecla == 8) return true; //Tecla de retroceso (para poder borrar)
    if (tecla == 9) return true; //Tecla de tab
    if (tecla == 0) return true; //Tecla de tab
    if (tecla == 11) return true; //Tecla de tab
    if (tecla == 44) return true;
    if (tecla == 48) return true;
    if (tecla == 49) return true;
    if (tecla == 50) return true;
    if (tecla == 51) return true;
    if (tecla == 52) return true;
    if (tecla == 53) return true;
    if (tecla == 54) return true;
    if (tecla == 55) return true;
    if (tecla == 56) return true;
    if (tecla == 57) return true;
    patron = /1/; //ver nota
    te = String.fromCharCode(tecla);
        return patron.test(te);
//        alert(tecla);
}


    </SCRIPT> 
    <table style="width: 100%" class="tabla3">
        <tr>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td width="5%">
                            Año:</td>
                        <td width="8%">
                            <asp:TextBox ID="TextBox1" runat="server" Width="50px" AutoPostBack="True"></asp:TextBox>
                        </td>
                        <td width="5%">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Grabar.gif" 
                                ToolTip="Grabar" />
                        </td>
                        <td style="text-align: left">
                            <asp:Button ID="Button1" runat="server" Text="Generar Programación" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td >
                <table style="border-width: 1px; border-style: solid; border-color: #000000; width: 98%; background-color: #59BD06; color: #FFFFFF;" 
                    >
                    <tr>
                        <td style="height: 20px" width="25%">
                            Sub Actividad/Tarea</td>
                        <td style="height: 20px; text-align: center" width="10%">
                            Unidad</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Ene.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Feb.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Mar.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Abr.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            May.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Jun.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Jul.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Ago.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Set.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Oct.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Nov.</td>
                        <td style="height: 20px; text-align: center" width="5%">
                            Dic.</td>
                        <td style="height: 20px; text-align: center; width: 5%;">
                            Total</td>
                    </tr>
                </table>
</td>
        </tr>
        <tr>
            <td>
                <div style="width: 100%; height: 500px; z-index: 1; overflow: auto;"

                class="Marco">

    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" GridLines="None" Skin="Hay" DataSourceID="SqlPoa" CssClass="Grid" 
                        Width="99.5%" EnableEmbeddedBaseStylesheet="False" 
                        EnableEmbeddedScripts="False">
        <AlternatingItemStyle CssClass="GridAlternateRow" />
<MasterTableView NoMasterRecordsText="No existen registros" DataSourceID="SqlPoa" 
            ShowHeader="False">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="IdProgramacion" 
            FilterControlAltText="Filter IdProgramacion column" HeaderText="IdProgramacion" 
            ReadOnly="True" SortExpression="IdProgramacion" 
            UniqueName="IdProgramacion" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NomTarea" 
            FilterControlAltText="Filter NomTarea column" HeaderText="Sub Actividad/Tarea" 
            ReadOnly="True" SortExpression="NomTarea" UniqueName="NomTarea">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" Width="25%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Unidad" 
            FilterControlAltText="Filter Unidad column" HeaderText="Unidad" ReadOnly="True" 
            SortExpression="Unidad" UniqueName="Unidad">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Font-Names="Arial" Font-Size="7pt" Width="10%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="anio" DataType="System.Int32" 
            FilterControlAltText="Filter anio column" HeaderText="Año" 
            SortExpression="anio" UniqueName="anio" Visible="False">
            <ItemStyle Font-Names="Arial" Font-Size="7pt" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            HeaderText="Ene." UniqueName="EneF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox3" runat="server" Text='<%# eval("EneF", "{0:N0}") %>'   
                    Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" 
                    ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            HeaderText="Feb." UniqueName="FebF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox4" runat="server" 
                    Text='<%# eval("FebF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn2 column" 
            HeaderText="Mar." UniqueName="MarF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox5" runat="server" 
                    Text='<%# eval("MarF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn3 column" 
            HeaderText="Abr." UniqueName="AbrF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox6" runat="server" 
                    Text='<%# eval("AbrF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn4 column" 
            HeaderText="May." UniqueName="MayF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox7" runat="server" 
                    Text='<%# eval("MayF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn5 column" 
            HeaderText="Jun." UniqueName="JunF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox8" runat="server" 
                    Text='<%# eval("JunF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn6 column" 
            HeaderText="Jul." UniqueName="JulF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox9" runat="server" 
                    Text='<%# eval("JulF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn7 column" 
            HeaderText="Ago." UniqueName="AgoF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox10" runat="server" 
                    Text='<%# eval("AgoF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn8 column" 
            HeaderText="Set." UniqueName="SepF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox11" runat="server"  
                    Text='<%# eval("SepF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn9 column" 
            HeaderText="Oct." UniqueName="OctF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox12" runat="server"  
                    Text='<%# eval("OctF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn10 column" 
            HeaderText="Nov." UniqueName="NovF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox13" runat="server"  
                    Text='<%# eval("NovF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn11 column" 
            HeaderText="Dic." UniqueName="DicF1">
            <ItemTemplate>
                <asp:TextBox ID="TextBox14" runat="server"  
                    Text='<%# eval("DicF", "{0:N0}") %>' Width="30px" onKeyPress="return validar(event)" Font-Names="Arial" Font-Size="8pt" ></asp:TextBox>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" HeaderText="Tipo" UniqueName="Tipo" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="EneF" 
            FilterControlAltText="Filter EneF column" UniqueName="EneF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FebF" 
            FilterControlAltText="Filter FebF column" UniqueName="FebF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="MarF" 
            FilterControlAltText="Filter MarF column" UniqueName="MarF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="AbrF" 
            FilterControlAltText="Filter AbrF column" UniqueName="AbrF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="MayF" 
            FilterControlAltText="Filter MayF column" UniqueName="MayF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="JunF" 
            FilterControlAltText="Filter JunF column" UniqueName="JunF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="JulF" 
            FilterControlAltText="Filter JulF column" UniqueName="JulF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="AgoF" 
            FilterControlAltText="Filter AgoF column" UniqueName="AgoF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SepF" 
            FilterControlAltText="Filter SepF column" UniqueName="SepF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="OctF" 
            FilterControlAltText="Filter OctF column" UniqueName="OctF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NovF" 
            FilterControlAltText="Filter NovF column" UniqueName="NovF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DicF" 
            FilterControlAltText="Filter DicF column" UniqueName="DicF" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter Total column" 
            HeaderText="Total" UniqueName="Total">
            <ItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Width="30px" 
                    Text='<%# Eval("Total", "{0:N0}") %>' Font-Names="Arial" Font-Size="8pt"></asp:TextBox>
            </ItemTemplate>
            <ItemStyle Width="5%" />
        </telerik:GridTemplateColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
    <ItemStyle CssClass="GridRow" />
    <AlternatingItemStyle CssClass="GridAlternateRow" />
    <HeaderStyle CssClass="GridHeader" />
</MasterTableView>

        <HeaderStyle CssClass="GridHeader" />
        <ItemStyle CssClass="GridRow" />

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
    </telerik:RadGrid>

            </div>
            </td>
        </tr>
        </table>
    <asp:SqlDataSource ID="SqlPoa" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" 
        SelectCommand="GetProgramacionDetallado" 
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="TextBox1" Name="anio" PropertyName="Text" 
                Type="Int32" />
            <asp:SessionParameter Name="IdProyecto" SessionField="IdProyecto" 
                Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
                                            
             

                                            
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
        Height="16px" Skin="Default">
    </telerik:RadAjaxLoadingPanel>
  

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="TextBox1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ImageButton2">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadGrid1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="ImageButton2" />
                    <telerik:AjaxUpdatedControl ControlID="Button1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
   
</asp:Content>
