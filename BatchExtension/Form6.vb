Public Class frmListViewOptions
    Private Sub frmListViewOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbxFilesToSkip.Items.Clear()
        chkAllowAdding.Checked = frmMain.allowFileFromDifLoc
        chkAllowSorting.Checked = frmMain.allowSort
        If frmMain.lvItemsToSkip IsNot Nothing Then
            For Each item In frmMain.lvItemsToSkip
                If item IsNot Nothing Then
                    lbxFilesToSkip.Items.Add(item)
                End If
            Next
        End If
        lblTotalItems.Text = "Total item(s) : " & lbxFilesToSkip.Items.Count
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub chkSortItems_CheckedChanged(sender As Object, e As EventArgs) Handles chkSortItems.CheckedChanged
        If chkSortItems.Checked Then
            lbxFilesToSkip.Sorted = True
        Else
            lbxFilesToSkip.Sorted = False
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
            btnAdd.PerformClick()
            txtExtName.Clear()
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim itemExists As Boolean
        If txtExtName.TextLength > 0 Then
            For i As Integer = 0 To lbxFilesToSkip.Items.Count - 1
                If txtExtName.Text.ToLower = lbxFilesToSkip.Items.Item(i).ToString Then
                    itemExists = True
                End If
            Next
            If Not itemExists Then
                lbxFilesToSkip.Items.Add(txtExtName.Text)
            Else
                MsgBox("Item already exists!", vbOKOnly + vbCritical)
            End If
            lblTotalItems.Text = "Total item(s) : " & lbxFilesToSkip.Items.Count
        End If
    End Sub

    Private Sub btnRemoveAllItems_Click(sender As Object, e As EventArgs) Handles btnRemoveAllItems.Click
        If lbxFilesToSkip.Items.Count > 0 Then
            If MsgBox("Clear all item(s)?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then
                lbxFilesToSkip.Items.Clear()
                btnDeleteSelectedItem.Enabled = Not Enabled
                lblTotalItems.Text = "Total item(s) : " & lbxFilesToSkip.Items.Count
            End If
        End If
    End Sub

    Private Sub lbxFilesToSkip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxFilesToSkip.SelectedIndexChanged
        If lbxFilesToSkip.SelectedItems.Count > 0 Then
            btnDeleteSelectedItem.Enabled = Enabled
        Else
            btnDeleteSelectedItem.Enabled = Not Enabled
        End If
    End Sub

    Private Sub btnDeleteSelectedItem_Click(sender As Object, e As EventArgs) Handles btnDeleteSelectedItem.Click
        For i As Integer = 0 To lbxFilesToSkip.SelectedItems.Count - 1
            lbxFilesToSkip.Items.Remove(lbxFilesToSkip.SelectedItem)
        Next
        lblTotalItems.Text = "Total item(s) : " & lbxFilesToSkip.Items.Count
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If lbxFilesToSkip.Items.Count > 0 Then
            ReDim frmMain.lvItemsToSkip(lbxFilesToSkip.Items.Count - 1)
            For i As Integer = 0 To lbxFilesToSkip.Items.Count - 1
                frmMain.lvItemsToSkip(i) = lbxFilesToSkip.Items.Item(i)
            Next
        Else
            frmMain.lvItemsToSkip = Nothing
        End If

        frmMain.txtExcludeList.Clear()
        If frmMain.lvItemsToSkip IsNot Nothing Then
            For Each item In frmMain.lvItemsToSkip
                frmMain.txtExcludeList.AppendText(Chr(34) & item & Chr(34) & " ")
            Next
        End If

        frmMain.allowSort = chkAllowSorting.Checked
        frmMain.allowFileFromDifLoc = chkAllowAdding.Checked

        Me.Close()
    End Sub

End Class