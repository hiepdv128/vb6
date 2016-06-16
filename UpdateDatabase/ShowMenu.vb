Public Class ShowMenu

    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        Me.Hide()
        DataUpdate.Show()
    End Sub

    Private Sub btnViewSubject_Click(sender As Object, e As EventArgs) Handles btnViewSubject.Click
        Me.Hide()
        ViewData.Show()
    End Sub

    Private Sub btnViewUser_Click(sender As Object, e As EventArgs) Handles btnViewUser.Click
        Me.Hide()
        ViewUser.Show()
    End Sub
End Class