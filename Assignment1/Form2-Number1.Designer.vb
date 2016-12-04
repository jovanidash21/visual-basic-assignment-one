<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNumber1
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
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SumLabel = New System.Windows.Forms.Label()
        Me.DifferenceLabel = New System.Windows.Forms.Label()
        Me.ProductLabel = New System.Windows.Forms.Label()
        Me.QuotientLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.SumTextBox = New System.Windows.Forms.Label()
        Me.DifferenceTextBox = New System.Windows.Forms.Label()
        Me.ProductTextBox = New System.Windows.Forms.Label()
        Me.QuotientTextBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNumberLabel.ForeColor = System.Drawing.Color.White
        Me.FirstNumberLabel.Location = New System.Drawing.Point(9, 23)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(140, 17)
        Me.FirstNumberLabel.TabIndex = 0
        Me.FirstNumberLabel.Text = "Enter 1st Number:"
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FirstNumberTextBox.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(158, 17)
        Me.FirstNumberTextBox.MaxLength = 9
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(114, 25)
        Me.FirstNumberTextBox.TabIndex = 1
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNumberLabel.ForeColor = System.Drawing.Color.White
        Me.SecondNumberLabel.Location = New System.Drawing.Point(9, 52)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(145, 17)
        Me.SecondNumberLabel.TabIndex = 2
        Me.SecondNumberLabel.Text = "Enter 2nd Number:"
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SecondNumberTextBox.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(158, 48)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(114, 25)
        Me.SecondNumberTextBox.TabIndex = 3
        '
        'SumLabel
        '
        Me.SumLabel.AutoSize = True
        Me.SumLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumLabel.ForeColor = System.Drawing.Color.White
        Me.SumLabel.Location = New System.Drawing.Point(88, 123)
        Me.SumLabel.Name = "SumLabel"
        Me.SumLabel.Size = New System.Drawing.Size(44, 17)
        Me.SumLabel.TabIndex = 5
        Me.SumLabel.Text = "Sum:"
        '
        'DifferenceLabel
        '
        Me.DifferenceLabel.AutoSize = True
        Me.DifferenceLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DifferenceLabel.ForeColor = System.Drawing.Color.White
        Me.DifferenceLabel.Location = New System.Drawing.Point(46, 145)
        Me.DifferenceLabel.Name = "DifferenceLabel"
        Me.DifferenceLabel.Size = New System.Drawing.Size(86, 17)
        Me.DifferenceLabel.TabIndex = 7
        Me.DifferenceLabel.Text = "Difference:"
        '
        'ProductLabel
        '
        Me.ProductLabel.AutoSize = True
        Me.ProductLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductLabel.ForeColor = System.Drawing.Color.White
        Me.ProductLabel.Location = New System.Drawing.Point(62, 168)
        Me.ProductLabel.Name = "ProductLabel"
        Me.ProductLabel.Size = New System.Drawing.Size(70, 17)
        Me.ProductLabel.TabIndex = 9
        Me.ProductLabel.Text = "Product:"
        '
        'QuotientLabel
        '
        Me.QuotientLabel.AutoSize = True
        Me.QuotientLabel.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuotientLabel.ForeColor = System.Drawing.Color.White
        Me.QuotientLabel.Location = New System.Drawing.Point(61, 192)
        Me.QuotientLabel.Name = "QuotientLabel"
        Me.QuotientLabel.Size = New System.Drawing.Size(72, 17)
        Me.QuotientLabel.TabIndex = 11
        Me.QuotientLabel.Text = "Quotient:"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.LightSalmon
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackButton.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(12, 220)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(74, 33)
        Me.BackButton.TabIndex = 13
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ComputeButton
        '
        Me.ComputeButton.BackColor = System.Drawing.Color.DarkViolet
        Me.ComputeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComputeButton.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputeButton.ForeColor = System.Drawing.Color.White
        Me.ComputeButton.Location = New System.Drawing.Point(91, 82)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(100, 33)
        Me.ComputeButton.TabIndex = 4
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = False
        '
        'SumTextBox
        '
        Me.SumTextBox.AutoSize = True
        Me.SumTextBox.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumTextBox.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.SumTextBox.Location = New System.Drawing.Point(132, 123)
        Me.SumTextBox.Name = "SumTextBox"
        Me.SumTextBox.Size = New System.Drawing.Size(0, 17)
        Me.SumTextBox.TabIndex = 6
        '
        'DifferenceTextBox
        '
        Me.DifferenceTextBox.AutoSize = True
        Me.DifferenceTextBox.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DifferenceTextBox.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.DifferenceTextBox.Location = New System.Drawing.Point(132, 145)
        Me.DifferenceTextBox.Name = "DifferenceTextBox"
        Me.DifferenceTextBox.Size = New System.Drawing.Size(0, 17)
        Me.DifferenceTextBox.TabIndex = 8
        '
        'ProductTextBox
        '
        Me.ProductTextBox.AutoSize = True
        Me.ProductTextBox.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductTextBox.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.ProductTextBox.Location = New System.Drawing.Point(132, 168)
        Me.ProductTextBox.Name = "ProductTextBox"
        Me.ProductTextBox.Size = New System.Drawing.Size(0, 17)
        Me.ProductTextBox.TabIndex = 10
        '
        'QuotientTextBox
        '
        Me.QuotientTextBox.AutoSize = True
        Me.QuotientTextBox.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuotientTextBox.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.QuotientTextBox.Location = New System.Drawing.Point(132, 192)
        Me.QuotientTextBox.Name = "QuotientTextBox"
        Me.QuotientTextBox.Size = New System.Drawing.Size(0, 17)
        Me.QuotientTextBox.TabIndex = 12
        '
        'FormNumber1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.QuotientTextBox)
        Me.Controls.Add(Me.ProductTextBox)
        Me.Controls.Add(Me.DifferenceTextBox)
        Me.Controls.Add(Me.SumTextBox)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.QuotientLabel)
        Me.Controls.Add(Me.ProductLabel)
        Me.Controls.Add(Me.DifferenceLabel)
        Me.Controls.Add(Me.SumLabel)
        Me.Controls.Add(Me.SecondNumberTextBox)
        Me.Controls.Add(Me.SecondNumberLabel)
        Me.Controls.Add(Me.FirstNumberTextBox)
        Me.Controls.Add(Me.FirstNumberLabel)
        Me.Name = "FormNumber1"
        Me.Text = "Number 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents SumLabel As Label
    Friend WithEvents DifferenceLabel As Label
    Friend WithEvents ProductLabel As Label
    Friend WithEvents QuotientLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents ComputeButton As Button
    Friend WithEvents SumTextBox As Label
    Friend WithEvents DifferenceTextBox As Label
    Friend WithEvents ProductTextBox As Label
    Friend WithEvents QuotientTextBox As Label
End Class
