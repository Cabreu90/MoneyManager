<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGridForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.MoneyManagerDatabaseDataSet = New MoneyManager.MoneyManagerDatabaseDataSet
        Me.DefaultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DefaultTableAdapter = New MoneyManager.MoneyManagerDatabaseDataSetTableAdapters.DefaultTableAdapter
        Me.MonthnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IncomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ElectricityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WaterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FoodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClothesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OthersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.exitButton = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyManagerDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefaultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonthnoDataGridViewTextBoxColumn, Me.IncomeDataGridViewTextBoxColumn, Me.RentDataGridViewTextBoxColumn, Me.CableDataGridViewTextBoxColumn, Me.GasDataGridViewTextBoxColumn, Me.ElectricityDataGridViewTextBoxColumn, Me.WaterDataGridViewTextBoxColumn, Me.FoodDataGridViewTextBoxColumn, Me.ClothesDataGridViewTextBoxColumn, Me.OthersDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DefaultBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1042, 304)
        Me.DataGridView1.TabIndex = 1
        '
        'MoneyManagerDatabaseDataSet
        '
        Me.MoneyManagerDatabaseDataSet.DataSetName = "MoneyManagerDatabaseDataSet"
        Me.MoneyManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DefaultBindingSource
        '
        Me.DefaultBindingSource.DataMember = "Default"
        Me.DefaultBindingSource.DataSource = Me.MoneyManagerDatabaseDataSet
        '
        'DefaultTableAdapter
        '
        Me.DefaultTableAdapter.ClearBeforeFill = True
        '
        'MonthnoDataGridViewTextBoxColumn
        '
        Me.MonthnoDataGridViewTextBoxColumn.DataPropertyName = "month_no"
        Me.MonthnoDataGridViewTextBoxColumn.HeaderText = "month_no"
        Me.MonthnoDataGridViewTextBoxColumn.Name = "MonthnoDataGridViewTextBoxColumn"
        '
        'IncomeDataGridViewTextBoxColumn
        '
        Me.IncomeDataGridViewTextBoxColumn.DataPropertyName = "income"
        Me.IncomeDataGridViewTextBoxColumn.HeaderText = "income"
        Me.IncomeDataGridViewTextBoxColumn.Name = "IncomeDataGridViewTextBoxColumn"
        '
        'RentDataGridViewTextBoxColumn
        '
        Me.RentDataGridViewTextBoxColumn.DataPropertyName = "rent"
        Me.RentDataGridViewTextBoxColumn.HeaderText = "rent"
        Me.RentDataGridViewTextBoxColumn.Name = "RentDataGridViewTextBoxColumn"
        '
        'CableDataGridViewTextBoxColumn
        '
        Me.CableDataGridViewTextBoxColumn.DataPropertyName = "cable"
        Me.CableDataGridViewTextBoxColumn.HeaderText = "cable"
        Me.CableDataGridViewTextBoxColumn.Name = "CableDataGridViewTextBoxColumn"
        '
        'GasDataGridViewTextBoxColumn
        '
        Me.GasDataGridViewTextBoxColumn.DataPropertyName = "gas"
        Me.GasDataGridViewTextBoxColumn.HeaderText = "gas"
        Me.GasDataGridViewTextBoxColumn.Name = "GasDataGridViewTextBoxColumn"
        '
        'ElectricityDataGridViewTextBoxColumn
        '
        Me.ElectricityDataGridViewTextBoxColumn.DataPropertyName = "electricity"
        Me.ElectricityDataGridViewTextBoxColumn.HeaderText = "electricity"
        Me.ElectricityDataGridViewTextBoxColumn.Name = "ElectricityDataGridViewTextBoxColumn"
        '
        'WaterDataGridViewTextBoxColumn
        '
        Me.WaterDataGridViewTextBoxColumn.DataPropertyName = "water"
        Me.WaterDataGridViewTextBoxColumn.HeaderText = "water"
        Me.WaterDataGridViewTextBoxColumn.Name = "WaterDataGridViewTextBoxColumn"
        '
        'FoodDataGridViewTextBoxColumn
        '
        Me.FoodDataGridViewTextBoxColumn.DataPropertyName = "food"
        Me.FoodDataGridViewTextBoxColumn.HeaderText = "food"
        Me.FoodDataGridViewTextBoxColumn.Name = "FoodDataGridViewTextBoxColumn"
        '
        'ClothesDataGridViewTextBoxColumn
        '
        Me.ClothesDataGridViewTextBoxColumn.DataPropertyName = "clothes"
        Me.ClothesDataGridViewTextBoxColumn.HeaderText = "clothes"
        Me.ClothesDataGridViewTextBoxColumn.Name = "ClothesDataGridViewTextBoxColumn"
        '
        'OthersDataGridViewTextBoxColumn
        '
        Me.OthersDataGridViewTextBoxColumn.DataPropertyName = "others"
        Me.OthersDataGridViewTextBoxColumn.HeaderText = "others"
        Me.OthersDataGridViewTextBoxColumn.Name = "OthersDataGridViewTextBoxColumn"
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(979, 322)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'DataGridForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 351)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DataGridForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataGridForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyManagerDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefaultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MoneyManagerDatabaseDataSet As MoneyManager.MoneyManagerDatabaseDataSet
    Friend WithEvents DefaultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DefaultTableAdapter As MoneyManager.MoneyManagerDatabaseDataSetTableAdapters.DefaultTableAdapter
    Friend WithEvents MonthnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IncomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ElectricityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClothesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OthersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
