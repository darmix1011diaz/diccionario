':::Libreria necesaria para manejo de directorios y archivos
Imports System.IO
Public Class frm_Listar

    ':::Ruta donde crearemos nuestro archivo txt
    Dim ruta As String = "C:\Tutoriales\"
    ':::Nombre del archivo
    Dim archivo As String = "deber_diccionario.txt"
    Private Sub Lv_palabras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_palabras.SelectedIndexChanged
        Dim palabra, definicion As String
        If lv_palabras.SelectedItems.Count > 0 Then
            palabra = lv_palabras.SelectedItems.Item(0).SubItems(1).Text
            definicion = lv_palabras.SelectedItems.Item(0).SubItems(2).Text
            frm_Ver.txt_palabra.Text = palabra
            frm_Ver.txt_definicion.Text = definicion
            frm_Ver.path = lv_palabras.SelectedItems.Item(0).SubItems(3).Text
            frm_Ver.indiceItem = lv_palabras.SelectedIndices(0)
            frm_Ver.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        frm_Agregar.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim fs As FileStream
        Dim Directorio As String

        If Dir(Environ("UserProfile") & "\Escritorio\", vbDirectory) <> "" Then Directorio = Environ("USERPROFILE") & "\Escritorio\"
        If Dir(Environ("UserProfile") & "\Desktop\", vbDirectory) <> "" Then Directorio = Environ("USERPROFILE") & "\Desktop\"
        ':::Validamos si la carpeta de ruta existe, si no existe la creamos
        ruta = Directorio
        'MsgBox(ruta)
        Try
            If File.Exists(ruta) Then

                ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & archivo)
                fs.Close()
                MsgBox("ARCHIVO CREADO", MsgBoxStyle.Information, ".")
            Else

                ':::Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)

                ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & archivo)
                fs.Close()
                MsgBox("ARCHIVO CREADO", MsgBoxStyle.Information, "")
            End If

        Catch ex As Exception
            MsgBox("PROBLEMA CON EL ARCHIVO: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        Dim escribir As New StreamWriter(ruta & archivo)
        Try
            ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
            For Each item As ListViewItem In Me.lv_palabras.Items
                escribir.WriteLine(item.Text)
            Next
            escribir.Close()
            MsgBox("REGISTRO GUARDADO", MsgBoxStyle.Information, "")
            ':::Llamamos nuestro procedimiento para leer el archivo TXT
            'LeerArchivo()
        Catch ex As Exception
            MsgBox("PROBLEMA CON EL ARCHIVO: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub Btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_Listar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbx_agregar.BackColor = Color.FromArgb(150, Color.Black)
    End Sub
End Class