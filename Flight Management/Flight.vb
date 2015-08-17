Imports System.IO
Imports System.Windows.Forms.DateTimePicker
Public Class Flight

    Dim myFlight As Flight_Class
    Public DepartureDate As Date
    Public PassFightName As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DepartName.Items.Add("Select Departure Airport Name....")
        DepartName.Items.Add("OR Tambo Airport")
        DepartName.Items.Add("KwaZulu Natal Airport")
        DepartName.Items.Add("Port Elizabeth Airport")
        DepartName.Items.Add("Cape Town Airport")
        DepartName.Items.Add("Magadishu Airport")
        DepartName.Items.Add("Adis Ababa Airport")
        DepartName.Items.Add("Cairo Airport")
        DepartName.SelectedIndex = 0

        Seatnumbertxt.Items.Add("Select Seat number")
        Seatnumbertxt.Items.Add("1")
        Seatnumbertxt.Items.Add("2")
        Seatnumbertxt.Items.Add("3")
        Seatnumbertxt.Items.Add("4")
        Seatnumbertxt.Items.Add("5")
        Seatnumbertxt.Items.Add("6")
        Seatnumbertxt.Items.Add("7")
        Seatnumbertxt.Items.Add("8")
        Seatnumbertxt.Items.Add("9")
        Seatnumbertxt.Items.Add("10")
        Seatnumbertxt.Items.Add("11")
        Seatnumbertxt.Items.Add("12")
        Seatnumbertxt.SelectedIndex = 0


        ArriveName.Items.Add("Select Arrive Airport Name....")
        ArriveName.Items.Add("OR Tambo Airport")
        ArriveName.Items.Add("KwaZulu Natal Airport")
        ArriveName.Items.Add("Port Elizabeth Airport")
        ArriveName.Items.Add("Cape Town Airport")
        ArriveName.Items.Add("Magadishu Airport")
        ArriveName.Items.Add("Adis Ababa Airport")
        ArriveName.Items.Add("Cairo Airport")
        ArriveName.SelectedIndex = 0
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Checking the click or selected radio button
        If SAARadio.Checked Then

            PassFightName = "South African Airways"
           
        End If

        If BritainRadio.Checked Then

            PassFightName = "Britain Airways"
           
        End If

        If KululaRadio.Checked Then

            PassFightName = "Kulula Airways"
            
        End If

        If MangoRadio.Checked Then

            PassFightName = "Mango Airways"
            
        End If

        CreateFlight(PassFightName, DepartName.Text, Seatnumbertxt.Text, ArriveName.Text, DateTimePicker1.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DepartName.Text = ""
        Seatnumbertxt.Text = ""
        ArriveName.Text = ""
    End Sub

    'Assigning user values to the object
    Private Sub CreateFlight(PassFightName As String, DepartName As String, Seatnumbertxt As String, ArriveName As String, DateTimePicker1 As Date)
        myFlight = New Flight_Class(PassFightName, DepartName, Seatnumbertxt, ArriveName, DateTimePicker1)
    End Sub

End Class
