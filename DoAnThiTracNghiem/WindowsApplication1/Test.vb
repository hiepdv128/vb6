Imports System.Data.SqlClient

Public Class Test
    Private connect As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True")
    Private numOfQuestion As Integer = 20
    Private IDSubject As String = "ktmt"
    Private time As Integer
    Private selectQuestions As New ArrayList
    Private allQuestions As New ArrayList

    Public Sub setNumOfQuestion(ByVal num As Integer)
        numOfQuestion = num
    End Sub

    Public Sub setIDSubject(ByVal ID As String)
        IDSubject = ID
    End Sub

    Public Sub setTime(ByVal t As Integer)
        time = t
    End Sub

    Private Sub questionText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        connect.Open()
        loadAllQuestion()
    End Sub

    Private Sub loadAllQuestion()
        Dim sqlQue = "select * from question where IDSubject = '" + IDSubject + "'"
        Dim cmdQue As New SqlCommand(sqlQue, connect)
        Dim readQue As SqlDataReader = cmdQue.ExecuteReader

        Dim i As Integer = 1
        While (readQue.Read)

            Dim question As New Question
            question.setQuestion(readQue.GetValue(2).ToString)
            Dim idQuestion As String = readQue.GetValue(1).ToString

            Dim sqlAns = "select * from answer where idquestion = '" + idQuestion + "'"

            Dim connect2 As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True")
            connect2.Open()
            Dim cmdAns As New SqlCommand(sqlAns, connect2)
            Dim readAns As SqlDataReader = cmdAns.ExecuteReader
            'read answers of instance question
            While readAns.Read
                Dim ans As New Answer
                ans.setContent(readAns.GetValue(2).ToString)
                If (readAns.GetValue(3).ToString.Equals("1")) Then
                    ans.setCorrect(True)
                Else
                    ans.setCorrect(False)
                End If
                question.addAnswers(ans)
            End While
            allQuestions.Add(question)

            Dim btn As New Button
            btn.Width = 50
            btn.Height = 20
            btn.Text = "Câu"
            flpButtonQues.Controls.Add(btn)
        End While
    End Sub

End Class