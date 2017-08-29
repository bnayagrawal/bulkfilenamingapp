Imports System.ComponentModel

Public Class frmMain
    Public lvItemsToSkip() As String
    Public allowSort As Boolean
    Public allowFileFromDifLoc As Boolean
    Public Items = frmUndo.lvwFiles.Items
    Public fileInfo As IO.FileInfo
    Public currentWorkingDir() As String
    Public viewRibonColor As Boolean
    Public colorCode As Integer
    Public ribonColor As Color

    Public totalFilesExtRemoved As Integer
    Public totalFilesRenamed As Integer
    Public totalFilesExtChanged As Integer
    Public programUsed As Integer
    Public programLastUsed As Date
    Public lastUsedFolder() As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dirList(Environment.GetCommandLineArgs.Length) As String
        Dim inc As Integer = 0
        Me.Text = "Easy File Namer v" & My.Application.Info.Version.ToString()
        Try
            If Environment.GetCommandLineArgs.Length >= 2 Then
                For Each arg In Environment.GetCommandLineArgs
                    If IO.Directory.Exists(arg) Then
                        dirList(inc) = arg
                        inc += 1
                    End If
                Next

                If dirList.Length > 0 Then
                    addFolderItems(dirList)
                End If
            End If
        Catch
        End Try

        'Load last saved settings
        totalFilesExtChanged = My.Settings.totalFilesExtChanged
        totalFilesExtRemoved = My.Settings.totalFilesExtRemoved
        totalFilesRenamed = My.Settings.totalFilesRenamed
        programLastUsed = My.Settings.programLastUsed
        programUsed = My.Settings.programUsed + 1
        ribonColor = My.Settings.ribonColor
        colorCode = My.Settings.colorCode
        setTheme(colorCode)

        allowSort = My.Settings.allowSort
        allowFileFromDifLoc = My.Settings.allowFileFromDifLoc

        If My.Settings.lvItemsToSkip IsNot Nothing Then
            Dim i As Integer = 0
            ReDim lvItemsToSkip(My.Settings.lvItemsToSkip.Count - 1)
            For Each item In My.Settings.lvItemsToSkip
                lvItemsToSkip(i) = item
                i += 1
            Next
        Else
            lvItemsToSkip = Nothing
        End If

        If lvItemsToSkip IsNot Nothing Then
            For Each item In lvItemsToSkip
                txtExcludeList.AppendText(Chr(34) & item & Chr(34) & " ")
            Next
        Else
            txtExcludeList.Clear()
        End If

        If My.Settings.lastUsedFolder IsNot Nothing Then
            Dim i As Integer = 0
            ReDim lastUsedFolder(My.Settings.lastUsedFolder.Count - 1)
            For Each item In My.Settings.lastUsedFolder
                lastUsedFolder(i) = item
                i += 1
            Next
        End If
    End Sub

    Private Sub btnBrowseFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        If IO.Directory.Exists(FolderBrowserDialog1.SelectedPath) Then
            ReDim currentWorkingDir(1)
            currentWorkingDir(0) = FolderBrowserDialog1.SelectedPath
            tsslblFilesSelected.Text = ""
            txtSelectedFiles.Text = ""
            txtFileType.Text = ""
            txtFileLoc.Text = ""
            addFolderItems(currentWorkingDir)
        End If
    End Sub

    Private Sub lvwFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwFiles.SelectedIndexChanged
        tsslblFilesSelected.Text = lvwFiles.SelectedItems.Count
        If lvwFiles.SelectedIndices.Count = 1 Then
            cbxSelect.SelectedIndex = 1
            btnFileProp.Enabled = True
            btnOpenContFolder.Enabled = True
            btnOpenFile.Enabled = True
            txtSelectedFiles.Text = lvwFiles.SelectedItems(0).SubItems(1).Text
            txtFileType.Text = lvwFiles.SelectedItems(0).SubItems(2).Text
            txtFileSize.Text = lvwFiles.SelectedItems(0).SubItems(3).Text
            txtFileLoc.Text = lvwFiles.SelectedItems(0).SubItems(4).Text
        ElseIf lvwFiles.SelectedIndices.Count > 1 Then
            cbxSelect.SelectedIndex = 1
            btnFileProp.Enabled = False
            btnOpenFile.Enabled = False
            btnOpenContFolder.Enabled = False
            txtSelectedFiles.Text = ""
            txtFileType.Text = ""
            txtFileSize.Text = ""
            txtFileLoc.Text = ""
        Else
            cbxSelect.SelectedIndex = 0
            btnFileProp.Enabled = False
            btnOpenFile.Enabled = False
            btnOpenContFolder.Enabled = False
            txtSelectedFiles.Text = ""
            txtFileSize.Text = ""
            txtFileType.Text = ""
            txtFileLoc.Text = ""
        End If
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        If txtFileLoc.Text <> "" Then
            Try
                Process.Start(txtFileLoc.Text)
            Catch x As System.ComponentModel.Win32Exception
                MsgBox("No application is associated with the specified file extension to open the file", vbOKOnly + vbCritical)
            End Try
        Else
            MsgBox("No file has been selected !", vbOKOnly + vbExclamation)
        End If
    End Sub

    Private Sub btnRemoveExt_Click(sender As Object, e As EventArgs) Handles btnRemoveExt.Click
        If cbxValidate() = 1 Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim selectedItemCount As Integer = lvwFiles.SelectedIndices.Count
        Dim selectedItems As ListView.SelectedListViewItemCollection = lvwFiles.SelectedItems
        Dim oldFileName As String
        Dim newFileName As String
        Dim opcount As Integer = 0
        Dim errorcount As Integer = 0
        Dim dotLoc As Integer
        Dim found As Boolean = False
        ToolStripProgressBar1.Value = 0
        If cbxSelect.SelectedIndex = 1 Then
            frmUndo.lvwFiles.Items.Clear()
            If frmRemoveExt.ShowDialog() = DialogResult.Cancel Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            ToolStripProgressBar1.Maximum = selectedItemCount
            For i As Integer = 0 To selectedItemCount - 1
                StatusStrip1.Refresh()
                oldFileName = selectedItems(i).SubItems(4).Text
                newFileName = selectedItems(i).SubItems(1).Text
                dotLoc = newFileName.LastIndexOf(".")
                If dotLoc < 0 Then
                    txtLog.AppendText("File : " + selectedItems(i).SubItems(1).Text + " has no extension [File Skipped]" + Environment.NewLine)
                    ToolStripProgressBar1.PerformStep()
                    Continue For
                End If

                If Not frmRemoveExt.removeAll Then
                    For Each skipItem In frmRemoveExt.itemsToSkip
                        If skipItem.ToLower = selectedItems(i).SubItems(2).Text.ToLower Then
                            txtLog.AppendText("SKIPING > File : " + selectedItems(i).SubItems(1).Text + " has extension [" + skipItem + "]" + Environment.NewLine)
                            ToolStripProgressBar1.PerformStep()
                            found = True
                        End If
                    Next
                    If found Then
                        found = False
                        Continue For
                    End If
                End If

                newFileName = newFileName.Substring(0, dotLoc)
                Try
                    ToolStripProgressBar1.PerformStep()
                    addUndoFileItems(oldFileName, newFileName) 'enables undo operation
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    txtLog.AppendText("Processing : " + selectedItems(i).SubItems(4).Text + Environment.NewLine)
                    opcount += 1
                Catch IOE As IO.IOException
                    txtLog.AppendText("Error : " + selectedItems(i).SubItems(1).Text + " [File Skipped] " + Environment.NewLine)
                    errorcount += 1
                Catch AE As System.UnauthorizedAccessException
                    txtLog.AppendText(Environment.NewLine + "ACCESS DENIED - ADMINISTRATIVE PRIVILEDGES REQUIRED" + Environment.NewLine)
                    errorcount += 1
                End Try
            Next
        ElseIf cbxSelect.SelectedIndex = 0 Then
            If frmRemoveExt.ShowDialog() = DialogResult.Cancel Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            If MsgBox("Remove extensions Of all files?", vbYesNo + vbExclamation) = MsgBoxResult.No Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Maximum = lvwFiles.Items.Count
            For i As Integer = 0 To lvwFiles.Items.Count - 1
                oldFileName = lvwFiles.Items(i).SubItems(4).Text
                newFileName = lvwFiles.Items(i).SubItems(1).Text
                dotLoc = newFileName.LastIndexOf(".")
                If dotLoc < 0 Then
                    txtLog.AppendText("File : " + lvwFiles.Items(i).SubItems(4).Text + " has no extension [File Skipped]" + Environment.NewLine)
                    ToolStripProgressBar1.PerformStep()
                    Continue For
                End If

                If Not frmRemoveExt.removeAll Then
                    For Each skipItem In frmRemoveExt.itemsToSkip
                        If skipItem.ToLower = lvwFiles.Items(i).SubItems(2).Text.ToLower Then
                            txtLog.AppendText("SKIPING > File : " + lvwFiles.Items(i).SubItems(1).Text + " has extension [" + skipItem + "]" + Environment.NewLine)
                            ToolStripProgressBar1.PerformStep()
                            found = True
                            Exit For
                        End If
                    Next
                    If found Then
                        found = False
                        Continue For
                    End If
                End If

                newFileName = newFileName.Substring(0, dotLoc)
                Try
                    ToolStripProgressBar1.PerformStep()
                    addUndoFileItems(oldFileName, newFileName) 'enables undo operation
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    txtLog.AppendText("Processing : " + lvwFiles.Items(i).SubItems(4).Text + Environment.NewLine)
                    opcount += 1
                Catch IOE As IO.IOException
                    errorcount += 1
                    txtLog.AppendText("Error : " + lvwFiles.Items(i).SubItems(1).Text + " [File Skipped] " + Environment.NewLine)
                Catch AE As System.UnauthorizedAccessException
                    errorcount += 1
                    txtLog.AppendText(Environment.NewLine + "ACCESS DENIED - ADMINISTRATIVE PRIVILEDGES REQUIRED" + Environment.NewLine)
                End Try
            Next
        Else
            MsgBox("Select an item first !", vbOKOnly + vbInformation)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        taskResult(opcount, errorcount)
        totalFilesExtRemoved += opcount
    End Sub

    Public Sub addFolderItems(ByVal dir() As String)
        lvwFiles.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Dim skip As Boolean = False
        Dim items As ListView.ListViewItemCollection
        items = lvwFiles.Items

        items.Clear()
        txtFolder.Clear()

        'for extracting file type description
        Dim Clskey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot
        Dim ExtKey As Microsoft.Win32.RegistryKey
        Dim Appkey2 As Microsoft.Win32.RegistryKey
        Dim AppDesc As String

        'file name and other info
        Dim fnames() As String
        Dim finfo As IO.FileInfo
        Dim fileExt As String
        Dim itemNumber As Integer
        Dim floc As Integer = 0
        Dim filesAdded As Integer = 0
        Dim filesSkipedCount As Integer = 0

        'different file sizes
        Dim bt As Integer
        Dim kb As Double
        Dim mb As Double
        Dim gb As Double

        ReDim currentWorkingDir(dir.Length)
        For Each directory In dir
            If Not IO.Directory.Exists(directory) Then
                Continue For
            End If

            fnames = IO.Directory.GetFiles(directory)
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = fnames.Length

            For Each file In fnames
                finfo = New IO.FileInfo(file)
                'to skip files having a specific extensions
                If finfo.Extension.Length > 0 Then
                    If lvItemsToSkip IsNot Nothing Then
                        For Each skipItem As String In lvItemsToSkip
                            If skipItem.ToLower = finfo.Extension.Substring(1).ToLower Then
                                skip = True
                                Exit For
                            End If
                        Next
                        If skip Then
                            skip = False
                            ToolStripProgressBar1.PerformStep()
                            filesSkipedCount += 1
                            Continue For
                        End If
                    End If
                End If

                items.Add(items.Count + 1.ToString)
                itemNumber = items.Count - 1
                items.Item(itemNumber).SubItems.Add(finfo.Name)
                If finfo.Extension.Length > 0 Then
                    fileExt = finfo.Extension.Substring(1)
                Else
                    fileExt = " "
                End If
                items.Item(itemNumber).SubItems.Add(fileExt)
                bt = finfo.Length
                If bt > 1024 Then
                    kb = bt / 1024
                    If kb > 1024 Then
                        mb = kb / 1024
                        If mb > 1024 Then
                            gb = mb / 1024
                            items.Item(itemNumber).SubItems.Add(Format(gb, "0.00") & " GB")
                        Else
                            items.Item(itemNumber).SubItems.Add(Format(mb, "0.00") & " MB")
                        End If
                    Else
                        items.Item(itemNumber).SubItems.Add(Format(kb, "0.00") & " KB")
                    End If
                Else
                    items.Item(itemNumber).SubItems.Add(bt.ToString & " bytes")
                End If
                'items.Item(itemNumber).SubItems.Add(CInt(finfo.Length / 1024) & " Kb")
                items.Item(itemNumber).SubItems.Add(file)
                items.Item(itemNumber).SubItems.Add(finfo.LastWriteTime.ToShortDateString)
                'extract file type description from registry
                ExtKey = Clskey.OpenSubKey(finfo.Extension, False)
                If ExtKey IsNot Nothing Then 'Occurs nullreff when extension not found
                    AppDesc = ExtKey.GetValue("", "")
                    Appkey2 = Clskey.OpenSubKey(AppDesc)
                    items.Item(itemNumber).SubItems.Add(Appkey2.GetValue("", ""))
                End If

                'Applies background color for items
                If itemNumber Mod 2 = 0 Then
                    If ViewRibbonColorToolStripMenuItem.Checked Then
                        items.Item(itemNumber).BackColor = ribonColor
                    End If
                End If

                ToolStripProgressBar1.PerformStep()
                filesAdded += 1
            Next
            txtFolder.Text = txtFolder.Text & Chr(34) & directory & Chr(34) & " "
            currentWorkingDir(floc) = directory
            floc += 1
            If Not cbxMultipleFolders.Checked Then
                Exit For
            End If
        Next

        tsslblTotalFiles.Text = filesAdded
        tsslblFilesExcluded.Text = "Files Excluded : " & filesSkipedCount
        ToolStripStatusLabel2.Text = "File(s) Added"
        lvwFiles.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnClearLog_Click(sender As Object, e As EventArgs)
        txtLog.Text = ""
    End Sub

    Private Sub btnChangeExt_Click(sender As Object, e As EventArgs) Handles btnChangeExt.Click
        If cbxValidate() = 1 Then
            Exit Sub
        End If

        Dim newFileName As String
        Dim oldFileName As String
        Dim newFileNameWithoutExtension As String
        Dim dotloc As Integer
        Dim opcount As Integer = 0
        Dim errorcount As Integer = 0
        Dim items As ListView.ListViewItemCollection
        Dim found As Boolean = False
        ToolStripProgressBar1.Value = 0

        Me.Cursor = Cursors.WaitCursor
        If cbxSelect.SelectedIndex = 0 Then
            frmUndo.lvwFiles.Items.Clear()
            frmChangeExtension.ShowDialog()
            If frmChangeExtension.isCanceled Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            ToolStripProgressBar1.Maximum = lvwFiles.Items.Count
            items = lvwFiles.Items
            ToolStripStatusLabel2.Text = "Changing file extensions..."
            For i As Integer = 0 To lvwFiles.Items.Count - 1
                oldFileName = items(i).SubItems(4).Text
                newFileName = items(i).SubItems(1).Text
                dotloc = items(i).SubItems(1).Text.LastIndexOf(".")
                If frmChangeExtension.appendExtension = False Then
                    If dotloc < 0 Then
                        newFileNameWithoutExtension = newFileName.Substring(0)
                        newFileName = newFileNameWithoutExtension + "." + frmChangeExtension.newExtention
                    Else
                        newFileNameWithoutExtension = newFileName.Substring(0, dotloc)
                        newFileName = items(i).SubItems(1).Text.Substring(0, dotloc) + "." + frmChangeExtension.newExtention
                    End If
                Else
                    newFileName = newFileName + "." + frmChangeExtension.newExtention
                End If
                Try
                    For Each skipItem In frmChangeExtension.itemsToSkip
                        If skipItem.ToLower = items(i).SubItems(2).Text.ToLower Then
                            txtLog.AppendText("SKIPING > File : " + items(i).SubItems(1).Text + " has extension [" + skipItem + "]" + Environment.NewLine)
                            ToolStripProgressBar1.PerformStep()
                            found = True
                            Exit For
                        End If
                    Next
                    If found Then
                        found = False
                        Continue For
                    End If

                    ToolStripProgressBar1.PerformStep()
                    addUndoFileItems(oldFileName, newFileName) 'Enables resotre operation
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    txtLog.AppendText("Processing : " + items(i).SubItems(4).Text + Environment.NewLine)
                    opcount += 1

                Catch ex As IO.IOException
                    errorcount += 1
                    txtLog.AppendText("Error : " + items(i).SubItems(1).Text + " [File Skipped] " + Environment.NewLine)
                Catch AE As System.UnauthorizedAccessException
                    errorcount += 1
                    txtLog.AppendText(Environment.NewLine + "ACCESS DENIED - ADMINISTRATIVE PRIVILEDGES REQUIRED" + Environment.NewLine)
                End Try
            Next
            taskResult(opcount, errorcount)
            totalFilesExtChanged += opcount
        ElseIf cbxSelect.SelectedIndex = 1 Then
            frmUndo.lvwFiles.Items.Clear()
            frmChangeExtension.ShowDialog()
            If frmChangeExtension.isCanceled Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            Dim sitems As ListView.SelectedListViewItemCollection
            sitems = lvwFiles.SelectedItems
            ToolStripProgressBar1.Maximum = sitems.Count
            ToolStripStatusLabel2.Text = "Changing file extensions..."
            For i As Integer = 0 To sitems.Count - 1
                oldFileName = sitems(i).SubItems(4).Text
                newFileName = sitems(i).SubItems(1).Text
                dotloc = sitems(i).SubItems(1).Text.LastIndexOf(".")
                If frmChangeExtension.appendExtension = False Then
                    If dotloc < 0 Then
                        newFileNameWithoutExtension = newFileName.Substring(0)
                        newFileName = newFileNameWithoutExtension + "." + frmChangeExtension.newExtention
                    Else
                        newFileNameWithoutExtension = newFileName.Substring(0, dotloc)
                        newFileName = sitems(i).SubItems(1).Text.Substring(0, dotloc) + "." + frmChangeExtension.newExtention
                    End If
                Else
                    newFileName = newFileName + "." + frmChangeExtension.newExtention
                End If
                Try
                    If sitems(i).SubItems(2).Text = frmChangeExtension.skipExtension Then
                        txtLog.AppendText("File Skipped [" + frmChangeExtension.skipExtension + "] : " + sitems(i).SubItems(1).Text + Environment.NewLine)
                        ToolStripProgressBar1.PerformStep()
                        Continue For
                    Else
                        ToolStripProgressBar1.PerformStep()
                        addUndoFileItems(oldFileName, newFileName) 'Enables resotre operation
                        FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                        txtLog.AppendText("Processing : " + sitems(i).SubItems(4).Text + Environment.NewLine)
                        opcount += 1
                    End If
                Catch ex As IO.IOException
                    errorcount += 1
                    txtLog.AppendText("Error : " + sitems(i).SubItems(1).Text + " [File Skipped] " + Environment.NewLine)
                Catch AE As System.UnauthorizedAccessException
                    errorcount += 1
                    txtLog.AppendText(Environment.NewLine + "ACCESS DENIED - ADMINISTRATIVE PRIVILEDGES REQUIRED" + Environment.NewLine)
                End Try
            Next
            taskResult(opcount, errorcount)
            totalFilesExtChanged += opcount
        Else
            MsgBox("Select an item first !", vbOKOnly + vbInformation)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnRenameFiles_Click(sender As Object, e As EventArgs) Handles btnRenameFiles.Click
        If cbxValidate() = 1 Then
            Exit Sub
        End If

        frmRename.ShowDialog()
        Exit Sub
    End Sub

    Private Sub lvwFiles_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvwFiles.ColumnClick
        If allowSort Then
            If e.Column = 0 Then
                If lvwFiles.Sorting = SortOrder.Ascending Then
                    lvwFiles.Sorting = SortOrder.Descending
                Else
                    lvwFiles.Sorting = SortOrder.Ascending
                End If
            End If
        End If
    End Sub

    Private Sub btnFileProp_Click(sender As Object, e As EventArgs) Handles btnFileProp.Click
        On Error GoTo ErrHandle
        Dim finobj As System.IO.FileInfo
        finobj = New IO.FileInfo(txtFileLoc.Text)
        Dim fileattr(12) As String
        fileattr(0) = "" '"Attributes : " & finobj.Attributes
        fileattr(1) = "CreationTime : " & finobj.CreationTime
        fileattr(2) = "Directory : " & finobj.Directory.ToString
        fileattr(3) = "Directory Name : " & finobj.DirectoryName
        fileattr(4) = "Exists : " & finobj.Exists.ToString
        fileattr(5) = "Extension : " & finobj.Extension
        fileattr(6) = "Full Name : " & finobj.FullName
        fileattr(7) = "Is ReadOnly : " & finobj.IsReadOnly.ToString
        fileattr(8) = "Last Access Time : " & finobj.LastAccessTime
        fileattr(9) = "Last Write Time : " & finobj.LastWriteTime
        fileattr(10) = "Lenght [bytes] : " & finobj.Length
        fileattr(11) = "Name : " & finobj.Name
        MsgBox(fileattr(0) + Chr(13) + fileattr(1) + Chr(13) + fileattr(2) + Chr(13) + fileattr(3) + Chr(13) + fileattr(4) + Chr(13) + fileattr(5) + Chr(13) + fileattr(6) + Chr(13) + fileattr(7) + Chr(13) + fileattr(8) + Chr(13) + fileattr(9) + Chr(13) + fileattr(10) + Chr(13) + fileattr(11) + Chr(13))
        Exit Sub
