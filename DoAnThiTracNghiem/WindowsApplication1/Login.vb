Imports System.Data.SqlClient
Public Class Login
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Me.CenterToScreen()
        Dim connectstring As String = "Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True"
        Dim con As New SqlConnection(connectstring)
        con.Open()
        Dim cmd As New SqlCommand("select password from alluser where username = @username", con)
        cmd.Parameters.AddWithValue("@username", txtUser.Text)
        Dim result As String = cmd.ExecuteScalar().ToString

        If (result.Equals(txtPass.Text)) Then
            MsgBox("dang nhap thanh cong")
            SelectSubject.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        About.Show()
    End Sub
End Class