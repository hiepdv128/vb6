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
        Dim userSignUp As String = txtUser.Text.Trim
        Dim passSignUp As String = txtPass.Text.Trim
        Dim passReturn As String = txtPassReturn.Text.Trim
        Dim nameSignUp As String = txtName.Text.Trim
        Dim sex As String = cmbSex.Text
        Dim birthdaySignUp As String = cmbMonth.Text & "/" & cmbDay.Text & "/" & cmbYear.Text

        If (Not passSignUp.Equals("")) And (Not userSignUp.Equals("")) _
            And (Not passReturn.Equals("")) And (Not nameSignUp.Equals("")) Then

            Dim cmdCheck As New SqlCommand("select password from alluser where username = @username", connect)
            cmdCheck.Parameters.AddWithValue("@username", txtUser.Text)
            Dim result As String = cmdCheck.ExecuteScalar()

            If (String.IsNullOrEmpty(result) And (passSignUp.Equals(passReturn)) _
                And (Not userSignUp.Contains(" ")) And (Not passSignUp.Contains(" "))) Then
                Dim cmdInsert As New SqlCommand("INSERT INTO ALLUSER VALUES (@user,@password,@name,@sex,@birthday)", connect)
                cmdInsert.Parameters.AddWithValue("@user", userSignUp)
                cmdInsert.Parameters.AddWithValue("@password", passSignUp)
                cmdInsert.Parameters.AddWithValue("@name", nameSignUp)
                cmdInsert.Parameters.AddWithValue("@sex", nameSignUp)
                cmdInsert.Parameters.AddWithValue("@birthday", birthdaySignUp)
                cmdInsert.ExecuteNonQuery()

                MsgBox("Đăng ký thành công tài khooản :" & userSignUp)
                Login.txtUser.Text = userSignUp
                Login.txtPass.Text = passSignUp
                Me.Hide()
                Login.Show()

            ElseIf (Not String.IsNullOrEmpty(result)) Then
                MsgBox("Tên tài khoản đã tồn tại, mời chọn tên khác")
                txtUser.Text = ""
                txtUser.Focus()

            ElseIf (userSignUp.Contains(" ") Or passSignUp.Contains(" ")) Then
                MsgBox("Tên tài khoản hoặc mật khẩu không chứa dấu SPACE")
                txtUser.Text = ""
                txtPassReturn.Text = ""
                txtPass.Text = ""
                txtUser.Focus()
            ElseIf (Not passSignUp.Equals(passReturn)) Then
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
        If MessageBox.Show("Bạn muốn thoát ứng dụng?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                End
            Catch ex As Exception
                Stop
            End Try
        Else
            e.Cancel = True
        End If
    End Sub

End Class