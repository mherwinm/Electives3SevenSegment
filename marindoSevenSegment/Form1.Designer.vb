<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class marindoSevenSegment
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(89, 129)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 29)
        Me.Button7.TabIndex = 13
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(89, 259)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 28)
        Me.Button6.TabIndex = 12
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(56, 164)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 96)
        Me.Button5.TabIndex = 11
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(202, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 96)
        Me.Button4.TabIndex = 10
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(202, 35)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 96)
        Me.Button3.TabIndex = 9
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(56, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 96)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(89, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'marindoSevenSegment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 301)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "marindoSevenSegment"
        Me.Text = "marindoSevenSegment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
