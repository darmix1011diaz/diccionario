Public Class frm_menu
    Private Sub Btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        frm_Agregar.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        frm_eliminar.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        frm_Listar.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class