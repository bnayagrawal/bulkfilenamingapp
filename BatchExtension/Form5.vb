Public Class frmRemoveExt
    Public removeAll As Boolean
    Public itemsToSkip() As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim itemExists As Boolean
        If txtExtName.TextLength > 0 Then
            For i As Integer = 0 To lbxItemsToSkip.Items.Count - 1
                If txtExtName.Text.ToLower = lbxItemsToSkip.Items.Item(i).ToString Then
                    itemExists = True
                End If
            Next
            If Not itemExists Then
                lbxItemsToSkip.Items.Add(txtExtName.Text)
            Else
                MsgBox("Item already exists!", vbOKOnly + vbCritical)
            End If
            lblTotalItems.Text = "Total item(s) : " & lbxItemsToSkip.Items.Count
        End If
    End Sub

    Private Sub lbxItemsToSkip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxItemsToSkip.SelectedIndexChanged
        If lbxItemsToSkip.SelectedItems.Count > 0 Then
            btnRemoveItem.Enabled = True
        Else
            btnRemoveItem.Enabled = Not Enabled
        End If
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        For i As Integer = 0 To lbxItemsToSkip.SelectedItems.Count - 1
            lbxItemsToSkip.Items.Remove(lbxItemsToSkip.SelectedItem)
        Next i
        lblTotalItems.Text = "Total item(s) : " & lbxItemsToSkip.Items.Count
    End Sub

    Private Sub btnRemoveAllItems_Click(sender As Object, e As EventArgs) Handles btnRemoveAllItems.Click
        If lbxItemsToSkip.Items.Count > 0 Then
            If MsgBox("Remove all item(s)?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then
                lbxItemsToSkip.Items.Clear()
                btnRemoveItem.Enabled = False
                lblTotalItems.Text = "Total item(s) : " & lbxItemsToSkip.Items.Count
            End If
        End If
    End Sub

    Private Sub txtExtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExtName.KeyPress

        If (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Then
            e.KeyChar = e.KeyChar
        ElseIf (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Then
            e.KeyChar = e.KeyChar
        ElseIf (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
            e.KeyChar = e.KeyChar
        ElseIf (Asc(e.KeyChar)) = 8 Then
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            btnAddItem.PerformClick()
            txtExtName.Clear()
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub chkRemoveAllExtTypes_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemoveAllExtTypes.CheckedChanged
        If chkRemoveAllExtTypes.Checked Then
            gbxFilesToSkip.Enabled = Not Enabled
        Else
            gbxFilesToSkip.Enabled = True
        End If
        removeAll = chkRemoveAllExtTypes.Checked
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If lbxItemsToSkip.Items.Count > 0 Then
            ReDim itemsToSkip(lbxItemsToSkip.Items.Count - 1)
            For i As Integer = 0 To lbxItemsToSkip.Items.Count - 1
                itemsToSkip(i) = lbxItemsToSkip.Items.Item(i)
            Next
            Me.DialogResult = DialogResult.Yes
        Else
            chkRemoveAllExtTypes.Checked = True
            MsgBox("You haven't added any item!" + Chr(13) + "All slected file(s) extension will be removed", vbOKOnly + vbCritical)
            Me.DialogResult = DialogResult.Yes
        End If
    End Sub
End Class