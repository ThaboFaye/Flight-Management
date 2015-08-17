
Public Class Seat
    Dim mySeat As Seat_Class
    Private Sub adult_TextChanged(sender As Object, e As EventArgs) Handles adulttxt.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Seat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populating values to choose from by the user
        adulttxt.Items.Add("Adult")
        adulttxt.Items.Add("1")
        adulttxt.Items.Add("2")
        adulttxt.Items.Add("3")
        adulttxt.Items.Add("4")
        adulttxt.Items.Add("5")
        adulttxt.Items.Add("6")
        adulttxt.Items.Add("7")
        adulttxt.Items.Add("8")
        adulttxt.Items.Add("9")
        adulttxt.SelectedIndex = 0

        childtxt.Items.Add("Child")
        childtxt.Items.Add("1")
        childtxt.Items.Add("2")
        childtxt.Items.Add("3")
        childtxt.Items.Add("4")
        childtxt.Items.Add("5")
        childtxt.Items.Add("6")
        childtxt.Items.Add("7")
        childtxt.Items.Add("8")
        childtxt.Items.Add("9")
        childtxt.SelectedIndex = 0

        infantstxt.Items.Add("Infants")
        infantstxt.Items.Add("1")
        infantstxt.Items.Add("2")
        infantstxt.Items.Add("3")
        infantstxt.Items.Add("4")
        infantstxt.Items.Add("5")
        infantstxt.Items.Add("6")
        infantstxt.Items.Add("7")
        infantstxt.Items.Add("8")
        infantstxt.Items.Add("9")
        infantstxt.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'When the save button is clicked, CreatSeat function will be called and assign values
        CreatSeat(adulttxt.Text, childtxt.Text, infantstxt.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'When Exit button is click the form will be closed
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'When clear button is clicked all values will be cleared 
        adulttxt.Text = ""
        childtxt.Text = ""
        infantstxt.Text = ""
    End Sub
    'Assigning user values to the object
    Private Sub CreatSeat(adulttxt As String, childtxt As String, infantstxt As String)
        mySeat = New Seat_Class(adulttxt, childtxt, infantstxt)
    End Sub

    Private Sub CreatSeat(p1 As String)
        Throw New NotImplementedException
    End Sub

End Class
