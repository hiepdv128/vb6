Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class AddUser
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True;MultipleActiveResultSets=True")

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



    Private Sub btnCompeleteSignup_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim user As String = txtUser.Text
        Dim password As String = txtPass.Text
        Dim passReturn As String = txtPassReturn.Text
        Dim name As String = txtName.Text.Trim
        Dim sex As String = cmbSex.Text
        Dim birthday As String = cmbMonth.Text & "/" & cmbDay.Text & "/" & cmbYear.Text

        If (Not password.Equals("")) And (Not user.Equals("")) _
            And (Not passReturn.Equals("")) And (Not name.Equals("")) Then

            Dim cmdCheck As New SqlCommand("select password from alluser where username = @username", connect)
            cmdCheck.Parameters.AddWithValue("@username", txtUser.Text)
            Dim result As String = cmdCheck.ExecuteScalar()

            If (String.IsNullOrEmpty(result) And (password.Equals(passReturn, StringComparison.Ordinal)) _
                And Not Regex.Match(user, "[^a-zA-Z0-9_]+").Success And Not Regex.Match(password, "[^a-zA-Z0-9_]+").Success) Then
                Dim cmdInsert As New SqlCommand("INSERT INTO ALLUSER VALUES (@user,@password,@name,@sex,@birthday)", connect)
                cmdInsert.Parameters.AddWithValue("@user", user)
                cmdInsert.Parameters.AddWithValue("@password", password)
                cmdInsert.Parameters.AddWithValue("@name", name)
                cmdInsert.Parameters.AddWithValue("@sex", sex)
                cmdInsert.Parameters.AddWithValue("@birthday", birthday)
                cmdInsert.ExecuteNonQuery()

                MsgBox("Thêm thành công tài khooản : " & user)
                btnReset.PerformClick()

            ElseIf (Not String.IsNullOrEmpty(result)) Then
                MsgBox("Tên tài khoản đã tồn tại, mời chọn tên khác")
                txtUser.Text = ""
                txtUser.Focus()

            ElseIf (Not password.Equals(passReturn)) Then
                MsgBox("Mật khẩu nhập lại không giống nhau! Xin nhập lại")
                txtPassReturn.Text = ""
                txtPass.Text = ""
                txtPass.Focus()
            Else
                MsgBox("Tên tài khoản hoặc mật khẩu không chứa ký tự tiếng Việt hoặc dấu SPACE")
                txtUser.Text = ""
                txtPassReturn.Text = ""
                txtPass.Text = ""
                txtUser.Focus()
            End If

        Else
            MsgBox("Bạn hãy điền đầy đủ thông tin trước khi nhấn Đăng Ký")

        End If

    End Sub

    Private Sub SignUp_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Hoàn thành thêm User mới?", "Nhắc nhở", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            connect.Close()
            Me.Hide()
            ViewUser.Show()
        Else
            e.Cancel = True
        End If
    End Sub


End Class

