Imports System.Data.SqlClient

Public Class Test
    Private user As String
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True; MultipleActiveResultSets=True")
    Private numOfQuestion As Integer = 50
    Private IDSubject As String = "kthdc"
    Private second, minute As Integer
    Private score As Integer

    'lis chua danh sach doi tuong kieu Question de thao tac
    Private questionSelecteds As New List(Of Question)

    'con tro den vi tri cua doi tuong hien tai dang xet trong list questionSelecteds
    Private currentQuestion As Integer = 0

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

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.Open()
        questionSelecteds.Capacity = 50
        CenterToScreen()
        loadQuestion()
        showQuestion()
        timer.Enabled = True
        Me.score = 0
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

            Dim sqlAnswer As String = "select contentanswer, correct from answer where idquestion = " & readQuestion.GetInt32(1) & " order by newid()"
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

    Private Sub showQuestion()
        'hien thi cau hoi dau tien
        Dim question As Question = questionSelecteds.Item(currentQuestion)
        lblQuestion.Text = question.getQuestion
        rbtAnswerA.Text = question.getAnswers.Item(0).getContent
        rbtAnswerB.Text = question.getAnswers.Item(1).getContent
        rbtAnswerC.Text = question.getAnswers.Item(2).getContent
        rbtAnswerD.Text = question.getAnswers.Item(3).getContent

        Dim i As Integer = 1
        For Each question In questionSelecteds
            addButton(i)
            i += 1
        Next
    End Sub

    Private Function addButton(ByVal index As Integer) As Button
        Dim btn As New Button
        'If (numOfQuestion <= 30) Then
        '    btn.Width = 60
        '    btn.Height = 40
        'Else
        btn.Width = 40
        btn.Height = 35
        'End If
        btn.Text = index
        flpButtonQues.Controls.Add(btn)
        AddHandler btn.Click, AddressOf clickNumOfQuestion
        Return btn
    End Function

    Private Sub clickNumOfQuestion(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        'lay ra so thu tu cua nut thong qua ten
        Dim nameBtn As String = btn.Text
        grbQuestion.Text = "Câu hỏi " & nameBtn
        currentQuestion = Integer.Parse(nameBtn) - 1

        Dim question As Question = questionSelecteds.Item(currentQuestion)
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

    Private Sub rbtAnswerA_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAnswerA.CheckedChanged
        questionSelecteds.Item(currentQuestion).setIndexChecked(0)
    End Sub

    Private Sub rbtAnswerB_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAnswerB.CheckedChanged
        questionSelecteds.Item(currentQuestion).setIndexChecked(1)
    End Sub

    Private Sub rbtAnswerC_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAnswerC.CheckedChanged
        questionSelecteds.Item(currentQuestion).setIndexChecked(2)
    End Sub

    Private Sub rbtAnswerD_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAnswerD.CheckedChanged
        questionSelecteds.Item(currentQuestion).setIndexChecked(3)
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If (second <> 0) Then
            second -= 1
        Else 'nếu thành phần giây = 0
            second = 59
            If (minute <> 0) Then
                minute -= 1
            Else
                MsgBox("Het gio")
            End If
        End If
        'hiển thị thời gian còn lại lên Label lblTimeOut
        lblTimeOut.Text = minute & " : " & second
    End Sub

    Private Sub endTest()
        Dim temp As Integer
        For Each question In questionSelecteds
            temp = question.getIndexChecked
            If (question.getAnswers.Item(temp).getCorrect) Then
                Me.score += 1
            End If
        Next

        //view lại
    End Sub

    Private Sub preview()


    End Sub

End Class