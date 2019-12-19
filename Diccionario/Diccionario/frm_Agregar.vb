Public Class frm_Agregar
    Dim file As New OpenFileDialog()
    Private Sub Frm_Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbx_agregar.BackColor = Color.FromArgb(150, Color.Black)


    End Sub

    Private Sub Btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim palabra, definicion As String
        palabra = txt_palabra.Text
        definicion = txt_definicion.Text
        Dim li_definicion As New ListViewItem(palabra + ": " + definicion + ". " + file.FileName)
        li_definicion.SubItems.AddRange(New String() {palabra, definicion, file.FileName})
        frm_Listar.lv_palabras.Items.Add(li_definicion)
        frm_eliminar.lv_palabras.Items.Add(li_definicion.Clone)
        frm_Listar.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        frm_menu.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_imagen_Click(sender As Object, e As EventArgs) Handles btn_imagen.Click

        file.Filter = "Archivo JPG|*.jpg"

        If file.ShowDialog() = DialogResult.OK Then
            pbx_imagen.Image = Image.FromFile(file.FileName)
            'MsgBox(file.FileName)
        End If
    End Sub
End Class
