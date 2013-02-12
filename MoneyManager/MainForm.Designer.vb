<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.nameTextBox = New System.Windows.Forms.TextBox
        Me.incomeTextBox = New System.Windows.Forms.TextBox
        Me.DefaultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoneyManagerDatabaseDataSet = New Global.MoneyManager.MoneyManagerDatabaseDataSet
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.clothesTextBox = New System.Windows.Forms.TextBox
        Me.otherTextBox = New System.Windows.Forms.TextBox
        Me.waterTextBox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.foodTextBox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.gasTextBox = New System.Windows.Forms.TextBox
        Me.electricityTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.rentTextBox = New System.Windows.Forms.TextBox
        Me.cableTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DefaultTableAdapter = New Global.MoneyManager.MoneyManagerDatabaseDataSetTableAdapters.DefaultTableAdapter
        Me.Label12 = New System.Windows.Forms.Label
        Me.dateMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Month_noComboBox = New System.Windows.Forms.ComboBox
        Me.sloganLabel = New System.Windows.Forms.Label
        Me.exitButton = New System.Windows.Forms.Button
        Me.doneButton = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddMonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SloganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.DefaultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyManagerDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(119, 95)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nameTextBox.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.nameTextBox, "Enter,your name here.")
        '
        'incomeTextBox
        '
        Me.incomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DefaultBindingSource, "income", True))
        Me.incomeTextBox.Location = New System.Drawing.Point(119, 157)
        Me.incomeTextBox.Name = "incomeTextBox"
        Me.incomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.incomeTextBox.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.incomeTextBox, "Enter, the amount of money" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you have.")
        '
        'DefaultBindingSource
        '
        Me.DefaultBindingSource.DataMember = "Default"
        Me.DefaultBindingSource.DataSource = Me.MoneyManagerDatabaseDataSet
        '
        'MoneyManagerDatabaseDataSet
        '
        Me.MoneyManagerDatabaseDataSet.DataSetName = "MoneyManagerDatabaseDataSet"
        Me.MoneyManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clothesTextBox)
        Me.GroupBox1.Controls.Add(Me.otherTextBox)
        Me.GroupBox1.Controls.Add(Me.waterTextBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.foodTextBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.gasTextBox)
        Me.GroupBox1.Controls.Add(Me.electricityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rentTextBox)
        Me.GroupBox1.Controls.Add(Me.cableTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 241)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monthly &Bills"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Enter the amount due.")
        '
        'clothesTextBox
        '
        Me.clothesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DefaultBindingSource, "clothes", True))
        Me.clothesTextBox.Location = New System.Drawing.Point(75, 175)
        Me.clothesTextBox.Name = "clothesTextBox"
        Me.clothesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.clothesTextBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.clothesTextBox, "Enter 0, if not applicable.")
        '
        'otherTextBox
        '
        Me.otherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DefaultBindingSource, "others", True))
        Me.otherTextBox.Location = New System.Drawing.Point(75, 201)
        Me.otherTextBox.Name = "otherTextBox"
        Me.otherTextBox.Size = New System.Drawing.Size(100, 20)
        Me.otherTextBox.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.otherTextBox, "Enter 0, if not applicable.")
        '
        'waterTextBox
        '
        Me.waterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DefaultBindingSource, "water", True))
        Me.waterTextBox.Location = New System.Drawing.Point(75, 123)
        Me.waterTextBox.Name = "waterTextBox"
        Me.waterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.waterTextBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.waterTextBox, "Enter 0, if not applicable.")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "C&lothes:"
        '
        'foodTextBox
        '
        Me.foodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DefaultBindingSource, "food", True))
        Me.foodTextBox.Location = New System.Drawing.Point(75, 149)
        Me.foodTextBox.Name = "foodTextBox"
        Me.foodTextBox.Size = New System.Drawing.Size(100, 20)
        Me.foodTextBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.foodTextBox, "Enter 0, if not applicable.")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "&Other:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "&Water:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "F&ood:"
        '
        'gasTextBox
        '
        Me.gasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DefaultBindingSource, "cable", True))
        Me.gasTextBox.Location = New System.Drawing.Point(75, 71)
        Me.gasTextBox.Name = "gasTextBox"
        Me.gasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.gasTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.gasTextBox, "Enter 0, if not applicable.")
        '
        'electricityTextBox
        '
        Me.electricityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DefaultBindingSource, "electricity", True))
        Me.electricityTextBox.Location = New System.Drawing.Point(75, 97)
        Me.electricityTextBox.Name = "electricityTextBox"
        Me.electricityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.electricityTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.electricityTextBox, "Enter 0, if not applicable.")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "&Gas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "&Electricity:"
        '
        'rentTextBox
        '
        Me.rentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DefaultBindingSource, "rent", True))
        Me.rentTextBox.Location = New System.Drawing.Point(75, 19)
        Me.rentTextBox.Name = "rentTextBox"
        Me.rentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.rentTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.rentTextBox, "Enter 0, if not applicable.")
        '
        'cableTextBox
        '
        Me.cableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DefaultBindingSource, "cable", True))
        Me.cableTextBox.Location = New System.Drawing.Point(75, 45)
        Me.cableTextBox.Name = "cableTextBox"
        Me.cableTextBox.Size = New System.Drawing.Size(100, 20)
        Me.cableTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cableTextBox, "Enter 0, if not applicable.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Rent:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ca&ble:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem1, Me.FontToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(112, 70)
        '
        'ColorToolStripMenuItem1
        '
        Me.ColorToolStripMenuItem1.Name = "ColorToolStripMenuItem1"
        Me.ColorToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.ColorToolStripMenuItem1.Text = "&Color..."
        '
        'FontToolStripMenuItem1
        '
        Me.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        Me.FontToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.FontToolStripMenuItem1.Text = "&Font.."
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'DefaultTableAdapter
        '
        Me.DefaultTableAdapter.ClearBeforeFill = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(68, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "&Month:"
        Me.Label12.Visible = False
        '
        'dateMaskedTextBox
        '
        Me.dateMaskedTextBox.Location = New System.Drawing.Point(283, 5)
        Me.dateMaskedTextBox.Mask = "0/00/0000"
        Me.dateMaskedTextBox.Name = "dateMaskedTextBox"
        Me.dateMaskedTextBox.ReadOnly = True
        Me.dateMaskedTextBox.Size = New System.Drawing.Size(75, 20)
        Me.dateMaskedTextBox.TabIndex = 39
        Me.dateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Month_noComboBox
        '
        Me.Month_noComboBox.DataSource = Me.DefaultBindingSource
        Me.Month_noComboBox.DisplayMember = "month_no"
        Me.Month_noComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Month_noComboBox.FormattingEnabled = True
        Me.Month_noComboBox.Location = New System.Drawing.Point(119, 127)
        Me.Month_noComboBox.Name = "Month_noComboBox"
        Me.Month_noComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Month_noComboBox.TabIndex = 30
        Me.Month_noComboBox.Visible = False
        '
        'sloganLabel
        '
        Me.sloganLabel.AutoSize = True
        Me.sloganLabel.Location = New System.Drawing.Point(173, 61)
        Me.sloganLabel.Name = "sloganLabel"
        Me.sloganLabel.Size = New System.Drawing.Size(173, 13)
        Me.sloganLabel.TabIndex = 27
        Me.sloganLabel.Text = "Where you don't need a calculator."
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(190, 434)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 35
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'doneButton
        '
        Me.doneButton.Location = New System.Drawing.Point(271, 434)
        Me.doneButton.Name = "doneButton"
        Me.doneButton.Size = New System.Drawing.Size(75, 23)
        Me.doneButton.TabIndex = 34
        Me.doneButton.Text = "&Done"
        Me.doneButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(194, 460)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Programmed by: Cesarin Abreu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Monthly &Income:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "&Name:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(357, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDataToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ToolStripSeparator2, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewDataToolStripMenuItem
        '
        Me.NewDataToolStripMenuItem.Name = "NewDataToolStripMenuItem"
        Me.NewDataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewDataToolStripMenuItem.Text = "&New Data"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Enabled = False
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "&Print Page..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMonthToolStripMenuItem, Me.ClearToolStripMenuItem1, Me.OptionsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddMonthToolStripMenuItem
        '
        Me.AddMonthToolStripMenuItem.Name = "AddMonthToolStripMenuItem"
        Me.AddMonthToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AddMonthToolStripMenuItem.Text = "&Add Month"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ClearToolStripMenuItem1.Text = "Cl&ear"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options..."
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem, Me.ToolStripSeparator1, Me.SloganToolStripMenuItem, Me.LogoToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.FontToolStripMenuItem.Text = "&Font..."
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ColorToolStripMenuItem.Text = "&Color..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(108, 6)
        '
        'SloganToolStripMenuItem
        '
        Me.SloganToolStripMenuItem.Checked = True
        Me.SloganToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SloganToolStripMenuItem.Name = "SloganToolStripMenuItem"
        Me.SloganToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.SloganToolStripMenuItem.Text = "Sloga&n"
        '
        'LogoToolStripMenuItem
        '
        Me.LogoToolStripMenuItem.Checked = True
        Me.LogoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LogoToolStripMenuItem.Name = "LogoToolStripMenuItem"
        Me.LogoToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.LogoToolStripMenuItem.Text = "&Logo"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ViewToolStripMenuItem.Text = "&View Database..."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 479)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dateMaskedTextBox)
        Me.Controls.Add(Me.Month_noComboBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.sloganLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.doneButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.incomeTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Money Manager"
        CType(Me.DefaultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyManagerDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoneyManagerDatabaseDataSet As Global.MoneyManager.MoneyManagerDatabaseDataSet
    Friend WithEvents DefaultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DefaultTableAdapter As Global.MoneyManager.MoneyManagerDatabaseDataSetTableAdapters.DefaultTableAdapter
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Month_noComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sloganLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents doneButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents incomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents clothesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents otherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents waterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents foodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents electricityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cableTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMonthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SloganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
