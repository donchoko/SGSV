Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'Se debe agregar una autenticación adecuada en este punto
        If txt_usuario.Text = "admin" And txt_contraseña.Text = "admin" Then
            If check_terms.Checked = True Then

                Session.Add("usuario", txt_usuario.Text)
                Session.Add("ultima_vista", "")
                Session.Add("seccion", "")
                Session.Add("tipo_doc", "")
                Response.Redirect("Secciones.aspx")
            Else
                lbl_warn.Text = "Debe aceptar los terminos y condiciones para poder accesar"
            End If

        Else
            lbl_warn.Text = "Usuario o contraseña incorrectos."
        End If

    End Sub
End Class