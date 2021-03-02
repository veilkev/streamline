<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStreamline
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStreamline))
        Me.pbArt = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.txtbxURL = New System.Windows.Forms.TextBox()
        Me.txtbxSave = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.saveTo = New System.Windows.Forms.FolderBrowserDialog()
        Me.optPaste = New System.Windows.Forms.CheckBox()
        Me.pbStream = New System.Windows.Forms.ProgressBar()
        Me.msLine = New System.Windows.Forms.MenuStrip()
        Me.msFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSaveTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.sitesTS = New System.Windows.Forms.ToolStripMenuItem()
        Me.themeTS = New System.Windows.Forms.ToolStripMenuItem()
        Me.LMTS = New System.Windows.Forms.ToolStripMenuItem()
        Me.dMTS = New System.Windows.Forms.ToolStripMenuItem()
        Me.nameTS = New System.Windows.Forms.ToolStripMenuItem()
        Me.nameTSON = New System.Windows.Forms.ToolStripMenuItem()
        Me.nameTSOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.msAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.optAudio = New System.Windows.Forms.CheckBox()
        CType(Me.pbArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msLine.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbArt
        '
        Me.pbArt.BackgroundImage = CType(resources.GetObject("pbArt.BackgroundImage"), System.Drawing.Image)
        Me.pbArt.Location = New System.Drawing.Point(-1, 33)
        Me.pbArt.Name = "pbArt"
        Me.pbArt.Size = New System.Drawing.Size(493, 512)
        Me.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbArt.TabIndex = 0
        Me.pbArt.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(287, 49)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(174, 39)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Streamline"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(317, 88)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(48, 13)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version: "
        '
        'txtbxURL
        '
        Me.txtbxURL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtbxURL.Location = New System.Drawing.Point(79, 456)
        Me.txtbxURL.Name = "txtbxURL"
        Me.txtbxURL.Size = New System.Drawing.Size(382, 20)
        Me.txtbxURL.TabIndex = 3
        Me.txtbxURL.Text = "Enter a supported URL"
        Me.txtbxURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbxSave
        '
        Me.txtbxSave.Location = New System.Drawing.Point(79, 483)
        Me.txtbxSave.Name = "txtbxSave"
        Me.txtbxSave.ReadOnly = True
        Me.txtbxSave.Size = New System.Drawing.Size(382, 20)
        Me.txtbxSave.TabIndex = 4
        Me.txtbxSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(22, 561)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 13)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status: "
        '
        'optPaste
        '
        Me.optPaste.AutoSize = True
        Me.optPaste.Checked = True
        Me.optPaste.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optPaste.Location = New System.Drawing.Point(417, 541)
        Me.optPaste.Name = "optPaste"
        Me.optPaste.Size = New System.Drawing.Size(75, 17)
        Me.optPaste.TabIndex = 9
        Me.optPaste.Text = "&Auto Copy"
        Me.optPaste.UseVisualStyleBackColor = True
        '
        'pbStream
        '
        Me.pbStream.Location = New System.Drawing.Point(71, 564)
        Me.pbStream.Name = "pbStream"
        Me.pbStream.Size = New System.Drawing.Size(99, 10)
        Me.pbStream.TabIndex = 10
        '
        'msLine
        '
        Me.msLine.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msFile, Me.msSettings, Me.msAbout})
        Me.msLine.Location = New System.Drawing.Point(0, 0)
        Me.msLine.Name = "msLine"
        Me.msLine.Size = New System.Drawing.Size(504, 24)
        Me.msLine.TabIndex = 11
        Me.msLine.Text = "MenuStrip1"
        '
        'msFile
        '
        Me.msFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msSaveTo})
        Me.msFile.Name = "msFile"
        Me.msFile.Size = New System.Drawing.Size(37, 20)
        Me.msFile.Text = "File"
        '
        'msSaveTo
        '
        Me.msSaveTo.Name = "msSaveTo"
        Me.msSaveTo.Size = New System.Drawing.Size(113, 22)
        Me.msSaveTo.Text = "Save To"
        '
        'msSettings
        '
        Me.msSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sitesTS, Me.themeTS, Me.nameTS})
        Me.msSettings.Name = "msSettings"
        Me.msSettings.Size = New System.Drawing.Size(61, 20)
        Me.msSettings.Text = "Settings"
        '
        'sitesTS
        '
        Me.sitesTS.Name = "sitesTS"
        Me.sitesTS.Size = New System.Drawing.Size(160, 22)
        Me.sitesTS.Text = "Support Sites"
        '
        'themeTS
        '
        Me.themeTS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LMTS, Me.dMTS})
        Me.themeTS.Name = "themeTS"
        Me.themeTS.Size = New System.Drawing.Size(160, 22)
        Me.themeTS.Text = "Theme"
        '
        'LMTS
        '
        Me.LMTS.Enabled = False
        Me.LMTS.Name = "LMTS"
        Me.LMTS.Size = New System.Drawing.Size(135, 22)
        Me.LMTS.Text = "Light Mode"
        '
        'dMTS
        '
        Me.dMTS.Enabled = False
        Me.dMTS.Name = "dMTS"
        Me.dMTS.Size = New System.Drawing.Size(135, 22)
        Me.dMTS.Text = "Dark Mode"
        '
        'nameTS
        '
        Me.nameTS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nameTSON, Me.nameTSOFF})
        Me.nameTS.Name = "nameTS"
        Me.nameTS.Size = New System.Drawing.Size(160, 22)
        Me.nameTS.Text = "Custom naming"
        '
        'nameTSON
        '
        Me.nameTSON.Name = "nameTSON"
        Me.nameTSON.Size = New System.Drawing.Size(91, 22)
        Me.nameTSON.Text = "On"
        '
        'nameTSOFF
        '
        Me.nameTSOFF.Enabled = False
        Me.nameTSOFF.Name = "nameTSOFF"
        Me.nameTSOFF.Size = New System.Drawing.Size(91, 22)
        Me.nameTSOFF.Text = "Off"
        '
        'msAbout
        '
        Me.msAbout.Name = "msAbout"
        Me.msAbout.Size = New System.Drawing.Size(52, 20)
        Me.msAbout.Text = "About"
        '
        'btnDown
        '
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Location = New System.Drawing.Point(196, 509)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(137, 65)
        Me.btnDown.TabIndex = 12
        Me.btnDown.Text = "&Download"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'optAudio
        '
        Me.optAudio.AutoSize = True
        Me.optAudio.Location = New System.Drawing.Point(417, 564)
        Me.optAudio.Name = "optAudio"
        Me.optAudio.Size = New System.Drawing.Size(77, 17)
        Me.optAudio.TabIndex = 13
        Me.optAudio.Text = "Audio &Only"
        Me.optAudio.UseVisualStyleBackColor = True
        '
        'frmStreamline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(504, 589)
        Me.Controls.Add(Me.optAudio)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.pbStream)
        Me.Controls.Add(Me.optPaste)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtbxSave)
        Me.Controls.Add(Me.txtbxURL)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbArt)
        Me.Controls.Add(Me.msLine)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msLine
        Me.Name = "frmStreamline"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Streamline"
        CType(Me.pbArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msLine.ResumeLayout(False)
        Me.msLine.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbArt As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents txtbxURL As System.Windows.Forms.TextBox
    Friend WithEvents txtbxSave As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents saveTo As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents optPaste As System.Windows.Forms.CheckBox
    Friend WithEvents pbStream As System.Windows.Forms.ProgressBar
    Friend WithEvents msLine As System.Windows.Forms.MenuStrip
    Friend WithEvents msSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sitesTS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents themeTS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LMTS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dMTS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msSaveTo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents nameTS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nameTSON As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nameTSOFF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optAudio As System.Windows.Forms.CheckBox

End Class
