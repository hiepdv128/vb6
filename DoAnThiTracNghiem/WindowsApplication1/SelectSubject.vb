Imports System.Data.SqlClient

Public Class SelectSubject
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True;MultipleActiveResultSets=True")
    Friend user As String

    Private Sub selectSubject_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If (Me.Visible) Then
            connect.Open()
            Me.user = Login.txtUser.Text
            loadDataToFrom()
        End If
    End Sub

    Private Sub loadDataToFrom()
        'Load to combo box
        Dim adapter As New SqlDataAdapter("select * from Subject", connect)
        Dim table As New DataTable
        adapter.Fill(table)
        cmbSubject.DataSource = table
        cmbSubject.DisplayMember = "Namesubject"
        cmbSubject.ValueMember = "IDSubject"
        cmbSubject.AutoCompleteMode = AutoCompleteMode.Suggest
        cmbSubject.AutoCompleteSource = AutoCompleteSource.ListItems

        'Load info of user
        Dim cmd As New SqlCommand("select name,sex,birthday from alluser where username='" & user & "'", connect)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        'Try
        reader.Read()
        lblName.Text = reader.GetValue(0).ToString
        lblSex.Text = reader.GetValue(1).ToString
        lblBirthday.Text = reader.GetValue(2).ToString().Remove(10, 12)
        'Catch ex As Exception
        '    MsgBox("Lấy dữ liệu lỗi!")
        'End Try
        adapter = Nothing
        cmd = Nothing
    End Sub


    Private Sub txtNumOfQuestion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumOfQuestion.KeyPress
        If (Char.IsDigit(e.KeyChar) Or (Char.IsControl(e.KeyChar))) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMinute_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinute.KeyPress
        If (Char.IsDigit(e.KeyChar) Or (Char.IsControl(e.KeyChar))) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumOfQuestion_TextChanged(sender As Object, e As EventArgs) Handles txtNumOfQuestion.TextChanged
        Dim num As Integer
        num = Val(txtNumOfQuestion.Text)
        If (num > 50) Then
            MsgBox("Số câu hỏi nhỏ hơn 50! Xin nhập lại")
            txtNumOfQuestion.Text = ""
        Else
            Test.setNumOfQuestion(num)
        End If
    End Sub

    Private Sub txtMinute_TextChanged(sender As Object, e As EventArgs) Handles txtMinute.TextChanged
        Dim num As Integer
        num = Val(txtMinute.Text)
        If (num > 60) Then
            MsgBox("Thời gian phải nhỏ hơn 60 phút! Xin nhập lại")
            txtMinute.Text = ""
        Else
            Test.setTime(num)
        End If
    End Sub

    Private Sub SelectSubject_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Bạn muốn thoát ứng dụng ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            connect.Close()
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnBeginTest_Click(sender As Object, e As EventArgs) Handles btnBeginTest.Click
        If (String.IsNullOrEmpty(txtMinute.Text) Or String.IsNullOrEmpty(txtNumOfQuestion.Text) Or String.IsNullOrEmpty(cmbSubject.Text)) Then
            MessageBox.Show("Xin hãy điền đầy đủ thông tin bài thi!")
        Else
            If (String.IsNullOrEmpty(cmbSubject.SelectedValue)) Then
                MsgBox("Bạn nhập sai tên môn học! Hãy chọn lại")
                Return
            End If

            If MessageBox.Show("Bạn đã chắc chắn bắt đầu thi? Nếu muốn đổi môn thi hãy nhấn NO", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Test.setNumOfQuestion(Integer.Parse(txtNumOfQuestion.Text))
                Test.setTime(Integer.Parse(txtMinute.Text))
                Test.setIDSubject(cmbSubject.SelectedValue)
                Test.lblNameSubject.Text = cmbSubject.Text
                connect.Close()
                Test.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub cmbSubject_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSubject.KeyPress
        e.Handled = False
    End Sub

    Private Sub lblThanhTich_Click(sender As Object, e As EventArgs) Handles lblThanhTich.Click
        Dim command As New SqlCommand("select * from mark where username = '" & user & "'", connect)
        If (String.IsNullOrEmpty(command.ExecuteScalar)) Then
            MessageBox.Show("Bạn chưa thi lần nào, hãy vào thi ngay!", "Nhắc nhở")
        Else
            connect.Close()
            ThanhTich.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        connect.Close()
        Me.Hide()
        Me.user = ""
        Login.Show()
    End Sub

End Class