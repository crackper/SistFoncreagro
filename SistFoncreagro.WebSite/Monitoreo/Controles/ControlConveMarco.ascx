<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlConveMarco.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlConveMarco" %>

<table >
    <tr>
        <td >
            Codigo:</td>
        <td>
            <asp:TextBox ID="TxtCodigo" runat="server" MaxLength="4" 
                style="text-transform :uppercase" ToolTip="Máximo 4 caracteres"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TxtCodigo" Display="Dynamic" 
                ErrorMessage="Debe ingresar el código"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td >
            Nombre:</td>
        <td>
            <asp:TextBox ID="TxtNombre" runat="server" TextMode="MultiLine"
              style="text-transform :uppercase" Width="670px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TxtNombre" Display="Dynamic" 
                ErrorMessage="Debe ingresar el nombre"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td >
            Adjunto:</td>
        <td>
            <br />
            <br />
            <asp:ImageButton ID="BtnNuevoAdj" runat="server" ImageUrl="~/img/Nuevo.gif" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                DataSourceID="OdsAdjuntos" EnableModelValidation="True" Width="676px" 
                DataKeyNames="IdAdjMonit">
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                    <asp:BoundField DataField="IdAdjMonit" HeaderText="IdAdjMonit" 
                        SortExpression="IdAdjMonit" Visible="False" />
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" 
                        Visible="False" />
                    <asp:BoundField DataField="Ruta" HeaderText="Archivo" SortExpression="Ruta" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" 
                        SortExpression="Descripcion" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="OdsAdjuntos" runat="server" 
                SelectMethod="GetADJMONITByIdAndTabla" 
                TypeName="SistFoncreagro.BussinesLogic.AdjMonitBL">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TxtIdTabla" Name="_Id" PropertyName="Text" 
                        Type="Int32" />
                    <asp:Parameter DefaultValue="CONVEMARCO" Name="_Tabla" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />
        </td>
    </tr>
    <tr>
        <td >
            </td>
        <td class="style6">
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <table class="style1">
                    <tr>
                        <td>
                            <asp:ImageButton ID="UploadButton" runat="server" ImageUrl="~/img/upload.gif" 
                                ToolTip="Adjuntar Archivo" OnClick="UploadButton_Click" />
                            <asp:ImageButton ID="BtnActualizarAdj" runat="server" 
                                ImageUrl="~/img/Update.gif" Width="25px" ToolTip="Actualizar cambios" />
                            <asp:ImageButton ID="BtnAbrirArchivo" runat="server" 
                                ImageUrl="~/img/OpenFile.gif" ToolTip="Abrir Archivo" />
                            <asp:ImageButton ID="BtnEliminarAdj" runat="server" ImageUrl="~/img/Delete.gif" 
                                Width="25px" />
                            <asp:ImageButton ID="CtnCancelarAdj" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cancelar" Width="25px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:FileUpload ID="FileUploadControl" runat="server" Height="25px" 
                                ToolTip="Adjuntar archivos" Width="446px" />
                            <asp:TextBox ID="TxtDescAdj" runat="server" Height="49px" 
                                style="text-transform :uppercase" TextMode="MultiLine" Width="415px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="StatusLabel" runat="server" text="Upload status: " />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TxtIdAdj" runat="server" Visible="False"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="2" >
        <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type ="text/javascript">
            function CerrarControl(indicador) {
                var oArg = new Object();
                oArg.indicador = indicador;
            }
          </script>
    </telerik:RadCodeBlock>
            <asp:ImageButton ID="CmdGrabar" runat="server" ImageUrl="~/img/Update.gif" 
                ToolTip="Grabar" CommandName = "PerformInsert"
                Visible="<%# (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>"/>
            <asp:ImageButton ID="CmdActualizar" runat="server" ImageUrl="~/img/Update.gif" 
                ToolTip="Actualizar" CommandName = "Update" 
                
                Visible="<%# not (TypeOf DataItem is Telerik.Web.UI.GridInsertionObject) %>"/>
            <asp:ImageButton ID="CmdCancelar" runat="server" ImageUrl="~/img/Cancel.gif" 
                ToolTip="Cancelar" CommandName = "Cancel" CausesValidation="False" 
                />
            <asp:TextBox ID="TxtIdTabla" runat="server" Visible="False"></asp:TextBox>
        </td>
    </tr>
</table>


