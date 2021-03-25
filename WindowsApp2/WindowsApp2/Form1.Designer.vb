<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.helloLb = New System.Windows.Forms.Label()
        Me.BaseUserControl1 = New WindowsApp2.BaseUserControl()
        Me.SuspendLayout()
        '
        'helloLb
        '
        Me.helloLb.AutoSize = True
        Me.helloLb.Location = New System.Drawing.Point(308, 190)
        Me.helloLb.Name = "helloLb"
        Me.helloLb.Size = New System.Drawing.Size(0, 13)
        Me.helloLb.TabIndex = 1
        '
        'BaseUserControl1
        '
        Me.BaseUserControl1.Location = New System.Drawing.Point(10, 83)
        Me.BaseUserControl1.Name = "BaseUserControl1"
        Me.BaseUserControl1.Size = New System.Drawing.Size(778, 279)
        Me.BaseUserControl1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BaseUserControl1)
        Me.Controls.Add(Me.helloLb)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents helloLb As Label
    Friend WithEvents BaseUserControl1 As BaseUserControl
End Class
