<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBoxForm
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
        Me.DataListBox = New System.Windows.Forms.ListBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DataListBox
        '
        Me.DataListBox.FormattingEnabled = True
        Me.DataListBox.ItemHeight = 16
        Me.DataListBox.Location = New System.Drawing.Point(64, 12)
        Me.DataListBox.Name = "DataListBox"
        Me.DataListBox.Size = New System.Drawing.Size(617, 340)
        Me.DataListBox.TabIndex = 0
        Me.DataListBox.TabStop = False
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(64, 377)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(130, 61)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(215, 377)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(130, 61)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(370, 377)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 61)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ListBoxForm
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DataListBox)
        Me.Name = "ListBoxForm"
        Me.Text = "List Box"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataListBox As ListBox
    Friend WithEvents AddButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
