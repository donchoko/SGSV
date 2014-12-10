Public Class DocList

    Private manager As ListadoManager
    Private ambitos() As String = {"Gestión", "Técnico", "Equipo"}
    Private tipos() As String = {"*", "Procedimiento", "Instructivo", "Manual", "Especificación", "Registro", "Norma", "Catalogo", "Hoja de calculo", "Listado"}
    Private procedencias() As String = {"Departamento de Ciencias Forenses", "Externo"}
    Private secciones() As String = {"*", "1", "2", "3"}
    Private alcance() As String = {"General", "Especifico"}
    Private sis_gestion() As String = {"Calidad", "Otro"}
    Private vigencias() As String = {"*", "Vigente", "No Vigente"}

    Public Structure itemLista
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property Seccion As String
        Public Property Version As String
        Public Property Rige As String
        Public Property Alcance As String
        Public Property Sistema As String
        Public Property Ambito As String
        Public Property Tipo As String
        Public Property Vigencia As String
    End Structure

    Public Sub New()
        InitializeComponent()
        cargarCombos()
        manager = New ListadoManager()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As RoutedEventArgs) Handles btnCrear.Click
        manager.crear()
    End Sub

    Private Sub btnMod_Click(sender As Object, e As RoutedEventArgs) Handles btnMod.Click
        If gridLista.SelectedItem IsNot Nothing Then
            manager.modificar(CType(gridLista.SelectedItem, itemLista).Codigo, CType(gridLista.SelectedItem, itemLista).Version)
        Else
            MessageBox.Show("No se ha seleccionado ninguna publicación")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As RoutedEventArgs) Handles btnEliminar.Click
        If gridLista.SelectedItem IsNot Nothing Then
            Dim p As itemLista = gridLista.SelectedItem
            If p.Vigencia <> "no vigente" Then
                manager.eliminar(p.Codigo, p.Version, p.Nombre)
                cargarLista()
            End If
        Else
            MessageBox.Show("No se ha seleccionado ninguna publicación")
        End If
    End Sub

    Private Sub btnHistorico_Click(sender As Object, e As RoutedEventArgs) Handles btnHistorico.Click
        manager.abrirHistorico()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As RoutedEventArgs) Handles btnCargar.Click
        cargarLista()
    End Sub


    Private Sub cargarCombos()
        comboSeccion.ItemsSource = secciones
        comboVigencia.ItemsSource = vigencias
        comboDoc.ItemsSource = tipos

    End Sub

    Private Sub cargarLista()
        If comboDoc.SelectedItem = Nothing Or comboSeccion.SelectedValue = Nothing Or comboVigencia.SelectedItem = Nothing Then

        Else
            Dim lista As List(Of SVSG_lib.Publicacion)
            Try
                lista = manager.cargarLista(comboDoc.SelectedValue.ToString(), comboSeccion.SelectedValue.ToString(), comboVigencia.SelectedValue.ToString())
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            'gridLista.ItemsSource = lista
            If lista Is Nothing Then
                MessageBox.Show("No se encontro ningun resultado")
            Else
                Dim source As New List(Of itemLista)
                For Each pub As SVSG_lib.Publicacion In lista
                    Dim il As New itemLista
                    il.Codigo = pub.cod
                    il.Version = pub.documento_version
                    il.Seccion = pub.seccion
                    il.Nombre = pub.Documento.nombre
                    il.Rige = pub.fecha.Date
                    il.Alcance = pub.tipo_alcance
                    il.Sistema = pub.sistema_gestion
                    il.Ambito = pub.ambito
                    il.Tipo = pub.tipo
                    il.Vigencia = pub.vigencia
                    source.Add(il)
                Next
                'gridLista.Items.Clear()

                gridLista.ItemsSource = source
                'gridLista.UpdateLayout()
                'For Each pub As itemLista In gridLista.ItemsSource
                'Dim row As DataGridRow
                'row = gridLista.ItemContainerGenerator.ContainerFromItem(pub)
                'If pub.Vigencia = "vigente" Then
                'row.Background = Brushes.GreenYellow
                'ElseIf pub.Vigencia = "no vigente" Then
                'row.Background = Brushes.LightPink
                'End If

                'Next
            End If
        End If
    End Sub

    Private Sub gridLista_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles gridLista.SelectionChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        Application.Current.Shutdown()
    End Sub
End Class
