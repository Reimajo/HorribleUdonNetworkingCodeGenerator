Public Class owo
    ''' <summary>
    ''' Don't look at this, it's the worst shit I ever wrote
    ''' </summary>
    Private Sub ButtonStartConversion_Click(sender As Object, e As EventArgs) Handles ButtonStartConversion.Click
        If (CheckBoxAutoClear.Checked) Then
            OutputOfBadSourcecode.Text = ""
        End If
        Dim inputGoodCode As String = InputOfGoodSourcecode.Text
        If (InputArray1.Text.Trim = "") Then
            MsgBox("Array 1 is empty")
        ElseIf inputGoodCode.Trim = "" Then
            MsgBox("Input sourcecode is empty")
        ElseIf (InStr(inputGoodCode, "#1#")) = 0 Then
            MsgBox("Input sourcecode has no variable placeholder like #1# so there is nothing to insert the array values into")
        Else
            'Array 1 determines how long the resulted code array is
            Dim inputArray1Str As String() = InputArray1.Text.Split(",")
            'Prepare output array with values
            Dim outputBadCode(inputArray1Str.Length - 1) As String
            Dim i As Integer = 0
            For Each arrayValue In inputArray1Str
                outputBadCode(i) = inputGoodCode.Replace("#1#", arrayValue)
                i += 1
            Next
            'Insert all other arrays
            outputBadCode = InsertTextFieldArrayIntoString("#2#", outputBadCode, InputArray2)
            outputBadCode = InsertTextFieldArrayIntoString("#3#", outputBadCode, InputArray3)
            outputBadCode = InsertTextFieldArrayIntoString("#4#", outputBadCode, InputArray4)
            If Not (InputJaggedArray1.Text.Trim = "") Then
                Dim sourceCodeSoFar As String = ArrayToString(outputBadCode)
                'Jagged array 1 determines how long the resulted code array is
                Dim inputJaggedArray1Str As String() = InputJaggedArray1.Text.Split(",")
                'Prepare output array with values
                Dim jaggedOutputBadCode(inputJaggedArray1Str.Length - 1) As String
                Dim j As Integer = 0
                For Each arrayValue In inputJaggedArray1Str
                    jaggedOutputBadCode(j) = sourceCodeSoFar.Replace("#J1#", arrayValue)
                    j += 1
                Next
                outputBadCode = jaggedOutputBadCode
                outputBadCode = InsertTextFieldArrayIntoString("#J2#", outputBadCode, InputJaggedArray2)
                outputBadCode = InsertTextFieldArrayIntoString("#J3#", outputBadCode, InputJaggedArray3)
            End If
            'Output the result
            OutputOfBadSourcecode.Text += ArrayToString(outputBadCode)
            Clipboard.SetText(OutputOfBadSourcecode.Text)
        End If
    End Sub
    ''' <summary>
    ''' Inserting one other textbox array input into the result
    ''' </summary>
    Private Function InsertTextFieldArrayIntoString(placeholder As String, outputBadCode As String(), InputArrayTextBox As TextBox) As String()
        Dim inputArrayStr As String() = InputArrayTextBox.Text.Split(",")
        If (InputArrayTextBox.Text.Trim = "") Then
            Return outputBadCode
        ElseIf outputBadCode.Length <> inputArrayStr.Length Then
            MsgBox("Array " & placeholder & " needs to have no values or exactly the same amount of values as array 1")
        Else
            Dim i As Integer = 0
            For Each arrayValue In inputArrayStr
                outputBadCode(i) = outputBadCode(i).Replace(placeholder, arrayValue)
                i += 1
            Next
        End If
        Return outputBadCode
    End Function

    Private Function ArrayToString(array As String()) As String
        Dim resultStr As String = ""
        For Each singleString In array
            resultStr += singleString & vbNewLine
        Next
        Return resultStr
    End Function

    Private Sub ButtonClearInputField_Click(sender As Object, e As EventArgs) Handles ButtonClearInputField.Click
        InputOfGoodSourcecode.Text = ""
    End Sub

    Private Sub ButtonClearOutputField_Click(sender As Object, e As EventArgs) Handles ButtonClearOutputField.Click
        OutputOfBadSourcecode.Text = ""
    End Sub

    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click
        Dim inputFromAsInt As Integer
        If Not Integer.TryParse(TextBoxInputFrom.Text, inputFromAsInt) Then
            MsgBox("Input field 'from' is not an integer value")
            Return
        End If
        Dim inputToAsInt As Integer
        If Not Integer.TryParse(TextBoxInputTo.Text, inputToAsInt) Then
            MsgBox("Input field 'to' is not an integer value")
            Return
        End If
        If Not inputFromAsInt < inputToAsInt Then
            MsgBox("Input field 'from' is smaller than input field 'to'")
            Return
        End If
        Dim outputStr As String = inputFromAsInt
        While (inputFromAsInt < inputToAsInt)
            inputFromAsInt += 1
            outputStr += "," & inputFromAsInt
        End While
        Clipboard.SetText(outputStr)
    End Sub
End Class
