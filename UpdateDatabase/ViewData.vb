Imports System.Data.SqlClient

Public Class ViewData
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True;MultipleActiveResultSets=True")
    Private dtbSubject, dtbQuestion, dtbAnswer As DataTable
    Private Sub ViewData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.Open()
        Me.CenterToScreen()
        loadSubject()
        loadAnswer()
        loadQuestion()
        loadComboBox()
    End Sub

    Private Sub loadSubject()
        Dim cmd As New SqlCommand("select *from subject", connect)
        Dim adapter As New SqlDataAdapter()
        adapter.SelectCommand = cmd
        Dim data As New DataSet
        adapter.Fill(data)
        dtbSubject = data.Tables(0)
        dgvSubjectView.DataSource = dtbSubject
    End Sub

    Private Sub loadQuestion()
        Dim cmd As New SqlCommand("select * from question", connect)
        Dim adapter As New SqlDataAdapter()
        adapter.SelectCommand = cmd
        Dim data As New DataSet
        adapter.Fill(data)
        dtbQuestion = data.Tables(0)
        dgvQuestionView.DataSource = dtbQuestion
    End Sub

    Private Sub loadAnswer()
        Dim cmd As New SqlCommand("select * from answer", connect)
        Dim adapter As New SqlDataAdapter()
        adapter.SelectCommand = cmd
        Dim data As New DataSet
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
            If MessageBox.Show("Bạn muốn chỉnh sửa bản ghi này, việc này ảnh hưởng tới tất cả DB, hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
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
            If MessageBox.Show("Bạn muốn chỉnh sửa bản ghi này, việc này ảnh hưởng tới tất cả DB, hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
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
        If MessageBox.Show("Bạn muốn xoá bản ghi này, việc này ảnh hưởng tới tất cả DB, hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("Bạn thực sự đã cân nhắc kỹ?", "Cảnh báo cấp 2", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim idSubject As String = e.Row.Cells(0).Value.ToString
                Dim cmd As SqlCommand
                cmd = New SqlCommand("delete from answer where idsubject = '" & idSubject & "'", connect)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("delete from question where idsubject = '" & idSubject & "'", connect)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("delete from subject where idsubject = '" & idSubject & "'", connect)
                cmd.ExecuteNonQuery()
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
        If (e.RowIndex < count - 1) Then
            Dim idSubjectFocus As String = dgvSubjectView.Rows(e.RowIndex).Cells(0).Value.ToString
            Dim dvQuestion, dvAnswer As DataView
            dvQuestion = New DataView(dtbQuestion, "IDSubject = '" & idSubjectFocus & "'", "idquestion asc", DataViewRowState.CurrentRows)
            dvAnswer = New DataView(dtbAnswer, "IDSubject = '" & idSubjectFocus & "'", "idquestion asc", DataViewRowState.CurrentRows)
            dgvQuestionView.DataSource = dvQuestion
            dgvAnswerView.DataSource = dvAnswer
        End If
    End Sub

    Private Sub dgvQuestionView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvQuestionView.RowHeaderMouseDoubleClick
        Dim count As Integer = dgvQuestionView.RowCount
        If (e.RowIndex < count - 1) Then
            Dim idQuestionFocus As String = dgvQuestionView.Rows(e.RowIndex).Cells(1).Value.ToString
            Dim idSubjectOfQuestion As String = dgvQuestionView.Rows(e.RowIndex).Cells(0).Value.ToString
            Dim dvSubject, dvAnswer As DataView
            dvSubject = New DataView(dtbSubject, "idsubject = '" & idSubjectOfQuestion & "'", "idsubject asc", DataViewRowState.CurrentRows)
            dvAnswer = New DataView(dtbAnswer, "idsubject = '" & idSubjectOfQuestion & "' and idquestion = '" & idQuestionFocus & "'", "idanswer asc", DataViewRowState.CurrentRows)
            dgvSubjectView.DataSource = dvSubject
            dgvAnswerView.DataSource = dvAnswer
        End If
    End Sub

    Private Sub dgvAnswerView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAnswerView.RowHeaderMouseDoubleClick
        Dim count As Integer = dgvQuestionView.RowCount
        If (e.RowIndex < count - 1) Then
            Dim row As DataGridViewRow = dgvAnswerView.Rows(e.RowIndex)
            Dim idQuestion As String = row.Cells(1).Value.ToString
            Dim idSubject As String = row.Cells(0).Value.ToString
            Dim dvSubject, dvQuestion As DataView
            dvSubject = New DataView(dtbSubject, "idsubject = '" & idSubject & "'", "idsubject asc", DataViewRowState.CurrentRows)
            dvQuestion = New DataView(dtbQuestion, "idsubject = '" & idSubject & "' and idquestion = '" & idQuestion & "'", "idquestion asc", DataViewRowState.CurrentRows)
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
        If MessageBox.Show("Bạn muốn xoá bản ghi này, việc này ảnh hưởng tới tất cả DB, hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("Bạn thực sự đã cân nhắc kỹ?", "Cảnh báo cấp 2", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim idSubject As String = e.Row.Cells(0).Value.ToString
                Dim idQuestion As String = e.Row.Cells(1).Value.ToString
                deleteQuestion(idQuestion, idSubject)
                loadQuestion()
                loadAnswer()
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub
    'xoa cau tra loi se xoa ca cau hoi va 3 cau tra loi con lai
    Private Sub dgvAnswerView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvAnswerView.UserDeletingRow
        If MessageBox.Show("Bạn muốn xoá bản ghi này, việc này ảnh hưởng tới tất cả DB, hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("Bạn thực sự đã cân nhắc kỹ?", "Cảnh báo cấp 2", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim idSubject As String = e.Row.Cells(0).Value.ToString
                Dim idQuestion As String = e.Row.Cells(1).Value.ToString
                deleteQuestion(idQuestion, idSubject)
                loadQuestion()
                loadAnswer()
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub deleteQuestion(idQuestion As String, idSubject As String)
        Dim cmd As SqlCommand
        cmd = New SqlCommand("delete from answer where idsubject = @idsubject and idquestion = @idquestion", connect)
        cmd.Parameters.AddWithValue("@idsubject", idSubject)
        cmd.Parameters.AddWithValue("@idquestion", idQuestion)
        cmd.ExecuteNonQuery()

        cmd = New SqlCommand("delete from question where idsubject = @idsubject and idquestion = @idquestion", connect)
        cmd.Parameters.AddWithValue("@idsubject", idSubject)
        cmd.Parameters.AddWithValue("@idquestion", idQuestion)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub loadComboBox()
        Dim arr1, arr2 As New ArrayList
        arr1.Add("ID")
        arr1.Add("CONTENT")
        arr2.Add("ID")
        arr2.Add("NAME")
        'cmbQuestionFilter.Text = "ID"
        'cmbSubjectFilter.Text = "ID"
        cmbQuestionFilter.DataSource = arr1
        cmbSubjectFilter.DataSource = arr2
    End Sub

    Private Sub filterByIdSubject(idSubjectFocus As String)
        Dim dvQuestion, dvAnswer, dvSubject As DataView
        dvSubject = New DataView(dtbSubject, "IDSubject = '" & idSubjectFocus & "'", "idsubject asc", DataViewRowState.CurrentRows)
        dvQuestion = New DataView(dtbQuestion, "IDSubject = '" & idSubjectFocus & "'", "idquestion asc", DataViewRowState.CurrentRows)
        dvAnswer = New DataView(dtbAnswer, "IDSubject = '" & idSubjectFocus & "'", "idquestion asc", DataViewRowState.CurrentRows)
        dgvQuestionView.DataSource = dvQuestion
        dgvAnswerView.DataSource = dvAnswer
        dgvSubjectView.DataSource = dvSubject
    End Sub

    Private Sub filterByNameSubject(nameSubject As String)
        Dim dvQuestion, dvAnswer As DataView
        dvQuestion = New DataView(dtbQuestion, "IDSubject like '" & nameSubject & "'", "idquestion asc", DataViewRowState.CurrentRows)
        dvAnswer = New DataView(dtbAnswer, "IDSubject like '" & nameSubject & "'", "idquestion asc", DataViewRowState.CurrentRows)
        dgvQuestionView.DataSource = dvQuestion
        dgvAnswerView.DataSource = dvAnswer
    End Sub

    Private Sub filterByIdSubjectQuestion(idSubjectFocus As String, idQuestionFocus As String)
        Dim dvSubject, dvAnswer, dvQuestion As DataView
        dvSubject = New DataView(dtbSubject, "idsubject = '" & idSubjectFocus & "'", "idsubject asc", DataViewRowState.CurrentRows)
        dvAnswer = New DataView(dtbAnswer, "idsubject = '" & idSubjectFocus & "' and idquestion = '" & idQuestionFocus & "'", "idanswer asc", DataViewRowState.CurrentRows)
        dvQuestion = New DataView(dtbQuestion, "idsubject = '" & idSubjectFocus & "' and idquestion = '" & idQuestionFocus & "'", "idquestion asc", DataViewRowState.CurrentRows)
        dgvSubjectView.DataSource = dvSubject
        dgvAnswerView.DataSource = dvAnswer
        dgvQuestionView.DataSource = dvQuestion
    End Sub
    ' chua hoan thien
    Private Sub filterByContentQuestion(content As String)
        Dim sql As String = "select * from Question where ContentQuestion like N'%" & content & "%'"
        Dim cmd As New SqlCommand(sql, connect)
        Dim adapter As New SqlDataAdapter
        Dim dataQuestion As New DataSet
        adapter.SelectCommand = cmd
        adapter.Fill(dataQuestion)
        dgvQuestionView.DataSource = dataQuestion.Tables(0)

        sql = "select * from subject where IDSubject = (select IDSubject from Question where ContentQuestion like N'%" & content & "%' group by IDSubject)"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        Dim dataSubject As New DataSet
        adapter.Fill(dataSubject)
        dgvSubjectView.DataSource = dataSubject.Tables(0)

        sql = "select * from Answer where " & _
            "IDSubject = (select IDSubject from Question where ContentQuestion like N'%" & content & "%' group by IDSubject) " & _
            "and IDQuestion in (select IDQuestion from Question where ContentQuestion like N'%" & content & "%')"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        Dim dataAnswer As New DataSet
        adapter.Fill(dataAnswer)
        dgvAnswerView.DataSource = dataAnswer.Tables(0)
    End Sub

    Private Sub filterByIDQuestion(idQuestion As String)
        Dim sql As String = "select * from Question where idquestion = " & idQuestion
        Dim cmd As New SqlCommand(sql, connect)
        Dim adapter As New SqlDataAdapter
        Dim dataQuestion As New DataSet
        adapter.SelectCommand = cmd
        adapter.Fill(dataQuestion)
        dgvQuestionView.DataSource = dataQuestion.Tables(0)

        sql = "select * from subject where IDSubject in (select idsubject from Question where idquestion = " & idQuestion & ")"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        Dim dataSubject As New DataSet
        adapter.Fill(dataSubject)
        dgvSubjectView.DataSource = dataSubject.Tables(0)

        sql = "select * from Answer where " & _
            "IDSubject in (select idsubject from Question where idquestion = " & idQuestion & ")" & _
            "and IDQuestion in (select IDQuestion from Question where idquestion = " & idQuestion & ")"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        Dim dataAnswer As New DataSet
        adapter.Fill(dataAnswer)
        dgvAnswerView.DataSource = dataAnswer.Tables(0)
    End Sub

    Private Sub filterByNameSubjectIdQuestion(nameSubject As String, idQuestion As String)
        Dim sql As String = "select * from subject where namesubject like N'%" & nameSubject & "%'"
        Dim cmd As New SqlCommand(sql, connect)
        Dim adapter As New SqlDataAdapter
        Dim dataSubject As New DataSet
        adapter.SelectCommand = cmd
        adapter.Fill(dataSubject)
        dgvSubjectView.DataSource = dataSubject.Tables(0)

        sql = "select * from question where IDSubject in (select idsubject from subject where namesubject like N'%" & nameSubject & "%')" & _
             "and idquestion = " & idQuestion
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        Dim dataQuestion As New DataSet
        adapter.Fill(dataQuestion)
        dgvQuestionView.DataSource = dataQuestion.Tables(0)

        sql = "select * from Answer where " & _
            "IDSubject in (select idsubject from subject where namesubject like N'%" & nameSubject & "%')" & _
            "and IDQuestion = " & idQuestion
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        Dim dataAnswer As New DataSet
        adapter.Fill(dataAnswer)
        dgvAnswerView.DataSource = dataAnswer.Tables(0)
    End Sub

    Private Sub filterByIdSubjectContentQuestion(idSubject As String, contentQuestion As String)
        Dim sql As String = "select * from subject where idsubject = '" & idSubject & "'"
        Dim cmd As New SqlCommand(sql, connect)
        Dim adapter As New SqlDataAdapter
        Dim dataSubject As New DataSet
        adapter.SelectCommand = cmd
        adapter.Fill(dataSubject)
        dgvSubjectView.DataSource = dataSubject.Tables(0)

        sql = "select * from question where contentquestion like N'%" & contentQuestion & "%'" & _
             "and idsubject = '" & idSubject & "'"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        Dim dataQuestion As New DataSet
        adapter.Fill(dataQuestion)
        dgvQuestionView.DataSource = dataQuestion.Tables(0)

        sql = "select * from Answer where " & _
            "idquestion in (select idquestion from question where contentquestion like N'%" & contentQuestion & "%' and idsubject = '" & idSubject & "')" & _
            "and idsubject = '" & idSubject & "'"
        cmd = New SqlCommand(sql, connect)
        adapter.SelectCommand = cmd
        Dim dataAnswer As New DataSet
        adapter.Fill(dataAnswer)
        dgvAnswerView.DataSource = dataAnswer.Tables(0)
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If (txtQuestionFilter.Text = "" And txtSubjectFilter.Text <> "") Then
            If (cmbSubjectFilter.Text = "ID") Then
                filterByIdSubject(txtSubjectFilter.Text)
            Else
                filterByNameSubject(txtSubjectFilter.Text)
            End If
        ElseIf (txtQuestionFilter.Text <> "" And txtSubjectFilter.Text <> "") Then
            If (cmbSubjectFilter.Text = "ID" And cmbQuestionFilter.Text = "ID") Then
                filterByIdSubjectQuestion(txtSubjectFilter.Text, txtQuestionFilter.Text)
            ElseIf (cmbQuestionFilter.Text = "ID" And cmbSubjectFilter.Text = "NAME") Then
                filterByNameSubjectIdQuestion(txtSubjectFilter.Text, txtQuestionFilter.Text)
            ElseIf (cmbQuestionFilter.Text = "CONTENT" And cmbSubjectFilter.Text = "ID") Then
                filterByIdSubjectContentQuestion(txtSubjectFilter.Text, txtQuestionFilter.Text)
            End If
        ElseIf (txtQuestionFilter.Text <> "" And txtSubjectFilter.Text = "") Then
            If (cmbQuestionFilter.Text = "CONTENT") Then
                filterByContentQuestion(txtQuestionFilter.Text)
            Else
                filterByIDQuestion(txtQuestionFilter.Text)
            End If
        Else
            MessageBox.Show("Hãy nhập từ khóa tìm kiếm (từ khóa sẽ được gợi ý), trước khi thực hiện lọc", "Lưu ý")
        End If
    End Sub

    Private Sub cmbSubjectFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjectFilter.SelectedIndexChanged
        Dim cmd As New SqlCommand("SELECT * FROM subject", connect)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "list")
        Dim col As New AutoCompleteStringCollection
        Dim i, count, index As Integer
        Dim table As DataTable = ds.Tables(0)
        count = ds.Tables(0).Rows.Count

        index = cmbSubjectFilter.SelectedIndex
        If (index = 0) Then
            For i = 0 To count - 1
                col.Add(table.Rows(i)("idsubject").ToString())
            Next
        ElseIf (index = 1) Then
            For i = 0 To count - 1
                col.Add(table.Rows(i)("namesubject").ToString())
            Next
        End If

        txtSubjectFilter.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSubjectFilter.AutoCompleteCustomSource = col
        txtSubjectFilter.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub cmbQuestionFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuestionFilter.SelectedIndexChanged
        Dim cmd As New SqlCommand("SELECT idquestion,contentquestion FROM question", connect)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "list")
        Dim col As New AutoCompleteStringCollection
        Dim i, count, index As Integer
        Dim table As DataTable = ds.Tables(0)
        count = ds.Tables(0).Rows.Count

        index = cmbQuestionFilter.SelectedIndex
        If (index = 0) Then
            For i = 0 To count - 1
                col.Add(table.Rows(i)("idquestion").ToString())
            Next
        ElseIf (index = 1) Then
            For i = 0 To count - 1
                col.Add(table.Rows(i)("contentquestion").ToString())
            Next
        End If

        txtQuestionFilter.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtQuestionFilter.AutoCompleteCustomSource = col
        txtQuestionFilter.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
End Class