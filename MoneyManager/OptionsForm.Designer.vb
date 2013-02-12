<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DayRadioButton = New System.Windows.Forms.RadioButton
        Me.weekRadioButton = New System.Windows.Forms.RadioButton
        Me.monthRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(19, 154)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(131, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "&Enable Default Values"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(39, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(93, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select week if you want" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the average to be calculated " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by weeks."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DayRadioButton)
        Me.GroupBox1.Controls.Add(Me.weekRadioButton)
        Me.GroupBox1.Controls.Add(Me.monthRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 91)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Select Average Type"
        '
        'DayRadioButton
        '
        Me.DayRadioButton.AutoSize = True
        Me.DayRadioButton.Location = New System.Drawing.Point(7, 65)
        Me.DayRadioButton.Name = "DayRadioButton"
        Me.DayRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.DayRadioButton.TabIndex = 2
        Me.DayRadioButton.Text = "&Days"
        Me.DayRadioButton.UseVisualStyleBackColor = True
        '
        'weekRadioButton
        '
        Me.weekRadioButton.AutoSize = True
        Me.weekRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.weekRadioButton.Name = "weekRadioButton"
        Me.weekRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.weekRadioButton.TabIndex = 1
        Me.weekRadioButton.Text = "&Weeks"
        Me.weekRadioButton.UseVisualStyleBackColor = True
        '
        'monthRadioButton
        '
        Me.monthRadioButton.AutoSize = True
        Me.monthRadioButton.Checked = True
        Me.monthRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.monthRadioButton.Name = "monthRadioButton"
        Me.monthRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.monthRadioButton.TabIndex = 0
        Me.monthRadioButton.TabStop = True
        Me.monthRadioButton.Text = "&Months"
        Me.monthRadioButton.UseVisualStyleBackColor = True
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(151, 227)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "OptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DayRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents weekRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents monthRadioButton As System.Windows.Forms.RadioButton
End Class
