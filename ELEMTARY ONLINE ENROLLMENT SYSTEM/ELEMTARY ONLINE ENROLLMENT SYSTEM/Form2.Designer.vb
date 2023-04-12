<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cbGrade = New System.Windows.Forms.CheckBox()
        Me.cbGrade2 = New System.Windows.Forms.CheckBox()
        Me.cbGrade3 = New System.Windows.Forms.CheckBox()
        Me.cbGrade4 = New System.Windows.Forms.CheckBox()
        Me.cbGrade5 = New System.Windows.Forms.CheckBox()
        Me.cbGrade6 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbGrade
        '
        Me.cbGrade.AutoSize = True
        Me.cbGrade.Location = New System.Drawing.Point(196, 280)
        Me.cbGrade.Name = "cbGrade"
        Me.cbGrade.Size = New System.Drawing.Size(73, 17)
        Me.cbGrade.TabIndex = 0
        Me.cbGrade.Text = "GRADE 1"
        Me.cbGrade.UseVisualStyleBackColor = True
        '
        'cbGrade2
        '
        Me.cbGrade2.AutoSize = True
        Me.cbGrade2.Location = New System.Drawing.Point(479, 280)
        Me.cbGrade2.Name = "cbGrade2"
        Me.cbGrade2.Size = New System.Drawing.Size(73, 17)
        Me.cbGrade2.TabIndex = 1
        Me.cbGrade2.Text = "GRADE 2"
        Me.cbGrade2.UseVisualStyleBackColor = True
        '
        'cbGrade3
        '
        Me.cbGrade3.AutoSize = True
        Me.cbGrade3.Location = New System.Drawing.Point(744, 280)
        Me.cbGrade3.Name = "cbGrade3"
        Me.cbGrade3.Size = New System.Drawing.Size(73, 17)
        Me.cbGrade3.TabIndex = 2
        Me.cbGrade3.Text = "GRADE 3"
        Me.cbGrade3.UseVisualStyleBackColor = True
        '
        'cbGrade4
        '
        Me.cbGrade4.AutoSize = True
        Me.cbGrade4.Location = New System.Drawing.Point(196, 427)
        Me.cbGrade4.Name = "cbGrade4"
        Me.cbGrade4.Size = New System.Drawing.Size(73, 17)
        Me.cbGrade4.TabIndex = 3
        Me.cbGrade4.Text = "GRADE 4"
        Me.cbGrade4.UseVisualStyleBackColor = True
        '
        'cbGrade5
        '
        Me.cbGrade5.AutoSize = True
        Me.cbGrade5.Location = New System.Drawing.Point(479, 427)
        Me.cbGrade5.Name = "cbGrade5"
        Me.cbGrade5.Size = New System.Drawing.Size(73, 17)
        Me.cbGrade5.TabIndex = 4
        Me.cbGrade5.Text = "GRADE 5"
        Me.cbGrade5.UseVisualStyleBackColor = True
        '
        'cbGrade6
        '
        Me.cbGrade6.AutoSize = True
        Me.cbGrade6.Location = New System.Drawing.Point(744, 427)
        Me.cbGrade6.Name = "cbGrade6"
        Me.cbGrade6.Size = New System.Drawing.Size(73, 17)
        Me.cbGrade6.TabIndex = 5
        Me.cbGrade6.Text = "GRADE 6"
        Me.cbGrade6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 41)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SCHOOL GRADE LEVEL"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbGrade6)
        Me.Controls.Add(Me.cbGrade5)
        Me.Controls.Add(Me.cbGrade4)
        Me.Controls.Add(Me.cbGrade3)
        Me.Controls.Add(Me.cbGrade2)
        Me.Controls.Add(Me.cbGrade)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbGrade As CheckBox
    Friend WithEvents cbGrade2 As CheckBox
    Friend WithEvents cbGrade3 As CheckBox
    Friend WithEvents cbGrade4 As CheckBox
    Friend WithEvents cbGrade5 As CheckBox
    Friend WithEvents cbGrade6 As CheckBox
    Friend WithEvents Label1 As Label
End Class
