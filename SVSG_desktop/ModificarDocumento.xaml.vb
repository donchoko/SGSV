Imports Microsoft.Win32

Public Class ModificarDocumento

    Public manager As SVSG_lib.DocumentoManager
    Private ambitos() As String = {"Gestión", "Técnico", "Equipo"}
    Private tipos() As String = {"Procedimiento", "Instructivo", "Manual", "Especificación", "Registro", "Norma", "Catalogo", "Hoja de calculo", "Listado"}
    Private procedencias() As String = {"Departamento de Ciencias Forenses", "Externo"}
    Private secciones() As String = {"1", "2", "3"}
    Private alcance() As String = {"General", "Especifico"}
    Private sis_gestion() As String = {"Calidad", "Otro"}
    Private vigencias() As String = {"Vigente", "Obsolteo"}

    Public Sub New(ByVal doc As SVSG_lib.Documento, ByVal publi As SVSG_lib.Publicacion)


        ' This call is required by the designer.
        InitializeComponent()
        combo_ambito.ItemsSource = ambitos
        combo_tipo_alcance.ItemsSource = alcance
        combo_seccion.ItemsSource = secciones
        combo_sistema_gestion.ItemsSource = sis_gestion
        combo_tipo_doc.ItemsSource = tipos
        colocarDatos(doc, publi)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub colocarDatos(ByVal doc As SVSG_lib.Documento, ByVal publi As SVSG_lib.Publicacion)
        txt_cod.Text = doc.cod
        txt_version.Text = publi.documento_version
        txt_nombre.Text = doc.nombre
        txt_responsable.Text = publi.publicado_por
        txt_alcance.Text = doc.alcance

        doc.Publicacion.OrderByDescending(Function(p) p.fecha)

        For Each p As SVSG_lib.Publicacion In doc.Publicacion
            txt_historico.Content += Environment.NewLine + p.documento_version + Environment.NewLine + p.fecha + Environment.NewLine + p.detalle + Environment.NewLine
        Next

    End Sub

    Private Function check_campos() As Boolean
        If txt_cod.Text = "" Or txt_nombre.Text = "" Or txt_version.Text = "" Or txt_responsable.Text = "" Or combo_tipo_alcance.Text = "" Or combo_ambito.Text = "" Or combo_sistema_gestion.Text = "" Or combo_tipo_doc.Text = "" Or txt_archivo.Content = "" Or txt_alcance.Text = "" Or txt_detalle.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub btn_mayor_Click(sender As Object, e As RoutedEventArgs) Handles btn_mayor.Click
        If check_campos() Then
            Dim dm As New DocumentoManager
            Dim p As New SVSG_lib.Publicacion
            Dim d As New SVSG_lib.Documento
            d.cod = txt_cod.Text
            d.nombre = txt_nombre.Text
            d.encargado = txt_responsable.Text
            d.creado = Date.Today
            d.alcance = txt_alcance.Text

            p.ambito = combo_ambito.Text
            p.cod = txt_cod.Text
            p.documento_version = txt_version.Text
            p.fecha = Date.Today
            p.procedencia = "interno"
            p.publicado_por = txt_responsable.Text
            p.seccion = combo_seccion.Text
            p.sistema_gestion = combo_sistema_gestion.Text
            p.tipo = combo_tipo_doc.Text
            p.tipo_alcance = combo_tipo_alcance.Text
            p.vigencia = "vigente"
            p.archivo = dm.convertir_Archivo_ArregloBytes(txt_archivo.Content)
            p.Documento = d
            p.detalle = txt_detalle.Text

            dm.publicacionMayor(p)
            Me.Close()
        Else
            MessageBox.Show("ERORR: Se necesita completar todos los campos primero", MessageBoxImage.Warning)
        End If
    End Sub

    Private Sub btn_archivo_Click(sender As Object, e As RoutedEventArgs) Handles btn_archivo.Click
        Try
            Dim extension As String = "Portable Document Format (PDF)|*.PDF"
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = extension
            openFileDialog1.Title = "Seleccionar documento"
            openFileDialog1.ShowDialog()
            txt_archivo.Content = openFileDialog1.FileName
            web_documento.Source = New Uri(txt_archivo.Content, UriKind.Absolute)
            'If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            'End If
        Catch ex As Exception
            MsgBox("Error, " + ex.Message, MsgBoxStyle.Critical, "Adjuntando documento")
        End Try

    End Sub
End Class
