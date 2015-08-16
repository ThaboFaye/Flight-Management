Imports System.IO
Imports System.Windows.Forms.DateTimePicker
Public Class Passangers

    Dim myPass As Pass_Class
    Public DatePassanger As Date

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'When the save button is clicked, CreatSeat function will be called and assign values
        CreatePass(Nametxt.Text, Surnametxt.Text, IDtxt.Text, DateTimePickertxt.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'When Exit button is click the form will be closed
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'When clear button is clicked all values will be cleared 
        Nametxt.Text = ""
        Surnametxt.Text = ""
        IDtxt.Text = ""
        DateTimePickertxt.Text = ""
    End Sub
    'Assigning user values to the object
    Private Sub CreatePass(Nametxt As String, Surnametxt As String, IDtxt As Long, DateTimePickertxt As Date)
        myPass = New Pass_Class(Nametxt, Surnametxt, IDtxt, DateTimePickertxt)
    End Sub

    Private Sub CreatPass(p1 As String)
        Throw New NotImplementedException
    End Sub


    Private Sub IDtxt_TextChanged(sender As Object, e As EventArgs) Handles IDtxt.TextChanged

    End Sub
End Class
