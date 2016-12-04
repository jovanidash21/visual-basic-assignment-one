<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNumber2point1
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
        Me.HelloNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameValue = New System.Windows.Forms.Label()
        Me.LastNameValue = New System.Windows.Forms.Label()
        Me.MyStudentNumberLabel = New System.Windows.Forms.Label()
        Me.StudentNumberValue = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HelloNameLabel
        '
        Me.HelloNameLabel.AutoSize = True
        Me.HelloNameLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelloNameLabel.ForeColor = System.Drawing.Color.White
        Me.HelloNameLabel.Location = New System.Drawing.Point(12, 32)
        Me.HelloNameLabel.Name = "HelloNameLabel"
        Me.HelloNameLabel.Size = New System.Drawing.Size(129, 17)
        Me.HelloNameLabel.TabIndex = 0
        Me.HelloNameLabel.Text = "Hello my name is"
        '
        'FirstNameValue
        '
        Me.FirstNameValue.AutoSize = True
        Me.FirstNameValue.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameValue.ForeColor = System.Drawing.Color.White
        Me.FirstNameValue.Location = New System.Drawing.Point(11, 59)
        Me.FirstNameValue.Name = "FirstNameValue"
        Me.FirstNameValue.Size = New System.Drawing.Size(0, 23)
        Me.FirstNameValue.TabIndex = 1
        Me.FirstNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LastNameValue
        '
        Me.LastNameValue.AutoSize = True
        Me.LastNameValue.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameValue.ForeColor = System.Drawing.Color.White
        Me.LastNameValue.Location = New System.Drawing.Point(12, 85)
        Me.LastNameValue.Name = "LastNameValue"
        Me.LastNameValue.Size = New System.Drawing.Size(0, 23)
        Me.LastNameValue.TabIndex = 2
        Me.LastNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyStudentNumberLabel
        '
        Me.MyStudentNumberLabel.AutoSize = True
        Me.MyStudentNumberLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyStudentNumberLabel.ForeColor = System.Drawing.Color.White
        Me.MyStudentNumberLabel.Location = New System.Drawing.Point(12, 139)
        Me.MyStudentNumberLabel.Name = "MyStudentNumberLabel"
        Me.MyStudentNumberLabel.Size = New System.Drawing.Size(167, 17)
        Me.MyStudentNumberLabel.TabIndex = 3
        Me.MyStudentNumberLabel.Text = "My student number is "
        '
        'StudentNumberValue
        '
        Me.StudentNumberValue.AutoSize = True
        Me.StudentNumberValue.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNumberValue.ForeColor = System.Drawing.Color.White
        Me.StudentNumberValue.Location = New System.Drawing.Point(12, 163)
        Me.StudentNumberValue.Name = "StudentNumberValue"
        Me.StudentNumberValue.Size = New System.Drawing.Size(0, 23)
        Me.StudentNumberValue.TabIndex = 4
        Me.StudentNumberValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.LightSalmon
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackButton.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(12, 216)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(74, 33)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'FormNumber2point1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.StudentNumberValue)
        Me.Controls.Add(Me.MyStudentNumberLabel)
        Me.Controls.Add(Me.LastNameValue)
        Me.Controls.Add(Me.FirstNameValue)
        Me.Controls.Add(Me.HelloNameLabel)
        Me.Name = "FormNumber2point1"
        Me.Text = "Message Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelloNameLabel As Label
    Friend WithEvents FirstNameValue As Label
    Friend WithEvents LastNameValue As Label
    Friend WithEvents MyStudentNumberLabel As Label
    Friend WithEvents StudentNumberValue As Label
    Friend WithEvents BackButton As Button
End Class
