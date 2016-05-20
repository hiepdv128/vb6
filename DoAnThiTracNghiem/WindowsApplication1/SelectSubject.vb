Imports System.Data.SqlClient

Public Class selectSubject


    Private Sub selectSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        loadDataToCmb()
    End Sub

    Private Sub loadDataToCmb()
        Dim con As New SqlConnection("Data Source=DESKTOP-6N5I9TS;Initial Catalog=DB_Demo;Integrated Security=True")
        con.Open()
        Dim adapter As New SqlDataAdapter("select * from Subject", con)
        Dim table As New DataTable
        adapter.Fill(table)
        cmbSubject.DataSource = table
        cmbSubject.DisplayMember = "Namesubject"
        cmbSubject.ValueMember = "IDSubject"
    End Sub
End Class