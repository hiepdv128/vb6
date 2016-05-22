Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class DataUpdate
    Dim connect As New SqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AnswerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AnswerBindingSource.EndEdit()
    End Sub
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        'choose file
        If (edtLinkFile.Text = "") Then
            openFileDialog.ShowDialog()
        End If

        If (edtIDSubject.Text.Length > 0) Then
            If (Me.isIDSubjectExist(edtIDSubject.Text)) Then
                dgvSubject.Rows.Add(edtIDSubject.Text, edtNameSubject.Text)
            ElseIf (String.IsNullOrEmpty(edtNameSubject.Text)) Then
                MsgBox("Xin hãy nhập tên môn học!")
                edtNameSubject.Focus()
            End If

            Dim excel As Excel.Application
            Dim workBook As Excel.Workbook
            Dim workSheet As Excel.Worksheet
            Dim range, last_cell, first_cell, all_cell As Excel.Range
            'open excel application
            excel = New Excel.Application
            'open file excel
            workBook = excel.Workbooks.Open(edtLinkFile.Text)
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
            Dim change As Boolean = False
            Dim id_qs As Integer = getLastIDQuestion(edtIDSubject.Text) + 1
            Dim id_as As Integer = 1
            Dim correct As Integer

            max_cell = UBound(arr_cell, 1)
            For i = 1 To max_cell
                str = arr_cell.GetValue(i, 1).ToString.Trim

                'check row is question
                If (str.Contains(":") Or str.Contains("?")) Then
                    change = False
                    dgvQuestion.Rows.Add(edtIDSubject.Text, id_qs, str)
                Else
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
                    End If
                End If

            Next
            excel.Quit()

        Else
            MsgBox("Vui long nhap gia tri cho Subject")
            edtIDSubject.Focus()
        End If
    End Sub


    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        'openfile
        openFileDialog.ShowDialog()
    End Sub

    Private Sub openFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles openFileDialog.FileOk
        edtLinkFile.Text = sender.FileName()

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim constring As String = "Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True"
        Dim con As New SqlConnection(constring)
        con.Open()
        Dim index As Integer
        Dim content As String

        'add to subject table
        If (Not isIDSubjectExist(edtIDSubject.Text)) Then
            Dim subjectRow As DataGridViewRow = dgvSubject.Rows(0)
            Dim subjectCommand As New SqlCommand("insert into subject values(@idsubject,@namesubject)", con)
            subjectCommand.Parameters.AddWithValue("@idsubject", subjectRow.Cells("IDSubject").Value)
            subjectCommand.Parameters.AddWithValue("@namesubject", subjectRow.Cells("NameSubject").Value)
            subjectCommand.ExecuteNonQuery()
            dgvSubject.Rows.Clear()
        End If

        'add to question table
        Dim questionrows As Integer = dgvQuestion.Rows.Count - 2
        For index = 0 To questionrows
            Dim row As DataGridViewRow = dgvQuestion.Rows(index)
            Using cmd As New SqlCommand("insert into question values(@idsubject, @idquestion, @content)", con)
                cmd.Parameters.AddWithValue("@idsubject", row.Cells("idsubjectquestion").Value)
                cmd.Parameters.AddWithValue("@idquestion", row.Cells("idquestion").Value)
                content = row.Cells("contentquestion").Value
                content = content.Substring(InStr(content, " ")).Trim
                cmd.Parameters.AddWithValue("@content", content)
                cmd.ExecuteNonQuery()
            End Using
        Next
        dgvQuestion.Rows.Clear()

        'add to answer table
        Dim answerRows As Integer = dgvAnswer.Rows.Count - 2
        For index = 0 To answerRows
            Dim row As DataGridViewRow = dgvAnswer.Rows(index)
            Using cmd As New SqlCommand("INSERT INTO Answer VALUES(@IdSubject, @IDQuestion, @Content,@Correct)", con)
                cmd.Parameters.AddWithValue("@IdSubject", row.Cells("IDQuestionAnswer").Value)
                cmd.Parameters.AddWithValue("@IDQuestion", row.Cells("IDAnswer").Value)
                content = row.Cells("ContentAnswer").Value
                content = content.Substring(InStr(content, " ")).Trim
                cmd.Parameters.AddWithValue("@Content", content)
                cmd.Parameters.AddWithValue("@Correct", row.Cells("Correct").Value)
                cmd.ExecuteNonQuery()
            End Using
        Next
        dgvAnswer.Rows.Clear()

        con.Close()
        MessageBox.Show("Records inserted.")

    End Sub

    Function getLastIDQuestion(idSubject As String) As Integer
        Dim lastID As Integer = 0
        Dim constring As String = "Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True"
        Dim con As New SqlConnection(constring)
        con.Open()
        Dim cmd As New SqlCommand("select max(idquestion) from question where idsubject = @idsubject", con)
        cmd.Parameters.AddWithValue("@idsubject",idSubject)
        Dim result As String
        result = cmd.ExecuteScalar().ToString
        If (Not String.IsNullOrEmpty(result)) Then
            lastID = Val(result)
        End If
        con.Close()
        Return lastID
    End Function

    Function isIDSubjectExist(idSubject As String) As Boolean
        Dim constring As String = "Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True"
        Dim con As New SqlConnection(constring)
        con.Open()
        Dim cmd As New SqlCommand("select namesubject from subject where idsubject = '" & idSubject & "'", con)

        Try
            Dim result As String = cmd.ExecuteScalar().ToString

            If (Not String.IsNullOrEmpty(result)) Then
                edtNameSubject.Text = result
                Return True
            End If
            con.Close()
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function


    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'ViewData.MdiParent = Me
        ViewData.Show()
    End Sub
End Class