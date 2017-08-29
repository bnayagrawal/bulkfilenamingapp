<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoveExt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemoveExt))
        Me.gbxFilesToSkip = New System.Windows.Forms.GroupBox()
        Me.btnRemoveAllItems = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.lbxItemsToSkip = New System.Windows.Forms.ListBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.txtExtName = New System.Windows.Forms.TextBox()
        Me.lblExtName = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkRemoveAllExtTypes = New System.Windows.Forms.CheckBox()
        Me.gbxFilesToSkip.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxFilesToSkip
        '
        Me.gbxFilesToSkip.BackColor = System.Drawing.Color.Transparent
        Me.gbxFilesToSkip.Controls.Add(Me.btnRemoveAllItems)
        Me.gbxFilesToSkip.Controls.Add(Me.btnRemoveItem)
        Me.gbxFilesToSkip.Controls.Add(Me.lblTotalItems)
        Me.gbxFilesToSkip.Controls.Add(Me.lbxItemsToSkip)
        Me.gbxFilesToSkip.Controls.Add(Me.lblDescription)
        Me.gbxFilesToSkip.Controls.Add(Me.btnAddItem)
        Me.gbxFilesToSkip.Controls.Add(Me.txtExtName)
        Me.gbxFilesToSkip.Controls.Add(Me.lblExtName)
        Me.gbxFilesToSkip.Location = New System.Drawing.Point(8, 3)
        Me.gbxFilesToSkip.Name = "gbxFilesToSkip"
        Me.gbxFilesToSkip.Size = New System.Drawing.Size(252, 155)
        Me.gbxFilesToSkip.TabIndex = 0
        Me.gbxFilesToSkip.TabStop = False
        Me.gbxFilesToSkip.Text = "Files to skip"
        '
        'btnRemoveAllItems
        '
        Me.btnRemoveAllItems.Location = New System.Drawing.Point(137, 122)
        Me.btnRemoveAllItems.Name = "btnRemoveAllItems"
        Me.btnRemoveAllItems.Size = New System.Drawing.Size(109, 23)
        Me.btnRemoveAllItems.TabIndex = 4
        Me.btnRemoveAllItems.Text = "Remove all item(s)"
        Me.btnRemoveAllItems.UseVisualStyleBackColor = True
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Enabled = False
        Me.btnRemoveItem.Location = New System.Drawing.Point(137, 93)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(109, 23)
        Me.btnRemoveItem.TabIndex = 4
        Me.btnRemoveItem.Text = "Remove item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Location = New System.Drawing.Point(137, 66)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(79, 13)
        Me.lblTotalItems.TabIndex = 4
        Me.lblTotalItems.Text = "Total item(s) : 3"
        '
        'lbxItemsToSkip
        '
        Me.lbxItemsToSkip.FormattingEnabled = True
        Me.lbxItemsToSkip.Items.AddRange(New Object() {"sys", "ini", "dll"})
        Me.lbxItemsToSkip.Location = New System.Drawing.Point(11, 62)
        Me.lbxItemsToSkip.Name = "lbxItemsToSkip"
        Me.lbxItemsToSkip.ScrollAlwaysVisible = True
        Me.lbxItemsToSkip.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxItemsToSkip.Size = New System.Drawing.Size(120, 82)
        Me.lbxItemsToSkip.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(8, 41)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(217, 13)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Files having these extensions will be skipped"
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(179, 14)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(67, 23)
        Me.btnAddItem.TabIndex = 2
        Me.btnAddItem.Text = "&Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'txtExtName
        '
        Me.txtExtName.Location = New System.Drawing.Point(105, 16)
        Me.txtExtName.Name = "txtExtName"
        Me.txtExtName.Size = New System.Drawing.Size(68, 20)
        Me.txtExtName.TabIndex = 1
        '
        'lblExtName
        '
        Me.lblExtName.AutoSize = True
        Me.lblExtName.Location = New System.Drawing.Point(8, 19)
        Me.lblExtName.Name = "lblExtName"
        Me.lblExtName.Size = New System.Drawing.Size(84, 13)
        Me.lblExtName.TabIndex = 0
        Me.lblExtName.Text = "Extension Name"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(187, 183)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(106, 183)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkRemoveAllExtTypes
        '
        Me.chkRemoveAllExtTypes.AutoSize = True
        Me.chkRemoveAllExtTypes.BackColor = System.Drawing.Color.Transparent
        Me.chkRemoveAllExtTypes.Location = New System.Drawing.Point(19, 164)
        Me.chkRemoveAllExtTypes.Name = "chkRemoveAllExtTypes"
        Me.chkRemoveAllExtTypes.Size = New System.Drawing.Size(155, 17)
        Me.chkRemoveAllExtTypes.TabIndex = 3
        Me.chkRemoveAllExtTypes.Text = "&Remove all extension types"
        Me.chkRemoveAllExtTypes.UseVisualStyleBackColor = False
        '
        'frmRemoveExt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(269, 214)
        Me.Controls.Add(Me.chkRemoveAllExtTypes)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.gbxFilesToSkip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRemoveExt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Remove Extension"
        Me.gbxFilesToSkip.ResumeLayout(False)
        Me.gbxFilesToSkip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxFilesToSkip As GroupBox
    Friend WithEvents btnRemoveAllItems As Button
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents lbxItemsToSkip As ListBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents txtExtName As TextBox
    Friend WithEvents lblExtName As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkRemoveAllExtTypes As CheckBox
End Class
