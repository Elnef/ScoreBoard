<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnAddMatch = New System.Windows.Forms.Button()
        Me.txtMatch1 = New System.Windows.Forms.TextBox()
        Me.BtnInitProcess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddMatch
        '
        Me.btnAddMatch.Location = New System.Drawing.Point(101, 205)
        Me.btnAddMatch.Name = "btnAddMatch"
        Me.btnAddMatch.Size = New System.Drawing.Size(75, 23)
        Me.btnAddMatch.TabIndex = 0
        Me.btnAddMatch.Text = "Add New Match"
        Me.btnAddMatch.UseVisualStyleBackColor = True
        '
        'txtMatch1
        '
        Me.txtMatch1.Location = New System.Drawing.Point(195, 128)
        Me.txtMatch1.Multiline = True
        Me.txtMatch1.Name = "txtMatch1"
        Me.txtMatch1.Size = New System.Drawing.Size(306, 188)
        Me.txtMatch1.TabIndex = 1
        '
        'BtnInitProcess
        '
        Me.BtnInitProcess.Location = New System.Drawing.Point(48, 68)
        Me.BtnInitProcess.Name = "BtnInitProcess"
        Me.BtnInitProcess.Size = New System.Drawing.Size(75, 23)
        Me.BtnInitProcess.TabIndex = 2
        Me.BtnInitProcess.Text = "Init Process"
        Me.BtnInitProcess.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnInitProcess)
        Me.Controls.Add(Me.txtMatch1)
        Me.Controls.Add(Me.btnAddMatch)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddMatch As Button
    Friend WithEvents txtMatch1 As TextBox
    Friend WithEvents BtnInitProcess As Button
End Class
