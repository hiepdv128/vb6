Imports System.Data.SqlClient

Public Class Login
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True")

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.Open()
        txtUser.Focus()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (String.IsNullOrEmpty(txtPass.Text) Or String.IsNullOrEmpty(txtUser.Text)) Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo")
            Exit Sub
        End If

        Dim cmd As New SqlCommand("select password from alluser where username = @username", connect)
        cmd.Parameters.AddWithValue("@username", txtUser.Text)

        Dim result As String = ""
        If String.IsNullOrEmpty(cmd.ExecuteScalar()) Then
            MsgBox("Tên tài khoản hoặc mật khẩu không tồn tại!")
            Exit Sub
        Else
            result = cmd.ExecuteScalar().ToString
        End If

        If (result.Equals(txtPass.Text)) Then
            MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo")
            SelectSubject.Show()
            SelectSubject.user = txtUser.Text
            Test.user = txtUser.Text
            Me.Hide()
        Else
            MsgBox("Tên tài khoản hoặc mật khẩu không tồn tại!")
        End If

    End Sub

    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        About.Show()
    End Sub

    Private Sub Login_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Bạn muốn thoát ứng dụng ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            connect.Close()
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub

End Class