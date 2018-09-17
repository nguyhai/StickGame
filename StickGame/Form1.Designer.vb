<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStickGame
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.txtPileStatus = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How Many Sitcks Will You Pick?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Status of Pile"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(408, 21)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(91, 49)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start New Game"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(516, 21)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(91, 49)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Exit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(212, 120)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(115, 23)
        Me.btnOne.TabIndex = 4
        Me.btnOne.Text = "One Stick"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(354, 120)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(115, 23)
        Me.btnTwo.TabIndex = 5
        Me.btnTwo.Text = "Two Sticks"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(492, 120)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(115, 23)
        Me.btnThree.TabIndex = 6
        Me.btnThree.Text = "Three Sticks"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'txtPileStatus
        '
        Me.txtPileStatus.Location = New System.Drawing.Point(105, 169)
        Me.txtPileStatus.Name = "txtPileStatus"
        Me.txtPileStatus.ReadOnly = True
        Me.txtPileStatus.Size = New System.Drawing.Size(502, 20)
        Me.txtPileStatus.TabIndex = 7
        '
        'frmStickGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 218)
        Me.Controls.Add(Me.txtPileStatus)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStickGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stick Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents txtPileStatus As TextBox
End Class
