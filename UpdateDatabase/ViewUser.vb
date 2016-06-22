Imports System.Data.SqlClient

Public Class ViewUser
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True;MultipleActiveResultSets=True")
    Private tableUser, tableMark As New DataTable


    Private Sub ViewUser_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If (Me.Visible) Then
            connect.Open()
            cmbMode.SelectedIndex = 0
            loadGirdview()
        End If
    End Sub

    Private Sub loadGirdview()

        Dim queryUser, queryMark As String
        Dim cmdUser, cmdMark As SqlCommand
        Dim adapterUser, adapterMark As New SqlDataAdapter()
        Dim setUser, setMark As New DataSet

        queryUser = "SELECT * FROM ALLUSER"
        cmdUser = New SqlCommand(queryUser, connect)
        adapterUser.SelectCommand = cmdUser
        adapterUser.Fill(setUser)
        Me.tableUser = setUser.Tables(0)
        dgvUser.DataSource = Me.tableUser

        queryMark = "SELECT USERNAME, MARK,TIMETEST, NAMESUBJECT,MARK.IDSUBJECT FROM MARK, SUBJECT " & _
                    "WHERE MARK.IDSUBJECT = SUBJECT.IDSUBJECT"
        cmdMark = New SqlCommand(queryMark, connect)
        adapterMark.SelectCommand = cmdMark
        adapterMark.Fill(setMark)
        Me.tableMark = setMark.Tables(0)
        dgvMark.DataSource = Me.tableMark

    End Sub

    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged
        Dim cmd As SqlCommand
        Dim data As New DataSet
        Dim adapter As New SqlDataAdapter
        Dim colection As New AutoCompleteStringCollection
        Dim i, count, index As Integer
        Dim table As DataTable
        Dim query As String = ""

        index = cmbMode.SelectedIndex
        If (index = 0) Then
            query = "SELECT USERNAME FROM ALLUSER"
        ElseIf (index = 1) Then
            query = "SELECT IDSUBJECT FROM SUBJECT"
        End If
        cmd = New SqlCommand(query, connect)
        adapter.SelectCommand = cmd
        adapter.Fill(data)
        table = data.Tables(0)
        count = table.Rows.Count
        For i = 0 To count - 1
            colection.Add(table.Rows(i)(0).ToString())
        Next
        txtSearch.AutoCompleteCustomSource = colection
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        loadGirdview()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim cmdUser, cmdMark As SqlCommand
        Dim setUser, setMark As New DataSet
        Dim adapterUser, adapterMark As New SqlDataAdapter
        Dim queryUser, queryMark As String

        If (cmbMode.SelectedIndex = 0) Then
            queryUser = "SELECT * FROM ALLUSER WHERE USERNAME = '" & txtSearch.Text & "'"
            queryMark = "SELECT USERNAME, MARK,TIMETEST, NAMESUBJECT,MARK.IDSUBJECT FROM MARK, SUBJECT " & _
                            " WHERE MARK.IDSUBJECT = SUBJECT.IDSUBJECT AND USERNAME = '" & txtSearch.Text & "'"
        Else
            queryUser = "SELECT * FROM ALLUSER WHERE USERNAME IN " & _
                        "(SELECT USERNAME FROM MARK WHERE IDSUBJECT = '" & txtSearch.Text & "')"
            queryMark = "SELECT USERNAME, MARK,TIMETEST, NAMESUBJECT,MARK.IDSUBJECT FROM MARK, SUBJECT " & _
                    "WHERE MARK.IDSUBJECT = SUBJECT.IDSUBJECT AND MARK.IDSUBJECT = '" & txtSearch.Text & "'"
        End If
        cmdUser = New SqlCommand(queryUser, connect)
        cmdMark = New SqlCommand(queryMark, connect)
        adapterUser.SelectCommand = cmdUser
        adapterMark.SelectCommand = cmdMark
        adapterMark.Fill(setMark)
        adapterUser.Fill(setUser)
        If (setMark.Tables(0).Rows.Count = 0 And setUser.Tables(0).Rows.Count = 0) Then
            MessageBox.Show("Dữ liệu bạn nhập không khớp bản ghi nào!", "Thông báo")
        Else
            dgvMark.DataSource = setMark.Tables(0)
            dgvUser.DataSource = setUser.Tables(0)
        End If
    End Sub

    Private Sub dgvMark_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMark.RowHeaderMouseDoubleClick
        Dim count As Integer = dgvMark.RowCount
        Dim subjectFocus As String
        If (e.RowIndex < count - 1) Then
            subjectFocus = dgvMark.Rows(e.RowIndex).Cells(4).Value.ToString
            cmbMode.SelectedIndex = 1
            txtSearch.Text = subjectFocus
            btnFilter.PerformClick()
        End If
    End Sub

    Private Sub dgvUser_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUser.RowHeaderMouseDoubleClick
        Dim count As Integer = dgvUser.RowCount
        Dim userFocus As String
        If (e.RowIndex < count - 1) Then
            userFocus = dgvUser.Rows(e.RowIndex).Cells(1).Value.ToString
            cmbMode.SelectedIndex = 0
            txtSearch.Text = userFocus
            btnFilter.PerformClick()
        End If
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        connect.Close()
        Me.Hide()
        AddUser.Show()
    End Sub

    Private Sub dgvUser_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvUser.UserDeletingRow
        If MessageBox.Show("Bạn muốn xoá bản ghi này, việc này ảnh hưởng tới tất cả DB, " & _
                           "hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("Bạn thực sự đã cân nhắc kỹ?", "Cảnh báo cấp 2", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim user As String = e.Row.Cells(0).Value.ToString
                Dim cmdUser, cmdMark As SqlCommand
                Dim queryUser, queryMark As String
                queryUser = "DELETE FROM ALLUSER WHERE USERNAME = '" & user & "'"
                queryMark = "DELETE FROM MARK WHERE USERNAME = '" & user & "'"
                cmdUser = New SqlCommand(queryUser, connect)
                cmdMark = New SqlCommand(queryMark, connect)
                cmdMark.ExecuteNonQuery()
                cmdUser.ExecuteNonQuery()
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub dgvMark_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvMark.UserDeletingRow
        If MessageBox.Show("Bạn muốn xoá bản ghi này, việc này ảnh hưởng tới tất cả DB, " & _
                           "hành động này không thể undo. Bạn đã cân nhắc kỹ?", "Warning", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("Bạn thực sự đã cân nhắc kỹ?", "Cảnh báo cấp 2", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim user As String = e.Row.Cells(0).Value.ToString
                Dim idSubject As String = e.Row.Cells(4).Value.ToString
                Dim cmdMark As SqlCommand
                Dim queryMark As String

                queryMark = "DELETE FROM MARK WHERE USERNAME = @USER AND IDSUBJECT = @IDSUBJECT"
                cmdMark = New SqlCommand(queryMark, connect)
                cmdMark.Parameters.AddWithValue("@USER", user)
                cmdMark.Parameters.AddWithValue("@IDSUBJECT", idSubject)
                cmdMark.ExecuteNonQuery()
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ViewQuestion_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        connect.Close()
        Me.Hide()
        ShowMenu.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        connect.Close()
        Me.Hide()
        ShowMenu.Show()
    End Sub


End Class