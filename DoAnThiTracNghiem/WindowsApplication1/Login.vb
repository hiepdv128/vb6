Imports System.Data.SqlClient
Public Class login
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim connectstring As String = "Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True"
        Dim con As New SqlConnection(connectstring)
        con.Open()
        Dim cmd As New SqlCommand("select password from alluser where username = @username", con)
        cmd.Parameters.AddWithValue("@username", txtUser.Text)
        Dim result As String = cmd.ExecuteScalar().ToString

        If (result.Equals(txtPass.Text)) 
            MsgBox("Dang nhap thanh cong")
        End If
    End Sub

    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        about.Show()
    End Sub
End Class