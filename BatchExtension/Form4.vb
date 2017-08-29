Imports System.ComponentModel

Public Class frmMore
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If txtSaveFilesTo.Text.Length = 0 Then
            Close()
        End If
        If IO.Directory.Exists(txtSaveFilesTo.Text) Then
            If MsgBox("Do you want to display " + txtSaveFilesTo.Text + " in BatchExtension?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                frmMain.txtFileLoc.Text = txtSaveFilesTo.Text
                'frmMain.addFolderItems(txtSaveFilesTo.Text)
                Me.Cursor = Cursors.Default
                Close()
            Else
                Close()
            End If
        Else
            Close()
        End If
    End Sub

    Private Sub chkAppendStringBeforeNum_CheckedChanged(sender As Object, e As EventArgs) Handles chkAppendStringBeforeNum.CheckedChanged
        If chkAppendStringBeforeNum.Checked Then
            txtStringToAppend.Enabled = True
            lblStringToAppend.Enabled = True
        Else
            txtStringToAppend.Enabled = False
            lblStringToAppend.Enabled = False
        End If
    End Sub

    Private Sub rbNameFileWithNum_CheckedChanged(sender As Object, e As EventArgs) Handles rbNameFileWithNum.CheckedChanged
        If rbGenRandFileName.Checked Then
            txtStringToAppend.Enabled = False
            NumericUpDown2.Enabled = False
            chkAppendStringBeforeNum.Enabled = False
            lblDefFileNameNumFrom.Enabled = False
            lblStringToAppend.Enabled = False
        Else
            NumericUpDown2.Enabled = True
            chkAppendStringBeforeNum.Enabled = True
            lblDefFileNameNumFrom.Enabled = True
            If chkAppendStringBeforeNum.Checked Then
                lblStringToAppend.Enabled = True
                txtStringToAppend.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        FolderBrowserDialog1.Description = "Select a folder where you want to create the files"
        FolderBrowserDialog1.ShowDialog()
        txtSaveFilesTo.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnStartCreatingFiles_Click(sender As Object, e As EventArgs) Handles btnStartCreatingFiles.Click
        If txtWithExtName.Text.Length = 0 Then
            MsgBox("Please provide a extension name !", vbCritical)
            Exit Sub
        End If
        If txtSaveFilesTo.Text.Length = 0 Then
            MsgBox("Please select a path", vbOKOnly + vbCritical)
            Exit Sub
        ElseIf IO.Directory.Exists(txtSaveFilesTo.Text) = False Then
            MsgBox("Invalid Directory !" + Chr(13) + "Please select a different directory", vbCritical)
            Exit Sub
        End If

        Dim fp As Integer = 0
        Dim fpe As Integer = 0
        If rbGenRandFileName.Checked Then
            tsProg.Value = 0
            tsProg.Maximum = NumericUpDown1.Value
            Dim fname As String
            Dim fn As String
            Dim fne As String
            For i As Integer = 1 To NumericUpDown1.Value
                Me.Enabled = False
                Me.Cursor = Cursors.WaitCursor
                Try
                    tsProg.PerformStep()
                    fname = New String(FileIO.FileSystem.GetTempFileName())
                    fn = fname.Substring(fname.LastIndexOf("\") + 1)
                    fne = fn.Substring(0, fn.LastIndexOf(".")) + "." + txtWithExtName.Text
                    FileIO.FileSystem.MoveFile(fname, txtSaveFilesTo.Text + "\" + fn)
                    FileIO.FileSystem.RenameFile(txtSaveFilesTo.Text + "\" + fn, fne)
                    txtLog.AppendText("Created : " + txtSaveFilesTo.Text + "\" + fne + Environment.NewLine)
                    fp += 1
                Catch ioe As IO.IOException
                    txtLog.AppendText("Error : file not created as a file with same name exists" + Environment.NewLine)
                    fpe += 1
                Catch AE As System.UnauthorizedAccessException
                    txtLog.AppendText("Error : Access Denied")
                    fpe += 1
                End Try
                Me.Enabled = True
                Me.Cursor = Cursors.Default
            Next
            txtLog.AppendText(Environment.NewLine + "Operation completed" + Environment.NewLine + "--------------------------------")
            txtLog.AppendText(Environment.NewLine + "File(s) created : " & fp & " Error(s) : " & fpe)
            MsgBox("File(s) created [" & fp & "] " + Chr(13) + "Saved to : " + txtSaveFilesTo.Text, vbInformation)
        Else
            tsProg.Value = 0
            tsProg.Maximum = NumericUpDown1.Value
            Dim fname As String
            Dim fn As String
            Dim fne As String
            Dim fno As Integer = Integer.Parse(NumericUpDown2.Value)
            For i As Integer = 1 To NumericUpDown1.Value
                Me.Enabled = False
                Me.Cursor = Cursors.WaitCursor
                Try
                    tsProg.PerformStep()
                    fname = New String(FileIO.FileSystem.GetTempFileName())
                    fn = fname.Substring(fname.LastIndexOf("\") + 1)
                    If chkAppendStringBeforeNum.Checked Then
                        fne = txtStringToAppend.Text + fno.ToString + "." + txtWithExtName.Text
                    Else
                        fne = fno.ToString + "." + txtWithExtName.Text
                    End If
                    fno += 1
                    'fne = fn.Substring(0, fn.LastIndexOf(".")) + "." + TextBox1.Text
                    FileIO.FileSystem.MoveFile(fname, txtSaveFilesTo.Text + "\" + fn)
                    FileIO.FileSystem.RenameFile(txtSaveFilesTo.Text + "\" + fn, fne)
                    txtLog.AppendText("Created : " + txtSaveFilesTo.Text + "\" + fne + Environment.NewLine)
                    fp += 1
                Catch ioe As IO.IOException
                    txtLog.AppendText("Error : file not created as a file with same name exists" + Environment.NewLine)
                    fpe += 1
                Catch AE As System.UnauthorizedAccessException
                    txtLog.AppendText("Error : Access Denied")
                    fpe += 1
                End Try
                Me.Enabled = True
                Me.Cursor = Cursors.WaitCursor
            Next
            txtLog.AppendText(Environment.NewLine + "Operation completed" + Environment.NewLine + "--------------------------------")
            txtLog.AppendText(Environment.NewLine + "File(s) created : " & fp & " Error(s) : " & fpe)
            MsgBox("File(s) created [" & fp & "] " + Chr(13) + "Saved to : " + txtSaveFilesTo.Text, vbInformation)
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("This program will help you in" + Chr(13) + "Creating 0 byte file(s) as much you want", vbInformation)
    End Sub
    Private Sub txtStringToAppend_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStringToAppend.KeyPress
        If e.KeyChar.ToString = "\" Then
            e.KeyChar = ""
        ElseIf e.KeyChar.ToString = "/" Then
            e.KeyChar = ""
        ElseIf e.KeyChar.ToString = ":" Then
            e.KeyChar = ""
        ElseIf e.KeyChar.ToString = "*" Then
            e.KeyChar = ""
        ElseIf e.KeyChar.ToString = "?" Then
            e.KeyChar = ""
        ElseIf e.KeyChar.ToString = "<" Then
            e.KeyChar = ""
        ElseIf e.KeyChar.ToString = ">" Then
            e.KeyChar = ""
        ElseIf e.KeyChar.ToString = ">" Then
            e.KeyChar = ""
        ElseIf e.KeyChar.ToString = "|" Then
            e.KeyChar = ""
        ElseIf Asc(e.KeyChar) = 34 Then
            e.KeyChar = ""
        End If
    End Sub

End Class