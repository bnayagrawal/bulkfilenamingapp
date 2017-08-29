<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeExtension
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeExtension))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkJustAppendExtName = New System.Windows.Forms.CheckBox()
        Me.gbxFilesToSkip = New System.Windows.Forms.GroupBox()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnRemoveAllItems = New System.Windows.Forms.Button()
        Me.lbxFilesToSkip = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtExtNameSkip = New System.Windows.Forms.TextBox()
        Me.lblExtNameSkip = New System.Windows.Forms.Label()
        Me.gbxGeneralOptions = New System.Windows.Forms.GroupBox()
        Me.txtExtName = New System.Windows.Forms.TextBox()
        Me.lblExtName = New System.Windows.Forms.Label()
        Me.gbxFilesToSkip.SuspendLayout()
        Me.gbxGeneralOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStart.Location = New System.Drawing.Point(191, 221)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(59, 23)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(127, 221)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkJustAppendExtName
        '
        Me.chkJustAppendExtName.AutoSize = True
        Me.chkJustAppendExtName.Location = New System.Drawing.Point(9, 42)
        Me.chkJustAppendExtName.Name = "chkJustAppendExtName"
        Me.chkJustAppendExtName.Size = New System.Drawing.Size(179, 17)
        Me.chkJustAppendExtName.TabIndex = 2
        Me.chkJustAppendExtName.Text = "Just append the extension name"
        Me.chkJustAppendExtName.UseVisualStyleBackColor = True
        '
        'gbxFilesToSkip
        '
        Me.gbxFilesToSkip.BackColor = System.Drawing.Color.Transparent
        Me.gbxFilesToSkip.Controls.Add(Me.lblTotalItems)
        Me.gbxFilesToSkip.Controls.Add(Me.btnRemoveItem)
        Me.gbxFilesToSkip.Controls.Add(Me.btnRemoveAllItems)
        Me.gbxFilesToSkip.Controls.Add(Me.lbxFilesToSkip)
        Me.gbxFilesToSkip.Controls.Add(Me.btnAdd)
        Me.gbxFilesToSkip.Controls.Add(Me.txtExtNameSkip)
        Me.gbxFilesToSkip.Controls.Add(Me.lblExtNameSkip)
        Me.gbxFilesToSkip.Location = New System.Drawing.Point(10, 75)
        Me.gbxFilesToSkip.Name = "gbxFilesToSkip"
        Me.gbxFilesToSkip.Size = New System.Drawing.Size(240, 140)
        Me.gbxFilesToSkip.TabIndex = 7
        Me.gbxFilesToSkip.TabStop = False
        Me.gbxFilesToSkip.Text = "Files to skip"
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Location = New System.Drawing.Point(130, 53)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(74, 13)
        Me.lblTotalItems.TabIndex = 9
        Me.lblTotalItems.Text = "Total Items : 3"
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Enabled = False
        Me.btnRemoveItem.Location = New System.Drawing.Point(130, 75)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(101, 23)
        Me.btnRemoveItem.TabIndex = 5
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'btnRemoveAllItems
        '
        Me.btnRemoveAllItems.Location = New System.Drawing.Point(130, 104)
        Me.btnRemoveAllItems.Name = "btnRemoveAllItems"
        Me.btnRemoveAllItems.Size = New System.Drawing.Size(101, 23)
        Me.btnRemoveAllItems.TabIndex = 6
        Me.btnRemoveAllItems.Text = "Remove All Items"
        Me.btnRemoveAllItems.UseVisualStyleBackColor = True
        '
        'lbxFilesToSkip
        '
        Me.lbxFilesToSkip.FormattingEnabled = True
        Me.lbxFilesToSkip.Items.AddRange(New Object() {"sys", "ini", "dll"})
        Me.lbxFilesToSkip.Location = New System.Drawing.Point(9, 45)
        Me.lbxFilesToSkip.Name = "lbxFilesToSkip"
        Me.lbxFilesToSkip.ScrollAlwaysVisible = True
        Me.lbxFilesToSkip.Size = New System.Drawing.Size(115, 82)
        Me.lbxFilesToSkip.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(191, 17)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(40, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtExtNameSkip
        '
        Me.txtExtNameSkip.Location = New System.Drawing.Point(126, 19)
        Me.txtExtNameSkip.Name = "txtExtNameSkip"
        Me.txtExtNameSkip.Size = New System.Drawing.Size(59, 20)
        Me.txtExtNameSkip.TabIndex = 3
        '
        'lblExtNameSkip
        '
        Me.lblExtNameSkip.AutoSize = True
        Me.lblExtNameSkip.Location = New System.Drawing.Point(6, 22)
        Me.lblExtNameSkip.Name = "lblExtNameSkip"
        Me.lblExtNameSkip.Size = New System.Drawing.Size(118, 13)
        Me.lblExtNameSkip.TabIndex = 8
        Me.lblExtNameSkip.Text = "Enter a extension name"
        '
        'gbxGeneralOptions
        '
        Me.gbxGeneralOptions.BackColor = System.Drawing.Color.Transparent
        Me.gbxGeneralOptions.Controls.Add(Me.txtExtName)
        Me.gbxGeneralOptions.Controls.Add(Me.chkJustAppendExtName)
        Me.gbxGeneralOptions.Controls.Add(Me.lblExtName)
        Me.gbxGeneralOptions.Location = New System.Drawing.Point(9, 4)
        Me.gbxGeneralOptions.Name = "gbxGeneralOptions"
        Me.gbxGeneralOptions.Size = New System.Drawing.Size(240, 65)
        Me.gbxGeneralOptions.TabIndex = 8
        Me.gbxGeneralOptions.TabStop = False
        Me.gbxGeneralOptions.Text = "General Options"
        '
        'txtExtName
        '
        Me.txtExtName.Location = New System.Drawing.Point(129, 16)
        Me.txtExtName.Name = "txtExtName"
        Me.txtExtName.Size = New System.Drawing.Size(77, 20)
        Me.txtExtName.TabIndex = 1
        '
        'lblExtName
        '
        Me.lblExtName.AutoSize = True
        Me.lblExtName.Location = New System.Drawing.Point(7, 19)
        Me.lblExtName.Name = "lblExtName"
        Me.lblExtName.Size = New System.Drawing.Size(121, 13)
        Me.lblExtName.TabIndex = 9
        Me.lblExtName.Text = "Enter a extension name "
        '
        'frmChangeExtension
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(260, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxGeneralOptions)
        Me.Controls.Add(Me.gbxFilesToSkip)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmChangeExtension"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Extension"
        Me.gbxFilesToSkip.ResumeLayout(False)
        Me.gbxFilesToSkip.PerformLayout()
        Me.gbxGeneralOptions.ResumeLayout(False)
        Me.gbxGeneralOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkJustAppendExtName As CheckBox
    Friend WithEvents gbxFilesToSkip As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtExtNameSkip As TextBox
    Friend WithEvents lblExtNameSkip As Label
    Friend WithEvents gbxGeneralOptions As GroupBox
    Friend WithEvents txtExtName As TextBox
    Friend WithEvents lblExtName As Label
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnRemoveAllItems As Button
    Friend WithEvents lbxFilesToSkip As ListBox
End Class
