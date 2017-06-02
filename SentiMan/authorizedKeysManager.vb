Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class authorizedKeysManager
    Property _keys As authorizedKeys
    Private _keysBinding As BindingSource

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Try
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim key As String = ""

            key = InputBox("Please paste the public key data from PuTTyGen", "Add authorizedKey")

            If key = "" Then Exit Sub

            If Regex.IsMatch(key, "\A^([^=]+==) (.+)$\z", RegexOptions.IgnoreCase Or RegexOptions.Multiline) Then
                Dim SplitArray As String()
                SplitArray = Regex.Split(key, "^([^=]+==) (.+)$", RegexOptions.IgnoreCase Or RegexOptions.Multiline)

                _keys.Add(New authorizedKey With {.description = SplitArray(2), .keyData = key})

                _keysBinding.DataSource = _keys.ToList

                DataGridView1.DataSource = _keysBinding
                DataGridView1.Refresh()
            Else
                MessageBox.Show("Incomplete public key data. Be sure to also fill ``key comment`` in PuTTyGen when creating a key.")
            End If
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub authorizedKeysManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _keysBinding = New BindingSource
            _keysBinding.DataSource = _keys.ToList

            DataGridView1.DataSource = _keysBinding
            DataGridView1.Refresh()

        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Try
            If MessageBox.Show(String.Format("Are you sure you want to delete {0}'s key?", e.Row.Cells(1).Value), "Delete key", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                e.Cancel = True
            End If
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        Try
            Dim d = (From k In _keys Where k.description = e.Row.Cells(1).Value.ToString Select k).FirstOrDefault

            If d IsNot Nothing Then
                _keys.Remove(d)
            End If

            _keysBinding.DataSource = _keys.ToList

            DataGridView1.DataSource = _keysBinding
            DataGridView1.Refresh()
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub
End Class
