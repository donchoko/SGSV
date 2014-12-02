Public Class DocList

    Private manager As ListadoManager
    Private ambitos() As String = {"Gestión", "Técnico", "Equipo"}
    Private tipos() As String = {"*", "Procedimiento", "Instructivo", "Manual", "Especificación", "Registro", "Norma", "Catalogo", "Hoja de calculo", "Listado"}
    Private procedencias() As String = {"Departamento de Ciencias Forenses", "Externo"}
    Private secciones() As String = {"*", "1", "2", "3"}
    Private alcance() As String = {"General", "Especifico"}
    Private sis_gestion() As String = {"Calidad", "Otro"}
    Private vigencias() As String = {"*", "Vigente", "Obsolteo"}

    Public Sub New()
        InitializeComponent()
        cargarCombos()
        manager = New ListadoManager()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As RoutedEventArgs) Handles btnCrear.Click
        manager.crear()
    End Sub

    Private Sub btnMod_Click(sender As Object, e As RoutedEventArgs) Handles btnMod.Click
        manager.modificar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As RoutedEventArgs) Handles btnEliminar.Click
        If gridLista.SelectedItem <> Nothing Then
            manager.eliminar(gridLista.SelectedItem.ToString())
        Else
            MessageBox.Show("No se ha seleccionado ningun documento")
        End If
    End Sub

    Private Sub btnHistorico_Click(sender As Object, e As RoutedEventArgs) Handles btnHistorico.Click
        manager.abrirHistorico()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As RoutedEventArgs) Handles btnCargar.Click
        If comboDoc.SelectedItem = Nothing Or comboSeccion.SelectedValue = Nothing Or comboVigencia.SelectedItem = Nothing Then
            
        Else
            Dim lista As List(Of SVSG_lib.Publicacion) = manager.cargarLista(comboDoc.SelectedValue.ToString(), comboSeccion.SelectedValue.ToString(), comboVigencia.SelectedValue.ToString())
            gridLista.ItemsSource = lista
        End If
    End Sub

    Private Sub cargarCombos()
        comboSeccion.ItemsSource = secciones
        comboVigencia.ItemsSource = vigencias
        comboDoc.ItemsSource = tipos

    End Sub
End Class
