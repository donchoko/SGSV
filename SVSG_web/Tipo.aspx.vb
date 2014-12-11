Public Class Tipo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_procedimiento_Click(sender As Object, e As EventArgs) Handles btn_procedimiento.Click

    End Sub

    Protected Sub btn_instructivo_Click(sender As Object, e As EventArgs) Handles btn_instructivo.Click

    End Sub

    Protected Sub btn_formato_Click(sender As Object, e As EventArgs) Handles btn_formato.Click

    End Sub

    Protected Sub btn_listado_Click(sender As Object, e As EventArgs) Handles btn_listado.Click

    End Sub

    Protected Sub btn_manual_Click(sender As Object, e As EventArgs) Handles btn_manual.Click

    End Sub

    Protected Sub btn_registro_Click(sender As Object, e As EventArgs) Handles btn_registro.Click

    End Sub

    Protected Sub btn_norma_Click(sender As Object, e As EventArgs) Handles btn_norma.Click

    End Sub

    Protected Sub btn_catalogo_Click(sender As Object, e As EventArgs) Handles btn_catalogo.Click

    End Sub

    Protected Sub btn_investigacion_Click(sender As Object, e As EventArgs) Handles btn_investigacion.Click

    End Sub

    Private Sub seleccionarTipo(ByVal tipo As String)
        Session.Item("ultimo") = "tipo"
        Session.Item("tipo") = tipo
        Response.Redirect("Listado.aspx")
    End Sub
End Class