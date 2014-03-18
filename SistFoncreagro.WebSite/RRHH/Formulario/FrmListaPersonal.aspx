<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmListaPersonal.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaPersonal" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<script src="jquery-1.6.2.min.js" type="text/javascript"></script>

<script language="javascript" type="text/javascript">
    $(document).ready(function () {
        //agregar una nueva columna con todo el texto 
        //contenido en las columnas de la grilla 
        // contains de Jquery es CaseSentive, por eso a minúscula 
         
        $(".filtrar tr:has(td.filtro)").each(function () {
            var t = $(this).text().toLowerCase();
            $("<td class='indexColumn'></td>")
                .hide().text(t).appendTo(this);
        });

        //Agregar el comportamiento al texto (se selecciona por el ID) 
        $("#texto").keyup(function () {
            var s = $(this).val().toLowerCase().split(" ");
            $(".filtrar tr:hidden").show();
            $.each(s, function () {
                $(".filtrar tr:visible .indexColumn:not(:contains('"
                     + this + "'))").parent().hide();
            });
        });
    }); 

</script> 


     
   <script type="text/javascript" language="javascript">

       function calcular() {
           var caja1 = document.getElementById("ctl00_ctl00_MainContent_MainContent_TextBox6");
           var caja2 = document.getElementById("ctl00_ctl00_MainContent_MainContent_TextBox7");
           var caja3 = document.getElementById("ctl00_ctl00_MainContent_MainContent_TextBox8");

           caja3.value = caja1.value + caja2.value;
           alert('hola')

       }

       function Mayusculas() {
           obj = document.getElementById("ctl00_ctl00_MainContent_MainContent_rtb1");
           return obj.value = obj.value.toUpperCase

       }

       function resalta(elEvento) {
           var evento = elEvento || window.event;
           switch (evento.type) {
               case 'mouseover':
                   this.style.borderColor = 'black';
                   break;
               case 'mouseout':
                   this.style.borderColor = 'silver';
                   break;
           }
       }

       

       function muestraInformacion(elEvento) {
           var evento = window.event || elEvento;

           var mensaje = "Tipo de evento: " + evento.type + "<br>" +
                "Propiedad keyCode: " + evento.keyCode + "<br>" +
                "Propiedad charCode: " + evento.charCode + "<br>" +
                "Carácter pulsado: " + String.fromCharCode(evento.charCode);

           info.innerHTML += "<br>--------------------------------------<br>" + mensaje
       }

       function tabular(e) {
           tecla = (document.all) ? e.keyCode : e.which;
           if (tecla != 13) return;
           event.keyCode = 9;
          
       } 
       

      
       

</script>  


       <p>
           <table style="width:100%;">
               <tr>
                   <td>
                           <fieldset>
                            <table style="width: 67%;">
                                <tr>
                                    <td style="width: 132px">
                                        Area:</td>
                                    <td style="width: 17px">
                                        &nbsp;</td>
                                    <td>
                                        Proyecto</td>
                                </tr>
                                <tr>
                                    <td style="width: 132px">
                                        <asp:TextBox ID="TextBox2" runat="server"  ></asp:TextBox>
                                    </td>
                                    <td style="width: 17px">
                                        &nbsp;</td>
                                    <td>
                                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 132px">
                                        Cargo:</td>
                                    <td style="width: 17px">
                                        &nbsp;</td>
                                    <td>
                                        DNI:</td>
                                </tr>
                                <tr>
                                    <td style="width: 132px">
                                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                    </td>
                                    <td style="width: 17px">
                                        &nbsp;</td>
                                    <td>
                                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                         </table>
                         </fieldset>
                        </td>
                   <td width="550">
                   <fieldset >
                       <asp:Image ID="Image2" runat="server" Height="106px" Width="86px" />
                   </fieldset >
                       </td>
               </tr>
               <tr>
                   <td valign="top">
                    
                            <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                                CellSpacing="0" GridLines="None" AllowFilteringByColumn="True"
                            AllowSorting="True" PageSize="12" ShowFooter="True" AllowPaging="True" Width="100%" 
                               ShowStatusBar="True"  >
                               <GroupingSettings CaseSensitive="false" />
