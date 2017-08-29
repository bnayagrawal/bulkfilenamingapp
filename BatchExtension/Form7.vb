Imports System.ComponentModel

Public Class frmUndo
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnRestoreFileName_Click(sender As Object, e As EventArgs) Handles btnRestoreFileName.Click
        If cbxOptions.SelectedIndex = 1 Then
            Me.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Dim oldFileName As String
            Dim newFileName As String
            Dim pcount As Integer = 0
            Dim ecount As Integer = 0
            ProgressBar1.Value = 0
            ProgressBar1.Maximum = lvwFiles.Items.Count
            For i As Integer = 0 To lvwFiles.Items.Count - 1
                Try
                    oldFileName = lvwFiles.Items.Item(i).SubItems(3).Text & lvwFiles.Items.Item(i).SubItems(2).Text
                    newFileName = lvwFiles.Items.Item(i).SubItems(1).Text
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    ProgressBar1.PerformStep()
                Catch Ee As Exception
                    ecount += 1
                    ProgressBar1.PerformStep()
                End Try
            Next
            Me.Enabled = True
            Me.Cursor = Cursors.Default
            MsgBox("Task Complete." & Chr(13) & "Files Processed : " & pcount & Chr(13) & "Errors : " & ecount, vbInformation)
            lvwFiles.Items.Clear()
            lblTotalItems.Text = "Total Item(s) : " & lvwFiles.Items.Count
            btnRestoreFileName.Enabled = False
            frmMain.btnUndo.Enabled = False
            frmMain.tsbtnUndo.Enabled = False
            frmMain.addFolderItems(frmMain.currentWorkingDir)
            Me.Close()
        ElseIf cbxOptions.SelectedIndex = 0 Then
            If lvwFiles.SelectedItems.Count = 0 Then
                MsgBox("Select a item first!", vbCritical + vbOKOnly)
                Exit Sub
            End If
            Me.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Dim oldFileName As String
            Dim newFileName As String
            Dim pcount As Integer = 0
            Dim ecount As Integer = 0
            ProgressBar1.Value = 0
            ProgressBar1.Maximum = lvwFiles.SelectedItems.Count
            For i As Integer = 0 To lvwFiles.SelectedItems.Count - 1
                Try
                    oldFileName = lvwFiles.SelectedItems.Item(i).SubItems(3).Text & lvwFiles.SelectedItems.Item(i).SubItems(2).Text
                    newFileName = lvwFiles.SelectedItems.Item(i).SubItems(1).Text
                    FileIO.FileSystem.RenameFile(oldFileName, newFileName)
                    pcount += 1
                    ProgressBar1.PerformStep()
                    'lvwFiles.SelectedItems.Item(i).Remove()
                Catch Ee As Exception
                    ecount += 1
                    ProgressBar1.PerformStep()
                    'lvwFiles.SelectedItems.Item(i).Remove()
                End Try
            Next
            Dim selectedItems = lvwFiles.SelectedItems
            For i As Integer = 0 To selectedItems.Count - 1
                selectedItems.Item(0).Remove()
            Next
            Me.Enabled = True
            Me.Cursor = Cursors.Default
            MsgBox("Task Complete." & Chr(13) & "Files Processed : " & pcount & Chr(13) & "Errors : " & ecount, vbInformation)
            lblTotalItems.Text = "Total Item(s) : " & lvwFiles.Items.Count
            lblSelectedItems.Text = "Selected Item(s) : 0"
            If lvwFiles.Items.Count = 0 Then
                btnRestoreFileName.Enabled = False
                frmMain.btnUndo.Enabled = False
                frmMain.tsbtnUndo.Enabled = False
                frmMain.addFolderItems(frmMain.currentWorkingDir)
                Me.Close()
            End If
            frmMain.addFolderItems(frmMain.currentWorkingDir)
        Else
            MsgBox("Selecte a option!", vbCritical + vbOKOnly)
            Exit Sub
        End If
    End Sub

    Private Sub frmUndo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lvwFiles.Items.Count > 0 Then
            btnRestoreFileName.Enabled = True
        End If
        lblTotalItems.Text = "Total Item(s) : " & lvwFiles.Items.Count
        lblSelectedItems.Text = "Selected Item(s) : 0"
    End Sub

    Private Sub lvwFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwFiles.SelectedIndexChanged
        lblSelectedItems.Text = "Selected Item(s) : " & lvwFiles.SelectedItems.Count
        If lvwFiles.SelectedItems.Count = 0 Then
            cbxOptions.SelectedIndex = 1
        Else
            cbxOptions.SelectedIndex = 0
        End If
    End Sub
End Class