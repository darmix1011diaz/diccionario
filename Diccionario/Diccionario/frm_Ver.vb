':::Libreria necesaria para manejo de directorios y archivos
Imports System.IO
Public Class frm_Ver
    Public indiceItem As Integer
    Public path As String
    ':::Ruta donde crearemos nuestro archivo txt
    Dim ruta As String = "C:\Tutoriales\"
    ':::Nombre del archivo
    Dim archivo As String = "deber_diccionario.txt"
    Private Sub Frm_Ver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbx_ver.BackColor = Color.FromArgb(150, Color.Black)
    End Sub

    Private Sub Btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim palabra, definicion As String
        palabra = txt_palabra.Text
        definicion = txt_definicion.Text
        Dim li_definicion As New ListViewItem(palabra + ": " + definicion + ". " + path)
        li_definicion.SubItems.AddRange(New String() {palabra, definicion, path})
        frm_Listar.lv_palabras.Items.Item(indiceItem) = li_definicion
        frm_eliminar.lv_palabras.Items.Item(indiceItem) = li_definicion.Clone
        frm_Listar.Show()
        Me.Hide()

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
            MsgBox("PROBLEMA EN EL ARCHIVO: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        Dim escribir As New StreamWriter(ruta & archivo)
        Try
            ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
            For Each item As ListViewItem In frm_Listar.lv_palabras.Items
                escribir.WriteLine(item.Text)
            Next
            escribir.Close()
            MsgBox("REGISTRO CORRECTO", MsgBoxStyle.Information, "")
            ':::Llamamos nuestro procedimiento para leer el archivo TXT
            'LeerArchivo()
        Catch ex As Exception
            MsgBox("PROBLEMA EN EL ARCHIVO: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try
    End Sub
End Class