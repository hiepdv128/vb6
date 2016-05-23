Imports System.Data.SqlClient

Public Class ViewData
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True;MultipleActiveResultSets=True")

    Private Sub AnswerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
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
        connect.Open()
    End Sub

    Private contentLast As String

    Private Sub dgvSubjectView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvSubjectView.CellBeginEdit
        Dim rowCurrent = dgvSubjectView.Rows(e.RowIndex)
        contentLast = rowCurrent.Cells(1).Value.ToString
    End Sub

    Private Sub dgvSubjectView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectView.CellEndEdit
        Dim rowCurrent As DataGridViewRow = dgvSubjectView.Rows(e.RowIndex)
        Dim contentCurrent As String = rowCurrent.Cells(1).Value.ToString
        Dim idSubject As String = rowCurrent.Cells(0).Value.ToString
        If (contentCurrent <> contentLast) Then
            If MessageBox.Show("Bạn muốn chỉnh sửa bản ghi này, việc này ảnh hưởng tới tất cả DB. Hãy cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim cmdUpdateSubject As New SqlCommand("update Subject set NameSubject = N'" & contentCurrent & "' where IDSubject = '" & idSubject & "'", connect)
                cmdUpdateSubject.ExecuteNonQuery()
            Else
                rowCurrent.Cells(1).Value = contentLast
            End If
        End If
    End Sub

    Private Sub dgvQuestionView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvQuestionView.CellBeginEdit
        Dim rowCurrent = dgvQuestionView.Rows(e.RowIndex)
        contentLast = rowCurrent.Cells(2).Value.ToString
    End Sub

    Private Sub dgvQuestionView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuestionView.CellEndEdit
        Dim rowCurrent As DataGridViewRow = dgvQuestionView.Rows(e.RowIndex)
        Dim contentCurrent As String = rowCurrent.Cells(2).Value.ToString
        Dim idSubject As String = rowCurrent.Cells(0).Value.ToString
        Dim idQuestion As String = rowCurrent.Cells(1).Value.ToString
        If (contentCurrent <> contentLast) Then
            If MessageBox.Show("Bạn muốn chỉnh sửa bản ghi này, việc này ảnh hưởng tới tất cả DB. Hãy cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim cmdUpdateQuestion As New SqlCommand("update Question set contentquestion = @content where IDSubject = @idsubject and idquestion = @idquestion", connect)
                cmdUpdateQuestion.Parameters.AddWithValue("@content", contentCurrent)
                cmdUpdateQuestion.Parameters.AddWithValue("@idsubject", idSubject)
                cmdUpdateQuestion.Parameters.AddWithValue("@idquestion", idQuestion)
                cmdUpdateQuestion.ExecuteNonQuery()
            Else
                rowCurrent.Cells(2).Value = contentLast
            End If
        End If
    End Sub

    Private Sub dgvAnswerView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvAnswerView.CellBeginEdit
        Dim rowCurrent = dgvAnswerView.Rows(e.RowIndex)
        contentLast = rowCurrent.Cells(3).Value.ToString
    End Sub

    Private Sub dgvAnswerView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnswerView.CellEndEdit
        Dim rowCurrent As DataGridViewRow = dgvAnswerView.Rows(e.RowIndex)
        Dim contentCurrent As String = rowCurrent.Cells(3).Value.ToString
        Dim idSubject As String = rowCurrent.Cells(0).Value.ToString
        Dim idQuestion As String = rowCurrent.Cells(1).Value.ToString
        Dim idAnswer As String = rowCurrent.Cells(2).Value.ToString
        If (contentCurrent <> contentLast) Then
            If MessageBox.Show("Bạn muốn chỉnh sửa bản ghi này, việc này ảnh hưởng tới tất cả DB. Hãy cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim cmdUpdateQuestion As New SqlCommand("update answer set contentanswer = @content where IDSubject = @idsubject and idquestion = @idquestion and idanswer = @idanswer", connect)
                cmdUpdateQuestion.Parameters.AddWithValue("@content", contentCurrent)
                cmdUpdateQuestion.Parameters.AddWithValue("@idsubject", idSubject)
                cmdUpdateQuestion.Parameters.AddWithValue("@idquestion", idQuestion)
                cmdUpdateQuestion.Parameters.AddWithValue("@idanswer", idAnswer)
                cmdUpdateQuestion.ExecuteNonQuery()
            Else
                rowCurrent.Cells(3).Value = contentLast
            End If
        End If
    End Sub


    Private Sub dgvSubjectView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvSubjectView.RowsRemoved
        Dim rowCurrent As DataGridViewRow = dgvAnswerView.Rows(e.RowIndex)
        MsgBox(rowCurrent.Cells(1))
    End Sub
End Class