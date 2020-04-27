<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGroceryForm
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
        Me.ItemComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.ItemListBox = New System.Windows.Forms.ListBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.ComboBoxLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ItemComboBox
        '
        Me.ItemComboBox.FormattingEnabled = True
        Me.ItemComboBox.Location = New System.Drawing.Point(103, 87)
        Me.ItemComboBox.Name = "ItemComboBox"
        Me.ItemComboBox.Size = New System.Drawing.Size(257, 24)
        Me.ItemComboBox.TabIndex = 1
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(103, 59)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(476, 22)
        Me.SearchTextBox.TabIndex = 0
        '
        'ItemListBox
        '
        Me.ItemListBox.FormattingEnabled = True
        Me.ItemListBox.ItemHeight = 16
        Me.ItemListBox.Location = New System.Drawing.Point(366, 87)
        Me.ItemListBox.Name = "ItemListBox"
        Me.ItemListBox.Size = New System.Drawing.Size(294, 260)
        Me.ItemListBox.TabIndex = 2
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(585, 59)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 3
        Me.SearchButton.Text = "&Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(6, 62)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(91, 17)
        Me.SearchLabel.TabIndex = 6
        Me.SearchLabel.Text = "Look Up Item"
        '
        'ComboBoxLabel
        '
        Me.ComboBoxLabel.AutoSize = True
        Me.ComboBoxLabel.Location = New System.Drawing.Point(20, 90)
        Me.ComboBoxLabel.Name = "ComboBoxLabel"
        Me.ComboBoxLabel.Size = New System.Drawing.Size(77, 17)
        Me.ComboBoxLabel.TabIndex = 7
        Me.ComboBoxLabel.Text = "Select Item"
        '
        'StansGroceryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 365)
        Me.Controls.Add(Me.ComboBoxLabel)
        Me.Controls.Add(Me.SearchLabel)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ItemListBox)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.ItemComboBox)
        Me.Name = "StansGroceryForm"
        Me.Text = "Stan's Grocery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ItemComboBox As ComboBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents ItemListBox As ListBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchLabel As Label
    Friend WithEvents ComboBoxLabel As Label
End Class
