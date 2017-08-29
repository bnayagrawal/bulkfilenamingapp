<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRename
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRename))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStringToAppend = New System.Windows.Forms.TextBox()
        Me.rbtnBefore = New System.Windows.Forms.RadioButton()
        Me.rbtnAfter = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.txtReplaceWith = New System.Windows.Forms.TextBox()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStringToRemove = New System.Windows.Forms.TextBox()
        Me.btnRemoveText = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStringToInsert = New System.Windows.Forms.TextBox()
        Me.rbtnBeforeString = New System.Windows.Forms.RadioButton()
        Me.rbtnAfterString = New System.Windows.Forms.RadioButton()
        Me.rbtnPosition = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.lblInsertAtPosition = New System.Windows.Forms.Label()
        Me.nudInsertAtPos = New System.Windows.Forms.NumericUpDown()
        Me.btnInsertText = New System.Windows.Forms.Button()
        Me.rbtnUpperCase = New System.Windows.Forms.RadioButton()
        Me.rbtnLowerCase = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudNumberStartFrom = New System.Windows.Forms.NumericUpDown()
        Me.rbtnAfterName = New System.Windows.Forms.RadioButton()
        Me.rbtnBeforeName = New System.Windows.Forms.RadioButton()
        Me.rbtnOnlyKeep = New System.Windows.Forms.RadioButton()
        Me.rbtnAtPosition = New System.Windows.Forms.RadioButton()
        Me.lblAtPosition = New System.Windows.Forms.Label()
        Me.nudAtPosition = New System.Windows.Forms.NumericUpDown()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.rbtnCapitalize = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nudRemoveCharacter = New System.Windows.Forms.NumericUpDown()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.rbtnFromEnd = New System.Windows.Forms.RadioButton()
        Me.rbtnFromBegening = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.nudInsertAtPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberStartFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAtPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudRemoveCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a string"
        '
        'txtStringToAppend
        '
        Me.txtStringToAppend.Location = New System.Drawing.Point(84, 23)
        Me.txtStringToAppend.Name = "txtStringToAppend"
        Me.txtStringToAppend.Size = New System.Drawing.Size(170, 20)
        Me.txtStringToAppend.TabIndex = 2
        '
        'rbtnBefore
        '
        Me.rbtnBefore.AutoSize = True
        Me.rbtnBefore.Checked = True
        Me.rbtnBefore.Location = New System.Drawing.Point(12, 49)
        Me.rbtnBefore.Name = "rbtnBefore"
        Me.rbtnBefore.Size = New System.Drawing.Size(142, 17)
        Me.rbtnBefore.TabIndex = 3
        Me.rbtnBefore.TabStop = True
        Me.rbtnBefore.Text = "Append before file Name"
        Me.rbtnBefore.UseVisualStyleBackColor = True
        '
        'rbtnAfter
        '
        Me.rbtnAfter.AutoSize = True
        Me.rbtnAfter.Location = New System.Drawing.Point(12, 72)
        Me.rbtnAfter.Name = "rbtnAfter"
        Me.rbtnAfter.Size = New System.Drawing.Size(131, 17)
        Me.rbtnAfter.TabIndex = 4
        Me.rbtnAfter.Text = "Append after file name"
        Me.rbtnAfter.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Find"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Replace with"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(41, 17)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(66, 20)
        Me.txtFind.TabIndex = 2
        '
        'txtReplaceWith
        '
        Me.txtReplaceWith.Location = New System.Drawing.Point(181, 17)
        Me.txtReplaceWith.Name = "txtReplaceWith"
        Me.txtReplaceWith.Size = New System.Drawing.Size(74, 20)
        Me.txtReplaceWith.TabIndex = 3
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(180, 43)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 2
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "String to remove"
        '
        'txtStringToRemove
        '
        Me.txtStringToRemove.Location = New System.Drawing.Point(100, 20)
        Me.txtStringToRemove.Name = "txtStringToRemove"
        Me.txtStringToRemove.Size = New System.Drawing.Size(92, 20)
        Me.txtStringToRemove.TabIndex = 3
        '
        'btnRemoveText
        '
        Me.btnRemoveText.Location = New System.Drawing.Point(198, 18)
        Me.btnRemoveText.Name = "btnRemoveText"
        Me.btnRemoveText.Size = New System.Drawing.Size(57, 23)
        Me.btnRemoveText.TabIndex = 3
        Me.btnRemoveText.Text = "Remove"
        Me.btnRemoveText.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Enter text to insert"
        '
        'txtStringToInsert
        '
        Me.txtStringToInsert.Location = New System.Drawing.Point(107, 13)
        Me.txtStringToInsert.Name = "txtStringToInsert"
        Me.txtStringToInsert.Size = New System.Drawing.Size(147, 20)
        Me.txtStringToInsert.TabIndex = 4
        '
        'rbtnBeforeString
        '
        Me.rbtnBeforeString.AutoSize = True
        Me.rbtnBeforeString.Checked = True
        Me.rbtnBeforeString.Location = New System.Drawing.Point(14, 38)
        Me.rbtnBeforeString.Name = "rbtnBeforeString"
        Me.rbtnBeforeString.Size = New System.Drawing.Size(93, 17)
        Me.rbtnBeforeString.TabIndex = 4
        Me.rbtnBeforeString.TabStop = True
        Me.rbtnBeforeString.Text = "Before a string"
        Me.rbtnBeforeString.UseVisualStyleBackColor = True
        '
        'rbtnAfterString
        '
        Me.rbtnAfterString.AutoSize = True
        Me.rbtnAfterString.Location = New System.Drawing.Point(113, 38)
        Me.rbtnAfterString.Name = "rbtnAfterString"
        Me.rbtnAfterString.Size = New System.Drawing.Size(84, 17)
        Me.rbtnAfterString.TabIndex = 4
        Me.rbtnAfterString.Text = "After a string"
        Me.rbtnAfterString.UseVisualStyleBackColor = True
        '
        'rbtnPosition
        '
        Me.rbtnPosition.AutoSize = True
        Me.rbtnPosition.Location = New System.Drawing.Point(14, 86)
        Me.rbtnPosition.Name = "rbtnPosition"
        Me.rbtnPosition.Size = New System.Drawing.Size(83, 17)
        Me.rbtnPosition.TabIndex = 4
        Me.rbtnPosition.Text = "At a position"
        Me.rbtnPosition.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Enter the string"
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(107, 60)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(147, 20)
        Me.txtString.TabIndex = 4
        '
        'lblInsertAtPosition
        '
        Me.lblInsertAtPosition.AutoSize = True
        Me.lblInsertAtPosition.Enabled = False
        Me.lblInsertAtPosition.Location = New System.Drawing.Point(104, 88)
        Me.lblInsertAtPosition.Name = "lblInsertAtPosition"
        Me.lblInsertAtPosition.Size = New System.Drawing.Size(57, 13)
        Me.lblInsertAtPosition.TabIndex = 4
        Me.lblInsertAtPosition.Text = "At Position"
        '
        'nudInsertAtPos
        '
        Me.nudInsertAtPos.Enabled = False
        Me.nudInsertAtPos.Location = New System.Drawing.Point(167, 86)
        Me.nudInsertAtPos.Name = "nudInsertAtPos"
        Me.nudInsertAtPos.Size = New System.Drawing.Size(87, 20)
        Me.nudInsertAtPos.TabIndex = 6
        '
        'btnInsertText
        '
        Me.btnInsertText.Location = New System.Drawing.Point(179, 113)
        Me.btnInsertText.Name = "btnInsertText"
        Me.btnInsertText.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertText.TabIndex = 7
        Me.btnInsertText.Text = "Insert text"
        Me.btnInsertText.UseVisualStyleBackColor = True
        '
        'rbtnUpperCase
        '
        Me.rbtnUpperCase.AutoSize = True
        Me.rbtnUpperCase.Checked = True
        Me.rbtnUpperCase.Location = New System.Drawing.Point(11, 16)
        Me.rbtnUpperCase.Name = "rbtnUpperCase"
        Me.rbtnUpperCase.Size = New System.Drawing.Size(81, 17)
        Me.rbtnUpperCase.TabIndex = 0
        Me.rbtnUpperCase.TabStop = True
        Me.rbtnUpperCase.Text = "Upper Case"
        Me.rbtnUpperCase.UseVisualStyleBackColor = True
        '
        'rbtnLowerCase
        '
        Me.rbtnLowerCase.AutoSize = True
        Me.rbtnLowerCase.Location = New System.Drawing.Point(100, 16)
        Me.rbtnLowerCase.Name = "rbtnLowerCase"
        Me.rbtnLowerCase.Size = New System.Drawing.Size(81, 17)
        Me.rbtnLowerCase.TabIndex = 5
        Me.rbtnLowerCase.Text = "Lower Case"
        Me.rbtnLowerCase.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(178, 36)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Format text"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Number start from"
        '
        'nudNumberStartFrom
        '
        Me.nudNumberStartFrom.Location = New System.Drawing.Point(109, 17)
        Me.nudNumberStartFrom.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudNumberStartFrom.Name = "nudNumberStartFrom"
        Me.nudNumberStartFrom.Size = New System.Drawing.Size(53, 20)
        Me.nudNumberStartFrom.TabIndex = 7
        '
        'rbtnAfterName
        '
        Me.rbtnAfterName.AutoSize = True
        Me.rbtnAfterName.Location = New System.Drawing.Point(11, 42)
        Me.rbtnAfterName.Name = "rbtnAfterName"
        Me.rbtnAfterName.Size = New System.Drawing.Size(142, 17)
        Me.rbtnAfterName.TabIndex = 6
        Me.rbtnAfterName.Text = "Append before file Name"
        Me.rbtnAfterName.UseVisualStyleBackColor = True
        '
        'rbtnBeforeName
        '
        Me.rbtnBeforeName.AutoSize = True
        Me.rbtnBeforeName.Location = New System.Drawing.Point(11, 65)
        Me.rbtnBeforeName.Name = "rbtnBeforeName"
        Me.rbtnBeforeName.Size = New System.Drawing.Size(131, 17)
        Me.rbtnBeforeName.TabIndex = 6
        Me.rbtnBeforeName.Text = "Append after file name"
        Me.rbtnBeforeName.UseVisualStyleBackColor = True
        '
        'rbtnOnlyKeep
        '
        Me.rbtnOnlyKeep.AutoSize = True
        Me.rbtnOnlyKeep.Checked = True
        Me.rbtnOnlyKeep.Location = New System.Drawing.Point(11, 88)
        Me.rbtnOnlyKeep.Name = "rbtnOnlyKeep"
        Me.rbtnOnlyKeep.Size = New System.Drawing.Size(111, 17)
        Me.rbtnOnlyKeep.TabIndex = 6
        Me.rbtnOnlyKeep.TabStop = True
        Me.rbtnOnlyKeep.Text = "Only keep number"
        Me.rbtnOnlyKeep.UseVisualStyleBackColor = True
        '
        'rbtnAtPosition
        '
        Me.rbtnAtPosition.AutoSize = True
        Me.rbtnAtPosition.Location = New System.Drawing.Point(11, 111)
        Me.rbtnAtPosition.Name = "rbtnAtPosition"
        Me.rbtnAtPosition.Size = New System.Drawing.Size(147, 17)
        Me.rbtnAtPosition.TabIndex = 8
        Me.rbtnAtPosition.Text = "Insert at specified position"
        Me.rbtnAtPosition.UseVisualStyleBackColor = True
        '
        'lblAtPosition
        '
        Me.lblAtPosition.AutoSize = True
        Me.lblAtPosition.Enabled = False
        Me.lblAtPosition.Location = New System.Drawing.Point(10, 136)
        Me.lblAtPosition.Name = "lblAtPosition"
        Me.lblAtPosition.Size = New System.Drawing.Size(56, 13)
        Me.lblAtPosition.TabIndex = 6
        Me.lblAtPosition.Text = "At position"
        '
        'nudAtPosition
        '
        Me.nudAtPosition.Enabled = False
        Me.nudAtPosition.Location = New System.Drawing.Point(72, 134)
        Me.nudAtPosition.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudAtPosition.Name = "nudAtPosition"
        Me.nudAtPosition.Size = New System.Drawing.Size(92, 20)
        Me.nudAtPosition.TabIndex = 9
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(89, 163)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Start"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(11, 25)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(242, 37)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Rename File with randomly generated string"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'rbtnCapitalize
        '
        Me.rbtnCapitalize.AutoSize = True
        Me.rbtnCapitalize.Location = New System.Drawing.Point(185, 16)
        Me.rbtnCapitalize.Name = "rbtnCapitalize"
        Me.rbtnCapitalize.Size = New System.Drawing.Size(70, 17)
        Me.rbtnCapitalize.TabIndex = 7
        Me.rbtnCapitalize.Text = "Capitalize"
        Me.rbtnCapitalize.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(8, 9)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(291, 423)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 7
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(283, 397)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Customize File Name"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbtnUpperCase)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.rbtnLowerCase)
        Me.GroupBox4.Controls.Add(Me.rbtnCapitalize)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 326)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(267, 67)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Format Case"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtReplaceWith)
        Me.GroupBox3.Controls.Add(Me.btnReplace)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtFind)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 251)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 74)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Replace Text"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nudRemoveCharacter)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.rbtnFromEnd)
        Me.GroupBox2.Controls.Add(Me.rbtnFromBegening)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnRemoveText)
        Me.GroupBox2.Controls.Add(Me.txtStringToRemove)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 104)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Remove Text"
        '
        'nudRemoveCharacter
        '
        Me.nudRemoveCharacter.Location = New System.Drawing.Point(167, 47)
        Me.nudRemoveCharacter.Name = "nudRemoveCharacter"
        Me.nudRemoveCharacter.Size = New System.Drawing.Size(88, 20)
        Me.nudRemoveCharacter.TabIndex = 9
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(198, 73)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(57, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'rbtnFromEnd
        '
        Me.rbtnFromEnd.AutoSize = True
        Me.rbtnFromEnd.Location = New System.Drawing.Point(113, 76)
        Me.rbtnFromEnd.Name = "rbtnFromEnd"
        Me.rbtnFromEnd.Size = New System.Drawing.Size(69, 17)
        Me.rbtnFromEnd.TabIndex = 10
        Me.rbtnFromEnd.Text = "From end"
        Me.rbtnFromEnd.UseVisualStyleBackColor = True
        '
        'rbtnFromBegening
        '
        Me.rbtnFromBegening.AutoSize = True
        Me.rbtnFromBegening.Checked = True
        Me.rbtnFromBegening.Location = New System.Drawing.Point(11, 75)
        Me.rbtnFromBegening.Name = "rbtnFromBegening"
        Me.rbtnFromBegening.Size = New System.Drawing.Size(91, 17)
        Me.rbtnFromBegening.TabIndex = 9
        Me.rbtnFromBegening.TabStop = True
        Me.rbtnFromBegening.Text = "From begining"
        Me.rbtnFromBegening.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Remove 'n' no. of characters"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rbtnPosition)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnInsertText)
        Me.GroupBox1.Controls.Add(Me.rbtnAfterString)
        Me.GroupBox1.Controls.Add(Me.txtString)
        Me.GroupBox1.Controls.Add(Me.rbtnBeforeString)
        Me.GroupBox1.Controls.Add(Me.lblInsertAtPosition)
        Me.GroupBox1.Controls.Add(Me.txtStringToInsert)
        Me.GroupBox1.Controls.Add(Me.nudInsertAtPos)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 143)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insert Text"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox7)
        Me.TabPage6.Controls.Add(Me.GroupBox6)
        Me.TabPage6.Controls.Add(Me.GroupBox5)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(283, 397)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Rename Files"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button7)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 311)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(267, 78)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Randomize"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.txtStringToAppend)
        Me.GroupBox6.Controls.Add(Me.rbtnBefore)
        Me.GroupBox6.Controls.Add(Me.rbtnAfter)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 201)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(267, 107)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Append/Prepend text"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.rbtnOnlyKeep)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.rbtnBeforeName)
        Me.GroupBox5.Controls.Add(Me.rbtnAtPosition)
        Me.GroupBox5.Controls.Add(Me.nudNumberStartFrom)
        Me.GroupBox5.Controls.Add(Me.rbtnAfterName)
        Me.GroupBox5.Controls.Add(Me.lblAtPosition)
        Me.GroupBox5.Controls.Add(Me.nudAtPosition)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(267, 193)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Auto-number"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(224, 438)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "&Close"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'frmRename
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(306, 466)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRename"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rename File(s)"
        CType(Me.nudInsertAtPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberStartFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAtPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudRemoveCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents rbtnAfter As RadioButton
    Friend WithEvents rbtnBefore As RadioButton
    Friend WithEvents txtStringToAppend As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReplace As Button
    Friend WithEvents txtReplaceWith As TextBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemoveText As Button
    Friend WithEvents txtStringToRemove As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnInsertText As Button
    Friend WithEvents nudInsertAtPos As NumericUpDown
    Friend WithEvents lblInsertAtPosition As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rbtnPosition As RadioButton
    Friend WithEvents rbtnAfterString As RadioButton
    Friend WithEvents rbtnBeforeString As RadioButton
    Friend WithEvents txtStringToInsert As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rbtnCapitalize As RadioButton
    Friend WithEvents Button5 As Button
    Friend WithEvents rbtnLowerCase As RadioButton
    Friend WithEvents rbtnUpperCase As RadioButton
    Friend WithEvents Button6 As Button
    Friend WithEvents nudAtPosition As NumericUpDown
    Friend WithEvents lblAtPosition As Label
    Friend WithEvents rbtnAtPosition As RadioButton
    Friend WithEvents rbtnOnlyKeep As RadioButton
    Friend WithEvents rbtnBeforeName As RadioButton
    Friend WithEvents rbtnAfterName As RadioButton
    Friend WithEvents nudNumberStartFrom As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Button8 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents nudRemoveCharacter As NumericUpDown
    Friend WithEvents btnDelete As Button
    Friend WithEvents rbtnFromEnd As RadioButton
    Friend WithEvents rbtnFromBegening As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txtString As TextBox
End Class
