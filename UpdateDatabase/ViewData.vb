Public Class ViewData

    Private Sub AnswerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AnswerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AnswerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_DataSet)

    End Sub

    Private Sub ViewData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_DataSet.Subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.DB_DataSet.Subject)
        'TODO: This line of code loads data into the 'DB_DataSet.Question' table. You can move, or remove it, as needed.
        Me.QuestionTableAdapter.Fill(Me.DB_DataSet.Question)
        'TODO: This line of code loads data into the 'DB_DataSet.Answer' table. You can move, or remove it, as needed.
        Me.AnswerTableAdapter.Fill(Me.DB_DataSet.Answer)

    End Sub
End Class