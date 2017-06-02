Imports System.Windows.Forms

Public Class connectionManager
    Property _conns As connections
    Private _connsBinding As BindingSource
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

    Private Sub connectionManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _connsBinding = New BindingSource
            _connsBinding.DataSource = _conns.ToList

            DataGridView1.DataSource = _connsBinding
            DataGridView1.Refresh()


        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.ColumnIndex = 0 Then
                Dim frx As New setpassword

                If frx.ShowDialog = DialogResult.OK Then
                    Dim p As String = frx.pass

                    frx.Close()

                    _conns.Item(e.RowIndex).setPass(p)
                    DataGridView1.Refresh()
                End If
            End If

        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub
End Class
