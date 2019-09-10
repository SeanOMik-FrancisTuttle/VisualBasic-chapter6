<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftballScoreboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnInningScore = New System.Windows.Forms.Button()
        Me.lstInningScore = New System.Windows.Forms.ListBox()
        Me.lblAverageRain = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(310, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(37, 20)
        Me.menuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(5, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(301, 35)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Softball Scoreboard"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnInningScore
        '
        Me.btnInningScore.BackColor = System.Drawing.Color.YellowGreen
        Me.btnInningScore.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInningScore.Location = New System.Drawing.Point(59, 113)
        Me.btnInningScore.Name = "btnInningScore"
        Me.btnInningScore.Size = New System.Drawing.Size(199, 35)
        Me.btnInningScore.TabIndex = 2
        Me.btnInningScore.Text = "Enter Score"
        Me.btnInningScore.UseVisualStyleBackColor = False
        '
        'lstInningScore
        '
        Me.lstInningScore.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInningScore.FormattingEnabled = True
        Me.lstInningScore.ItemHeight = 18
        Me.lstInningScore.Location = New System.Drawing.Point(19, 152)
        Me.lstInningScore.Name = "lstInningScore"
        Me.lstInningScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstInningScore.Size = New System.Drawing.Size(29, 130)
        Me.lstInningScore.TabIndex = 3
        '
        'lblAverageRain
        '
        Me.lblAverageRain.AutoSize = True
        Me.lblAverageRain.BackColor = System.Drawing.Color.YellowGreen
        Me.lblAverageRain.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageRain.Location = New System.Drawing.Point(54, 152)
        Me.lblAverageRain.Name = "lblAverageRain"
        Me.lblAverageRain.Size = New System.Drawing.Size(233, 58)
        Me.lblAverageRain.TabIndex = 4
        Me.lblAverageRain.Text = "Total inning score " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is XX.X"
        Me.lblAverageRain.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblAverageRain.Visible = False
        '
        'frmSoftballScoreboard
        '
        Me.AcceptButton = Me.btnInningScore
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(310, 438)
        Me.Controls.Add(Me.lblAverageRain)
        Me.Controls.Add(Me.lstInningScore)
        Me.Controls.Add(Me.btnInningScore)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSoftballScoreboard"
        Me.Text = "Softball Scoreboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnInningScore As Button
    Friend WithEvents lstInningScore As ListBox
    Friend WithEvents lblAverageRain As Label
End Class
