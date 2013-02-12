'Project:     MoneyManager
'Programmer:  Cesarin Abreu
'Date:        5/10/11
'Description: This program calculates and display summary of the amount a user spents and helps them
'              have an idea of how much they spend out of their income.

Imports System.IO

Public Class MainForm
    ' Declare public variables.


    Private dirtypBooloean As Boolean
    Friend checkedBoolean As Boolean
    Private responseDialogResult As System.Windows.Forms.DialogResult
    Const ti As Integer = 13


    ' Doing a MonyManager Class to print the current user info.
    Structure MoneyManager
        Dim rentDecimal As Decimal
        Dim cableDecimal As Decimal
        Dim gasDecimal As Decimal
        Dim electricityDecimal As Decimal
        Dim waterDecimal As Decimal
        Dim foodDecimal As Decimal
        Dim clothesDecimal As Decimal
        Dim othersDecimal As Decimal
    End Structure


    Friend rentTotalDecimal, cableTotalDecimal, gasTotalDecimal, electricityTotalDecimal, waterTotalDecimal, foodTotalDecimal, _
    clothesTotalDecimal, othersTotalDecimal, remainingMoneyDecimal, finalAverageDecimal, allDebtTotalDecimal As Decimal

    ' Assuming each month is 4 weeks.
    Const WEEK_Integer As Integer = 4D
    Const DAY_Integer As Integer = 30D ' Assuming each month is 30 weeks.

    Friend usernameString As String

    Private userSpentsMonth(12) As MoneyManager
    Private incomeDecimal As Decimal


    ' Declaring counter
    Friend monthCounter As Integer

    Private selectedButtonString As String

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles ExitToolStripMenuItem1.Click, ExitToolStripMenuItem.Click, exitButton.Click
        ' Close project
        Me.Close()
    End Sub

    Private Sub AddMonthToolStripMenuItem_click(ByVal sender As System.Object, ByVal e As _
    System.EventArgs) Handles AddMonthToolStripMenuItem.Click, doneButton.Click
        ' Calculate and display the current amounts and add to totals.

        Dim debtTotalDecimal As Decimal

        With Me
            ' Allow only 10 shirt types.
            If monthCounter < 12 Then
                If .nameTextBox.Text = "" Then
                    MessageBox.Show("Please enter a name.", _
                    "Data Entry.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    With .nameTextBox
                        .Focus()
                        .SelectAll()
                    End With
                Else
                    usernameString = String.Format(.nameTextBox.Text)
                    Try
                        incomeDecimal = Integer.Parse(.incomeTextBox.Text)
                        Try
                            userSpentsMonth(monthCounter).rentDecimal = Integer.Parse(.rentTextBox.Text)
                            ' Add quantiy to totals
                            Try
                                userSpentsMonth(monthCounter).cableDecimal = Integer.Parse(.cableTextBox.Text)
                                Try
                                    userSpentsMonth(monthCounter).gasDecimal = Integer.Parse(.gasTextBox.Text)
                                    Try
                                        userSpentsMonth(monthCounter).electricityDecimal = Integer.Parse(.electricityTextBox.Text)
                                        Try
                                            userSpentsMonth(monthCounter).waterDecimal = Integer.Parse(.waterTextBox.Text)
                                            Try
                                                userSpentsMonth(monthCounter).foodDecimal = Integer.Parse(.foodTextBox.Text)

                                                Try
                                                    userSpentsMonth(monthCounter).clothesDecimal = Integer.Parse(.clothesTextBox.Text)
                                                    Try
                                                        userSpentsMonth(monthCounter).othersDecimal = Integer.Parse(.otherTextBox.Text)

                                                        ' Add to totals.
                                                        rentTotalDecimal += userSpentsMonth(monthCounter).rentDecimal
                                                        debtTotalDecimal += userSpentsMonth(monthCounter).rentDecimal

                                                        cableTotalDecimal += userSpentsMonth(monthCounter).cableDecimal
                                                        debtTotalDecimal += userSpentsMonth(monthCounter).cableDecimal

                                                        gasTotalDecimal += userSpentsMonth(monthCounter).gasDecimal
                                                        debtTotalDecimal += userSpentsMonth(monthCounter).gasDecimal

                                                        electricityTotalDecimal += userSpentsMonth(monthCounter).electricityDecimal
                                                        debtTotalDecimal += userSpentsMonth(monthCounter).electricityDecimal

                                                        waterTotalDecimal += userSpentsMonth(monthCounter).waterDecimal
                                                        debtTotalDecimal += userSpentsMonth(monthCounter).waterDecimal

                                                        foodTotalDecimal += userSpentsMonth(monthCounter).foodDecimal
                                                        debtTotalDecimal += userSpentsMonth(monthCounter).foodDecimal

                                                        clothesTotalDecimal += userSpentsMonth(monthCounter).clothesDecimal
                                                        debtTotalDecimal += userSpentsMonth(monthCounter).clothesDecimal

                                                        othersTotalDecimal += userSpentsMonth(monthCounter).othersDecimal
                                                        debtTotalDecimal += userSpentsMonth(monthCounter).othersDecimal


                                                        remainingMoneyDecimal += incomeDecimal
                                                        remainingMoneyDecimal -= debtTotalDecimal
                                                        allDebtTotalDecimal += debtTotalDecimal
                                                        If remainingMoneyDecimal < 0 Then
                                                            MessageBox.Show("You are " & remainingMoneyDecimal.ToString("C") & " short in money.")
                                                        ElseIf remainingMoneyDecimal < (debtTotalDecimal / 2) Then
                                                            MessageBox.Show("You are getting short in money.")
                                                        End If

                                                        monthCounter += 1 ' Maintain a count of each order calculation/addition.

                                                        ' Calculate average depending on the option selected by user.
                                                        If OptionsForm.weekRadioButton.Checked = True Then
                                                            finalAverageDecimal = averagertn((WEEK_Integer * monthCounter), allDebtTotalDecimal)
                                                        ElseIf OptionsForm.DayRadioButton.Checked = True Then
                                                            finalAverageDecimal = averagertn((DAY_Integer * monthCounter), allDebtTotalDecimal)
                                                        Else
                                                            finalAverageDecimal = averagertn(monthCounter, allDebtTotalDecimal)
                                                        End If



                                                        .nameTextBox.Enabled = False     ' Disable the nameTextBox.
                                                        .SummaryToolStripMenuItem.Enabled = True ' Disable the summaryButton.

                                                        .dirtypBooloean = True ' Data changed

                                                        ' Clear controls
                                                        .ClearToolStripMenuItem1_Click(sender, e)
                                                        .SaveToolStripMenuItem.Enabled = True
                                                    Catch othersException As FormatException
                                                        MessageBox.Show("The other bill amount must be numeric.", _
                                                        "Data Entry.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        With .otherTextBox
                                                            .Focus()
                                                            .SelectAll()
                                                        End With
                                                    End Try

                                                Catch clothesException As FormatException
                                                    MessageBox.Show("The clothes bill amount must be numeric.", _
                                                    "Data Entry.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    With .clothesTextBox
                                                        .Focus()
                                                        .SelectAll()
                                                    End With
                                                End Try

                                            Catch foodException As FormatException
                                                MessageBox.Show("The food bill amount must be numeric.", _
                                                "Data Entry.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                With .foodTextBox
                                                    .Focus()
                                                    .SelectAll()
                                                End With
                                            End Try

                                        Catch waterException As FormatException
                                            MessageBox.Show("The water bill amount must be numeric.", _
                                            "Data Entry.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            With .waterTextBox
                                                .Focus()
                                                .SelectAll()
                                            End With
                                        End Try

                                    Catch electricityException As FormatException
                                        MessageBox.Show("The electricity bill amount must be numeric.", _
                                        "Data Entry.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        With .electricityTextBox
                                            .Focus()
                                            .SelectAll()
                                        End With
                                    End Try

                                Catch gasException As FormatException
                                    MessageBox.Show("The gas bill amount must be numeric.", _
                                    "Data Entry.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    With .gasTextBox
                                        .Focus()
                                        .SelectAll()
                                    End With
                                End Try
                            Catch cableException As FormatException
                                MessageBox.Show("The cable bill amount must be numeric.", _
                                "Data Entry.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                With .cableTextBox
                                    .Focus()
                                    .SelectAll()
                                End With
                            End Try
                        Catch rentException As FormatException
                            MessageBox.Show("The rent bill amount must be numeric.", _
                            "Data Entry.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            With .rentTextBox
                                .Focus()
                                .SelectAll()
                            End With
                        End Try
                    Catch incomeExcetion As FormatException
                        MessageBox.Show("The income amount must be numeric.", _
                        "Data Entry.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        With .incomeTextBox
                            .Focus()
                            .SelectAll()
                        End With
                    Catch anyException As Exception
                        MessageBox.Show("Error: " & anyException.Message)
                    End Try
                End If
            Else
                MessageBox.Show("This is a trial Version. You are only allowed 12 months.")
            End If
        End With
    End Sub
    Friend Function averagertn(ByVal num As Decimal, ByVal debt As Decimal) As Decimal

        Return debt / num
    End Function


    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Display the summary form.

        summaryForm.ShowDialog()
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem1.Click
        ' Clear all controls.

        With Me
            ' Reset all boxes and variavles
            If Month_noComboBox.Visible Then

                ' set the focus to month combobox
                Month_noComboBox.Focus()
                .incomeTextBox.Clear()
            Else
                With .incomeTextBox
                    .Clear()
                    .Focus()
                End With
            End If
            .rentTextBox.Clear()
            .cableTextBox.Clear()
            .gasTextBox.Clear()
            .electricityTextBox.Clear()
            .waterTextBox.Clear()
            .foodTextBox.Clear()
            .clothesTextBox.Clear()
            .otherTextBox.Clear()

        End With
    End Sub

    Private Sub NewDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDataToolStripMenuItem.Click
        ' Clear evrything, including totals.
        ' Clear all current information and/or display total.


        Dim dialogResult As System.Windows.Forms.DialogResult
        Dim message As String

        With Me

            ' Ask to clear the information.
            message = "This is going to delete all previous information, are you sure you want to delete everything?"
            dialogResult = MessageBox.Show(message, "Delete Data", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If dialogResult = System.Windows.Forms.DialogResult.Yes Then

                ' Learned this from "Help"
                ' Check if the file exist
                If My.Computer.FileSystem.FileExists("datafile.txt") Then

                    ' If the file exist delete
                    My.Computer.FileSystem.DeleteFile("datafile.txt")
                End If

                ' Reset all TextBoxes

                .ClearToolStripMenuItem1_Click(sender, e)

                .remainingMoneyDecimal = 0
                .rentTotalDecimal = 0
                .cableTotalDecimal = 0
                .gasTotalDecimal = 0
                .electricityTotalDecimal = 0
                .waterTotalDecimal = 0
                .foodTotalDecimal = 0
                .clothesTotalDecimal = 0
                .othersTotalDecimal = 0
                .monthCounter = 0
                .allDebtTotalDecimal = 0
                .finalAverageDecimal = 0
                'Re-enable the name text box
                '.nameTextBox.Enabled = True

                'Disable summary
                SummaryToolStripMenuItem.Enabled = False

                'Disable summary
                SaveToolStripMenuItem.Enabled = False


                With .nameTextBox
                    .Enabled = True                 ' Re-enable the name TextBox
                    .Clear()                        ' Clears Name TextBox
                    .Focus()                        ' Name TextBox receives focus
                End With
            End If
        End With


    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        ' Print a report using Print Preview.


        ' Don't print if it was not ran.
        If monthCounter > 0 Then
            With Me
                .PrintPreviewDialog1.Document = .PrintDocument1
                .PrintPreviewDialog1.ShowDialog()
            End With
        Else
            MessageBox.Show("There are not redords to print.")
        End If
    End Sub




    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, _
    ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
    Handles PrintDocument1.PrintPage
        ' Handle print and print previews.

        Dim printFont As New Font("Arial", 12)
        Dim headingFont As New Font("Arial", 16, FontStyle.Bold)
        Dim titleFont As New Font("Arial", 12, FontStyle.Bold)
        Dim lineHeightSingle As Single = printFont.GetHeight + 2
        Dim columnHorizontalLocationSingle() As Single = {e.MarginBounds.Left, _
        200, 310, 420, 500, 570, 260, 320}
        Dim columnHorizontal2LocationSingle As Single
        Dim verticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim printLineString As String
        Dim fontSizeF As New SizeF
        Dim formattedPriceString As String


        For element As Integer = 0 To 4 ' Add first four.
            columnHorizontal2LocationSingle += columnHorizontalLocationSingle(element)
        Next

        ' Set up and display heading lines.
        printLineString = "Money Manager"
        e.Graphics.DrawString(printLineString, headingFont, _
        Brushes.Black, columnHorizontalLocationSingle(6), verticalPrintLocationSingle)
        printLineString = "By Cesarin Abreu"
        verticalPrintLocationSingle += lineHeightSingle * 2
        e.Graphics.DrawString(printLineString, headingFont, _
        Brushes.Black, columnHorizontalLocationSingle(6), verticalPrintLocationSingle)
        verticalPrintLocationSingle += lineHeightSingle * 3




        e.Graphics.DrawString("User Name:", titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(0), verticalPrintLocationSingle)
        e.Graphics.DrawString(usernameString, titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(2), verticalPrintLocationSingle)
        verticalPrintLocationSingle += lineHeightSingle * 2


        ' Increment the Y position for the next line; Decimal space.
        verticalPrintLocationSingle += lineHeightSingle * 2



        ' Setting up and displaying first line of the titles.
        e.Graphics.DrawString("Rent", titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(0), verticalPrintLocationSingle)
        e.Graphics.DrawString("Cable", titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(1), verticalPrintLocationSingle)
        e.Graphics.DrawString("Gas", titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(2), verticalPrintLocationSingle)
        e.Graphics.DrawString("Electricity", titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(3), verticalPrintLocationSingle)


        ' Increment the Y position for the next line; Double space.
        verticalPrintLocationSingle += lineHeightSingle * 2


        ' Display Decimal line.
        e.Graphics.DrawString("==========================================", _
        titleFont, Brushes.Black, columnHorizontalLocationSingle(0), verticalPrintLocationSingle)

        ' Increment the Y position for the next line; Double space.
        verticalPrintLocationSingle += lineHeightSingle * 2


        ' Loop through the order.
        For Each individualMonth As MoneyManager In userSpentsMonth

            If individualMonth.rentDecimal > 0 Or individualMonth.cableDecimal > 0 _
            And individualMonth.gasDecimal > 0 Or individualMonth.electricityDecimal > 0 _
            And individualMonth.waterDecimal > 0 Or individualMonth.foodDecimal > 0 _
            And individualMonth.clothesDecimal > 0 Or individualMonth.othersDecimal > 0 Then
                ' Display shirt types cost

                formattedPriceString = individualMonth.rentDecimal.ToString("C")
                e.Graphics.DrawString(formattedPriceString, titleFont, _
                Brushes.Black, columnHorizontalLocationSingle(0), verticalPrintLocationSingle)
                formattedPriceString = individualMonth.cableDecimal.ToString("C")
                e.Graphics.DrawString(formattedPriceString, titleFont, _
                Brushes.Black, columnHorizontalLocationSingle(1), verticalPrintLocationSingle)
                formattedPriceString = individualMonth.gasDecimal.ToString("C")
                e.Graphics.DrawString(formattedPriceString, titleFont, _
                Brushes.Black, columnHorizontalLocationSingle(2), verticalPrintLocationSingle)
                formattedPriceString = individualMonth.electricityDecimal.ToString("C")
                e.Graphics.DrawString(formattedPriceString, titleFont, _
                Brushes.Black, columnHorizontalLocationSingle(3), verticalPrintLocationSingle)

                ' Increment the Y position for the next line; Double space.
                verticalPrintLocationSingle += lineHeightSingle * 2
            End If
        Next

        ' Increment the Y position for the next line; Double space.
        verticalPrintLocationSingle += lineHeightSingle * 2

        ' Setting up and displaying second line of the titles.
        e.Graphics.DrawString("Water", titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(0), verticalPrintLocationSingle)
        e.Graphics.DrawString("Food", titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(1), verticalPrintLocationSingle)
        e.Graphics.DrawString("Clothes", titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(2), verticalPrintLocationSingle)
        e.Graphics.DrawString("Others", titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(3), verticalPrintLocationSingle)


        ' Increment the Y position for the next line; Double space.
        verticalPrintLocationSingle += lineHeightSingle * 2


        ' Display double line.
        e.Graphics.DrawString("==========================================", _
        titleFont, Brushes.Black, columnHorizontalLocationSingle(0), verticalPrintLocationSingle)

        ' Increment the Y position for the next line; Double space.
        verticalPrintLocationSingle += lineHeightSingle * 2



        ' Loop through the order.
        For Each individualMonth As MoneyManager In userSpentsMonth

            If individualMonth.rentDecimal > 0 Or individualMonth.cableDecimal > 0 _
             And individualMonth.gasDecimal > 0 Or individualMonth.electricityDecimal > 0 _
             And individualMonth.waterDecimal > 0 Or individualMonth.foodDecimal > 0 _
             And individualMonth.clothesDecimal > 0 Or individualMonth.othersDecimal > 0 Then
                ' Display shirt types cost

                formattedPriceString = individualMonth.waterDecimal.ToString("C")
                e.Graphics.DrawString(formattedPriceString, titleFont, _
                Brushes.Black, columnHorizontalLocationSingle(0), verticalPrintLocationSingle)
                formattedPriceString = individualMonth.foodDecimal.ToString("C")
                e.Graphics.DrawString(formattedPriceString, titleFont, _
                Brushes.Black, columnHorizontalLocationSingle(1), verticalPrintLocationSingle)
                formattedPriceString = individualMonth.clothesDecimal.ToString("C")
                e.Graphics.DrawString(formattedPriceString, titleFont, _
                Brushes.Black, columnHorizontalLocationSingle(2), verticalPrintLocationSingle)
                formattedPriceString = individualMonth.othersDecimal.ToString("C")
                e.Graphics.DrawString(formattedPriceString, titleFont, _
                Brushes.Black, columnHorizontalLocationSingle(3), verticalPrintLocationSingle)

                ' Increment the Y position for the next line; Double space.
                verticalPrintLocationSingle += lineHeightSingle * 2
            End If
        Next


        verticalPrintLocationSingle += lineHeightSingle * 2

        e.Graphics.DrawString("Remaining Money:", titleFont, _
        Brushes.Black, columnHorizontalLocationSingle(0), verticalPrintLocationSingle)
        e.Graphics.DrawString(remainingMoneyDecimal.ToString("C"), titleFont, Brushes.Black, _
        columnHorizontalLocationSingle(3), verticalPrintLocationSingle)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display the aboutbox form.

        AboutBox1.ShowDialog()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
Handles FontToolStripMenuItem1.Click, FontToolStripMenuItem.Click
        ' Allow the user to select a new font for the slogan.

        With Me.FontDialog1
            .Font = Me.sloganLabel.Font
            .ShowDialog()
            Me.sloganLabel.Font = .Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles ColorToolStripMenuItem1.Click, ColorToolStripMenuItem.Click
        ' Allow the user to select a new color for the slogan.


        With Me.ColorDialog1
            .Color = Me.sloganLabel.ForeColor
            .ShowDialog()
            Me.sloganLabel.ForeColor = .Color
        End With
    End Sub

    Private Sub SloganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SloganToolStripMenuItem.Click

        ' Hide the slogan if unchecked.
        If SloganToolStripMenuItem.Checked Then
            Me.sloganLabel.Visible = False
        Else
            Me.sloganLabel.Visible = True
        End If
    End Sub

    Private Sub LogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoToolStripMenuItem.Click, PictureBox1.Click

        ' Hide the logo if unchecked.

        If LogoToolStripMenuItem.Checked Then
            Me.PictureBox1.Visible = False
        Else
            Me.PictureBox1.Visible = True
        End If
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        ' Display options
        OptionsForm.ShowDialog()


        ' Enable defult values
        If Me.checkedBoolean Then
            Month_noComboBox.Visible = True
            Label12.Visible = True

            'This line of code loads data into the 'MoneyManagerDatabaseDataSet._Default' table.
            DefaultTableAdapter.Fill(MoneyManagerDatabaseDataSet._Default)
        Else

            ' If it is false disavle and clear mainform text boxes.
            Month_noComboBox.Visible = False
            Label12.Visible = False
            With Me
                ' Reset all boxes and variavles

                If .nameTextBox.Enabled Then

                    .nameTextBox.Focus()
                    .incomeTextBox.Clear()
                Else
                    With .incomeTextBox
                        .Clear()
                        .Focus()
                    End With
                End If
                .rentTextBox.Clear()
                .cableTextBox.Clear()
                .gasTextBox.Clear()
                .electricityTextBox.Clear()
                .waterTextBox.Clear()
                .foodTextBox.Clear()
                .clothesTextBox.Clear()
                .otherTextBox.Clear()
            End With

            ' Clear all controls.

        End If
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ' Ask the user to save
        Dim messageString As String = "You made changes. Save changes?"

        If dirtypBooloean Then
            responseDialogResult = MessageBox.Show(messageString, "Data Changed", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If responseDialogResult = Windows.Forms.DialogResult.Yes Then

                SaveToolStripMenuItem_Click(sender, e)
            End If
        End If

    End Sub


    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LoginForm1.ShowDialog()
        If LoginForm1.LoginBoolean Then
            ' Display date in a maskedtextbox
            Dim dateTimeDate As Date
            dateTimeDate = Now
            Me.dateMaskedTextBox.Text = dateTimeDate.ToString("d")

            ' Load the totals if any
            Dim dataIn(ti) As String
            Dim i As Integer = 0

            Try
                ' Open file
                Dim dataFileStremReader As New StreamReader("datafile.txt")
                ' Read all elements
                Do Until dataFileStremReader.Peek = -1

                    dataIn(i) = dataFileStremReader.ReadLine()
                    i += 1
                Loop
                ' Close the file
                dataFileStremReader.Close()
                With Me
                    With .nameTextBox
                        .Text = dataIn(0)
                        .Enabled = False 'Re-enable the name text box

                    End With
                    .rentTotalDecimal = dataIn(1)
                    .cableTotalDecimal = dataIn(2)
                    .gasTotalDecimal = dataIn(3)
                    .electricityTotalDecimal = dataIn(4)
                    .waterTotalDecimal = dataIn(5)
                    .foodTotalDecimal = dataIn(6)
                    .clothesTotalDecimal = dataIn(7)
                    .othersTotalDecimal = dataIn(8)
                    .remainingMoneyDecimal = dataIn(9)
                    .monthCounter = dataIn(10)
                    .allDebtTotalDecimal = dataIn(11)
                    .finalAverageDecimal = dataIn(12)
                    If dataIn(0) = "" Then
                        .nameTextBox.Enabled = True
                        .SummaryToolStripMenuItem.Enabled = False
                        .SaveToolStripMenuItem.Enabled = False
                    Else
                        .SummaryToolStripMenuItem.Enabled = True ' Enable the summaryButton.
                    End If
                End With
            Catch dataException As Exception
                ' File does not exist?
                responseDialogResult = MessageBox.Show("Create a new file?", "New File", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If responseDialogResult = Windows.Forms.DialogResult.No Then
                    ' Exit program
                    Me.Close()
                End If
            End Try
        Else
            End
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '5
        ' Save data
        Dim dataOut(ti) As String

        With Me
            dataOut(0) = .nameTextBox.Text

            dataOut(1) = .rentTotalDecimal.ToString()
            dataOut(2) = .cableTotalDecimal.ToString()
            dataOut(3) = .gasTotalDecimal.ToString()
            dataOut(4) = .electricityTotalDecimal.ToString()
            dataOut(5) = .waterTotalDecimal.ToString()
            dataOut(6) = .foodTotalDecimal.ToString()
            dataOut(7) = .clothesTotalDecimal.ToString()
            dataOut(8) = .othersTotalDecimal.ToString()
            dataOut(9) = .remainingMoneyDecimal.ToString()
            dataOut(10) = .monthCounter.ToString()
            dataOut(11) = .allDebtTotalDecimal.ToString()
            dataOut(12) = .finalAverageDecimal.ToString()
        End With

        ' Open file
        Dim dataFileWriter As New StreamWriter("datafile.txt")
        ' Save items in the data file
        For element As Integer = 0 To ti
            dataFileWriter.WriteLine(dataOut(element))

        Next


        ' Close the file
        dataFileWriter.Close()

        ' Reset dirtyboolean to false
        dirtypBooloean = False
    End Sub

    Private Sub DefaultBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DefaultBindingSource.EndEdit()
        Me.DefaultTableAdapter.Update(Me.MoneyManagerDatabaseDataSet._Default)

    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        ' Display form with a DataGrid to view the database

        DataGridForm.Show()
    End Sub
End Class
