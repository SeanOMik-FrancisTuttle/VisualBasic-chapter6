<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainfall
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
        Me.btnRainfall = New System.Windows.Forms.Button()
        Me.lstRainfall = New System.Windows.Forms.ListBox()
        Me.lblAverageRain = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(674, 24)
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
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblTitle.Location = New System.Drawing.Point(12, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(426, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Most Rainfall in the US - Kauai"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnRainfall
        '
        Me.btnRainfall.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRainfall.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRainfall.Location = New System.Drawing.Point(157, 135)
        Me.btnRainfall.Name = "btnRainfall"
        Me.btnRainfall.Size = New System.Drawing.Size(199, 35)
        Me.btnRainfall.TabIndex = 2
        Me.btnRainfall.Text = "Enter Rainfall"
        Me.btnRainfall.UseVisualStyleBackColor = False
        '
        'lstRainfall
        '
        Me.lstRainfall.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRainfall.ForeColor = System.Drawing.Color.DarkOrange
        Me.lstRainfall.FormattingEnabled = True
        Me.lstRainfall.ItemHeight = 18
        Me.lstRainfall.Location = New System.Drawing.Point(499, 43)
        Me.lstRainfall.Name = "lstRainfall"
        Me.lstRainfall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstRainfall.Size = New System.Drawing.Size(56, 220)
        Me.lstRainfall.TabIndex = 3
        '
        'lblAverageRain
        '
        Me.lblAverageRain.BackColor = System.Drawing.SystemColors.Control
        Me.lblAverageRain.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageRain.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblAverageRain.Location = New System.Drawing.Point(36, 192)
        Me.lblAverageRain.Name = "lblAverageRain"
        Me.lblAverageRain.Size = New System.Drawing.Size(440, 25)
        Me.lblAverageRain.TabIndex = 4
        Me.lblAverageRain.Text = "Average Rainfall per Month is X.X inches"
        Me.lblAverageRain.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblAverageRain.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(200, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rainfall Average"
        '
        'frmRainfall
        '
        Me.AcceptButton = Me.btnRainfall
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FitnessChallenge.My.Resources.Resources.hawaii
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(674, 497)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAverageRain)
        Me.Controls.Add(Me.lstRainfall)
        Me.Controls.Add(Me.btnRainfall)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRainfall"
        Me.Text = "Most Rainfall in the USA"
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
    Friend WithEvents btnRainfall As Button
    Friend WithEvents lstRainfall As ListBox
    Friend WithEvents lblAverageRain As Label
    Friend WithEvents Label1 As Label
End Class
