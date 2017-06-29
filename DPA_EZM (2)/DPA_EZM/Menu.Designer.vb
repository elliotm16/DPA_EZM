<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnFormOne = New System.Windows.Forms.Button()
        Me.btnFormTwo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFormOne
        '
        Me.btnFormOne.Location = New System.Drawing.Point(12, 12)
        Me.btnFormOne.Name = "btnFormOne"
        Me.btnFormOne.Size = New System.Drawing.Size(100, 30)
        Me.btnFormOne.TabIndex = 0
        Me.btnFormOne.Text = "Form1"
        Me.btnFormOne.UseVisualStyleBackColor = True
        '
        'btnFormTwo
        '
        Me.btnFormTwo.Location = New System.Drawing.Point(12, 48)
        Me.btnFormTwo.Name = "btnFormTwo"
        Me.btnFormTwo.Size = New System.Drawing.Size(100, 30)
        Me.btnFormTwo.TabIndex = 1
        Me.btnFormTwo.Text = "Form2"
        Me.btnFormTwo.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnFormTwo)
        Me.Controls.Add(Me.btnFormOne)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFormOne As System.Windows.Forms.Button
    Friend WithEvents btnFormTwo As System.Windows.Forms.Button
End Class
