Public Class SVSG
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("usuario") Is Nothing Then
            Response.Redirect("Index.aspx")
        Else
            usuario_label.Text = "Usuario: " + Session.Item("usuario").ToString()
        End If
    End Sub

    Protected Sub lnk_cerrar_Click(sender As Object, e As EventArgs) Handles lnk_cerrar.Click

    End Sub
End Class