<MasterTableView EditMode="InPlace" AllowFilteringByColumn="True" ShowFooter="True" TableLayout="Fixed">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                            </telerik:RadGrid>

                            <asp:TextBox ID="TextBox6" runat="server">0</asp:TextBox>
                            <asp:TextBox ID="TextBox7" runat="server">0</asp:TextBox>
                            <asp:TextBox ID="TextBox8" runat="server">0</asp:TextBox>

                            <br />
                            <br />
                            <table class="tabla4">
                                <tr>
                                    <td>
                                        <input id="texto" type="text" /></td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:GridView ID="GridView1" class="filtrar" runat="server" AutoGenerateColumns="False" 
                                            DataSourceID="ODS1" EnableModelValidation="True" AllowPaging="True">
                                            <Columns>
                                                <asp:BoundField ItemStyle-CssClass="filtro" DataField="ApeMaterno" HeaderText="ApeMaterno" 
                                                    SortExpression="ApeMaterno" />
                                                <asp:BoundField ItemStyle-CssClass="filtro" DataField="ApePaterno" HeaderText="ApePaterno" 
                                                    SortExpression="ApePaterno" />
                                                <asp:BoundField DataField="Celular" HeaderText="Celular" 
                                                    SortExpression="Celular" />
                                                <asp:BoundField ItemStyle-CssClass="filtro" DataField="Direccion" HeaderText="Direccion" 
                                                    SortExpression="Direccion" />
                                                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                                <asp:BoundField DataField="EstadoCivil" HeaderText="EstadoCivil" 
                                                    SortExpression="EstadoCivil" />
                                            </Columns>
                                        </asp:GridView>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>

                            </td>
                   <td width="550">
                            <telerik:RadTabStrip ID="RadTabStrip1" runat="server" Height="58px" 
                                Width="100%" Skin="Black" SelectedIndex="0"  MultiPageID="RadMultiPage3"
                                 CssClass="tabStrip" BackColor="#333333">
                                <Tabs>
                                    <telerik:RadTab Text="Datos Generales" Selected="True">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Periodo Laboral">
                                    </telerik:RadTab> 
                                    <telerik:RadTab Text="SP - Seguros">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Derecho Habientes">
                                    </telerik:RadTab>

                                </Tabs>
                            </telerik:RadTabStrip>
                            <telerik:RadMultiPage ID="RadMultiPage3" runat="server" SelectedIndex="0" 
                                CssClass="multiPage" Height="490px" Width="100%" >
                                <telerik:RadPageView ID="RadPageView1" runat="server" CssClass="pageViewEducation">
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </telerik:RadPageView>
                                <telerik:RadPageView ID="RadPageView2" runat="server"  
                                    ContentUrl="~/Logistica/FrmRequerimiento.aspx" cssClass= "pageview1">
                                    <asp:Button ID="Button1" runat="server" Text="Button" style="height: 26px" />
                                </telerik:RadPageView>
                                <telerik:RadPageView ID="RadPageView3" runat="server">
                                </telerik:RadPageView>
                                <telerik:RadPageView ID="RadPageView4" runat="server">
                                </telerik:RadPageView>
                            </telerik:RadMultiPage>
                        </td>
               </tr>
               <tr>
                   <td>
                            <asp:ObjectDataSource ID="ODS1" runat="server" 
                                SelectMethod="GetAllFromPersonal" 
                                TypeName="SistFoncreagro.BussinesLogic.PersonalBL"></asp:ObjectDataSource>
                    
                   </td>
                   <td width="550">
                       &nbsp;</td>
               </tr>
           </table>
           <br />
        <br />
    </p>
    
   

</asp:Content>
