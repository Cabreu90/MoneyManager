'Project:     MoneyManager
'Programmer:  Cesarin Abreu
'Date:        5/10/11
'Description: This Form display summary of the amount a user spents.

Public Class summaryForm

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        ' Close this summary form.

        Me.Hide()
    End Sub

    Private Sub summaryForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ' Display summary

        ' Display totals.
        rentTextBox.Text = MainForm.rentTotalDecimal.ToString("C")
        cableTextBox.Text = MainForm.cableTotalDecimal.ToString("C")
        gasTextBox.Text = MainForm.gasTotalDecimal.ToString("C")
        electricityTextBox.Text = MainForm.electricityTotalDecimal.ToString("C")
        waterTextBox.Text = MainForm.waterTotalDecimal.ToString("C")
        foodTextBox.Text = MainForm.foodTotalDecimal.ToString("C")
        clothsTextBox.Text = MainForm.clothesTotalDecimal.ToString("C")
        otherTextBox.Text = MainForm.othersTotalDecimal.ToString("C")
        totalTextBox.Text = MainForm.allDebtTotalDecimal.ToString("C")

        'Display the amount of money the user hae left after paying debts.
        remainingTextBox.Text = MainForm.remainingMoneyDecimal.ToString("C")

        'Display average.
        averageTextBox.Text = MainForm.finalAverageDecimal.ToString("C")
    End Sub
End Class