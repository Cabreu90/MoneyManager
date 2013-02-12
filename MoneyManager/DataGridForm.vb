Public Class DataGridForm

    Private Sub DataGridForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoneyManagerDatabaseDataSet._Default' table. You can move, or remove it, as needed.
        Me.DefaultTableAdapter.Fill(Me.MoneyManagerDatabaseDataSet._Default)

    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        ' Close form
        Me.Hide()
    End Sub
End Class