Imports System.IO
Imports System.Windows.Forms.DateTimePicker
'Creating Fight_Class that will print user input on the text file 
Public Class Flight_Class
    Dim a As StreamReader
    Dim c As String = "C:\Users\tfaye\Documents\Visual Studio 2013\Projects\Airline Bookings.txt"
    Public FlightName As String
    Public DepartureDate As Date
    Public DepAirportName As String
    Public ArriveAirportName As String
    Public SeatNumber As String

    Public Sub New(PassFightName As String, DepartName As String, Seatnumbertxt As String, ArriveName As String, DateTimePicker1 As Date)
        FlightName = PassFightName
        DepAirportName = DepartName
        SeatNumber = Seatnumbertxt
        ArriveAirportName = ArriveName
        DepartureDate = DateTimePicker1

        If Not File.Exists(c) Then
            Dim d As FileStream
            d = File.Create(c)
            d.Close()
        End If

        Display_Flight(c, FlightName, DepartureDate, SeatNumber, DepAirportName, ArriveAirportName)

    End Sub

End Class
