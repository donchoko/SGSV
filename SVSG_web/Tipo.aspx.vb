Public Class Tipo
    Inherits System.Web.UI.Page

    Private Structure tabla_item
        Property Codigo As String
        Property Nombre As String
        Property Version As String
        Property Fecha As String
    End Structure

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session.Item("tipo") = Nothing
        Dim context As New PublicacionesService.ListadoClient()
        Dim lista_temp As List(Of SVSG_lib.Publicacion) = context.cargarLista("*", Session.Item("seccion").ToString(), "vigente").Lista
        context.Close()
        If lista_temp Is Nothing Then
            Response.Redirect("404.aspx")
        Else
            lista_temp.OrderByDescending(Function(p) p.fecha)
            Dim lista As New List(Of tabla_item)


            For value As Integer = 0 To 4
                Dim r As New TableRow()
                Dim i As New tabla_item
                Dim c As New TableCell()
                c.Text = lista_temp.Item(value).cod
                r.Cells.Add(c)
                c = New TableCell()
                c.Text = lista_temp.Item(value).Documento.nombre
                r.Cells.Add(c)
                c = New TableCell()
                c.Text = lista_temp.Item(value).documento_version
                r.Cells.Add(c)
                c = New TableCell()
                c.Text = lista_temp.Item(value).fecha
                r.Cells.Add(c)
                tbl_info.Rows.Add(r)
            Next
        End If


    End Sub

    Protected Sub btn_procedimiento_Click(sender As Object, e As EventArgs) Handles btn_procedimiento.Click
        seleccionarTipo("Procedimiento")
    End Sub

    Protected Sub btn_instructivo_Click(sender As Object, e As EventArgs) Handles btn_instructivo.Click
        seleccionarTipo("Instructivo")
    End Sub

    Protected Sub btn_formato_Click(sender As Object, e As EventArgs) Handles btn_formato.Click
        seleccionarTipo("Formato")
    End Sub

    Protected Sub btn_listado_Click(sender As Object, e As EventArgs) Handles btn_listado.Click
        seleccionarTipo("")
    End Sub

    Protected Sub btn_manual_Click(sender As Object, e As EventArgs) Handles btn_manual.Click
        seleccionarTipo("")
    End Sub

    Protected Sub btn_registro_Click(sender As Object, e As EventArgs) Handles btn_registro.Click
        seleccionarTipo("")
    End Sub

    Protected Sub btn_norma_Click(sender As Object, e As EventArgs) Handles btn_norma.Click
        seleccionarTipo("")
    End Sub

    Protected Sub btn_catalogo_Click(sender As Object, e As EventArgs) Handles btn_catalogo.Click
        seleccionarTipo("")
    End Sub

    Protected Sub btn_especificacion_Click(sender As Object, e As EventArgs) Handles btn_especificacion.Click
        seleccionarTipo("")
    End Sub

    Private Sub seleccionarTipo(ByVal tipo As String)
        'Session.Item("ultimo") = "tipo"
        Session.Item("tipo") = tipo
        Response.Redirect("Listado.aspx")
    End Sub

    
End Class