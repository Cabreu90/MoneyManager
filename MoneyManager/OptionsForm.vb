Public Class OptionsForm
    ' Declaring module-level variables
    Private selectionString As String
    Private selectionBoolean As Boolean = False
    Private t As Integer

    Private Sub OptionsForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        With Me
            ' Save the current selected button
            If Me.weekRadioButton.Checked = True Then
                selectionString = "W"
            ElseIf .DayRadioButton.Checked = True Then
                selectionString = "D"
            Else
                selectionString = "M"
            End If

            ' Save check box check state
            selectionBoolean = Me.CheckBox1.Checked

            ' Disable the apply button
            Me.Button1.Enabled = False
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Reset controls
        With Me
            Select Case selectionString
                Case "W"
                    .weekRadioButton.Checked = True
                Case "D"
                    .DayRadioButton.Checked = True
                Case Else
                    .monthRadioButton.Checked = True
            End Select

            MainForm.checkedBoolean = selectionBoolean

            ' Close window
            .Close()
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Closes form
        Me.Close()

    End Sub

    Private Sub monthRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles monthRadioButton.CheckedChanged, _
    weekRadioButton.CheckedChanged, DayRadioButton.CheckedChanged, CheckBox1.CheckedChanged
        ' Enable the apply button
        Me.Button1.Enabled = True
    End Sub

    Private Sub OptionsForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
       
        ' Calculate Average
        Dim num2 As Integer = MainForm.monthCounter
        If num2 = 0 Then num2 = 1

        ' Calculate average depending on the option selected by user.
        If Me.weekRadioButton.Checked = True Then
            MainForm.finalAverageDecimal = MainForm.averagertn((4 * num2), MainForm.allDebtTotalDecimal)
        ElseIf Me.DayRadioButton.Checked = True Then
            MainForm.finalAverageDecimal = MainForm.averagertn((30 * num2), MainForm.allDebtTotalDecimal)
        Else
            MainForm.finalAverageDecimal = MainForm.averagertn(num2, MainForm.allDebtTotalDecimal)
        End If

        MainForm.checkedBoolean = Me.CheckBox1.Checked
    End Sub
End Class