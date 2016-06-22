Public Class ShowMenu

    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        Me.Hide()
        DataUpdate.Show()
    End Sub

    Private Sub btnViewSubject_Click(sender As Object, e As EventArgs) Handles btnViewSubject.Click
        Me.Hide()
        ViewQuestion.Show()
    End Sub

    Private Sub btnViewUser_Click(sender As Object, e As EventArgs) Handles btnViewUser.Click
        Me.Hide()
        ViewUser.Show()
    End Sub

    Private Sub Menu_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Bạn có chắc muốn đóng chương trình?", "Warning", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class