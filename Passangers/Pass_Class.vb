Imports System.IO
Imports System.Windows.Forms.DateTimePicker
'Creating Pass_Class that will print user input on the text file 
Public Class Pass_Class
    'Passanger particulars inside the class
    Dim p As StreamReader
    Dim s As String = "C:\Users\tfaye\Documents\Visual Studio 2013\Projects\Passangers.txt"
    Public PassangerName As String
    Public Surname As String
    Public IDnumber As Long
    Public DatePassenger As Date

    'Sub to fetch user input from the form
    Public Sub New(Nametxt As String, Surnametxt As String, IDtxt As Long, DateTimePickertxt As Date)
        PassangerName = Nametxt
        Surname = Surnametxt
        IDnumber = IDtxt
        DatePassenger = DateTimePickertxt
        'Checking if the text file exist, if not will creat new file
        If Not File.Exists(s) Then
            Dim d As FileStream
            d = File.Create(s)
            d.Close()
        End If
        'Statement to call a function inside module to print values
        Dim Display_Passangers(s, PassangerName, Surname, IDnumber, DatePassenger)

    End Sub

End Class
