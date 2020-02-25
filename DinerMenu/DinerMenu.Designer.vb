<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(297, 37)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(265, 43)
        Me.DinerNameLabel.TabIndex = 0
        Me.DinerNameLabel.Text = "Freddy's Diner"
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(12, 442)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(141, 115)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "&Salad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(211, 442)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(141, 115)
        Me.SoupButton.TabIndex = 2
        Me.SoupButton.Text = "&Soup"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(421, 442)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(141, 115)
        Me.FishButton.TabIndex = 3
        Me.FishButton.Text = "&Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(710, 442)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(141, 115)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.AutoSize = True
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(155, 111)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(0, 23)
        Me.DisplaySpecialLabel.TabIndex = 5
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 569)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Name = "DinerMenuForm"
        Me.Text = "Freddy's Diner Special Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents SaladButton As Button
    Friend WithEvents SoupButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplaySpecialLabel As Label
End Class
