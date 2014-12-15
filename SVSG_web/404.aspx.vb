Public Class _404
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Response.Redirect("Secciones.aspx")
    End Sub
End Class