Imports System.Data.SqlClient

Public Class ViewQuestion
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True;MultipleActiveResultSets=True")
    Private dtbSubject, dtbQuestion, dtbAnswer As DataTable
    Private Sub ViewData_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If (Me.Visible) Then
            connect.Open()
            loadSubject()
            loadAnswer()
            loadQuestion()
            cmbQuestionFilter.SelectedIndex = 0
            cmbSubjectFilter.SelectedIndex = 0
        End If
    End Sub

    Private Sub loadSubject()
        Dim cmd As New SqlCommand("SELECT * FROM SUBJECT", connect)
        Dim adapter As New SqlDataAdapter()
        Dim data As New DataSet
        adapter.SelectCommand = cmd
        adapter.Fill(data)
        dtbSubject = data.Tables(0)
        dgvSubjectView.DataSource = dtbSubject
    End Sub

    Private Sub loadQuestion()
        Dim cmd As New SqlCommand("SELECT * FROM QUESTION", connect)
        Dim adapter As New SqlDataAdapter()
        Dim data As New DataSet
        adapter.SelectCommand = cmd
        adapter.Fill(data)
        dtbQuestion = data.Tables(0)
        dgvQuestionView.DataSource = dtbQuestion
    End Sub

    Private Sub loadAnswer()
        Dim cmd As New SqlCommand("SELECT IDSUBJECT,ANSWER.IDQUESTION,IDANSWER,CONTENTANSWER,CORRECT FROM ANSWER, QUESTION " & _
                                  "WHERE ANSWER.IDQUESTION = QUESTION.IDQUESTION", connect)
        Dim adapter As New SqlDataAdapter()
        Dim data As New DataSet
        adapter.SelectCommand = cmd
        adapter.Fill(data)
        dtbAnswer = data.Tables(0)
        dgvAnswerView.DataSource = dtbAnswer
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
            If MessageBox.Show("Bạn muốn chỉnh sửa bản ghi này, việc này ảnh hưởng tới tất cả DB, hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim cmdUpdateSubject As New SqlCommand("UPDATE SUBJECT SET NAMESUBJECT = N'" & contentCurrent & "' WHERE IDSUBJECT = '" & idSubject & "'", connect)
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
            If MessageBox.Show("Bạn muốn chỉnh sửa bản ghi này, việc này ảnh hưởng tới tất cả DB, hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim cmdUpdateQuestion As New SqlCommand("UPDATE QUESTION SET CONTENTQUESTION = @CONTENT WHERE IDSUBJECT = @IDSUBJECT AND IDQUESTION = @IDQUESTION", connect)
                cmdUpdateQuestion.Parameters.AddWithValue("@CONTENT", contentCurrent)
                cmdUpdateQuestion.Parameters.AddWithValue("@IDSUBJECT", idSubject)
                cmdUpdateQuestion.Parameters.AddWithValue("@IDQUESTION", idQuestion)
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
            If MessageBox.Show("Bạn muốn chỉnh sửa bản ghi này, việc này ảnh hưởng tới tất cả DB, hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim cmdUpdateQuestion As New SqlCommand("UPDATE ANSWER SET CONTENTANSWER = @CONTENT WHERE IDSUBJECT = @IDSUBJECT AND IDQUESTION = @IDQUESTION AND IDANSWER = @IDANSWER", connect)
                cmdUpdateQuestion.Parameters.AddWithValue("@CONTENT", contentCurrent)
                cmdUpdateQuestion.Parameters.AddWithValue("@IDSUBJECT", idSubject)
                cmdUpdateQuestion.Parameters.AddWithValue("@IDQUESTION", idQuestion)
                cmdUpdateQuestion.Parameters.AddWithValue("@IDANSWER", idAnswer)
                cmdUpdateQuestion.ExecuteNonQuery()
            Else
                rowCurrent.Cells(3).Value = contentLast
            End If
        End If
    End Sub

    Private Sub dgvQuestionView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuestionView.CellDoubleClick
        Dim row As DataGridViewRow = dgvQuestionView.Rows(e.RowIndex)
        If (e.ColumnIndex > 0) Then
            MessageBox.Show(row.Cells(2).Value.ToString, "Câu hỏi")
        End If
    End Sub

    Private Sub dgvAnswerView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnswerView.CellDoubleClick
        Dim row As DataGridViewRow = dgvAnswerView.Rows(e.RowIndex)
        If (e.ColumnIndex > 0) Then
            MessageBox.Show(row.Cells(3).Value.ToString, "Câu trả lời")
        End If
    End Sub

    Private Sub dgvSubjectView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectView.CellDoubleClick
        Dim row As DataGridViewRow = dgvSubjectView.Rows(e.RowIndex)
        If (e.ColumnIndex > 0) Then
            MessageBox.Show(row.Cells(1).Value.ToString, "Môn học")
        End If
    End Sub

    Private Sub dgvSubjectView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvSubjectView.UserDeletingRow
        If MessageBox.Show("Bạn muốn xoá bản ghi này, việc này sẽ xóa toàn bộ câu hỏi, các kết quả thi liên quan đến câu hỏi, " & _
                           "hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("Bạn thực sự đã cân nhắc kỹ?", "Cảnh báo cấp 2", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim idSubject As String = e.Row.Cells(0).Value.ToString
                Dim cmd As SqlCommand

                cmd = New SqlCommand("DELETE FROM SUBJECT WHERE IDSUBJECT = '" & idSubject & "'", connect)
                cmd.ExecuteNonQuery()

                cmbSubjectFilter.SelectedIndex = 1
                cmbSubjectFilter.SelectedIndex = 0
                cmbQuestionFilter.SelectedIndex = 1
                cmbQuestionFilter.SelectedIndex = 0

                loadQuestion()
                loadAnswer()
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub dgvSubjectView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSubjectView.RowHeaderMouseDoubleClick
        Dim count As Integer = dgvSubjectView.RowCount
        Dim dvQuestion, dvAnswer As DataView
        If (e.RowIndex < count) Then
            Dim idSubjectFocus As String = dgvSubjectView.Rows(e.RowIndex).Cells(0).Value.ToString
            dvQuestion = New DataView(dtbQuestion, "IDSubject = '" & idSubjectFocus & "'", "idquestion asc", DataViewRowState.CurrentRows)
            dvAnswer = New DataView(dtbAnswer, "IDSubject = '" & idSubjectFocus & "'", "idquestion asc", DataViewRowState.CurrentRows)
            dgvQuestionView.DataSource = dvQuestion
            dgvAnswerView.DataSource = dvAnswer
        End If
    End Sub

    Private Sub dgvQuestionView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvQuestionView.RowHeaderMouseDoubleClick
        Dim count As Integer = dgvQuestionView.RowCount
        If (e.RowIndex < count) Then
            Dim idQuestionFocus As String = dgvQuestionView.Rows(e.RowIndex).Cells(1).Value.ToString
            Dim idSubjectOfQuestion As String = dgvQuestionView.Rows(e.RowIndex).Cells(0).Value.ToString
            Dim dvSubject, dvAnswer As DataView
            dvSubject = New DataView(dtbSubject, "idsubject = '" & idSubjectOfQuestion & "'", "idsubject asc", DataViewRowState.CurrentRows)
            dvAnswer = New DataView(dtbAnswer, "idquestion = '" & idQuestionFocus & "'", "idanswer asc", DataViewRowState.CurrentRows)
            dgvSubjectView.DataSource = dvSubject
            dgvAnswerView.DataSource = dvAnswer
        End If
    End Sub

    Private Sub dgvAnswerView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAnswerView.RowHeaderMouseDoubleClick
        Dim count As Integer = dgvAnswerView.RowCount
        If (e.RowIndex < count) Then
            Dim dvSubject, dvQuestion As DataView
            Dim row As DataGridViewRow = dgvAnswerView.Rows(e.RowIndex)
            Dim idQuestion As String = row.Cells(1).Value.ToString
            Dim idSubject As String = row.Cells(0).Value.ToString
            dvSubject = New DataView(dtbSubject, "idsubject = '" & idSubject & "'", "idsubject asc", DataViewRowState.CurrentRows)
            dvQuestion = New DataView(dtbQuestion, "idquestion = '" & idQuestion & "'", "idquestion asc", DataViewRowState.CurrentRows)
            dgvSubjectView.DataSource = dvSubject
            dgvQuestionView.DataSource = dvQuestion
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dgvAnswerView.DataSource = dtbAnswer
        dgvQuestionView.DataSource = dtbQuestion
        dgvSubjectView.DataSource = dtbSubject
        txtQuestionFilter.Text = ""
        txtSubjectFilter.Text = ""
    End Sub
    'xoa cai hoi se xoa kem theo 4 cau tra loi
    Private Sub dgvQuestionView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvQuestionView.UserDeletingRow
        If MessageBox.Show("Bạn muốn xoá bản ghi này, xóa câu hỏi đồng nghĩa xóa 4 câu trả lời, " & _
                           "hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("Bạn thực sự đã cân nhắc kỹ?", "Cảnh báo cấp 2", _
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim idQuestion As String = e.Row.Cells(1).Value.ToString
                Dim cmd As SqlCommand
                cmd = New SqlCommand("DELETE FROM QUESTION WHERE IDQUESTION = @IDQUESTION", connect)
                cmd.Parameters.AddWithValue("@IDQUESTION", idQuestion)
                cmd.ExecuteNonQuery()
                loadAnswer()

                cmbQuestionFilter.SelectedIndex = 1
                cmbQuestionFilter.SelectedIndex = 0
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub
    'xoa cau tra loi se xoa ca cau hoi va 3 cau tra loi con lai
    Private Sub dgvAnswerView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvAnswerView.UserDeletingRow
        If MessageBox.Show("Bạn muốn xoá bản ghi này, việc này đồng nghĩa xóa câu hỏi và 3 đáp án còn lại, " & _
                           "hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("Bạn thực sự đã cân nhắc kỹ?", "Cảnh báo cấp 2", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim idQuestion As String = e.Row.Cells(1).Value.ToString
                Dim cmd As SqlCommand
                cmd = New SqlCommand("DELETE FROM QUESTION WHERE IDQUESTION = @IDQUESTION", connect)
                cmd.Parameters.AddWithValue("@IDQUESTION", idQuestion)
                cmd.ExecuteNonQuery()
                loadQuestion()
                loadAnswer()

                cmbQuestionFilter.SelectedIndex = 1
                cmbQuestionFilter.SelectedIndex = 0
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    'Private Sub deleteQuestion(idQuestion As String)
    '    Dim cmd As SqlCommand
    '    cmd = New SqlCommand("DELETE FROM ANSWER WHERE IDQUESTION = @IDQUESTION", connect)
    '    cmd.Parameters.AddWithValue("@IDQUESTION", idQuestion)
    '    cmd.ExecuteNonQuery()
    '    cmd = New SqlCommand("DELETE FROM QUESTION WHERE IDQUESTION = @IDQUESTION", connect)
    '    cmd.Parameters.AddWithValue("@IDQUESTION", idQuestion)
    '    cmd.ExecuteNonQuery()
    'End Sub

    Private Sub filterIdSubject(idSubjectFocus As String)
        Dim sql As String
        Dim cmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataQuestion As New DataSet
        Dim dataAnswer As New DataSet
        Dim dataSubject As New DataSet

        sql = "SELECT * FROM QUESTION WHERE IDSUBJECT = '" & idSubjectFocus & "'"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataQuestion)
        dgvQuestionView.DataSource = dataQuestion.Tables(0)

        sql = "SELECT * FROM SUBJECT WHERE IDSUBJECT = '" & idSubjectFocus & "'"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataSubject)
        dgvSubjectView.DataSource = dataSubject.Tables(0)

        sql = "SELECT * FROM ANSWER WHERE IDQUESTION IN (SELECT IDQUESTION FROM QUESTION WHERE IDSUBJECT = '" & idSubjectFocus & "')"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataAnswer)
        dgvAnswerView.DataSource = dataAnswer.Tables(0)
    End Sub

    Private Sub filterNameSubject(nameSubject As String)
        Dim sql As String
        Dim cmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataQuestion As New DataSet
        Dim dataAnswer As New DataSet
        Dim dataSubject As New DataSet

        sql = "SELECT * FROM SUBJECT WHERE NAMESUBJECT LIKE N'" & nameSubject & "%'"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataSubject)
        dgvSubjectView.DataSource = dataSubject.Tables(0)

        sql = "SELECT * FROM QUESTION WHERE IDSUBJECT IN (SELECT IDSUBJECT FROM SUBJECT WHERE NAMESUBJECT LIKE N'" & nameSubject & "%')"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataQuestion)
        dgvQuestionView.DataSource = dataQuestion.Tables(0)

        sql = "SELECT * FROM ANSWER WHERE IDQUESTION IN " & _
            "(SELECT IDQUESTION FROM QUESTION WHERE IDSUBJECT IN (SELECT IDSUBJECT FROM SUBJECT WHERE NAMESUBJECT LIKE N'" & nameSubject & "%'))"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataAnswer)
        dgvAnswerView.DataSource = dataAnswer.Tables(0)
    End Sub

    Private Sub filterIdSubjectIdQuestion(idSubjectFocus As String, idQuestionFocus As String)
        Dim sql As String
        Dim cmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataQuestion As New DataSet
        Dim dataAnswer As New DataSet
        Dim dataSubject As New DataSet

        Try
            sql = "SELECT * FROM QUESTION WHERE IDQUESTION = " & idQuestionFocus
            cmd = New SqlCommand(sql, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(dataQuestion)
            dgvQuestionView.DataSource = dataQuestion.Tables(0)

            sql = "SELECT * FROM SUBJECT WHERE IDSUBJECT = '" & idSubjectFocus & "'"
            cmd = New SqlCommand(sql, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(dataSubject)
            dgvSubjectView.DataSource = dataSubject.Tables(0)

            sql = "SELECT * FROM ANSWER WHERE IDQUESTION = " & idQuestionFocus
            cmd = New SqlCommand(sql, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(dataAnswer)
            dgvAnswerView.DataSource = dataAnswer.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Dữ liệu bạn nhập không khớp với bản ghi nào!", "Thông báo")
        End Try
    End Sub
    ' chua hoan thien
    Private Sub filterContentQuestion(contentQuestion As String)
        Dim sql As String
        Dim cmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataQuestion As New DataSet
        Dim dataAnswer As New DataSet
        Dim dataSubject As New DataSet

        sql = "SELECT * FROM QUESTION WHERE CONTENTQUESTION LIKE N'%" & contentQuestion & "%'"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataQuestion)
        dgvQuestionView.DataSource = dataQuestion.Tables(0)

        sql = "SELECT * FROM SUBJECT WHERE IDSUBJECT IN (SELECT IDSUBJECT FROM QUESTION WHERE CONTENTQUESTION LIKE N'%" & contentQuestion & "%')"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataSubject)
        dgvSubjectView.DataSource = dataSubject.Tables(0)

        sql = "SELECT * FROM ANSWER WHERE " & _
            "IDQUESTION IN (SELECT IDQUESTION FROM QUESTION WHERE CONTENTQUESTION LIKE N'%" & contentQuestion & "%')"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataAnswer)
        dgvAnswerView.DataSource = dataAnswer.Tables(0)

    End Sub

    Private Sub filterIDQuestion(idQuestion As String)
        Dim sql As String
        Dim cmd As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataQuestion As New DataSet
        Dim dataSubject As New DataSet
        Dim dataAnswer As New DataSet

        If (IsNumeric(idQuestion)) Then

        End If

        Try
            sql = "SELECT * FROM QUESTION WHERE IDQUESTION = " & idQuestion
            cmd = New SqlCommand(sql, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(dataQuestion)
            dgvQuestionView.DataSource = dataQuestion.Tables(0)

            sql = "SELECT * FROM SUBJECT WHERE IDSUBJECT IN (SELECT IDSUBJECT FROM QUESTION WHERE IDQUESTION = " & idQuestion & ")"
            cmd = New SqlCommand(sql, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(dataSubject)
            dgvSubjectView.DataSource = dataSubject.Tables(0)

            sql = "SELECT * FROM ANSWER WHERE " & _
                "IDQUESTION IN (SELECT IDQUESTION FROM QUESTION WHERE IDQUESTION = " & idQuestion & ")"
            cmd = New SqlCommand(sql, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(dataAnswer)
            dgvAnswerView.DataSource = dataAnswer.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Dữ liệu bạn nhập không khớp với bản ghi nào!", "Thông báo")
        End Try

    End Sub

    Private Sub filterNameSubjectIdQuestion(nameSubject As String, idQuestion As String)
        Dim sql As String
        Dim cmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataSubject As New DataSet
        Dim dataQuestion As New DataSet
        Dim dataAnswer As New DataSet

        Try
            sql = "SELECT * FROM SUBJECT WHERE NAMESUBJECT LIKE N'%" & nameSubject & "%'"
            cmd = New SqlCommand(sql, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(dataSubject)
            dgvSubjectView.DataSource = dataSubject.Tables(0)

            sql = "SELECT * FROM QUESTION WHERE IDSUBJECT IN (SELECT IDSUBJECT FROM SUBJECT WHERE NAMESUBJECT LIKE N'%" & nameSubject & "%')" & _
                 "AND IDQUESTION = " & idQuestion
            cmd = New SqlCommand(sql, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(dataQuestion)
            dgvQuestionView.DataSource = dataQuestion.Tables(0)

            sql = "SELECT * FROM ANSWER WHERE IDQUESTION IN (SELECT IDQUESTION FROM QUESTION " & _
                "WHERE IDSUBJECT IN (SELECT IDSUBJECT FROM SUBJECT WHERE NAMESUBJECT LIKE N'%" & nameSubject & "%')" & _
                 "AND IDQUESTION = " & idQuestion & ")"
            cmd = New SqlCommand(sql, connect)
            adapter.SelectCommand = cmd
            adapter.Fill(dataAnswer)
            dgvAnswerView.DataSource = dataAnswer.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Dữ liệu bạn nhập không khớp với bản ghi nào!", "Thông báo")
        End Try

    End Sub

    Private Sub filterIdSubjectContentQuestion(idSubject As String, contentQuestion As String)
        Dim sql As String
        Dim cmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataSubject As New DataSet
        Dim dataQuestion As New DataSet
        Dim dataAnswer As New DataSet

        sql = "SELECT * FROM SUBJECT WHERE IDSUBJECT LIKE '" & idSubject & "%'"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataSubject)
        dgvSubjectView.DataSource = dataSubject.Tables(0)

        sql = "SELECT * FROM QUESTION WHERE CONTENTQUESTION LIKE N'%" & contentQuestion & "%'" & _
             "AND IDSUBJECT LIKE '" & idSubject & "%'"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataQuestion)
        dgvQuestionView.DataSource = dataQuestion.Tables(0)

        sql = "SELECT * FROM ANSWER WHERE IDQUESTION IN (SELECT IDQUESTION FROM QUESTION " & _
            "WHERE CONTENTQUESTION LIKE N'%" & contentQuestion & "%' AND IDSUBJECT LIKE '" & idSubject & "%')"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataAnswer)
        dgvAnswerView.DataSource = dataAnswer.Tables(0)
    End Sub

    Private Sub filterNameSubjectContentQuestion(nameSubject As String, contentQuestion As String)
        Dim sql As String
        Dim cmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataSubject As New DataSet
        Dim dataQuestion As New DataSet
        Dim dataAnswer As New DataSet

        sql = "SELECT * fROM SUBJECT WHERE IDSUBJECT IN (SELECT IDSUBJECT FROM QUESTION WHERE CONTENTQUESTION LIKE N'%" & contentQuestion & _
            "%' AND IDSubject in (SELECT IDSubject from Subject where namesubject LIKE N'%" & nameSubject & "%'))"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataSubject)
        dgvSubjectView.DataSource = dataSubject.Tables(0)

        sql = "SELECT * FROM QUESTION WHERE CONTENTQUESTION LIKE N'%" & contentQuestion & _
            "%' AND IDSubject in (SELECT IDSubject from Subject where namesubject LIKE N'%" & nameSubject & "%')"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataQuestion)
        dgvQuestionView.DataSource = dataQuestion.Tables(0)

        sql = "SELECT * FROM ANSWER WHERE IDQUESTION IN (SELECT IDQUESTION FROM QUESTION,SUBJECT " & _
            "WHERE QUESTION.IDSUBJECT = SUBJECT.IDSUBJECT AND " & _
            "CONTENTQUESTION LIKE N'%" & contentQuestion & "%' AND NAMESUBJECT LIKE N'%" & nameSubject & "%')"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(dataAnswer)
        dgvAnswerView.DataSource = dataAnswer.Tables(0)
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim questionFilter As String = txtQuestionFilter.Text
        Dim subjectFilter As String = txtSubjectFilter.Text
        Dim QSItemSelected As String = cmbQuestionFilter.SelectedItem
        Dim SJItemSelected As String = cmbSubjectFilter.SelectedItem

        If (questionFilter = "" And subjectFilter <> "") Then
            If (SJItemSelected = "ID") Then
                filterIdSubject(subjectFilter)
            Else
                filterNameSubject(subjectFilter)
            End If

        ElseIf (questionFilter <> "" And subjectFilter <> "") Then
            If (SJItemSelected = "ID" And QSItemSelected = "ID") Then
                filterIdSubjectIdQuestion(subjectFilter, questionFilter)
            ElseIf (QSItemSelected = "ID" And SJItemSelected = "NAME") Then
                filterNameSubjectIdQuestion(subjectFilter, questionFilter)
            ElseIf (QSItemSelected = "CONTENT" And SJItemSelected = "ID") Then
                filterIdSubjectContentQuestion(subjectFilter, questionFilter)
            Else
                filterNameSubjectContentQuestion(subjectFilter, questionFilter)
            End If

        ElseIf (questionFilter <> "" And subjectFilter = "") Then
            If (QSItemSelected = "CONTENT") Then
                filterContentQuestion(questionFilter)
            Else
                filterIDQuestion(questionFilter)
            End If
        Else
            MessageBox.Show("Hãy nhập từ khóa tìm kiếm (từ khóa sẽ được gợi ý), trước khi thực hiện lọc", "Lưu ý")
        End If

        If (dgvSubjectView.RowCount = 0) Then
            MessageBox.Show("Dữ liệu bạn nhập không khớp bản ghi nào!", "Thông báo")
        End If
    End Sub

    Private Sub cmbSubjectFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjectFilter.SelectedIndexChanged
        Dim cmd As New SqlCommand("SELECT * FROM SUBJECT", connect)
        Dim data As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)

        Dim collection As New AutoCompleteStringCollection
        Dim i, count, index As Integer
        Dim table As DataTable

        adapter.Fill(data, "list")
        table = data.Tables(0)
        count = table.Rows.Count
        index = cmbSubjectFilter.SelectedIndex
        If (index = 0) Then
            For i = 0 To count - 1
                collection.Add(table.Rows(i)("idsubject").ToString())
            Next
        ElseIf (index = 1) Then
            For i = 0 To count - 1
                collection.Add(table.Rows(i)("namesubject").ToString())
            Next
        End If
        txtSubjectFilter.AutoCompleteCustomSource = collection
    End Sub

    Private Sub cmbQuestionFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuestionFilter.SelectedIndexChanged
        Dim cmd As New SqlCommand
        Dim data As New DataSet
        Dim adapter As New SqlDataAdapter
        Dim colection As New AutoCompleteStringCollection
        Dim i, count, indexQuestion, indexSubject As Integer
        Dim table As DataTable
        Dim subject As String

        indexQuestion = cmbQuestionFilter.SelectedIndex
        indexSubject = cmbSubjectFilter.SelectedIndex
        subject = txtSubjectFilter.Text

        If (subject.Equals("")) Then
            If (indexQuestion = 0) Then
                cmd = New SqlCommand("SELECT IDQUESTION FROM QUESTION", connect)
            ElseIf (indexQuestion = 1) Then
                cmd = New SqlCommand("SELECT CONTENTQUESTION FROM QUESTION", connect)
            End If
        ElseIf (indexSubject = 0 And indexQuestion = 0) Then
            cmd = New SqlCommand("SELECT IDQUESTION FROM QUESTION WHERE IDSUBJECT = '" & subject & "'", connect)
        ElseIf (indexSubject = 0 And indexQuestion = 1) Then
            cmd = New SqlCommand("SELECT CONTENTQUESTION FROM QUESTION WHERE IDSUBJECT ='" & subject & "'", connect)
        ElseIf (indexSubject = 1 And indexQuestion = 0) Then
            cmd = New SqlCommand("SELECT IDQUESTION FROM QUESTION WHERE IDSUBJECT IN" & _
                                 "(SELECT IDSUBJECT FROM SUBJECT WHERE NAMESUBJECT LIKE N'" & subject & "%')", connect)
        ElseIf (indexSubject = 1 And indexQuestion = 1) Then
            cmd = New SqlCommand("SELECT CONTENTQUESTION FROM QUESTION WHERE IDSUBJECT IN" & _
                                 "(SELECT IDSUBJECT FROM SUBJECT WHERE NAMESUBJECT LIKE N'" & subject & "%')", connect)
        End If

        adapter.SelectCommand = cmd
        adapter.Fill(data)
        table = data.Tables(0)
        count = table.Rows.Count
        For i = 0 To count - 1
            colection.Add(table.Rows(i)(0).ToString())
        Next
        txtQuestionFilter.AutoCompleteCustomSource = colection
    End Sub

    Private Sub ViewQuestion_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnReset.PerformClick()
        connect.Close()
        Me.Hide()
        ShowMenu.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        connect.Close()
        Me.Hide()
        ShowMenu.Show()
    End Sub

    Private Sub ViewQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class