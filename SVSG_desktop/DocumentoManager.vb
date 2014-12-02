Imports System.IO
Imports System.Windows.Forms

Public Class DocumentoManager


    Public Sub crearDocumento(ByVal p As SVSG_lib.Publicacion)
        Dim client As New PublicacionService.ListadoClient
        If client.crearDocumento(p) Then
            System.Windows.MessageBox.Show("Se creo el documento y fue publicado")
        Else
            System.Windows.MessageBox.Show("Hubo un error en la creación del documento", MessageBoxImage.Error)
        End If
        client.Close()

    End Sub

    Public Function convertir_Archivo_ArregloBytes(ByVal RutaDireccion As String) As Byte()
        Dim ArchivoBytes() As Byte
        Dim numBytes As Long
        Dim fInfo As FileInfo
        Dim fStream As FileStream
        Dim br As BinaryReader

        Try
            'No es tan necesario, pero para ver información del archivo.
            fInfo = New FileInfo(RutaDireccion)
            numBytes = fInfo.Length
            fStream = New FileStream(RutaDireccion, FileMode.Open, FileAccess.Read)
            br = New BinaryReader(fStream)
            'recupera cada byte del sistema binario y lo inserta en el vector
            ArchivoBytes = br.ReadBytes(CInt(numBytes))
            'cerrar los objetos
            br.Close()
            fStream.Close()

            Return ArchivoBytes

        Catch exFNF As FileNotFoundException
            'Sino encuentra el archivo
            System.Windows.MessageBox.Show("El archivo indicado no existe:" & ControlChars.CrLf & RutaDireccion & ControlChars.CrLf & exFNF.Message, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Catch ex As Exception
            System.Windows.MessageBox.Show(RutaDireccion & ControlChars.CrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            fInfo = Nothing
            fStream = Nothing
            br = Nothing
        End Try

    End Function


End Class


