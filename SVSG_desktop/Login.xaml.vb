Class Login

    Private Sub btnLogin_Click(sender As Object, e As RoutedEventArgs) Handles btnLogin.Click
        Dim lm As LoginManager = New LoginManager()
        lm.login(txtUsuario.Text, txtContraseña.Password, Me)
    End Sub
End Class
