Imports System.Data.SqlClient

Public Class Achievement
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True;MultipleActiveResultSets=True")
    Friend user As String

    Private Sub ThanhTich_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If (Me.Visible) Then
            Me.user = SelectSubject.user
            connect.Open()
            Dim command As New SqlCommand("select NameSubject, Mark, TimeTest from Subject, Mark where Mark.IdSubject = Subject.IDSubject and UserName = '" & user & "'", connect)
            Dim adapter As New SqlDataAdapter(command)
            Dim data As New DataSet
            adapter.Fill(data)
            If (data.Tables(0).Rows.Count <= 0) Then
                If MessageBox.Show("Bạn chưa thi lần nào, vào thi ngay?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    SelectSubject.Show()
                    Me.Hide()
                End If
            Else
                dgvAchieve.DataSource = data.Tables(0)
            End If
        End If
    End Sub

    Private Sub ThisForm_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If MessageBox.Show("Bạn muốn thoát ứng dụng ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    connect.Close()
        '    End
        'Else
        '    e.Cancel = True
        'End If
        connect.Close()
        Me.Hide()
        SelectSubject.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        connect.Close()
        Me.Hide()
        SelectSubject.Show()
    End Sub

End Class