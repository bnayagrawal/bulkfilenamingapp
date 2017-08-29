<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListViewOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListViewOptions))
        Me.gbxItemsToSkip = New System.Windows.Forms.GroupBox()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.chkSortItems = New System.Windows.Forms.CheckBox()
        Me.btnDeleteSelectedItem = New System.Windows.Forms.Button()
        Me.btnRemoveAllItems = New System.Windows.Forms.Button()
        Me.lbxFilesToSkip = New System.Windows.Forms.ListBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtExtName = New System.Windows.Forms.TextBox()
        Me.lblExtName = New System.Windows.Forms.Label()
        Me.gbxGeneralOptions = New System.Windows.Forms.GroupBox()
        Me.chkAllowSorting = New System.Windows.Forms.CheckBox()
        Me.chkAllowAdding = New System.Windows.Forms.CheckBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbxItemsToSkip.SuspendLayout()
        Me.gbxGeneralOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxItemsToSkip
        '
        Me.gbxItemsToSkip.BackColor = System.Drawing.Color.Transparent
        Me.gbxItemsToSkip.Controls.Add(Me.lblTotalItems)
        Me.gbxItemsToSkip.Controls.Add(Me.chkSortItems)
        Me.gbxItemsToSkip.Controls.Add(Me.btnDeleteSelectedItem)
        Me.gbxItemsToSkip.Controls.Add(Me.btnRemoveAllItems)
        Me.gbxItemsToSkip.Controls.Add(Me.lbxFilesToSkip)
        Me.gbxItemsToSkip.Controls.Add(Me.lblDescription)
        Me.gbxItemsToSkip.Controls.Add(Me.btnAdd)
        Me.gbxItemsToSkip.Controls.Add(Me.txtExtName)
        Me.gbxItemsToSkip.Controls.Add(Me.lblExtName)
        Me.gbxItemsToSkip.Location = New System.Drawing.Point(8, 8)
        Me.gbxItemsToSkip.Name = "gbxItemsToSkip"
        Me.gbxItemsToSkip.Size = New System.Drawing.Size(270, 166)
        Me.gbxItemsToSkip.TabIndex = 0
        Me.gbxItemsToSkip.TabStop = False
        Me.gbxItemsToSkip.Text = "Items to skip"
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Location = New System.Drawing.Point(125, 62)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(80, 13)
        Me.lblTotalItems.TabIndex = 4
        Me.lblTotalItems.Text = "Total Item(s) : 0"
        '
        'chkSortItems
        '
        Me.chkSortItems.AutoSize = True
        Me.chkSortItems.Location = New System.Drawing.Point(128, 82)
        Me.chkSortItems.Name = "chkSortItems"
        Me.chkSortItems.Size = New System.Drawing.Size(79, 17)
        Me.chkSortItems.TabIndex = 4
        Me.chkSortItems.Text = "Sort Item(s)"
        Me.chkSortItems.UseVisualStyleBackColor = True
        '
        'btnDeleteSelectedItem
        '
        Me.btnDeleteSelectedItem.Enabled = False
        Me.btnDeleteSelectedItem.Location = New System.Drawing.Point(128, 105)
        Me.btnDeleteSelectedItem.Name = "btnDeleteSelectedItem"
        Me.btnDeleteSelectedItem.Size = New System.Drawing.Size(128, 23)
        Me.btnDeleteSelectedItem.TabIndex = 5
        Me.btnDeleteSelectedItem.Text = "Delete selected item"
        Me.btnDeleteSelectedItem.UseVisualStyleBackColor = True
        '
        'btnRemoveAllItems
        '
        Me.btnRemoveAllItems.Location = New System.Drawing.Point(128, 134)
        Me.btnRemoveAllItems.Name = "btnRemoveAllItems"
        Me.btnRemoveAllItems.Size = New System.Drawing.Size(128, 23)
        Me.btnRemoveAllItems.TabIndex = 4
        Me.btnRemoveAllItems.Text = "Remove all item(s)"
        Me.btnRemoveAllItems.UseVisualStyleBackColor = True
        '
        'lbxFilesToSkip
        '
        Me.lbxFilesToSkip.FormattingEnabled = True
        Me.lbxFilesToSkip.Location = New System.Drawing.Point(9, 62)
        Me.lbxFilesToSkip.Name = "lbxFilesToSkip"
        Me.lbxFilesToSkip.ScrollAlwaysVisible = True
        Me.lbxFilesToSkip.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxFilesToSkip.Size = New System.Drawing.Size(109, 95)
        Me.lbxFilesToSkip.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(5, 43)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(260, 13)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Files having any of these extensions will not be added"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(211, 16)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(45, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtExtName
        '
        Me.txtExtName.Location = New System.Drawing.Point(122, 18)
        Me.txtExtName.Name = "txtExtName"
        Me.txtExtName.Size = New System.Drawing.Size(81, 20)
        Me.txtExtName.TabIndex = 1
        '
        'lblExtName
        '
        Me.lblExtName.AutoSize = True
        Me.lblExtName.Location = New System.Drawing.Point(6, 21)
        Me.lblExtName.Name = "lblExtName"
        Me.lblExtName.Size = New System.Drawing.Size(112, 13)
        Me.lblExtName.TabIndex = 1
        Me.lblExtName.Text = "Enter Extension Name"
        '
        'gbxGeneralOptions
        '
        Me.gbxGeneralOptions.BackColor = System.Drawing.Color.Transparent
        Me.gbxGeneralOptions.Controls.Add(Me.chkAllowSorting)
        Me.gbxGeneralOptions.Controls.Add(Me.chkAllowAdding)
        Me.gbxGeneralOptions.Location = New System.Drawing.Point(8, 180)
        Me.gbxGeneralOptions.Name = "gbxGeneralOptions"
        Me.gbxGeneralOptions.Size = New System.Drawing.Size(270, 70)
        Me.gbxGeneralOptions.TabIndex = 1
        Me.gbxGeneralOptions.TabStop = False
        Me.gbxGeneralOptions.Text = "General Options"
        '
        'chkAllowSorting
        '
        Me.chkAllowSorting.AutoSize = True
        Me.chkAllowSorting.Location = New System.Drawing.Point(9, 44)
        Me.chkAllowSorting.Name = "chkAllowSorting"
        Me.chkAllowSorting.Size = New System.Drawing.Size(130, 17)
        Me.chkAllowSorting.TabIndex = 2
        Me.chkAllowSorting.Text = "Allow sorting of item(s)"
        Me.chkAllowSorting.UseVisualStyleBackColor = True
        '
        'chkAllowAdding
        '
        Me.chkAllowAdding.AutoSize = True
        Me.chkAllowAdding.Location = New System.Drawing.Point(9, 21)
        Me.chkAllowAdding.Name = "chkAllowAdding"
        Me.chkAllowAdding.Size = New System.Drawing.Size(216, 17)
        Me.chkAllowAdding.TabIndex = 2
        Me.chkAllowAdding.Text = "Allow adding files from different locations"
        Me.chkAllowAdding.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(203, 256)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "&Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(122, 256)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmListViewOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(287, 286)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.gbxGeneralOptions)
        Me.Controls.Add(Me.gbxItemsToSkip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmListViewOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "List View Options"
        Me.gbxItemsToSkip.ResumeLayout(False)
        Me.gbxItemsToSkip.PerformLayout()
        Me.gbxGeneralOptions.ResumeLayout(False)
        Me.gbxGeneralOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxItemsToSkip As GroupBox
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents chkSortItems As CheckBox
    Friend WithEvents btnDeleteSelectedItem As Button
    Friend WithEvents btnRemoveAllItems As Button
    Friend WithEvents lbxFilesToSkip As ListBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtExtName As TextBox
    Friend WithEvents lblExtName As Label
    Friend WithEvents gbxGeneralOptions As GroupBox
    Friend WithEvents chkAllowSorting As CheckBox
    Friend WithEvents chkAllowAdding As CheckBox
    Friend WithEvents btnApply As Button
    Friend WithEvents btnClose As Button
End Class
