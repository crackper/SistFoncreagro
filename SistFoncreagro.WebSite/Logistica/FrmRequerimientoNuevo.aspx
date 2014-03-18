<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmRequerimientoNuevo.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmRequerimientoNuevo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <fieldset class="jcv">
       <legend class="legendJcv">NUEVO REQUERIMIENTO</legend>
      <table class="tabla5" cellpadding="0" cellspacing="0" style="width: 100%">
          <tr>
              <td align="left" style="width: 15px" class="Texto">
                    &nbsp;</td>
              <td align="left" style="width: 96px" class="Texto">
                    &nbsp;</td>
              <td style="height: 10px; " colspan="2">
                    &nbsp;</td>
          </tr>
          <tr>
              <td align="left" style="width: 15px" class="Texto">
                    &nbsp;</td>
              <td align="left" style="width: 96px; font-weight: bold; height: 25px;" 
                  class="Texto">
                    Tipo Requerimiento :</td>
              <td style="height: 10px; " colspan="2">
                    <asp:DropDownList ID="ddlTipoRequerimiento" runat="server" Width="241px" 
                        AutoPostBack="True">
                        <asp:ListItem Value="PRODUCTO">PRODUCTO</asp:ListItem>
                        <asp:ListItem Value="SERVICIO">SERVICIO</asp:ListItem>
                    </asp:DropDownList>
                </td>
          </tr>
          <tr>
              <td align="left" style="width: 15px" class="Texto">
                    &nbsp;</td>
              <td align="right" style="width: 96px; height: 25px;" class="Texto">
                    Periodo :&nbsp; </td>
              <td style="height: 25px; " colspan="2">
                    <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td style="width: 23px">
                    <asp:CheckBox ID="cbPeriodo" runat="server" Enabled="False" Text=" " AutoPostBack="True" />
                            </td>
                            <td align="left" style="width: 60px">
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                Inicio :
                            </td>
                            <td style="width: 160px" align="center">
                    <telerik:RadDatePicker ID="rdpPeriodoInicio" Runat="server" Enabled="False" 
                        ToolTip="Fecha Inicio" Width="140px">
                        <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                            ViewSelectorText="x">
                        </Calendar>
                        <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy">
                        </DateInput>
                        <DatePopupButton CssClass="rcCalPopup rcDisabled" HoverImageUrl="" 
                            ImageUrl="" />
                    </telerik:RadDatePicker>
                            </td>
                            <td align="right" style="width: 57px">
                                Fin :&nbsp;&nbsp;&nbsp; </td>
                            <td>
                    <telerik:RadDatePicker ID="rdpPeriodoFin" Runat="server" Enabled="False" 
                        ToolTip="Fecha Fin" Width="140px">
                    </telerik:RadDatePicker>
                            </td>
                        </tr>
                    </table>
                </td>
          </tr>
          <tr>
              <td align="left" style="width: 15px" class="Texto">
                    &nbsp;</td>
              <td align="right" style="width: 96px" class="Texto">
                    Ruta :&nbsp; </td>
              <td style="height: 25px; " colspan="2">
                    <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td style="width: 23px">
                                <asp:CheckBox ID="cbRuta" runat="server" Enabled="False" Text=" " 
                                    AutoPostBack="True" />
                            </td>
                            <td align="left" style="width: 71px">
                                &nbsp;&nbsp;
                                Origen :</td>
                            <td>
                    <telerik:RadComboBox ID="rcbOrigen" Runat="server" Width="352px" 
                        DataSourceID="obsRuta" DataTextField="Nombre" 
                        DataValueField="IdRutaRequerimiento" Enabled="False">
                    </telerik:RadComboBox>
                            </td>
                        </tr>
                    </table>
                </td>
          </tr>
          <tr>
              <td align="left" style="width: 15px" class="Texto">
                    &nbsp;</td>
              <td align="right" style="width: 96px" class="Texto">
                    &nbsp;</td>
              <td style="height: 25px; " colspan="2">
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 23px">
                                &nbsp;</td>
                            <td align="left" style="width: 60px">
                                Destino :</td>
                            <td>
                                <telerik:RadComboBox ID="rcbDestino" Runat="server" DataSourceID="obsRuta" 
                                    DataTextField="Nombre" DataValueField="IdRutaRequerimiento" Enabled="False" 
                                    Width="352px">
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                    </table>
                </td>
          </tr>
          <tr>
              <td align="left" style="width: 15px" class="Texto">
                    &nbsp;</td>
              <td align="left" style="width: 96px; font-weight: bold;" class="Texto">
                    Moneda :</td>
              <td style="height: 25px; " colspan="2">
                    <asp:DropDownList ID="ddlMoneda" runat="server" Width="447px" 
                        DataSourceID="odsMoneda" DataTextField="Nombre" DataValueField="IdMoneda">
                        <asp:ListItem Value="1">Soles</asp:ListItem>
                    </asp:DropDownList>
                </td>
          </tr>
          <tr>
              <td align="left" style="width: 15px">
                    &nbsp;</td>
              <td align="left" style="width: 96px; font-weight: bold;" class="Texto">
                    Área/Proyecto :</td>
              <td style="height: 25px; " colspan="2">
                                                                                            <telerik:RadComboBox ID="rcmProyecto" Runat="server" AllowCustomText="True" 
                                                                                                
                        AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                                                                                
                        DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                                                                                
                        EnableVirtualScrolling="True" ItemsPerRequest="10" Width="447px">
                                                                                            </telerik:RadComboBox>
                </td>
          </tr>
          <tr>
              <td align="left" style="width: 15px">
                    &nbsp;</td>
              <td align="left" style="width: 96px; font-weight: bold;" class="Texto">
                    Centro de Costo :</td>
              <td style="width: 600px; height: 23px;">
                    <table border="0" cellspacing="0" cellpadding="0" style="width: 100%">
                        <tr>
                            <td style="width: 451px">
                    <telerik:RadComboBox ID="rcbCentroCosto" Runat="server" 
                        Width="447px" DataTextField="CodigoElementoGasto" 
                        DataValueField="IdCCosto" DataSourceID="odsCentroCosto" AllowCustomText="True" 
                                    EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                    MarkFirstMatch="True">
                    </telerik:RadComboBox>
                            </td>
                            <td>
                    <asp:RequiredFieldValidator ID="rfvSustento0" runat="server" 
                        ControlToValidate="rcbCentroCosto" ErrorMessage="Seleccione centro de costo." 
                        Font-Size="8pt" ValidationGroup="Validar">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </td>
              <td style="width: 10px">
                    &nbsp;</td>
          </tr>
          <tr>
              <td align="left" style="width: 15px">
                    &nbsp;</td>
              <td align="left" style="width: 96px; font-weight: bold;" class="Texto">
                    Sustento :</td>
              <td style="height: 23px;" colspan="2">
                    <asp:TextBox ID="txtSustento" runat="server" Width="441px" 
                        ValidationGroup="Validar"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSustento" runat="server" 
                        ControlToValidate="txtSustento" ErrorMessage="Ingrese sustento." 
                        Font-Size="8pt" ValidationGroup="Validar">*</asp:RequiredFieldValidator>
                </td>
          </tr>
          <tr>
              <td align="left" style="width: 15px">
                    &nbsp;</td>
              <td align="left" style="width: 96px; font-weight: bold;" class="Texto">
                    Observaciones :<br />
                    <br />
                    <br />
                </td>
              <td style="height: 23px;" colspan="2">
                    <asp:TextBox ID="txtObservacion" runat="server" Height="49px" 
                        TextMode="MultiLine" Width="441px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ibGuardar" runat="server" ImageUrl="~/img/Grabar.gif" 
                        ValidationGroup="Validar" />
                </td>
          </tr>
          <tr>
              <td style="width: 15px">
                    &nbsp;</td>
              <td style="width: 96px" class="Texto">
                    &nbsp;</td>
              <td style="height: 10px; " colspan="2">
                    
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ValidationGroup="Validar" Font-Size="8pt" />
              </td>
          </tr>
      </table>
      </fieldset>  
    <br /> 
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="ddlTipoRequerimiento">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="cbPeriodo" />
                    <telerik:AjaxUpdatedControl ControlID="rdpPeriodoInicio" />
                    <telerik:AjaxUpdatedControl ControlID="rdpPeriodoFin" />
                    <telerik:AjaxUpdatedControl ControlID="cbRuta" />
                    <telerik:AjaxUpdatedControl ControlID="rcbOrigen" />
                    <telerik:AjaxUpdatedControl ControlID="rcbDestino" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="cbPeriodo">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rdpPeriodoInicio" />
                    <telerik:AjaxUpdatedControl ControlID="rdpPeriodoFin" />
                    <telerik:AjaxUpdatedControl ControlID="rfvFechaInicio" />
                    <telerik:AjaxUpdatedControl ControlID="rfvFechaFin" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="cbRuta">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rcbOrigen" />
                    <telerik:AjaxUpdatedControl ControlID="rcbDestino" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="rcmProyecto">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rcbCentroCosto" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="ibGuardar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="rfvFechaInicio" />
                    <telerik:AjaxUpdatedControl ControlID="rfvFechaFin" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <asp:ObjectDataSource ID="odsMoneda" runat="server" 
          SelectMethod="GetAllFromMoneda" 
          TypeName="SistFoncreagro.BussinesLogic.MonedaBL">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsProyecto" runat="server" 
    SelectMethod="GetAllFromProyecto" 
    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="obsRuta" runat="server" 
        SelectMethod="GetAllFromRutaRequerimiento" 
        TypeName="SistFoncreagro.BussinesLogic.RutaRequerimientoBL">
    </asp:ObjectDataSource>
      <asp:ObjectDataSource ID="odsCentroCosto" runat="server" 
          SelectMethod="GetCCOSTOByIdProyecto" 
          TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
          <SelectParameters>
              <asp:ControlParameter ControlID="rcmProyecto" Name="_IdProyecto" 
                  PropertyName="SelectedValue" Type="Int32" />
          </SelectParameters>
      </asp:ObjectDataSource>
</asp:Content>

