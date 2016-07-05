Imports System.Data.SqlClient
Imports System.Math

Public Class Test
    Friend user As String
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True; MultipleActiveResultSets=True")
    Private numOfQuestion As Integer
    Private IDSubject As String
    Private minute As Integer
    Private second As Integer
    Private mark As Double
    Private isAutoNext As Boolean
    Private clicked As Integer
    Private isReview As Boolean

    'lis chua danh sach doi tuong kieu Question de thao tac
    Private questionSelecteds As New List(Of Question)

    'con tro den vi tri cua doi tuong hien tai dang xet trong list questionSelecteds
    Private current As Integer = 0

    Public Sub setNumOfQuestion(ByVal num As Integer)
        Me.numOfQuestion = num
    End Sub

    Public Sub setIDSubject(ByVal ID As String)
        Me.IDSubject = ID
    End Sub

    Public Sub setTime(ByVal t As Integer)
        Me.minute = t
        Me.second = 0
    End Sub

    Private Sub test_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If (Me.Visible) Then
            connect.Open()
            Me.user = SelectSubject.user
            questionSelecteds.Capacity = 50
            'numOfQuestion = 50
            'IDSubject = "kthdc"
            'minute = 0
            'second = 4
            mark = 0
            isAutoNext = False
            clicked = 0
            isReview = False
            loadInfo()
            loadQuestion()
            showButtonQuestion()
            timer.Enabled = True
        End If

    End Sub

    Private Sub loadInfo()
        Dim cmd As New SqlCommand("SELECT NAME,SEX,BIRTHDAY FROM ALLUSER WHERE USERNAME='" & user & "'", connect)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        'Try
        reader.Read()
        lblName.Text = reader.GetValue(0).ToString
        lblSex.Text = reader.GetValue(1).ToString
        lblBirthday.Text = reader.GetValue(2).ToString().Remove(10, 12)

        lblNotCheck.Text = numOfQuestion

        Dim cmd2 As New SqlCommand("SELECT NAMESUBJECT FROM SUBJECT", connect)
        lblNameSubject.Text = cmd2.ExecuteScalar.ToString
    End Sub

    'lay tat ca id cau hoi trung voi mon hoc da chon
    'Private Sub loadAllIDQuestion()
    '    Dim sql = "select idquestion from Question where IDSubject = '" + IDSubject + "'"
    '    Dim cmd As New SqlCommand(sql, connect)
    '    Dim reader As SqlDataReader = cmd.ExecuteReader
    '    While reader.Read
    '        allQuestions.Add(Integer.Parse(reader.Item(0)))
    '    End While
    'End Sub
    'tra ve 1 arraylist chua id da duoc sap xep random
    'Private Function getIDRandom(ByVal listAllItems As ArrayList, ByVal numOfSelect As Integer) As ArrayList
    '    Dim list As New ArrayList
    '    Dim count As Integer = listAllItems.Count
    '    Dim i, rand As Integer
    '    For i = 1 To numOfSelect
    '        rand = getNumRandom(0, count - 1)
    '        list.Add(listAllItems.Item(rand))
    '        listAllItems.RemoveAt(rand)
    '        count -= 1
    '    Next
    '    Return list
    'End Function

    'Public Function getNumRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
    '    Static Generator As System.Random = New System.Random()
    '    Return Generator.Next(Min, Max)
    'End Function

    Public Sub loadQuestion()
        Dim sqlQuestion = "select top " & numOfQuestion & " * from question where idsubject = '" & IDSubject & "' order by newid()"
        Dim cmdQuestion As New SqlCommand(sqlQuestion, connect)
        Dim readQuestion As SqlDataReader = cmdQuestion.ExecuteReader

        While readQuestion.Read
            Dim question As New Question
            question.setQuestion(readQuestion.GetString(2))
            Dim idQuestion As Integer = readQuestion.GetInt32(1)
            Dim sqlAnswer As String = "select contentanswer, correct from answer where idquestion = " & idQuestion & " order by newid()"
            Dim cmdAnswer As New SqlCommand(sqlAnswer, connect)
            Dim readAnswer As SqlDataReader = cmdAnswer.ExecuteReader
            'read answers of instance question
            While readAnswer.Read
                Dim answer As New Answer
                answer.setContent(readAnswer.GetValue(0).ToString)
                If (readAnswer.GetValue(1).ToString.Trim.Equals("1")) Then
                    answer.setCorrect(True)
                Else
                    answer.setCorrect(False)
                End If
                question.addAnswers(answer)
            End While

            questionSelecteds.Add(question)
        End While
    End Sub

    Private Sub showButtonQuestion()

        Dim i As Integer = 1
        For i = 1 To numOfQuestion
            flpButtonQues.Controls.Add(getNewButton(i))
        Next

        'get button 1, and set performclick
        Dim btn As Button = DirectCast(flpButtonQues.Controls.Item(0), Button)
        btn.PerformClick()
    End Sub

    Private Function getNewButton(index As Integer) As Button
        Dim btn As New Button

        btn.Width = 40
        btn.Height = 35
        btn.BackColor = Color.LightSkyBlue
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Text = index
        btn.Font = New Font("Modern No. 20", 13)
        AddHandler btn.Click, AddressOf clickButtonQuestion

        Return btn
    End Function

    Private Sub clickButtonQuestion(ByVal sender As Object, ByVal e As EventArgs)
        'set color for the last question clicked

        Dim last As Button = DirectCast(flpButtonQues.Controls.Item(current), Button)
        If (questionSelecteds.Item(current).getIndexChecked >= 0) Then
            last.BackColor = Color.Navy
        Else
            last.BackColor = Color.LightSkyBlue
        End If


        Dim bt As Button = DirectCast(sender, Button)
        bt.BackColor = Color.Gold
        current = flpButtonQues.Controls.IndexOf(sender)
        showQuestion(current)

    End Sub

    Private Sub showQuestion(position As Integer)

        Dim question As Question = questionSelecteds.Item(position)
        'Show content
        lblQuestion.Text = question.getQuestion
        rbtAnswerA.Text = question.getAnswers.Item(0).getContent
        rbtAnswerB.Text = question.getAnswers.Item(1).getContent
        rbtAnswerC.Text = question.getAnswers.Item(2).getContent
        rbtAnswerD.Text = question.getAnswers.Item(3).getContent

        Dim index As Integer = question.getIndexChecked()
        Select Case index
            Case 0
                rbtAnswerA.Checked = True
            Case 1
                rbtAnswerB.Checked = True
            Case 2
                rbtAnswerC.Checked = True
            Case 3
                rbtAnswerD.Checked = True
            Case -1
                rbtAnswerA.Checked = False
                rbtAnswerB.Checked = False
                rbtAnswerC.Checked = False
                rbtAnswerD.Checked = False
        End Select
    End Sub


    Private Sub rbtAnswerA_MouseClick(sender As Object, e As EventArgs) Handles rbtAnswerA.MouseClick
        If (Not isReview) Then
            If (questionSelecteds.Item(current).getIndexChecked = -1) Then
                clicked += 1
                lblChecked.Text = clicked
                lblNotCheck.Text = numOfQuestion - clicked
            End If

            questionSelecteds.Item(current).setIndexChecked(0)
            lblLastChecked.Text = current + 1
            If (current < numOfQuestion - 1 And isAutoNext) Then
                btnNext.PerformClick()
            End If
        Else
            rbtAnswerA.Checked = False
        End If
    End Sub

    Private Sub rbtAnswerB_MouseClick(sender As Object, e As EventArgs) Handles rbtAnswerB.MouseClick
        If (Not isReview) Then

            If (questionSelecteds.Item(current).getIndexChecked = -1 And Not isReview) Then
                clicked += 1
                lblChecked.Text = clicked
                lblNotCheck.Text = numOfQuestion - clicked
            End If
            questionSelecteds.Item(current).setIndexChecked(1)
            lblLastChecked.Text = current + 1

            If (current < numOfQuestion - 1 And isAutoNext) Then
                btnNext.PerformClick()
            End If
        Else
            rbtAnswerB.Checked = False
        End If
    End Sub

    Private Sub rbtAnswerC_MouseClick(sender As Object, e As EventArgs) Handles rbtAnswerC.MouseClick
        If (Not isReview) Then

            If (questionSelecteds.Item(current).getIndexChecked = -1 And Not isReview) Then
                clicked += 1
                lblChecked.Text = clicked
                lblNotCheck.Text = numOfQuestion - clicked
            End If
            questionSelecteds.Item(current).setIndexChecked(2)
            lblLastChecked.Text = current + 1

            If (current < numOfQuestion - 1 And isAutoNext) Then
                btnNext.PerformClick()
            End If
        Else
            rbtAnswerC.Checked = False
        End If
    End Sub

    Private Sub rbtAnswerD_MouseClick(sender As Object, e As EventArgs) Handles rbtAnswerD.MouseClick
        If (Not isReview) Then

            If (questionSelecteds.Item(current).getIndexChecked = -1 And Not isReview) Then
                clicked += 1
                lblChecked.Text = clicked
                lblNotCheck.Text = numOfQuestion - clicked
            End If
            questionSelecteds.Item(current).setIndexChecked(3)
            lblLastChecked.Text = current + 1

            If (current < numOfQuestion - 1 And isAutoNext) Then
                btnNext.PerformClick()
            End If
        Else
            rbtAnswerD.Checked = False
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If (second <> 0) Then
            second -= 1
        Else 'nếu thành phần giây = 0
            second = 59
            If (minute <> 0) Then
                minute -= 1
            Else
                second = 0
                timer.Enabled = False
                MsgBox("Hết giờ, kết thúc bài thi!")
                'End test if time up
                Me.endTest()
            End If
        End If
        'hiển thị thời gian còn lại lên Label lblTimeOut
        lblTimeOut.Text = minute & " : " & second
    End Sub

    Private Sub endTest()
        timer.Enabled = False
        cbAutoNext.Enabled = False
        isReview = True
        btnEndTest.Visible = False
        btnBack.Visible = True
        flpButtonQues.Controls.Clear()

        Dim temp As Integer
        For temp = 0 To numOfQuestion - 1
            Dim question As Question = questionSelecteds.Item(temp)
            Dim correct As Boolean
            If (question.getIndexChecked < 0) Then
                correct = False
            Else
                correct = question.getAnswers.Item(question.getIndexChecked).getCorrect
            End If

            If (correct) Then
                Me.mark += 1
            End If
            addReviewButton(temp + 1, correct)
        Next
        mark = Round(10 * mark / numOfQuestion)
        'Save to database
        Dim query As String = "INSERT INTO MARK VALUES(@USER,@IDSUBJECT,@MARK,@TIME)"
        Dim command As New SqlCommand(query, connect)
        command.Parameters.AddWithValue("@USER", user)
        command.Parameters.AddWithValue("@IDSUBJECT", IDSubject)
        command.Parameters.AddWithValue("@MARK", mark)
        command.Parameters.AddWithValue("@TIME", Date.Now.ToString("MM/dd/yyyy"))
        command.ExecuteNonQuery()

        lblTimeOut.Text = "Điểm : " & mark

        'click first
        Dim firstButton As Button = DirectCast(flpButtonQues.Controls.Item(0), Button)
        firstButton.PerformClick()
    End Sub

    Private Function addReviewButton(index As Integer, correct As Boolean) As Button
        Dim btn As New Button

        btn.Width = 40
        btn.Height = 35
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        'set color here
        If (correct) Then
            btn.BackColor = Color.Lime
        Else
            btn.BackColor = Color.Crimson
        End If

        btn.Text = index
        btn.Font = New Font("Modern No. 20", 13)

        flpButtonQues.Controls.Add(btn)
        AddHandler btn.Click, AddressOf reviewQuestion

        Return btn
    End Function

    Private Sub resetRadioButton()

        rbtAnswerA.ForeColor = Color.Black
        rbtAnswerB.ForeColor = Color.Black
        rbtAnswerC.ForeColor = Color.Black
        rbtAnswerD.ForeColor = Color.Black
        rbtAnswerA.Checked = False
        rbtAnswerB.Checked = False
        rbtAnswerC.Checked = False
        rbtAnswerD.Checked = False
    End Sub

    'Review a question
    Private Sub reviewQuestion(ByVal sender As Object, ByVal e As EventArgs)
        'set color last clicked
        Dim lastButton As Button = DirectCast(flpButtonQues.Controls.Item(current), Button)
        Dim lastQuestion As Question = questionSelecteds.Item(current)
        If (lastQuestion.getIndexChecked < 0) Then
            lastButton.BackColor = Color.Crimson
        ElseIf (Not lastQuestion.getAnswers.Item(lastQuestion.getIndexChecked).getCorrect) Then
            lastButton.BackColor = Color.Crimson
        Else
            lastButton.BackColor = Color.Lime
        End If

        'set color current button
        DirectCast(sender, Button).BackColor = Color.Gold

        'set current
        current = flpButtonQues.Controls.IndexOf(sender)
        Dim question As Question = questionSelecteds.Item(current)

        lblQuestion.Text = question.getQuestion
        rbtAnswerA.Text = question.getAnswers.Item(0).getContent
        rbtAnswerB.Text = question.getAnswers.Item(1).getContent
        rbtAnswerC.Text = question.getAnswers.Item(2).getContent
        rbtAnswerD.Text = question.getAnswers.Item(3).getContent

        'Reset color before
        Me.resetRadioButton()

        'Set color the true answer
        If (question.getAnswers.Item(0).getCorrect) Then
            rbtAnswerA.ForeColor = Color.Red
        ElseIf (question.getAnswers.Item(1).getCorrect) Then
            rbtAnswerB.ForeColor = Color.Red
        ElseIf (question.getAnswers.Item(2).getCorrect) Then
            rbtAnswerC.ForeColor = Color.Red
        ElseIf (question.getAnswers.Item(3).getCorrect) Then
            rbtAnswerD.ForeColor = Color.Red
        End If

        Dim index As Integer = question.getIndexChecked()
        Select Case index
            Case 0
                rbtAnswerA.ForeColor = Color.Blue
            Case 1
                rbtAnswerB.ForeColor = Color.Blue
            Case 2
                rbtAnswerC.ForeColor = Color.Blue
            Case 3
                rbtAnswerD.ForeColor = Color.Blue
        End Select

    End Sub

    Private Sub btnEndTest_Click(sender As Object, e As EventArgs) Handles btnEndTest.Click
        If MessageBox.Show("Bạn chắc muốn nộp bài?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.endTest()
        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If (current > 0) Then
            Dim bt As Button = DirectCast(flpButtonQues.Controls.Item(current - 1), Button)
            bt.PerformClick()
        Else
            Dim bt As Button = DirectCast(flpButtonQues.Controls.Item(numOfQuestion - 1), Button)
            bt.PerformClick()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (current < numOfQuestion - 1) Then
            Dim bt As Button = DirectCast(flpButtonQues.Controls.Item(current + 1), Button)
            bt.PerformClick()
        Else
            Dim bt As Button = DirectCast(flpButtonQues.Controls.Item(0), Button)
            bt.PerformClick()
        End If
    End Sub


    Private Sub cbAutoNext_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoNext.CheckedChanged
        isAutoNext = cbAutoNext.Checked
    End Sub

    Private Sub Test_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not isReview) Then
            If MessageBox.Show("Bạn muốn thoát ứng dụng? Kết quả đến thời điểm hiện tại vẫn sẽ được tính.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                endTest()
                connect.Close()
                End
            Else
                e.Cancel = True
            End If
        Else
            Me.Hide()
            SelectSubject.Show()
        End If
        
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        connect.Close()
        Me.Hide()
        SelectSubject.Show()
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class