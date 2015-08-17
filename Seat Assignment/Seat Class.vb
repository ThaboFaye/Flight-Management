Imports System.IO
Imports System.Windows.Forms.DateTimePicker
'Creating Seat_Class that will print user input on the text file 
Public Class Seat_Class
    'Passanger seat and age selection inside the class

    Dim Z As StreamReader
    Dim t As String = "C:\Users\tfaye\Documents\Visual Studio 2013\Projects\Seat.txt"
    Public Adult As String
    Public Child As String
    Public Infants As String

    'Sub to fetch user input from the form

    Public Sub New(adulttxt As String, childtxt As String, infantstxt As String)
        'Transferring user input to public variables for storing
        Adult = adulttxt.ToString
        Child = childtxt.ToString
        Infants = infantstxt.ToString
        'Checking if the text file exist, if not will creat new file
        If Not File.Exists(t) Then
            Dim d As FileStream
            d = File.Create(t)
            d.Close()
        End If
        'Printing values to text file seperated by comma
        Display_Seat(t, Adult, Child, Infants)

    End Sub

    

End Class
