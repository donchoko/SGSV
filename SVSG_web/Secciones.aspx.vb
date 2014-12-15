Public Class Secciones
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub

    Protected Sub btn_jefatura_Click(sender As Object, e As EventArgs) Handles btn_jefatura.Click
        seleccionarSeccion("Jefatura Departamental")
    End Sub

    Protected Sub btn_gica_Click(sender As Object, e As EventArgs) Handles btn_gica.Click
        seleccionarSeccion("GICA")
    End Sub

    Protected Sub btn_quim_analitica_Click(sender As Object, e As EventArgs) Handles btn_quim_analitica.Click
        seleccionarSeccion("Química analítica")
    End Sub

    Protected Sub btn_bioquim_Click(sender As Object, e As EventArgs) Handles btn_bioquim.Click
        seleccionarSeccion("Bioquímica")
    End Sub

    Protected Sub btn_pericias_Click(sender As Object, e As EventArgs) Handles btn_pericias.Click
        seleccionarSeccion("Pericias físicas")
    End Sub

    Protected Sub btn_ing_forense_Click(sender As Object, e As EventArgs) Handles btn_ing_forense.Click
        seleccionarSeccion("Ingeniería forense")
    End Sub

    Protected Sub btn_doc_dudosos_Click(sender As Object, e As EventArgs) Handles btn_doc_dudosos.Click
        seleccionarSeccion("Documentos dudosos")
    End Sub

    Protected Sub btn_biologia_Click(sender As Object, e As EventArgs) Handles btn_biologia.Click
        seleccionarSeccion("Biología")
    End Sub

    Protected Sub btn_img_sonido_Click(sender As Object, e As EventArgs) Handles btn_img_sonido.Click
        seleccionarSeccion("Imagen y sonido forense")
    End Sub

    Protected Sub btn_toxi_Click(sender As Object, e As EventArgs) Handles btn_toxi.Click
        seleccionarSeccion("Toxicología")
    End Sub

    Private Sub seleccionarSeccion(ByVal seccion As String)
        If (seccion = "GICA") Then
            'Session.Item("ultimo") = "secciones"
            Session.Item("seccion") = seccion
            Response.Redirect("Tipo_gica.aspx")
        Else
            'Session.Item("ultimo") = "secciones"
            Session.Item("seccion") = seccion
            Response.Redirect("Tipo.aspx")
        End If
    End Sub


End Class