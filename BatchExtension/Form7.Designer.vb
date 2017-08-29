<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUndo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUndo))
        Me.lvwFiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRestoreFileName = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.cbxOptions = New System.Windows.Forms.ComboBox()
        Me.lblSelectedItems = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvwFiles
        '
        Me.lvwFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwFiles.FullRowSelect = True
        Me.lvwFiles.GridLines = True
        Me.lvwFiles.Location = New System.Drawing.Point(10, 10)
        Me.lvwFiles.Name = "lvwFiles"
        Me.lvwFiles.Size = New System.Drawing.Size(699, 380)
        Me.lvwFiles.TabIndex = 0
        Me.lvwFiles.UseCompatibleStateImageBehavior = False
        Me.lvwFiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 36
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Old File Name"
        Me.ColumnHeader2.Width = 168
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Current File Name"
        Me.ColumnHeader3.Width = 191
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Absolute Path"
        Me.ColumnHeader4.Width = 297
        '
        'btnRestoreFileName
        '
        Me.btnRestoreFileName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestoreFileName.Enabled = False
        Me.btnRestoreFileName.Location = New System.Drawing.Point(602, 396)
        Me.btnRestoreFileName.Name = "btnRestoreFileName"
        Me.btnRestoreFileName.Size = New System.Drawing.Size(107, 23)
        Me.btnRestoreFileName.TabIndex = 1
        Me.btnRestoreFileName.Text = "&Restore File Name"
        Me.btnRestoreFileName.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(521, 396)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(415, 397)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 20)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 4
        '
        'lblTotalItems
        '
        Me.lblTotalItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalItems.Location = New System.Drawing.Point(182, 401)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(80, 13)
        Me.lblTotalItems.TabIndex = 5
        Me.lblTotalItems.Text = "Total Item(s) : 0"
        '
        'cbxOptions
        '
        Me.cbxOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxOptions.FormattingEnabled = True
        Me.cbxOptions.Items.AddRange(New Object() {"Only for the selected file(s)", "All File(s)"})
        Me.cbxOptions.Location = New System.Drawing.Point(10, 398)
        Me.cbxOptions.Name = "cbxOptions"
        Me.cbxOptions.Size = New System.Drawing.Size(166, 21)
        Me.cbxOptions.TabIndex = 6
        Me.cbxOptions.Text = " - - SELECT - - "
        '
        'lblSelectedItems
        '
        Me.lblSelectedItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSelectedItems.AutoSize = True
        Me.lblSelectedItems.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectedItems.Location = New System.Drawing.Point(289, 401)
        Me.lblSelectedItems.Name = "lblSelectedItems"
        Me.lblSelectedItems.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedItems.TabIndex = 7
        Me.lblSelectedItems.Text = "Selected Item(s) : 0"
        '
        'frmUndo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(721, 426)
        Me.Controls.Add(Me.lblSelectedItems)
        Me.Controls.Add(Me.cbxOptions)
        Me.Controls.Add(Me.lblTotalItems)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRestoreFileName)
        Me.Controls.Add(Me.lvwFiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(737, 465)
        Me.Name = "frmUndo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Undo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwFiles As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnRestoreFileName As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents cbxOptions As ComboBox
    Friend WithEvents lblSelectedItems As Label
End Class
