Public Class Tipo
    Inherits System.Web.UI.Page

    Private Structure tabla_item
        Property Codigo As String
        Property Nombre As String
        Property Version As String
        Property Fecha As String
    End Structure

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim context As New PublicacionesService.ListadoClient()
        Dim lista_temp As List(Of SVSG_lib.Publicacion) = context.cargarLista("*", "2", "vigente").Lista
        context.Close()
        Dim lista As New List(Of tabla_item)

        For Each p As SVSG_lib.Publicacion In lista_temp
            Dim r As New TableRow()
            Dim i As New tabla_item
            Dim c As New TableCell()
            c.Text = p.cod
            r.Cells.Add(c)
            c = New TableCell()
            c.Text = p.Documento.nombre
            r.Cells.Add(c)
            c = New TableCell()
            c.Text = p.documento_version
            r.Cells.Add(c)
            c = New TableCell()
            c.Text = p.fecha
            r.Cells.Add(c)
            tbl_info.Rows.Add(r)
        Next


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