Public Class LoginManager


    Public Sub login(ByVal usuario As String, ByVal contraseña As String, ByVal ventana As Login)
        If (usuario <> "" And contraseña <> "") Then
            Dim lista As DocList = New DocList()
            lista.Show()
            ventana.Close()
        End If
    End Sub

End Class
