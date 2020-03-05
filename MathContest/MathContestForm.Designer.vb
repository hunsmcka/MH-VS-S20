<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.Number1stTextBox = New System.Windows.Forms.TextBox()
        Me.Number2ndTextBox = New System.Windows.Forms.TextBox()
        Me.Number1stLabel = New System.Windows.Forms.Label()
        Me.Number2ndLabel = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.InformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.MathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.MathTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.InformationGroupBox.SuspendLayout()
        Me.MathProblemGroupBox.SuspendLayout()
        Me.MathTypeGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(35, 19)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(133, 51)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(35, 94)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(133, 51)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(35, 169)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(133, 51)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "S&ummary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(35, 244)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(133, 51)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(11, 48)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(278, 22)
        Me.NameTextBox.TabIndex = 4
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(8, 28)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(319, 48)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(38, 22)
        Me.AgeTextBox.TabIndex = 6
        Me.AgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(383, 48)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(38, 22)
        Me.GradeTextBox.TabIndex = 7
        Me.GradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(379, 28)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(48, 17)
        Me.GradeLabel.TabIndex = 8
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(321, 28)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(33, 17)
        Me.AgeLabel.TabIndex = 9
        Me.AgeLabel.Text = "Age"
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(42, 31)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(54, 21)
        Me.AddRadioButton.TabIndex = 10
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(42, 58)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(82, 21)
        Me.SubtractRadioButton.TabIndex = 11
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(42, 85)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(76, 21)
        Me.MultiplyRadioButton.TabIndex = 12
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(42, 112)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(68, 21)
        Me.DivideRadioButton.TabIndex = 13
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'Number1stTextBox
        '
        Me.Number1stTextBox.Enabled = False
        Me.Number1stTextBox.Location = New System.Drawing.Point(11, 48)
        Me.Number1stTextBox.Name = "Number1stTextBox"
        Me.Number1stTextBox.Size = New System.Drawing.Size(197, 22)
        Me.Number1stTextBox.TabIndex = 14
        '
        'Number2ndTextBox
        '
        Me.Number2ndTextBox.Enabled = False
        Me.Number2ndTextBox.Location = New System.Drawing.Point(11, 100)
        Me.Number2ndTextBox.Name = "Number2ndTextBox"
        Me.Number2ndTextBox.Size = New System.Drawing.Size(197, 22)
        Me.Number2ndTextBox.TabIndex = 15
        '
        'Number1stLabel
        '
        Me.Number1stLabel.AutoSize = True
        Me.Number1stLabel.Location = New System.Drawing.Point(8, 28)
        Me.Number1stLabel.Name = "Number1stLabel"
        Me.Number1stLabel.Size = New System.Drawing.Size(81, 17)
        Me.Number1stLabel.TabIndex = 16
        Me.Number1stLabel.Text = "1st Number"
        '
        'Number2ndLabel
        '
        Me.Number2ndLabel.AutoSize = True
        Me.Number2ndLabel.Location = New System.Drawing.Point(8, 80)
        Me.Number2ndLabel.Name = "Number2ndLabel"
        Me.Number2ndLabel.Size = New System.Drawing.Size(86, 17)
        Me.Number2ndLabel.TabIndex = 17
        Me.Number2ndLabel.Text = "2nd Number"
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(11, 152)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(197, 22)
        Me.AnswerTextBox.TabIndex = 18
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(8, 131)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(107, 17)
        Me.StudentAnswerLabel.TabIndex = 19
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'InformationGroupBox
        '
        Me.InformationGroupBox.Controls.Add(Me.NameTextBox)
        Me.InformationGroupBox.Controls.Add(Me.NameLabel)
        Me.InformationGroupBox.Controls.Add(Me.AgeTextBox)
        Me.InformationGroupBox.Controls.Add(Me.GradeTextBox)
        Me.InformationGroupBox.Controls.Add(Me.GradeLabel)
        Me.InformationGroupBox.Controls.Add(Me.AgeLabel)
        Me.InformationGroupBox.Location = New System.Drawing.Point(26, 26)
        Me.InformationGroupBox.Name = "InformationGroupBox"
        Me.InformationGroupBox.Size = New System.Drawing.Size(458, 100)
        Me.InformationGroupBox.TabIndex = 20
        Me.InformationGroupBox.TabStop = False
        Me.InformationGroupBox.Text = "Student Information"
        '
        'MathProblemGroupBox
        '
        Me.MathProblemGroupBox.Controls.Add(Me.Number2ndTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.Number1stTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.Number1stLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.AnswerTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.Number2ndLabel)
        Me.MathProblemGroupBox.Location = New System.Drawing.Point(26, 139)
        Me.MathProblemGroupBox.Name = "MathProblemGroupBox"
        Me.MathProblemGroupBox.Size = New System.Drawing.Size(224, 199)
        Me.MathProblemGroupBox.TabIndex = 21
        Me.MathProblemGroupBox.TabStop = False
        Me.MathProblemGroupBox.Text = "Current Math Problem"
        '
        'MathTypeGroupBox
        '
        Me.MathTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathTypeGroupBox.Location = New System.Drawing.Point(292, 139)
        Me.MathTypeGroupBox.Name = "MathTypeGroupBox"
        Me.MathTypeGroupBox.Size = New System.Drawing.Size(171, 158)
        Me.MathTypeGroupBox.TabIndex = 22
        Me.MathTypeGroupBox.TabStop = False
        Me.MathTypeGroupBox.Text = "Math Type"
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(504, 26)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(200, 312)
        Me.ButtonGroupBox.TabIndex = 23
        Me.ButtonGroupBox.TabStop = False
        '
        'MathContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 368)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.MathTypeGroupBox)
        Me.Controls.Add(Me.MathProblemGroupBox)
        Me.Controls.Add(Me.InformationGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.InformationGroupBox.ResumeLayout(False)
        Me.InformationGroupBox.PerformLayout()
        Me.MathProblemGroupBox.ResumeLayout(False)
        Me.MathProblemGroupBox.PerformLayout()
        Me.MathTypeGroupBox.ResumeLayout(False)
        Me.MathTypeGroupBox.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents Number1stTextBox As TextBox
    Friend WithEvents Number2ndTextBox As TextBox
    Friend WithEvents Number1stLabel As Label
    Friend WithEvents Number2ndLabel As Label
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents InformationGroupBox As GroupBox
    Friend WithEvents MathProblemGroupBox As GroupBox
    Friend WithEvents MathTypeGroupBox As GroupBox
    Friend WithEvents ButtonGroupBox As GroupBox
End Class
