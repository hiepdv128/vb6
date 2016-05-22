Imports System.Data.SqlClient

Public Class Test
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True; MultipleActiveResultSets=True")
    Private numOfQuestion As Integer = 45
    Private IDSubject As String = "ktmt"
    Private time As Integer

    'list chua id cau hoi da duoc chon random
    Private selectedIDs As New ArrayList

    'list chua id tat ca cau hoi cua mon hoc
    Private allQuestions As New ArrayList

    'lis chua danh sach doi tuong kieu Question de thao tac
    Private questionSelecteds As New List(Of Question)

    'con tro den vi tri cua doi tuong hien tai dang xet trong list questionSelecteds
    Private currentQuestion As Integer = 0

    Public Sub setNumOfQuestion(ByVal num As Integer)
        numOfQuestion = num
    End Sub

    Public Sub setIDSubject(ByVal ID As String)
        IDSubject = ID
    End Sub

    Public Sub setTime(ByVal t As Integer)
        time = t
    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.Open()
        questionSelecteds.Capacity = 60
        CenterToScreen()
        loadAllIDQuestion()
        selectedIDs = getIDRandom(allQuestions, numOfQuestion)
        loadQuesAns()
        showQuestion()
    End Sub
    'lay tat ca id cau hoi trung voi mon hoc da chon
    Private Sub loadAllIDQuestion()
        Dim sql = "select idquestion from Question where IDSubject = '" + IDSubject + "'"
        Dim cmd As New SqlCommand(sql, connect)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read
            allQuestions.Add(Integer.Parse(reader.Item(0)))
        End While
    End Sub
    'tra ve 1 arraylist chua id da duoc sap xep random
    Private Function getIDRandom(ByVal listAllItems As ArrayList, ByVal numOfSelect As Integer) As ArrayList
        Dim list As New ArrayList
        Dim count As Integer = listAllItems.Count
        Dim i, rand As Integer
        For i = 1 To numOfSelect
            rand = getNumRandom(0, count - 1)
            list.Add(listAllItems.Item(rand))
            listAllItems.RemoveAt(rand)
            count -= 1
        Next
        Return list
    End Function

    Public Function getNumRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Public Sub loadQuesAns()
        For Each idQuestion In selectedIDs
            Dim sqlQuestion = "select contentquestion from question where idquestion = '" & idQuestion & "'"
            Dim cmdQuestion As New SqlCommand(sqlQuestion, connect)
            Dim question As New Question
            question.setQuestion(cmdQuestion.ExecuteScalar.ToString)
            Dim sqlAnswer As String = "select contentanswer, correct from answer where idquestion = '" & idQuestion & "'"
            Dim cmdAnswer As New SqlCommand(sqlAnswer, connect)
            Dim readAns As SqlDataReader = cmdAnswer.ExecuteReader
            'read answers of instance question
            While readAns.Read
                Dim answer As New Answer
                answer.setContent(readAns.GetValue(0).ToString)
                If (readAns.GetValue(1).ToString.Trim.Equals("1")) Then
                    answer.setCorrect(True)
                Else
                    answer.setCorrect(False)
                End If
                question.addAnswers(answer)
            End While
            questionSelecteds.Add(question)
        Next
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
        If (numOfQuestion <= 30) Then
            btn.Width = 70
            btn.Height = 30
        Else
            btn.Width = 50
            btn.Height = 20
        End If
        btn.Text = "Câu " & index
        flpButtonQues.Controls.Add(btn)
        AddHandler btn.Click, AddressOf clickNumOfQuestion
        Return btn
    End Function

    Private Sub clickNumOfQuestion(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        'lay ra so thu tu cua nut thong qua ten
        Dim nameBtn As String = btn.Text
        grbQuestion.Text = nameBtn
        nameBtn = nameBtn.Replace("Câu ", "")
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
End Class