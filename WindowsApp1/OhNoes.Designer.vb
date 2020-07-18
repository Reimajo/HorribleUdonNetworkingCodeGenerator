<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class owo
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(owo))
        Me.ButtonStartConversion = New System.Windows.Forms.Button()
        Me.InputArray2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InputArray3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InputArray4 = New System.Windows.Forms.TextBox()
        Me.InputOfGoodSourcecode = New System.Windows.Forms.TextBox()
        Me.OutputOfBadSourcecode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InputArray1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InputJaggedArray1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InputJaggedArray2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InputJaggedArray3 = New System.Windows.Forms.TextBox()
        Me.ButtonClearInputField = New System.Windows.Forms.Button()
        Me.ButtonClearOutputField = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxInputFrom = New System.Windows.Forms.TextBox()
        Me.TextBoxInputTo = New System.Windows.Forms.TextBox()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckBoxAutoClear = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ButtonStartConversion
        '
        Me.ButtonStartConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonStartConversion.Location = New System.Drawing.Point(251, 461)
        Me.ButtonStartConversion.Name = "ButtonStartConversion"
        Me.ButtonStartConversion.Size = New System.Drawing.Size(350, 34)
        Me.ButtonStartConversion.TabIndex = 0
        Me.ButtonStartConversion.Text = "Start horrible conversion for Udon"
        Me.ButtonStartConversion.UseVisualStyleBackColor = True
        '
        'InputArray2
        '
        Me.InputArray2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.InputArray2.Location = New System.Drawing.Point(294, 51)
        Me.InputArray2.Name = "InputArray2"
        Me.InputArray2.Size = New System.Drawing.Size(500, 26)
        Me.InputArray2.TabIndex = 1
        Me.InputArray2.Text = "a,b,c"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(21, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Array 2 (comma-seperated list) #2#"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(21, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Array 3 (comma-seperated list) #3#"
        '
        'InputArray3
        '
        Me.InputArray3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.InputArray3.Location = New System.Drawing.Point(294, 83)
        Me.InputArray3.Name = "InputArray3"
        Me.InputArray3.Size = New System.Drawing.Size(500, 26)
        Me.InputArray3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(21, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Array 4 (comma-seperated list) #4#"
        '
        'InputArray4
        '
        Me.InputArray4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.InputArray4.Location = New System.Drawing.Point(294, 115)
        Me.InputArray4.Name = "InputArray4"
        Me.InputArray4.Size = New System.Drawing.Size(500, 26)
        Me.InputArray4.TabIndex = 5
        '
        'InputOfGoodSourcecode
        '
        Me.InputOfGoodSourcecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.InputOfGoodSourcecode.Location = New System.Drawing.Point(25, 258)
        Me.InputOfGoodSourcecode.Multiline = True
        Me.InputOfGoodSourcecode.Name = "InputOfGoodSourcecode"
        Me.InputOfGoodSourcecode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.InputOfGoodSourcecode.Size = New System.Drawing.Size(769, 186)
        Me.InputOfGoodSourcecode.TabIndex = 7
        Me.InputOfGoodSourcecode.Text = "MyFunction#J1#(Button#1#,""#2#"");"
        '
        'OutputOfBadSourcecode
        '
        Me.OutputOfBadSourcecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.OutputOfBadSourcecode.Location = New System.Drawing.Point(25, 514)
        Me.OutputOfBadSourcecode.Multiline = True
        Me.OutputOfBadSourcecode.Name = "OutputOfBadSourcecode"
        Me.OutputOfBadSourcecode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputOfBadSourcecode.Size = New System.Drawing.Size(769, 251)
        Me.OutputOfBadSourcecode.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(21, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Array 1 (comma-seperated list) #1#"
        '
        'InputArray1
        '
        Me.InputArray1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.InputArray1.Location = New System.Drawing.Point(294, 19)
        Me.InputArray1.Name = "InputArray1"
        Me.InputArray1.Size = New System.Drawing.Size(500, 26)
        Me.InputArray1.TabIndex = 9
        Me.InputArray1.Text = "1,2,3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(21, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(319, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Jagged array 1 (comma-seperated list) #J1#"
        '
        'InputJaggedArray1
        '
        Me.InputJaggedArray1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.InputJaggedArray1.Location = New System.Drawing.Point(355, 150)
        Me.InputJaggedArray1.Name = "InputJaggedArray1"
        Me.InputJaggedArray1.Size = New System.Drawing.Size(439, 26)
        Me.InputJaggedArray1.TabIndex = 11
        Me.InputJaggedArray1.Text = "A,B,C"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(21, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(319, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jagged array 1 (comma-seperated list) #J2#"
        '
        'InputJaggedArray2
        '
        Me.InputJaggedArray2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.InputJaggedArray2.Location = New System.Drawing.Point(355, 183)
        Me.InputJaggedArray2.Name = "InputJaggedArray2"
        Me.InputJaggedArray2.Size = New System.Drawing.Size(439, 26)
        Me.InputJaggedArray2.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(21, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(319, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Jagged array 1 (comma-seperated list) #J3#"
        '
        'InputJaggedArray3
        '
        Me.InputJaggedArray3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.InputJaggedArray3.Location = New System.Drawing.Point(355, 217)
        Me.InputJaggedArray3.Name = "InputJaggedArray3"
        Me.InputJaggedArray3.Size = New System.Drawing.Size(439, 26)
        Me.InputJaggedArray3.TabIndex = 15
        '
        'ButtonClearInputField
        '
        Me.ButtonClearInputField.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonClearInputField.Location = New System.Drawing.Point(810, 258)
        Me.ButtonClearInputField.Name = "ButtonClearInputField"
        Me.ButtonClearInputField.Size = New System.Drawing.Size(119, 186)
        Me.ButtonClearInputField.TabIndex = 17
        Me.ButtonClearInputField.Text = "Clear Input Field"
        Me.ButtonClearInputField.UseVisualStyleBackColor = True
        '
        'ButtonClearOutputField
        '
        Me.ButtonClearOutputField.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonClearOutputField.Location = New System.Drawing.Point(810, 514)
        Me.ButtonClearOutputField.Name = "ButtonClearOutputField"
        Me.ButtonClearOutputField.Size = New System.Drawing.Size(119, 251)
        Me.ButtonClearOutputField.TabIndex = 18
        Me.ButtonClearOutputField.Text = "Clear Output Field"
        Me.ButtonClearOutputField.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(21, 470)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Result is copied to clipboard"
        '
        'TextBoxInputFrom
        '
        Me.TextBoxInputFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBoxInputFrom.Location = New System.Drawing.Point(810, 51)
        Me.TextBoxInputFrom.Name = "TextBoxInputFrom"
        Me.TextBoxInputFrom.Size = New System.Drawing.Size(119, 26)
        Me.TextBoxInputFrom.TabIndex = 20
        Me.TextBoxInputFrom.Text = "1"
        '
        'TextBoxInputTo
        '
        Me.TextBoxInputTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBoxInputTo.Location = New System.Drawing.Point(810, 115)
        Me.TextBoxInputTo.Name = "TextBoxInputTo"
        Me.TextBoxInputTo.Size = New System.Drawing.Size(119, 26)
        Me.TextBoxInputTo.TabIndex = 21
        Me.TextBoxInputTo.Text = "10"
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonGenerate.Location = New System.Drawing.Point(810, 150)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(119, 44)
        Me.ButtonGenerate.TabIndex = 22
        Me.ButtonGenerate.Text = "Generate"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(808, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Result is copied"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(808, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "to clipboard"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(808, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "from"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(808, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "to"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(637, 470)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 20)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Auto-Clear:"
        '
        'CheckBoxAutoClear
        '
        Me.CheckBoxAutoClear.AutoSize = True
        Me.CheckBoxAutoClear.Checked = True
        Me.CheckBoxAutoClear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAutoClear.Location = New System.Drawing.Point(733, 472)
        Me.CheckBoxAutoClear.Name = "CheckBoxAutoClear"
        Me.CheckBoxAutoClear.Size = New System.Drawing.Size(129, 17)
        Me.CheckBoxAutoClear.TabIndex = 28
        Me.CheckBoxAutoClear.Text = "Auto-clear output field"
        Me.CheckBoxAutoClear.UseVisualStyleBackColor = True
        '
        'owo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 779)
        Me.Controls.Add(Me.CheckBoxAutoClear)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Controls.Add(Me.TextBoxInputTo)
        Me.Controls.Add(Me.TextBoxInputFrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonClearOutputField)
        Me.Controls.Add(Me.ButtonClearInputField)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.InputJaggedArray3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.InputJaggedArray2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.InputJaggedArray1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InputArray1)
        Me.Controls.Add(Me.OutputOfBadSourcecode)
        Me.Controls.Add(Me.InputOfGoodSourcecode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.InputArray4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InputArray3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputArray2)
        Me.Controls.Add(Me.ButtonStartConversion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "owo"
        Me.Text = "I'm so sorry for making this"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonStartConversion As Button
    Friend WithEvents InputArray2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InputArray3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents InputArray4 As TextBox
    Friend WithEvents InputOfGoodSourcecode As TextBox
    Friend WithEvents OutputOfBadSourcecode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents InputArray1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents InputJaggedArray1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents InputJaggedArray2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents InputJaggedArray3 As TextBox
    Friend WithEvents ButtonClearInputField As Button
    Friend WithEvents ButtonClearOutputField As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxInputFrom As TextBox
    Friend WithEvents TextBoxInputTo As TextBox
    Friend WithEvents ButtonGenerate As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBoxAutoClear As CheckBox
End Class
