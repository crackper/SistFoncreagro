Public Class FrmListaPersonal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sJscript As String
        'sJscript = String.Format("javascript:return Mayusculas({0},this) ", Me.rtb1.ClientID)

        'Me.TextBox1.Attributes.Add("onkeyup", "javascript:return Mayusculas()")



        'Me.rtb1.Attributes.Add("onkeyup", sJscript)

        'Me.rtb1.Text = Me.rtb1.ClientID

        Me.TextBox7.Text = Me.TextBox7.ClientID

        Me.TextBox6.Attributes.Add("onChange", "calcular('5')")
    End Sub

    Protected Sub RadGrid1_NeedDataSource(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGrid1.NeedDataSource

    End Sub

    Protected Sub RadTabStrip1_TabClick(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadTabStripEventArgs) Handles RadTabStrip1.TabClick

    End Sub


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

    End Sub
End Class