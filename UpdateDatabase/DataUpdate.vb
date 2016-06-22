Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class DataUpdate
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True;MultipleActiveResultSets=True")

    Private Sub DataUpdate_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If (Me.Visible) Then
            connect.Open()
            AutoCompeleteSubject()
        End If
    End Sub

    Private Sub AutoCompeleteSubject()
        Dim cmd As SqlCommand
        Dim data As New DataSet
        Dim adapter As New SqlDataAdapter
        Dim colection As New AutoCompleteStringCollection
        Dim i, count As Integer
        Dim table As DataTable
        Dim query As String = "SELECT IDSUBJECT FROM SUBJECT"

        cmd = New SqlCommand(query, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(data)
        table = data.Tables(0)
        count = table.Rows.Count
        For i = 0 To count - 1
            colection.Add(table.Rows(i)(0).ToString())
        Next
        txtIDSubject.AutoCompleteCustomSource.Clear()
        txtIDSubject.AutoCompleteCustomSource = colection
    End Sub

    'Private Sub AnswerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.AnswerBindingSource.EndEdit()
    'End Sub

    Private Sub txtIDSubject_Leave(sender As Object, e As EventArgs) Handles txtIDSubject.Leave
        Dim id As String = txtIDSubject.Text
        Dim cmd As New SqlCommand("select namesubject from subject where idsubject = '" & id & "'", connect)
        Try
            Dim result As String = cmd.ExecuteScalar().ToString
            If (Not String.IsNullOrEmpty(result)) Then
                txtNameSubject.Text = result
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        'choose file
        If (txtLinkFile.Text = "") Then
            openFileDialog.ShowDialog()
        End If

        If (txtIDSubject.Text.Length > 0) Then
            If (txtNameSubject.Text.Length > 0) Then
                dgvSubject.Rows.Add(txtIDSubject.Text, txtNameSubject.Text)

                Dim excel As Excel.Application
                Dim workBook As Excel.Workbook
                Dim workSheet As Excel.Worksheet
                Dim range, last_cell, first_cell, all_cell As Excel.Range
                'open excel application
                excel = New Excel.Application
                'open file excel
                workBook = excel.Workbooks.Open(txtLinkFile.Text)
                'open sheet
                workSheet = workBook.Worksheets(1)
                range = workSheet.Columns(1)

                first_cell = workSheet.Cells(1, 1)
                last_cell = range.End(Microsoft.Office.Interop.Excel.XlDirection.xlDown)
                all_cell = workSheet.Range(first_cell, last_cell)
                Dim arr_cell As Object(,)
                arr_cell = all_cell.Value2()

                Dim i, max_cell As Integer
                Dim str As String
                Dim change As Boolean = True
                Dim id_qs As Integer = getLastIDQuestion() + 1
                Dim id_as As Integer = 1
                Dim correct As Integer

                max_cell = UBound(arr_cell, 1)

                'check file is hop le
                Try
                    For i = 1 To max_cell
                        str = arr_cell.GetValue(i, 1).ToString.Trim

                        'check row is question
                        'change de kiem tra da doc het 4 cau tra loi chua
                        If (str.Substring(str.Length - 1).Equals(":") Or str.Substring(str.Length - 1).Equals("?") And change = True) Then
                            change = False
                            dgvQuestion.Rows.Add(txtIDSubject.Text, id_qs, str)
                        ElseIf (Not change) Then
                            If (str.Substring(str.Length - 1).Equals("*")) Then
                                correct = 1
                                'delete symbol '*'
                                str = str.Substring(0, str.Length - 1)
                            Else
                                correct = 0
                            End If

                            dgvAnswer.Rows.Add(id_qs, id_qs & "" & id_as, str, correct)
                            If (id_as < 4) Then
                                id_as = id_as + 1
                            Else
                                id_as = 1
                                id_qs = id_qs + 1
                                change = True
                            End If
                        End If
                    Next
                    excel.Quit()
                Catch ex As Exception
                    MessageBox.Show("Bạn đã nhập vào file không đúng định dạng!", "Lưu ý")
                    btnReset.PerformClick()
                End Try

                If (dgvQuestion.RowCount = 0 OrElse dgvAnswer.RowCount = 0) Then
                    MessageBox.Show("Bạn đã nhập vào file không đúng định dạng!", "Lưu ý")
                    btnReset.PerformClick()
                End If

            Else
                MessageBox.Show("Vui lòng nhập tên môn học", "Lưu ý")
                txtNameSubject.Focus()
            End If

        Else
            MessageBox.Show("Xin hãy nhập ID môn học!", "Lưu ý")
            txtIDSubject.Focus()
        End If
    End Sub


    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        'openfile
        openFileDialog.ShowDialog()
    End Sub

    Private Sub openFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles openFileDialog.FileOk
        txtLinkFile.Text = sender.FileName()

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim index As Integer
        Dim content As String

        If (dgvSubject.Rows.Count = 0) Then
            MessageBox.Show("Bạn hãy lựa chọn file trước khi thêm vào db", "Nhắc nhở")
            Exit Sub
        End If

        'add to subject table
        If (Not isIDSubjectExist(txtIDSubject.Text.Trim)) Then
            Dim subjectRow As DataGridViewRow = dgvSubject.Rows(0)
            Dim subjectCommand As New SqlCommand("insert into subject values(@idsubject,@namesubject)", connect)
            subjectCommand.Parameters.AddWithValue("@idsubject", subjectRow.Cells("IDSubject").Value)
            subjectCommand.Parameters.AddWithValue("@namesubject", subjectRow.Cells("NameSubject").Value)
            subjectCommand.ExecuteNonQuery()
        End If
        dgvSubject.Rows.Clear()

        'add to question table
        Dim questionrows As Integer = dgvQuestion.Rows.Count - 2
        For index = 0 To questionrows
            Dim row As DataGridViewRow = dgvQuestion.Rows(index)
            Try
                Using cmd As New SqlCommand("insert into question values(@idsubject, @idquestion, @content)", connect)
                    cmd.Parameters.AddWithValue("@idsubject", row.Cells("idsubjectquestion").Value)
                    cmd.Parameters.AddWithValue("@idquestion", row.Cells("idquestion").Value)
                    content = row.Cells("contentquestion").Value
                    content = content.Substring(InStr(content, " ")).Trim
                    cmd.Parameters.AddWithValue("@content", content)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
        dgvQuestion.Rows.Clear()

        'add to answer table
        Dim answerRows As Integer = dgvAnswer.Rows.Count - 2
        For index = 0 To answerRows
            Dim row As DataGridViewRow = dgvAnswer.Rows(index)
            Try
                Using cmd As New SqlCommand("INSERT INTO Answer VALUES(@IDQuestion,@IDAnswer, @Content,@Correct)", connect)
                    cmd.Parameters.AddWithValue("@IDQuestion", row.Cells("IDQuestionAnswer").Value)
                    cmd.Parameters.AddWithValue("@IDAnswer", row.Cells("IDAnswer").Value)
                    content = row.Cells("ContentAnswer").Value
                    content = content.Substring(InStr(content, " ")).Trim
                    cmd.Parameters.AddWithValue("@Content", content)
                    cmd.Parameters.AddWithValue("@Correct", row.Cells("Correct").Value)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception

            End Try
        Next
        dgvAnswer.Rows.Clear()

        txtIDSubject.Text = ""
        txtLinkFile.Text = ""
        txtNameSubject.Text = ""

        MessageBox.Show("Records inserted.")
    End Sub

    Function getLastIDQuestion() As Integer
        Dim lastID As Integer = 0
        Dim cmd As New SqlCommand("select max(idquestion) from question", connect)
        Dim result As String
        result = cmd.ExecuteScalar().ToString
        If (Not String.IsNullOrEmpty(result)) Then
            lastID = Val(result)
        End If
        Return lastID
    End Function

    Function isIDSubjectExist(idSubject As String) As Boolean
        Dim cmd As New SqlCommand("select namesubject from subject where idsubject = '" & idSubject & "'", connect)

        Try
            Dim result As String = cmd.ExecuteScalar().ToString

            If (Not String.IsNullOrEmpty(result)) Then
                txtNameSubject.Text = result
                Return True
            End If
            'connect.Close()
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtIDSubject.Text = ""
        txtLinkFile.Text = ""
        txtNameSubject.Text = ""
        dgvAnswer.Rows.Clear()
        dgvQuestion.Rows.Clear()
        dgvSubject.Rows.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        connect.Close()
        Me.Hide()
        ShowMenu.Show()
    End Sub

    Private Sub ViewUser_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If MessageBox.Show("Bạn có chắc muốn đóng chương trình?", "Warning", MessageBoxButtons.YesNo, _
        '                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    connect.Close()
        '    End
        'Else
        '    e.Cancel = True
        'End If
        connect.Close()
        Me.Hide()
        ShowMenu.Show()
    End Sub


End Class