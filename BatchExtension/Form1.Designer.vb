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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblFolder = New System.Windows.Forms.Label()
        Me.txtFolder = New System.Windows.Forms.TextBox()
        Me.btnBrowseFolder = New System.Windows.Forms.Button()
        Me.lvwFiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GridLinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRibbonColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelectedFile = New System.Windows.Forms.Label()
        Me.btnChangeExt = New System.Windows.Forms.Button()
        Me.btnRemoveExt = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblFileType = New System.Windows.Forms.Label()
        Me.cbxSelect = New System.Windows.Forms.ComboBox()
        Me.txtSelectedFiles = New System.Windows.Forms.TextBox()
        Me.txtFileType = New System.Windows.Forms.TextBox()
        Me.lblFileLoc = New System.Windows.Forms.Label()
        Me.txtFileLoc = New System.Windows.Forms.TextBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblTotalFiles = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblFilesExcluded = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblFilesSelected = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.btnRenameFiles = New System.Windows.Forms.Button()
        Me.btnFileProp = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.btnOpenContFolder = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.gbxSelectedFile = New System.Windows.Forms.GroupBox()
        Me.txtFileSize = New System.Windows.Forms.TextBox()
        Me.lblFileSize = New System.Windows.Forms.Label()
        Me.btnLastRunFolder = New System.Windows.Forms.Button()
        Me.grpTasks = New System.Windows.Forms.GroupBox()
        Me.lblTaskFor = New System.Windows.Forms.Label()
        Me.panleFolder = New System.Windows.Forms.Panel()
        Me.txtExcludeList = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxMultipleFolders = New System.Windows.Forms.CheckBox()
        Me.tsbtnBrowseFolder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnOptions = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnUndo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.gbxSelectedFile.SuspendLayout()
        Me.grpTasks.SuspendLayout()
        Me.panleFolder.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFolder
        '
        Me.lblFolder.AutoSize = True
        Me.lblFolder.Location = New System.Drawing.Point(12, 11)
        Me.lblFolder.Name = "lblFolder"
        Me.lblFolder.Size = New System.Drawing.Size(61, 13)
        Me.lblFolder.TabIndex = 0
        Me.lblFolder.Text = "Folder Path"
        '
        'txtFolder
        '
        Me.txtFolder.Location = New System.Drawing.Point(79, 8)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.Size = New System.Drawing.Size(379, 20)
        Me.txtFolder.TabIndex = 1
        '
        'btnBrowseFolder
        '
        Me.btnBrowseFolder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBrowseFolder.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btnBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseFolder.ForeColor = System.Drawing.Color.Black
        Me.btnBrowseFolder.Location = New System.Drawing.Point(468, 6)
        Me.btnBrowseFolder.Name = "btnBrowseFolder"
        Me.btnBrowseFolder.Size = New System.Drawing.Size(78, 23)
        Me.btnBrowseFolder.TabIndex = 2
        Me.btnBrowseFolder.Text = "Browse Folder"
        Me.btnBrowseFolder.UseVisualStyleBackColor = False
        '
        'lvwFiles
        '
        Me.lvwFiles.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lvwFiles.AllowColumnReorder = True
        Me.lvwFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwFiles.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvwFiles.FullRowSelect = True
        Me.lvwFiles.GridLines = True
        Me.lvwFiles.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.lvwFiles.Location = New System.Drawing.Point(8, 142)
        Me.lvwFiles.Name = "lvwFiles"
        Me.lvwFiles.Size = New System.Drawing.Size(477, 392)
        Me.lvwFiles.TabIndex = 3
        Me.lvwFiles.UseCompatibleStateImageBehavior = False
        Me.lvwFiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "File Name"
        Me.ColumnHeader2.Width = 238
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Extension"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Size"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Absolute File Path"
        Me.ColumnHeader5.Width = 151
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date Modified"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "File Description"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1, Me.ToolStripSeparator1, Me.GridLinesToolStripMenuItem, Me.ViewRibbonColorToolStripMenuItem, Me.ToolStripMenuItem2, Me.OptionsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 109)
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Large Icon", "Small Icon", "Tile", "List", "Details"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ToolStripComboBox1.Text = "Details"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'GridLinesToolStripMenuItem
        '
        Me.GridLinesToolStripMenuItem.Checked = True
        Me.GridLinesToolStripMenuItem.CheckOnClick = True
        Me.GridLinesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GridLinesToolStripMenuItem.Name = "GridLinesToolStripMenuItem"
        Me.GridLinesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GridLinesToolStripMenuItem.Text = "View Grid &Lines"
        '
        'ViewRibbonColorToolStripMenuItem
        '
        Me.ViewRibbonColorToolStripMenuItem.Checked = True
        Me.ViewRibbonColorToolStripMenuItem.CheckOnClick = True
        Me.ViewRibbonColorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ViewRibbonColorToolStripMenuItem.Name = "ViewRibbonColorToolStripMenuItem"
        Me.ViewRibbonColorToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ViewRibbonColorToolStripMenuItem.Text = "View &Ribbon Color"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(178, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = CType(resources.GetObject("OptionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'lblSelectedFile
        '
        Me.lblSelectedFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSelectedFile.AutoSize = True
        Me.lblSelectedFile.Location = New System.Drawing.Point(5, 21)
        Me.lblSelectedFile.Name = "lblSelectedFile"
        Me.lblSelectedFile.Size = New System.Drawing.Size(54, 13)
        Me.lblSelectedFile.TabIndex = 4
        Me.lblSelectedFile.Text = "File Name"
        '
        'btnChangeExt
        '
        Me.btnChangeExt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChangeExt.BackColor = System.Drawing.Color.White
        Me.btnChangeExt.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btnChangeExt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnChangeExt.Location = New System.Drawing.Point(141, 50)
        Me.btnChangeExt.Name = "btnChangeExt"
        Me.btnChangeExt.Size = New System.Drawing.Size(107, 27)
        Me.btnChangeExt.TabIndex = 6
        Me.btnChangeExt.Text = "Change Extension"
        Me.btnChangeExt.UseVisualStyleBackColor = False
        '
        'btnRemoveExt
        '
        Me.btnRemoveExt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveExt.BackColor = System.Drawing.Color.White
        Me.btnRemoveExt.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btnRemoveExt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRemoveExt.Location = New System.Drawing.Point(8, 50)
        Me.btnRemoveExt.Name = "btnRemoveExt"
        Me.btnRemoveExt.Size = New System.Drawing.Size(127, 27)
        Me.btnRemoveExt.TabIndex = 7
        Me.btnRemoveExt.Text = "Remove Extension"
        Me.btnRemoveExt.UseVisualStyleBackColor = False
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select a folder"
        '
        'lblFileType
        '
        Me.lblFileType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFileType.AutoSize = True
        Me.lblFileType.Location = New System.Drawing.Point(5, 51)
        Me.lblFileType.Name = "lblFileType"
        Me.lblFileType.Size = New System.Drawing.Size(50, 13)
        Me.lblFileType.TabIndex = 10
        Me.lblFileType.Text = "File Type"
        '
        'cbxSelect
        '
        Me.cbxSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxSelect.FormattingEnabled = True
        Me.cbxSelect.Items.AddRange(New Object() {"All files present in the directory", "Only for the selected file(s)"})
        Me.cbxSelect.Location = New System.Drawing.Point(71, 20)
        Me.cbxSelect.Name = "cbxSelect"
        Me.cbxSelect.Size = New System.Drawing.Size(177, 21)
        Me.cbxSelect.TabIndex = 12
        Me.cbxSelect.Text = "- - SELECT - -"
        '
        'txtSelectedFiles
        '
        Me.txtSelectedFiles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSelectedFiles.BackColor = System.Drawing.Color.White
        Me.txtSelectedFiles.Location = New System.Drawing.Point(72, 19)
        Me.txtSelectedFiles.Name = "txtSelectedFiles"
        Me.txtSelectedFiles.ReadOnly = True
        Me.txtSelectedFiles.Size = New System.Drawing.Size(177, 20)
        Me.txtSelectedFiles.TabIndex = 13
        '
        'txtFileType
        '
        Me.txtFileType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFileType.BackColor = System.Drawing.Color.White
        Me.txtFileType.Location = New System.Drawing.Point(72, 48)
        Me.txtFileType.Name = "txtFileType"
        Me.txtFileType.ReadOnly = True
        Me.txtFileType.Size = New System.Drawing.Size(47, 20)
        Me.txtFileType.TabIndex = 14
        '
        'lblFileLoc
        '
        Me.lblFileLoc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFileLoc.AutoSize = True
        Me.lblFileLoc.Location = New System.Drawing.Point(5, 80)
        Me.lblFileLoc.Name = "lblFileLoc"
        Me.lblFileLoc.Size = New System.Drawing.Size(67, 13)
        Me.lblFileLoc.TabIndex = 15
        Me.lblFileLoc.Text = "File Location"
        '
        'txtFileLoc
        '
        Me.txtFileLoc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFileLoc.BackColor = System.Drawing.Color.White
        Me.txtFileLoc.Location = New System.Drawing.Point(72, 77)
        Me.txtFileLoc.Name = "txtFileLoc"
        Me.txtFileLoc.ReadOnly = True
        Me.txtFileLoc.Size = New System.Drawing.Size(177, 20)
        Me.txtFileLoc.TabIndex = 16
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOpenFile.BackColor = System.Drawing.Color.White
        Me.btnOpenFile.Enabled = False
        Me.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOpenFile.ForeColor = System.Drawing.Color.Black
        Me.btnOpenFile.Location = New System.Drawing.Point(140, 106)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(40, 27)
        Me.btnOpenFile.TabIndex = 17
        Me.btnOpenFile.Text = "Open"
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'txtLog
        '
        Me.txtLog.AcceptsReturn = True
        Me.txtLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.BackColor = System.Drawing.Color.White
        Me.txtLog.Location = New System.Drawing.Point(494, 409)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(258, 125)
        Me.txtLog.TabIndex = 18
        Me.txtLog.WordWrap = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel4, Me.tsslblTotalFiles, Me.ToolStripStatusLabel5, Me.tsslblFilesExcluded, Me.ToolStripStatusLabel10, Me.ToolStripStatusLabel6, Me.tsslblFilesSelected, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel3, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 541)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(761, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(112, 17)
        Me.ToolStripStatusLabel1.Text = "Current Operation : "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(81, 17)
        Me.ToolStripStatusLabel2.Text = "Select a folder"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel8.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(4, 17)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(65, 17)
        Me.ToolStripStatusLabel4.Text = "Total Files :"
        '
        'tsslblTotalFiles
        '
        Me.tsslblTotalFiles.Name = "tsslblTotalFiles"
        Me.tsslblTotalFiles.Size = New System.Drawing.Size(13, 17)
        Me.tsslblTotalFiles.Text = "0"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(4, 17)
        '
        'tsslblFilesExcluded
        '
        Me.tsslblFilesExcluded.Name = "tsslblFilesExcluded"
        Me.tsslblFilesExcluded.Size = New System.Drawing.Size(95, 17)
        Me.tsslblFilesExcluded.Text = "Files Excluded : 0"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel10.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(4, 17)
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(83, 17)
        Me.ToolStripStatusLabel6.Text = "Files Selected :"
        '
        'tsslblFilesSelected
        '
        Me.tsslblFilesSelected.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslblFilesSelected.Name = "tsslblFilesSelected"
        Me.tsslblFilesSelected.Size = New System.Drawing.Size(13, 17)
        Me.tsslblFilesSelected.Text = "0"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel7.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(4, 17)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(165, 17)
        Me.ToolStripStatusLabel3.Spring = True
        Me.ToolStripStatusLabel3.Text = "Progress"
        Me.ToolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripProgressBar1.MarqueeAnimationSpeed = 1
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Step = 1
        '
        'btnRenameFiles
        '
        Me.btnRenameFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRenameFiles.BackColor = System.Drawing.Color.White
        Me.btnRenameFiles.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btnRenameFiles.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRenameFiles.Location = New System.Drawing.Point(8, 82)
        Me.btnRenameFiles.Name = "btnRenameFiles"
        Me.btnRenameFiles.Size = New System.Drawing.Size(97, 27)
        Me.btnRenameFiles.TabIndex = 24
        Me.btnRenameFiles.Text = "Rename File(s)"
        Me.btnRenameFiles.UseVisualStyleBackColor = False
        '
        'btnFileProp
        '
        Me.btnFileProp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFileProp.Enabled = False
        Me.btnFileProp.Location = New System.Drawing.Point(186, 106)
        Me.btnFileProp.Name = "btnFileProp"
        Me.btnFileProp.Size = New System.Drawing.Size(62, 27)
        Me.btnFileProp.TabIndex = 27
        Me.btnFileProp.Text = "Properties"
        Me.btnFileProp.UseVisualStyleBackColor = True
        '
        'btnMore
        '
        Me.btnMore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMore.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btnMore.Location = New System.Drawing.Point(177, 82)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(71, 27)
        Me.btnMore.TabIndex = 28
        Me.btnMore.Text = "More..."
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'btnOpenContFolder
        '
        Me.btnOpenContFolder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOpenContFolder.Enabled = False
        Me.btnOpenContFolder.Location = New System.Drawing.Point(8, 106)
        Me.btnOpenContFolder.Name = "btnOpenContFolder"
        Me.btnOpenContFolder.Size = New System.Drawing.Size(127, 27)
        Me.btnOpenContFolder.TabIndex = 29
        Me.btnOpenContFolder.Text = "Open Containing Folder"
        Me.btnOpenContFolder.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUndo.Enabled = False
        Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btnUndo.Location = New System.Drawing.Point(111, 82)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(61, 27)
        Me.btnUndo.TabIndex = 31
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'gbxSelectedFile
        '
        Me.gbxSelectedFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxSelectedFile.BackColor = System.Drawing.Color.Transparent
        Me.gbxSelectedFile.Controls.Add(Me.txtFileSize)
        Me.gbxSelectedFile.Controls.Add(Me.lblFileSize)
        Me.gbxSelectedFile.Controls.Add(Me.txtSelectedFiles)
        Me.gbxSelectedFile.Controls.Add(Me.btnOpenContFolder)
        Me.gbxSelectedFile.Controls.Add(Me.lblSelectedFile)
        Me.gbxSelectedFile.Controls.Add(Me.lblFileType)
        Me.gbxSelectedFile.Controls.Add(Me.btnFileProp)
        Me.gbxSelectedFile.Controls.Add(Me.txtFileType)
        Me.gbxSelectedFile.Controls.Add(Me.lblFileLoc)
        Me.gbxSelectedFile.Controls.Add(Me.txtFileLoc)
        Me.gbxSelectedFile.Controls.Add(Me.btnOpenFile)
        Me.gbxSelectedFile.Location = New System.Drawing.Point(494, 142)
        Me.gbxSelectedFile.Name = "gbxSelectedFile"
        Me.gbxSelectedFile.Size = New System.Drawing.Size(258, 140)
        Me.gbxSelectedFile.TabIndex = 32
        Me.gbxSelectedFile.TabStop = False
        Me.gbxSelectedFile.Text = "Selected File"
        '
        'txtFileSize
        '
        Me.txtFileSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFileSize.BackColor = System.Drawing.Color.White
        Me.txtFileSize.Location = New System.Drawing.Point(177, 48)
        Me.txtFileSize.Name = "txtFileSize"
        Me.txtFileSize.ReadOnly = True
        Me.txtFileSize.Size = New System.Drawing.Size(72, 20)
        Me.txtFileSize.TabIndex = 34
        '
        'lblFileSize
        '
        Me.lblFileSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFileSize.AutoSize = True
        Me.lblFileSize.Location = New System.Drawing.Point(125, 51)
        Me.lblFileSize.Name = "lblFileSize"
        Me.lblFileSize.Size = New System.Drawing.Size(46, 13)
        Me.lblFileSize.TabIndex = 33
        Me.lblFileSize.Text = "File Size"
        '
        'btnLastRunFolder
        '
        Me.btnLastRunFolder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLastRunFolder.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btnLastRunFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLastRunFolder.Location = New System.Drawing.Point(552, 6)
        Me.btnLastRunFolder.Name = "btnLastRunFolder"
        Me.btnLastRunFolder.Size = New System.Drawing.Size(90, 23)
        Me.btnLastRunFolder.TabIndex = 35
        Me.btnLastRunFolder.Text = "Last Folder"
        Me.btnLastRunFolder.UseVisualStyleBackColor = False
        '
        'grpTasks
        '
        Me.grpTasks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTasks.BackColor = System.Drawing.Color.Transparent
        Me.grpTasks.Controls.Add(Me.lblTaskFor)
        Me.grpTasks.Controls.Add(Me.cbxSelect)
        Me.grpTasks.Controls.Add(Me.btnRemoveExt)
        Me.grpTasks.Controls.Add(Me.btnChangeExt)
        Me.grpTasks.Controls.Add(Me.btnMore)
        Me.grpTasks.Controls.Add(Me.btnUndo)
        Me.grpTasks.Controls.Add(Me.btnRenameFiles)
        Me.grpTasks.Location = New System.Drawing.Point(493, 288)
        Me.grpTasks.Name = "grpTasks"
        Me.grpTasks.Size = New System.Drawing.Size(258, 115)
        Me.grpTasks.TabIndex = 34
        Me.grpTasks.TabStop = False
        Me.grpTasks.Text = "Task"
        '
        'lblTaskFor
        '
        Me.lblTaskFor.AutoSize = True
        Me.lblTaskFor.Location = New System.Drawing.Point(10, 23)
        Me.lblTaskFor.Name = "lblTaskFor"
        Me.lblTaskFor.Size = New System.Drawing.Size(49, 13)
        Me.lblTaskFor.TabIndex = 35
        Me.lblTaskFor.Text = "Task For"
        '
        'panleFolder
        '
        Me.panleFolder.BackColor = System.Drawing.Color.Transparent
        Me.panleFolder.BackgroundImage = Global.BatchExtension.My.Resources.Resources.themeBlueL
        Me.panleFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panleFolder.Controls.Add(Me.txtExcludeList)
        Me.panleFolder.Controls.Add(Me.Button1)
        Me.panleFolder.Controls.Add(Me.Label1)
        Me.panleFolder.Controls.Add(Me.cbxMultipleFolders)
        Me.panleFolder.Controls.Add(Me.btnLastRunFolder)
        Me.panleFolder.Controls.Add(Me.lblFolder)
        Me.panleFolder.Controls.Add(Me.btnBrowseFolder)
        Me.panleFolder.Controls.Add(Me.txtFolder)
        Me.panleFolder.Dock = System.Windows.Forms.DockStyle.Top
        Me.panleFolder.Location = New System.Drawing.Point(0, 70)
        Me.panleFolder.Name = "panleFolder"
        Me.panleFolder.Size = New System.Drawing.Size(761, 65)
        Me.panleFolder.TabIndex = 36
        '
        'txtExcludeList
        '
        Me.txtExcludeList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtExcludeList.Location = New System.Drawing.Point(79, 35)
        Me.txtExcludeList.Name = "txtExcludeList"
        Me.txtExcludeList.ReadOnly = True
        Me.txtExcludeList.Size = New System.Drawing.Size(121, 20)
        Me.txtExcludeList.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(206, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Modify"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Exclude List"
        '
        'cbxMultipleFolders
        '
        Me.cbxMultipleFolders.AutoSize = True
        Me.cbxMultipleFolders.Location = New System.Drawing.Point(294, 37)
        Me.cbxMultipleFolders.Name = "cbxMultipleFolders"
        Me.cbxMultipleFolders.Size = New System.Drawing.Size(164, 17)
        Me.cbxMultipleFolders.TabIndex = 37
        Me.cbxMultipleFolders.Text = "Allow adding multiple folder(s)"
        Me.cbxMultipleFolders.UseVisualStyleBackColor = True
        '
        'tsbtnBrowseFolder
        '
        Me.tsbtnBrowseFolder.Image = CType(resources.GetObject("tsbtnBrowseFolder.Image"), System.Drawing.Image)
        Me.tsbtnBrowseFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnBrowseFolder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnBrowseFolder.Name = "tsbtnBrowseFolder"
        Me.tsbtnBrowseFolder.Size = New System.Drawing.Size(78, 67)
        Me.tsbtnBrowseFolder.Text = "Select Folder"
        Me.tsbtnBrowseFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(68, 67)
        Me.ToolStripButton1.Text = "Last Folder"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 70)
        '
        'tsbtnOptions
        '
        Me.tsbtnOptions.Image = CType(resources.GetObject("tsbtnOptions.Image"), System.Drawing.Image)
        Me.tsbtnOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOptions.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tsbtnOptions.Name = "tsbtnOptions"
        Me.tsbtnOptions.Size = New System.Drawing.Size(53, 67)
        Me.tsbtnOptions.Text = "Options"
        Me.tsbtnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 70)
        '
        'tsbtnUndo
        '
        Me.tsbtnUndo.Enabled = False
        Me.tsbtnUndo.Image = CType(resources.GetObject("tsbtnUndo.Image"), System.Drawing.Image)
        Me.tsbtnUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUndo.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.tsbtnUndo.Name = "tsbtnUndo"
        Me.tsbtnUndo.Size = New System.Drawing.Size(52, 67)
        Me.tsbtnUndo.Text = "Undo"
        Me.tsbtnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 70)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton5.Text = "About"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(5, 1, 3, 2)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton3.Text = "Help"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 1, 3, 2)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton4.Text = "Info"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 70)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton6.Text = "Exit"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.BatchExtension.My.Resources.Resources.themeBlueL
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnBrowseFolder, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.tsbtnOptions, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.tsbtnUndo, Me.ToolStripSeparator4, Me.ToolStripButton5, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator5, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.Size = New System.Drawing.Size(761, 70)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton2.Text = "Theme"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.BatchExtension.My.Resources.Resources.themeBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(761, 563)
        Me.Controls.Add(Me.grpTasks)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.gbxSelectedFile)
        Me.Controls.Add(Me.lvwFiles)
        Me.Controls.Add(Me.panleFolder)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(710, 545)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy File Namer"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbxSelectedFile.ResumeLayout(False)
        Me.gbxSelectedFile.PerformLayout()
        Me.grpTasks.ResumeLayout(False)
        Me.grpTasks.PerformLayout()
        Me.panleFolder.ResumeLayout(False)
        Me.panleFolder.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFolder As Label
    Friend WithEvents txtFolder As TextBox
    Friend WithEvents btnBrowseFolder As Button
    Friend WithEvents lvwFiles As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lblSelectedFile As Label
    Friend WithEvents btnChangeExt As Button
    Friend WithEvents btnRemoveExt As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblFileType As Label
    Friend WithEvents cbxSelect As ComboBox
    Friend WithEvents txtSelectedFiles As TextBox
    Friend WithEvents txtFileType As TextBox
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents lblFileLoc As Label
    Friend WithEvents txtFileLoc As TextBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents txtLog As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents btnRenameFiles As Button
    Friend WithEvents btnFileProp As Button
    Friend WithEvents btnMore As Button
    Friend WithEvents btnOpenContFolder As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents tsslblTotalFiles As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents tsslblFilesSelected As ToolStripStatusLabel
    Friend WithEvents gbxSelectedFile As GroupBox
    Friend WithEvents txtFileSize As TextBox
    Friend WithEvents lblFileSize As Label
    Friend WithEvents grpTasks As GroupBox
    Friend WithEvents lblTaskFor As Label
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents btnLastRunFolder As Button
    Friend WithEvents tsslblFilesExcluded As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As ToolStripStatusLabel
    Friend WithEvents panleFolder As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxMultipleFolders As CheckBox
    Friend WithEvents tsbtnBrowseFolder As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbtnOptions As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbtnUndo As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GridLinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewRibbonColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtExcludeList As TextBox
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
