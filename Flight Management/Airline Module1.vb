
Imports System.IO
Module Airline_Management
    Dim a As StreamReader
    Dim c As String = "C:\Users\tfaye\Documents\Visual Studio 2013\Projects\Airline Bookings.txt"

    Dim p As StreamReader
    Dim s As String = "C:\Users\tfaye\Documents\Visual Studio 2013\Projects\Passangers.txt"

    Dim Z As StreamReader
    Dim t As String = "C:\Users\tfaye\Documents\Visual Studio 2013\Projects\Seat.txt"

    Sub Display_Flight(c As String, FlightName As String, DepartureDate As Date, SeatNumber As String, DepAirportName As String, ArriveAirportName As String)

        File.AppendAllText(c, FlightName & vbLf & ", ")

        File.AppendAllText(c, DepartureDate & vbLf & ", ")

        File.AppendAllText(c, SeatNumber & vbLf & ", ")

        File.AppendAllText(c, DepAirportName & vbLf & ", ")

        File.AppendAllText(c, ArriveAirportName & vbLf & ". ")


    End Sub

    Sub Display_Passangers(s As String, PassangerName As String, Surname As String, IDnumber As Long, DatePassenger As Date)
        'Printing values to text file seperated by comma
        File.AppendAllText(s, PassangerName & vbLf & ", ")

        File.AppendAllText(s, Surname & vbLf & ", ")

        File.AppendAllText(s, IDnumber & vbLf & ", ")

        File.AppendAllText(s, DatePassenger & vbLf & ". ")
    End Sub

    Public Sub Display_Seat(t As String, Adult As String, Child As String, Infants As String)

        File.AppendAllText(t, Adult & vbLf & ", ")

        File.AppendAllText(t, Child & vbLf & ", ")

        File.AppendAllText(t, Infants & vbLf & ". ")

    End Sub
End Module
