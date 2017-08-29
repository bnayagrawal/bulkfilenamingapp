Public Class frmRename
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        frmMain.randomFileName()
        Me.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtStringToAppend.TextLength = 0 Then
            MsgBox("String cant be empty!", vbCritical)
            Exit Sub
        End If

        Close()
        If rbtnAfter.Checked Then
            Me.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            frmMain.append_prepend(txtStringToAppend.Text, 1)
            Me.Enabled = True
            Me.Cursor = Cursors.Default
        Else
            Me.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            frmMain.append_prepend(txtStringToAppend.Text, 0)
            Me.Enabled = True
            Me.Cursor = Cursors.Default
        End If
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        If rbtnCapitalize.Checked Then
            frmMain.formatCase(2)
        ElseIf rbtnLowerCase.Checked Then
            frmMain.formatCase(1)
        Else
            frmMain.formatCase(0)
        End If
        Me.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub rbtnAtPosition_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAtPosition.CheckedChanged
        If rbtnAtPosition.Checked Then
            lblAtPosition.Enabled = True
            nudAtPosition.Enabled = True
        Else
            lblAtPosition.Enabled = Not Enabled
            nudAtPosition.Enabled = Not Enabled
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        If rbtnAfterName.Checked Then
            frmMain.autoNumber(0, nudNumberStartFrom.Value, nudAtPosition.Value)
        ElseIf rbtnBeforeName.Checked Then
            frmMain.autoNumber(1, nudNumberStartFrom.Value, nudAtPosition.Value)
        ElseIf rbtnOnlyKeep.Checked Then
            frmMain.autoNumber(2, nudNumberStartFrom.Value, nudAtPosition.Value)
        Else
            frmMain.autoNumber(3, nudNumberStartFrom.Value, nudAtPosition.Value)
        End If
        Me.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        If rbtnFromBegening.Checked Then
            frmMain.deleteCharacter(0, nudRemoveCharacter.Value)
        Else
            frmMain.deleteCharacter(1, nudRemoveCharacter.Value)
        End If

        Me.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub rbtnPosition_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPosition.CheckedChanged
        If rbtnPosition.Checked Then
            lblInsertAtPosition.Enabled = True
            nudInsertAtPos.Enabled = True
        Else
            lblInsertAtPosition.Enabled = False
            nudInsertAtPos.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnInsertText.Click
        If txtStringToInsert.TextLength = 0 Then
            MsgBox("The text to insert cant be empty!", vbCritical)
            Exit Sub
        End If

        If rbtnAfterName.Checked Or rbtnBeforeName.Checked Then
            If txtString.TextLength = 0 Then
                MsgBox("The string cant be empty!", vbCritical)
                Exit Sub
            End If
        End If

        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        If rbtnBeforeString.Checked Then
            frmMain.insertText(txtStringToInsert.Text, 0,, txtString.Text.Trim)
        ElseIf rbtnAfterString.Checked Then
            frmMain.insertText(txtStringToInsert.Text, 1,, txtString.Text.Trim)
        Else
            frmMain.insertText(txtStringToInsert.Text, 2, nudInsertAtPos.Value, txtString.Text.Trim)
        End If

        Me.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnRemoveText.Click
        If txtStringToRemove.TextLength = 0 Then
            MsgBox("String to remove cant be empty!", vbCritical)
            Exit Sub
        End If

        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        frmMain.removeText(txtStringToRemove.Text.Trim)

        Me.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtStringToInsert_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStringToInsert.KeyPress
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

    Private Sub txtString_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtString.KeyPress
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

    Private Sub txtStringToRemove_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStringToRemove.KeyPress
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
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFind.KeyPress
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

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReplaceWith.KeyPress
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

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        If txtFind.TextLength = 0 Then
            MsgBox("String to remove cant be empty!", vbCritical)
            Exit Sub
        End If

        If txtReplaceWith.Text.Length = 0 Then
            MsgBox("String to replace cant be empty!", vbCritical)
            Exit Sub
        End If

        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        frmMain.replaceString(txtFind.Text.Trim, txtReplaceWith.Text)

        Me.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

End Class