<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TitleScreen = New System.Windows.Forms.Panel()
        Me.Map1 = New System.Windows.Forms.Panel()
        Me.Map1Player = New System.Windows.Forms.PictureBox()
        Me.PressToPlay = New System.Windows.Forms.Label()
        Me.Settings = New System.Windows.Forms.Label()
        Me.Quit = New System.Windows.Forms.Label()
        Me.TitleScreen.SuspendLayout()
        Me.Map1.SuspendLayout()
        CType(Me.Map1Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleScreen
        '
        Me.TitleScreen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TitleScreen.Controls.Add(Me.Quit)
        Me.TitleScreen.Controls.Add(Me.Settings)
        Me.TitleScreen.Controls.Add(Me.PressToPlay)
        Me.TitleScreen.Location = New System.Drawing.Point(86, 52)
        Me.TitleScreen.Name = "TitleScreen"
        Me.TitleScreen.Size = New System.Drawing.Size(306, 224)
        Me.TitleScreen.TabIndex = 0
        '
        'Map1
        '
        Me.Map1.Controls.Add(Me.Map1Player)
        Me.Map1.Enabled = False
        Me.Map1.Location = New System.Drawing.Point(493, 197)
        Me.Map1.Name = "Map1"
        Me.Map1.Size = New System.Drawing.Size(200, 100)
        Me.Map1.TabIndex = 1
        Me.Map1.Visible = False
        '
        'Map1Player
        '
        Me.Map1Player.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Map1Player.Location = New System.Drawing.Point(62, 18)
        Me.Map1Player.Name = "Map1Player"
        Me.Map1Player.Size = New System.Drawing.Size(100, 50)
        Me.Map1Player.TabIndex = 0
        Me.Map1Player.TabStop = False
        '
        'PressToPlay
        '
        Me.PressToPlay.AutoSize = True
        Me.PressToPlay.Location = New System.Drawing.Point(121, 62)
        Me.PressToPlay.Name = "PressToPlay"
        Me.PressToPlay.Size = New System.Drawing.Size(39, 13)
        Me.PressToPlay.TabIndex = 0
        Me.PressToPlay.Text = "Label1"
        '
        'Settings
        '
        Me.Settings.AutoSize = True
        Me.Settings.Location = New System.Drawing.Point(121, 92)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(39, 13)
        Me.Settings.TabIndex = 0
        Me.Settings.Text = "Label1"
        '
        'Quit
        '
        Me.Quit.AutoSize = True
        Me.Quit.Location = New System.Drawing.Point(121, 145)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(39, 13)
        Me.Quit.TabIndex = 0
        Me.Quit.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Map1)
        Me.Controls.Add(Me.TitleScreen)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TitleScreen.ResumeLayout(False)
        Me.TitleScreen.PerformLayout()
        Me.Map1.ResumeLayout(False)
        CType(Me.Map1Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleScreen As Panel
    Friend WithEvents Map1 As Panel
    Friend WithEvents Map1Player As PictureBox
    Friend WithEvents Quit As Label
    Friend WithEvents Settings As Label
    Friend WithEvents PressToPlay As Label
End Class
