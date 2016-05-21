Imports System.Data.SqlClient

Public Class SelectSubject


    Private Sub selectSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        loadDataToCmb()
    End Sub

    Private Sub loadDataToCmb()
        Dim con As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True")
        con.Open()
        Dim adapter As New SqlDataAdapter("select * from Subject", con)
        Dim table As New DataTable
        adapter.Fill(table)
        cmbSubject.DataSource = table
        cmbSubject.DisplayMember = "Namesubject"
        cmbSubject.ValueMember = "IDSubject"
        cmbSubject.AutoCompleteMode = AutoCompleteMode.Suggest
        cmbSubject.AutoCompleteSource = AutoCompleteSource.ListItems
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

End Class