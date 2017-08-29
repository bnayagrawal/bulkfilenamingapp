Public Class frmChangeExtension
    Public newExtention As String
    Public skipExtension As String
    Public appendExtension As Boolean
    Public isCanceled As Boolean
    Public itemsToSkip() As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        isCanceled = True
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtExtName.Text.Length > 0 Then
            If chkJustAppendExtName.Checked Then
                appendExtension = True
            Else
                appendExtension = False
            End If
            newExtention = txtExtName.Text

            If lbxFilesToSkip.Items.Count > 0 Then
                ReDim itemsToSkip(lbxFilesToSkip.Items.Count - 1)
                For i As Integer = 0 To lbxFilesToSkip.Items.Count - 1
                    itemsToSkip(i) = lbxFilesToSkip.Items.Item(i)
                Next
                Me.DialogResult = DialogResult.Yes
            End If
            isCanceled = False
            Me.Close()
        Else
            MsgBox("New Extension name can't be empty !", vbOKOnly + vbCritical)
            isCanceled = True
        End If
    End Sub


    Private Sub txtExtName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Then
            e.KeyChar = e.KeyChar
        ElseIf (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Then
            e.KeyChar = e.KeyChar
        ElseIf (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
            e.KeyChar = e.KeyChar
        ElseIf (Asc(e.KeyChar)) = 8 Then
            e.KeyChar = e.KeyChar
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub chkJustAppendExtName_CheckedChanged(sender As Object, e As EventArgs) Handles chkJustAppendExtName.CheckedChanged
        If chkJustAppendExtName.Checked Then
            appendExtension = True
        Else
            appendExtension = False
        End If
    End Sub


    Private Sub txtExtNameSkip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExtNameSkip.KeyPress
        If (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Then
            e.KeyChar = e.KeyChar
        ElseIf (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Then
            e.KeyChar = e.KeyChar
        ElseIf (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
            e.KeyChar = e.KeyChar
        ElseIf (Asc(e.KeyChar)) = 8 Then
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            btnAdd.PerformClick()
            txtExtNameSkip.Clear()
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim itemExists As Boolean
        If txtExtNameSkip.TextLength > 0 Then
            For i As Integer = 0 To lbxFilesToSkip.Items.Count - 1
                If txtExtNameSkip.Text.ToLower = lbxFilesToSkip.Items.Item(i).ToString Then
                    itemExists = True
                End If
            Next
            If Not itemExists Then
                lbxFilesToSkip.Items.Add(txtExtNameSkip.Text)
            Else
                MsgBox("Item already exists!", vbOKOnly + vbCritical)
            End If
            lblTotalItems.Text = "Total item(s) : " & lbxFilesToSkip.Items.Count
        End If
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        For i As Integer = 0 To lbxFilesToSkip.SelectedItems.Count - 1
            lbxFilesToSkip.Items.Remove(lbxFilesToSkip.SelectedItem)
        Next i
        lblTotalItems.Text = "Total item(s) : " & lbxFilesToSkip.Items.Count
    End Sub

    Private Sub btnRemoveAllItems_Click(sender As Object, e As EventArgs) Handles btnRemoveAllItems.Click
        If lbxFilesToSkip.Items.Count > 0 Then
            If MsgBox("Remove all item(s)?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then
                lbxFilesToSkip.Items.Clear()
                lblTotalItems.Text = "Total item(s) : " & lbxFilesToSkip.Items.Count
            End If
        End If
    End Sub

    Private Sub lbxFilesToSkip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxFilesToSkip.SelectedIndexChanged
        If lbxFilesToSkip.SelectedItems.Count > 0 Then
            btnRemoveItem.Enabled = True
        Else
            btnRemoveItem.Enabled = Not Enabled
        End If
    End Sub

End Class