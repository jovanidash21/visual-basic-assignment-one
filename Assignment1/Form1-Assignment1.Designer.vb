<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAssignment1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Number1 = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Number2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Number1
        '
        Me.Number1.BackColor = System.Drawing.Color.DarkViolet
        Me.Number1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Number1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number1.ForeColor = System.Drawing.Color.White
        Me.Number1.Location = New System.Drawing.Point(44, 88)
        Me.Number1.Name = "Number1"
        Me.Number1.Size = New System.Drawing.Size(193, 55)
        Me.Number1.TabIndex = 1
        Me.Number1.Text = "Four Basic Arithmetic Operations"
        Me.Number1.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(39, 40)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(198, 27)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Assignment No. 1"
        '
        'Number2
        '
        Me.Number2.BackColor = System.Drawing.Color.DarkViolet
        Me.Number2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Number2.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number2.ForeColor = System.Drawing.Color.White
        Me.Number2.Location = New System.Drawing.Point(44, 149)
        Me.Number2.Name = "Number2"
        Me.Number2.Size = New System.Drawing.Size(193, 55)
        Me.Number2.TabIndex = 2
        Me.Number2.Text = "Name And Student Number"
        Me.Number2.UseVisualStyleBackColor = False
        '
        'FormAssignment1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Number2)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Number1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormAssignment1"
        Me.Text = "Assignment 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Number1 As Button
    Friend WithEvents Title As Label
    Friend WithEvents Number2 As Button
End Class
