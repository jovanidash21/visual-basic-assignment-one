<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNumber2
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
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentNumberLabel = New System.Windows.Forms.Label()
        Me.StudentNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel.ForeColor = System.Drawing.Color.White
        Me.FirstNameLabel.Location = New System.Drawing.Point(12, 20)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(89, 17)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel.ForeColor = System.Drawing.Color.White
        Me.LastNameLabel.Location = New System.Drawing.Point(12, 80)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(86, 17)
        Me.LastNameLabel.TabIndex = 2
        Me.LastNameLabel.Text = "Last Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(15, 40)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(257, 25)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LastNameTextBox.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(15, 100)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(257, 25)
        Me.LastNameTextBox.TabIndex = 3
        '
        'StudentNumberLabel
        '
        Me.StudentNumberLabel.AutoSize = True
        Me.StudentNumberLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNumberLabel.ForeColor = System.Drawing.Color.White
        Me.StudentNumberLabel.Location = New System.Drawing.Point(12, 142)
        Me.StudentNumberLabel.Name = "StudentNumberLabel"
        Me.StudentNumberLabel.Size = New System.Drawing.Size(128, 17)
        Me.StudentNumberLabel.TabIndex = 4
        Me.StudentNumberLabel.Text = "Student Number:"
        '
        'StudentNumberTextBox
        '
        Me.StudentNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentNumberTextBox.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNumberTextBox.Location = New System.Drawing.Point(15, 162)
        Me.StudentNumberTextBox.Name = "StudentNumberTextBox"
        Me.StudentNumberTextBox.Size = New System.Drawing.Size(257, 25)
        Me.StudentNumberTextBox.TabIndex = 5
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.DarkViolet
        Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SubmitButton.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.ForeColor = System.Drawing.Color.White
        Me.SubmitButton.Location = New System.Drawing.Point(198, 216)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(74, 33)
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.LightSalmon
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackButton.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(15, 216)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(74, 33)
        Me.BackButton.TabIndex = 7
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'FormNumber2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.StudentNumberTextBox)
        Me.Controls.Add(Me.StudentNumberLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Name = "FormNumber2"
        Me.Text = "Number 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents StudentNumberLabel As Label
    Friend WithEvents StudentNumberTextBox As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents BackButton As Button
End Class
