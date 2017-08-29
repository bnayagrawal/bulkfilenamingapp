<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMore))
        Me.gbxGeneral = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtSaveFilesTo = New System.Windows.Forms.TextBox()
        Me.lblSaveFilesTo = New System.Windows.Forms.Label()
        Me.txtWithExtName = New System.Windows.Forms.TextBox()
        Me.lblWithExtName = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblFilesToCreate = New System.Windows.Forms.Label()
        Me.gbxMoreOptions = New System.Windows.Forms.GroupBox()
        Me.txtStringToAppend = New System.Windows.Forms.TextBox()
        Me.lblStringToAppend = New System.Windows.Forms.Label()
        Me.chkAppendStringBeforeNum = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.lblDefFileNameNumFrom = New System.Windows.Forms.Label()
        Me.rbNameFileWithNum = New System.Windows.Forms.RadioButton()
        Me.rbGenRandFileName = New System.Windows.Forms.RadioButton()
        Me.btnStartCreatingFiles = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsProg = New System.Windows.Forms.ToolStripProgressBar()
        Me.gbxGeneral.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxMoreOptions.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxGeneral
        '
        Me.gbxGeneral.BackColor = System.Drawing.Color.Transparent
        Me.gbxGeneral.Controls.Add(Me.btnBrowse)
        Me.gbxGeneral.Controls.Add(Me.txtSaveFilesTo)
        Me.gbxGeneral.Controls.Add(Me.lblSaveFilesTo)
        Me.gbxGeneral.Controls.Add(Me.txtWithExtName)
        Me.gbxGeneral.Controls.Add(Me.lblWithExtName)
        Me.gbxGeneral.Controls.Add(Me.NumericUpDown1)
        Me.gbxGeneral.Controls.Add(Me.lblFilesToCreate)
        Me.gbxGeneral.Location = New System.Drawing.Point(10, 5)
        Me.gbxGeneral.Name = "gbxGeneral"
        Me.gbxGeneral.Size = New System.Drawing.Size(264, 112)
        Me.gbxGeneral.TabIndex = 0
        Me.gbxGeneral.TabStop = False
        Me.gbxGeneral.Text = "General"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(197, 78)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(59, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtSaveFilesTo
        '
        Me.txtSaveFilesTo.Location = New System.Drawing.Point(91, 79)
        Me.txtSaveFilesTo.Name = "txtSaveFilesTo"
        Me.txtSaveFilesTo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaveFilesTo.TabIndex = 3
        '
        'lblSaveFilesTo
        '
        Me.lblSaveFilesTo.AutoSize = True
        Me.lblSaveFilesTo.Location = New System.Drawing.Point(7, 82)
        Me.lblSaveFilesTo.Name = "lblSaveFilesTo"
        Me.lblSaveFilesTo.Size = New System.Drawing.Size(78, 13)
        Me.lblSaveFilesTo.TabIndex = 2
        Me.lblSaveFilesTo.Text = "Save File(s) To"
        '
        'txtWithExtName
        '
        Me.txtWithExtName.Location = New System.Drawing.Point(138, 52)
        Me.txtWithExtName.Name = "txtWithExtName"
        Me.txtWithExtName.Size = New System.Drawing.Size(118, 20)
        Me.txtWithExtName.TabIndex = 2
        '
        'lblWithExtName
        '
        Me.lblWithExtName.AutoSize = True
        Me.lblWithExtName.Location = New System.Drawing.Point(6, 56)
        Me.lblWithExtName.Name = "lblWithExtName"
        Me.lblWithExtName.Size = New System.Drawing.Size(109, 13)
        Me.lblWithExtName.TabIndex = 1
        Me.lblWithExtName.Text = "With Extension Name"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(138, 24)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(118, 20)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblFilesToCreate
        '
        Me.lblFilesToCreate.AutoSize = True
        Me.lblFilesToCreate.Location = New System.Drawing.Point(6, 26)
        Me.lblFilesToCreate.Name = "lblFilesToCreate"
        Me.lblFilesToCreate.Size = New System.Drawing.Size(128, 13)
        Me.lblFilesToCreate.TabIndex = 0
        Me.lblFilesToCreate.Text = "Number of file(s) to create"
        '
        'gbxMoreOptions
        '
        Me.gbxMoreOptions.BackColor = System.Drawing.Color.Transparent
        Me.gbxMoreOptions.Controls.Add(Me.txtStringToAppend)
        Me.gbxMoreOptions.Controls.Add(Me.lblStringToAppend)
        Me.gbxMoreOptions.Controls.Add(Me.chkAppendStringBeforeNum)
        Me.gbxMoreOptions.Controls.Add(Me.NumericUpDown2)
        Me.gbxMoreOptions.Controls.Add(Me.lblDefFileNameNumFrom)
        Me.gbxMoreOptions.Controls.Add(Me.rbNameFileWithNum)
        Me.gbxMoreOptions.Controls.Add(Me.rbGenRandFileName)
        Me.gbxMoreOptions.Location = New System.Drawing.Point(10, 123)
        Me.gbxMoreOptions.Name = "gbxMoreOptions"
        Me.gbxMoreOptions.Size = New System.Drawing.Size(264, 140)
        Me.gbxMoreOptions.TabIndex = 1
        Me.gbxMoreOptions.TabStop = False
        Me.gbxMoreOptions.Text = "More Options"
        '
        'txtStringToAppend
        '
        Me.txtStringToAppend.Enabled = False
        Me.txtStringToAppend.Location = New System.Drawing.Point(138, 111)
        Me.txtStringToAppend.Name = "txtStringToAppend"
        Me.txtStringToAppend.Size = New System.Drawing.Size(118, 20)
        Me.txtStringToAppend.TabIndex = 9
        '
        'lblStringToAppend
        '
        Me.lblStringToAppend.AutoSize = True
        Me.lblStringToAppend.Enabled = False
        Me.lblStringToAppend.Location = New System.Drawing.Point(7, 113)
        Me.lblStringToAppend.Name = "lblStringToAppend"
        Me.lblStringToAppend.Size = New System.Drawing.Size(118, 13)
        Me.lblStringToAppend.TabIndex = 3
        Me.lblStringToAppend.Text = "Enter String To Append"
        '
        'chkAppendStringBeforeNum
        '
        Me.chkAppendStringBeforeNum.AutoSize = True
        Me.chkAppendStringBeforeNum.Location = New System.Drawing.Point(10, 89)
        Me.chkAppendStringBeforeNum.Name = "chkAppendStringBeforeNum"
        Me.chkAppendStringBeforeNum.Size = New System.Drawing.Size(171, 17)
        Me.chkAppendStringBeforeNum.TabIndex = 8
        Me.chkAppendStringBeforeNum.Text = "Append a string before number"
        Me.chkAppendStringBeforeNum.UseVisualStyleBackColor = True
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(167, 65)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(89, 20)
        Me.NumericUpDown2.TabIndex = 7
        '
        'lblDefFileNameNumFrom
        '
        Me.lblDefFileNameNumFrom.AutoSize = True
        Me.lblDefFileNameNumFrom.Location = New System.Drawing.Point(7, 68)
        Me.lblDefFileNameNumFrom.Name = "lblDefFileNameNumFrom"
        Me.lblDefFileNameNumFrom.Size = New System.Drawing.Size(154, 13)
        Me.lblDefFileNameNumFrom.TabIndex = 2
        Me.lblDefFileNameNumFrom.Text = "Define File Name Number From"
        '
        'rbNameFileWithNum
        '
        Me.rbNameFileWithNum.AutoSize = True
        Me.rbNameFileWithNum.Checked = True
        Me.rbNameFileWithNum.Location = New System.Drawing.Point(10, 42)
        Me.rbNameFileWithNum.Name = "rbNameFileWithNum"
        Me.rbNameFileWithNum.Size = New System.Drawing.Size(147, 17)
        Me.rbNameFileWithNum.TabIndex = 6
        Me.rbNameFileWithNum.TabStop = True
        Me.rbNameFileWithNum.Text = "Name Files With Numbers"
        Me.rbNameFileWithNum.UseVisualStyleBackColor = True
        '
        'rbGenRandFileName
        '
        Me.rbGenRandFileName.AutoSize = True
        Me.rbGenRandFileName.Location = New System.Drawing.Point(10, 19)
        Me.rbGenRandFileName.Name = "rbGenRandFileName"
        Me.rbGenRandFileName.Size = New System.Drawing.Size(162, 17)
        Me.rbGenRandFileName.TabIndex = 5
        Me.rbGenRandFileName.Text = "Generate Random File Name"
        Me.rbGenRandFileName.UseVisualStyleBackColor = True
        '
        'btnStartCreatingFiles
        '
        Me.btnStartCreatingFiles.Location = New System.Drawing.Point(168, 395)
        Me.btnStartCreatingFiles.Name = "btnStartCreatingFiles"
        Me.btnStartCreatingFiles.Size = New System.Drawing.Size(104, 23)
        Me.btnStartCreatingFiles.TabIndex = 10
        Me.btnStartCreatingFiles.Text = "Start Creating Files"
        Me.btnStartCreatingFiles.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.White
        Me.txtLog.Location = New System.Drawing.Point(10, 271)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(262, 118)
        Me.txtLog.TabIndex = 3
        Me.txtLog.WordWrap = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(10, 395)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(132, 395)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(32, 23)
        Me.btnHelp.TabIndex = 11
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsProg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(136, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Progress"
        '
        'tsProg
        '
        Me.tsProg.ForeColor = System.Drawing.Color.Teal
        Me.tsProg.Name = "tsProg"
        Me.tsProg.Size = New System.Drawing.Size(100, 16)
        Me.tsProg.Step = 1
        '
        'frmMore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnStartCreatingFiles)
        Me.Controls.Add(Me.gbxMoreOptions)
        Me.Controls.Add(Me.gbxGeneral)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMore"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "More File Operation"
        Me.gbxGeneral.ResumeLayout(False)
        Me.gbxGeneral.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxMoreOptions.ResumeLayout(False)
        Me.gbxMoreOptions.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxGeneral As GroupBox
    Friend WithEvents txtWithExtName As TextBox
    Friend WithEvents lblWithExtName As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblFilesToCreate As Label
    Friend WithEvents gbxMoreOptions As GroupBox
    Friend WithEvents txtStringToAppend As TextBox
    Friend WithEvents lblStringToAppend As Label
    Friend WithEvents chkAppendStringBeforeNum As CheckBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents lblDefFileNameNumFrom As Label
    Friend WithEvents rbNameFileWithNum As RadioButton
    Friend WithEvents rbGenRandFileName As RadioButton
    Friend WithEvents btnStartCreatingFiles As Button
    Friend WithEvents txtLog As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtSaveFilesTo As TextBox
    Friend WithEvents lblSaveFilesTo As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tsProg As ToolStripProgressBar
End Class
