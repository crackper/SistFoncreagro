<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmRegistroPersonal.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmRegistroPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="tabla4" width ="1000px">
        <tr>
            <td colspan="2">
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td>
                            ficha de personal</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right; width:110px">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td width="20">
                &nbsp;</td>
            <td style="width: 600px">
                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                    <AjaxSettings>
                        <telerik:AjaxSetting AjaxControlID="RCBNacionalidad">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="RCBTipoDI" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="RCBVinculo">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="RCBTipoTrabajador" />
                                <telerik:AjaxUpdatedControl ControlID="RCBTipoContrato" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                    </AjaxSettings>
                </telerik:RadAjaxManager>
            </td>
        </tr>
        <tr>
            <td width="20">
                
                                     
                <br />
                <br />
                
                                     
            </td>
            <td style="width: 800px">
                            <telerik:RadTabStrip ID="RadTabStrip1" runat="server" Height="28px" 
                                Width="100%" SelectedIndex="3"  MultiPageID="RadMultiPage3"
                                 CssClass="tabStrip">
                                <Tabs>
                                    <telerik:RadTab Text="Datos Generales">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Periodo Laboral">
                                    </telerik:RadTab> 
                                    <telerik:RadTab Text="SP - Seguros">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Derecho Habientes" Selected="True">
                                    </telerik:RadTab>

                                </Tabs>
                            </telerik:RadTabStrip>
                            <div style="padding: 11px; border-style: solid; border-width: 1px 1px 0px 1px; width: 97%; height: 110px; white-space: normal; background-color: #FFFFFF;">                                                                               
                                <table width="100%">
                                    <tr>
                                        <td align="left" rowspan="4" width="120">
                            <asp:Image ID="Image2" runat="server" Height="108px" Width="88px" />
                                        </td>
                                        <td>
                                            <asp:Label ID="lblNombre" runat="server" 
                                                style="font-weight: 700; font-size: medium" Width="100%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </div>
                            <div >
                            <telerik:RadMultiPage ID="RadMultiPage3" runat="server" SelectedIndex="3" 
                                Width="100%">
                                <telerik:RadPageView ID="RPVDatosGenerales" runat="server" 
                                    CssClass="pageViewEducation" BorderStyle="Solid" 
                                    BorderWidth="1px" Height="100%">
                                    <table style="width:100%; " cellpadding ="5" >
                                    <tr>
                                    <td colspan="3" 
                                            style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #808080">
                                        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/img/Grabar.gif" 
                                            ToolTip="Clic para grabar" />
                                        <asp:ImageButton ID="ImageButton6" runat="server" CausesValidation="False" 
                                            ImageUrl="~/img/Nuevo.gif" ToolTip="Clic para registrar nuevo" />
                                        <asp:ObjectDataSource ID="ODSTipoDocumento" runat="server" 
                                            SelectMethod="GetTipoDocumentoIdentidadByIdNacionalidad" 
                                            TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoIdentidadBL">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="RCBNacionalidad" Name="idNacionalidad" 
                                                    PropertyName="SelectedValue" Type="Int32" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                                    </td>
                                    </tr>
                                    <tr>
                                            <td style="width: 130px; " align="right">
                                                Nombres:</td>
                                            <td style="width: 185px">
                                                <asp:TextBox ID="txtNombre" runat="server" BorderColor="Silver" 
                                                    BorderWidth="1px" Width="150px"></asp:TextBox>
                                            </td>
                                            <td rowspan="12" width="364" style="vertical-align:top;">
                                                <div>
                                                    
                                                    <table class="tabla4" style="border-style: solid; border-width: 1px">
                                                        <tr>
                                                            <td width="6">
                                                                &nbsp;</td>
                                                            <td width="90">
                                                                <strong>Personales:</strong></td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" width="6">
                                                                &nbsp;</td>
                                                            <td align="right" width="90">
                                                                Teléfono:</td>
                                                            <td>
                                                                <asp:TextBox ID="txtTelPersonal" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="150px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" width="6">
                                                                &nbsp;</td>
                                                            <td align="right" width="90">
                                                                Celular:</td>
                                                            <td>
                                                                <asp:TextBox ID="txtCelPersonal" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="150px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" width="6">
                                                                &nbsp;</td>
                                                            <td align="right" width="90">
                                                                Email:</td>
                                                            <td>
                                                                <telerik:RadTextBox ID="RtxtEmailPersonal" Runat="server" Height="50px" 
                                                                    Skin="Default" TextMode="MultiLine" Width="150px">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="6">
                                                                &nbsp;</td>
                                                            <td width="90">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td width="6">
                                                                &nbsp;</td>
                                                            <td width="90">
                                                                <strong>Coorporativos:</strong></td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" width="6">
                                                                &nbsp;</td>
                                                            <td align="right" width="90">
                                                                Teléfono:</td>
                                                            <td>
                                                                <asp:TextBox ID="txtTelCoorporativo" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="150px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" width="6">
                                                                &nbsp;</td>
                                                            <td align="right" width="90">
                                                                Celular:</td>
                                                            <td>
                                                                <asp:ListBox ID="lbxTelfCoorporativo" runat="server" Width="150px"></asp:ListBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" width="6">
                                                                &nbsp;</td>
                                                            <td align="right" width="90">
                                                                Email:</td>
                                                            <td>
                                                                <telerik:RadTextBox ID="RtxtEmailCoorporativo" Runat="server" Height="50px" 
                                                                    Skin="Default" TextMode="MultiLine" Width="150px">
                                                                </telerik:RadTextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="6">
                                                                &nbsp;</td>
                                                            <td width="90">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                    </table>
                                                    
                                                </div>
                                               <br>                                         
                                                <div>
                                                    <table class="tabla4" style="border-style: solid; border-width: 1px">
                                                        <tr>
                                                            <td style="width: 7px">
                                                                &nbsp;</td>
                                                            <td style="width: 55px">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" style="width: 7px">
                                                                &nbsp;</td>
                                                            <td align="right" style="width: 55px">
                                                                Tipo de Sangre:</td>
                                                            <td>
                                                                <asp:TextBox ID="txtTipoSangre" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="150px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" style="width: 7px">
                                                                &nbsp;</td>
                                                            <td align="right" style="width: 55px">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="left" style="font-weight: 700; width: 7px">
                                                                &nbsp;</td>
                                                            <td align="left" colspan="2" style="font-weight: 700">
                                                                Persona de contacto en caso de emergencia:</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" style="width: 7px">
                                                                &nbsp;</td>
                                                            <td align="right" style="width: 55px">
                                                                Nombre:</td>
                                                            <td>
                                                                <asp:TextBox ID="txtNombreContacto" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="200px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" style="width: 7px">
                                                                &nbsp;</td>
                                                            <td align="right" style="width: 55px">
                                                                Telefono:</td>
                                                            <td>
                                                                <asp:TextBox ID="txtTelContacto" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="200px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right" style="width: 7px">
                                                                &nbsp;</td>
                                                            <td align="right" style="width: 55px">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </div>                                                     

                                            </td>
                                          </tr>
                                        <tr>
                                           <td align="right" style="width: 130px; ">
                                                    Apellido Paterno:</td>
                                           <td style="width: 185px">
                                                    <asp:TextBox ID="txtApelPaterno" runat="server" BorderColor="Silver" 
                                                        BorderWidth="1px" Width="150px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                                <td align="right" style="width: 130px; ">
                                                    Apellido Materno:</td>
                                                <td style="width: 185px">
                                                    <asp:TextBox ID="txtApelMaterno" runat="server" BorderColor="Silver" 
                                                        BorderWidth="1px" Width="150px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        <tr>
                                            <td align="right" style="width: 130px; ">
                                                Nacionalidad:</td>
                                            <td style="width: 185px">
                                                <telerik:RadComboBox ID="RCBNacionalidad" Runat="server" AccessibilityMode="True" 
                                                    AllowCustomText="True" DataSourceID="ODSNacionalidad" 
                                                    DataTextField="Nacionalidad" DataValueField="IdNacionalidad" 
                                                    MarkFirstMatch="True" Skin="Sunset" Width="150px" AutoPostBack="True">
                                                </telerik:RadComboBox>
                                            </td>
                                        </tr>
                                        <tr>
                                                <td class="boton" colspan="2">
                                                    <table cellpadding="0" cellspacing="0" class="tabla4">
                                                        <tr>
                                                            <td width="170">
                                                                <telerik:RadComboBox ID="RCBTipoDI" Runat="server" 
                                                                    DataSourceID="ODSTipoDocumento" Skin="Sunset" Width="168px" 
                                                                    DataTextField="Descripcion" DataValueField="IdTipoDI">
                                                                </telerik:RadComboBox>
                                                            </td>
                                                            <td style="color: #000000" width="20">
                                                                N°:</td>
                                                            <td width="105">
                                                                <asp:TextBox ID="txtNroDI" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="100px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        <tr>
                                                <td align="right" style="width: 130px; " 
                                                    valign="top">
                                                    Direccion:</td>
                                                <td style="width: 185px" valign="top">
                                                    <telerik:RadTextBox ID="RtxtDireccion" Runat="server" Height="50px" Skin="Default" 
                                                        TextMode="MultiLine" Width="150px">
                                                    </telerik:RadTextBox>
                                                </td>
                                            </tr>
                                        <tr>
                                                <td align="right" style="width: 130px; " 
                                                    valign="middle">
                                                    Fecha de Nacimiento:</td>
                                                <td style="width: 185px">
                                                    <asp:TextBox ID="txtFechaNacimiento" runat="server" BorderColor="Silver" 
                                                        BorderWidth="1px" Width="130px"></asp:TextBox>
                                                    <telerik:RadButton ID="RadButton2" runat="server" Skin="Default" Text="..." 
                                                        Width="15px">
                                                    </telerik:RadButton>
                                                </td>
                                            </tr>
                                        <tr>
                                                <td align="right" style="width: 130px; " 
                                                    valign="top">
                                                    Lugar de Nacimiento:</td>
                                                <td style="width: 185px">
                                                    <asp:TextBox ID="txtLugarNacimiento" runat="server" BorderColor="Silver" 
                                                        BorderWidth="1px" Width="150px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        <tr>
                                                <td align="right" style="width: 130px; " 
                                                    valign="top">
                                                    Genero:</td>
                                                <td style="width: 185px">
                                                    <telerik:RadComboBox ID="RCBGenero" Runat="server" Skin="Sunset" 
                                                        Width="150px">
                                                        <Items>
                                                            <telerik:RadComboBoxItem runat="server" Text="FEMENINO" Value="FEMENINO" 
                                                                Owner="RCBGenero" />
                                                            <telerik:RadComboBoxItem runat="server" Text="MASCULINO" Value="MASCULINO" 
                                                                Owner="RCBGenero" />
                                                        </Items>
                                                    </telerik:RadComboBox>
                                                </td>
                                            </tr>
                                        <tr>
                                                <td align="right" style="width: 130px; " 
                                                    valign="top">
                                                    Estado Civil:</td>
                                                <td style="width: 185px">
                                                    <telerik:RadComboBox ID="RCBEstadoCivil" Runat="server" 
                                                        AppendDataBoundItems="True" Skin="Sunset" Width="150px">
                                                        <Items>
                                                            <telerik:RadComboBoxItem runat="server" Text="SOLTERO(A)" Value="SOLTERO(A)" 
                                                                Owner="RCBEstadoCivil" />
                                                            <telerik:RadComboBoxItem runat="server" Text="CASADO(A)" Value="CASADO(A)" 
                                                                Owner="RCBEstadoCivil" />
                                                            <telerik:RadComboBoxItem runat="server" Text="CONVIVIENTE" 
                                                                Value="CONVIVIENTE" Owner="RCBEstadoCivil" />
                                                        </Items>
                                                    </telerik:RadComboBox>
                                                    &nbsp;</td>
                                            </tr>
                                        <tr>
                                                <td align="right" style="width: 130px; " 
                                                    valign="top">
                                                    Lic. Conducir:</td>
                                                <td style="width: 185px">
                                                    <asp:TextBox ID="txtLicConducir" runat="server" Width="150px" 
                                                        BorderColor="Silver" BorderWidth="1px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        <tr>
                                                <td align="right" style="width: 130px; " 
                                                    valign="top">
                                                    Fotocheck:</td>
                                                <td style="width: 185px">
                                                    <asp:TextBox ID="txtFotocheck" runat="server" Width="150px" 
                                                        BorderColor="Silver" BorderWidth="1px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                            <td align="center" valign="top" colspan="3">Vinculo con la Institución:<asp:ObjectDataSource 
                                                    ID="ODSNacionalidad" runat="server" SelectMethod="GetAllFromNacionalidad" 
                                                    TypeName="SistFoncreagro.BussinesLogic.NacionalidadBL">
                                                </asp:ObjectDataSource>
                                                </td>
                                            </tr>
                                        <tr>
                                            <td align="right" valign="top" bgcolor="#F4F4F4" colspan="3">
                                                <table class="tabla4">
                                                    <tr>
                                                        <td style="width: 135px">
                                                            Cargar Fotografia:</td>
                                                        <td align="left" width="300">
                                                            <asp:TextBox ID="txtArchivoFotografia" runat="server" Width="295px"></asp:TextBox>
                                                        </td>
                                                        <td width="140">
                                                            <asp:ImageButton ID="ImageButton2" runat="server" 
                                                                ImageUrl="~/img/imgRRHH/BuscarArchivo.jpg" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 135px">
                                                            Cargar Hoja de Vida:</td>
                                                        <td align="left" width="300">
                                                            <asp:TextBox ID="txtArchivoCV" runat="server" Width="295px"></asp:TextBox>
                                                        </td>
                                                        <td width="140">
                                                            <asp:ImageButton ID="ImageButton3" runat="server" 
                                                                ImageUrl="~/img/imgRRHH/BuscarArchivo.jpg" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </telerik:RadPageView>
                                <telerik:RadPageView ID="RadPageView6" runat="server"  
                                    cssClass= "pageview1" 
                                    Height="100%" BorderWidth="1px">
                                    <table style="width:100%;">
                                        <tr>
                                            <td style="width: 3px">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="width: 3px">
                                                &nbsp;</td>
                                            <td>
                                                <table class="tabla4" style="border-width: 1px; border-style: solid" 
                                                    width="100%">
                                                    <tr>
                                                        <td colspan="2">
                                                            <strong>Periodo Laboral:</strong></td>
                                                        <td width="150">
                                                            &nbsp;</td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 105px" align="right">
                                                            Fecha de Ingreso:</td>
                                                        <td width="120">
                                                            <asp:TextBox ID="txtFechaIngreso" runat="server" BorderColor="Silver" 
                                                                BorderWidth="1px" Width="110px"></asp:TextBox>
                                                        </td>
                                                        <td width="150">
                                                            &nbsp;</td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 105px" align="right">
                                                            Fecha de Cese:</td>
                                                        <td width="120">
                                                            <asp:TextBox ID="txtFechaCese" runat="server" BorderColor="Silver" 
                                                                BorderWidth="1px" Width="110px"></asp:TextBox>
                                                        </td>
                                                        <td width="150">
                                                            &nbsp;</td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 105px" align="right">
                                                            &nbsp;</td>
                                                        <td width="120">
                                                            &nbsp;</td>
                                                        <td width="150">
                                                            &nbsp;</td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 105px" align="right">
                                                            Vinculo:</td>
                                                        <td colspan="2" style="width: 270px" width="120">
                                                            <telerik:RadComboBox ID="RCBVinculo" Runat="server" AllowCustomText="True" 
                                                                Skin="Sunset" Width="250px" DataSourceID="ODSCategoriaRRHH" 
                                                                AutoPostBack="True" DataTextField="Nombre" DataValueField="IdCategoria">
                                                            </telerik:RadComboBox>
                                                            <asp:ObjectDataSource ID="ODSCategoriaRRHH" runat="server" 
                                                                SelectMethod="GetAllFromCategoriaRrhh" 
                                                                TypeName="SistFoncreagro.BussinesLogic.CategoriaRrhhBL">
                                                            </asp:ObjectDataSource>
                                                        </td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td rowspan="3">
                                                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                                                DataSourceID="ODSSitEs" DataTextField="Descripcion" 
                                                                DataValueField="IdSituacionEspecial">
                                                                <asp:ListItem Value="1">Personal De Confianza</asp:ListItem>
                                                            </asp:RadioButtonList>
                                                            <asp:ObjectDataSource ID="ODSSitEs" runat="server" 
                                                                SelectMethod="GetAllSituacionEspecial" 
                                                                TypeName="SistFoncreagro.BussinesLogic.SituacionEspecialBL">
                                                            </asp:ObjectDataSource>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 105px" align="right">
                                                            Tipo Trabajador:</td>
                                                        <td colspan="2" style="width: 270px" width="120">
                                                            <telerik:RadComboBox ID="RCBTipoTrabajador" Runat="server" AllowCustomText="True" 
                                                                Skin="Sunset" Width="250px" DataSourceID="ODSTipoTrabajador" 
                                                                DataTextField="Descripcion" DataValueField="IdTipoTrabajador">
                                                            </telerik:RadComboBox>
                                                            <asp:ObjectDataSource ID="ODSTipoTrabajador" runat="server" 
                                                                SelectMethod="GetTipoTrabajadorByIdCategoriaYDisponibles" 
                                                                TypeName="SistFoncreagro.BussinesLogic.TipoTrabajadorBL">
                                                                <SelectParameters>
                                                                    <asp:ControlParameter ControlID="RCBVinculo" DefaultValue="" Name="idCategoria" 
                                                                        PropertyName="SelectedValue" Type="Int32" />
                                                                    <asp:Parameter DefaultValue="true" Name="disponible" Type="Boolean" />
                                                                </SelectParameters>
                                                            </asp:ObjectDataSource>
                                                        </td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 105px" align="right">
                                                            Nivel Educativo:</td>
                                                        <td colspan="2" style="width: 270px" width="120">
                                                            <telerik:RadComboBox ID="RCBNivelEducativo" Runat="server" AllowCustomText="True" 
                                                                Skin="Sunset" Width="250px" DataSourceID="ODSNivelEducativo" 
                                                                DataTextField="Descripcion" DataValueField="IdNivelEducativo">
                                                            </telerik:RadComboBox>
                                                            <asp:ObjectDataSource ID="ODSNivelEducativo" runat="server" 
                                                                SelectMethod="GetAllFromNivelEducativo" 
                                                                TypeName="SistFoncreagro.BussinesLogic.NivelEducativoBL">
                                                            </asp:ObjectDataSource>
                                                        </td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 3px">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="width: 3px">
                                                &nbsp;</td>
                                            <td>
                                                <table class="tabla4" style="border-style: solid; border-width: 1px">
                                                    <tr>
                                                        <td>
                                                            <strong>Contrato Actual:</strong></td>
                                                        <td width="110">
                                                            &nbsp;</td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td width="120">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td width="105" align="right">
                                                            Nro. Contrato:</td>
                                                        <td width="110">
                                                            <asp:TextBox ID="TextBox10" runat="server" Width="105px"></asp:TextBox>
                                                        </td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td width="120">
                                                            <asp:DropDownList ID="DropDownList3" runat="server" Width="110px">
                                                                <asp:ListItem Value="0">Nuevo</asp:ListItem>
                                                                <asp:ListItem Value="1">Renovación</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td width="105" align="right">
                                                            Modalidad:</td>
                                                        <td colspan="3" style="width: 240px">
                                                            <telerik:RadComboBox ID="RCBTipoContrato" Runat="server" AllowCustomText="True" 
                                                                DataSourceID="ODSTipoOCntrato" DataTextField="Descripcion" 
                                                                DataValueField="IdTipoContrato" Skin="Sunset" Width="238px">
                                                            </telerik:RadComboBox>
                                                            <asp:ObjectDataSource ID="ODSTipoOCntrato" runat="server" 
                                                                SelectMethod="GetTipoContratoByIdCategoria" 
                                                                TypeName="SistFoncreagro.BussinesLogic.TipoContratoBL">
                                                                <SelectParameters>
                                                                    <asp:ControlParameter ControlID="RCBVinculo" Name="idCategoria" 
                                                                        PropertyName="SelectedValue" Type="Int32" />
                                                                </SelectParameters>
                                                            </asp:ObjectDataSource>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td width="105" align="right"> Fecha de Inicio:</td>
                                                        <td width="110"> 
                                                            <asp:TextBox ID="TextBox11" runat="server" Width="105px"></asp:TextBox>
                                                        </td>
                                                        <td width="20"> &nbsp;</td>
                                                        <td width="120">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td width="105">
                                                            &nbsp;</td>
                                                        <td width="100">
                                                            &nbsp;</td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td width="120">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="3" style="width: 225px; font-weight: 700">
                                                            Condiciones Actuales del Contrato</td>
                                                        <td width="120">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td width="105" align="right">
                                                            Fecha de Fín:</td>
                                                        <td width="100">
                                                            <asp:TextBox ID="TextBox12" runat="server" Width="105px"></asp:TextBox>
                                                        </td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td width="120">
                                                            (original/adenda)</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" width="105">
                                                            Grupo Ocupacional:</td>
                                                        <td colspan="3" style="width: 220px">
                                                            <telerik:RadComboBox ID="RadComboBox11" Runat="server" AllowCustomText="True" 
                                                                Skin="Sunset" Width="238px">
                                                            </telerik:RadComboBox>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td width="105">
                                                            &nbsp;</td>
                                                        <td width="100">
                                                            &nbsp;</td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td width="120">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="5">
                                                            <table class="tabla4" style="border-style: solid; border-width: 1px">
                                                                <tr>
                                                                    <td align="right" width="70">
                                                                        Proyecto:</td>
                                                                    <td>
                                                                        <telerik:RadComboBox ID="RadComboBox12" Runat="server" Width="100%">
                                                                        </telerik:RadComboBox>
                                                                    </td>
                                                                    <td align="right" style="width: 80px">
                                                                        Sueldo Bruto:</td>
                                                                    <td width="160">
                                                                        <asp:TextBox ID="TextBox13" runat="server" Width="155px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" width="70">
                                                                        Area:</td>
                                                                    <td>
                                                                        <telerik:RadComboBox ID="RadComboBox13" Runat="server" Width="100%">
                                                                        </telerik:RadComboBox>
                                                                    </td>
                                                                    <td align="right" style="width: 80px">
                                                                        Jornada Laboral:</td>
                                                                    <td width="160">
                                                                        <asp:TextBox ID="TextBox14" runat="server" Height="40px" TextMode="MultiLine" 
                                                                            Width="155px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" width="70">
                                                                        Cargo:</td>
                                                                    <td>
                                                                        <telerik:RadComboBox ID="RadComboBox14" Runat="server" Width="100%">
                                                                        </telerik:RadComboBox>
                                                                    </td>
                                                                    <td align="right" style="width: 80px">
                                                                        Horario:</td>
                                                                    <td width="160">
                                                                        <asp:TextBox ID="TextBox15" runat="server" Height="40px" TextMode="MultiLine" 
                                                                            Width="155px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" width="70">
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                    <td align="right" style="width: 80px">
                                                                        &nbsp;</td>
                                                                    <td width="160">
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td width="105">
                                                            &nbsp;</td>
                                                        <td width="100">
                                                            &nbsp;</td>
                                                        <td width="20">
                                                            &nbsp;</td>
                                                        <td width="120">
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 3px">
                                                &nbsp;</td>
                                            <td>
                                                <table class="tabla4">
                                                    <tr>
                                                        <td style="width: 135px">
                                                            Cargar Contrato:</td>
                                                        <td align="left" width="300">
                                                            <asp:TextBox ID="txtArchivoFotografia0" runat="server" Width="295px"></asp:TextBox>
                                                        </td>
                                                        <td width="140">
                                                            <asp:ImageButton ID="ImageButton7" runat="server" 
                                                                ImageUrl="~/img/imgRRHH/BuscarArchivo.jpg" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 3px">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </telerik:RadPageView>
                                <telerik:RadPageView ID="RadPageView7" runat="server" Height="450px">
                                </telerik:RadPageView>
                                <telerik:RadPageView ID="RadPageView8" runat="server" Height="450px">
                                </telerik:RadPageView>
                            </telerik:RadMultiPage>
                            
                            </div>
                            </td>
        </tr>
        <tr>
            <td width="20">
                &nbsp;</td>
            <td style="width: 800px">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="20">
                &nbsp;</td>
            <td style="width: 800px">
                            <asp:ObjectDataSource ID="ODS1" runat="server" 
                                SelectMethod="GetAllFromPersonal" 
                                TypeName="SistFoncreagro.BussinesLogic.PersonalBL"></asp:ObjectDataSource>
                    
                   </td>
        </tr>
    </table>
</asp:Content>
