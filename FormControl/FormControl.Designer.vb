<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormControl
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
        Me.GoButton = New System.Windows.Forms.Button()
        Me.UserInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserSelectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.UserPictureBox = New System.Windows.Forms.PictureBox()
        Me.UserInputGroupBox.SuspendLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(370, 326)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(120, 100)
        Me.GoButton.TabIndex = 0
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'UserInputGroupBox
        '
        Me.UserInputGroupBox.Controls.Add(Me.TextBox3)
        Me.UserInputGroupBox.Controls.Add(Me.TextBox2)
        Me.UserInputGroupBox.Controls.Add(Me.TextBox1)
        Me.UserInputGroupBox.Location = New System.Drawing.Point(30, 49)
        Me.UserInputGroupBox.Name = "UserInputGroupBox"
        Me.UserInputGroupBox.Size = New System.Drawing.Size(225, 249)
        Me.UserInputGroupBox.TabIndex = 1
        Me.UserInputGroupBox.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(21, 125)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(177, 22)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(21, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(177, 22)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 22)
        Me.TextBox1.TabIndex = 0
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(508, 326)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(120, 100)
        Me.UpdateButton.TabIndex = 2
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(643, 326)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(120, 100)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UserSelectionGroupBox
        '
        Me.UserSelectionGroupBox.Location = New System.Drawing.Point(278, 49)
        Me.UserSelectionGroupBox.Name = "UserSelectionGroupBox"
        Me.UserSelectionGroupBox.Size = New System.Drawing.Size(225, 249)
        Me.UserSelectionGroupBox.TabIndex = 4
        Me.UserSelectionGroupBox.TabStop = False
        '
        'UserPictureBox
        '
        Me.UserPictureBox.Location = New System.Drawing.Point(527, 54)
        Me.UserPictureBox.Name = "UserPictureBox"
        Me.UserPictureBox.Size = New System.Drawing.Size(236, 244)
        Me.UserPictureBox.TabIndex = 5
        Me.UserPictureBox.TabStop = False
        '
        'FormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserPictureBox)
        Me.Controls.Add(Me.UserSelectionGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.UserInputGroupBox)
        Me.Controls.Add(Me.GoButton)
        Me.Name = "FormControl"
        Me.Text = "User Control Interface"
        Me.UserInputGroupBox.ResumeLayout(False)
        Me.UserInputGroupBox.PerformLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GoButton As Button
    Friend WithEvents UserInputGroupBox As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UserSelectionGroupBox As GroupBox
    Friend WithEvents UserPictureBox As PictureBox
End Class
