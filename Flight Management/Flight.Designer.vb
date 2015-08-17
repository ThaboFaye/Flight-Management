<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flight
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flight))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MangoRadio = New System.Windows.Forms.RadioButton()
        Me.KululaRadio = New System.Windows.Forms.RadioButton()
        Me.BritainRadio = New System.Windows.Forms.RadioButton()
        Me.SAARadio = New System.Windows.Forms.RadioButton()
        Me.Seatnumbertxt = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ArriveName = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DepartName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria Math", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(243, -37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 195)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FLIGHT MANAGEMENT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MangoRadio)
        Me.GroupBox1.Controls.Add(Me.KululaRadio)
        Me.GroupBox1.Controls.Add(Me.BritainRadio)
        Me.GroupBox1.Controls.Add(Me.SAARadio)
        Me.GroupBox1.Controls.Add(Me.Seatnumbertxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ArriveName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DepartName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 215)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flight Booking"
        '
        'MangoRadio
        '
        Me.MangoRadio.AutoSize = True
        Me.MangoRadio.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MangoRadio.Location = New System.Drawing.Point(28, 154)
        Me.MangoRadio.Name = "MangoRadio"
        Me.MangoRadio.Size = New System.Drawing.Size(131, 24)
        Me.MangoRadio.TabIndex = 13
        Me.MangoRadio.TabStop = True
        Me.MangoRadio.Text = "Mango Airways"
        Me.MangoRadio.UseVisualStyleBackColor = True
        '
        'KululaRadio
        '
        Me.KululaRadio.AutoSize = True
        Me.KululaRadio.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KululaRadio.Location = New System.Drawing.Point(28, 123)
        Me.KululaRadio.Name = "KululaRadio"
        Me.KululaRadio.Size = New System.Drawing.Size(128, 24)
        Me.KululaRadio.TabIndex = 12
        Me.KululaRadio.TabStop = True
        Me.KululaRadio.Text = "Kulula Airways"
        Me.KululaRadio.UseVisualStyleBackColor = True
        '
        'BritainRadio
        '
        Me.BritainRadio.AutoSize = True
        Me.BritainRadio.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BritainRadio.Location = New System.Drawing.Point(28, 92)
        Me.BritainRadio.Name = "BritainRadio"
        Me.BritainRadio.Size = New System.Drawing.Size(127, 24)
        Me.BritainRadio.TabIndex = 11
        Me.BritainRadio.TabStop = True
        Me.BritainRadio.Text = "British Airways"
        Me.BritainRadio.UseVisualStyleBackColor = True
        '
        'SAARadio
        '
        Me.SAARadio.AutoSize = True
        Me.SAARadio.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAARadio.Location = New System.Drawing.Point(28, 59)
        Me.SAARadio.Name = "SAARadio"
        Me.SAARadio.Size = New System.Drawing.Size(220, 24)
        Me.SAARadio.TabIndex = 10
        Me.SAARadio.TabStop = True
        Me.SAARadio.Text = "South African Airways (SAA)"
        Me.SAARadio.UseVisualStyleBackColor = True
        '
        'Seatnumbertxt
        '
        Me.Seatnumbertxt.FormattingEnabled = True
        Me.Seatnumbertxt.Location = New System.Drawing.Point(366, 139)
        Me.Seatnumbertxt.Name = "Seatnumbertxt"
        Me.Seatnumbertxt.Size = New System.Drawing.Size(125, 28)
        Me.Seatnumbertxt.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Number of Seats on the Flight"
        '
        'ArriveName
        '
        Me.ArriveName.FormattingEnabled = True
        Me.ArriveName.Location = New System.Drawing.Point(563, 139)
        Me.ArriveName.Name = "ArriveName"
        Me.ArriveName.Size = New System.Drawing.Size(186, 28)
        Me.ArriveName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(579, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Arrive Airport Name"
        '
        'DepartName
        '
        Me.DepartName.FormattingEnabled = True
        Me.DepartName.Location = New System.Drawing.Point(563, 58)
        Me.DepartName.Name = "DepartName"
        Me.DepartName.Size = New System.Drawing.Size(186, 28)
        Me.DepartName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(566, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Departure Airport Name"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(317, 58)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 28)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Flight Departure Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Airline Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(357, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(676, 400)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Flight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 457)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Flight"
        Me.Text = "Flight Management Entry"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ArriveName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DepartName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Seatnumbertxt As System.Windows.Forms.ComboBox
    Friend WithEvents MangoRadio As System.Windows.Forms.RadioButton
    Friend WithEvents KululaRadio As System.Windows.Forms.RadioButton
    Friend WithEvents BritainRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SAARadio As System.Windows.Forms.RadioButton

End Class
