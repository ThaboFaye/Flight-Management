Module Airline_Data
    Sub Main2()
        Dim nextLine As String
        'Path to the actual Airline booking text file 
        FileOpen(1, "C:\Users\tfaye\Documents\Visual Studio 2013\Projects\Airline Bookings.txt", OpenMode.Input)
        'Reading the data from the file
        Do While Not EOF(1)
            nextLine = LineInput(1)
            Console.WriteLine(nextLine)
        Loop
        'Closing the file after reading
        FileClose(1)
        Console.ReadLine()

    End Sub

    Sub Main1()
        Dim nextLine1 As String
        'Path to the actual Seat text file 
        FileOpen(1, "C:\Users\tfaye\Documents\Visual Studio 2013\Projects\Seat.txt", OpenMode.Input)
        'Reading the data from the file
        Do While Not EOF(1)
            nextLine1 = LineInput(1)
            Console.WriteLine(nextLine1)
        Loop
        'Closing the file after reading
        FileClose(1)
        Console.ReadLine()

    End Sub

    Sub Main()
        Dim nextLine2 As String
        'Path to the actual Passanger text file 
        FileOpen(1, "C:\Users\tfaye\Documents\Visual Studio 2013\Projects\Passangers.txt", OpenMode.Input)
        'Reading the data from the file
        Do While Not EOF(1)
            nextLine2 = LineInput(1)
            Console.WriteLine(nextLine2)
        Loop
        'Closing the file after reading
        FileClose(1)
        Console.ReadLine()

    End Sub
End Module
