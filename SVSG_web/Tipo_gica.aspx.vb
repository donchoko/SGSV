Public Class Tipo_gica
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

    Protected Sub btn_diagrama_proceso_Click(sender As Object, e As EventArgs) Handles btn_diagrama_proceso.Click

    End Sub

    Protected Sub btn_politica_sistema_Click(sender As Object, e As EventArgs) Handles btn_politica_sistema.Click

    End Sub

    Protected Sub btn_objetivo_sistema_Click(sender As Object, e As EventArgs) Handles btn_objetivo_sistema.Click

    End Sub
End Class