ErrHandle:
        MsgBox("Error Occured !", vbCritical)
    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        frmMore.ShowDialog()
    End Sub

    Private Sub frmMain_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub frmMain_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim srcDir() As String = e.Data.GetData(DataFormats.FileDrop)
        Dim dirlist(srcDir.Length) As String
        Dim inc As Integer = 0

        For Each directory In srcDir
            If IO.Directory.Exists(directory) Then
                dirlist(inc) = directory
                inc += 1
            End If
        Next

        If dirlist.Length > 0 Then
            addFolderItems(dirlist)
        End If
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        If ToolStripComboBox1.SelectedIndex = 0 Then
            lvwFiles.View = View.LargeIcon
        ElseIf ToolStripComboBox1.SelectedIndex = 1 Then
            lvwFiles.View = View.SmallIcon
        ElseIf ToolStripComboBox1.SelectedIndex = 2 Then
            lvwFiles.View = View.Tile
        ElseIf ToolStripComboBox1.SelectedIndex = 3 Then
            lvwFiles.View = View.List
        Else
            lvwFiles.View = View.Details
        End If
    End Sub

    Private Sub txtFolder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFolder.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim dir(1) As String
            dir(0) = txtFolder.Text
            If IO.Directory.Exists(txtFolder.Text) Then
                addFolderItems(dir)
            Else
                MsgBox("Invalid Directory", vbCritical)
            End If
        End If
    End Sub

    Private Sub MenuItem5_Click(sender As Object, e As EventArgs)
        frmAbout.ShowDialog()
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub MenuItem2_Click_1(sender As Object, e As EventArgs)
        btnBrowseFolder.PerformClick()
    End Sub

    Private Sub GridLinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridLinesToolStripMenuItem.Click
        If GridLinesToolStripMenuItem.Checked Then
            lvwFiles.GridLines = True
        Else
            lvwFiles.GridLines = False
        End If
    End Sub
    Private Sub ViewRibbonColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRibbonColorToolStripMenuItem.Click
        setRibonColor()
    End Sub

    Private Sub btnOpenContFolder_Click(sender As Object, e As EventArgs) Handles btnOpenContFolder.Click
        If txtFileLoc.Text <> "" Then
            Try
                Dim finfo As IO.FileInfo = New IO.FileInfo(txtFileLoc.Text)
                Process.Start(finfo.DirectoryName)
            Catch x As Exception
                MsgBox("Error!", vbOKOnly + vbCritical)
            End Try
        Else
            MsgBox("No file has been selected !", vbOKOnly + vbExclamation)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmAbout.ShowDialog()
    End Sub

    Private Sub SelectFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        btnBrowseFolder.PerformClick()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        frmListViewOptions.ShowDialog()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then
            e.Cancel = False
            Dim stringCollection As System.Collections.Specialized.StringCollection = New Specialized.StringCollection
            Dim stringCollection2 As System.Collections.Specialized.StringCollection = New Specialized.StringCollection
            If lvItemsToSkip IsNot Nothing Then
                For Each item In lvItemsToSkip
                    If item = "" Then
                        Continue For
                    End If
                    stringCollection.Add(item)
                Next
            Else
                My.Settings.lvItemsToSkip = Nothing
            End If

            My.Settings.allowSort = allowSort
            My.Settings.lvItemsToSkip = stringCollection 'lvItemsToSktip
            My.Settings.allowFileFromDifLoc = allowFileFromDifLoc
            My.Settings.viewRibonColor = ViewRibbonColorToolStripMenuItem.Checked
            My.Settings.programUsed = programUsed
            My.Settings.programLastUsed = System.DateTime.Now
            My.Settings.totalFilesRenamed = totalFilesRenamed
            My.Settings.totalFilesExtRemoved = totalFilesExtRemoved
            My.Settings.totalFilesExtChanged = totalFilesExtChanged
            My.Settings.colorCode = colorCode
            My.Settings.ribonColor = ribonColor

            If currentWorkingDir IsNot Nothing Then
                For Each item In currentWorkingDir
                    If item = Nothing Then
                        Continue For
                    End If

                    If item.Length = 0 Then
                        Continue For
                    End If
                    stringCollection2.Add(item)
                Next
            Else
                My.Settings.lastUsedFolder = Nothing
            End If

            My.Settings.lastUsedFolder = stringCollection2
        Else
            e.Cancel = True
        End If
    End Sub
    Public Sub addUndoFileItems(ByVal oldFileName As String, ByVal newFileName As String)
        Dim path As String
        fileInfo = New IO.FileInfo(oldFileName)
        oldFileName = fileInfo.Name
        path = fileInfo.DirectoryName & "\"
        Items.Add(frmUndo.lvwFiles.Items.Count + 1)
        Items.Item(Items.Count - 1).SubItems.Add(oldFileName)
        Items.Item(Items.Count - 1).SubItems.Add(newFileName)
        Items.Item(Items.Count - 1).SubItems.Add(path)
        If (Items.count - 1) Mod 2 = 0 Then
            If ViewRibbonColorToolStripMenuItem.Checked Then
                Items.Item(Items.count - 1).BackColor = ribonColor
            End If
        End If
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        frmUndo.ShowDialog()
    End Sub

    Private Sub txtFolder_Leave(sender As Object, e As EventArgs) Handles txtFolder.Leave
        'txtFolder.Text = currentWorkingDir
    End Sub

    Private Sub btnLastRunFolder_Click(sender As Object, e As EventArgs) Handles btnLastRunFolder.Click
        addFolderItems(lastUsedFolder)
    End Sub

    Public Sub statusUpdater(ByVal status As String)
        ToolStripStatusLabel2.Text = status
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim lsf As TextBox = New TextBox
        If lastUsedFolder IsNot Nothing Then
            For Each item In lastUsedFolder
                If item IsNot Nothing Then
                    If item.Length = 0 Then
                        Continue For
                    Else
                        lsf.AppendText(item & Environment.NewLine)
                    End If
                End If
            Next
        End If
        MsgBox("Total File(s) Extension Removed : " & totalFilesExtRemoved & Chr(13) &
       "Total File(s) Extension Changed : " & totalFilesExtChanged & Chr(13) &
       "Total File(s) Renamed : " & totalFilesRenamed & Chr(13) &
       "Program Last Used : " & programLastUsed.ToString & Chr(13) &
       "Program Used In Total : " & programUsed & Chr(13) &
        "Last Used Folder : " & Chr(13) & lsf.Text, vbInformation)
    End Sub

    Private Sub tsbtnBrowseFolder_Click(sender As Object, e As EventArgs) Handles tsbtnBrowseFolder.Click
        btnBrowseFolder.PerformClick()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        btnLastRunFolder.PerformClick()
    End Sub

    Private Sub tsbtnOptions_Click(sender As Object, e As EventArgs) Handles tsbtnOptions.Click
        frmListViewOptions.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles tsbtnUndo.Click
        btnUndo.PerformClick()
    End Sub

    Public Sub randomFileName()
        Dim oldFileName As String
        Dim newFileName As String
        Dim pcount As Integer = 0
        Dim ecount As Integer = 0
        Dim rand As New Random

        If cbxSelect.SelectedIndex = 1 Then
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.SelectedItems.Count

            Dim selectedItems = lvwFiles.SelectedItems
            For i As Integer = 0 To lvwFiles.SelectedItems.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    newFileName = ChrW(rand.Next(97, 122)) & rand.Next(12453, 476547) & ChrW(rand.Next(65, 90)) & rand.Next(12453, 478847) & ChrW(rand.Next(48, 57)) & ChrW(rand.Next(65, 90)) & rand.Next(1453, 47547) & ChrW(rand.Next(97, 122)) & "." & ChrW(rand.Next(97, 122)) & ChrW(rand.Next(65, 90)) & ChrW(rand.Next(97, 122))
                    oldFileName = selectedItems.Item(i).SubItems(4).Text
                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch ex As Exception
                    txtLog.AppendText("Error : " & selectedItems.Item(i).SubItems(4).Text & Environment.NewLine)
                    ecount += 1
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        ElseIf cbxSelect.SelectedIndex = 0 Then
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.Items.Count

            For i As Integer = 0 To lvwFiles.Items.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    newFileName = ChrW(rand.Next(97, 122)) & rand.Next(12453, 476547) & ChrW(rand.Next(65, 90)) & rand.Next(12453, 478847) & ChrW(rand.Next(48, 57)) & ChrW(rand.Next(65, 90)) & rand.Next(1453, 47547) & ChrW(rand.Next(97, 122)) & "." & ChrW(rand.Next(97, 122)) & ChrW(rand.Next(65, 90)) & ChrW(rand.Next(97, 122))
                    oldFileName = lvwFiles.Items.Item(i).SubItems(4).Text
                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch ex As Exception
                    txtLog.AppendText("Error : " & lvwFiles.Items.Item(i).SubItems(4).Text & Environment.NewLine)
                    ecount += 1
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        Else
            MsgBox("Invalid selection", vbOKOnly + vbCritical)
        End If
    End Sub

    Public Sub taskResult(pcount As Integer, ecount As Integer)
        txtLog.AppendText(Environment.NewLine & "File(s) Processed : " & pcount & " Error(s) : " & ecount & Environment.NewLine)
        txtLog.AppendText("---------- Refreshing Folder Contents -----------" + Environment.NewLine)
        ToolStripStatusLabel2.Text = "Refreshing Folder Contents..."
        addFolderItems(currentWorkingDir)
        ToolStripStatusLabel2.Text = "Folder Contents refreshed"
        btnUndo.Enabled = True
        tsbtnUndo.Enabled = True
        Me.Cursor = Cursors.Default
        If ecount = 0 Then
            MsgBox("Operation Completed successfuly", vbOKOnly + vbInformation)
        Else
            MsgBox("Operation Complete with some error(s)" + Chr(13) + "See Log", vbOKOnly + vbExclamation)
        End If
    End Sub

    Public Function cbxValidate() As Integer
        If txtFolder.Text = "" Then
            MsgBox("Select a folder first !", vbOKOnly + vbExclamation)
            Return 1
        End If

        If cbxSelect.SelectedIndex = -1 Then
            MsgBox("Select a option first", vbOKOnly + vbCritical)
            Return 1
        End If

        If cbxSelect.SelectedIndex = 1 Then
            If lvwFiles.SelectedItems.Count = 0 Then
                MsgBox("No file has been selected from the list!", vbCritical)
                Return 1
            End If
        End If

        'if everything is fine then
        Return 0
    End Function

    Public Sub append_prepend(stringToAppend As String, AppendAt As Integer)
        'appendAt 0 = before and 1 = after [file name]
        If cbxValidate() = 1 Then
            Exit Sub
        End If

        Dim oldFileName As String
        Dim newFileName As String
        Dim fileNameWithoutExt As String
        Dim dotloc As Integer
        Dim pcount As Integer = 0
        Dim ecount As Integer = 0

        If cbxSelect.SelectedIndex = 0 Then
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.Items.Count

            For i As Integer = 0 To lvwFiles.Items.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = lvwFiles.Items.Item(i).SubItems(4).Text
                    dotloc = lvwFiles.Items.Item(i).SubItems(1).Text.LastIndexOf(".")

                    If dotloc > 0 Then
                        fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text.Substring(0, dotloc)
                    Else
                        fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text
                    End If

                    'decides wheter to append before or after file name
                    If AppendAt = 0 Then
                        newFileName = stringToAppend & fileNameWithoutExt & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                    Else
                        newFileName = fileNameWithoutExt & stringToAppend & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                    End If

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & lvwFiles.Items.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        Else
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.SelectedItems.Count

            Dim selectedItems = lvwFiles.SelectedItems
            For i As Integer = 0 To lvwFiles.SelectedItems.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = selectedItems.Item(i).SubItems(4).Text
                    dotloc = selectedItems.Item(i).SubItems(1).Text.LastIndexOf(".")

                    If dotloc > 0 Then
                        fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text.Substring(0, dotloc)
                    Else
                        fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text
                    End If

                    'decides wheter to append before or after file name
                    If AppendAt = 0 Then
                        newFileName = stringToAppend & fileNameWithoutExt & "." & selectedItems.Item(i).SubItems(2).Text
                    Else
                        newFileName = fileNameWithoutExt & stringToAppend & "." & selectedItems.Item(i).SubItems(2).Text
                    End If

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & selectedItems.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        End If
    End Sub

    Public Sub formatCase(caseCode As Integer)
        If cbxValidate() = 1 Then
            Exit Sub
        End If

        Dim newFileName As String
        Dim oldFileName As String
        Dim tmpOldFileName As String
        Dim pcount As Integer = 0
        Dim ecount As Integer = 0

        If cbxSelect.SelectedIndex = 0 Then
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.Items.Count

            For i As Integer = 0 To lvwFiles.Items.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = lvwFiles.Items.Item(i).SubItems(4).Text

                    If caseCode = 0 Then
                        'upper case
                        newFileName = lvwFiles.Items.Item(i).SubItems(1).Text.ToUpper
                    ElseIf caseCode = 1 Then
                        'lower case
                        newFileName = lvwFiles.Items.Item(i).SubItems(1).Text.ToLower
                    Else
                        'capitalize
                    End If

                    'temporarly rename to a custom file name
                    FileIO.FileSystem.RenameFile(oldFileName, "12345XYZNULLFILE0987.TMP")
                    tmpOldFileName = lvwFiles.Items.Item(i).SubItems(4).Text.Substring(0, lvwFiles.Items.Item(i).SubItems(4).Text.LastIndexOf("\"))
                    tmpOldFileName = tmpOldFileName & "\12345XYZNULLFILE0987.TMP"

                    FileIO.FileSystem.RenameFile(tmpOldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & lvwFiles.Items.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next

            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        Else
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.SelectedItems.Count

            Dim selectedItems = lvwFiles.SelectedItems
            For i As Integer = 0 To lvwFiles.SelectedItems.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = selectedItems.Item(i).SubItems(4).Text

                    If caseCode = 0 Then
                        'upper case
                        newFileName = selectedItems.Item(i).SubItems(1).Text.ToUpper
                    ElseIf caseCode = 1 Then
                        'lower case
                        newFileName = selectedItems.Item(i).SubItems(1).Text.ToLower
                    Else
                        'capitalize
                    End If

                    'temporarly rename to a custom file name
                    FileIO.FileSystem.RenameFile(oldFileName, "12345XYZNULLFILE0987.TMP")
                    tmpOldFileName = selectedItems.Item(i).SubItems(4).Text.Substring(0, selectedItems.Item(i).SubItems(4).Text.LastIndexOf("\"))
                    tmpOldFileName = tmpOldFileName & "\12345XYZNULLFILE0987.TMP"

                    FileIO.FileSystem.RenameFile(tmpOldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & selectedItems.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next

            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        End If
    End Sub

    Public Sub autoNumber(jobCode As Integer, NumberFrom As Integer, atPosition As Integer)
        'jobCode 0 = Before File Name
        'jobCode 1 = After File Name
        'jobCode 2 = Only Keep Number
        'jobCode 3 = Insert at position

        If cbxValidate() = 1 Then
            Exit Sub
        End If

        Dim newFileName As String
        Dim oldFileName As String
        Dim fileNameWithoutExt As String
        Dim tempFileName As String
        Dim number As Integer
        Dim dotloc As Integer
        Dim pcount As Integer = 0
        Dim ecount As Integer = 0

        If cbxSelect.SelectedIndex = 0 Then
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.Items.Count
            number = NumberFrom

            For i As Integer = 0 To lvwFiles.Items.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = lvwFiles.Items.Item(i).SubItems(4).Text

                    If jobCode = 0 Then
                        newFileName = number.ToString & lvwFiles.Items.Item(i).SubItems(1).Text
                    ElseIf jobCode = 1 Then
                        dotloc = lvwFiles.Items.Item(i).SubItems(1).Text.LastIndexOf(".")
                        If dotloc > 0 Then
                            fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text.Substring(0, dotloc)
                        Else
                            fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text
                        End If
                        newFileName = fileNameWithoutExt & number.ToString & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                    ElseIf jobCode = 2 Then
                        If lvwFiles.Items.Item(i).SubItems(2).Text.Length > 0 Then
                            newFileName = number.ToString & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                        Else
                            newFileName = number.ToString
                        End If
                    Else
                        dotloc = lvwFiles.Items.Item(i).SubItems(1).Text.LastIndexOf(".")
                        If dotloc > 0 Then
                            fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text.Substring(0, dotloc)
                        Else
                            fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text
                        End If

                        If atPosition <= fileNameWithoutExt.Length Then
                            tempFileName = lvwFiles.Items.Item(i).SubItems(1).Text.Substring(0, atPosition)
                            newFileName = tempFileName & number.ToString & lvwFiles.Items.Item(i).SubItems(1).Text.Substring(atPosition)
                        Else
                            newFileName = fileNameWithoutExt & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                        End If
                    End If

                    number += 1 'increments the number

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & lvwFiles.Items.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next

            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        Else
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.SelectedItems.Count

            Dim selectedItems = lvwFiles.SelectedItems
            number = NumberFrom
            For i As Integer = 0 To lvwFiles.SelectedItems.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = selectedItems.Item(i).SubItems(4).Text

                    If jobCode = 0 Then
                        newFileName = number.ToString & selectedItems.Item(i).SubItems(1).Text
                    ElseIf jobCode = 1 Then
                        dotloc = selectedItems.Item(i).SubItems(1).Text.LastIndexOf(".")
                        If dotloc > 0 Then
                            fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text.Substring(0, dotloc)
                        Else
                            fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text
                        End If
                        newFileName = fileNameWithoutExt & number.ToString & "." & selectedItems.Item(i).SubItems(2).Text
                    ElseIf jobCode = 2 Then
                        If selectedItems.Item(i).SubItems(2).Text.Length > 0 Then
                            newFileName = number.ToString & "." & selectedItems.Item(i).SubItems(2).Text
                        Else
                            newFileName = number.ToString
                        End If
                    Else
                        dotloc = selectedItems.Item(i).SubItems(1).Text.LastIndexOf(".")
                        If dotloc > 0 Then
                            fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text.Substring(0, dotloc)
                        Else
                            fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text
                        End If

                        If atPosition <= fileNameWithoutExt.Length Then
                            tempFileName = selectedItems.Item(i).SubItems(1).Text.Substring(0, atPosition)
                            newFileName = tempFileName & number.ToString & selectedItems.Item(i).SubItems(1).Text.Substring(atPosition)
                        Else
                            newFileName = fileNameWithoutExt & "." & selectedItems.Item(i).SubItems(2).Text
                        End If
                    End If

                    number += 1 'increments the number

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & selectedItems.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next

            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        End If
    End Sub

    Public Sub deleteCharacter(position As Integer, deleteCount As Integer)
        'position 0 = begining
        'position 1 = end

        If cbxValidate() = 1 Then
            Exit Sub
        End If

        Dim oldFileName As String
        Dim newFileName As String
        Dim fileNameWithoutExt As String
        Dim dotloc As Integer
        Dim pcount As Integer = 0
        Dim ecount As Integer = 0

        If cbxSelect.SelectedIndex = 0 Then
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.Items.Count

            For i As Integer = 0 To lvwFiles.Items.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = lvwFiles.Items.Item(i).SubItems(4).Text
                    dotloc = lvwFiles.Items.Item(i).SubItems(1).Text.LastIndexOf(".")

                    If dotloc > 0 Then
                        fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text.Substring(0, dotloc)
                    Else
                        fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text
                    End If

                    'decides whether to delete before or after file name
                    If position = 0 Then
                        If deleteCount < fileNameWithoutExt.Length Then
                            newFileName = lvwFiles.Items.Item(i).SubItems(1).Text.Substring(deleteCount)
                        Else
                            txtLog.AppendText("Error [FILE NAME LENGTH IS SORETER]: " & lvwFiles.Items.Item(i).SubItems(4).Text & Environment.NewLine)
                            ecount += 1
                            Continue For
                        End If
                    Else
                        If deleteCount < fileNameWithoutExt.Length Then
                            newFileName = fileNameWithoutExt.Substring(0, fileNameWithoutExt.Length - deleteCount) & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                        Else
                            txtLog.AppendText("Error [FILE NAME LENGTH IS SORETER]: " & lvwFiles.Items.Item(i).SubItems(4).Text & Environment.NewLine)
                            ecount += 1
                            Continue For
                        End If
                    End If

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & lvwFiles.Items.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        Else
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.SelectedItems.Count

            Dim selectedItems = lvwFiles.SelectedItems
            For i As Integer = 0 To lvwFiles.SelectedItems.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = selectedItems.Item(i).SubItems(4).Text
                    dotloc = selectedItems.Item(i).SubItems(1).Text.LastIndexOf(".")

                    If dotloc > 0 Then
                        fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text.Substring(0, dotloc)
                    Else
                        fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text
                    End If

                    'decides whether to delete before or after file name
                    If position = 0 Then
                        If deleteCount < fileNameWithoutExt.Length Then
                            newFileName = selectedItems.Item(i).SubItems(1).Text.Substring(deleteCount)
                        Else
                            txtLog.AppendText("Error [FILE NAME LENGTH IS SORETER]: " & selectedItems.Item(i).SubItems(4).Text & Environment.NewLine)
                            ecount += 1
                            Continue For
                        End If
                    Else
                        If deleteCount < fileNameWithoutExt.Length Then
                            newFileName = fileNameWithoutExt.Substring(0, fileNameWithoutExt.Length - deleteCount) & "." & selectedItems.Item(i).SubItems(2).Text
                        Else
                            txtLog.AppendText("Error [FILE NAME LENGTH IS SORETER]: " & selectedItems.Item(i).SubItems(4).Text & Environment.NewLine)
                            ecount += 1
                            Continue For
                        End If
                    End If

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & selectedItems.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        End If
    End Sub

    Public Sub insertText(stringToInsert As String, position As Integer, Optional insertAt As Integer = 0, Optional sstring As String = Nothing)
        'position 0 = before
        'position 1 = after
        'position 2 = at Position

        If cbxValidate() = 1 Then
            Exit Sub
        End If

        Dim oldFileName As String
        Dim newFileName As String
        Dim fileNameWithoutExt As String
        Dim dotloc As Integer
        Dim pcount As Integer = 0
        Dim ecount As Integer = 0

        If cbxSelect.SelectedIndex = 0 Then
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.Items.Count
            Dim indexOfsstring As Integer

            For i As Integer = 0 To lvwFiles.Items.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = lvwFiles.Items.Item(i).SubItems(4).Text
                    dotloc = lvwFiles.Items.Item(i).SubItems(1).Text.LastIndexOf(".")

                    If dotloc > 0 Then
                        fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text.Substring(0, dotloc)
                    Else
                        fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text
                    End If

                    'decides whether to delete before or after file name
                    If position = 0 Then
                        indexOfsstring = fileNameWithoutExt.ToLower.IndexOf(sstring.ToLower)
                        If indexOfsstring >= 0 Then
                            newFileName = fileNameWithoutExt.Insert(indexOfsstring, stringToInsert) & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                        Else
                            txtLog.AppendText("ERROR [STRING NOT FOUND] : " & Items.Item(i).SubItems(1).Text & Environment.NewLine)
                            ecount += 1
                            Continue For
                        End If
                    ElseIf position = 1 Then
                        indexOfsstring = fileNameWithoutExt.ToLower.IndexOf(sstring.ToLower)
                        If indexOfsstring >= 0 Then
                            newFileName = fileNameWithoutExt.Insert(indexOfsstring + stringToInsert.Length, stringToInsert) & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                        Else
                            txtLog.AppendText("ERROR [STRING NOT FOUND] : " & lvwFiles.Items.Item(i).SubItems(1).Text & Environment.NewLine)
                            ecount += 1
                            Continue For
                        End If
                    Else
                        If insertAt <= fileNameWithoutExt.Length Then
                            newFileName = fileNameWithoutExt.Insert(insertAt, stringToInsert) & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                        Else
                            txtLog.AppendText("ERROR [INSERTION POSITION IS INVALID] : " & lvwFiles.Items.Item(i).SubItems(1).Text & Environment.NewLine)
                            ecount += 1
                            Continue For
                        End If
                    End If

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & lvwFiles.Items.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        Else
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.SelectedItems.Count
            Dim indexOfsstring As Integer

            Dim selectedItems = lvwFiles.SelectedItems
            For i As Integer = 0 To lvwFiles.SelectedItems.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = selectedItems.Item(i).SubItems(4).Text
                    dotloc = selectedItems.Item(i).SubItems(1).Text.LastIndexOf(".")

                    If dotloc > 0 Then
                        fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text.Substring(0, dotloc)
                    Else
                        fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text
                    End If

                    'decides whether to delete before or after file name
                    If position = 0 Then
                        indexOfsstring = fileNameWithoutExt.ToLower.IndexOf(sstring.ToLower)
                        If indexOfsstring >= 0 Then
                            newFileName = fileNameWithoutExt.Insert(indexOfsstring, stringToInsert) & "." & selectedItems.Item(i).SubItems(2).Text
                        Else
                            txtLog.AppendText("ERROR [STRING NOT FOUND] : " & selectedItems.Item(i).SubItems(1).Text & Environment.NewLine)
                            ecount += 1
                            Continue For
                        End If
                    ElseIf position = 1 Then
                        indexOfsstring = fileNameWithoutExt.ToLower.IndexOf(sstring.ToLower)
                        If indexOfsstring >= 0 Then
                            newFileName = fileNameWithoutExt.Insert(indexOfsstring + stringToInsert.Length, stringToInsert) & "." & selectedItems.Item(i).SubItems(2).Text
                        Else
                            txtLog.AppendText("ERROR [STRING NOT FOUND] : " & selectedItems.Item(i).SubItems(1).Text & Environment.NewLine)
                            ecount += 1
                            Continue For
                        End If
                    Else
                        If insertAt <= fileNameWithoutExt.Length Then
                            newFileName = fileNameWithoutExt.Insert(insertAt, stringToInsert) & "." & selectedItems.Item(i).SubItems(2).Text
                        Else
                            txtLog.AppendText("ERROR [INSERTION POSITION IS INVALID] : " & selectedItems.Item(i).SubItems(1).Text & Environment.NewLine)
                            ecount += 1
                            Continue For
                        End If
                    End If

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & selectedItems.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        End If
    End Sub

    Public Sub removeText(stringToRemove As String)
        If cbxValidate() = 1 Then
            Exit Sub
        End If

        Dim oldFileName As String
        Dim newFileName As String
        Dim StringOne As String
        Dim StringTwo As String
        Dim fileNameWithoutExt As String
        Dim dotloc As Integer
        Dim pcount As Integer = 0
        Dim ecount As Integer = 0

        If cbxSelect.SelectedIndex = 0 Then
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.Items.Count
            Dim indexOfsstring As Integer

            For i As Integer = 0 To lvwFiles.Items.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = lvwFiles.Items.Item(i).SubItems(4).Text
                    dotloc = lvwFiles.Items.Item(i).SubItems(1).Text.LastIndexOf(".")

                    If dotloc > 0 Then
                        fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text.Substring(0, dotloc)
                    Else
                        fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text
                    End If

                    'decides whether to delete before or after file name
                    indexOfsstring = fileNameWithoutExt.ToLower.IndexOf(stringToRemove.ToLower)
                    If indexOfsstring >= 0 Then
                        StringOne = fileNameWithoutExt.Substring(0, indexOfsstring)
                        StringTwo = fileNameWithoutExt.Substring(indexOfsstring + stringToRemove.Length)
                        newFileName = StringOne & StringTwo & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                    Else
                        txtLog.AppendText("ERROR [STRING NOT FOUND] : " & lvwFiles.Items.Item(i).SubItems(1).Text & Environment.NewLine)
                        ecount += 1
                        Continue For
                    End If

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & lvwFiles.Items.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        Else
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.SelectedItems.Count
            Dim indexOfsstring As Integer

            Dim selectedItems = lvwFiles.SelectedItems
            For i As Integer = 0 To lvwFiles.SelectedItems.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = selectedItems.Item(i).SubItems(4).Text
                    dotloc = selectedItems.Item(i).SubItems(1).Text.LastIndexOf(".")

                    If dotloc > 0 Then
                        fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text.Substring(0, dotloc)
                    Else
                        fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text
                    End If

                    'decides whether to delete before or after file name
                    indexOfsstring = fileNameWithoutExt.ToLower.IndexOf(stringToRemove.ToLower)
                    If indexOfsstring >= 0 Then
                        StringOne = fileNameWithoutExt.Substring(0, indexOfsstring)
                        StringTwo = fileNameWithoutExt.Substring(indexOfsstring + stringToRemove.Length)
                        newFileName = StringOne & StringTwo & "." & selectedItems.Item(i).SubItems(2).Text
                    Else
                        txtLog.AppendText("ERROR [STRING NOT FOUND] : " & selectedItems.Item(i).SubItems(1).Text & Environment.NewLine)
                        ecount += 1
                        Continue For
                    End If

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & selectedItems.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        End If
    End Sub

    Public Sub replaceString(stringToFind As String, stringToReplace As String)
        If cbxValidate() = 1 Then
            Exit Sub
        End If

        Dim oldFileName As String
        Dim newFileName As String
        Dim StringOne As String
        Dim StringTwo As String
        Dim fileNameWithoutExt As String
        Dim dotloc As Integer
        Dim pcount As Integer = 0
        Dim ecount As Integer = 0

        If cbxSelect.SelectedIndex = 0 Then
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.Items.Count
            Dim indexOfsstring As Integer

            For i As Integer = 0 To lvwFiles.Items.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = lvwFiles.Items.Item(i).SubItems(4).Text
                    dotloc = lvwFiles.Items.Item(i).SubItems(1).Text.LastIndexOf(".")

                    If dotloc > 0 Then
                        fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text.Substring(0, dotloc)
                    Else
                        fileNameWithoutExt = lvwFiles.Items.Item(i).SubItems(1).Text
                    End If

                    'decides whether to delete before or after file name
                    indexOfsstring = fileNameWithoutExt.ToLower.IndexOf(stringToFind.ToLower)
                    If indexOfsstring >= 0 Then
                        StringOne = fileNameWithoutExt.Substring(0, indexOfsstring) & stringToReplace
                        StringTwo = fileNameWithoutExt.Substring(indexOfsstring + stringToFind.Length)
                        newFileName = StringOne & StringTwo & "." & lvwFiles.Items.Item(i).SubItems(2).Text
                    Else
                        txtLog.AppendText("ERROR [STRING NOT FOUND] : " & lvwFiles.Items.Item(i).SubItems(1).Text & Environment.NewLine)
                        ecount += 1
                        Continue For
                    End If

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & lvwFiles.Items.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        Else
            frmUndo.lvwFiles.Items.Clear()
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Maximum = lvwFiles.SelectedItems.Count
            Dim indexOfsstring As Integer

            Dim selectedItems = lvwFiles.SelectedItems
            For i As Integer = 0 To lvwFiles.SelectedItems.Count - 1
                Try
                    ToolStripProgressBar1.PerformStep()
                    oldFileName = selectedItems.Item(i).SubItems(4).Text
                    dotloc = selectedItems.Item(i).SubItems(1).Text.LastIndexOf(".")

                    If dotloc > 0 Then
                        fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text.Substring(0, dotloc)
                    Else
                        fileNameWithoutExt = selectedItems.Item(i).SubItems(1).Text
                    End If

                    'decides whether to delete before or after file name
                    indexOfsstring = fileNameWithoutExt.ToLower.IndexOf(stringToFind.ToLower)
                    If indexOfsstring >= 0 Then
                        StringOne = fileNameWithoutExt.Substring(0, indexOfsstring) & stringToReplace
                        StringTwo = fileNameWithoutExt.Substring(indexOfsstring + stringToFind.Length)
                        newFileName = StringOne & StringTwo & "." & selectedItems.Item(i).SubItems(2).Text
                    Else
                        txtLog.AppendText("ERROR [STRING NOT FOUND] : " & selectedItems.Item(i).SubItems(1).Text & Environment.NewLine)
                        ecount += 1
                        Continue For
                    End If

                    addUndoFileItems(oldFileName, newFileName)
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    txtLog.AppendText("Processing : " & oldFileName & Environment.NewLine)
                Catch e As Exception
                    ecount += 1
                    txtLog.AppendText("Error : " & selectedItems.Item(i).SubItems(4).Text & Environment.NewLine)
                End Try
            Next
            taskResult(pcount, ecount)
            totalFilesRenamed += pcount
        End If
    End Sub

    Public Sub setTheme(colorCode As Integer)
        '0 for blue
        '1 for green
        '2 for yellow
        '3 for red
        '4 for grey
        '5 for orange

        'the forms collection
        Dim formsToTheme(7) As Form
        formsToTheme(0) = Me
        formsToTheme(1) = frmRemoveExt
        formsToTheme(2) = frmChangeExtension
        formsToTheme(3) = frmRename
        formsToTheme(4) = frmUndo
        formsToTheme(5) = frmListViewOptions
        formsToTheme(6) = frmMore

        'code to change the theme
        For i As Integer = 0 To 6
            If colorCode = 0 Then
                formsToTheme(i).BackgroundImage = My.Resources.themeBlue
                panleFolder.BackgroundImage = My.Resources.themeBlueL
                ToolStrip1.BackgroundImage = My.Resources.themeBlueL
                StatusStrip1.BackColor = Color.FromArgb(215, 228, 242)
                frmMore.StatusStrip1.BackColor = Color.FromArgb(215, 228, 242)
                ribonColor = Color.AliceBlue
                setRibonColor()
            ElseIf colorCode = 1 Then
                formsToTheme(i).BackgroundImage = My.Resources.themeGreen
                panleFolder.BackgroundImage = My.Resources.themeGreenL
                ToolStrip1.BackgroundImage = My.Resources.themeGreenL
                StatusStrip1.BackColor = Color.FromArgb(192, 255, 192)
                frmMore.StatusStrip1.BackColor = Color.FromArgb(192, 255, 192)
                ribonColor = Color.FromArgb(230, 255, 230)
                setRibonColor()
            ElseIf colorCode = 2 Then
                formsToTheme(i).BackgroundImage = My.Resources.themeYellow
                panleFolder.BackgroundImage = My.Resources.themeYellowL
                ToolStrip1.BackgroundImage = My.Resources.themeYellowL
                StatusStrip1.BackColor = Color.PaleGoldenrod
                frmMore.StatusStrip1.BackColor = Color.PaleGoldenrod
                ribonColor = Color.FromArgb(255, 255, 220)
                setRibonColor()
            ElseIf colorCode = 3 Then
                formsToTheme(i).BackgroundImage = My.Resources.themeRed
                panleFolder.BackgroundImage = My.Resources.themeRedL
                ToolStrip1.BackgroundImage = My.Resources.themeRedL
                frmMore.StatusStrip1.BackColor = Color.Pink
                StatusStrip1.BackColor = Color.Pink
                ribonColor = Color.FromArgb(255, 240, 240)
                setRibonColor()
            ElseIf colorCode = 4 Then
                formsToTheme(i).BackgroundImage = My.Resources.themeGrey
                panleFolder.BackgroundImage = My.Resources.themeGreyL
                ToolStrip1.BackgroundImage = My.Resources.themeGreyL
                frmMore.StatusStrip1.BackColor = Color.Gainsboro
                StatusStrip1.BackColor = Color.Gainsboro
                ribonColor = Color.WhiteSmoke
                setRibonColor()
            Else
                formsToTheme(i).BackgroundImage = My.Resources.themeOrange
                panleFolder.BackgroundImage = My.Resources.themeOrangeL
                ToolStrip1.BackgroundImage = My.Resources.themeOrangeL
                frmMore.StatusStrip1.BackColor = Color.NavajoWhite
                StatusStrip1.BackColor = Color.NavajoWhite
                ribonColor = Color.FromArgb(255, 240, 225)
                setRibonColor()
            End If
        Next

    End Sub
    Public Sub setRibonColor()
        If ViewRibbonColorToolStripMenuItem.Checked = False Then
            If lvwFiles.Items.Count > 0 Then
                For i As Integer = 0 To lvwFiles.Items.Count - 1
                    If i Mod 2 = 0 Then
                        lvwFiles.Items(i).BackColor = Color.White
                    End If
                Next
            End If
            If frmUndo.lvwFiles.Items.Count > 0 Then
                For i As Integer = 0 To frmUndo.lvwFiles.Items.Count - 1
                    If i Mod 2 = 0 Then
                        frmUndo.lvwFiles.Items(i).BackColor = Color.White
                    End If
                Next
            End If
        Else
            If lvwFiles.Items.Count > 0 Then
                For i As Integer = 0 To lvwFiles.Items.Count - 1
                    If i Mod 2 = 0 Then
                        lvwFiles.Items(i).BackColor = ribonColor
                    End If
                Next
            End If
            If frmUndo.lvwFiles.Items.Count > 0 Then
                For i As Integer = 0 To frmUndo.lvwFiles.Items.Count - 1
                    If i Mod 2 = 0 Then
                        frmUndo.lvwFiles.Items(i).BackColor = ribonColor
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmChangeTheme.ShowDialog()
    End Sub

    Private Sub txtFolder_TextChanged(sender As Object, e As EventArgs) Handles txtFolder.TextChanged

    End Sub
End Class

