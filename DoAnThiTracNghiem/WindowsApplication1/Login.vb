Imports System.Data.SqlClient

Public Class Login
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True")

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.Open()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (String.IsNullOrEmpty(txtPass.Text) Or String.IsNullOrEmpty(txtUser.Text)) Then
            MsgBox("Vui lòng nhập đầy đủ thông tin!")
            Exit Sub
        End If

        Dim cmd As New SqlCommand("select password from alluser where username = @username", connect)
        cmd.Parameters.AddWithValue("@username", txtUser.Text)
        Dim result As String = cmd.ExecuteScalar().ToString

        If (result.Equals(txtPass.Text)) Then
            MsgBox("Bạn đã đăng nhập thành công!",MsgBoxStyle.Information)
            SelectSubject.Show()
            SelectSubject.user = txtUser.Text
            Test.user = txtUser.Text
            Me.Hide()
        End If


    End Sub

    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        About.Show()
    End Sub

    Private Sub Login_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Bạn muốn thoát ứng dụng ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            connect.Close()
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub

End Class