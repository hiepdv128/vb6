Imports System.Data.SqlClient

Public Class SignUp
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True;MultipleActiveResultSets=True")

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        loadCombobox()
        connect.Open()

    End Sub

    Private Sub loadCombobox()

        cmbSex.Items.Add("Nam")
        cmbSex.Items.Add("Nữ")
        cmbSex.SelectedIndex = 0

        'load date
        For i = 1 To 31
            cmbDay.Items.Add(i)
        Next
        cmbDay.SelectedIndex = 0

        'load Month
        For i = 1 To 12
            cmbMonth.Items.Add(i)
        Next
        cmbMonth.SelectedIndex = 0

        'load date
        For i = 1990 To 2010
            cmbYear.Items.Add(i)
        Next
        cmbYear.SelectedIndex = 0
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUser.Text = ""
        txtPassReturn.Text = ""
        txtPass.Text = ""
        txtName.Text = ""
    End Sub

    Private Sub btnCompeleteSignup_Click(sender As Object, e As EventArgs) Handles btnCompeleteSignup.Click
        Dim user As String = txtUser.Text.Trim
        Dim password As String = txtPass.Text.Trim
        Dim passReturn As String = txtPassReturn.Text.Trim
        Dim fullName As String = txtName.Text.Trim
        Dim sex As String = cmbSex.Text
        Dim birthday As String = cmbMonth.Text & "/" & cmbDay.Text & "/" & cmbYear.Text

        If (Not password.Equals("")) And (Not user.Equals("")) _
            And (Not passReturn.Equals("")) And (Not fullName.Equals("")) Then

            Dim cmdCheck As New SqlCommand("select password from alluser where username = @username", connect)
            cmdCheck.Parameters.AddWithValue("@username", txtUser.Text)
            Dim result As String = cmdCheck.ExecuteScalar()

            If (String.IsNullOrEmpty(result) And (password.Equals(passReturn, StringComparison.Ordinal)) _
                And (Not user.Contains(" ")) And (Not password.Contains(" "))) Then
                Dim cmdInsert As New SqlCommand("INSERT INTO ALLUSER VALUES (@user,@password,@name,@sex,@birthday)", connect)
                cmdInsert.Parameters.AddWithValue("@user", user)
                cmdInsert.Parameters.AddWithValue("@password", password)
                cmdInsert.Parameters.AddWithValue("@name", fullName)
                cmdInsert.Parameters.AddWithValue("@sex", sex)
                cmdInsert.Parameters.AddWithValue("@birthday", birthday)
                cmdInsert.ExecuteNonQuery()

                MsgBox("Đăng ký thành công tài khooản :" & user)
                Login.txtUser.Text = user
                Login.txtPass.Text = password
                Me.Hide()
                Login.Show()

            ElseIf (Not String.IsNullOrEmpty(result)) Then
                MsgBox("Tên tài khoản đã tồn tại, mời chọn tên khác")
                txtUser.Text = ""
                txtUser.Focus()

            ElseIf (user.Contains(" ") Or password.Contains(" ")) Then
                MsgBox("Tên tài khoản hoặc mật khẩu không chứa dấu SPACE")
                txtUser.Text = ""
                txtPassReturn.Text = ""
                txtPass.Text = ""
                txtUser.Focus()
            ElseIf (Not password.Equals(passReturn)) Then
                MsgBox("Mật khẩu nhập lại không giống nhau! Xin nhập lại")
                txtPassReturn.Text = ""
                txtPass.Text = ""
                txtPass.Focus()
            End If

        Else
            MsgBox("Bạn hãy điền đầy đủ thông tin trước khi nhấn Đăng Ký")

        End If
    End Sub

    Private Sub SignUp_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        connect.Close()
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        connect.Close()
        Me.Hide()
        Login.Show()
    End Sub
End Class